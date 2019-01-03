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
using Google.Cloud.Logging.Type;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    [SnippetOutputCollector]
    public class LoggingSnippetsTests
    {
        private static readonly LogEntryPolling s_polling = new LogEntryPolling();

        private readonly string _testId;
        private readonly DateTime _startTime;

        public LoggingSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTime.UtcNow;
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
        /// Test for RegisterGoogleLoggerPropagateExceptions and RegisterGoogleLoggerPropagateExceptions2 snippets.
        /// These snippets are configuration snippets so the best way to test them is by checking if 
        /// exceptions are propagated properly.
        /// </summary>
        [Fact]
        public async Task Logs_PropagateExceptions()
        {
            using (TestServer server = new TestServer(GetExceptionPropagatingHostBuilder()))
            using (HttpClient client = server.CreateClient())
            {
                await Assert.ThrowsAsync<AggregateException>(() => client.GetAsync($"/LoggingSamples/LogInformation/{_testId}"));
            }
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
#if NETCOREAPP2_0
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
#else
            return new WebHostBuilder().UseStartup<LoggingTestApplication>();
#endif
        }

        private IWebHostBuilder GetExceptionPropagatingHostBuilder()
        {
#if NETCOREAPP2_0
            string projectId = LoggingTestApplicationPropagateExceptions.ProjectId;
            // Sample: RegisterGoogleLoggerPropagateExceptions2
            return new WebHostBuilder()
                .ConfigureServices(services =>
                {
                    // Explicitly create logger options that will propagate any exceptions thrown
                    // during logging.
                    RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
                    // Also set the no buffer option so that writing the logs is attempted inmediately.
                    BufferOptions bufferOptions = BufferOptions.NoBuffer();
                    LoggerOptions loggerOptions = LoggerOptions.Create(bufferOptions: bufferOptions, retryOptions: retryOptions);

                    // Replace projectId with your Google Cloud Project ID.
                    services.AddSingleton<ILoggerProvider>(sp => GoogleLoggerProvider.Create(sp, projectId, options: loggerOptions));
                })
                .UseStartup<Startup>();
            // End sample
#else
            return new WebHostBuilder().UseStartup<LoggingTestApplicationPropagateExceptions>();
#endif
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
    /// A simple web application to test the <see cref="GoogleLogger"/>
    /// and associated classes.
    /// </summary>
    internal class LoggingTestApplicationPropagateExceptions
    {
        // Set this value to a dummy project ID so we can test that logging exceptions
        // are propagated.
        internal static readonly string ProjectId = "non-existent-project-id";

        // Sample: RegisterGoogleLoggerPropagateExceptions
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // Explicitly create logger options that will propagate any exceptions thrown
            // during logging.
            RetryOptions retryOptions = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            // Also set the no buffer option so that writing the logs is attempted inmediately.
            BufferOptions bufferOptions = BufferOptions.NoBuffer();
            LoggerOptions loggerOptions = LoggerOptions.Create(retryOptions: retryOptions, bufferOptions: bufferOptions);

            // Replace ProjectId with your Google Cloud Project ID.
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, options: loggerOptions);

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
