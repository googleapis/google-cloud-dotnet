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

namespace Google.Cloud.Debugger.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Debugger.V2;
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
    public class GeneratedController2ClientTest
    {
        [Fact]
        public void UpdateActiveBreakpoint()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            UpdateActiveBreakpointRequest expectedRequest = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse();
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpoint(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            Breakpoint breakpoint = new Breakpoint();
            UpdateActiveBreakpointResponse response = client.UpdateActiveBreakpoint(debuggeeId, breakpoint);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateActiveBreakpointAsync()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            UpdateActiveBreakpointRequest expectedRequest = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse();
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpointAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UpdateActiveBreakpointResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            Breakpoint breakpoint = new Breakpoint();
            UpdateActiveBreakpointResponse response = await client.UpdateActiveBreakpointAsync(debuggeeId, breakpoint);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateActiveBreakpoint2()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse();
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpoint(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            UpdateActiveBreakpointResponse response = client.UpdateActiveBreakpoint(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateActiveBreakpointAsync2()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse();
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpointAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UpdateActiveBreakpointResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            UpdateActiveBreakpointResponse response = await client.UpdateActiveBreakpointAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RegisterDebuggee()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            RegisterDebuggeeRequest expectedRequest = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse();
            mockGrpcClient.Setup(x => x.RegisterDebuggee(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            Debuggee debuggee = new Debuggee();
            RegisterDebuggeeResponse response = client.RegisterDebuggee(debuggee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RegisterDebuggeeAsync()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            RegisterDebuggeeRequest expectedRequest = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse();
            mockGrpcClient.Setup(x => x.RegisterDebuggeeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RegisterDebuggeeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            Debuggee debuggee = new Debuggee();
            RegisterDebuggeeResponse response = await client.RegisterDebuggeeAsync(debuggee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RegisterDebuggee2()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse();
            mockGrpcClient.Setup(x => x.RegisterDebuggee(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            RegisterDebuggeeResponse response = client.RegisterDebuggee(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RegisterDebuggeeAsync2()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse();
            mockGrpcClient.Setup(x => x.RegisterDebuggeeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RegisterDebuggeeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            RegisterDebuggeeResponse response = await client.RegisterDebuggeeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListActiveBreakpoints()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            ListActiveBreakpointsRequest expectedRequest = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpoints(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            ListActiveBreakpointsResponse response = client.ListActiveBreakpoints(debuggeeId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListActiveBreakpointsAsync()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            ListActiveBreakpointsRequest expectedRequest = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpointsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListActiveBreakpointsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            ListActiveBreakpointsResponse response = await client.ListActiveBreakpointsAsync(debuggeeId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListActiveBreakpoints2()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpoints(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            ListActiveBreakpointsResponse response = client.ListActiveBreakpoints(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListActiveBreakpointsAsync2()
        {
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client>(MockBehavior.Strict);
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpointsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListActiveBreakpointsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            ListActiveBreakpointsResponse response = await client.ListActiveBreakpointsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
