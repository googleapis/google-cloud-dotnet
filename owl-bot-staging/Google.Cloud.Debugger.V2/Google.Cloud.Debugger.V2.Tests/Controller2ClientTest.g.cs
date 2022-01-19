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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Debugger.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedController2ClientTest
    {
        [xunit::FactAttribute]
        public void RegisterDebuggeeRequestObject()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse
            {
                Debuggee = new Debuggee(),
            };
            mockGrpcClient.Setup(x => x.RegisterDebuggee(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            RegisterDebuggeeResponse response = client.RegisterDebuggee(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RegisterDebuggeeRequestObjectAsync()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse
            {
                Debuggee = new Debuggee(),
            };
            mockGrpcClient.Setup(x => x.RegisterDebuggeeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegisterDebuggeeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            RegisterDebuggeeResponse responseCallSettings = await client.RegisterDebuggeeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegisterDebuggeeResponse responseCancellationToken = await client.RegisterDebuggeeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RegisterDebuggee()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse
            {
                Debuggee = new Debuggee(),
            };
            mockGrpcClient.Setup(x => x.RegisterDebuggee(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            RegisterDebuggeeResponse response = client.RegisterDebuggee(request.Debuggee);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RegisterDebuggeeAsync()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse
            {
                Debuggee = new Debuggee(),
            };
            mockGrpcClient.Setup(x => x.RegisterDebuggeeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegisterDebuggeeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            RegisterDebuggeeResponse responseCallSettings = await client.RegisterDebuggeeAsync(request.Debuggee, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegisterDebuggeeResponse responseCancellationToken = await client.RegisterDebuggeeAsync(request.Debuggee, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListActiveBreakpointsRequestObject()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                WaitToken = "wait_tokencb600154",
                SuccessOnTimeout = false,
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            ListActiveBreakpointsResponse response = client.ListActiveBreakpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListActiveBreakpointsRequestObjectAsync()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                WaitToken = "wait_tokencb600154",
                SuccessOnTimeout = false,
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListActiveBreakpointsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            ListActiveBreakpointsResponse responseCallSettings = await client.ListActiveBreakpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListActiveBreakpointsResponse responseCancellationToken = await client.ListActiveBreakpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListActiveBreakpoints()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            ListActiveBreakpointsResponse response = client.ListActiveBreakpoints(request.DebuggeeId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListActiveBreakpointsAsync()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
            };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
                WaitExpired = false,
            };
            mockGrpcClient.Setup(x => x.ListActiveBreakpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListActiveBreakpointsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            ListActiveBreakpointsResponse responseCallSettings = await client.ListActiveBreakpointsAsync(request.DebuggeeId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListActiveBreakpointsResponse responseCancellationToken = await client.ListActiveBreakpointsAsync(request.DebuggeeId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateActiveBreakpointRequestObject()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse { };
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            UpdateActiveBreakpointResponse response = client.UpdateActiveBreakpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateActiveBreakpointRequestObjectAsync()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse { };
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UpdateActiveBreakpointResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            UpdateActiveBreakpointResponse responseCallSettings = await client.UpdateActiveBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UpdateActiveBreakpointResponse responseCancellationToken = await client.UpdateActiveBreakpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateActiveBreakpoint()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse { };
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            UpdateActiveBreakpointResponse response = client.UpdateActiveBreakpoint(request.DebuggeeId, request.Breakpoint);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateActiveBreakpointAsync()
        {
            moq::Mock<Controller2.Controller2Client> mockGrpcClient = new moq::Mock<Controller2.Controller2Client>(moq::MockBehavior.Strict);
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
            };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse { };
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UpdateActiveBreakpointResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            UpdateActiveBreakpointResponse responseCallSettings = await client.UpdateActiveBreakpointAsync(request.DebuggeeId, request.Breakpoint, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UpdateActiveBreakpointResponse responseCancellationToken = await client.UpdateActiveBreakpointAsync(request.DebuggeeId, request.Breakpoint, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
