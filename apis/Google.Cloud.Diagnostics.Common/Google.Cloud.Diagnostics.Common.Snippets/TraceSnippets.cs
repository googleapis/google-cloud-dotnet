// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Snippets
{
    public class TraceSnippets
    {
        private const string OutgoingUrl = "https://www.google.com/";
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;

        private readonly DateTimeOffset _startTime;

        public TraceSnippets()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTimeOffset.UtcNow;

            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();
        }

        private static class DefaultHostBuilder
        {
            // Sample: Configure
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddGoogleTrace(new TraceServiceOptions { ProjectId = ProjectId });
                        // Register other services here if you need them.
                    });
            // End sample
        }

        private static class TroubleshootingHostBuilder
        {
            // Sample: Troubleshooting
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Explicitly create trace options that will propagate any exceptions thrown during tracing.
                        RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
                        // Also set the no buffer option so that tracing is attempted immediately.
                        BufferOptions bufferOptions = BufferOptions.NoBuffer();
                        TraceOptions traceOptions = TraceOptions.Create(bufferOptions: bufferOptions, retryOptions: retryOptions);

                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddGoogleTrace(new TraceServiceOptions { ProjectId = ProjectId, Options = traceOptions });
                        // Register other services here if you need them.
                    });
            // End sample
        }

        private static class OutgoingHostBuilder
        {
            // Sample: ConfigureHttpClient
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddGoogleTrace(new TraceServiceOptions { ProjectId = ProjectId });

                        // Register an HttpClient for outgoing requests.
                        services.AddHttpClient("tracesOutgoing")
                            // The next call guarantees that trace information is propagated for outgoing
                            // requests that are already being traced.
                            .AddOutgoingGoogleTraceHandler();

                        // Register other services here if you need them.
                    });
            // End sample
        }

        private static class CustomgOutgoingHostBuilder
        {
            // Sample: CustomConfigureHttpClient
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddGoogleTrace(new TraceServiceOptions { ProjectId = ProjectId });

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

                        // Register other services here if you need them.
                    });
            // End sample
        }

        [Fact]
        public async Task TraceIncomingAsync()
        {
            IHost host = null;
            // Hides that we use different classes so that we can have multiple CreateHostBuilder methods.
            Func<IHostBuilder> CreateHostBuilder = DefaultHostBuilder.CreateHostBuilder;

            try
            {
                // Sample: Start
                host = CreateHostBuilder().Build();
                await host.StartAsync();
                // End sample

                object request = null;
                // Sample: IncomingContext
                ITraceContext traceContext = GetTraceContextFromIncomingRequest(request);
                var tracerFactory = host.Services.GetRequiredService<Func<ITraceContext, IManagedTracer>>();
                IManagedTracer tracer = tracerFactory(traceContext);
                ContextTracerManager.SetCurrentTracer(tracer);
                // End sample

                // Let's just start a span with the test ID so we can find it faster.
                // But we don't show this in sample code.
                using (tracer.StartSpan(_testId))
                {
                    // Sample: Trace
                    IManagedTracer currentTracer = host.Services.GetRequiredService<IManagedTracer>();
                    using (currentTracer.StartSpan("testing_tracing"))
                    {
                        Console.WriteLine("Using Cloud Trace from a non ASP.NET Core app");
                    }
                    // End sample
                }

                var trace = TraceEntryPolling.Default.GetTrace(_testId, _startTime);
                TraceEntryVerifiers.AssertParentChildSpan(trace, _testId, "testing_tracing");
                Assert.Equal(traceContext.TraceId, trace.TraceId);
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        [Fact]
        public async Task TraceSingleAsync()
        {
            IHost host = null;

            try
            {
                host = TroubleshootingHostBuilder.CreateHostBuilder().Build();
                await host.StartAsync();

                // Sample: SingleContext
                ITraceContext traceContext = new SimpleTraceContext(null, null, true);
                var tracerFactory = host.Services.GetRequiredService<Func<ITraceContext, IManagedTracer>>();
                IManagedTracer tracer = tracerFactory(traceContext);
                ContextTracerManager.SetCurrentTracer(tracer);
                // End sample

                // Let's just start a span with the test ID so we can find it faster.
                // But we don't show this in sample code.
                using (tracer.StartSpan(_testId))
                {
                    // Sample: RunIn
                    IManagedTracer currentTracer = host.Services.GetRequiredService<IManagedTracer>();
                    currentTracer.RunInSpan(
                        () => Console.WriteLine("Using Cloud Trace from a non ASP.NET Core app"),
                        "testing_tracing");
                    // End sample
                }

                var trace = TraceEntryPolling.Default.GetTrace(_testId, _startTime);
                TraceEntryVerifiers.AssertParentChildSpan(trace, _testId, "testing_tracing");
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        [Fact]
        public async Task TraceOutgoingAsync()
        {
            IHost host = null;

            try
            {
                host = OutgoingHostBuilder.CreateHostBuilder().Build();
                await host.StartAsync();

                ITraceContext traceContext = new SimpleTraceContext(null, null, true);
                var tracerFactory = host.Services.GetRequiredService<Func<ITraceContext, IManagedTracer>>();
                IManagedTracer tracer = tracerFactory(traceContext);
                ContextTracerManager.SetCurrentTracer(tracer);

                // Let's just start a span with the test ID so we can find it faster.
                // But we don't show this in sample code.
                using (tracer.StartSpan(_testId))
                {
                    // Sample: TraceOutgoingClientFactory
                    IHttpClientFactory clientFactory = host.Services.GetRequiredService<IHttpClientFactory>();
                    var httpClient = clientFactory.CreateClient("tracesOutgoing");
                    // Any code that makes outgoing requests.
                    var response = await httpClient.GetAsync(OutgoingUrl);
                    // End sample
                }

                var trace = TraceEntryPolling.Default.GetTrace(_testId, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, _testId, OutgoingUrl);
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        [Fact]
        public async Task TraceCustomOutgoingAsync()
        {
            // Naming it like a static variable so that it looks like that on sample code.
            IHost host = null;

            try
            {
                host = CustomgOutgoingHostBuilder.CreateHostBuilder().Build();
                await host.StartAsync();

                ITraceContext traceContext = new SimpleTraceContext(null, null, true);
                var tracerFactory = host.Services.GetRequiredService<Func<ITraceContext, IManagedTracer>>();
                IManagedTracer tracer = tracerFactory(traceContext);
                ContextTracerManager.SetCurrentTracer(tracer);

                // Let's just start a span with the test ID so we can find it faster.
                // But we don't show this in sample code.
                using (tracer.StartSpan(_testId))
                {
                    IHttpClientFactory clientFactory = host.Services.GetRequiredService<IHttpClientFactory>();
                    var httpClient = clientFactory.CreateClient("tracesOutgoing");
                    // Any code that makes outgoing requests.
                    var response = await httpClient.GetAsync(OutgoingUrl);
                }

                var trace = TraceEntryPolling.Default.GetTrace(_testId, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, _testId, OutgoingUrl);
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        private static ITraceContext GetTraceContextFromIncomingRequest(object _) =>
            new SimpleTraceContext(TraceIdFactory.Create().NextId(), null, true);
    }
}


