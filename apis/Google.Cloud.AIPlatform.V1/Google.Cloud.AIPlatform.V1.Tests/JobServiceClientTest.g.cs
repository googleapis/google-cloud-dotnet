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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedJobServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCustomJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob response = client.CreateCustomJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob responseCallSettings = await client.CreateCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomJob responseCancellationToken = await client.CreateCustomJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob response = client.CreateCustomJob(request.Parent, request.CustomJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob responseCallSettings = await client.CreateCustomJobAsync(request.Parent, request.CustomJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomJob responseCancellationToken = await client.CreateCustomJobAsync(request.Parent, request.CustomJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob response = client.CreateCustomJob(request.ParentAsLocationName, request.CustomJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob responseCallSettings = await client.CreateCustomJobAsync(request.ParentAsLocationName, request.CustomJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomJob responseCancellationToken = await client.CreateCustomJobAsync(request.ParentAsLocationName, request.CustomJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob response = client.GetCustomJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob responseCallSettings = await client.GetCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomJob responseCancellationToken = await client.GetCustomJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob response = client.GetCustomJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob responseCallSettings = await client.GetCustomJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomJob responseCancellationToken = await client.GetCustomJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob response = client.GetCustomJob(request.CustomJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            CustomJob expectedResponse = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "display_name137f65c2",
                JobSpec = new CustomJobSpec(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            CustomJob responseCallSettings = await client.GetCustomJobAsync(request.CustomJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomJob responseCancellationToken = await client.GetCustomJobAsync(request.CustomJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelCustomJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelCustomJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelCustomJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelCustomJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelCustomJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelCustomJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelCustomJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelCustomJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelCustomJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelCustomJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelCustomJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelCustomJob(request.CustomJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelCustomJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelCustomJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelCustomJobAsync(request.CustomJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelCustomJobAsync(request.CustomJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataLabelingJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob response = client.CreateDataLabelingJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataLabelingJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataLabelingJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob responseCallSettings = await client.CreateDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataLabelingJob responseCancellationToken = await client.CreateDataLabelingJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataLabelingJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob response = client.CreateDataLabelingJob(request.Parent, request.DataLabelingJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataLabelingJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataLabelingJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob responseCallSettings = await client.CreateDataLabelingJobAsync(request.Parent, request.DataLabelingJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataLabelingJob responseCancellationToken = await client.CreateDataLabelingJobAsync(request.Parent, request.DataLabelingJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataLabelingJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob response = client.CreateDataLabelingJob(request.ParentAsLocationName, request.DataLabelingJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataLabelingJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataLabelingJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob responseCallSettings = await client.CreateDataLabelingJobAsync(request.ParentAsLocationName, request.DataLabelingJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataLabelingJob responseCancellationToken = await client.CreateDataLabelingJobAsync(request.ParentAsLocationName, request.DataLabelingJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataLabelingJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob response = client.GetDataLabelingJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataLabelingJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataLabelingJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob responseCallSettings = await client.GetDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataLabelingJob responseCancellationToken = await client.GetDataLabelingJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataLabelingJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob response = client.GetDataLabelingJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataLabelingJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataLabelingJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob responseCallSettings = await client.GetDataLabelingJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataLabelingJob responseCancellationToken = await client.GetDataLabelingJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataLabelingJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob response = client.GetDataLabelingJob(request.DataLabelingJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataLabelingJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            DataLabelingJob expectedResponse = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "display_name137f65c2",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 852414329,
                InstructionUri = "instruction_uri3b1c9f62",
                InputsSchemaUri = "inputs_schema_uri668b3ec5",
                Inputs = new wkt::Value(),
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnnotationLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelingProgress = 56913776,
                CurrentSpend = new gt::Money(),
                SpecialistPools =
                {
                    "specialist_pools5b9246a5",
                },
                EncryptionSpec = new EncryptionSpec(),
                ActiveLearningConfig = new ActiveLearningConfig(),
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataLabelingJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            DataLabelingJob responseCallSettings = await client.GetDataLabelingJobAsync(request.DataLabelingJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataLabelingJob responseCancellationToken = await client.GetDataLabelingJobAsync(request.DataLabelingJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelDataLabelingJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelDataLabelingJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelDataLabelingJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelDataLabelingJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelDataLabelingJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelDataLabelingJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelDataLabelingJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelDataLabelingJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelDataLabelingJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelDataLabelingJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDataLabelingJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelDataLabelingJob(request.DataLabelingJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelDataLabelingJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDataLabelingJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelDataLabelingJobAsync(request.DataLabelingJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelDataLabelingJobAsync(request.DataLabelingJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateHyperparameterTuningJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob response = client.CreateHyperparameterTuningJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateHyperparameterTuningJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HyperparameterTuningJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob responseCallSettings = await client.CreateHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HyperparameterTuningJob responseCancellationToken = await client.CreateHyperparameterTuningJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateHyperparameterTuningJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob response = client.CreateHyperparameterTuningJob(request.Parent, request.HyperparameterTuningJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateHyperparameterTuningJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HyperparameterTuningJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob responseCallSettings = await client.CreateHyperparameterTuningJobAsync(request.Parent, request.HyperparameterTuningJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HyperparameterTuningJob responseCancellationToken = await client.CreateHyperparameterTuningJobAsync(request.Parent, request.HyperparameterTuningJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateHyperparameterTuningJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob response = client.CreateHyperparameterTuningJob(request.ParentAsLocationName, request.HyperparameterTuningJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateHyperparameterTuningJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HyperparameterTuningJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob responseCallSettings = await client.CreateHyperparameterTuningJobAsync(request.ParentAsLocationName, request.HyperparameterTuningJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HyperparameterTuningJob responseCancellationToken = await client.CreateHyperparameterTuningJobAsync(request.ParentAsLocationName, request.HyperparameterTuningJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHyperparameterTuningJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob response = client.GetHyperparameterTuningJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHyperparameterTuningJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HyperparameterTuningJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob responseCallSettings = await client.GetHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HyperparameterTuningJob responseCancellationToken = await client.GetHyperparameterTuningJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHyperparameterTuningJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob response = client.GetHyperparameterTuningJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHyperparameterTuningJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HyperparameterTuningJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob responseCallSettings = await client.GetHyperparameterTuningJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HyperparameterTuningJob responseCancellationToken = await client.GetHyperparameterTuningJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHyperparameterTuningJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob response = client.GetHyperparameterTuningJob(request.HyperparameterTuningJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHyperparameterTuningJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            HyperparameterTuningJob expectedResponse = new HyperparameterTuningJob
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                MaxTrialCount = 1024715559,
                ParallelTrialCount = -517961398,
                MaxFailedTrialCount = -966014448,
                TrialJobSpec = new CustomJobSpec(),
                Trials = { new Trial(), },
                State = JobState.Paused,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HyperparameterTuningJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            HyperparameterTuningJob responseCallSettings = await client.GetHyperparameterTuningJobAsync(request.HyperparameterTuningJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HyperparameterTuningJob responseCancellationToken = await client.GetHyperparameterTuningJobAsync(request.HyperparameterTuningJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelHyperparameterTuningJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelHyperparameterTuningJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelHyperparameterTuningJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelHyperparameterTuningJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelHyperparameterTuningJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelHyperparameterTuningJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelHyperparameterTuningJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelHyperparameterTuningJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelHyperparameterTuningJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelHyperparameterTuningJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelHyperparameterTuningJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelHyperparameterTuningJob(request.HyperparameterTuningJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelHyperparameterTuningJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelHyperparameterTuningJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelHyperparameterTuningJobAsync(request.HyperparameterTuningJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelHyperparameterTuningJobAsync(request.HyperparameterTuningJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBatchPredictionJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.CreateBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob response = client.CreateBatchPredictionJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBatchPredictionJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.CreateBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchPredictionJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob responseCallSettings = await client.CreateBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchPredictionJob responseCancellationToken = await client.CreateBatchPredictionJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBatchPredictionJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.CreateBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob response = client.CreateBatchPredictionJob(request.Parent, request.BatchPredictionJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBatchPredictionJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.CreateBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchPredictionJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob responseCallSettings = await client.CreateBatchPredictionJobAsync(request.Parent, request.BatchPredictionJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchPredictionJob responseCancellationToken = await client.CreateBatchPredictionJobAsync(request.Parent, request.BatchPredictionJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBatchPredictionJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.CreateBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob response = client.CreateBatchPredictionJob(request.ParentAsLocationName, request.BatchPredictionJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBatchPredictionJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.CreateBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchPredictionJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob responseCallSettings = await client.CreateBatchPredictionJobAsync(request.ParentAsLocationName, request.BatchPredictionJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchPredictionJob responseCancellationToken = await client.CreateBatchPredictionJobAsync(request.ParentAsLocationName, request.BatchPredictionJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBatchPredictionJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.GetBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob response = client.GetBatchPredictionJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBatchPredictionJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.GetBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchPredictionJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob responseCallSettings = await client.GetBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchPredictionJob responseCancellationToken = await client.GetBatchPredictionJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBatchPredictionJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.GetBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob response = client.GetBatchPredictionJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBatchPredictionJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.GetBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchPredictionJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob responseCallSettings = await client.GetBatchPredictionJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchPredictionJob responseCancellationToken = await client.GetBatchPredictionJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBatchPredictionJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.GetBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob response = client.GetBatchPredictionJob(request.BatchPredictionJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBatchPredictionJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            BatchPredictionJob expectedResponse = new BatchPredictionJob
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
                DisplayName = "display_name137f65c2",
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictionJob.Types.InputConfig(),
                ModelParameters = new wkt::Value(),
                OutputConfig = new BatchPredictionJob.Types.OutputConfig(),
                DedicatedResources = new BatchDedicatedResources(),
                ManualBatchTuningParameters = new ManualBatchTuningParameters(),
                OutputInfo = new BatchPredictionJob.Types.OutputInfo(),
                State = JobState.Paused,
                Error = new gr::Status(),
                PartialFailures = { new gr::Status(), },
                ResourcesConsumed = new ResourcesConsumed(),
                CompletionStats = new CompletionStats(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GenerateExplanation = true,
                EncryptionSpec = new EncryptionSpec(),
                ExplanationSpec = new ExplanationSpec(),
                UnmanagedContainerModel = new UnmanagedContainerModel(),
            };
            mockGrpcClient.Setup(x => x.GetBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchPredictionJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            BatchPredictionJob responseCallSettings = await client.GetBatchPredictionJobAsync(request.BatchPredictionJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchPredictionJob responseCancellationToken = await client.GetBatchPredictionJobAsync(request.BatchPredictionJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelBatchPredictionJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelBatchPredictionJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelBatchPredictionJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelBatchPredictionJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelBatchPredictionJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelBatchPredictionJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelBatchPredictionJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelBatchPredictionJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelBatchPredictionJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelBatchPredictionJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelBatchPredictionJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelBatchPredictionJob(request.BatchPredictionJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelBatchPredictionJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelBatchPredictionJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelBatchPredictionJobAsync(request.BatchPredictionJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelBatchPredictionJobAsync(request.BatchPredictionJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateModelDeploymentMonitoringJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob response = client.CreateModelDeploymentMonitoringJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateModelDeploymentMonitoringJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelDeploymentMonitoringJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob responseCallSettings = await client.CreateModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelDeploymentMonitoringJob responseCancellationToken = await client.CreateModelDeploymentMonitoringJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateModelDeploymentMonitoringJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob response = client.CreateModelDeploymentMonitoringJob(request.Parent, request.ModelDeploymentMonitoringJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateModelDeploymentMonitoringJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelDeploymentMonitoringJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob responseCallSettings = await client.CreateModelDeploymentMonitoringJobAsync(request.Parent, request.ModelDeploymentMonitoringJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelDeploymentMonitoringJob responseCancellationToken = await client.CreateModelDeploymentMonitoringJobAsync(request.Parent, request.ModelDeploymentMonitoringJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateModelDeploymentMonitoringJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob response = client.CreateModelDeploymentMonitoringJob(request.ParentAsLocationName, request.ModelDeploymentMonitoringJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateModelDeploymentMonitoringJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelDeploymentMonitoringJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob responseCallSettings = await client.CreateModelDeploymentMonitoringJobAsync(request.ParentAsLocationName, request.ModelDeploymentMonitoringJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelDeploymentMonitoringJob responseCancellationToken = await client.CreateModelDeploymentMonitoringJobAsync(request.ParentAsLocationName, request.ModelDeploymentMonitoringJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelDeploymentMonitoringJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob response = client.GetModelDeploymentMonitoringJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelDeploymentMonitoringJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelDeploymentMonitoringJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob responseCallSettings = await client.GetModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelDeploymentMonitoringJob responseCancellationToken = await client.GetModelDeploymentMonitoringJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelDeploymentMonitoringJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob response = client.GetModelDeploymentMonitoringJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelDeploymentMonitoringJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelDeploymentMonitoringJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob responseCallSettings = await client.GetModelDeploymentMonitoringJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelDeploymentMonitoringJob responseCancellationToken = await client.GetModelDeploymentMonitoringJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelDeploymentMonitoringJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob response = client.GetModelDeploymentMonitoringJob(request.ModelDeploymentMonitoringJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelDeploymentMonitoringJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            ModelDeploymentMonitoringJob expectedResponse = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "display_name137f65c2",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Paused,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig(),
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig(),
                LoggingSamplingStrategy = new SamplingStrategy(),
                PredictInstanceSchemaUri = "predict_instance_schema_uri9d43c294",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                NextScheduleTime = new wkt::Timestamp(),
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig(),
                AnalysisInstanceSchemaUri = "analysis_instance_schema_urid527dfc5",
                LogTtl = new wkt::Duration(),
                SamplePredictInstance = new wkt::Value(),
                StatsAnomaliesBaseDirectory = new GcsDestination(),
                EncryptionSpec = new EncryptionSpec(),
                EnableMonitoringPipelineLogs = true,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelDeploymentMonitoringJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ModelDeploymentMonitoringJob responseCallSettings = await client.GetModelDeploymentMonitoringJobAsync(request.ModelDeploymentMonitoringJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelDeploymentMonitoringJob responseCancellationToken = await client.GetModelDeploymentMonitoringJobAsync(request.ModelDeploymentMonitoringJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseModelDeploymentMonitoringJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseModelDeploymentMonitoringJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseModelDeploymentMonitoringJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseModelDeploymentMonitoringJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseModelDeploymentMonitoringJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseModelDeploymentMonitoringJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseModelDeploymentMonitoringJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseModelDeploymentMonitoringJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseModelDeploymentMonitoringJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseModelDeploymentMonitoringJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseModelDeploymentMonitoringJob(request.ModelDeploymentMonitoringJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseModelDeploymentMonitoringJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseModelDeploymentMonitoringJobAsync(request.ModelDeploymentMonitoringJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseModelDeploymentMonitoringJobAsync(request.ModelDeploymentMonitoringJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeModelDeploymentMonitoringJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeModelDeploymentMonitoringJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeModelDeploymentMonitoringJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeModelDeploymentMonitoringJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeModelDeploymentMonitoringJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeModelDeploymentMonitoringJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeModelDeploymentMonitoringJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeModelDeploymentMonitoringJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeModelDeploymentMonitoringJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeModelDeploymentMonitoringJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeModelDeploymentMonitoringJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeModelDeploymentMonitoringJob(request.ModelDeploymentMonitoringJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeModelDeploymentMonitoringJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeModelDeploymentMonitoringJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeModelDeploymentMonitoringJobAsync(request.ModelDeploymentMonitoringJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeModelDeploymentMonitoringJobAsync(request.ModelDeploymentMonitoringJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
