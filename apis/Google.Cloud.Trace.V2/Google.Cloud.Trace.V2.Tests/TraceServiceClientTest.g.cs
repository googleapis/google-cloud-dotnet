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

namespace Google.Cloud.Trace.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Trace.V2;
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
            IEnumerable<apis::Span> spans = new List<apis::Span>();
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
            IEnumerable<apis::Span> spans = new List<apis::Span>();
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

        [Fact]
        public void CreateSpan()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            apis::Span request = new apis::Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "spanId-2011840976",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            apis::Span expectedResponse = new apis::Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "spanId2-643891741",
                ParentSpanId = "parentSpanId-1757797477",
            };
            mockGrpcClient.Setup(x => x.CreateSpan(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            apis::Span response = client.CreateSpan(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSpanAsync()
        {
            Mock<TraceService.TraceServiceClient> mockGrpcClient = new Mock<TraceService.TraceServiceClient>(MockBehavior.Strict);
            apis::Span request = new apis::Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "spanId-2011840976",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            apis::Span expectedResponse = new apis::Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "spanId2-643891741",
                ParentSpanId = "parentSpanId-1757797477",
            };
            mockGrpcClient.Setup(x => x.CreateSpanAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Span>(Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            apis::Span response = await client.CreateSpanAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
