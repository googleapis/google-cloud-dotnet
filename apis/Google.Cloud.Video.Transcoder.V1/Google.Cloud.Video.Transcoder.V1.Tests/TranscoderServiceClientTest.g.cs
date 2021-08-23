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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Video.Transcoder.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTranscoderServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJob()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.Parent, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.Parent, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.Parent, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsLocationName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig(),
                State = Job.Types.ProcessingState.Succeeded,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                TtlAfterCompletionDays = 1495978457,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJob()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.JobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.JobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTemplateRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.CreateJobTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTemplateRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.CreateJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.CreateJobTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTemplate()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.CreateJobTemplate(request.Parent, request.JobTemplate, request.JobTemplateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTemplateAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.CreateJobTemplateAsync(request.Parent, request.JobTemplate, request.JobTemplateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.CreateJobTemplateAsync(request.Parent, request.JobTemplate, request.JobTemplateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTemplateResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.CreateJobTemplate(request.ParentAsLocationName, request.JobTemplate, request.JobTemplateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTemplateResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.CreateJobTemplateAsync(request.ParentAsLocationName, request.JobTemplate, request.JobTemplateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.CreateJobTemplateAsync(request.ParentAsLocationName, request.JobTemplate, request.JobTemplateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTemplateRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.GetJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.GetJobTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTemplateRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.GetJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.GetJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.GetJobTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTemplate()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.GetJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.GetJobTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTemplateAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.GetJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.GetJobTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.GetJobTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTemplateResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.GetJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.GetJobTemplate(request.JobTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTemplateResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig(),
            };
            mockGrpcClient.Setup(x => x.GetJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.GetJobTemplateAsync(request.JobTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.GetJobTemplateAsync(request.JobTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTemplateRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTemplateRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTemplate()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTemplate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTemplateAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTemplateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTemplateResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTemplate(request.JobTemplateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTemplateResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTemplateAsync(request.JobTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTemplateAsync(request.JobTemplateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
