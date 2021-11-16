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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTensorboardServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetTensorboardRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            Tensorboard expectedResponse = new Tensorboard
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RunCount = 976805878,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                BlobStoragePathPrefix = "blob_storage_path_prefix3e8df409",
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            Tensorboard response = client.GetTensorboard(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            Tensorboard expectedResponse = new Tensorboard
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RunCount = 976805878,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                BlobStoragePathPrefix = "blob_storage_path_prefix3e8df409",
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tensorboard>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            Tensorboard responseCallSettings = await client.GetTensorboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tensorboard responseCancellationToken = await client.GetTensorboardAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboard()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            Tensorboard expectedResponse = new Tensorboard
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RunCount = 976805878,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                BlobStoragePathPrefix = "blob_storage_path_prefix3e8df409",
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            Tensorboard response = client.GetTensorboard(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            Tensorboard expectedResponse = new Tensorboard
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RunCount = 976805878,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                BlobStoragePathPrefix = "blob_storage_path_prefix3e8df409",
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tensorboard>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            Tensorboard responseCallSettings = await client.GetTensorboardAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tensorboard responseCancellationToken = await client.GetTensorboardAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            Tensorboard expectedResponse = new Tensorboard
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RunCount = 976805878,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                BlobStoragePathPrefix = "blob_storage_path_prefix3e8df409",
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            Tensorboard response = client.GetTensorboard(request.TensorboardName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            Tensorboard expectedResponse = new Tensorboard
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RunCount = 976805878,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                BlobStoragePathPrefix = "blob_storage_path_prefix3e8df409",
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tensorboard>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            Tensorboard responseCallSettings = await client.GetTensorboardAsync(request.TensorboardName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tensorboard responseCancellationToken = await client.GetTensorboardAsync(request.TensorboardName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardExperimentRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "tensorboard_experiment_id23a3df56",
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.CreateTensorboardExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardExperimentRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "tensorboard_experiment_id23a3df56",
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.CreateTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.CreateTensorboardExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardExperiment()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "tensorboard_experiment_id23a3df56",
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.CreateTensorboardExperiment(request.Parent, request.TensorboardExperiment, request.TensorboardExperimentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardExperimentAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "tensorboard_experiment_id23a3df56",
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.CreateTensorboardExperimentAsync(request.Parent, request.TensorboardExperiment, request.TensorboardExperimentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.CreateTensorboardExperimentAsync(request.Parent, request.TensorboardExperiment, request.TensorboardExperimentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardExperimentResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "tensorboard_experiment_id23a3df56",
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.CreateTensorboardExperiment(request.ParentAsTensorboardExperimentName, request.TensorboardExperiment, request.TensorboardExperimentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardExperimentResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "tensorboard_experiment_id23a3df56",
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.CreateTensorboardExperimentAsync(request.ParentAsTensorboardExperimentName, request.TensorboardExperiment, request.TensorboardExperimentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.CreateTensorboardExperimentAsync(request.ParentAsTensorboardExperimentName, request.TensorboardExperiment, request.TensorboardExperimentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardExperimentRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.GetTensorboardExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardExperimentRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.GetTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.GetTensorboardExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardExperiment()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.GetTensorboardExperiment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardExperimentAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.GetTensorboardExperimentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.GetTensorboardExperimentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardExperimentResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.GetTensorboardExperiment(request.TensorboardExperimentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardExperimentResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.GetTensorboardExperimentAsync(request.TensorboardExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.GetTensorboardExperimentAsync(request.TensorboardExperimentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTensorboardExperimentRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardExperimentRequest request = new UpdateTensorboardExperimentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardExperiment = new TensorboardExperiment(),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.UpdateTensorboardExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTensorboardExperimentRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardExperimentRequest request = new UpdateTensorboardExperimentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardExperiment = new TensorboardExperiment(),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.UpdateTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.UpdateTensorboardExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTensorboardExperiment()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardExperimentRequest request = new UpdateTensorboardExperimentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardExperiment = new TensorboardExperiment(),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment response = client.UpdateTensorboardExperiment(request.TensorboardExperiment, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTensorboardExperimentAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardExperimentRequest request = new UpdateTensorboardExperimentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardExperiment = new TensorboardExperiment(),
            };
            TensorboardExperiment expectedResponse = new TensorboardExperiment
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Source = "sourcef438cd36",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardExperiment responseCallSettings = await client.UpdateTensorboardExperimentAsync(request.TensorboardExperiment, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardExperiment responseCancellationToken = await client.UpdateTensorboardExperimentAsync(request.TensorboardExperiment, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardRunRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "tensorboard_run_id476e8a40",
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.CreateTensorboardRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardRunRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "tensorboard_run_id476e8a40",
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.CreateTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.CreateTensorboardRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardRun()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "tensorboard_run_id476e8a40",
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.CreateTensorboardRun(request.Parent, request.TensorboardRun, request.TensorboardRunId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardRunAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "tensorboard_run_id476e8a40",
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.CreateTensorboardRunAsync(request.Parent, request.TensorboardRun, request.TensorboardRunId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.CreateTensorboardRunAsync(request.Parent, request.TensorboardRun, request.TensorboardRunId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardRunResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "tensorboard_run_id476e8a40",
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.CreateTensorboardRun(request.ParentAsTensorboardRunName, request.TensorboardRun, request.TensorboardRunId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardRunResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "tensorboard_run_id476e8a40",
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.CreateTensorboardRunAsync(request.ParentAsTensorboardRunName, request.TensorboardRun, request.TensorboardRunId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.CreateTensorboardRunAsync(request.ParentAsTensorboardRunName, request.TensorboardRun, request.TensorboardRunId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateTensorboardRunsRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            BatchCreateTensorboardRunsResponse expectedResponse = new BatchCreateTensorboardRunsResponse
            {
                TensorboardRuns =
                {
                    new TensorboardRun(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardRunsResponse response = client.BatchCreateTensorboardRuns(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateTensorboardRunsRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            BatchCreateTensorboardRunsResponse expectedResponse = new BatchCreateTensorboardRunsResponse
            {
                TensorboardRuns =
                {
                    new TensorboardRun(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateTensorboardRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardRunsResponse responseCallSettings = await client.BatchCreateTensorboardRunsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateTensorboardRunsResponse responseCancellationToken = await client.BatchCreateTensorboardRunsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateTensorboardRuns()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            BatchCreateTensorboardRunsResponse expectedResponse = new BatchCreateTensorboardRunsResponse
            {
                TensorboardRuns =
                {
                    new TensorboardRun(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardRunsResponse response = client.BatchCreateTensorboardRuns(request.Parent, request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateTensorboardRunsAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            BatchCreateTensorboardRunsResponse expectedResponse = new BatchCreateTensorboardRunsResponse
            {
                TensorboardRuns =
                {
                    new TensorboardRun(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateTensorboardRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardRunsResponse responseCallSettings = await client.BatchCreateTensorboardRunsAsync(request.Parent, request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateTensorboardRunsResponse responseCancellationToken = await client.BatchCreateTensorboardRunsAsync(request.Parent, request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateTensorboardRunsResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            BatchCreateTensorboardRunsResponse expectedResponse = new BatchCreateTensorboardRunsResponse
            {
                TensorboardRuns =
                {
                    new TensorboardRun(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardRunsResponse response = client.BatchCreateTensorboardRuns(request.ParentAsTensorboardExperimentName, request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateTensorboardRunsResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            BatchCreateTensorboardRunsResponse expectedResponse = new BatchCreateTensorboardRunsResponse
            {
                TensorboardRuns =
                {
                    new TensorboardRun(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateTensorboardRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardRunsResponse responseCallSettings = await client.BatchCreateTensorboardRunsAsync(request.ParentAsTensorboardExperimentName, request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateTensorboardRunsResponse responseCancellationToken = await client.BatchCreateTensorboardRunsAsync(request.ParentAsTensorboardExperimentName, request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardRunRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.GetTensorboardRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardRunRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.GetTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.GetTensorboardRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardRun()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.GetTensorboardRun(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardRunAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.GetTensorboardRunAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.GetTensorboardRunAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardRunResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.GetTensorboardRun(request.TensorboardRunName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardRunResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.GetTensorboardRunAsync(request.TensorboardRunName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.GetTensorboardRunAsync(request.TensorboardRunName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTensorboardRunRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardRunRequest request = new UpdateTensorboardRunRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardRun = new TensorboardRun(),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.UpdateTensorboardRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTensorboardRunRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardRunRequest request = new UpdateTensorboardRunRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardRun = new TensorboardRun(),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.UpdateTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.UpdateTensorboardRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTensorboardRun()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardRunRequest request = new UpdateTensorboardRunRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardRun = new TensorboardRun(),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun response = client.UpdateTensorboardRun(request.TensorboardRun, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTensorboardRunAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardRunRequest request = new UpdateTensorboardRunRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardRun = new TensorboardRun(),
            };
            TensorboardRun expectedResponse = new TensorboardRun
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardRun responseCallSettings = await client.UpdateTensorboardRunAsync(request.TensorboardRun, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardRun responseCancellationToken = await client.UpdateTensorboardRunAsync(request.TensorboardRun, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateTensorboardTimeSeriesRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            BatchCreateTensorboardTimeSeriesResponse expectedResponse = new BatchCreateTensorboardTimeSeriesResponse
            {
                TensorboardTimeSeries =
                {
                    new TensorboardTimeSeries(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardTimeSeriesResponse response = client.BatchCreateTensorboardTimeSeries(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateTensorboardTimeSeriesRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            BatchCreateTensorboardTimeSeriesResponse expectedResponse = new BatchCreateTensorboardTimeSeriesResponse
            {
                TensorboardTimeSeries =
                {
                    new TensorboardTimeSeries(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateTensorboardTimeSeriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardTimeSeriesResponse responseCallSettings = await client.BatchCreateTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateTensorboardTimeSeriesResponse responseCancellationToken = await client.BatchCreateTensorboardTimeSeriesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateTensorboardTimeSeries()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            BatchCreateTensorboardTimeSeriesResponse expectedResponse = new BatchCreateTensorboardTimeSeriesResponse
            {
                TensorboardTimeSeries =
                {
                    new TensorboardTimeSeries(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardTimeSeriesResponse response = client.BatchCreateTensorboardTimeSeries(request.Parent, request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateTensorboardTimeSeriesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            BatchCreateTensorboardTimeSeriesResponse expectedResponse = new BatchCreateTensorboardTimeSeriesResponse
            {
                TensorboardTimeSeries =
                {
                    new TensorboardTimeSeries(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateTensorboardTimeSeriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardTimeSeriesResponse responseCallSettings = await client.BatchCreateTensorboardTimeSeriesAsync(request.Parent, request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateTensorboardTimeSeriesResponse responseCancellationToken = await client.BatchCreateTensorboardTimeSeriesAsync(request.Parent, request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateTensorboardTimeSeriesResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            BatchCreateTensorboardTimeSeriesResponse expectedResponse = new BatchCreateTensorboardTimeSeriesResponse
            {
                TensorboardTimeSeries =
                {
                    new TensorboardTimeSeries(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardTimeSeriesResponse response = client.BatchCreateTensorboardTimeSeries(request.ParentAsTensorboardExperimentName, request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateTensorboardTimeSeriesResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            BatchCreateTensorboardTimeSeriesResponse expectedResponse = new BatchCreateTensorboardTimeSeriesResponse
            {
                TensorboardTimeSeries =
                {
                    new TensorboardTimeSeries(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchCreateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateTensorboardTimeSeriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateTensorboardTimeSeriesResponse responseCallSettings = await client.BatchCreateTensorboardTimeSeriesAsync(request.ParentAsTensorboardExperimentName, request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateTensorboardTimeSeriesResponse responseCancellationToken = await client.BatchCreateTensorboardTimeSeriesAsync(request.ParentAsTensorboardExperimentName, request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardTimeSeriesRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
                TensorboardTimeSeriesId = "tensorboard_time_series_id8cb7881c",
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.CreateTensorboardTimeSeries(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardTimeSeriesRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
                TensorboardTimeSeriesId = "tensorboard_time_series_id8cb7881c",
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.CreateTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.CreateTensorboardTimeSeriesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardTimeSeries()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.CreateTensorboardTimeSeries(request.Parent, request.TensorboardTimeSeries);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardTimeSeriesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.CreateTensorboardTimeSeriesAsync(request.Parent, request.TensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.CreateTensorboardTimeSeriesAsync(request.Parent, request.TensorboardTimeSeries, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTensorboardTimeSeriesResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.CreateTensorboardTimeSeries(request.ParentAsTensorboardTimeSeriesName, request.TensorboardTimeSeries);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTensorboardTimeSeriesResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.CreateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.CreateTensorboardTimeSeriesAsync(request.ParentAsTensorboardTimeSeriesName, request.TensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.CreateTensorboardTimeSeriesAsync(request.ParentAsTensorboardTimeSeriesName, request.TensorboardTimeSeries, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardTimeSeriesRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.GetTensorboardTimeSeries(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardTimeSeriesRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.GetTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.GetTensorboardTimeSeriesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardTimeSeries()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.GetTensorboardTimeSeries(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardTimeSeriesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.GetTensorboardTimeSeriesAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.GetTensorboardTimeSeriesAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorboardTimeSeriesResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.GetTensorboardTimeSeries(request.TensorboardTimeSeriesName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorboardTimeSeriesResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.GetTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.GetTensorboardTimeSeriesAsync(request.TensorboardTimeSeriesName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.GetTensorboardTimeSeriesAsync(request.TensorboardTimeSeriesName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTensorboardTimeSeriesRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardTimeSeriesRequest request = new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.UpdateTensorboardTimeSeries(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTensorboardTimeSeriesRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardTimeSeriesRequest request = new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.UpdateTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.UpdateTensorboardTimeSeriesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTensorboardTimeSeries()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardTimeSeriesRequest request = new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries response = client.UpdateTensorboardTimeSeries(request.TensorboardTimeSeries, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTensorboardTimeSeriesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTensorboardTimeSeriesRequest request = new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = new wkt::FieldMask(),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            TensorboardTimeSeries expectedResponse = new TensorboardTimeSeries
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                PluginName = "plugin_namefc8f5357",
                PluginData = proto::ByteString.CopyFromUtf8("plugin_data61edbb6d"),
                Metadata = new TensorboardTimeSeries.Types.Metadata(),
            };
            mockGrpcClient.Setup(x => x.UpdateTensorboardTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorboardTimeSeries>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            TensorboardTimeSeries responseCallSettings = await client.UpdateTensorboardTimeSeriesAsync(request.TensorboardTimeSeries, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorboardTimeSeries responseCancellationToken = await client.UpdateTensorboardTimeSeriesAsync(request.TensorboardTimeSeries, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchReadTensorboardTimeSeriesDataRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                TimeSeriesAsTensorboardTimeSeriesNames =
                {
                    TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                },
            };
            BatchReadTensorboardTimeSeriesDataResponse expectedResponse = new BatchReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchReadTensorboardTimeSeriesData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchReadTensorboardTimeSeriesDataResponse response = client.BatchReadTensorboardTimeSeriesData(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchReadTensorboardTimeSeriesDataRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                TimeSeriesAsTensorboardTimeSeriesNames =
                {
                    TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                },
            };
            BatchReadTensorboardTimeSeriesDataResponse expectedResponse = new BatchReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchReadTensorboardTimeSeriesDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchReadTensorboardTimeSeriesDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchReadTensorboardTimeSeriesDataResponse responseCallSettings = await client.BatchReadTensorboardTimeSeriesDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchReadTensorboardTimeSeriesDataResponse responseCancellationToken = await client.BatchReadTensorboardTimeSeriesDataAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchReadTensorboardTimeSeriesData()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            BatchReadTensorboardTimeSeriesDataResponse expectedResponse = new BatchReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchReadTensorboardTimeSeriesData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchReadTensorboardTimeSeriesDataResponse response = client.BatchReadTensorboardTimeSeriesData(request.Tensorboard);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchReadTensorboardTimeSeriesDataAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            BatchReadTensorboardTimeSeriesDataResponse expectedResponse = new BatchReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchReadTensorboardTimeSeriesDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchReadTensorboardTimeSeriesDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchReadTensorboardTimeSeriesDataResponse responseCallSettings = await client.BatchReadTensorboardTimeSeriesDataAsync(request.Tensorboard, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchReadTensorboardTimeSeriesDataResponse responseCancellationToken = await client.BatchReadTensorboardTimeSeriesDataAsync(request.Tensorboard, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchReadTensorboardTimeSeriesDataResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            BatchReadTensorboardTimeSeriesDataResponse expectedResponse = new BatchReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchReadTensorboardTimeSeriesData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchReadTensorboardTimeSeriesDataResponse response = client.BatchReadTensorboardTimeSeriesData(request.TensorboardAsTensorboardName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchReadTensorboardTimeSeriesDataResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            BatchReadTensorboardTimeSeriesDataResponse expectedResponse = new BatchReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchReadTensorboardTimeSeriesDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchReadTensorboardTimeSeriesDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            BatchReadTensorboardTimeSeriesDataResponse responseCallSettings = await client.BatchReadTensorboardTimeSeriesDataAsync(request.TensorboardAsTensorboardName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchReadTensorboardTimeSeriesDataResponse responseCancellationToken = await client.BatchReadTensorboardTimeSeriesDataAsync(request.TensorboardAsTensorboardName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadTensorboardTimeSeriesDataRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                MaxDataPoints = -1780885567,
                Filter = "filtere47ac9b2",
            };
            ReadTensorboardTimeSeriesDataResponse expectedResponse = new ReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData = new TimeSeriesData(),
            };
            mockGrpcClient.Setup(x => x.ReadTensorboardTimeSeriesData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            ReadTensorboardTimeSeriesDataResponse response = client.ReadTensorboardTimeSeriesData(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadTensorboardTimeSeriesDataRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                MaxDataPoints = -1780885567,
                Filter = "filtere47ac9b2",
            };
            ReadTensorboardTimeSeriesDataResponse expectedResponse = new ReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData = new TimeSeriesData(),
            };
            mockGrpcClient.Setup(x => x.ReadTensorboardTimeSeriesDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadTensorboardTimeSeriesDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            ReadTensorboardTimeSeriesDataResponse responseCallSettings = await client.ReadTensorboardTimeSeriesDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadTensorboardTimeSeriesDataResponse responseCancellationToken = await client.ReadTensorboardTimeSeriesDataAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadTensorboardTimeSeriesData()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            ReadTensorboardTimeSeriesDataResponse expectedResponse = new ReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData = new TimeSeriesData(),
            };
            mockGrpcClient.Setup(x => x.ReadTensorboardTimeSeriesData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            ReadTensorboardTimeSeriesDataResponse response = client.ReadTensorboardTimeSeriesData(request.TensorboardTimeSeries);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadTensorboardTimeSeriesDataAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            ReadTensorboardTimeSeriesDataResponse expectedResponse = new ReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData = new TimeSeriesData(),
            };
            mockGrpcClient.Setup(x => x.ReadTensorboardTimeSeriesDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadTensorboardTimeSeriesDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            ReadTensorboardTimeSeriesDataResponse responseCallSettings = await client.ReadTensorboardTimeSeriesDataAsync(request.TensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadTensorboardTimeSeriesDataResponse responseCancellationToken = await client.ReadTensorboardTimeSeriesDataAsync(request.TensorboardTimeSeries, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadTensorboardTimeSeriesDataResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            ReadTensorboardTimeSeriesDataResponse expectedResponse = new ReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData = new TimeSeriesData(),
            };
            mockGrpcClient.Setup(x => x.ReadTensorboardTimeSeriesData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            ReadTensorboardTimeSeriesDataResponse response = client.ReadTensorboardTimeSeriesData(request.TensorboardTimeSeriesAsTensorboardTimeSeriesName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadTensorboardTimeSeriesDataResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            ReadTensorboardTimeSeriesDataResponse expectedResponse = new ReadTensorboardTimeSeriesDataResponse
            {
                TimeSeriesData = new TimeSeriesData(),
            };
            mockGrpcClient.Setup(x => x.ReadTensorboardTimeSeriesDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadTensorboardTimeSeriesDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            ReadTensorboardTimeSeriesDataResponse responseCallSettings = await client.ReadTensorboardTimeSeriesDataAsync(request.TensorboardTimeSeriesAsTensorboardTimeSeriesName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadTensorboardTimeSeriesDataResponse responseCancellationToken = await client.ReadTensorboardTimeSeriesDataAsync(request.TensorboardTimeSeriesAsTensorboardTimeSeriesName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteTensorboardExperimentDataRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            WriteTensorboardExperimentDataResponse expectedResponse = new WriteTensorboardExperimentDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardExperimentData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardExperimentDataResponse response = client.WriteTensorboardExperimentData(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteTensorboardExperimentDataRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            WriteTensorboardExperimentDataResponse expectedResponse = new WriteTensorboardExperimentDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardExperimentDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteTensorboardExperimentDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardExperimentDataResponse responseCallSettings = await client.WriteTensorboardExperimentDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteTensorboardExperimentDataResponse responseCancellationToken = await client.WriteTensorboardExperimentDataAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteTensorboardExperimentData()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            WriteTensorboardExperimentDataResponse expectedResponse = new WriteTensorboardExperimentDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardExperimentData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardExperimentDataResponse response = client.WriteTensorboardExperimentData(request.TensorboardExperiment, request.WriteRunDataRequests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteTensorboardExperimentDataAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            WriteTensorboardExperimentDataResponse expectedResponse = new WriteTensorboardExperimentDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardExperimentDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteTensorboardExperimentDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardExperimentDataResponse responseCallSettings = await client.WriteTensorboardExperimentDataAsync(request.TensorboardExperiment, request.WriteRunDataRequests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteTensorboardExperimentDataResponse responseCancellationToken = await client.WriteTensorboardExperimentDataAsync(request.TensorboardExperiment, request.WriteRunDataRequests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteTensorboardExperimentDataResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            WriteTensorboardExperimentDataResponse expectedResponse = new WriteTensorboardExperimentDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardExperimentData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardExperimentDataResponse response = client.WriteTensorboardExperimentData(request.TensorboardExperimentAsTensorboardExperimentName, request.WriteRunDataRequests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteTensorboardExperimentDataResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            WriteTensorboardExperimentDataResponse expectedResponse = new WriteTensorboardExperimentDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardExperimentDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteTensorboardExperimentDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardExperimentDataResponse responseCallSettings = await client.WriteTensorboardExperimentDataAsync(request.TensorboardExperimentAsTensorboardExperimentName, request.WriteRunDataRequests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteTensorboardExperimentDataResponse responseCancellationToken = await client.WriteTensorboardExperimentDataAsync(request.TensorboardExperimentAsTensorboardExperimentName, request.WriteRunDataRequests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteTensorboardRunDataRequestObject()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            WriteTensorboardRunDataResponse expectedResponse = new WriteTensorboardRunDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardRunData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardRunDataResponse response = client.WriteTensorboardRunData(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteTensorboardRunDataRequestObjectAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            WriteTensorboardRunDataResponse expectedResponse = new WriteTensorboardRunDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardRunDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteTensorboardRunDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardRunDataResponse responseCallSettings = await client.WriteTensorboardRunDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteTensorboardRunDataResponse responseCancellationToken = await client.WriteTensorboardRunDataAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteTensorboardRunData()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            WriteTensorboardRunDataResponse expectedResponse = new WriteTensorboardRunDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardRunData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardRunDataResponse response = client.WriteTensorboardRunData(request.TensorboardRun, request.TimeSeriesData);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteTensorboardRunDataAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            WriteTensorboardRunDataResponse expectedResponse = new WriteTensorboardRunDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardRunDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteTensorboardRunDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardRunDataResponse responseCallSettings = await client.WriteTensorboardRunDataAsync(request.TensorboardRun, request.TimeSeriesData, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteTensorboardRunDataResponse responseCancellationToken = await client.WriteTensorboardRunDataAsync(request.TensorboardRun, request.TimeSeriesData, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteTensorboardRunDataResourceNames()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            WriteTensorboardRunDataResponse expectedResponse = new WriteTensorboardRunDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardRunData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardRunDataResponse response = client.WriteTensorboardRunData(request.TensorboardRunAsTensorboardRunName, request.TimeSeriesData);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteTensorboardRunDataResourceNamesAsync()
        {
            moq::Mock<TensorboardService.TensorboardServiceClient> mockGrpcClient = new moq::Mock<TensorboardService.TensorboardServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            WriteTensorboardRunDataResponse expectedResponse = new WriteTensorboardRunDataResponse { };
            mockGrpcClient.Setup(x => x.WriteTensorboardRunDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteTensorboardRunDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TensorboardServiceClient client = new TensorboardServiceClientImpl(mockGrpcClient.Object, null);
            WriteTensorboardRunDataResponse responseCallSettings = await client.WriteTensorboardRunDataAsync(request.TensorboardRunAsTensorboardRunName, request.TimeSeriesData, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteTensorboardRunDataResponse responseCancellationToken = await client.WriteTensorboardRunDataAsync(request.TensorboardRunAsTensorboardRunName, request.TimeSeriesData, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
