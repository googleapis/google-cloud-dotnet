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

namespace Google.LongRunning.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.LongRunning;
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
    public class GeneratedOperationsClientTest
    {
        [Fact]
        public void GetOperation()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            GetOperationRequest expectedRequest = new GetOperationRequest
            {
                Name = "name3373707",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetOperation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            Operation response = client.GetOperation(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOperationAsync()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            GetOperationRequest expectedRequest = new GetOperationRequest
            {
                Name = "name3373707",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            Operation response = await client.GetOperationAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOperation2()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                Name = "name3373707",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetOperation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.GetOperation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOperationAsync2()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                Name = "name3373707",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.GetOperationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelOperation()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            CancelOperationRequest expectedRequest = new CancelOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            client.CancelOperation(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelOperationAsync()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            CancelOperationRequest expectedRequest = new CancelOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            await client.CancelOperationAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelOperation2()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            client.CancelOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelOperationAsync2()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            await client.CancelOperationAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteOperation()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            DeleteOperationRequest expectedRequest = new DeleteOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOperation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            client.DeleteOperation(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteOperationAsync()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            DeleteOperationRequest expectedRequest = new DeleteOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOperationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            await client.DeleteOperationAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteOperation2()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            DeleteOperationRequest request = new DeleteOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOperation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            client.DeleteOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteOperationAsync2()
        {
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient>(MockBehavior.Strict);
            DeleteOperationRequest request = new DeleteOperationRequest
            {
                Name = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOperationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOperationAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
