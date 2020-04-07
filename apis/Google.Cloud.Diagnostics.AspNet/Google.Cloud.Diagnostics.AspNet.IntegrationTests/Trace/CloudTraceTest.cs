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
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.IntegrationTests
{
    public class CloudTraceTest : IDisposable
    {
        private readonly string _projectId;
        private readonly string _testId;
        private readonly Timestamp _startTime;

        private static readonly TraceOptions _noBuffer = TraceOptions.Create(bufferOptions: BufferOptions.NoBuffer());
        private readonly TraceEntryPolling _polling = new TraceEntryPolling();

        public CloudTraceTest()
        {
            _projectId = TestEnvironment.GetTestProjectId();
            _testId = IdGenerator.FromDateTime();
            _startTime = Timestamp.FromDateTime(DateTime.UtcNow);

            // Set up a fake HttpContext to trace with.
            var response = new HttpResponse(File.CreateText(Path.GetTempFileName()));
            var request = new HttpRequest("some-file", $"http://some-site.com/{_testId}", "");
            HttpContext.Current = new HttpContext(request, response);
        }

        // Remove the HttpContext from the test.
        public void Dispose() => HttpContext.Current = null;
        
        [Fact]
        public void Trace()
        {
            using (var cloudTrace = CloudTrace.InitializeInternal(new HttpApplication(), _projectId, _noBuffer))
            {
                cloudTrace.BeginRequest(null, null);
                cloudTrace.EndRequest(null, null);
            }

            var trace = _polling.GetTrace($"/{_testId}", _startTime);
            Assert.NotNull(trace);
            Assert.Single(trace.Spans);
        }

        [Fact]
        public void No_Trace()
        {
            var predicate = TraceDecisionPredicate.Create((req) => false);
            using (var cloudTrace = CloudTrace.InitializeInternal(new HttpApplication(), 
                projectId: _projectId, options: _noBuffer, traceFallbackPredicate: predicate))
            {
                cloudTrace.BeginRequest(null, null);
                cloudTrace.EndRequest(null, null);
            }

            var trace = _polling.GetTrace($"/{_testId}", _startTime, false);
            Assert.Null(trace);
        }

        [Fact]
        public void Trace_Multiple_Spans()
        {
            using (var cloudTrace = CloudTrace.InitializeInternal(new HttpApplication(), _projectId, _noBuffer))
            {
                cloudTrace.BeginRequest(null, null);
                using (CloudTrace.Tracer.StartSpan("/another-trace"))
                {
                    Thread.Sleep(TimeSpan.FromMilliseconds(10));
                }
                cloudTrace.EndRequest(null, null);
            }

            var trace = _polling.GetTrace($"/{_testId}", _startTime);
            Assert.NotNull(trace);
            Assert.Equal(2, trace.Spans.Count);
        }

        // All the following tests would need an AspNet application to be deployed to work,
        // and we currently don't have such a setup.
        // The application we are using is Google.Cloud.Diagnostics.AspNet.ClientApp and we deploy
        // on local and test on local.
        // But for CI all these tests should be skipped. See this comment as to why:
        // https://github.com/googleapis/google-cloud-dotnet/issues/2167#issuecomment-409605030

        private static readonly Uri PublishedServiceBaseAddress = new Uri("http://localhost:58755");

        [Fact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/2167#issuecomment-409605030")]
        public async Task Trace_Iss()
        {
            var service = $"/api/Trace/Trace/{_testId}";
            var childSpanName = EntryData.GetMessage("Trace", _testId);

            HttpResponseMessage response;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = PublishedServiceBaseAddress;
                response = await httpClient.GetAsync(service);
            }

            var trace = _polling.GetTrace(service, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, service, childSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == service), TraceEntryData.HttpGetSuccessLabels);

            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        [Fact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/2167#issuecomment-409605030")]
        public async Task Trace_Iss_Label()
        {
            var service = $"/api/Trace/TraceLabels/{_testId}";
            var childSpanName = EntryData.GetMessage("TraceLabels", _testId);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = PublishedServiceBaseAddress;
                await httpClient.GetAsync(service);
            }

            var trace = _polling.GetTrace(service, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, service, childSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(trace.Spans.First(s => s.Name == childSpanName),
                new Dictionary<string, string>
                {
                        {TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue }
                });
        }

        [Fact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/2167#issuecomment-409605030")]
        public async Task Trace_Iss_StackTrace()
        {
            var service = $"/api/Trace/TraceStackTrace/{_testId}";
            var childSpanName = EntryData.GetMessage("TraceStackTrace", _testId);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = PublishedServiceBaseAddress;
                await httpClient.GetAsync(service);
            }

            var trace = _polling.GetTrace(service, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, service, childSpanName);
            TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == childSpanName),
                "TraceController", "TraceStackTrace",
                nameof(TraceEntryData), nameof(TraceEntryData.CreateStackTrace));
        }

        [Fact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/2167#issuecomment-409605030")]
        public async Task Trace_Iss_Outgoing()
        {
            var service = $"/api/Trace/TraceOutgoing/{_testId}";
            var childSpanName = EntryData.GetMessage("TraceOutgoing", _testId);
            var outgoingSpanName = "https://google.com/";

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = PublishedServiceBaseAddress;
                await httpClient.GetAsync(service);
            }

            var trace = _polling.GetTrace(service, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, service, childSpanName, outgoingSpanName);
        }

        [Fact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/2167#issuecomment-409605030")]
        public async Task Trace_Iss_CurrentTracer_AsyncLocal()
        {
            string service = "/api/Trace/ParentChild/";
            string uri = $"{PublishedServiceBaseAddress}{service}";
            IList<string> spanIds = new List<string>();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(uri);

                IList<Task> tasks = new List<Task>();
                for(int i = 0; i < 10; i++)
                {
                    string spanId = IdGenerator.FromGuid();
                    spanIds.Add(spanId);
                    tasks.Add(httpClient.GetStringAsync(spanId));
                }

                await Task.WhenAll(tasks);
            }

            // We are testing here that each request hast its own IManagedTracer.
            // The tracer holds the span stack, and the api method we are using is creating
            // spans as follows:
            // $"/api/Home/{spanId}"
            //  --$"parent-{spanId}"
            //  ----$"child-{spanId}"
            // If the tracer is changed during a request, then the span stack will change as well
            // and there's no way that our 10 traces have all the correct span structure maintaining
            // the spanId throughout, since each request has its own spanId.
            // This cannot be tested on CI yet, but passed in local.
            foreach (string spanId in spanIds)
            {
                var trace = _polling.GetTrace($"{service}{spanId}", _startTime);
                TraceEntryVerifiers.AssertParentChildSpan(trace, $"{service}{spanId}", $"parent-{spanId}", $"child-{spanId}");
            }
        }
    }
}
