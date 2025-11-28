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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests.TestServerHelpers;

namespace Google.Cloud.Diagnostics.AspNetCore3.Snippets
{
    [SnippetOutputCollector]
    public class TraceSnippetsTests : IDisposable
    {
        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly DateTimeOffset _startTime;

        public TraceSnippetsTests()
        {
            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();

            _testId = IdGenerator.FromDateTime();

            _server = GetTestServer<TraceTestApplication.Startup>();
            _client = _server.CreateClient();

            _startTime = DateTimeOffset.UtcNow;
        }

        [Fact]
        public async Task Traces_ConstructorInjection()
        {
            var uri = $"/TraceSamplesConstructor/{nameof(TraceSamplesConstructorController.TraceHelloWorld)}/{_testId}";
            var response = await _client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, _testId);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        [Fact]
        public async Task Traces_MethodInjection()
        {
            var uri = $"/TraceSamplesMethod/{nameof(TraceSamplesMethodController.TraceHelloWorld)}/{_testId}";
            var response = await _client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, _testId);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        [Fact]
        public async Task Traces_CustomTraceContext()
        {
            var uri = $"/TraceSamplesConstructor/{nameof(TraceSamplesConstructorController.TraceHelloWorld)}/{_testId}";
            var traceId = TraceIdFactory.Create().NextId();

            using var server = GetTestServer<CustomTraceContextTestApplication.Startup>();
            using var client = server.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, uri)
            {
                Headers = { { "custom_trace_id", traceId } }
            };
            var response = await client.SendAsync(request);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, _testId);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));

            Assert.Equal(traceId, trace.TraceId);
            Assert.True(response.Headers.Contains("custom_trace_id"));
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

        // To hide some implementation details from the
        // sample code, like how we are overriding the methods.
        internal class Startup : BaseStartup
        {
            private readonly TraceTestApplication application = new TraceTestApplication();

            public override void ConfigureServices(IServiceCollection services)
            {
                application.ConfigureServices(services);
                base.ConfigureServices(services);
            }
        }

        // Sample: RegisterGoogleTracer
        public void ConfigureServices(IServiceCollection services)
        {
            // Replace ProjectId with your Google Cloud Project ID.
            services.AddGoogleTraceForAspNetCore(new AspNetCoreTraceOptions
            {
                ServiceOptions = new Common.TraceServiceOptions
                {
                    ProjectId = ProjectId
                }
            });

            // Add any other services your application requires, for instance,
            // depending on the version of ASP.NET Core you are using, you may
            // need one of the following:

            // services.AddMvc();

            // services.AddControllersWithViews();
        }
        // End sample
    }

    internal class CustomTraceContextTestApplication
    {
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        // To hide some implementation details from the
        // sample code, like how we are overriding the methods.
        internal class Startup : BaseStartup
        {
            private readonly CustomTraceContextTestApplication application = new CustomTraceContextTestApplication();

            public override void ConfigureServices(IServiceCollection services)
            {
                application.ConfigureServices(services);
                base.ConfigureServices(services);
            }
        }

        // Sample: CustomTraceContext
        public void ConfigureServices(IServiceCollection services)
        {

            // Register a trace context provider method that inspects the request and
            // extracts the trace context information.
            services.AddScoped(CustomTraceContextProvider);
            static ITraceContext CustomTraceContextProvider(IServiceProvider sp)
            {
                var accessor = sp.GetRequiredService<IHttpContextAccessor>();
                string traceId = accessor.HttpContext?.Request?.Headers["custom_trace_id"];
                return new SimpleTraceContext(traceId, null, null);
            }

            // Register a method that sets the updated trace context information on the response.
            services.AddSingleton<Action<HttpResponse, ITraceContext>>(
                (response, traceContext) => response.Headers.Append("custom_trace_id", traceContext.TraceId));

            // Now you can register Google Trace normally.

            // Replace ProjectId with your Google Cloud Project ID.
            services.AddGoogleTraceForAspNetCore(new AspNetCoreTraceOptions
            {
                ServiceOptions = new Common.TraceServiceOptions
                {
                    ProjectId = ProjectId
                }
            });

            // If your application is making outgoing HTTP requests then you configure
            // your HTTP client for trace propagation as you normally would.
            // If the trace context information should be propagated in a custom format
            // then you register a method that sets the trace context information on the
            // outgoing request.
            services.AddSingleton<Action<HttpRequestMessage, ITraceContext>>(
                (request, traceContext) => request.Headers.Add("custom_trace_id", traceContext.TraceId));

            // Register an HttpClient for outgoing requests.
            services.AddHttpClient("tracesOutgoing")
                // The next call guarantees that trace information is propagated for outgoing
                // requests that are already being traced.
                .AddOutgoingGoogleTraceHandler();

            // Add any other services your application requires, for instance,
            // depending on the version of ASP.NET Core you are using, you may
            // need one of the following:

            // services.AddMvc();

            // services.AddControllersWithViews();
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
