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
using Google.Cloud.Diagnostics.AspNet.Tests;
using Google.Cloud.Diagnostics.Common;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNet.IntegrationTests
{
    public class TraceTest
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();

        /// <summary>Total time to spend sleeping when looking for a trace.</summary>
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

        /// <summary>Time to sleep between checks for a trace.</summary>
        private readonly TimeSpan _sleepInterval = TimeSpan.FromSeconds(2);

        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId;

        /// <summary>Unique id of the test.</summary>
        private readonly string _testId;

        /// <summary>Test start time to allow for easier querying of traces.</summary>
        private readonly Timestamp _startTime;

        /// <summary>Client to use to send RPCs.</summary>
        private readonly TraceServiceClient _client;

        public TraceTest()
        {
            _projectId = Utils.GetProjectIdFromEnvironment();
            _testId = Utils.GetTestId();
            _startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            _client = TraceServiceClient.Create();
        }

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

        /// <summary>
        /// Gets a trace that contains a span with the given name.
        /// </summary>
        /// <param name="expectTrace">True if the trace is expected to exist.  This is used
        ///     to minimize RPC calls.</param>
        private async Task<TraceProto> GetTrace(string spanName, bool expectTrace = true)
        {
            TimeSpan totalSleepTime = TimeSpan.Zero;
            while (totalSleepTime <= _timeout)
            {
                TimeSpan sleepTime = expectTrace ? _sleepInterval : _timeout;
                totalSleepTime += sleepTime;
                Thread.Sleep(sleepTime);

                ListTracesRequest request = new ListTracesRequest
                {
                    ProjectId = _projectId,
                    StartTime = _startTime,
                    View = ListTracesRequest.Types.ViewType.Complete
                };
                var traces = _client.ListTracesAsync(request);
                TraceProto trace = await traces.FirstOrDefault(t => t.Spans.Any(s => s.Name.Equals(spanName)));
                if (trace != null)
                {
                    return trace;
                }
            }
            return null;
        }

        private string CreateRootSpanName(string name) => $"{_testId}-{name}";

        [Fact]
        public async Task Trace_Simple()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple));
            IConsumer<TraceProto> consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.EndSpan();

            TraceProto trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public async Task Trace_Simple_Buffer()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_Buffer));
            SizedBufferingConsumer<TraceProto> consumer = SizedBufferingConsumer<TraceProto>.Create(
                CreateGrpcTraceConsumer(), TraceSizer.Instance, BufferOptions.DefaultBufferSize);
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            // Create annotations with very large labels to ensure the buffer is flushed.
            string label = string.Join("", Enumerable.Repeat("1234567890", 2000));
            Dictionary<string, string> annotation = new Dictionary<string, string>
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

            TraceProto trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public async Task Trace_Simple_BufferNoTrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_BufferNoTrace));
            SizedBufferingConsumer<TraceProto> consumer = SizedBufferingConsumer<TraceProto>.Create(
                CreateGrpcTraceConsumer(), TraceSizer.Instance, BufferOptions.DefaultBufferSize);
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.EndSpan();

            TraceProto trace = await GetTrace(rootSpanName, false);
            Assert.Null(trace);
        }

        [Fact]
        public async Task Trace_SimpleAnnotation()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_SimpleAnnotation));
            IConsumer<TraceProto> consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            Dictionary<string, string> annotation = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" },
                { "some-key", "some-value" }
            };

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();

            TraceProto trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
            Assert.True(TraceUtils.IsValidAnnotation(trace.Spans[0], annotation));
        }

        [Fact]
        public async Task Trace_SimpleStacktrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_SimpleStacktrace));
            IConsumer<TraceProto> consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.SetStackTrace(new StackTrace(true));
            tracer.EndSpan();

            TraceProto trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);

            MapField<string, string> labels = trace.Spans[0].Labels;
            Assert.True(labels.ContainsKey(Labels.StackTrace));
            Assert.Contains(nameof(Trace_SimpleStacktrace), labels[Labels.StackTrace]);
            Assert.Contains(nameof(TraceTest), labels[Labels.StackTrace]);
        }

        [Fact]
        public async Task Trace_MultipleSpans()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_MultipleSpans));
            IConsumer<TraceProto> consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            Dictionary<string, string> annotation = new Dictionary<string, string>
            {
                { "annotation-key", "annotation-value" }
            };

            tracer.StartSpan(rootSpanName);
            BlockUntilClockTick();
            tracer.StartSpan("child-one");
            tracer.SetStackTrace(new StackTrace(true));
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

            TraceProto trace = await GetTrace(rootSpanName);
            Assert.NotNull(trace);
            Assert.Equal(5, trace.Spans.Count);

            TraceSpan root = trace.Spans.First(s => s.Name.Equals(rootSpanName));
            TraceSpan childOne = trace.Spans.First(s => s.Name.Equals("child-one"));
            TraceSpan childTwo = trace.Spans.First(s => s.Name.Equals("child-two"));
            TraceSpan grandchildOne = trace.Spans.First(s => s.Name.Equals("grandchild-one"));
            TraceSpan grandchildTwo = trace.Spans.First(s => s.Name.Equals("grandchild-two"));

            Assert.Equal(root.SpanId, childOne.ParentSpanId);
            MapField<string, string> labels = childOne.Labels;
            Assert.True(labels.ContainsKey(Labels.StackTrace));
            Assert.Contains(nameof(Trace_MultipleSpans), labels[Labels.StackTrace]);
            Assert.Contains(nameof(TraceTest), labels[Labels.StackTrace]);

            Assert.Equal(root.SpanId, childTwo.ParentSpanId);

            Assert.Equal(childTwo.SpanId, grandchildOne.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.RpcClient, grandchildOne.Kind);

            Assert.Equal(childTwo.SpanId, grandchildTwo.ParentSpanId);
            Assert.Equal(TraceSpan.Types.SpanKind.Unspecified, grandchildTwo.Kind);
            Assert.True(TraceUtils.IsValidAnnotation(grandchildTwo, annotation));
        }

        [Fact]
        public async Task Trace_IncompleteSpans()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_IncompleteSpans));
            IConsumer<TraceProto> consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            tracer.StartSpan("span-name-1");
            BlockUntilClockTick();
            tracer.StartSpan("span-name-2");
            BlockUntilClockTick();
            tracer.EndSpan();
            tracer.EndSpan();

            TraceProto trace = await GetTrace(rootSpanName, false);
            Assert.Null(trace);
        }
    }
}