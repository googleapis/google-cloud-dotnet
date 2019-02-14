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

        [Fact(Skip = "Until we have CI infrastructure to deploy Google.Cloud.Diagnostics.AspNet.ClientApp")]
        public async Task Trace_CurrentTracer_AsyncLocal()
        {
            string clientAppUri = "http://localhost:58755/api/Home/";
            IList<string> spanIds = new List<string>();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(clientAppUri);

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
                var trace = _polling.GetTrace($"/api/Home/{spanId}", _startTime);
                TraceEntryVerifiers.AssertParentChildSpan(trace, $"/api/Home/{spanId}", $"parent-{spanId}", $"child-{spanId}");
            }
        }
    }
}
