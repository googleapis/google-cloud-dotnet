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
    public class GeneratedContextsClientTest
    {
        [Fact]
        public void GetContext()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            GetContextRequest expectedRequest = new GetContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.GetContext(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            ContextName name = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]");
            Context response = client.GetContext(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetContextAsync()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            GetContextRequest expectedRequest = new GetContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Context>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            ContextName name = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]");
            Context response = await client.GetContextAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetContext2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.GetContext(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context response = client.GetContext(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetContextAsync2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Context>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context response = await client.GetContextAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateContext()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            CreateContextRequest expectedRequest = new CreateContextRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.CreateContext(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            SessionName parent = new SessionName("[PROJECT]", "[SESSION]");
            Context context = new Context();
            Context response = client.CreateContext(parent, context);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateContextAsync()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            CreateContextRequest expectedRequest = new CreateContextRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Context>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            SessionName parent = new SessionName("[PROJECT]", "[SESSION]");
            Context context = new Context();
            Context response = await client.CreateContextAsync(parent, context);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateContext2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context response = client.CreateContext(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateContextAsync2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Context>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context response = await client.CreateContextAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateContext()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            UpdateContextRequest expectedRequest = new UpdateContextRequest
            {
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.UpdateContext(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context context = new Context();
            Context response = client.UpdateContext(context);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateContextAsync()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            UpdateContextRequest expectedRequest = new UpdateContextRequest
            {
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Context>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context context = new Context();
            Context response = await client.UpdateContextAsync(context);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateContext2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.UpdateContext(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context response = client.UpdateContext(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateContextAsync2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = 1178775510,
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Context>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            Context response = await client.UpdateContextAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteContext()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteContextRequest expectedRequest = new DeleteContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteContext(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            ContextName name = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]");
            client.DeleteContext(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteContextAsync()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteContextRequest expectedRequest = new DeleteContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteContextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            ContextName name = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]");
            await client.DeleteContextAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteContext2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteContext(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            client.DeleteContext(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteContextAsync2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = new ContextName("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteContextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteContextAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAllContexts()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteAllContextsRequest expectedRequest = new DeleteAllContextsRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAllContexts(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            SessionName parent = new SessionName("[PROJECT]", "[SESSION]");
            client.DeleteAllContexts(parent);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAllContextsAsync()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteAllContextsRequest expectedRequest = new DeleteAllContextsRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAllContextsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            SessionName parent = new SessionName("[PROJECT]", "[SESSION]");
            await client.DeleteAllContextsAsync(parent);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAllContexts2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAllContexts(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            client.DeleteAllContexts(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAllContextsAsync2()
        {
            Mock<Contexts.ContextsClient> mockGrpcClient = new Mock<Contexts.ContextsClient>(MockBehavior.Strict);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAllContextsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAllContextsAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
