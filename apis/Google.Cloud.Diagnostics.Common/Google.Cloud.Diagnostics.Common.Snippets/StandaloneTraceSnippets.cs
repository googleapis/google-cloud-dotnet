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
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Snippets
{
    public class StandaloneTraceSnippets
    {
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;

        private readonly DateTimeOffset _startTime;

        public StandaloneTraceSnippets()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTimeOffset.UtcNow;

            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();
        }

        // Sample: Configure
        public static IHostBuilder CreateHostBuilder() =>
            new HostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddGoogleTrace(new Common.TraceServiceOptions { ProjectId = ProjectId });
                    // Register other services here if you need them.
                });
        // End sample

        [Fact]
        public async Task TraceAsync()
        {
            // Naming it like an instance variable so that it looks like that on sample code.
            IHost _host = null;

            try
            {
                // Sample: Start
                _host = CreateHostBuilder().Build();
                await _host.StartAsync();
                // End sample

                // Sample: IncomingContext
                ITraceContext traceContext = GetTraceContextFromIncomingRequest();
                var tracerFactory = _host.Services.GetRequiredService<Func<ITraceContext, IManagedTracer>>();
                IManagedTracer tracer = tracerFactory(traceContext);
                ContextTracerManager.SetCurrentTracer(tracer);
                // End sample

                // Let's just start a span with the test ID so we can find it faster.
                // But we don't show this in sample code.
                using (tracer.StartSpan(_testId))
                {
                    // Sample: Trace
                    IManagedTracer currentTracer = _host.Services.GetRequiredService<IManagedTracer>();
                    using (currentTracer.StartSpan("standalone_tracing"))
                    {
                        Console.WriteLine("Using Cloud Trace from a non ASP.NET Core app");
                    }
                    // End sample
                }

                var trace = TraceEntryPolling.Default.GetTrace(_testId, _startTime);
                TraceEntryVerifiers.AssertParentChildSpan(trace, _testId, "standalone_tracing");
                Assert.Equal(traceContext.TraceId, trace.TraceId);
            }
            finally
            {
                if (_host != null)
                {
                    await _host.StopAsync();
                }
            }
        }

        private static ITraceContext GetTraceContextFromIncomingRequest() =>
            new SimpleTraceContext(TraceIdFactory.Create().NextId(), null, true);
    }
}


