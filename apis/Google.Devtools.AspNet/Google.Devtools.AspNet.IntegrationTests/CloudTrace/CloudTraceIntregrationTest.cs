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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using Google.Cloud.Trace.V1;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using Trace = Google.Cloud.Trace.V1.Trace;

namespace Google.Devtools.AspNet.IntegrationTests
{
    public class CloudTraceIntregrationTest
    {
        /// <summary>Total time to spend sleeping when looking for a trace.</summary>
        private const int TimeoutMilliseconds = 10000; // 10 seconds.

        /// <summary>Time to sleep between checks for a trace.</summary>
        private const int SleepIntervalMilliseconds = 1000; // 1 second.

        /// <summary>Project id to run the test on.</summary>
        private readonly string ProjectId;

        /// <summary>Unique id of the test.</summary>
        private readonly string TestId;

        /// <summary>Test start time to allow for easier querying of traces.</summary>
        private readonly Timestamp StartTime;

        /// <summary>Using the underlying grpc client so we can filter.</summary>
        private readonly TraceService.TraceServiceClient GrpcClient;

        public CloudTraceIntregrationTest()
        {
            ProjectId = Utils.GetProjectIdFromEnvironment();
            TestId = Utils.GetTestId();
            StartTime = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime());
            GrpcClient = TraceServiceClient.Create().GrpcClient;
        }

        private GrpcTraceConsumer CreateGrpcTraceConsumer()
        {
            TraceServiceClient client = TraceServiceClient.Create();
            return new GrpcTraceConsumer(Task.FromResult(client));
        }

        private SimpleManagedTracer CreateSimpleManagedTracer(ITraceConsumer consumer)
        {
            TraceIdFactory traceIdFactory = TraceIdFactory.Create();
            Trace trace = new Trace()
            {
                ProjectId = ProjectId,
                TraceId = traceIdFactory.NextId()
            };
            return SimpleManagedTracer.Create(consumer, trace, null);
        }

        /// <summary>
        /// Gets a trace that contains a span with the given name.
        /// </summary>
        private async Task<Trace> GetTrace(string spanName)
        {
            int sleepTime = 0;
            while (sleepTime < TimeoutMilliseconds)
            {
                sleepTime += SleepIntervalMilliseconds;
                Thread.Sleep(SleepIntervalMilliseconds);

                ListTracesRequest request = new ListTracesRequest
                {
                    ProjectId = ProjectId,
                    StartTime = StartTime,
                    View = ListTracesRequest.Types.ViewType.Complete
                };
                ListTracesResponse response = await GrpcClient.ListTracesAsync(request);
                List<Trace> traces = response.Traces.Where(t => t.Spans.Any(s => s.Name.Equals(spanName))).ToList();
                if (traces.Count != 0)
                {
                    return traces[0];
                }
            }
            return null;
        }

        private string CreateRootSpanName(string name) => $"{TestId}-{name}";

        [Fact]
        public async Task Trace_Simple()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple));
            GrpcTraceConsumer consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public async Task Trace_Simple_Buffer()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_Buffer));
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(CreateGrpcTraceConsumer());
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            // Create annotations with very large labels to ensure the buffer is flushed.
            string label = "1234567890";
            while (label.Length < 20000)
            {
                label += label;
            }
            Dictionary<string, string> annotation = new Dictionary<string, string>
            {
                { "key-one", label },
                { "key-two", label },
                { "key-three", label },
                { "key-four", label },
                { "key-five", label },
            };

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public async Task Trace_Simple_BufferNoTrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_BufferNoTrace));
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(CreateGrpcTraceConsumer());
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.Null(trace);
        }

        [Fact]
        public async Task Trace_SimpleAnnotation()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_SimpleAnnotation));
            GrpcTraceConsumer consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            Dictionary<string, string> annotation = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" },
                { "some-key", "some-value" }
            };

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
            Assert.True(Tests.TraceUtils.IsValidAnnotation(trace.Spans[0], annotation));
        }

        [Fact]
        public async Task Trace_SimpleStacktrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_SimpleStacktrace));
            GrpcTraceConsumer consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.SetStackTrace(new StackTrace(true));
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);

            MapField<string, string> labels = trace.Spans[0].Labels;
            Assert.True(labels.ContainsKey(Labels.StackTrace));
            Assert.Contains(nameof(Trace_SimpleStacktrace), labels[Labels.StackTrace]);
            Assert.Contains(nameof(CloudTraceIntregrationTest), labels[Labels.StackTrace]);
        }

        [Fact]
        public async Task Trace_MultipleSpans()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_MultipleSpans));
            GrpcTraceConsumer consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            Dictionary<string, string> annotation = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" }
            };

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.StartSpan("child-one");
            tracer.SetStackTrace(new StackTrace(true));
            Thread.Sleep(20);
            tracer.EndSpan();
            tracer.StartSpan("child-two");
            Thread.Sleep(5);
            tracer.StartSpan("grandchild-one", StartSpanOptions.Create(SpanKind.RpcClient));
            Thread.Sleep(50);
            tracer.EndSpan();
            tracer.StartSpan("grandchild-two");
            Thread.Sleep(10);
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();
            tracer.EndSpan();
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Equal(5, trace.Spans.Count);

            TraceSpan root = trace.Spans.Where(s => s.Name.Equals(rootSpanName)).First();
            TraceSpan childOne = trace.Spans.Where(s => s.Name.Equals("child-one")).First();
            TraceSpan childTwo = trace.Spans.Where(s => s.Name.Equals("child-two")).First();
            TraceSpan grandchildOne = trace.Spans.Where(s => s.Name.Equals("grandchild-one")).First();
            TraceSpan grandchildTwo = trace.Spans.Where(s => s.Name.Equals("grandchild-two")).First();

            Assert.Equal(root.SpanId, childOne.ParentSpanId);
            MapField<string, string> labels = childOne.Labels;
            Assert.True(labels.ContainsKey(Labels.StackTrace));
            Assert.Contains(nameof(Trace_MultipleSpans), labels[Labels.StackTrace]);
            Assert.Contains(nameof(CloudTraceIntregrationTest), labels[Labels.StackTrace]);

            Assert.Equal(root.SpanId, childTwo.ParentSpanId);

            Assert.Equal(childTwo.SpanId, grandchildOne.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.RpcClient, grandchildOne.Kind);

            Assert.Equal(childTwo.SpanId, grandchildTwo.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.Unspecified, grandchildTwo.Kind);
            Assert.True(Tests.TraceUtils.IsValidAnnotation(grandchildTwo, annotation));
        }

        [Fact]
        public async Task Trace_IncompleteSpans()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_IncompleteSpans));
            GrpcTraceConsumer consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            tracer.StartSpan("span-name-1");
            Thread.Sleep(5);
            tracer.StartSpan("span-name-2");
            Thread.Sleep(10);
            tracer.EndSpan();
            tracer.EndSpan();

            Trace trace = await GetTrace(rootSpanName);
            Assert.Null(trace);
        }
    }
}
