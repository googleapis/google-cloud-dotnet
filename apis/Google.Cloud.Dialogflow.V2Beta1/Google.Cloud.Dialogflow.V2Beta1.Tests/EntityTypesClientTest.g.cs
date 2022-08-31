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
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEntityTypesClientTest
    {
        [xunit::FactAttribute]
        public void GetEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityType1()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityType1Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityType1ResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request.EntityTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityType1ResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.EntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.EntityTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityType2()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request.Name, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityType2Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.Name, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.Name, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityType2ResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request.EntityTypeName, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityType2ResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.EntityTypeName, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.EntityTypeName, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityType1()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request.Parent, request.EntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityType1Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request.Parent, request.EntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request.Parent, request.EntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityType1ResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request.ParentAsAgentName, request.EntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityType1ResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request.ParentAsAgentName, request.EntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request.ParentAsAgentName, request.EntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityType2()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request.Parent, request.EntityType, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityType2Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request.Parent, request.EntityType, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request.Parent, request.EntityType, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityType2ResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request.ParentAsAgentName, request.EntityType, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityType2ResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request.ParentAsAgentName, request.EntityType, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request.ParentAsAgentName, request.EntityType, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.UpdateEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityType1()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.UpdateEntityType(request.EntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityType1Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request.EntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request.EntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityType2()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.UpdateEntityType(request.EntityType, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityType2Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request.EntityType, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request.EntityType, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityType3()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.UpdateEntityType(request.EntityType, request.LanguageCode, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityType3Async()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                EnableFuzzyExtraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request.EntityType, request.LanguageCode, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request.EntityType, request.LanguageCode, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityType(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityTypeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityType()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityType(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityTypeAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityTypeAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityTypeResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityType(request.EntityTypeName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityTypeResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityTypeAsync(request.EntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityTypeAsync(request.EntityTypeName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
