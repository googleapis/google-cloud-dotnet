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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSessionEntityTypesClientTest
    {
        [xunit::FactAttribute]
        public void GetSessionEntityTypeRequestObject()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.GetSessionEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSessionEntityTypeRequestObjectAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.GetSessionEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.GetSessionEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSessionEntityType()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.GetSessionEntityType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSessionEntityTypeAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.GetSessionEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.GetSessionEntityTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSessionEntityTypeResourceNames()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.GetSessionEntityType(request.SessionEntityTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSessionEntityTypeResourceNamesAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.GetSessionEntityTypeAsync(request.SessionEntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.GetSessionEntityTypeAsync(request.SessionEntityTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSessionEntityTypeRequestObject()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.CreateSessionEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSessionEntityTypeRequestObjectAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.CreateSessionEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.CreateSessionEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSessionEntityType()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.CreateSessionEntityType(request.Parent, request.SessionEntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSessionEntityTypeAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.CreateSessionEntityTypeAsync(request.Parent, request.SessionEntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.CreateSessionEntityTypeAsync(request.Parent, request.SessionEntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSessionEntityTypeResourceNames()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.CreateSessionEntityType(request.ParentAsSessionName, request.SessionEntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSessionEntityTypeResourceNamesAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.CreateSessionEntityTypeAsync(request.ParentAsSessionName, request.SessionEntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.CreateSessionEntityTypeAsync(request.ParentAsSessionName, request.SessionEntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSessionEntityTypeRequestObject()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.UpdateSessionEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSessionEntityTypeRequestObjectAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.UpdateSessionEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.UpdateSessionEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSessionEntityType1()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.UpdateSessionEntityType(request.SessionEntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSessionEntityType1Async()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.UpdateSessionEntityTypeAsync(request.SessionEntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.UpdateSessionEntityTypeAsync(request.SessionEntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSessionEntityType2()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType response = client.UpdateSessionEntityType(request.SessionEntityType, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSessionEntityType2Async()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
                EntityOverrideMode = SessionEntityType.Types.EntityOverrideMode.Supplement,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SessionEntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            SessionEntityType responseCallSettings = await client.UpdateSessionEntityTypeAsync(request.SessionEntityType, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SessionEntityType responseCancellationToken = await client.UpdateSessionEntityTypeAsync(request.SessionEntityType, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSessionEntityTypeRequestObject()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSessionEntityType(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSessionEntityTypeRequestObjectAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSessionEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSessionEntityTypeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSessionEntityType()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSessionEntityType(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSessionEntityTypeAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSessionEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSessionEntityTypeAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSessionEntityTypeResourceNames()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSessionEntityType(request.SessionEntityTypeName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSessionEntityTypeResourceNamesAsync()
        {
            moq::Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new moq::Mock<SessionEntityTypes.SessionEntityTypesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSessionEntityTypeAsync(request.SessionEntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSessionEntityTypeAsync(request.SessionEntityTypeName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
