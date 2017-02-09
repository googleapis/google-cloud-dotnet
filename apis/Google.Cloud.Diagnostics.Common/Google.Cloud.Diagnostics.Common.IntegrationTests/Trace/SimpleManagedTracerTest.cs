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
            return new GrpcTraceConsumer(Task.FromResult(client));
        }

        private SimpleManagedTracer CreateSimpleManagedTracer(IConsumer<TraceProto> consumer)
        {
            TraceProto trace = new TraceProto
            {
                ProjectId = _projectId,
                TraceId = _traceIdFactory.NextId()
            };
            return SimpleManagedTracer.Create(consumer, trace, null);
        }

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

        private string CreateRootSpanName(string name) => $"{_testId}-{name}";

        [Fact]
        public void Trace_Simple()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple));
            var consumer = CreateGrpcTraceConsumer();
            var tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.EndSpan();

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

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();

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

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.EndSpan();

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

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();

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

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.SetStackTrace(new StackTrace(new Exception(), true));
            tracer.EndSpan();

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);

            var labels = trace.Spans[0].Labels;
            Assert.True(labels.ContainsKey(TraceLabels.StackTrace));
            Assert.Contains(nameof(Trace_SimpleStacktrace), labels[TraceLabels.StackTrace]);
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

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.StartSpan("child-one");
            tracer.SetStackTrace(new StackTrace(new Exception(), true));
            BlockUntilClockTick();
            tracer.EndSpan();
            tracer.StartSpan("child-two");
            BlockUntilClockTick();
            tracer.StartSpan("grandchild-one", StartSpanOptions.Create(SpanKind.RpcClient));
            BlockUntilClockTick();
            tracer.EndSpan();
            tracer.StartSpan("grandchild-two");
            BlockUntilClockTick();
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();
            tracer.EndSpan();
            tracer.EndSpan();

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
            Assert.Contains(nameof(Trace_MultipleSpans), labels[TraceLabels.StackTrace]);
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

            tracer.StartSpan(rootSpanName);
            tracer.StartSpan("span-name-1");
            BlockUntilClockTick();
            tracer.StartSpan("span-name-2");
            BlockUntilClockTick();
            tracer.EndSpan();
            tracer.EndSpan();

            TraceProto trace = _polling.GetTrace(rootSpanName, _startTime, false);
            Assert.Null(trace);
        }
    }
}