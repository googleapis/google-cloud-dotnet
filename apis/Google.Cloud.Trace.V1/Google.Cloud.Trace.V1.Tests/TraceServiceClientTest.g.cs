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

namespace Google.Cloud.Trace.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Trace.V1;
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
    public class GeneratedTraceServiceClientTest
    {
        [Fact]
        public void PatchTraces()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            PatchTracesRequest expectedRequest = new PatchTracesRequest
            {
                ProjectId = "projectId-1969970175",
                Traces = new Traces(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.PatchTraces(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            Traces traces = new Traces();
            client.PatchTraces(projectId, traces);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PatchTracesAsync()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            PatchTracesRequest expectedRequest = new PatchTracesRequest
            {
                ProjectId = "projectId-1969970175",
                Traces = new Traces(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.PatchTracesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            Traces traces = new Traces();
            await client.PatchTracesAsync(projectId, traces);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PatchTraces2()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "projectId-1969970175",
                Traces = new Traces(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.PatchTraces(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            client.PatchTraces(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PatchTracesAsync2()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "projectId-1969970175",
                Traces = new Traces(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.PatchTracesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            await client.PatchTracesAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTrace()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            GetTraceRequest expectedRequest = new GetTraceRequest
            {
                ProjectId = "projectId-1969970175",
                TraceId = "traceId1270300245",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "projectId2939242356",
                TraceId = "traceId2987826376",
            };
            mockGrpcClient.Setup(x => x.GetTrace(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string traceId = "traceId1270300245";
            Trace response = client.GetTrace(projectId, traceId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTraceAsync()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            GetTraceRequest expectedRequest = new GetTraceRequest
            {
                ProjectId = "projectId-1969970175",
                TraceId = "traceId1270300245",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "projectId2939242356",
                TraceId = "traceId2987826376",
            };
            mockGrpcClient.Setup(x => x.GetTraceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Trace>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string traceId = "traceId1270300245";
            Trace response = await client.GetTraceAsync(projectId, traceId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTrace2()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "projectId-1969970175",
                TraceId = "traceId1270300245",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "projectId2939242356",
                TraceId = "traceId2987826376",
            };
            mockGrpcClient.Setup(x => x.GetTrace(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            Trace response = client.GetTrace(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTraceAsync2()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "projectId-1969970175",
                TraceId = "traceId1270300245",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "projectId2939242356",
                TraceId = "traceId2987826376",
            };
            mockGrpcClient.Setup(x => x.GetTraceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Trace>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            Trace response = await client.GetTraceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
