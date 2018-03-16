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

namespace Google.Cloud.Trace.V2.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedTraceServiceClientTest
    {
        [Fact]
        public void BatchWriteSpans()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            BatchWriteSpansRequest expectedRequest = new BatchWriteSpansRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Spans = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchWriteSpans(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<Span> spans = new List<Span>();
            client.BatchWriteSpans(name, spans);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchWriteSpansAsync()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            BatchWriteSpansRequest expectedRequest = new BatchWriteSpansRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Spans = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchWriteSpansAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<Span> spans = new List<Span>();
            await client.BatchWriteSpansAsync(name, spans);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchWriteSpans2()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Spans = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchWriteSpans(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchWriteSpans(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchWriteSpansAsync2()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Spans = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchWriteSpansAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchWriteSpansAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
