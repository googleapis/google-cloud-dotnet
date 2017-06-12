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

        [Fact]
        public async Task TraceOutGoing()
        {
            string googleUri = "https://google.com/";
            string testId = Utils.GetTestId();
            var spanName = $"{nameof(TraceOutGoing)}-{testId}";

            var trace = await TestTracingOutGoingRequest(googleUri, spanName, exceptionExpected: false);
            var innerSpan = trace.Spans.Single(s => s.Name != spanName);
            Assert.Equal(2, innerSpan.Labels.Count);
            Assert.Equal("GET", innerSpan.Labels[TraceLabels.HttpMethod]);
            Assert.Equal("200", innerSpan.Labels[TraceLabels.HttpStatusCode]);
        }

        [Fact]
        public async Task TraceOutGoing_Exception()
        {
            string fakeUri = "http://www.thiscannotpossiblyexist934719238.com/";
            string testId = Utils.GetTestId();
            var spanName = $"{nameof(TraceOutGoing_Exception)}-{testId}";

            var trace = await TestTracingOutGoingRequest(fakeUri, spanName, exceptionExpected: true);
            var innerSpan = trace.Spans.Single(s => s.Name != spanName);
            Assert.Equal(2, innerSpan.Labels.Count);
            Assert.Equal("GET", innerSpan.Labels[TraceLabels.HttpMethod]);
            Assert.False(string.IsNullOrWhiteSpace(innerSpan.Labels[TraceLabels.StackTrace]));
        }

        [Fact]
        public async Task TraceOutGoing_HttpError()
        {
            string fakeUri = "https://google.com/404";
            string testId = Utils.GetTestId();
            var spanName = $"{nameof(TraceOutGoing_Exception)}-{testId}";

            var trace = await TestTracingOutGoingRequest(fakeUri, spanName, exceptionExpected: false);
            var innerSpan = trace.Spans.Single(s => s.Name != spanName);
            Assert.Equal(2, innerSpan.Labels.Count);
            Assert.Equal("GET", innerSpan.Labels[TraceLabels.HttpMethod]);
            Assert.Equal("404", innerSpan.Labels[TraceLabels.HttpStatusCode]);
        }

        /// <summary>
        /// Helper function to test tracing of out going requests.
        /// </summary>
        /// <param name="uri">The Uri to call.</param>
        /// <param name="rootSpanName">The name for the root span.</param>
        /// <param name="exceptionExpected">True if an exception from the request to the Uri is expected.</param>
        /// <returns>A trace with two spans.  A root span and a child span tracing the outgoing Uri
        ///     request.</returns>
        private async Task<TraceProto> TestTracingOutGoingRequest(
            string uri, string rootSpanName, bool exceptionExpected)
        {
            var startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            await TraceOutGoingRequest(CreateTracer(), rootSpanName, uri, exceptionExpected);
            var trace = _polling.GetTrace(rootSpanName, startTime);
            CheckTrace(trace, rootSpanName, uri);
            return trace;
        }

        /// <summary>
        /// Creates a <see cref="SimpleManagedTracer"/> with a <see cref="GrpcTraceConsumer"/>.
        /// </summary>
        private IManagedTracer CreateTracer()
        {
            string traceId = _traceIdFactory.NextId();
            var consumer = new GrpcTraceConsumer(TraceServiceClient.Create());
            return SimpleManagedTracer.Create(consumer, _projectId, traceId, null);
        }

        /// <summary>
        /// Creates a <see cref="TraceHeaderPropagatingHandler"/> and traces the sending of a
        /// GET request to the given Uri.  The trace is wrapped in a parent span.
        /// </summary>
        /// <param name="tracer">The tracer to trace the request with.</param>
        /// <param name="rootSpanName">The name of the root span that will wrap the span
        ///     that traces the request.</param>
        /// <param name="uri">The Uri to request.</param>
        /// <param name="exceptionExpected">True if an exception from the request to the Uri is expected.</param>
        private async Task TraceOutGoingRequest(
            IManagedTracer tracer, string rootSpanName, string uri, bool exceptionExpected)
        {
            using (tracer.StartSpan(rootSpanName))
            {
                var traceHeaderHandler = new TraceHeaderPropagatingHandler(() => tracer);
                using (var httpClient = new HttpClient(traceHeaderHandler))
                {
                    try
                    {
                        await httpClient.GetAsync(uri);
                        Assert.False(exceptionExpected);
                    }
                    catch (Exception e) when (exceptionExpected && !(e is Xunit.Sdk.XunitException))
                    {
                    }
                }
            }
        }

        /// <summary>
        /// Checks a trace for the following:
        /// <list type="bullet">
        /// <term>The trace is not null.</term>
        /// <term>The trace has two spans.</term>
        /// <term>The trace has a root span with name rootSpanName</term>
        /// <term>The root span has a single child span with name childSpanName</term>
        /// </list>
        /// </summary>
        /// <param name="trace">The trace to check.</param>
        /// <param name="rootSpanName">The name of the root span.</param>
        /// <param name="childSpanName">The name of the child span.</param>
        private void CheckTrace(TraceProto trace, string rootSpanName, string childSpanName)
        {
            Assert.NotNull(trace);
            var spans = trace.Spans;
            Assert.Equal(2, spans.Count);
            var mainSpan = spans.Single(s => s.Name == rootSpanName);
            var innerSpan = spans.Single(s => s.Name != rootSpanName);
            Assert.Equal(childSpanName, innerSpan.Name);
            Assert.Equal(mainSpan.SpanId, innerSpan.ParentSpanId);
        }
    }
}
