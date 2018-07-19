// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using GcpTrace = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    [SnippetOutputCollector]
    public class TraceSnippetsTests : IDisposable
    {
        private static readonly TraceEntryPolling s_polling = new TraceEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly Timestamp _startTime;

        public TraceSnippetsTests()
        {
            _testId = Utils.GetTestId();

            var builder = new WebHostBuilder().UseStartup<TraceTestApplication>();
            _server = new TestServer(builder);
            _client = _server.CreateClient();

            _startTime = Timestamp.FromDateTime(DateTime.UtcNow);

            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();
        }

        [Fact]
        public async Task Traces_Block()
        {
            HttpResponseMessage response = await _client.GetAsync($"/TraceSamples/TraceHelloWorld/{_testId}");

            PollAndVerifyTrace(_startTime, "/TraceSamples/TraceHelloWorld/", _testId, response);
        }

        [Fact]
        public async Task Traces_RunIn()
        {
            HttpResponseMessage response = await _client.GetAsync($"/TraceSamples/TraceHelloWorldRunIn/{_testId}");

            PollAndVerifyTrace(_startTime, "/TraceSamples/TraceHelloWorldRunIn/", _testId, response);
        }

        [Fact]
        public async Task Traces_ConstructorInjection()
        {
            HttpResponseMessage response = await _client.GetAsync($"/TraceSamplesConstructor/TraceHelloWorld/{_testId}");

            PollAndVerifyTrace(_startTime, "/TraceSamplesConstructor/TraceHelloWorld/", _testId, response);
        }

        [Fact]
        public async Task Traces_MethodInjection()
        {
            HttpResponseMessage response = await _client.GetAsync($"/TraceSamplesMethod/TraceHelloWorld/{_testId}");

            PollAndVerifyTrace(_startTime, "/TraceSamplesMethod/TraceHelloWorld/", _testId, response);
        }

        [Fact]
        public async Task Traces_Outgoing()
        {
            HttpResponseMessage response = await _client.GetAsync($"/TraceSamples/TraceOutgoing/{_testId}");

            PollAndVerifyTrace(_startTime, "/TraceSamples/TraceOutgoing/", "https://weather.com/", response);
        }

        internal static void PollAndVerifyTrace(Timestamp startTime, string automaticSpanName, string explicitSpanName, HttpResponseMessage response)
        {
            GcpTrace trace = s_polling.GetTrace(explicitSpanName, startTime);

            Assert.NotNull(trace);
            Assert.Equal(2, trace.Spans.Count);

            var span = trace.Spans.FirstOrDefault(s => s.Name.StartsWith(automaticSpanName));

            Assert.NotNull(span);
            Assert.NotEmpty(span.Labels);
            Assert.Equal("GET", span.Labels[TraceLabels.HttpMethod]);
            Assert.Equal("200", span.Labels[TraceLabels.HttpStatusCode]);

            span = trace.Spans.FirstOrDefault(s => s.Name.StartsWith(explicitSpanName));

            Assert.NotNull(span);

            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="CloudTraceMiddleware"/>
    /// and associated classes.
    /// </summary>
    internal class TraceTestApplication
    {
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        // Sample: RegisterGoogleTracer
        public void ConfigureServices(IServiceCollection services)
        {
            // The line below is needed for trace ids to be added to logs.
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Replace ProjectId with your Google Cloud Project ID.
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = ProjectId;
            });

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Use at the start of the request pipeline to ensure the entire request is traced.
            app.UseGoogleTrace();

            // ...any other configuration your application requires.

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        // End sample
    }

    /// <summary>
    /// A controller for the <see cref="TraceTestApplication"/> used to trace operations.
    /// </summary>
    public class TraceSamplesController : Controller
    {
        // Sample: UseTracer
        /// <summary>
        /// Manually trace a set of operations.
        /// The <see cref="IManagedTracer"/> is populated by dependency injection
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public void TraceHelloWorld(string id, [FromServices] IManagedTracer tracer)
        {
            // Change the name of the span to what makese sense in your context.
            using (tracer.StartSpan(id))
            {
                // The code whose execution is to be included in the span goes here.
                ViewData["Message"] = "Hello World.";
            }
        }
        // End sample

        // Sample: UseTracerRunIn
        /// <summary>
        /// Manually trace a specific Action or Func<T>.
        /// The <see cref="IManagedTracer"/> is populated by dependency injection
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public void TraceHelloWorldRunIn(string id, [FromServices]IManagedTracer tracer)
        {
            tracer.RunInSpan(
                // The Action or Func<T> to be traced.
                () =>
                {
                    // The code whose execution is to be included in the span goes here.
                    ViewData["Message"] = "Hello World.";
                },
                // The name of the span.
                id);
        }
        // End sample

        // Sample: TraceOutgoing
        /// <summary>
        /// Add a handler to trace outgoing requests and to propagate the trace header.
        /// The <see cref="TraceHeaderPropagatingHandler"/> is populated by dependency injection
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public async Task<HttpResponseMessage> TraceOutgoing([FromServices] TraceHeaderPropagatingHandler traceHeaderHandler)
        {
            using (var httpClient = new HttpClient(traceHeaderHandler))
            {
                // Any code that makes outgoing requests.
                return await httpClient.GetAsync("https://weather.com/");
            }
        }
        // End sample
    }

    // Sample: TraceMVCConstructor
    public class TraceSamplesConstructorController : Controller
    {
        private readonly IManagedTracer _tracer;

        /// <summary>
        /// The <see cref="IManagedTracer"/> is populated by dependency injection.
        /// </summary>
        public TraceSamplesConstructorController(IManagedTracer tracer)
        {
            _tracer = tracer;
        }

        public void TraceHelloWorld(string id)
        {
            // Change the name of the span to what makese sense in your context.
            using (_tracer.StartSpan(id))
            {
                // The code whose execution is to be included in the span goes here.
                ViewData["Message"] = "Hello World.";
            }
        }
    }
    // End sample

    // Sample: TraceMVCMethod
    public class TraceSamplesMethodController : Controller
    {
        /// <summary>
        /// Manually trace a set of operations.
        /// The <see cref="IManagedTracer"/> is populated by dependency injection
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public void TraceHelloWorld(string id, [FromServices] IManagedTracer tracer)
        {
            // Change the name of the span to what makese sense in your context.
            using (tracer.StartSpan(id))
            {
                // The code whose execution is to be included in the span goes here.
                ViewData["Message"] = "Hello World.";
            }
        }
    }
    // End sample
}
