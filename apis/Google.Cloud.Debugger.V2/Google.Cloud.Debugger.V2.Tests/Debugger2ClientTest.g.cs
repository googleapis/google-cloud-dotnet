// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Debugger.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDebugger2ClientTest
    {
        [Fact]
        public void SetBreakpointTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client> { DefaultValue = DefaultValue.Mock };
            SetBreakpointResponse expectedResponse = new SetBreakpointResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetBreakpoint(It.IsAny<SetBreakpointRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            Breakpoint breakpoint = new Breakpoint();
            string clientVersion = "clientVersion-1506231196";
            SetBreakpointResponse response = client.SetBreakpoint(debuggeeId, breakpoint, clientVersion);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetBreakpointTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client> { DefaultValue = DefaultValue.Mock };
            GetBreakpointResponse expectedResponse = new GetBreakpointResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetBreakpoint(It.IsAny<GetBreakpointRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string breakpointId = "breakpointId498424873";
            string clientVersion = "clientVersion-1506231196";
            GetBreakpointResponse response = client.GetBreakpoint(debuggeeId, breakpointId, clientVersion);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteBreakpointTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteBreakpoint(It.IsAny<DeleteBreakpointRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string breakpointId = "breakpointId498424873";
            string clientVersion = "clientVersion-1506231196";
            client.DeleteBreakpoint(debuggeeId, breakpointId, clientVersion);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListBreakpointsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client> { DefaultValue = DefaultValue.Mock };
            ListBreakpointsResponse expectedResponse = new ListBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListBreakpoints(It.IsAny<ListBreakpointsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            string clientVersion = "clientVersion-1506231196";
            ListBreakpointsResponse response = client.ListBreakpoints(debuggeeId, clientVersion);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListDebuggeesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Debugger2.Debugger2Client> mockGrpcClient = new Mock<Debugger2.Debugger2Client> { DefaultValue = DefaultValue.Mock };
            ListDebuggeesResponse expectedResponse = new ListDebuggeesResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListDebuggees(It.IsAny<ListDebuggeesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Debugger2Client client = new Debugger2ClientImpl(mockGrpcClient.Object, null);
            string project = "project-309310695";
            string clientVersion = "clientVersion-1506231196";
            ListDebuggeesResponse response = client.ListDebuggees(project, clientVersion);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
