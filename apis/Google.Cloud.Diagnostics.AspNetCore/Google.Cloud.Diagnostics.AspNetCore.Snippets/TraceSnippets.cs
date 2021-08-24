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
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.Snippets
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
#else
#error unknown target framework
#endif
{
    using static IntegrationTests.TestServerHelpers;

    [SnippetOutputCollector]
    public class TraceSnippetsTests : IDisposable
    {
        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly DateTimeOffset _startTime;

        public TraceSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();

            _server = GetTestServer<TraceTestApplication.Startup>();
            _client = _server.CreateClient();

            _startTime = DateTimeOffset.UtcNow;

            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();
        }

        [Fact]
        public async Task Traces_Block()
        {
            var uri = $"/TraceSamples/{nameof(TraceSamplesController.TraceHelloWorld)}/{_testId}";
            var response = await _client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, _testId);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        [Fact]
        public async Task Traces_RunIn()
        {
            var uri = $"/TraceSamples/{nameof(TraceSamplesController.TraceHelloWorldRunIn)}/{_testId}";
            var response = await _client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, _testId);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
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
        public async Task Traces_Outgoing()
        {
            var uri = $"/TraceSamples/{nameof(TraceSamplesController.TraceOutgoing)}/{_testId}";
            var response = await _client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, "http://weather.com/");
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        [Fact]
        public async Task Traces_OutgoingClientFactory()
        {
            var uri = $"/TraceSamples/{nameof(TraceSamplesController.TraceOutgoingClientFactory)}/{_testId}";

            using var server = GetTestServer<TraceClientFactoryTestApplication.Startup>();
            using var client = server.CreateClient();
            var response = await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, "http://weather.com/");
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        [Fact]
        public async Task Traces_CustomTraceContext()
        {
            var uri = $"/TraceSamples/{nameof(TraceSamplesController.TraceHelloWorld)}/{_testId}";
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

        private void Troubleshooting()
        {
            // Not a test - just a sample.
            
            // Sample: Troubleshooting
            // Explicitly create trace options that will propagate any exceptions thrown during tracing.
            RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            // Also set the no buffer option so that tracing is attempted immediately.
            BufferOptions bufferOptions = BufferOptions.NoBuffer();
            TraceOptions traceOptions = TraceOptions.Create(bufferOptions: bufferOptions, retryOptions: retryOptions);
            // End sample
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

            public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
            {
                application.Configure(app);
                base.Configure(app, loggerFactory);
            }
        }

        // Sample: RegisterGoogleTracer
        public void ConfigureServices(IServiceCollection services)
        {
            // Replace ProjectId with your Google Cloud Project ID.
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = ProjectId;
            });

            // Add any other services your application requires, for instance,
            // depending on the version of ASP.NET Core you are using, you may
            // need one of the following:

            // services.AddMvc();

            // services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Use at the start of the request pipeline to ensure the entire request is traced.
            app.UseGoogleTrace();

            // Add any other configuration your application requires, for instance,
            // depending on the verson of ASP.NET Core you are using, you may
            // need one of the following:

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});
        }
        // End sample
    }

    internal class TraceClientFactoryTestApplication
    {
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        // To hide some implementation details from the
        // sample code, like how we are overriding the methods.
        internal class Startup : BaseStartup
        {
            private readonly TraceClientFactoryTestApplication application = new TraceClientFactoryTestApplication();

            public override void ConfigureServices(IServiceCollection services)
            {
                application.ConfigureServices(services);
                base.ConfigureServices(services);
            }

            public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
            {
                application.Configure(app);
                base.Configure(app, loggerFactory);
            }
        }

        // Sample: ConfigureHttpClient
        public void ConfigureServices(IServiceCollection services)
        {
            // Replace ProjectId with your Google Cloud Project ID.
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = ProjectId;
            });

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

        public void Configure(IApplicationBuilder app)
        {
            // Use at the start of the request pipeline to ensure the entire request is traced.
            app.UseGoogleTrace();

            // Add any other configuration your application requires, for instance,
            // depending on the verson of ASP.NET Core you are using, you may
            // need one of the following:

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});
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

            public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
            {
                application.Configure(app);
                base.Configure(app, loggerFactory);
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
                (response, traceContext) => response.Headers.Add("custom_trace_id", traceContext.TraceId));

            // Now you can register Google Trace normally.

            // Replace ProjectId with your Google Cloud Project ID.
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = ProjectId;
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

        public void Configure(IApplicationBuilder app)
        {
            // Use at the start of the request pipeline to ensure the entire request is traced.
            app.UseGoogleTrace();

            // Add any other configuration your application requires, for instance,
            // depending on the verson of ASP.NET Core you are using, you may
            // need one of the following:

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});
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
            using var httpClient = new HttpClient(traceHeaderHandler);
            // Any code that makes outgoing requests.
            return await httpClient.GetAsync("http://weather.com/");
        }
        // End sample

        // Sample: TraceOutgoingClientFactory
        /// <summary>
        /// Use the <see cref="IHttpClientFactory"/> to create an HttpClient that will guarantee
        /// the tracing of outgoing requests.
        /// The <see cref="IHttpClientFactory"/> is populated by dependency injection
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public async Task<HttpResponseMessage> TraceOutgoingClientFactory([FromServices] IHttpClientFactory clientFactory)
        {
            var httpClient = clientFactory.CreateClient("tracesOutgoing");
            // Any code that makes outgoing requests.
            return await httpClient.GetAsync("http://weather.com/");
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
