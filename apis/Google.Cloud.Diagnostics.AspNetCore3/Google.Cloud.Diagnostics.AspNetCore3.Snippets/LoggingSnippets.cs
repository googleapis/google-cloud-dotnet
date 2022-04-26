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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Snippets
{
    using static IntegrationTests.TestServerHelpers;

    [SnippetOutputCollector]
    public class LoggingSnippetsTests
    {
        private readonly string _testId;
        private readonly DateTime _startTime;

        public LoggingSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();
            _startTime = DateTime.UtcNow;
        }

        [Fact]
        public async Task LogsAsync()
        {
            TestServer server = GetTestServer(GetHostBuilder());

            using (HttpClient client = server.CreateClient())
            {
                await client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");
            }
            server.Dispose();

            PollAndVerifyLog(LogEntryPolling.Default, _startTime, _testId);
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

        private static IHostBuilder GetHostBuilder()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: ConfigureAspNetCore3
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    // Replace projectId with your Google Cloud Project ID.
                    .ConfigureLogging(builder => builder.AddGoogle(new LoggingServiceOptions { ProjectId = projectId }))
                    .UseStartup<Startup>());
            // End sample
            return hostBuilder.ConfigureWebHost(webBuilder => webBuilder.UseTestServer());
        }
    }

    // Sample: Logging
    public class LoggingSamplesController : Controller
    {
        private ILogger _logger;

        public LoggingSamplesController(ILogger<LoggingSamplesController> logger) =>
            _logger = logger;

        /// <summary>
        /// This method logs an Information level message.
        /// </summary>
        public void LogInformation(string id)
        {
            // Log whatever message you want to log.
            _logger.LogInformation($"Id received: {id}");
        }
    }
    // End sample
}
