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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeaturestoreServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetFeaturestoreRequestObject()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            Featurestore expectedResponse = new Featurestore
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                OnlineServingConfig = new Featurestore.Types.OnlineServingConfig(),
                State = Featurestore.Types.State.Unspecified,
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetFeaturestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Featurestore response = client.GetFeaturestore(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeaturestoreRequestObjectAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            Featurestore expectedResponse = new Featurestore
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                OnlineServingConfig = new Featurestore.Types.OnlineServingConfig(),
                State = Featurestore.Types.State.Unspecified,
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetFeaturestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Featurestore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Featurestore responseCallSettings = await client.GetFeaturestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Featurestore responseCancellationToken = await client.GetFeaturestoreAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeaturestore()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            Featurestore expectedResponse = new Featurestore
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                OnlineServingConfig = new Featurestore.Types.OnlineServingConfig(),
                State = Featurestore.Types.State.Unspecified,
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetFeaturestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Featurestore response = client.GetFeaturestore(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeaturestoreAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            Featurestore expectedResponse = new Featurestore
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                OnlineServingConfig = new Featurestore.Types.OnlineServingConfig(),
                State = Featurestore.Types.State.Unspecified,
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetFeaturestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Featurestore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Featurestore responseCallSettings = await client.GetFeaturestoreAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Featurestore responseCancellationToken = await client.GetFeaturestoreAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeaturestoreResourceNames()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            Featurestore expectedResponse = new Featurestore
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                OnlineServingConfig = new Featurestore.Types.OnlineServingConfig(),
                State = Featurestore.Types.State.Unspecified,
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetFeaturestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Featurestore response = client.GetFeaturestore(request.FeaturestoreName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeaturestoreResourceNamesAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            Featurestore expectedResponse = new Featurestore
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                OnlineServingConfig = new Featurestore.Types.OnlineServingConfig(),
                State = Featurestore.Types.State.Unspecified,
                EncryptionSpec = new EncryptionSpec(),
            };
            mockGrpcClient.Setup(x => x.GetFeaturestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Featurestore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Featurestore responseCallSettings = await client.GetFeaturestoreAsync(request.FeaturestoreName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Featurestore responseCancellationToken = await client.GetFeaturestoreAsync(request.FeaturestoreName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityTypeRequestObject()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.GetEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeRequestObjectAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityType()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.GetEntityType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityTypeResourceNames()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.GetEntityType(request.EntityTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeResourceNamesAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.EntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.EntityTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityTypeRequestObject()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.UpdateEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityTypeRequestObjectAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityType()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.UpdateEntityType(request.EntityType, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityTypeAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
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
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request.EntityType, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request.EntityType, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeatureRequestObject()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.GetFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature response = client.GetFeature(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeatureRequestObjectAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.GetFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.GetFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.GetFeatureAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeature()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.GetFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature response = client.GetFeature(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeatureAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.GetFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.GetFeatureAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.GetFeatureAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeatureResourceNames()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.GetFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature response = client.GetFeature(request.FeatureName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeatureResourceNamesAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.GetFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.GetFeatureAsync(request.FeatureName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.GetFeatureAsync(request.FeatureName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFeatureRequestObject()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new wkt::FieldMask(),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.UpdateFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature response = client.UpdateFeature(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFeatureRequestObjectAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new wkt::FieldMask(),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.UpdateFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.UpdateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.UpdateFeatureAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFeature()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new wkt::FieldMask(),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.UpdateFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature response = client.UpdateFeature(request.Feature, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFeatureAsync()
        {
            moq::Mock<FeaturestoreService.FeaturestoreServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreService.FeaturestoreServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new wkt::FieldMask(),
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                Description = "description2cf9da67",
                ValueType = Feature.Types.ValueType.DoubleArray,
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
            mockGrpcClient.Setup(x => x.UpdateFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreServiceClient client = new FeaturestoreServiceClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.UpdateFeatureAsync(request.Feature, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.UpdateFeatureAsync(request.Feature, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
