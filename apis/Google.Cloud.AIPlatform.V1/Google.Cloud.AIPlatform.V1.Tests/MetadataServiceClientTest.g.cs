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

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMetadataServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetMetadataStoreRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            MetadataStore expectedResponse = new MetadataStore
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
                State = new MetadataStore.Types.MetadataStoreState(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataStore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataStore response = client.GetMetadataStore(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataStoreRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            MetadataStore expectedResponse = new MetadataStore
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
                State = new MetadataStore.Types.MetadataStoreState(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataStoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataStore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataStore responseCallSettings = await client.GetMetadataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataStore responseCancellationToken = await client.GetMetadataStoreAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataStore()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            MetadataStore expectedResponse = new MetadataStore
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
                State = new MetadataStore.Types.MetadataStoreState(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataStore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataStore response = client.GetMetadataStore(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataStoreAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            MetadataStore expectedResponse = new MetadataStore
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
                State = new MetadataStore.Types.MetadataStoreState(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataStoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataStore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataStore responseCallSettings = await client.GetMetadataStoreAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataStore responseCancellationToken = await client.GetMetadataStoreAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataStoreResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            MetadataStore expectedResponse = new MetadataStore
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
                State = new MetadataStore.Types.MetadataStoreState(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataStore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataStore response = client.GetMetadataStore(request.MetadataStoreName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataStoreResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            MetadataStore expectedResponse = new MetadataStore
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
                State = new MetadataStore.Types.MetadataStoreState(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataStoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataStore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataStore responseCallSettings = await client.GetMetadataStoreAsync(request.MetadataStoreName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataStore responseCancellationToken = await client.GetMetadataStoreAsync(request.MetadataStoreName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifact()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.Parent, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.Parent, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.Parent, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.ParentAsMetadataStoreName, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.ParentAsMetadataStoreName, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.ParentAsMetadataStoreName, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.GetArtifact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.GetArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.GetArtifactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifact()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.GetArtifact(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.GetArtifactAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.GetArtifactAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.GetArtifact(request.ArtifactName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.GetArtifactAsync(request.ArtifactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.GetArtifactAsync(request.ArtifactName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateArtifactRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.UpdateArtifact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateArtifactRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.UpdateArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.UpdateArtifactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateArtifact()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new wkt::FieldMask(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.UpdateArtifact(request.Artifact, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateArtifactAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new wkt::FieldMask(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                DisplayName = "display_name137f65c2",
                Uri = "uri3db70593",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Artifact.Types.State.Unspecified,
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.UpdateArtifactAsync(request.Artifact, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.UpdateArtifactAsync(request.Artifact, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContextRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "context_id3a5c58bc",
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.CreateContext(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContextRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "context_id3a5c58bc",
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.CreateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.CreateContextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContext()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "context_id3a5c58bc",
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.CreateContext(request.Parent, request.Context, request.ContextId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContextAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "context_id3a5c58bc",
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.CreateContextAsync(request.Parent, request.Context, request.ContextId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.CreateContextAsync(request.Parent, request.Context, request.ContextId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContextResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "context_id3a5c58bc",
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.CreateContext(request.ParentAsMetadataStoreName, request.Context, request.ContextId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContextResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "context_id3a5c58bc",
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.CreateContextAsync(request.ParentAsMetadataStoreName, request.Context, request.ContextId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.CreateContextAsync(request.ParentAsMetadataStoreName, request.Context, request.ContextId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContextRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.GetContext(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContextRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.GetContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.GetContextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContext()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.GetContext(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContextAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.GetContextAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.GetContextAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContextResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.GetContext(request.ContextName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContextResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.GetContextAsync(request.ContextName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.GetContextAsync(request.ContextName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContextRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.UpdateContext(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContextRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.UpdateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.UpdateContextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContext()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.UpdateContext(request.Context, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContextAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ParentContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.UpdateContextAsync(request.Context, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.UpdateContextAsync(request.Context, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddContextArtifactsAndExecutionsRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            AddContextArtifactsAndExecutionsResponse expectedResponse = new AddContextArtifactsAndExecutionsResponse { };
            mockGrpcClient.Setup(x => x.AddContextArtifactsAndExecutions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextArtifactsAndExecutionsResponse response = client.AddContextArtifactsAndExecutions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddContextArtifactsAndExecutionsRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            AddContextArtifactsAndExecutionsResponse expectedResponse = new AddContextArtifactsAndExecutionsResponse { };
            mockGrpcClient.Setup(x => x.AddContextArtifactsAndExecutionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddContextArtifactsAndExecutionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextArtifactsAndExecutionsResponse responseCallSettings = await client.AddContextArtifactsAndExecutionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddContextArtifactsAndExecutionsResponse responseCancellationToken = await client.AddContextArtifactsAndExecutionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddContextArtifactsAndExecutions()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            AddContextArtifactsAndExecutionsResponse expectedResponse = new AddContextArtifactsAndExecutionsResponse { };
            mockGrpcClient.Setup(x => x.AddContextArtifactsAndExecutions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextArtifactsAndExecutionsResponse response = client.AddContextArtifactsAndExecutions(request.Context, request.Artifacts, request.Executions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddContextArtifactsAndExecutionsAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            AddContextArtifactsAndExecutionsResponse expectedResponse = new AddContextArtifactsAndExecutionsResponse { };
            mockGrpcClient.Setup(x => x.AddContextArtifactsAndExecutionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddContextArtifactsAndExecutionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextArtifactsAndExecutionsResponse responseCallSettings = await client.AddContextArtifactsAndExecutionsAsync(request.Context, request.Artifacts, request.Executions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddContextArtifactsAndExecutionsResponse responseCancellationToken = await client.AddContextArtifactsAndExecutionsAsync(request.Context, request.Artifacts, request.Executions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddContextArtifactsAndExecutionsResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            AddContextArtifactsAndExecutionsResponse expectedResponse = new AddContextArtifactsAndExecutionsResponse { };
            mockGrpcClient.Setup(x => x.AddContextArtifactsAndExecutions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextArtifactsAndExecutionsResponse response = client.AddContextArtifactsAndExecutions(request.ContextAsContextName, request.ArtifactsAsArtifactNames, request.ExecutionsAsExecutionNames);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddContextArtifactsAndExecutionsResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            AddContextArtifactsAndExecutionsResponse expectedResponse = new AddContextArtifactsAndExecutionsResponse { };
            mockGrpcClient.Setup(x => x.AddContextArtifactsAndExecutionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddContextArtifactsAndExecutionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextArtifactsAndExecutionsResponse responseCallSettings = await client.AddContextArtifactsAndExecutionsAsync(request.ContextAsContextName, request.ArtifactsAsArtifactNames, request.ExecutionsAsExecutionNames, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddContextArtifactsAndExecutionsResponse responseCancellationToken = await client.AddContextArtifactsAndExecutionsAsync(request.ContextAsContextName, request.ArtifactsAsArtifactNames, request.ExecutionsAsExecutionNames, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddContextChildrenRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            AddContextChildrenResponse expectedResponse = new AddContextChildrenResponse { };
            mockGrpcClient.Setup(x => x.AddContextChildren(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextChildrenResponse response = client.AddContextChildren(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddContextChildrenRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            AddContextChildrenResponse expectedResponse = new AddContextChildrenResponse { };
            mockGrpcClient.Setup(x => x.AddContextChildrenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddContextChildrenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextChildrenResponse responseCallSettings = await client.AddContextChildrenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddContextChildrenResponse responseCancellationToken = await client.AddContextChildrenAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddContextChildren()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            AddContextChildrenResponse expectedResponse = new AddContextChildrenResponse { };
            mockGrpcClient.Setup(x => x.AddContextChildren(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextChildrenResponse response = client.AddContextChildren(request.Context, request.ChildContexts);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddContextChildrenAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            AddContextChildrenResponse expectedResponse = new AddContextChildrenResponse { };
            mockGrpcClient.Setup(x => x.AddContextChildrenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddContextChildrenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextChildrenResponse responseCallSettings = await client.AddContextChildrenAsync(request.Context, request.ChildContexts, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddContextChildrenResponse responseCancellationToken = await client.AddContextChildrenAsync(request.Context, request.ChildContexts, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddContextChildrenResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            AddContextChildrenResponse expectedResponse = new AddContextChildrenResponse { };
            mockGrpcClient.Setup(x => x.AddContextChildren(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextChildrenResponse response = client.AddContextChildren(request.ContextAsContextName, request.ChildContextsAsContextNames);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddContextChildrenResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            AddContextChildrenResponse expectedResponse = new AddContextChildrenResponse { };
            mockGrpcClient.Setup(x => x.AddContextChildrenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddContextChildrenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddContextChildrenResponse responseCallSettings = await client.AddContextChildrenAsync(request.ContextAsContextName, request.ChildContextsAsContextNames, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddContextChildrenResponse responseCancellationToken = await client.AddContextChildrenAsync(request.ContextAsContextName, request.ChildContextsAsContextNames, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryContextLineageSubgraphRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryContextLineageSubgraph(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryContextLineageSubgraph(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryContextLineageSubgraphRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryContextLineageSubgraphAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryContextLineageSubgraphAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryContextLineageSubgraphAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryContextLineageSubgraph()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryContextLineageSubgraph(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryContextLineageSubgraph(request.Context);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryContextLineageSubgraphAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryContextLineageSubgraphAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryContextLineageSubgraphAsync(request.Context, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryContextLineageSubgraphAsync(request.Context, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryContextLineageSubgraphResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryContextLineageSubgraph(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryContextLineageSubgraph(request.ContextAsContextName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryContextLineageSubgraphResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryContextLineageSubgraphAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryContextLineageSubgraphAsync(request.ContextAsContextName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryContextLineageSubgraphAsync(request.ContextAsContextName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExecutionRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "execution_id7e78fb21",
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.CreateExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExecutionRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "execution_id7e78fb21",
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.CreateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CreateExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExecution()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "execution_id7e78fb21",
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.CreateExecution(request.Parent, request.Execution, request.ExecutionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExecutionAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "execution_id7e78fb21",
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.CreateExecutionAsync(request.Parent, request.Execution, request.ExecutionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CreateExecutionAsync(request.Parent, request.Execution, request.ExecutionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExecutionResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "execution_id7e78fb21",
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.CreateExecution(request.ParentAsMetadataStoreName, request.Execution, request.ExecutionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExecutionResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "execution_id7e78fb21",
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.CreateExecutionAsync(request.ParentAsMetadataStoreName, request.Execution, request.ExecutionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CreateExecutionAsync(request.ParentAsMetadataStoreName, request.Execution, request.ExecutionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecutionRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.GetExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecution()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.GetExecution(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecutionResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.GetExecution(request.ExecutionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.ExecutionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.ExecutionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExecutionRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExecutionRequest request = new UpdateExecutionRequest
            {
                Execution = new Execution(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.UpdateExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExecutionRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExecutionRequest request = new UpdateExecutionRequest
            {
                Execution = new Execution(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.UpdateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.UpdateExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExecution()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExecutionRequest request = new UpdateExecutionRequest
            {
                Execution = new Execution(),
                UpdateMask = new wkt::FieldMask(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.UpdateExecution(request.Execution, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExecutionAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExecutionRequest request = new UpdateExecutionRequest
            {
                Execution = new Execution(),
                UpdateMask = new wkt::FieldMask(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                State = Execution.Types.State.Cancelled,
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SchemaTitle = "schema_title9b5ec482",
                SchemaVersion = "schema_versionc7ead397",
                Metadata = new wkt::Struct(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.UpdateExecutionAsync(request.Execution, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.UpdateExecutionAsync(request.Execution, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddExecutionEventsRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            AddExecutionEventsResponse expectedResponse = new AddExecutionEventsResponse { };
            mockGrpcClient.Setup(x => x.AddExecutionEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddExecutionEventsResponse response = client.AddExecutionEvents(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddExecutionEventsRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            AddExecutionEventsResponse expectedResponse = new AddExecutionEventsResponse { };
            mockGrpcClient.Setup(x => x.AddExecutionEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddExecutionEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddExecutionEventsResponse responseCallSettings = await client.AddExecutionEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddExecutionEventsResponse responseCancellationToken = await client.AddExecutionEventsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddExecutionEvents()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            AddExecutionEventsResponse expectedResponse = new AddExecutionEventsResponse { };
            mockGrpcClient.Setup(x => x.AddExecutionEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddExecutionEventsResponse response = client.AddExecutionEvents(request.Execution, request.Events);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddExecutionEventsAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            AddExecutionEventsResponse expectedResponse = new AddExecutionEventsResponse { };
            mockGrpcClient.Setup(x => x.AddExecutionEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddExecutionEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddExecutionEventsResponse responseCallSettings = await client.AddExecutionEventsAsync(request.Execution, request.Events, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddExecutionEventsResponse responseCancellationToken = await client.AddExecutionEventsAsync(request.Execution, request.Events, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddExecutionEventsResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            AddExecutionEventsResponse expectedResponse = new AddExecutionEventsResponse { };
            mockGrpcClient.Setup(x => x.AddExecutionEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddExecutionEventsResponse response = client.AddExecutionEvents(request.ExecutionAsExecutionName, request.Events);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddExecutionEventsResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            AddExecutionEventsResponse expectedResponse = new AddExecutionEventsResponse { };
            mockGrpcClient.Setup(x => x.AddExecutionEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddExecutionEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            AddExecutionEventsResponse responseCallSettings = await client.AddExecutionEventsAsync(request.ExecutionAsExecutionName, request.Events, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddExecutionEventsResponse responseCancellationToken = await client.AddExecutionEventsAsync(request.ExecutionAsExecutionName, request.Events, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryExecutionInputsAndOutputsRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryExecutionInputsAndOutputs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryExecutionInputsAndOutputs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryExecutionInputsAndOutputsRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryExecutionInputsAndOutputsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryExecutionInputsAndOutputsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryExecutionInputsAndOutputsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryExecutionInputsAndOutputs()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryExecutionInputsAndOutputs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryExecutionInputsAndOutputs(request.Execution);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryExecutionInputsAndOutputsAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryExecutionInputsAndOutputsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryExecutionInputsAndOutputsAsync(request.Execution, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryExecutionInputsAndOutputsAsync(request.Execution, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryExecutionInputsAndOutputsResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryExecutionInputsAndOutputs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryExecutionInputsAndOutputs(request.ExecutionAsExecutionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryExecutionInputsAndOutputsResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryExecutionInputsAndOutputsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryExecutionInputsAndOutputsAsync(request.ExecutionAsExecutionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryExecutionInputsAndOutputsAsync(request.ExecutionAsExecutionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetadataSchemaRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "metadata_schema_id2242928a",
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateMetadataSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema response = client.CreateMetadataSchema(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetadataSchemaRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "metadata_schema_id2242928a",
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateMetadataSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataSchema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema responseCallSettings = await client.CreateMetadataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataSchema responseCancellationToken = await client.CreateMetadataSchemaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetadataSchema()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "metadata_schema_id2242928a",
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateMetadataSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema response = client.CreateMetadataSchema(request.Parent, request.MetadataSchema, request.MetadataSchemaId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetadataSchemaAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "metadata_schema_id2242928a",
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateMetadataSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataSchema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema responseCallSettings = await client.CreateMetadataSchemaAsync(request.Parent, request.MetadataSchema, request.MetadataSchemaId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataSchema responseCancellationToken = await client.CreateMetadataSchemaAsync(request.Parent, request.MetadataSchema, request.MetadataSchemaId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetadataSchemaResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "metadata_schema_id2242928a",
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateMetadataSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema response = client.CreateMetadataSchema(request.ParentAsMetadataStoreName, request.MetadataSchema, request.MetadataSchemaId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetadataSchemaResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "metadata_schema_id2242928a",
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateMetadataSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataSchema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema responseCallSettings = await client.CreateMetadataSchemaAsync(request.ParentAsMetadataStoreName, request.MetadataSchema, request.MetadataSchemaId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataSchema responseCancellationToken = await client.CreateMetadataSchemaAsync(request.ParentAsMetadataStoreName, request.MetadataSchema, request.MetadataSchemaId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataSchemaRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetMetadataSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema response = client.GetMetadataSchema(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataSchemaRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetMetadataSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataSchema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema responseCallSettings = await client.GetMetadataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataSchema responseCancellationToken = await client.GetMetadataSchemaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataSchema()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetMetadataSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema response = client.GetMetadataSchema(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataSchemaAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetMetadataSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataSchema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema responseCallSettings = await client.GetMetadataSchemaAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataSchema responseCancellationToken = await client.GetMetadataSchemaAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataSchemaResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetMetadataSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema response = client.GetMetadataSchema(request.MetadataSchemaName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataSchemaResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            MetadataSchema expectedResponse = new MetadataSchema
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
                SchemaVersion = "schema_versionc7ead397",
                Schema = "schema5f0d55c9",
                SchemaType = MetadataSchema.Types.MetadataSchemaType.ExecutionType,
                CreateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetMetadataSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataSchema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            MetadataSchema responseCallSettings = await client.GetMetadataSchemaAsync(request.MetadataSchemaName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataSchema responseCancellationToken = await client.GetMetadataSchemaAsync(request.MetadataSchemaName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryArtifactLineageSubgraphRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                MaxHops = -399419703,
                Filter = "filtere47ac9b2",
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryArtifactLineageSubgraph(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryArtifactLineageSubgraph(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryArtifactLineageSubgraphRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                MaxHops = -399419703,
                Filter = "filtere47ac9b2",
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryArtifactLineageSubgraphAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryArtifactLineageSubgraphAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryArtifactLineageSubgraphAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryArtifactLineageSubgraph()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryArtifactLineageSubgraph(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryArtifactLineageSubgraph(request.Artifact);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryArtifactLineageSubgraphAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryArtifactLineageSubgraphAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryArtifactLineageSubgraphAsync(request.Artifact, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryArtifactLineageSubgraphAsync(request.Artifact, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryArtifactLineageSubgraphResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryArtifactLineageSubgraph(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph response = client.QueryArtifactLineageSubgraph(request.ArtifactAsArtifactName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryArtifactLineageSubgraphResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            LineageSubgraph expectedResponse = new LineageSubgraph
            {
                Artifacts = { new Artifact(), },
                Executions = { new Execution(), },
                Events = { new Event(), },
            };
            mockGrpcClient.Setup(x => x.QueryArtifactLineageSubgraphAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LineageSubgraph>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null, null);
            LineageSubgraph responseCallSettings = await client.QueryArtifactLineageSubgraphAsync(request.ArtifactAsArtifactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LineageSubgraph responseCancellationToken = await client.QueryArtifactLineageSubgraphAsync(request.ArtifactAsArtifactName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
