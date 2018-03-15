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

namespace Google.Cloud.Trace.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedTraceServiceClientTest
    {
        [Fact]
        public void PatchTracesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.PatchTraces(It.IsAny<PatchTracesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            Traces traces = new Traces();
            client.PatchTraces(projectId, traces);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTraceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient> { DefaultValue = DefaultValue.Mock };
            Trace expectedResponse = new Trace
            {
                ProjectId = "projectId2939242356",
                TraceId = "traceId2987826376",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetTrace(It.IsAny<GetTraceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string traceId = "traceId1270300245";
            Trace response = client.GetTrace(projectId, traceId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
