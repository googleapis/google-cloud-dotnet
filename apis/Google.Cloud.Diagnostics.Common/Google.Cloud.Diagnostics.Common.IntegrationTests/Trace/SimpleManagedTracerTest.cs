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

using Google.Cloud.Trace.V1;
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public class SimpleManagedTracerTest
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();

        private readonly TraceEntryPolling _polling = new TraceEntryPolling();

        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = Utils.GetProjectIdFromEnvironment();

        /// <summary>Unique id of the test.</summary>
        private readonly string _testId = Utils.GetTestId();

        /// <summary>Test start time to allow for easier querying of traces.</summary>
        private readonly Timestamp _startTime = Timestamp.FromDateTime(DateTime.UtcNow);

        private IConsumer<TraceProto> CreateGrpcTraceConsumer()
        {
            TraceServiceClient client = TraceServiceClient.Create();
            return new GrpcTraceConsumer(client);
        }

        private SimpleManagedTracer CreateSimpleManagedTracer(IConsumer<TraceProto> consumer) =>
            SimpleManagedTracer.Create(consumer, _projectId, _traceIdFactory.NextId(), null);

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

        /// <summary>Create a thrown exception.</summary>
        internal Exception CreateException()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private string CreateRootSpanName(string name) => $"{_testId}-{name}";

        [Fact]
        public void Trace_Simple()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple));
            var consumer = CreateGrpcTraceConsumer();
            var tracer = CreateSimpleManagedTracer(consumer);

            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
            }

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public void Trace_Simple_Buffer()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_Buffer));
            var consumer = SizedBufferingConsumer<TraceProto>.Create(
                CreateGrpcTraceConsumer(), MessageSizer<TraceProto>.GetSize, BufferOptions.DefaultBufferSize / 2);
            var tracer = CreateSimpleManagedTracer(consumer);

            // Create annotations with very large labels to ensure the buffer is flushed.
            string label = string.Join("", Enumerable.Repeat("1234567890", 1000));
            var annotation = new Dictionary<string, string>
            {
                { "key-one", label },
                { "key-two", label },
                { "key-three", label },
                { "key-four", label },
                { "key-five", label },
            };

            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                tracer.AnnotateSpan(annotation);
            }

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public void Trace_Simple_BufferNoTrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_BufferNoTrace));
            var consumer = SizedBufferingConsumer<TraceProto>.Create(
                CreateGrpcTraceConsumer(), MessageSizer<TraceProto>.GetSize, BufferOptions.DefaultBufferSize);
            var tracer = CreateSimpleManagedTracer(consumer);

            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
            }

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime, false);
            Assert.Null(trace);
        }

        [Fact]
        public void Trace_SimpleAnnotation()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_SimpleAnnotation));
            var consumer = CreateGrpcTraceConsumer();
            var tracer = CreateSimpleManagedTracer(consumer);

            var annotation = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" },
                { "some-key", "some-value" }
            };

            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                tracer.AnnotateSpan(annotation);
            }

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
            Assert.True(TraceUtils.IsValidAnnotation(trace.Spans[0], annotation));
        }

        [Fact]
        public void Trace_SimpleStacktrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_SimpleStacktrace));
            var consumer = CreateGrpcTraceConsumer();
            var tracer = CreateSimpleManagedTracer(consumer);

            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                tracer.SetStackTrace(new StackTrace(CreateException(), true));
            }

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);

            var labels = trace.Spans[0].Labels;
            Assert.True(labels.ContainsKey(TraceLabels.StackTrace));
            Assert.Contains(nameof(CreateException), labels[TraceLabels.StackTrace]);
            Assert.Contains(nameof(SimpleManagedTracerTest), labels[TraceLabels.StackTrace]);
        }

        [Fact]
        public void Trace_MultipleSpans()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_MultipleSpans));
            var consumer = CreateGrpcTraceConsumer();
            var tracer = CreateSimpleManagedTracer(consumer);

            var annotation = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" }
            };

            using (tracer.StartSpan(rootSpanName))
            {
                BlockUntilClockTick();
                using (tracer.StartSpan("child-one"))
                {
                    tracer.SetStackTrace(new StackTrace(CreateException(), true));
                    BlockUntilClockTick();
                }
                using (tracer.StartSpan("child-two")) { 
                    BlockUntilClockTick();
                    using (tracer.StartSpan("grandchild-one", StartSpanOptions.Create(SpanKind.RpcClient)))
                    {
                        BlockUntilClockTick();
                    }
                    using (tracer.StartSpan("grandchild-two"))
                    {
                        BlockUntilClockTick();
                        tracer.AnnotateSpan(annotation);
                    }
                }
            }

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime);
            Assert.NotNull(trace);
            Assert.Equal(5, trace.Spans.Count);

            TraceSpan root = trace.Spans.First(s => s.Name.Equals(rootSpanName));
            TraceSpan childOne = trace.Spans.First(s => s.Name.Equals("child-one"));
            TraceSpan childTwo = trace.Spans.First(s => s.Name.Equals("child-two"));
            TraceSpan grandchildOne = trace.Spans.First(s => s.Name.Equals("grandchild-one"));
            TraceSpan grandchildTwo = trace.Spans.First(s => s.Name.Equals("grandchild-two"));

            Assert.Equal(root.SpanId, childOne.ParentSpanId);
            var labels = childOne.Labels;
            Assert.True(labels.ContainsKey(TraceLabels.StackTrace));
            Assert.Contains(nameof(CreateException), labels[TraceLabels.StackTrace]);
            Assert.Contains(nameof(SimpleManagedTracerTest), labels[TraceLabels.StackTrace]);

            Assert.Equal(root.SpanId, childTwo.ParentSpanId);

            Assert.Equal(childTwo.SpanId, grandchildOne.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.RpcClient, grandchildOne.Kind);

            Assert.Equal(childTwo.SpanId, grandchildTwo.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.Unspecified, grandchildTwo.Kind);
            Assert.True(TraceUtils.IsValidAnnotation(grandchildTwo, annotation));
        }

        [Fact]
        public void Trace_IncompleteSpans()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_IncompleteSpans));
            var consumer = CreateGrpcTraceConsumer();
            var tracer = CreateSimpleManagedTracer(consumer);

            var one = tracer.StartSpan(rootSpanName);
            var two = tracer.StartSpan("span-name-1");
            BlockUntilClockTick();
            var three = tracer.StartSpan("span-name-2");
            BlockUntilClockTick();
            three.Dispose();
            two.Dispose();

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime, false);
            Assert.Null(trace);
        }
    }
}