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
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Diagnostics.Common.Tests;
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
    public class LoggingSnippetsTests : IDisposable
    {
        private static readonly string ProjectId = Utils.GetProjectIdFromEnvironment();
        private static readonly LogEntryPolling s_polling = new LogEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly DateTime _startTime;

        public LoggingSnippetsTests()
        {
            _testId = Utils.GetTestId();
            IWebHostBuilder builder;
#if NETCOREAPP2_0
            // Sample: RegisterGoogleLogger2
            builder = new WebHostBuilder()
                .ConfigureServices(services =>
                {
                    // Replace ProjectId with your Google Cloud Project ID.
                    services.AddSingleton<ILoggerProvider>(sp => GoogleLoggerProvider.Create(sp, ProjectId));
                })
                .UseStartup<Startup>();
            // End sample
#else
            builder = new WebHostBuilder().UseStartup<LoggingTestApplication>();
#endif
            _server = new TestServer(builder);
            _client = _server.CreateClient();

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
            await _client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");

            PollAndVerifyLog(_startTime, _testId);
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

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/>
    /// and associated classes.
    /// </summary>
    internal class LoggingTestApplication
    {
        private static readonly string ProjectId = Utils.GetProjectIdFromEnvironment();

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
