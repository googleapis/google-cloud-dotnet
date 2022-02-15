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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Trace.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTraceServiceClientTest
    {
        [xunit::FactAttribute]
        public void BatchWriteSpansRequestObject()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchWriteSpans(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchWriteSpans(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchWriteSpansRequestObjectAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchWriteSpansAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchWriteSpansAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchWriteSpansAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchWriteSpans()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchWriteSpans(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchWriteSpans(request.Name, request.Spans);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchWriteSpansAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchWriteSpansAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchWriteSpansAsync(request.Name, request.Spans, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchWriteSpansAsync(request.Name, request.Spans, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchWriteSpansResourceNames()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchWriteSpans(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchWriteSpans(request.ProjectName, request.Spans);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchWriteSpansResourceNamesAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchWriteSpansAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchWriteSpansAsync(request.ProjectName, request.Spans, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchWriteSpansAsync(request.ProjectName, request.Spans, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSpanRequestObject()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            Span request = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "span_id47c232d3",
                ParentSpanId = "parent_span_ide637f6a2",
                DisplayName = new TruncatableString(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Attributes = new Span.Types.Attributes(),
                StackTrace = new StackTrace(),
                TimeEvents = new Span.Types.TimeEvents(),
                Links = new Span.Types.Links(),
                Status = new gr::Status(),
                SameProcessAsParentSpan = false,
                ChildSpanCount = -1491694397,
                SpanKind = Span.Types.SpanKind.Consumer,
            };
            Span expectedResponse = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "span_id47c232d3",
                ParentSpanId = "parent_span_ide637f6a2",
                DisplayName = new TruncatableString(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Attributes = new Span.Types.Attributes(),
                StackTrace = new StackTrace(),
                TimeEvents = new Span.Types.TimeEvents(),
                Links = new Span.Types.Links(),
                Status = new gr::Status(),
                SameProcessAsParentSpan = false,
                ChildSpanCount = -1491694397,
                SpanKind = Span.Types.SpanKind.Consumer,
            };
            mockGrpcClient.Setup(x => x.CreateSpan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            Span response = client.CreateSpan(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSpanRequestObjectAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            Span request = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "span_id47c232d3",
                ParentSpanId = "parent_span_ide637f6a2",
                DisplayName = new TruncatableString(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Attributes = new Span.Types.Attributes(),
                StackTrace = new StackTrace(),
                TimeEvents = new Span.Types.TimeEvents(),
                Links = new Span.Types.Links(),
                Status = new gr::Status(),
                SameProcessAsParentSpan = false,
                ChildSpanCount = -1491694397,
                SpanKind = Span.Types.SpanKind.Consumer,
            };
            Span expectedResponse = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "span_id47c232d3",
                ParentSpanId = "parent_span_ide637f6a2",
                DisplayName = new TruncatableString(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Attributes = new Span.Types.Attributes(),
                StackTrace = new StackTrace(),
                TimeEvents = new Span.Types.TimeEvents(),
                Links = new Span.Types.Links(),
                Status = new gr::Status(),
                SameProcessAsParentSpan = false,
                ChildSpanCount = -1491694397,
                SpanKind = Span.Types.SpanKind.Consumer,
            };
            mockGrpcClient.Setup(x => x.CreateSpanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Span>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null);
            Span responseCallSettings = await client.CreateSpanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Span responseCancellationToken = await client.CreateSpanAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
