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

using Google.Devtools.AspNet.Tests;
using Google.Devtools.Cloudtrace.V1;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using Trace = Google.Devtools.Cloudtrace.V1.Trace;

namespace Google.Devtools.AspNet.IntegrationTests
{
    public class CloudTraceIntregrationTest
    {
        private const int TimeoutMilliseconds = 10000; // 10 seconds.
        private const int SleepIntervalMilliseconds = 1000; // 1 second.
        private readonly string ProjectId;
        private readonly string TestId;
        private readonly Timestamp StartTime;
        private readonly TraceService.TraceServiceClient GrpcClient;

        public CloudTraceIntregrationTest()
        {
            ProjectId = "cloud-sharp-test";//Utils.GetProjectIdFromEnvironment();
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

        private Task<List<Trace>> GetTraces(string spanName, int traceCount)
        {
            return Task.Run(() => {
                List<Trace> traces = new List<Trace>();
                int sleepTime = 0;
                while (sleepTime < TimeoutMilliseconds)
                {

                    // TODO(Talarico): FIX THIS
                    sleepTime += SleepIntervalMilliseconds;
                    sleepTime += TimeoutMilliseconds;




                    // TODO(Talarico): FIX THIS
                    //Thread.Sleep(SleepIntervalMilliseconds);
                    Thread.Sleep(TimeoutMilliseconds);



                    ListTracesRequest request = new ListTracesRequest
                    {
                        ProjectId = ProjectId,
                        StartTime = StartTime,
                        View = ListTracesRequest.Types.ViewType.Complete
                    };
                    ListTracesResponse response = GrpcClient.ListTraces(request);
                    traces = response.Traces.Where(t => t.Spans.Any(s => s.Name.Equals(spanName))).ToList();
                    if ((traceCount > 0 && traces.Count >= traceCount) || (traceCount <= 0 && traces.Count > 0))
                    {
                        break;
                    }
                }
                return traces;
            });
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

            IList<Trace> traces = await GetTraces(rootSpanName, 1);
            Assert.Single(traces);
            Assert.Single(traces[0].Spans);
        }

        [Fact]
        public async Task Trace_Simple_Buffer()
        {

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

            IList<Trace> traces = await GetTraces(rootSpanName, 0);
            Assert.Empty(traces);
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

            IList<Trace> traces = await GetTraces(rootSpanName, 1);
            Assert.Single(traces);
            Assert.Single(traces[0].Spans);
            Assert.True(Tests.Utils.IsValidAnnotation(traces[0].Spans[0], annotation));
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

            IList<Trace> traces = await GetTraces(rootSpanName, 1);
            Assert.Single(traces);
            Assert.Single(traces[0].Spans);

            MapField<string, string> labels = traces[0].Spans[0].Labels;
            Assert.True(labels.ContainsKey(Labels.StackTrace));
            Assert.Contains(nameof(Trace_SimpleStacktrace), labels[Labels.StackTrace]);
            Assert.Contains(nameof(CloudTraceIntregrationTest), labels[Labels.StackTrace]);
        }

        [Fact]
        public async Task Trace_MultipleSpans()
        {
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

            IList<Trace> traces = await GetTraces(rootSpanName, 0);
            Assert.Empty(traces);
        }
    }
}
