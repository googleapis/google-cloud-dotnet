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
using System.IO;
using System.Threading;
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
    }
}
