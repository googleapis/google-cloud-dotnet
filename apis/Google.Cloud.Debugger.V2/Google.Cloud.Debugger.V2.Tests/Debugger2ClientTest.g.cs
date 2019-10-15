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
    public class GeneratedDebugger2ClientTest
    {
        [Fact]
        public void DeleteBreakpoint()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            DeleteBreakpointRequest expectedRequest = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteBreakpoint(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string breakpointId = "breakpointId498424873";
            string clientVersion = "clientVersion-1506231196";
            client.DeleteBreakpoint(debuggeeId, breakpointId, clientVersion);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteBreakpointAsync()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            DeleteBreakpointRequest expectedRequest = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteBreakpointAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string breakpointId = "breakpointId498424873";
            string clientVersion = "clientVersion-1506231196";
            await client.DeleteBreakpointAsync(debuggeeId, breakpointId, clientVersion);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteBreakpoint2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteBreakpoint(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteBreakpoint(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteBreakpointAsync2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteBreakpointAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBreakpointAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetBreakpoint()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            SetBreakpointRequest expectedRequest = new SetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
                ClientVersion = "clientVersion-1506231196",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse();
            mockGrpcClient.Setup(x => x.SetBreakpoint(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            Breakpoint breakpoint = new Breakpoint();
            string clientVersion = "clientVersion-1506231196";
            SetBreakpointResponse response = client.SetBreakpoint(debuggeeId, breakpoint, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetBreakpointAsync()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            SetBreakpointRequest expectedRequest = new SetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
                ClientVersion = "clientVersion-1506231196",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse();
            mockGrpcClient.Setup(x => x.SetBreakpointAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SetBreakpointResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            Breakpoint breakpoint = new Breakpoint();
            string clientVersion = "clientVersion-1506231196";
            SetBreakpointResponse response = await client.SetBreakpointAsync(debuggeeId, breakpoint, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetBreakpoint2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
                ClientVersion = "clientVersion-1506231196",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse();
            mockGrpcClient.Setup(x => x.SetBreakpoint(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            SetBreakpointResponse response = client.SetBreakpoint(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetBreakpointAsync2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                Breakpoint = new Breakpoint(),
                ClientVersion = "clientVersion-1506231196",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse();
            mockGrpcClient.Setup(x => x.SetBreakpointAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SetBreakpointResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            SetBreakpointResponse response = await client.SetBreakpointAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetBreakpoint()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            GetBreakpointRequest expectedRequest = new GetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse();
            mockGrpcClient.Setup(x => x.GetBreakpoint(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string breakpointId = "breakpointId498424873";
            string clientVersion = "clientVersion-1506231196";
            GetBreakpointResponse response = client.GetBreakpoint(debuggeeId, breakpointId, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetBreakpointAsync()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            GetBreakpointRequest expectedRequest = new GetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse();
            mockGrpcClient.Setup(x => x.GetBreakpointAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GetBreakpointResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string breakpointId = "breakpointId498424873";
            string clientVersion = "clientVersion-1506231196";
            GetBreakpointResponse response = await client.GetBreakpointAsync(debuggeeId, breakpointId, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetBreakpoint2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse();
            mockGrpcClient.Setup(x => x.GetBreakpoint(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            GetBreakpointResponse response = client.GetBreakpoint(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetBreakpointAsync2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                BreakpointId = "breakpointId498424873",
                ClientVersion = "clientVersion-1506231196",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse();
            mockGrpcClient.Setup(x => x.GetBreakpointAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GetBreakpointResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            GetBreakpointResponse response = await client.GetBreakpointAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListBreakpoints()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListBreakpointsRequest expectedRequest = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                ClientVersion = "clientVersion-1506231196",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
            };
            mockGrpcClient.Setup(x => x.ListBreakpoints(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string clientVersion = "clientVersion-1506231196";
            ListBreakpointsResponse response = client.ListBreakpoints(debuggeeId, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListBreakpointsAsync()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListBreakpointsRequest expectedRequest = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                ClientVersion = "clientVersion-1506231196",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
            };
            mockGrpcClient.Setup(x => x.ListBreakpointsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListBreakpointsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string clientVersion = "clientVersion-1506231196";
            ListBreakpointsResponse response = await client.ListBreakpointsAsync(debuggeeId, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListBreakpoints2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                ClientVersion = "clientVersion-1506231196",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
            };
            mockGrpcClient.Setup(x => x.ListBreakpoints(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            ListBreakpointsResponse response = client.ListBreakpoints(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListBreakpointsAsync2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggeeId-997255898",
                ClientVersion = "clientVersion-1506231196",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
            };
            mockGrpcClient.Setup(x => x.ListBreakpointsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListBreakpointsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            ListBreakpointsResponse response = await client.ListBreakpointsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListDebuggees()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListDebuggeesRequest expectedRequest = new ListDebuggeesRequest
            {
                Project = "project-309310695",
                ClientVersion = "clientVersion-1506231196",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse();
            mockGrpcClient.Setup(x => x.ListDebuggees(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string project = "project-309310695";
            string clientVersion = "clientVersion-1506231196";
            ListDebuggeesResponse response = client.ListDebuggees(project, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListDebuggeesAsync()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListDebuggeesRequest expectedRequest = new ListDebuggeesRequest
            {
                Project = "project-309310695",
                ClientVersion = "clientVersion-1506231196",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse();
            mockGrpcClient.Setup(x => x.ListDebuggeesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListDebuggeesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string project = "project-309310695";
            string clientVersion = "clientVersion-1506231196";
            ListDebuggeesResponse response = await client.ListDebuggeesAsync(project, clientVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListDebuggees2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "project-309310695",
                ClientVersion = "clientVersion-1506231196",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse();
            mockGrpcClient.Setup(x => x.ListDebuggees(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            ListDebuggeesResponse response = client.ListDebuggees(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListDebuggeesAsync2()
        {
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client>(MockBehavior.Strict);
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "project-309310695",
                ClientVersion = "clientVersion-1506231196",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse();
            mockGrpcClient.Setup(x => x.ListDebuggeesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListDebuggeesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            ListDebuggeesResponse response = await client.ListDebuggeesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
