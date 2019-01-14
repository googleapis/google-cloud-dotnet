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
    public class GeneratedSessionEntityTypesClientTest
    {
        [Fact]
        public void GetSessionEntityType()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            GetSessionEntityTypeRequest expectedRequest = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityTypeName name = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            SessionEntityType response = client.GetSessionEntityType(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSessionEntityTypeAsync()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            GetSessionEntityTypeRequest expectedRequest = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SessionEntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityTypeName name = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            SessionEntityType response = await client.GetSessionEntityTypeAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSessionEntityType2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType response = client.GetSessionEntityType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSessionEntityTypeAsync2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.GetSessionEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SessionEntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType response = await client.GetSessionEntityTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSessionEntityType()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            CreateSessionEntityTypeRequest expectedRequest = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionName parent = new SessionName("[PROJECT]", "[SESSION]");
            SessionEntityType sessionEntityType = new SessionEntityType();
            SessionEntityType response = client.CreateSessionEntityType(parent, sessionEntityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSessionEntityTypeAsync()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            CreateSessionEntityTypeRequest expectedRequest = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SessionEntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionName parent = new SessionName("[PROJECT]", "[SESSION]");
            SessionEntityType sessionEntityType = new SessionEntityType();
            SessionEntityType response = await client.CreateSessionEntityTypeAsync(parent, sessionEntityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSessionEntityType2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType response = client.CreateSessionEntityType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSessionEntityTypeAsync2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSessionEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SessionEntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType response = await client.CreateSessionEntityTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSessionEntityType()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            UpdateSessionEntityTypeRequest expectedRequest = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType sessionEntityType = new SessionEntityType();
            SessionEntityType response = client.UpdateSessionEntityType(sessionEntityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSessionEntityTypeAsync()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            UpdateSessionEntityTypeRequest expectedRequest = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SessionEntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType sessionEntityType = new SessionEntityType();
            SessionEntityType response = await client.UpdateSessionEntityTypeAsync(sessionEntityType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSessionEntityType2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType response = client.UpdateSessionEntityType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSessionEntityTypeAsync2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
            };
            SessionEntityType expectedResponse = new SessionEntityType
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSessionEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SessionEntityType>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityType response = await client.UpdateSessionEntityTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSessionEntityType()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            DeleteSessionEntityTypeRequest expectedRequest = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSessionEntityType(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityTypeName name = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            client.DeleteSessionEntityType(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSessionEntityTypeAsync()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            DeleteSessionEntityTypeRequest expectedRequest = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSessionEntityTypeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            SessionEntityTypeName name = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            await client.DeleteSessionEntityTypeAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSessionEntityType2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSessionEntityType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            client.DeleteSessionEntityType(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSessionEntityTypeAsync2()
        {
            Mock<SessionEntityTypes.SessionEntityTypesClient> mockGrpcClient = new Mock<SessionEntityTypes.SessionEntityTypesClient>(MockBehavior.Strict);
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = new SessionEntityTypeName("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSessionEntityTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionEntityTypesClient client = new SessionEntityTypesClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSessionEntityTypeAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
