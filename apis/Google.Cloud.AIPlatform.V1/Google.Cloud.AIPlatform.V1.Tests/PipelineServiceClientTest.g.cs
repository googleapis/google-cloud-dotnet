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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPipelineServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateTrainingPipelineRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline response = client.CreateTrainingPipeline(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrainingPipelineRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline responseCallSettings = await client.CreateTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.CreateTrainingPipelineAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrainingPipeline()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline response = client.CreateTrainingPipeline(request.Parent, request.TrainingPipeline);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrainingPipelineAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline responseCallSettings = await client.CreateTrainingPipelineAsync(request.Parent, request.TrainingPipeline, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.CreateTrainingPipelineAsync(request.Parent, request.TrainingPipeline, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrainingPipelineResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline response = client.CreateTrainingPipeline(request.ParentAsLocationName, request.TrainingPipeline);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrainingPipelineResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline responseCallSettings = await client.CreateTrainingPipelineAsync(request.ParentAsLocationName, request.TrainingPipeline, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.CreateTrainingPipelineAsync(request.ParentAsLocationName, request.TrainingPipeline, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrainingPipelineRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline response = client.GetTrainingPipeline(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrainingPipelineRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline responseCallSettings = await client.GetTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.GetTrainingPipelineAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrainingPipeline()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline response = client.GetTrainingPipeline(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrainingPipelineAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline responseCallSettings = await client.GetTrainingPipelineAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.GetTrainingPipelineAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrainingPipelineResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline response = client.GetTrainingPipeline(request.TrainingPipelineName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrainingPipelineResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
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
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            TrainingPipeline responseCallSettings = await client.GetTrainingPipelineAsync(request.TrainingPipelineName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.GetTrainingPipelineAsync(request.TrainingPipelineName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelTrainingPipelineRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelTrainingPipeline(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelTrainingPipelineRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelTrainingPipelineAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelTrainingPipeline()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelTrainingPipeline(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelTrainingPipelineAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelTrainingPipelineAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelTrainingPipelineAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelTrainingPipelineResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelTrainingPipeline(request.TrainingPipelineName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelTrainingPipelineResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelTrainingPipelineAsync(request.TrainingPipelineName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelTrainingPipelineAsync(request.TrainingPipelineName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
