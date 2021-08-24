// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public class SimpleManagedTracerTest : IDisposable
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();

        /// <summary>Unique id of the test.</summary>
        private readonly string _testId;

        private readonly IConsumer<TraceProto> _grpcConsumer;

        /// <summary>Test start time to allow for easier querying of traces.</summary>
        private readonly DateTimeOffset _startTime;

        public SimpleManagedTracerTest()
        {
            _testId = IdGenerator.FromDateTime();

            _grpcConsumer = new GrpcTraceConsumer(TraceServiceClient.Create());

            _startTime = DateTimeOffset.UtcNow;
        }

        [Fact]
        public void Trace_Simple()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_Simple), _testId);

            using (CreateSimpleManagedTracer(_grpcConsumer).StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
            }

            TraceProto trace = TraceEntryPolling.Default.GetTrace(rootSpanName, _startTime);
            TraceEntryVerifiers.AssertSingleSpan(trace, rootSpanName);
        }

        [Fact]
        public void Trace_Simple_Buffer()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_Simple_Buffer), _testId);
            // Create annotations with very large labels to ensure the buffer is flushed.
            string label = string.Join("", Enumerable.Repeat("1234567890", 1000));
            var labels = new Dictionary<string, string>
            {
                { "key-one", label },
                { "key-two", label },
                { "key-three", label },
                { "key-four", label },
                { "key-five", label },
            };

            using (var consumer = SizedBufferingConsumer<TraceProto>.Create(_grpcConsumer, MessageSizer<TraceProto>.GetSize, BufferOptions.DefaultBufferSize / 2))
            {
                var tracer = CreateSimpleManagedTracer(consumer);
                using (tracer.StartSpan(rootSpanName))
                {
                    BlockUntilClockTick();
                    tracer.AnnotateSpan(labels);
                }
            }

            TraceProto trace = TraceEntryPolling.Default.GetTrace(rootSpanName, _startTime);

            TraceEntryVerifiers.AssertSingleSpan(trace, rootSpanName);
        }

        [Fact]
        public void Trace_Simple_BufferNoTrace()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_Simple_BufferNoTrace), _testId);

            using (var consumer = SizedBufferingConsumer<TraceProto>.Create(_grpcConsumer, MessageSizer<TraceProto>.GetSize, BufferOptions.DefaultBufferSize))
            {
                using (CreateSimpleManagedTracer(consumer).StartSpan(rootSpanName))
                {
                    BlockUntilClockTick();
                }

                // Verifying before disposing of the consumer so as to check that the buffer
                // wasn't flush because of the size of the messages. If we verify after disposing
                // any message, big or small, would have been flushed on disposing.
                TraceProto trace = TraceEntryPolling.NoEntry.GetTrace(rootSpanName, _startTime, false);

                Assert.Null(trace);
            }
        }

        [Fact]
        public void Trace_SimpleAnnotation()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_SimpleAnnotation), _testId);
            var labels = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" },
                { "some-key", "some-value" }
            };

            var tracer = CreateSimpleManagedTracer(_grpcConsumer);
            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                tracer.AnnotateSpan(labels);
            }

            TraceProto trace = TraceEntryPolling.Default.GetTrace(rootSpanName, _startTime);

            TraceEntryVerifiers.AssertSingleSpan(trace, rootSpanName);
            TraceEntryVerifiers.AssertSpanLabelsExact(trace.Spans.First(), labels);
        }

        [Fact]
        public void Trace_SimpleStacktrace()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_SimpleStacktrace), _testId);

            var tracer = CreateSimpleManagedTracer(_grpcConsumer);
            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                tracer.SetStackTrace(TraceEntryData.CreateStackTrace());
            }

            TraceProto trace = TraceEntryPolling.Default.GetTrace(rootSpanName, _startTime);

            TraceEntryVerifiers.AssertSingleSpan(trace, rootSpanName);
            TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans[0],
                nameof(TraceEntryData.CreateStackTrace), nameof(SimpleManagedTracerTest));
        }

        [Fact]
        public void Trace_MultipleSpans()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_MultipleSpans), _testId);
            var labels = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" }
            };

            var tracer = CreateSimpleManagedTracer(_grpcConsumer);
            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                using (tracer.StartSpan("child-one"))
                {
                    tracer.SetStackTrace(TraceEntryData.CreateStackTrace());
                    BlockUntilClockTick();
                }
                using (tracer.StartSpan("child-two"))
                {
                    BlockUntilClockTick();
                    using (tracer.StartSpan("grandchild-one", StartSpanOptions.Create(SpanKind.RpcClient)))
                    {
                        BlockUntilClockTick();
                    }
                    using (tracer.StartSpan("grandchild-two"))
                    {
                        BlockUntilClockTick();
                        tracer.AnnotateSpan(labels);
                    }
                }
            }

            TraceProto trace = TraceEntryPolling.Default.GetTrace(rootSpanName, _startTime);

            Assert.NotNull(trace);
            Assert.Equal(5, trace.Spans.Count);

            TraceSpan root = trace.Spans.First(s => s.Name.Equals(rootSpanName));
            TraceSpan childOne = trace.Spans.First(s => s.Name.Equals("child-one"));
            TraceSpan childTwo = trace.Spans.First(s => s.Name.Equals("child-two"));
            TraceSpan grandchildOne = trace.Spans.First(s => s.Name.Equals("grandchild-one"));
            TraceSpan grandchildTwo = trace.Spans.First(s => s.Name.Equals("grandchild-two"));

            Assert.Equal(root.SpanId, childOne.ParentSpanId);
            TraceEntryVerifiers.AssertContainsStackTrace(childOne,
                nameof(TraceEntryData.CreateStackTrace), nameof(SimpleManagedTracerTest));

            Assert.Equal(root.SpanId, childTwo.ParentSpanId);

            Assert.Equal(childTwo.SpanId, grandchildOne.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.RpcClient, grandchildOne.Kind);

            Assert.Equal(childTwo.SpanId, grandchildTwo.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.Unspecified, grandchildTwo.Kind);
            TraceEntryVerifiers.AssertSpanLabelsExact(grandchildTwo, labels);
        }

        [Fact]
        public void Trace_IncompleteSpans()
        {
            string rootSpanName = EntryData.GetMessage(nameof(Trace_IncompleteSpans), _testId);

            var tracer = CreateSimpleManagedTracer(_grpcConsumer);
            tracer.StartSpan(rootSpanName);
            using (tracer.StartSpan("span-name-1"))
            {
                BlockUntilClockTick();
                using (tracer.StartSpan("span-name-2"))
                {
                    BlockUntilClockTick();
                }
            }

            TraceProto trace = TraceEntryPolling.NoEntry.GetTrace(rootSpanName, _startTime, false);
            Assert.Null(trace);
        }

        private IManagedTracer CreateSimpleManagedTracer(IConsumer<TraceProto> consumer) =>
            SimpleManagedTracer.Create(consumer, TestEnvironment.GetTestProjectId(), _traceIdFactory.NextId(), null);

        /// <summary>
        /// Block until the time has changed.
        /// </summary>
        private void BlockUntilClockTick()
        {
            DateTime now = DateTime.UtcNow;
            while (now >= DateTime.UtcNow)
            {
                Thread.Sleep(1);
            }
        }

        public void Dispose() => _grpcConsumer.Dispose();
    }
}