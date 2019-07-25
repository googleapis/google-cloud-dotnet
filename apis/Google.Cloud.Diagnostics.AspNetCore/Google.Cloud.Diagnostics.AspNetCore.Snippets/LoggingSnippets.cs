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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Logging.Type;
using Grpc.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    [SnippetOutputCollector]
    public class LoggingSnippetsTests
    {
        private const string ExpectedGcpLogBaseUrl = "https://console.cloud.google.com/logs/viewer";
        private static readonly LogEntryPolling s_polling = new LogEntryPolling();

        private readonly string _testId;
        private readonly DateTime _startTime;

        public LoggingSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTime.UtcNow;
        }

        /// <summary>
        /// Test for the GcpStackdriverLoggingConsoleUrl snippet.
        /// </summary>
        [Fact]
        public void GetsLogViewingUrl()
        {
            TextWriter oldConsoleOut = Console.Out;
            string writtenInfo;
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);

                // No need to make an actual call to the controller. Just starting up the server
                // creates several loggers.
                using (TestServer server = new TestServer(GetUrlWriterHostBuilder())) { }

                writtenInfo = writer.ToString();

                Console.SetOut(oldConsoleOut);
            }

            int urlStart = writtenInfo.LastIndexOf("http", StringComparison.OrdinalIgnoreCase);
            Assert.NotEqual(urlStart, -1);

            // We know the URL is the last to be written.
            string url = writtenInfo.Substring(urlStart);
            string expectedProject = TestEnvironment.GetTestProjectId();

            Assert.StartsWith(ExpectedGcpLogBaseUrl, url);
            Assert.Contains($"resource={MonitoredResourceBuilder.FromPlatform().Type}", url);
            Assert.Contains($"project={expectedProject}", url);
            Assert.Contains("minLogLevel=200", url);
            Assert.Contains($"logName=projects/{expectedProject}/logs/aspnetcore", url);
            Assert.DoesNotContain("organizationId=", url);
        }

        /// <summary>
        /// Test for RegisterGoogleLogger, RegisterGoogleLogger2 and UseGoogleLogger snippets.
        /// The RegisterGoogleLogger and RegisterGoogleLogger2 snippets are configuration snippets
        /// so the best way to test it is by checking if logging works properly.
        /// </summary>
        [Fact]
        public async Task Logs_Information()
        {
            using (TestServer server = new TestServer(GetSimpleHostBuilder()))
            using (HttpClient client = server.CreateClient())
            {
                await client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");
            }

            PollAndVerifyLog(_startTime, _testId);
        }

        /// <summary>
        /// Test for RegisterGoogleLogger3 snippet.
        /// </summary>
        [Fact]
        public async Task Logs_Information2()
        {
            using (TestServer server = new TestServer(GetSimpleHostBuilder2()))
            using (HttpClient client = server.CreateClient())
            {
                await client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");
            }

            PollAndVerifyLog(_startTime, _testId);
        }

        /// <summary>
        /// Test for RegisterGoogleLoggerPropagateExceptions snippet.
        /// This snippet is a configuration snippet so the best way to test is by checking if 
        /// exceptions are propagated properly.
        /// </summary>
        [Fact]
        public async Task Logs_PropagateExceptions()
        {
            var aggregateEx = await Assert.ThrowsAsync<AggregateException>(async () =>
            {
                using (TestServer server = new TestServer(GetExceptionPropagatingHostBuilder()))
                using (HttpClient client = server.CreateClient())
                {
                    await client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");
                }
            });

            var rpcException = (RpcException) aggregateEx.InnerException;
            Assert.Equal(StatusCode.NotFound, rpcException.StatusCode);
        }

        internal static void PollAndVerifyLog(DateTime startTime, string testId)
        {
            var results = s_polling.GetEntries(startTime, testId, 1, LogSeverity.Info);
            results = from result in results
                      where result.JsonPayload?.Fields["log_name"]?.StringValue?.Equals(typeof(LoggingSamplesController).FullName) ?? false
                      select result;

            var logEntry = results.Single();

            Assert.Equal(LogSeverity.Info, logEntry.Severity);
            Assert.Contains(testId, logEntry.JsonPayload?.Fields["message"]?.StringValue);
        }

        private IWebHostBuilder GetSimpleHostBuilder()
        {
            string projectId = TestEnvironment.GetTestProjectId();
            // Sample: RegisterGoogleLogger2
            return new WebHostBuilder()
                .ConfigureServices(services =>
                {
                    // Replace projectId with your Google Cloud Project ID.
                    services.AddSingleton<ILoggerProvider>(sp => GoogleLoggerProvider.Create(sp, projectId));
                })
                .UseStartup<Startup>();
            // End sample
        }

        private IWebHostBuilder GetSimpleHostBuilder2()
        {
            string projectId = TestEnvironment.GetTestProjectId();
            // Sample: RegisterGoogleLogger3
            return new WebHostBuilder()
                .ConfigureLogging(builder => builder.AddProvider(GoogleLoggerProvider.Create(serviceProvider: null, projectId)))
                .UseStartup<Startup>();
            // End sample
        }

        private IWebHostBuilder GetExceptionPropagatingHostBuilder()
        {
            string projectId = "non-existent-project-id";
            // Sample: RegisterGoogleLoggerPropagateExceptions
            // Explicitly create logger options that will propagate any exceptions thrown
            // during logging.
            RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            // Also set the no buffer option so that writing the logs is attempted immediately.
            BufferOptions bufferOptions = BufferOptions.NoBuffer();
            LoggerOptions loggerOptions = LoggerOptions.Create(bufferOptions: bufferOptions, retryOptions: retryOptions);
            return new WebHostBuilder()
                .UseGoogleDiagnostics(projectId, loggerOptions: loggerOptions)
                .UseStartup<Startup>();
            // End sample
        }

        private IWebHostBuilder GetUrlWriterHostBuilder()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: RegisterGoogleLoggerWriteUrl
            return new WebHostBuilder()
                .UseGoogleDiagnostics(projectId, loggerOptions: LoggerOptions.Create(loggerDiagnosticsOutput: Console.Out))
                .UseStartup<Startup>();
            // End sample
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/>
    /// and associated classes.
    /// </summary>
    internal class LoggingTestApplication
    {
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        // Sample: RegisterGoogleLogger
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // Replace ProjectId with your Google Cloud Project ID.
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId);

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
    /// A controller for the <see cref="LoggingTestApplication"/> used to log information.
    /// </summary>
    // Sample: UseGoogleLogger
    public class LoggingSamplesController : Controller
    {
        /// <summary>
        /// This method logs an Information level message.
        /// The <see cref="ILogger"/> is populated by dependency injection
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public void LogInformation(string id, [FromServices]ILogger<LoggingSamplesController> logger)
        {
            // Log whatever message you want to log.
            logger.LogInformation(id);
        }
    }
    // End sample
}
