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

using Google.Devtools.Cloudtrace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

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
                int sleepTime = 0;
                while (sleepTime < TimeoutMilliseconds)
                {
                    sleepTime += SleepIntervalMilliseconds;




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
                    List<Trace> traces = response.Traces.Where(t => t.Spans.Any(s => s.Name.Equals(spanName))).ToList();
                    if (traces.Count < traceCount)
                    {
                        continue;
                    }
                    return traces;
                }
                return null;
            });
        }

        private string CreateRootSpanName(string name)
        {
            return $"{TestId}-{name}";
        }

        [Fact]
        public async void Trace_Simple()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple));
            GrpcTraceConsumer consumer = CreateGrpcTraceConsumer();
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.EndSpan();

            IList<Trace> traces = await GetTraces(rootSpanName, 1);
            Assert.NotNull(traces);
            Assert.Equal(1, traces[0].Spans.Count);
        }

        [Fact]
        public async void Trace_Simple_Buffer()
        {

        }

        [Fact]
        public async void Trace_Simple_BufferNoTrace()
        {
            string rootSpanName = CreateRootSpanName(nameof(Trace_Simple_BufferNoTrace));
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(CreateGrpcTraceConsumer());
            SimpleManagedTracer tracer = CreateSimpleManagedTracer(consumer);

            tracer.StartSpan(rootSpanName);
            Thread.Sleep(10);
            tracer.EndSpan();

            // Wait for one so we keep looking as no results should ever be returned.
            IList<Trace> traces = await GetTraces(rootSpanName, 1);
            Assert.NotNull(traces);
            Assert.Equal(0, traces.Count);
        }

   

        [Fact]
        public async void Trace_SimpleAnnotation()
        {
        }

        [Fact]
        public async void Trace_SimpleStacktrace()
        {
        }

        [Fact]
        public async void Trace_MultipleSpans()
        {
        }

        [Fact]
        public async void Trace_IncompleteSpans()
        {
        }
    }
}
