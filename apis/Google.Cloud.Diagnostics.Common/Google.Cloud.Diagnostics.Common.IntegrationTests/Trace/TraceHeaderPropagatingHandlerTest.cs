// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public class TraceHeaderPropagatingHandlerTest
    {


        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = Utils.GetProjectIdFromEnvironment();

        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();
        private static readonly SpanIdFactory _spanIdFactory = SpanIdFactory.Create();
        private readonly TraceEntryPolling _polling = new TraceEntryPolling();



        // TODO(talarico): Update TraceHeader with asp.net core option and snippets!


        [Fact]
        public async Task TraceOutGoing()
        {
            string googleUri = "https://google.com/";
            string testId = Utils.GetTestId();
            var spanName = $"{nameof(TraceOutGoing)}-{testId}";

            var trace = await TraceOutGoing(googleUri, spanName);
            var spans = trace.Spans;
            Assert.Equal(2, spans.Count);

            var mainSpan = spans.Single(s => s.Name == spanName);
            Assert.Empty(mainSpan.Labels);

            var innerSpan = spans.Single(s => s.Name != spanName);
            Assert.Equal(googleUri, innerSpan.Name);
            Assert.Equal(mainSpan.SpanId, innerSpan.ParentSpanId);
        }

        [Fact]
        public async Task TraceOutGoing_Exception()
        {
        }


        private async Task<TraceProto> TraceOutGoing(string uri, string spanName)
        {
            var startTime = Timestamp.FromDateTime(DateTime.UtcNow);

            string traceId = _traceIdFactory.NextId();
            var traceProto = new TraceProto { ProjectId = _projectId, TraceId = traceId };
            var consumer = new GrpcTraceConsumer(TraceServiceClient.CreateAsync());
            var tracer = SimpleManagedTracer.Create(consumer, traceProto, null);

            tracer.StartSpan(spanName);
            var traceHeaderHandler = TraceHeaderPropagatingHandler.Create(tracer);
            using (var httpClient = HttpClientFactory.Create(traceHeaderHandler))
            {
                await httpClient.GetAsync(uri);
            }
            tracer.EndSpan();

            return _polling.GetTrace(spanName, startTime);
        }
    }
}
