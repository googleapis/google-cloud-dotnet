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

using Google.Cloud.ClientTesting;
using Google.Cloud.Trace.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public class TraceHeaderPropagatingHandlerTest : IDisposable
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();

        private readonly string _testId;

        private readonly IConsumer<TraceProto> _consumer;
        private readonly IManagedTracer _tracer;

        private readonly DateTimeOffset _startTime;

        public TraceHeaderPropagatingHandlerTest()
        {
            _testId = IdGenerator.FromDateTime();

            _consumer = new GrpcTraceConsumer(TraceServiceClient.Create());
            _tracer = SimpleManagedTracer.Create(_consumer, TestEnvironment.GetTestProjectId(), _traceIdFactory.NextId(), null);

            _startTime = DateTimeOffset.UtcNow;
        }

        [Fact]
        public async Task TraceOutGoing()
        {
            string googleUri = "https://google.com/";
            var spanName = EntryData.GetMessage(nameof(TraceOutGoing), _testId);

            await TraceOutGoingRequest(spanName, googleUri, false);

            var trace = TraceEntryPolling.Default.GetTrace(spanName, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, spanName, googleUri);
            TraceEntryVerifiers.AssertSpanLabelsExact(
                trace.Spans.First(s => s.Name == googleUri), TraceEntryData.HttpGetSuccessLabels);
        }

        [Fact]
        public async Task TraceOutGoing_Exception()
        {
            string fakeUri = "http://www.thiscannotpossiblyexist934719238.com/";
            var spanName = EntryData.GetMessage(nameof(TraceOutGoing_Exception), _testId);

            await TraceOutGoingRequest(spanName, fakeUri, true);

            var trace = TraceEntryPolling.Default.GetTrace(spanName, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, spanName, fakeUri);
            var span = trace.Spans.Where(s => s.Name == fakeUri).Single();
            TraceEntryVerifiers.AssertSpanLabelsContains(span,
                new Dictionary<string, string>
                {
                    {TraceLabels.HttpMethod, "GET" },
                });
            TraceEntryVerifiers.AssertContainsStackTrace(span);
        }

        [Fact]
        public async Task TraceOutGoing_HttpError()
        {
            string fakeUri = "https://google.com/404";
            var spanName = EntryData.GetMessage(nameof(TraceOutGoing_HttpError), _testId);

            await TraceOutGoingRequest(spanName, fakeUri, false);

            var trace = TraceEntryPolling.Default.GetTrace(spanName, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, spanName, fakeUri);
            TraceEntryVerifiers.AssertSpanLabelsExact(trace.Spans.Where(s => s.Name == fakeUri).Single(),
                new Dictionary<string, string>
                {
                    {TraceLabels.HttpMethod, "GET" },
                    {TraceLabels.HttpStatusCode, "404" }
                });
        }

        /// <summary>
        /// Creates a <see cref="TraceHeaderPropagatingHandler"/> and traces the sending of a
        /// GET request to the given Uri.  The trace is wrapped in a parent span.
        /// </summary>
        /// <param name="rootSpanName">The name of the root span that will wrap the span
        /// that traces the request.</param>
        /// <param name="uri">The Uri to request.</param>
        /// <param name="exceptionExpected">True if an exception from the request to the Uri is expected.</param>
        private async Task TraceOutGoingRequest(string rootSpanName, string uri, bool exceptionExpected)
        {
            using (_tracer.StartSpan(rootSpanName))
#pragma warning disable CS0618 // Type or member is obsolete
            using (var traceHeaderHandler = new TraceHeaderPropagatingHandler(() => _tracer))
#pragma warning restore CS0618 // Type or member is obsolete
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

        public void Dispose()
        {
            _consumer.Dispose();
        }
    }
}
