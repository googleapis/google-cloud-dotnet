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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Debugger.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDebugger2ClientTest
    {
        [xunit::FactAttribute]
        public void SetBreakpointRequestObject()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
                ClientVersion = "client_version92be8ead",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.SetBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            SetBreakpointResponse response = client.SetBreakpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetBreakpointRequestObjectAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
                ClientVersion = "client_version92be8ead",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.SetBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SetBreakpointResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            SetBreakpointResponse responseCallSettings = await client.SetBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SetBreakpointResponse responseCancellationToken = await client.SetBreakpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetBreakpoint()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
                ClientVersion = "client_version92be8ead",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.SetBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            SetBreakpointResponse response = client.SetBreakpoint(request.DebuggeeId, request.Breakpoint, request.ClientVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetBreakpointAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                Breakpoint = new Breakpoint(),
                ClientVersion = "client_version92be8ead",
            };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.SetBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SetBreakpointResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            SetBreakpointResponse responseCallSettings = await client.SetBreakpointAsync(request.DebuggeeId, request.Breakpoint, request.ClientVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SetBreakpointResponse responseCancellationToken = await client.SetBreakpointAsync(request.DebuggeeId, request.Breakpoint, request.ClientVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBreakpointRequestObject()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.GetBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            GetBreakpointResponse response = client.GetBreakpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBreakpointRequestObjectAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.GetBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetBreakpointResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            GetBreakpointResponse responseCallSettings = await client.GetBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetBreakpointResponse responseCancellationToken = await client.GetBreakpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBreakpoint()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.GetBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            GetBreakpointResponse response = client.GetBreakpoint(request.DebuggeeId, request.BreakpointId, request.ClientVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBreakpointAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse
            {
                Breakpoint = new Breakpoint(),
            };
            mockGrpcClient.Setup(x => x.GetBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetBreakpointResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            GetBreakpointResponse responseCallSettings = await client.GetBreakpointAsync(request.DebuggeeId, request.BreakpointId, request.ClientVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetBreakpointResponse responseCancellationToken = await client.GetBreakpointAsync(request.DebuggeeId, request.BreakpointId, request.ClientVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBreakpointRequestObject()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteBreakpoint(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBreakpointRequestObjectAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBreakpointAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBreakpoint()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBreakpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteBreakpoint(request.DebuggeeId, request.BreakpointId, request.ClientVersion);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBreakpointAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                BreakpointId = "breakpoint_id5b0a5ee2",
                ClientVersion = "client_version92be8ead",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBreakpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteBreakpointAsync(request.DebuggeeId, request.BreakpointId, request.ClientVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBreakpointAsync(request.DebuggeeId, request.BreakpointId, request.ClientVersion, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListBreakpointsRequestObject()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                IncludeAllUsers = false,
                IncludeInactive = true,
                Action = new ListBreakpointsRequest.Types.BreakpointActionValue(),
#pragma warning disable CS0612
                StripResults = false,
#pragma warning restore CS0612
                WaitToken = "wait_tokencb600154",
                ClientVersion = "client_version92be8ead",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
            };
            mockGrpcClient.Setup(x => x.ListBreakpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListBreakpointsResponse response = client.ListBreakpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListBreakpointsRequestObjectAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                IncludeAllUsers = false,
                IncludeInactive = true,
                Action = new ListBreakpointsRequest.Types.BreakpointActionValue(),
#pragma warning disable CS0612
                StripResults = false,
#pragma warning restore CS0612
                WaitToken = "wait_tokencb600154",
                ClientVersion = "client_version92be8ead",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
            };
            mockGrpcClient.Setup(x => x.ListBreakpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListBreakpointsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListBreakpointsResponse responseCallSettings = await client.ListBreakpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListBreakpointsResponse responseCancellationToken = await client.ListBreakpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListBreakpoints()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                ClientVersion = "client_version92be8ead",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
            };
            mockGrpcClient.Setup(x => x.ListBreakpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListBreakpointsResponse response = client.ListBreakpoints(request.DebuggeeId, request.ClientVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListBreakpointsAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "debuggee_id454a924a",
                ClientVersion = "client_version92be8ead",
            };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                Breakpoints = { new Breakpoint(), },
                NextWaitToken = "next_wait_token2855eb7e",
            };
            mockGrpcClient.Setup(x => x.ListBreakpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListBreakpointsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListBreakpointsResponse responseCallSettings = await client.ListBreakpointsAsync(request.DebuggeeId, request.ClientVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListBreakpointsResponse responseCancellationToken = await client.ListBreakpointsAsync(request.DebuggeeId, request.ClientVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDebuggeesRequestObject()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "projectaa6ff846",
                IncludeInactive = true,
                ClientVersion = "client_version92be8ead",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse
            {
                Debuggees = { new Debuggee(), },
            };
            mockGrpcClient.Setup(x => x.ListDebuggees(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListDebuggeesResponse response = client.ListDebuggees(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDebuggeesRequestObjectAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "projectaa6ff846",
                IncludeInactive = true,
                ClientVersion = "client_version92be8ead",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse
            {
                Debuggees = { new Debuggee(), },
            };
            mockGrpcClient.Setup(x => x.ListDebuggeesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDebuggeesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListDebuggeesResponse responseCallSettings = await client.ListDebuggeesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDebuggeesResponse responseCancellationToken = await client.ListDebuggeesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDebuggees()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "projectaa6ff846",
                ClientVersion = "client_version92be8ead",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse
            {
                Debuggees = { new Debuggee(), },
            };
            mockGrpcClient.Setup(x => x.ListDebuggees(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListDebuggeesResponse response = client.ListDebuggees(request.Project, request.ClientVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDebuggeesAsync()
        {
            moq::Mock<Debugger2.Debugger2Client> mockGrpcClient = new moq::Mock<Debugger2.Debugger2Client>(moq::MockBehavior.Strict);
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "projectaa6ff846",
                ClientVersion = "client_version92be8ead",
            };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse
            {
                Debuggees = { new Debuggee(), },
            };
            mockGrpcClient.Setup(x => x.ListDebuggeesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDebuggeesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null, null);
            ListDebuggeesResponse responseCallSettings = await client.ListDebuggeesAsync(request.Project, request.ClientVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDebuggeesResponse responseCancellationToken = await client.ListDebuggeesAsync(request.Project, request.ClientVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
