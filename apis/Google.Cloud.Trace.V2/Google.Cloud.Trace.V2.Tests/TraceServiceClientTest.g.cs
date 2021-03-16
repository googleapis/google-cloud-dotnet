// Copyright 2021 Google LLC
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
using proto = Google.Protobuf;
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
                Spans =
                {
                    new Span
                    {
                        SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                        SpanId = "span_id47c232d3",
                        ParentSpanId = "parent_span_ide637f6a2",
                        DisplayName = new TruncatableString
                        {
                            Value = "value60c16320",
                            TruncatedByteCount = 2128325585,
                        },
                        StartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        EndTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Attributes = new Span.Types.Attributes
                        {
                            AttributeMap =
                            {
                                {
                                    "key8a0b6e3c",
                                    new AttributeValue
                                    {
                                        StringValue = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        IntValue = 6964907734533641939L,
                                        BoolValue = false,
                                    }
                                },
                            },
                            DroppedAttributesCount = -943197187,
                        },
                        StackTrace = new StackTrace
                        {
                            StackFrames = new StackTrace.Types.StackFrames
                            {
                                Frame =
                                {
                                    new StackTrace.Types.StackFrame
                                    {
                                        FunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        OriginalFunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        FileName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        LineNumber = -6767150858782418247L,
                                        ColumnNumber = -1645305070928801317L,
                                        LoadModule = new Module
                                        {
                                            Module_ = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            BuildId = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                        },
                                        SourceVersion = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                    },
                                },
                                DroppedFramesCount = -530937800,
                            },
                            StackTraceHashId = -3233071409397891082L,
                        },
                        TimeEvents = new Span.Types.TimeEvents
                        {
                            TimeEvent =
                            {
                                new Span.Types.TimeEvent
                                {
                                    Time = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Annotation = new Span.Types.TimeEvent.Types.Annotation
                                    {
                                        Description = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        Attributes = new Span.Types.Attributes
                                        {
                                            AttributeMap =
                                            {
                                                {
                                                    "key8a0b6e3c",
                                                    new AttributeValue
                                                    {
                                                        StringValue = new TruncatableString
                                                        {
                                                            Value = "value60c16320",
                                                            TruncatedByteCount = 2128325585,
                                                        },
                                                        IntValue = 6964907734533641939L,
                                                        BoolValue = false,
                                                    }
                                                },
                                            },
                                            DroppedAttributesCount = -943197187,
                                        },
                                    },
                                    MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                                    {
                                        Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                        Id = -6774108720365892680L,
                                        UncompressedSizeBytes = 7207111653247989525L,
                                        CompressedSizeBytes = -5863566423773706985L,
                                    },
                                },
                            },
                            DroppedAnnotationsCount = -1339084470,
                            DroppedMessageEventsCount = -2043953306,
                        },
                        Links = new Span.Types.Links
                        {
                            Link =
                            {
                                new Span.Types.Link
                                {
                                    TraceId = "trace_id105c890f",
                                    SpanId = "span_id47c232d3",
                                    Type = Span.Types.Link.Types.Type.Unspecified,
                                    Attributes = new Span.Types.Attributes
                                    {
                                        AttributeMap =
                                        {
                                            {
                                                "key8a0b6e3c",
                                                new AttributeValue
                                                {
                                                    StringValue = new TruncatableString
                                                    {
                                                        Value = "value60c16320",
                                                        TruncatedByteCount = 2128325585,
                                                    },
                                                    IntValue = 6964907734533641939L,
                                                    BoolValue = false,
                                                }
                                            },
                                        },
                                        DroppedAttributesCount = -943197187,
                                    },
                                },
                            },
                            DroppedLinksCount = 996193750,
                        },
                        Status = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        SameProcessAsParentSpan = false,
                        ChildSpanCount = -1491694397,
                        SpanKind = Span.Types.SpanKind.Consumer,
                    },
                },
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
                Spans =
                {
                    new Span
                    {
                        SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                        SpanId = "span_id47c232d3",
                        ParentSpanId = "parent_span_ide637f6a2",
                        DisplayName = new TruncatableString
                        {
                            Value = "value60c16320",
                            TruncatedByteCount = 2128325585,
                        },
                        StartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        EndTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Attributes = new Span.Types.Attributes
                        {
                            AttributeMap =
                            {
                                {
                                    "key8a0b6e3c",
                                    new AttributeValue
                                    {
                                        StringValue = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        IntValue = 6964907734533641939L,
                                        BoolValue = false,
                                    }
                                },
                            },
                            DroppedAttributesCount = -943197187,
                        },
                        StackTrace = new StackTrace
                        {
                            StackFrames = new StackTrace.Types.StackFrames
                            {
                                Frame =
                                {
                                    new StackTrace.Types.StackFrame
                                    {
                                        FunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        OriginalFunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        FileName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        LineNumber = -6767150858782418247L,
                                        ColumnNumber = -1645305070928801317L,
                                        LoadModule = new Module
                                        {
                                            Module_ = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            BuildId = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                        },
                                        SourceVersion = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                    },
                                },
                                DroppedFramesCount = -530937800,
                            },
                            StackTraceHashId = -3233071409397891082L,
                        },
                        TimeEvents = new Span.Types.TimeEvents
                        {
                            TimeEvent =
                            {
                                new Span.Types.TimeEvent
                                {
                                    Time = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Annotation = new Span.Types.TimeEvent.Types.Annotation
                                    {
                                        Description = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        Attributes = new Span.Types.Attributes
                                        {
                                            AttributeMap =
                                            {
                                                {
                                                    "key8a0b6e3c",
                                                    new AttributeValue
                                                    {
                                                        StringValue = new TruncatableString
                                                        {
                                                            Value = "value60c16320",
                                                            TruncatedByteCount = 2128325585,
                                                        },
                                                        IntValue = 6964907734533641939L,
                                                        BoolValue = false,
                                                    }
                                                },
                                            },
                                            DroppedAttributesCount = -943197187,
                                        },
                                    },
                                    MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                                    {
                                        Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                        Id = -6774108720365892680L,
                                        UncompressedSizeBytes = 7207111653247989525L,
                                        CompressedSizeBytes = -5863566423773706985L,
                                    },
                                },
                            },
                            DroppedAnnotationsCount = -1339084470,
                            DroppedMessageEventsCount = -2043953306,
                        },
                        Links = new Span.Types.Links
                        {
                            Link =
                            {
                                new Span.Types.Link
                                {
                                    TraceId = "trace_id105c890f",
                                    SpanId = "span_id47c232d3",
                                    Type = Span.Types.Link.Types.Type.Unspecified,
                                    Attributes = new Span.Types.Attributes
                                    {
                                        AttributeMap =
                                        {
                                            {
                                                "key8a0b6e3c",
                                                new AttributeValue
                                                {
                                                    StringValue = new TruncatableString
                                                    {
                                                        Value = "value60c16320",
                                                        TruncatedByteCount = 2128325585,
                                                    },
                                                    IntValue = 6964907734533641939L,
                                                    BoolValue = false,
                                                }
                                            },
                                        },
                                        DroppedAttributesCount = -943197187,
                                    },
                                },
                            },
                            DroppedLinksCount = 996193750,
                        },
                        Status = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        SameProcessAsParentSpan = false,
                        ChildSpanCount = -1491694397,
                        SpanKind = Span.Types.SpanKind.Consumer,
                    },
                },
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
                Spans =
                {
                    new Span
                    {
                        SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                        SpanId = "span_id47c232d3",
                        ParentSpanId = "parent_span_ide637f6a2",
                        DisplayName = new TruncatableString
                        {
                            Value = "value60c16320",
                            TruncatedByteCount = 2128325585,
                        },
                        StartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        EndTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Attributes = new Span.Types.Attributes
                        {
                            AttributeMap =
                            {
                                {
                                    "key8a0b6e3c",
                                    new AttributeValue
                                    {
                                        StringValue = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        IntValue = 6964907734533641939L,
                                        BoolValue = false,
                                    }
                                },
                            },
                            DroppedAttributesCount = -943197187,
                        },
                        StackTrace = new StackTrace
                        {
                            StackFrames = new StackTrace.Types.StackFrames
                            {
                                Frame =
                                {
                                    new StackTrace.Types.StackFrame
                                    {
                                        FunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        OriginalFunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        FileName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        LineNumber = -6767150858782418247L,
                                        ColumnNumber = -1645305070928801317L,
                                        LoadModule = new Module
                                        {
                                            Module_ = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            BuildId = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                        },
                                        SourceVersion = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                    },
                                },
                                DroppedFramesCount = -530937800,
                            },
                            StackTraceHashId = -3233071409397891082L,
                        },
                        TimeEvents = new Span.Types.TimeEvents
                        {
                            TimeEvent =
                            {
                                new Span.Types.TimeEvent
                                {
                                    Time = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Annotation = new Span.Types.TimeEvent.Types.Annotation
                                    {
                                        Description = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        Attributes = new Span.Types.Attributes
                                        {
                                            AttributeMap =
                                            {
                                                {
                                                    "key8a0b6e3c",
                                                    new AttributeValue
                                                    {
                                                        StringValue = new TruncatableString
                                                        {
                                                            Value = "value60c16320",
                                                            TruncatedByteCount = 2128325585,
                                                        },
                                                        IntValue = 6964907734533641939L,
                                                        BoolValue = false,
                                                    }
                                                },
                                            },
                                            DroppedAttributesCount = -943197187,
                                        },
                                    },
                                    MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                                    {
                                        Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                        Id = -6774108720365892680L,
                                        UncompressedSizeBytes = 7207111653247989525L,
                                        CompressedSizeBytes = -5863566423773706985L,
                                    },
                                },
                            },
                            DroppedAnnotationsCount = -1339084470,
                            DroppedMessageEventsCount = -2043953306,
                        },
                        Links = new Span.Types.Links
                        {
                            Link =
                            {
                                new Span.Types.Link
                                {
                                    TraceId = "trace_id105c890f",
                                    SpanId = "span_id47c232d3",
                                    Type = Span.Types.Link.Types.Type.Unspecified,
                                    Attributes = new Span.Types.Attributes
                                    {
                                        AttributeMap =
                                        {
                                            {
                                                "key8a0b6e3c",
                                                new AttributeValue
                                                {
                                                    StringValue = new TruncatableString
                                                    {
                                                        Value = "value60c16320",
                                                        TruncatedByteCount = 2128325585,
                                                    },
                                                    IntValue = 6964907734533641939L,
                                                    BoolValue = false,
                                                }
                                            },
                                        },
                                        DroppedAttributesCount = -943197187,
                                    },
                                },
                            },
                            DroppedLinksCount = 996193750,
                        },
                        Status = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        SameProcessAsParentSpan = false,
                        ChildSpanCount = -1491694397,
                        SpanKind = Span.Types.SpanKind.Consumer,
                    },
                },
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
                Spans =
                {
                    new Span
                    {
                        SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                        SpanId = "span_id47c232d3",
                        ParentSpanId = "parent_span_ide637f6a2",
                        DisplayName = new TruncatableString
                        {
                            Value = "value60c16320",
                            TruncatedByteCount = 2128325585,
                        },
                        StartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        EndTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Attributes = new Span.Types.Attributes
                        {
                            AttributeMap =
                            {
                                {
                                    "key8a0b6e3c",
                                    new AttributeValue
                                    {
                                        StringValue = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        IntValue = 6964907734533641939L,
                                        BoolValue = false,
                                    }
                                },
                            },
                            DroppedAttributesCount = -943197187,
                        },
                        StackTrace = new StackTrace
                        {
                            StackFrames = new StackTrace.Types.StackFrames
                            {
                                Frame =
                                {
                                    new StackTrace.Types.StackFrame
                                    {
                                        FunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        OriginalFunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        FileName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        LineNumber = -6767150858782418247L,
                                        ColumnNumber = -1645305070928801317L,
                                        LoadModule = new Module
                                        {
                                            Module_ = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            BuildId = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                        },
                                        SourceVersion = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                    },
                                },
                                DroppedFramesCount = -530937800,
                            },
                            StackTraceHashId = -3233071409397891082L,
                        },
                        TimeEvents = new Span.Types.TimeEvents
                        {
                            TimeEvent =
                            {
                                new Span.Types.TimeEvent
                                {
                                    Time = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Annotation = new Span.Types.TimeEvent.Types.Annotation
                                    {
                                        Description = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        Attributes = new Span.Types.Attributes
                                        {
                                            AttributeMap =
                                            {
                                                {
                                                    "key8a0b6e3c",
                                                    new AttributeValue
                                                    {
                                                        StringValue = new TruncatableString
                                                        {
                                                            Value = "value60c16320",
                                                            TruncatedByteCount = 2128325585,
                                                        },
                                                        IntValue = 6964907734533641939L,
                                                        BoolValue = false,
                                                    }
                                                },
                                            },
                                            DroppedAttributesCount = -943197187,
                                        },
                                    },
                                    MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                                    {
                                        Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                        Id = -6774108720365892680L,
                                        UncompressedSizeBytes = 7207111653247989525L,
                                        CompressedSizeBytes = -5863566423773706985L,
                                    },
                                },
                            },
                            DroppedAnnotationsCount = -1339084470,
                            DroppedMessageEventsCount = -2043953306,
                        },
                        Links = new Span.Types.Links
                        {
                            Link =
                            {
                                new Span.Types.Link
                                {
                                    TraceId = "trace_id105c890f",
                                    SpanId = "span_id47c232d3",
                                    Type = Span.Types.Link.Types.Type.Unspecified,
                                    Attributes = new Span.Types.Attributes
                                    {
                                        AttributeMap =
                                        {
                                            {
                                                "key8a0b6e3c",
                                                new AttributeValue
                                                {
                                                    StringValue = new TruncatableString
                                                    {
                                                        Value = "value60c16320",
                                                        TruncatedByteCount = 2128325585,
                                                    },
                                                    IntValue = 6964907734533641939L,
                                                    BoolValue = false,
                                                }
                                            },
                                        },
                                        DroppedAttributesCount = -943197187,
                                    },
                                },
                            },
                            DroppedLinksCount = 996193750,
                        },
                        Status = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        SameProcessAsParentSpan = false,
                        ChildSpanCount = -1491694397,
                        SpanKind = Span.Types.SpanKind.Consumer,
                    },
                },
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
                Spans =
                {
                    new Span
                    {
                        SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                        SpanId = "span_id47c232d3",
                        ParentSpanId = "parent_span_ide637f6a2",
                        DisplayName = new TruncatableString
                        {
                            Value = "value60c16320",
                            TruncatedByteCount = 2128325585,
                        },
                        StartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        EndTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Attributes = new Span.Types.Attributes
                        {
                            AttributeMap =
                            {
                                {
                                    "key8a0b6e3c",
                                    new AttributeValue
                                    {
                                        StringValue = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        IntValue = 6964907734533641939L,
                                        BoolValue = false,
                                    }
                                },
                            },
                            DroppedAttributesCount = -943197187,
                        },
                        StackTrace = new StackTrace
                        {
                            StackFrames = new StackTrace.Types.StackFrames
                            {
                                Frame =
                                {
                                    new StackTrace.Types.StackFrame
                                    {
                                        FunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        OriginalFunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        FileName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        LineNumber = -6767150858782418247L,
                                        ColumnNumber = -1645305070928801317L,
                                        LoadModule = new Module
                                        {
                                            Module_ = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            BuildId = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                        },
                                        SourceVersion = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                    },
                                },
                                DroppedFramesCount = -530937800,
                            },
                            StackTraceHashId = -3233071409397891082L,
                        },
                        TimeEvents = new Span.Types.TimeEvents
                        {
                            TimeEvent =
                            {
                                new Span.Types.TimeEvent
                                {
                                    Time = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Annotation = new Span.Types.TimeEvent.Types.Annotation
                                    {
                                        Description = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        Attributes = new Span.Types.Attributes
                                        {
                                            AttributeMap =
                                            {
                                                {
                                                    "key8a0b6e3c",
                                                    new AttributeValue
                                                    {
                                                        StringValue = new TruncatableString
                                                        {
                                                            Value = "value60c16320",
                                                            TruncatedByteCount = 2128325585,
                                                        },
                                                        IntValue = 6964907734533641939L,
                                                        BoolValue = false,
                                                    }
                                                },
                                            },
                                            DroppedAttributesCount = -943197187,
                                        },
                                    },
                                    MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                                    {
                                        Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                        Id = -6774108720365892680L,
                                        UncompressedSizeBytes = 7207111653247989525L,
                                        CompressedSizeBytes = -5863566423773706985L,
                                    },
                                },
                            },
                            DroppedAnnotationsCount = -1339084470,
                            DroppedMessageEventsCount = -2043953306,
                        },
                        Links = new Span.Types.Links
                        {
                            Link =
                            {
                                new Span.Types.Link
                                {
                                    TraceId = "trace_id105c890f",
                                    SpanId = "span_id47c232d3",
                                    Type = Span.Types.Link.Types.Type.Unspecified,
                                    Attributes = new Span.Types.Attributes
                                    {
                                        AttributeMap =
                                        {
                                            {
                                                "key8a0b6e3c",
                                                new AttributeValue
                                                {
                                                    StringValue = new TruncatableString
                                                    {
                                                        Value = "value60c16320",
                                                        TruncatedByteCount = 2128325585,
                                                    },
                                                    IntValue = 6964907734533641939L,
                                                    BoolValue = false,
                                                }
                                            },
                                        },
                                        DroppedAttributesCount = -943197187,
                                    },
                                },
                            },
                            DroppedLinksCount = 996193750,
                        },
                        Status = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        SameProcessAsParentSpan = false,
                        ChildSpanCount = -1491694397,
                        SpanKind = Span.Types.SpanKind.Consumer,
                    },
                },
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
                Spans =
                {
                    new Span
                    {
                        SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                        SpanId = "span_id47c232d3",
                        ParentSpanId = "parent_span_ide637f6a2",
                        DisplayName = new TruncatableString
                        {
                            Value = "value60c16320",
                            TruncatedByteCount = 2128325585,
                        },
                        StartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        EndTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Attributes = new Span.Types.Attributes
                        {
                            AttributeMap =
                            {
                                {
                                    "key8a0b6e3c",
                                    new AttributeValue
                                    {
                                        StringValue = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        IntValue = 6964907734533641939L,
                                        BoolValue = false,
                                    }
                                },
                            },
                            DroppedAttributesCount = -943197187,
                        },
                        StackTrace = new StackTrace
                        {
                            StackFrames = new StackTrace.Types.StackFrames
                            {
                                Frame =
                                {
                                    new StackTrace.Types.StackFrame
                                    {
                                        FunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        OriginalFunctionName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        FileName = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        LineNumber = -6767150858782418247L,
                                        ColumnNumber = -1645305070928801317L,
                                        LoadModule = new Module
                                        {
                                            Module_ = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            BuildId = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                        },
                                        SourceVersion = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                    },
                                },
                                DroppedFramesCount = -530937800,
                            },
                            StackTraceHashId = -3233071409397891082L,
                        },
                        TimeEvents = new Span.Types.TimeEvents
                        {
                            TimeEvent =
                            {
                                new Span.Types.TimeEvent
                                {
                                    Time = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Annotation = new Span.Types.TimeEvent.Types.Annotation
                                    {
                                        Description = new TruncatableString
                                        {
                                            Value = "value60c16320",
                                            TruncatedByteCount = 2128325585,
                                        },
                                        Attributes = new Span.Types.Attributes
                                        {
                                            AttributeMap =
                                            {
                                                {
                                                    "key8a0b6e3c",
                                                    new AttributeValue
                                                    {
                                                        StringValue = new TruncatableString
                                                        {
                                                            Value = "value60c16320",
                                                            TruncatedByteCount = 2128325585,
                                                        },
                                                        IntValue = 6964907734533641939L,
                                                        BoolValue = false,
                                                    }
                                                },
                                            },
                                            DroppedAttributesCount = -943197187,
                                        },
                                    },
                                    MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                                    {
                                        Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                        Id = -6774108720365892680L,
                                        UncompressedSizeBytes = 7207111653247989525L,
                                        CompressedSizeBytes = -5863566423773706985L,
                                    },
                                },
                            },
                            DroppedAnnotationsCount = -1339084470,
                            DroppedMessageEventsCount = -2043953306,
                        },
                        Links = new Span.Types.Links
                        {
                            Link =
                            {
                                new Span.Types.Link
                                {
                                    TraceId = "trace_id105c890f",
                                    SpanId = "span_id47c232d3",
                                    Type = Span.Types.Link.Types.Type.Unspecified,
                                    Attributes = new Span.Types.Attributes
                                    {
                                        AttributeMap =
                                        {
                                            {
                                                "key8a0b6e3c",
                                                new AttributeValue
                                                {
                                                    StringValue = new TruncatableString
                                                    {
                                                        Value = "value60c16320",
                                                        TruncatedByteCount = 2128325585,
                                                    },
                                                    IntValue = 6964907734533641939L,
                                                    BoolValue = false,
                                                }
                                            },
                                        },
                                        DroppedAttributesCount = -943197187,
                                    },
                                },
                            },
                            DroppedLinksCount = 996193750,
                        },
                        Status = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        SameProcessAsParentSpan = false,
                        ChildSpanCount = -1491694397,
                        SpanKind = Span.Types.SpanKind.Consumer,
                    },
                },
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
                DisplayName = new TruncatableString
                {
                    Value = "value60c16320",
                    TruncatedByteCount = 2128325585,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Attributes = new Span.Types.Attributes
                {
                    AttributeMap =
                    {
                        {
                            "key8a0b6e3c",
                            new AttributeValue
                            {
                                StringValue = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                IntValue = 6964907734533641939L,
                                BoolValue = false,
                            }
                        },
                    },
                    DroppedAttributesCount = -943197187,
                },
                StackTrace = new StackTrace
                {
                    StackFrames = new StackTrace.Types.StackFrames
                    {
                        Frame =
                        {
                            new StackTrace.Types.StackFrame
                            {
                                FunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                OriginalFunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                FileName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                LineNumber = -6767150858782418247L,
                                ColumnNumber = -1645305070928801317L,
                                LoadModule = new Module
                                {
                                    Module_ = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                    BuildId = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                },
                                SourceVersion = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                            },
                        },
                        DroppedFramesCount = -530937800,
                    },
                    StackTraceHashId = -3233071409397891082L,
                },
                TimeEvents = new Span.Types.TimeEvents
                {
                    TimeEvent =
                    {
                        new Span.Types.TimeEvent
                        {
                            Time = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Annotation = new Span.Types.TimeEvent.Types.Annotation
                            {
                                Description = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                Attributes = new Span.Types.Attributes
                                {
                                    AttributeMap =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new AttributeValue
                                            {
                                                StringValue = new TruncatableString
                                                {
                                                    Value = "value60c16320",
                                                    TruncatedByteCount = 2128325585,
                                                },
                                                IntValue = 6964907734533641939L,
                                                BoolValue = false,
                                            }
                                        },
                                    },
                                    DroppedAttributesCount = -943197187,
                                },
                            },
                            MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                            {
                                Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                Id = -6774108720365892680L,
                                UncompressedSizeBytes = 7207111653247989525L,
                                CompressedSizeBytes = -5863566423773706985L,
                            },
                        },
                    },
                    DroppedAnnotationsCount = -1339084470,
                    DroppedMessageEventsCount = -2043953306,
                },
                Links = new Span.Types.Links
                {
                    Link =
                    {
                        new Span.Types.Link
                        {
                            TraceId = "trace_id105c890f",
                            SpanId = "span_id47c232d3",
                            Type = Span.Types.Link.Types.Type.Unspecified,
                            Attributes = new Span.Types.Attributes
                            {
                                AttributeMap =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AttributeValue
                                        {
                                            StringValue = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            IntValue = 6964907734533641939L,
                                            BoolValue = false,
                                        }
                                    },
                                },
                                DroppedAttributesCount = -943197187,
                            },
                        },
                    },
                    DroppedLinksCount = 996193750,
                },
                Status = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                SameProcessAsParentSpan = false,
                ChildSpanCount = -1491694397,
                SpanKind = Span.Types.SpanKind.Consumer,
            };
            Span expectedResponse = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "span_id47c232d3",
                ParentSpanId = "parent_span_ide637f6a2",
                DisplayName = new TruncatableString
                {
                    Value = "value60c16320",
                    TruncatedByteCount = 2128325585,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Attributes = new Span.Types.Attributes
                {
                    AttributeMap =
                    {
                        {
                            "key8a0b6e3c",
                            new AttributeValue
                            {
                                StringValue = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                IntValue = 6964907734533641939L,
                                BoolValue = false,
                            }
                        },
                    },
                    DroppedAttributesCount = -943197187,
                },
                StackTrace = new StackTrace
                {
                    StackFrames = new StackTrace.Types.StackFrames
                    {
                        Frame =
                        {
                            new StackTrace.Types.StackFrame
                            {
                                FunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                OriginalFunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                FileName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                LineNumber = -6767150858782418247L,
                                ColumnNumber = -1645305070928801317L,
                                LoadModule = new Module
                                {
                                    Module_ = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                    BuildId = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                },
                                SourceVersion = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                            },
                        },
                        DroppedFramesCount = -530937800,
                    },
                    StackTraceHashId = -3233071409397891082L,
                },
                TimeEvents = new Span.Types.TimeEvents
                {
                    TimeEvent =
                    {
                        new Span.Types.TimeEvent
                        {
                            Time = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Annotation = new Span.Types.TimeEvent.Types.Annotation
                            {
                                Description = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                Attributes = new Span.Types.Attributes
                                {
                                    AttributeMap =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new AttributeValue
                                            {
                                                StringValue = new TruncatableString
                                                {
                                                    Value = "value60c16320",
                                                    TruncatedByteCount = 2128325585,
                                                },
                                                IntValue = 6964907734533641939L,
                                                BoolValue = false,
                                            }
                                        },
                                    },
                                    DroppedAttributesCount = -943197187,
                                },
                            },
                            MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                            {
                                Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                Id = -6774108720365892680L,
                                UncompressedSizeBytes = 7207111653247989525L,
                                CompressedSizeBytes = -5863566423773706985L,
                            },
                        },
                    },
                    DroppedAnnotationsCount = -1339084470,
                    DroppedMessageEventsCount = -2043953306,
                },
                Links = new Span.Types.Links
                {
                    Link =
                    {
                        new Span.Types.Link
                        {
                            TraceId = "trace_id105c890f",
                            SpanId = "span_id47c232d3",
                            Type = Span.Types.Link.Types.Type.Unspecified,
                            Attributes = new Span.Types.Attributes
                            {
                                AttributeMap =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AttributeValue
                                        {
                                            StringValue = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            IntValue = 6964907734533641939L,
                                            BoolValue = false,
                                        }
                                    },
                                },
                                DroppedAttributesCount = -943197187,
                            },
                        },
                    },
                    DroppedLinksCount = 996193750,
                },
                Status = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
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
                DisplayName = new TruncatableString
                {
                    Value = "value60c16320",
                    TruncatedByteCount = 2128325585,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Attributes = new Span.Types.Attributes
                {
                    AttributeMap =
                    {
                        {
                            "key8a0b6e3c",
                            new AttributeValue
                            {
                                StringValue = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                IntValue = 6964907734533641939L,
                                BoolValue = false,
                            }
                        },
                    },
                    DroppedAttributesCount = -943197187,
                },
                StackTrace = new StackTrace
                {
                    StackFrames = new StackTrace.Types.StackFrames
                    {
                        Frame =
                        {
                            new StackTrace.Types.StackFrame
                            {
                                FunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                OriginalFunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                FileName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                LineNumber = -6767150858782418247L,
                                ColumnNumber = -1645305070928801317L,
                                LoadModule = new Module
                                {
                                    Module_ = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                    BuildId = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                },
                                SourceVersion = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                            },
                        },
                        DroppedFramesCount = -530937800,
                    },
                    StackTraceHashId = -3233071409397891082L,
                },
                TimeEvents = new Span.Types.TimeEvents
                {
                    TimeEvent =
                    {
                        new Span.Types.TimeEvent
                        {
                            Time = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Annotation = new Span.Types.TimeEvent.Types.Annotation
                            {
                                Description = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                Attributes = new Span.Types.Attributes
                                {
                                    AttributeMap =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new AttributeValue
                                            {
                                                StringValue = new TruncatableString
                                                {
                                                    Value = "value60c16320",
                                                    TruncatedByteCount = 2128325585,
                                                },
                                                IntValue = 6964907734533641939L,
                                                BoolValue = false,
                                            }
                                        },
                                    },
                                    DroppedAttributesCount = -943197187,
                                },
                            },
                            MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                            {
                                Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                Id = -6774108720365892680L,
                                UncompressedSizeBytes = 7207111653247989525L,
                                CompressedSizeBytes = -5863566423773706985L,
                            },
                        },
                    },
                    DroppedAnnotationsCount = -1339084470,
                    DroppedMessageEventsCount = -2043953306,
                },
                Links = new Span.Types.Links
                {
                    Link =
                    {
                        new Span.Types.Link
                        {
                            TraceId = "trace_id105c890f",
                            SpanId = "span_id47c232d3",
                            Type = Span.Types.Link.Types.Type.Unspecified,
                            Attributes = new Span.Types.Attributes
                            {
                                AttributeMap =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AttributeValue
                                        {
                                            StringValue = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            IntValue = 6964907734533641939L,
                                            BoolValue = false,
                                        }
                                    },
                                },
                                DroppedAttributesCount = -943197187,
                            },
                        },
                    },
                    DroppedLinksCount = 996193750,
                },
                Status = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                SameProcessAsParentSpan = false,
                ChildSpanCount = -1491694397,
                SpanKind = Span.Types.SpanKind.Consumer,
            };
            Span expectedResponse = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "span_id47c232d3",
                ParentSpanId = "parent_span_ide637f6a2",
                DisplayName = new TruncatableString
                {
                    Value = "value60c16320",
                    TruncatedByteCount = 2128325585,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Attributes = new Span.Types.Attributes
                {
                    AttributeMap =
                    {
                        {
                            "key8a0b6e3c",
                            new AttributeValue
                            {
                                StringValue = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                IntValue = 6964907734533641939L,
                                BoolValue = false,
                            }
                        },
                    },
                    DroppedAttributesCount = -943197187,
                },
                StackTrace = new StackTrace
                {
                    StackFrames = new StackTrace.Types.StackFrames
                    {
                        Frame =
                        {
                            new StackTrace.Types.StackFrame
                            {
                                FunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                OriginalFunctionName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                FileName = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                LineNumber = -6767150858782418247L,
                                ColumnNumber = -1645305070928801317L,
                                LoadModule = new Module
                                {
                                    Module_ = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                    BuildId = new TruncatableString
                                    {
                                        Value = "value60c16320",
                                        TruncatedByteCount = 2128325585,
                                    },
                                },
                                SourceVersion = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                            },
                        },
                        DroppedFramesCount = -530937800,
                    },
                    StackTraceHashId = -3233071409397891082L,
                },
                TimeEvents = new Span.Types.TimeEvents
                {
                    TimeEvent =
                    {
                        new Span.Types.TimeEvent
                        {
                            Time = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Annotation = new Span.Types.TimeEvent.Types.Annotation
                            {
                                Description = new TruncatableString
                                {
                                    Value = "value60c16320",
                                    TruncatedByteCount = 2128325585,
                                },
                                Attributes = new Span.Types.Attributes
                                {
                                    AttributeMap =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new AttributeValue
                                            {
                                                StringValue = new TruncatableString
                                                {
                                                    Value = "value60c16320",
                                                    TruncatedByteCount = 2128325585,
                                                },
                                                IntValue = 6964907734533641939L,
                                                BoolValue = false,
                                            }
                                        },
                                    },
                                    DroppedAttributesCount = -943197187,
                                },
                            },
                            MessageEvent = new Span.Types.TimeEvent.Types.MessageEvent
                            {
                                Type = Span.Types.TimeEvent.Types.MessageEvent.Types.Type.Unspecified,
                                Id = -6774108720365892680L,
                                UncompressedSizeBytes = 7207111653247989525L,
                                CompressedSizeBytes = -5863566423773706985L,
                            },
                        },
                    },
                    DroppedAnnotationsCount = -1339084470,
                    DroppedMessageEventsCount = -2043953306,
                },
                Links = new Span.Types.Links
                {
                    Link =
                    {
                        new Span.Types.Link
                        {
                            TraceId = "trace_id105c890f",
                            SpanId = "span_id47c232d3",
                            Type = Span.Types.Link.Types.Type.Unspecified,
                            Attributes = new Span.Types.Attributes
                            {
                                AttributeMap =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AttributeValue
                                        {
                                            StringValue = new TruncatableString
                                            {
                                                Value = "value60c16320",
                                                TruncatedByteCount = 2128325585,
                                            },
                                            IntValue = 6964907734533641939L,
                                            BoolValue = false,
                                        }
                                    },
                                },
                                DroppedAttributesCount = -943197187,
                            },
                        },
                    },
                    DroppedLinksCount = 996193750,
                },
                Status = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
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
