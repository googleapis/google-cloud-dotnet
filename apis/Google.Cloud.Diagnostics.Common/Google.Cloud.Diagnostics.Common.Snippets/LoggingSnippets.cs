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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Logging.Type;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Snippets
{
    public class LoggingSnippets
    {
        private const string ExpectedGcpLogBaseUrl = "https://console.cloud.google.com/logs/viewer";

        public const string Service = EntryData.Service;
        public const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;
        private readonly DateTime _startTime;

        public LoggingSnippets()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTime.UtcNow;
        }

        private static class LoggingHostBuilder
        {
            // Sample: ConfigureLogging
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureLogging(builder => builder.AddGoogle(new LoggingServiceOptions
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        ProjectId = ProjectId,
                        // Replace Service with a name or identifier for the service.
                        ServiceName = Service,
                        // Replace Version with a version for the service.
                        Version = Version
                    }));
            // End sample
        }

        private static class ServicesHostBuilder
        {
            // Sample: ConfigureServices
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddLogging(builder => builder.AddGoogle(new LoggingServiceOptions
                        {
                            // Replace ProjectId with your Google Cloud Project ID.
                            ProjectId = ProjectId,
                            // Replace Service with a name or identifier for the service.
                            ServiceName = Service,
                            // Replace Version with a version for the service.
                            Version = Version
                        }));
                        // Register other services here if you need them.
                    });
            // End sample
        }

        private static class PropagateExceptionsHostBuilder
        {
            private const string ProjectId = "non-existent-project-id";

            // Sample: PropagatesExceptions
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        //Explicitly create logger options that will propagate any exceptions thrown
                        // during logging.
                        RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
                        // Also set the no buffer option so that writing the logs is attempted immediately.
                        BufferOptions bufferOptions = BufferOptions.NoBuffer();

                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddLogging(builder => builder.AddGoogle(new LoggingServiceOptions
                        {
                            // Replace ProjectId with your Google Cloud Project ID.
                            ProjectId = ProjectId,
                            // Replace Service with a name or identifier for the service.
                            ServiceName = Service,
                            // Replace Version with a version for the service.
                            Version = Version,
                            Options = LoggingOptions.Create(retryOptions: retryOptions, bufferOptions: bufferOptions)
                        })); ;
                        // Register other services here if you need them.
                    });
            // End sample
        }

        private static class WritesLogsUrlHostBuilder
        {
            // Sample: WritesLogsUrl
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        // Replace ProjectId with your Google Cloud Project ID.
                        services.AddLogging(builder => builder.AddGoogle(new LoggingServiceOptions
                        {
                            // Replace ProjectId with your Google Cloud Project ID.
                            ProjectId = ProjectId,
                            // Replace Service with a name or identifier for the service.
                            ServiceName = Service,
                            // Replace Version with a version for the service.
                            Version = Version,
                            // Set a TextWriter to which you want yout logs URL to be written to.
                            LoggerDiagnosticsOutput = Console.Out
                        })); ;
                        // Register other services here if you need them.
                    });
            // End sample
        }

        public static IEnumerable<object[]> BasicLoggingConfigs
        {
            get
            {
                yield return new object[] { (Func<IHostBuilder>)LoggingHostBuilder.CreateHostBuilder };
                yield return new object[] { (Func<IHostBuilder>)ServicesHostBuilder.CreateHostBuilder };
            }
        }

        [Theory]
        [MemberData(nameof(BasicLoggingConfigs))]
        public async Task LogsAsync(Func<IHostBuilder> hostBuilderCreator)
        {
            IHost host = null;
            // Hides that we use different classes so that we can have multiple CreateHostBuilder methods.
            Func<IHostBuilder> CreateHostBuilder = hostBuilderCreator;

            try
            {
                // Sample: Start
                host = CreateHostBuilder().Build();
                await host.StartAsync();
                // End sample

                string userName = _testId;
                // Sample: Logging
                ILogger logger = host.Services.GetRequiredService<ILogger<Program>>();
                logger.LogInformation($"User {userName} logged in.");
                // End sample

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

        [Fact]
        public async Task PropagatesExceptionAsync()
        {
            IHost host = null;

            try
            {
                var exception = await Assert.ThrowsAsync<AggregateException>(async () =>
                {
                    host = PropagateExceptionsHostBuilder.CreateHostBuilder().Build();
                    await host.StartAsync();

                    ILogger logger = host.Services.GetRequiredService<ILogger<Program>>();
                    logger.LogInformation(_testId);
                });

                var rpcException = Assert.Single(exception.InnerExceptions.OfType<RpcException>());
                Assert.Equal(StatusCode.NotFound, rpcException.StatusCode);
            }
            finally
            {
                if (host is object)
                {
                    host.Dispose();
                }
            }
        }

        [Fact]
        public async Task WritesLogsUrlAsync()
        {
            IHost host = null;
            TextWriter oldConsoleOut = Console.Out;
            try
            {
                using StringWriter writer = new StringWriter();
                Console.SetOut(writer);

                // No need to make an actual call to the controller. Just starting up the server
                // creates several loggers.
                host = WritesLogsUrlHostBuilder.CreateHostBuilder().Build();
                await host.StartAsync();

                string writtenInfo = writer.ToString();

                int urlStart = writtenInfo.LastIndexOf("http", StringComparison.OrdinalIgnoreCase);
                Assert.NotEqual(urlStart, -1);

                // We know the URL is the last to be written.
                string url = writtenInfo.Substring(urlStart);

                Assert.StartsWith(ExpectedGcpLogBaseUrl, url);
                Assert.Contains($"resource={MonitoredResourceBuilder.FromPlatform().Type}", url);
                Assert.Contains($"project={ProjectId}", url);
                Assert.Contains("minLogLevel=200", url);
                Assert.Contains($"logName=projects/{ProjectId}/logs/aspnetcore", url);
                Assert.DoesNotContain("organizationId=", url);
            }
            finally
            {
                Console.SetOut(oldConsoleOut);
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
                      where result.JsonPayload?.Fields["log_name"]?.StringValue?.Equals(typeof(Program).FullName) ?? false
                      select result;

            var logEntry = results.Single();

            Assert.Equal(LogSeverity.Info, logEntry.Severity);
            Assert.Contains(testId, logEntry.JsonPayload?.Fields["message"]?.StringValue);
        }
    }

    internal class Program
    { }
}
