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
    public class GeneratedController2ClientTest
    {
        [Fact]
        public void RegisterDebuggeeTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client> { DefaultValue = DefaultValue.Mock };
            RegisterDebuggeeResponse expectedResponse = new RegisterDebuggeeResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.RegisterDebuggee(It.IsAny<RegisterDebuggeeRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            Debuggee debuggee = new Debuggee();
            RegisterDebuggeeResponse response = client.RegisterDebuggee(debuggee);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListActiveBreakpointsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client> { DefaultValue = DefaultValue.Mock };
            ListActiveBreakpointsResponse expectedResponse = new ListActiveBreakpointsResponse
            {
                NextWaitToken = "nextWaitToken1006864251",
                WaitExpired = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListActiveBreakpoints(It.IsAny<ListActiveBreakpointsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            ListActiveBreakpointsResponse response = client.ListActiveBreakpoints(debuggeeId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateActiveBreakpointTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Controller2.Controller2Client> mockGrpcClient = new Mock<Controller2.Controller2Client> { DefaultValue = DefaultValue.Mock };
            UpdateActiveBreakpointResponse expectedResponse = new UpdateActiveBreakpointResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateActiveBreakpoint(It.IsAny<UpdateActiveBreakpointRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            Controller2Client client = new Controller2ClientImpl(mockGrpcClient.Object, null);
            string debuggeeId = "debuggeeId-997255898";
            Breakpoint breakpoint = new Breakpoint();
            UpdateActiveBreakpointResponse response = client.UpdateActiveBreakpoint(debuggeeId, breakpoint);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
