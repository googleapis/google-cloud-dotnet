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

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using Google.Cloud.Logging.Type;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public class DiagnosticsTests
    {
        private const string Service = EntryData.Service;
        private const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;
        private readonly DateTimeOffset _startTime;

        public DiagnosticsTests()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTimeOffset.UtcNow;
        }

        private static class EmptyHostBuilder
        {
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureLogging(builder => builder.ClearProviders())
                    .ConfigureServices(services => services.AddGoogleDiagnostics());
        }

        private static class DefaultHostBuilder
        {
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureLogging(builder => builder.ClearProviders())
                    .ConfigureServices(services => services.AddGoogleDiagnostics(ProjectId, Service, Version));
        }

        private static class WithOptionsHostBuilder
        {
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureLogging(builder => builder.ClearProviders())
                    .ConfigureServices(services =>
                        // We don't care much about which options we are setting.
                        // These are for testing that all the extension method overloads work as expected.
                        services.AddGoogleDiagnostics(ProjectId, Service, Version,
                            TraceOptions.Create(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate)),
                            LoggingOptions.Create(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate)),
                            ErrorReportingOptions.CreateInstance(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate))));
        }

        private static class WithServiceOptionsHostBuilder
        {
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureLogging(builder => builder.ClearProviders())
                    .ConfigureServices(services =>
                    {
                        // We don't care much about which options we are setting.
                        // These are for testing that all the extension method overloads work as expected.
                        services.AddGoogleDiagnostics(
                            new TraceServiceOptions
                            {
                                ProjectId = ProjectId,
                                Options = TraceOptions.Create(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate))
                            },
                            new LoggingServiceOptions
                            {
                                ProjectId = ProjectId,
                                ServiceName = Service,
                                Version = Version,
                                Options = LoggingOptions.Create(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate))
                            },
                            new ErrorReportingServiceOptions
                            {
                                ProjectId = ProjectId,
                                ServiceName = Service,
                                Version = Version,
                                Options = ErrorReportingOptions.CreateInstance(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate))
                            });
                    });
        }

        public static IEnumerable<object[]> HostBuilderData
        {
            get
            {
                yield return new object[] { (Func<IHostBuilder>)DefaultHostBuilder.CreateHostBuilder };
                yield return new object[] { (Func<IHostBuilder>)WithOptionsHostBuilder.CreateHostBuilder };
                yield return new object[] { (Func<IHostBuilder>)WithServiceOptionsHostBuilder.CreateHostBuilder };
                // Skip these tests if we are not running on GCP
                if (Platform.Instance().Type != PlatformType.Unknown)
                {
                    yield return new object[] { (Func<IHostBuilder>)EmptyHostBuilder.CreateHostBuilder };
                }
            }
        }

        [Theory]
        [MemberData(nameof(HostBuilderData))]
        public async Task TraceSingleAsync(Func<IHostBuilder> createHostBuilder)
        {
            IHost host = null;

            try
            {
                host = createHostBuilder().Build();
                await host.StartAsync();

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
        [MemberData(nameof(HostBuilderData))]
        public async Task LogsAsync(Func<IHostBuilder> createHostBuilder)
        {
            IHost host = null;

            try
            {
                host = createHostBuilder().Build();
                await host.StartAsync();

                ILogger logger = host.Services.GetRequiredService<ILogger<DiagnosticsTests>>();
                logger.LogInformation(_testId);

                PollAndVerifyLog(LogEntryPolling.Default, _startTime, _testId);
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
        [MemberData(nameof(HostBuilderData))]
        public async Task LogsExceptionAsync(Func<IHostBuilder> createHostBuilder)
        {
            IHost host = null;

            try
            {
                host = createHostBuilder().Build();
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
                    errorEvent, _testId, nameof(ThrowsException), verifyHttpContext: false, verifyServiceAndVersion: false);
            }
            finally
            {
                if (host is object)
                {
                    await host.StopAsync();
                }
            }
        }

        internal static void PollAndVerifyLog(LogEntryPolling poller, DateTimeOffset startTime, string testId)
        {
            var results = poller.GetEntries(startTime, testId, 1, LogSeverity.Info);
            results = from result in results
                      where result.JsonPayload?.Fields["log_name"]?.StringValue?.Equals(typeof(DiagnosticsTests).FullName) ?? false
                      select result;

            var logEntry = results.Single();

            Assert.Equal(LogSeverity.Info, logEntry.Severity);
            Assert.Contains(testId, logEntry.JsonPayload?.Fields["message"]?.StringValue);
        }

        private void ThrowsException() => throw new Exception(_testId);
    }
}
