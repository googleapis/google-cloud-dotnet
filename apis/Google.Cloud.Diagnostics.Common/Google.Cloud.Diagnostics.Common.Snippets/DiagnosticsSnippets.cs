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
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Snippets
{
    public class DiagnosticsSnippets
    {
        private const string Service = EntryData.Service;
        private const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;
        private readonly DateTimeOffset _startTime;

        public DiagnosticsSnippets()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTimeOffset.UtcNow;
        }

        private static class DefaultHostBuilder
        {
            // Sample: Configure
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        // Replace Service with a name or identifier for the service.
                        // Replace Version with a version for the service.
                        services.AddGoogleDiagnostics(ProjectId, Service, Version);
                        // Register other services here if you need them.
                    });
            // End sample
        }

        private static class NoBuffersHostBuilder
        {
            // Sample: ConfigureBuffers
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        // Replace Service with a name or identifier for the service.
                        // Replace Version with a version for the service.
                        services.AddGoogleDiagnostics(ProjectId, Service, Version,
                            // Configure the three components to use no buffer.
                            traceOptions: TraceOptions.Create(bufferOptions: BufferOptions.NoBuffer()),
                            loggingOptions: LoggingOptions.Create(bufferOptions: BufferOptions.NoBuffer()),
                            errorReportingOptions: ErrorReportingOptions.Create(bufferOptions: BufferOptions.NoBuffer()));
                        // Register other services here if you need them.
                    });
            // End sample
        }

        public static TheoryData<Func<IHostBuilder>> HostBuilders => new TheoryData<Func<IHostBuilder>>
        {
            DefaultHostBuilder.CreateHostBuilder,
            NoBuffersHostBuilder.CreateHostBuilder
        };

        [Theory]
        [MemberData(nameof(HostBuilders))]
        public async Task TraceSingleAsync(Func<IHostBuilder> hostBuilder)
        {
            IHost host = null;
            // Hides that we use different classes so that we can have multiple CreateHostBuilder methods.
            Func<IHostBuilder> CreateHostBuilder = hostBuilder;

            try
            {
                // Sample: Start
                host = CreateHostBuilder().Build();
                await host.StartAsync();
                // End sample

                ITraceContext traceContext = new SimpleTraceContext(null, null, true);
                var tracerFactory = host.Services.GetRequiredService<Func<ITraceContext, IManagedTracer>>();
                IManagedTracer tracer = tracerFactory(traceContext);
                ContextTracerManager.SetCurrentTracer(tracer);

                using (tracer.StartSpan(_testId))
                {
                    IManagedTracer currentTracer = host.Services.GetRequiredService<IManagedTracer>();
                    currentTracer.RunInSpan(
                        () => Console.WriteLine("Using Cloud Trace from a non ASP.NET Core app"),
                        "testing_tracing");
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

        [Theory]
        [MemberData(nameof(HostBuilders))]
        public async Task LogsAsync(Func<IHostBuilder> hostBuilder)
        {
            IHost host = null;

            try
            {
                host = hostBuilder().Build();
                await host.StartAsync();

                ILogger logger = host.Services.GetRequiredService<ILogger<Program>>();
                logger.LogInformation(_testId);

                LoggingSnippets.PollAndVerifyLog(LogEntryPolling.Default, _startTime, _testId);
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        [Theory]
        [MemberData(nameof(HostBuilders))]
        public async Task LogsExceptionAsync(Func<IHostBuilder> hostBuilder)
        {
            IHost host = null;

            try
            {
                host = hostBuilder().Build();
                await host.StartAsync();

                IContextExceptionLogger exceptionLogger = host.Services.GetRequiredService<IContextExceptionLogger>();
                try
                {
                    ThrowsException();
                }
                catch (Exception e)
                {
                    exceptionLogger.Log(e, null);
                }

                var errorEvent = ErrorEventEntryVerifiers.VerifySingle(ErrorEventEntryPolling.Default, _testId);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(
                    errorEvent, _testId, nameof(ThrowsException), verifyHttpContext: false);
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        private void ThrowsException() => throw new Exception(_testId);
    }
}
