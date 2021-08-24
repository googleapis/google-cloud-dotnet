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
using System.Collections.Generic;
#if NETCOREAPP3_1
using Microsoft.Extensions.Hosting;
#elif NETCOREAPP2_1 || NET461
#else
#error unknown target framework
#endif

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
    public class LoggingSnippetsTests
    {
        private const string ExpectedGcpLogBaseUrl = "https://console.cloud.google.com/logs/viewer";

        private readonly string _testId;
        private readonly DateTime _startTime;

        public LoggingSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTime.UtcNow;
        }

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
                using (TestServer server = GetTestServer(GetUrlWriterHostBuilder())) { }

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

        public static IEnumerable<object[]> BasicTestServers
        {
            get
            {
                yield return new object[] { GetTestServer(GetSimpleHostBuilder()) };
                yield return new object[] { GetTestServer<LoggingTestApplication.Startup>() };
                yield return new object[] { GetTestServer(GetSimpleHostBuilder2()) };
            }
        }

        /// <summary>
        /// Test for RegisterGoogleLogger, RegisterGoogleLogger2, RegisterGoogleLogger3 and UseGoogleLogger snippets.
        /// The RegisterGoogleLogger, RegisterGoogleLogger2, RegisterGoogleLogger3 snippets are configuration snippets
        /// so the best way to test it is by checking if logging works properly.
        /// </summary>
        [Theory]
        [MemberData(nameof(BasicTestServers))]
        public async Task Logs_Information(TestServer server)
        {
            using (HttpClient client = server.CreateClient())
            {
                await client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");
            }
            server.Dispose();

            PollAndVerifyLog(LogEntryPolling.Default, _startTime, _testId);
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
                using TestServer server = GetTestServer(GetExceptionPropagatingHostBuilder());
                using HttpClient client = server.CreateClient();
                await client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");
            });

            var rpcException = (RpcException) aggregateEx.InnerException;
            Assert.Equal(StatusCode.NotFound, rpcException.StatusCode);
        }

        internal static void PollAndVerifyLog(LogEntryPolling poller, DateTimeOffset startTime, string testId)
        {
            var results = poller.GetEntries(startTime, testId, 1, LogSeverity.Info);
            results = from result in results
                      where result.JsonPayload?.Fields["log_name"]?.StringValue?.Equals(typeof(LoggingSamplesController).FullName) ?? false
                      select result;

            var logEntry = results.Single();

            Assert.Equal(LogSeverity.Info, logEntry.Severity);
            Assert.Contains(testId, logEntry.JsonPayload?.Fields["message"]?.StringValue);
        }

#if NETCOREAPP3_1
        private static IHostBuilder GetSimpleHostBuilder()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: RegisterGoogleLogger2_Core3
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    // Replace projectId with your Google Cloud Project ID.
                    .ConfigureServices(services => services.AddSingleton<ILoggerProvider>(sp => GoogleLoggerProvider.Create(sp, projectId)))
                    .UseStartup<Startup>());
            // End sample
            return hostBuilder.ConfigureWebHost(webBuilder => webBuilder.UseTestServer());
        }

        private static IHostBuilder GetSimpleHostBuilder2()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: RegisterGoogleLogger3_Core3
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    // Replace projectId with your Google Cloud Project ID.
                    .ConfigureLogging(builder => builder.AddProvider(GoogleLoggerProvider.Create(serviceProvider: null, projectId)))
                    .UseStartup<Startup>());
            // End sample
            return hostBuilder.ConfigureWebHost(webBuilder => webBuilder.UseTestServer());
        }

        private static IHostBuilder GetExceptionPropagatingHostBuilder()
        {
            string projectId = "non-existent-project-id";

            // Sample: RegisterGoogleLoggerPropagateExceptions_Core3
            // Explicitly create logger options that will propagate any exceptions thrown
            // during logging.
            RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            // Also set the no buffer option so that writing the logs is attempted immediately.
            BufferOptions bufferOptions = BufferOptions.NoBuffer();
            LoggerOptions loggerOptions = LoggerOptions.Create(bufferOptions: bufferOptions, retryOptions: retryOptions);
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    // Replace projectId with your Google Cloud Project ID.
                    .UseGoogleDiagnostics(projectId, loggerOptions: loggerOptions)
                    .UseStartup<Startup>());
            // End sample
            return hostBuilder.ConfigureWebHost(webBuilder => webBuilder.UseTestServer());
        }

        private static IHostBuilder GetUrlWriterHostBuilder()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: RegisterGoogleLoggerWriteUrl_Core3
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    // Replace projectId with your Google Cloud Project ID.
                    .UseGoogleDiagnostics(projectId, loggerOptions: LoggerOptions.Create(loggerDiagnosticsOutput: Console.Out))
                    .UseStartup<Startup>());
            // End sample
            return hostBuilder.ConfigureWebHost(webBuilder => webBuilder.UseTestServer());
        }
#elif NETCOREAPP2_1 || NET461
        private static IWebHostBuilder GetSimpleHostBuilder()
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

        private static IWebHostBuilder GetSimpleHostBuilder2()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: RegisterGoogleLogger3
            return new WebHostBuilder()
                .ConfigureLogging(builder => builder.AddProvider(GoogleLoggerProvider.Create(serviceProvider: null, projectId)))
                .UseStartup<Startup>();
            // End sample
        }

        private static IWebHostBuilder GetExceptionPropagatingHostBuilder()
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

        private static IWebHostBuilder GetUrlWriterHostBuilder()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: RegisterGoogleLoggerWriteUrl
            return new WebHostBuilder()
                .UseGoogleDiagnostics(projectId, loggerOptions: LoggerOptions.Create(loggerDiagnosticsOutput: Console.Out))
                .UseStartup<Startup>();
            // End sample
        }
#else
#error unknown target framework
#endif
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/>
    /// and associated classes.
    /// </summary>
    internal class LoggingTestApplication
    {
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        // To hide some implementation details from the
        // sample code, like how we are overriding the methods.
        internal class Startup : BaseStartup
        {
            private readonly LoggingTestApplication application = new LoggingTestApplication();

            public override void ConfigureServices(IServiceCollection services)
            {
                application.ConfigureServices(services);
                base.ConfigureServices(services);
            }

            public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
            {
                application.Configure(app, loggerFactory);
                base.Configure(app, loggerFactory);
            }
        }

        // Sample: RegisterGoogleLogger
        public void ConfigureServices(IServiceCollection services)
        {
            // No specific services are needed to use Google Logging.

            // Add any services your application requires, for instance,
            // depending on the version of ASP.NET Core you are using, you may
            // need one of the following:

            // services.AddMvc();

            // services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // Replace ProjectId with your Google Cloud Project ID.
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId);

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
