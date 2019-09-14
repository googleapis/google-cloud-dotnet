// Copyright 2019 Google LLC
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

namespace Google.Cloud.Dialogflow.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedEntityTypesClientTest
    {
        [Fact]
        public void GetEntityType()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetEntityTypeRequest expectedRequest = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            EntityType response = client.GetEntityType(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetEntityTypeAsync()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetEntityTypeRequest expectedRequest = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            EntityType response = await client.GetEntityTypeAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetEntityType2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetEntityTypeRequest expectedRequest = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "languageCode-412800396",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            string languageCode = "languageCode-412800396";
            EntityType response = client.GetEntityType(name, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetEntityTypeAsync2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetEntityTypeRequest expectedRequest = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "languageCode-412800396",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            string languageCode = "languageCode-412800396";
            EntityType response = await client.GetEntityTypeAsync(name, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetEntityType3()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.GetEntityType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetEntityTypeAsync3()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType response = await client.GetEntityTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateEntityType()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateEntityTypeRequest expectedRequest = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            EntityType response = client.CreateEntityType(parent, entityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateEntityTypeAsync()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateEntityTypeRequest expectedRequest = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            EntityType response = await client.CreateEntityTypeAsync(parent, entityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateEntityType2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateEntityTypeRequest expectedRequest = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "languageCode-412800396",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            string languageCode = "languageCode-412800396";
            EntityType response = client.CreateEntityType(parent, entityType, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateEntityTypeAsync2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateEntityTypeRequest expectedRequest = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "languageCode-412800396",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            string languageCode = "languageCode-412800396";
            EntityType response = await client.CreateEntityTypeAsync(parent, entityType, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateEntityType3()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.CreateEntityType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateEntityTypeAsync3()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType response = await client.CreateEntityTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateEntityType()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest expectedRequest = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType entityType = new EntityType();
            EntityType response = client.UpdateEntityType(entityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateEntityTypeAsync()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest expectedRequest = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType entityType = new EntityType();
            EntityType response = await client.UpdateEntityTypeAsync(entityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateEntityType2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest expectedRequest = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "languageCode-412800396",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType entityType = new EntityType();
            string languageCode = "languageCode-412800396";
            EntityType response = client.UpdateEntityType(entityType, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateEntityTypeAsync2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest expectedRequest = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "languageCode-412800396",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType entityType = new EntityType();
            string languageCode = "languageCode-412800396";
            EntityType response = await client.UpdateEntityTypeAsync(entityType, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateEntityType3()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType response = client.UpdateEntityType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateEntityTypeAsync3()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                DisplayName = "displayName1615086568",
                EnableFuzzyExtraction = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityType response = await client.UpdateEntityTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteEntityType()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteEntityTypeRequest expectedRequest = new DeleteEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            client.DeleteEntityType(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteEntityTypeAsync()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteEntityTypeRequest expectedRequest = new DeleteEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            await client.DeleteEntityTypeAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteEntityType2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntityType(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteEntityTypeAsync2()
        {
            Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new Mock<EntityTypes.EntityTypesClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntityTypeAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
