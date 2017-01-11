// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class LoggingTest
    {
        /// <summary>Total time to spend sleeping when looking for log entries.</summary>
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

        /// <summary>Time to sleep between checks for log entries.</summary>
        private readonly TimeSpan _sleepInterval = TimeSpan.FromSeconds(2);

        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId;

        /// <summary>Client to use to send RPCs.</summary>
        private readonly LoggingServiceV2Client _client;

        public LoggingTest()
        {
            _projectId = Utils.GetProjectIdFromEnvironment();
            _client = LoggingServiceV2Client.Create();
        }

        /// <summary>
        /// Gets log entries that contain the passed in testId in the log message.  Will poll
        /// and wait for the entries to appear.
        /// </summary>
        /// <param name="startTime">The earliest log entry time that will be looked at.</param>
        /// <param name="testId">The test id to filter log entries on.</param>
        /// <param name="minEntries">The minimum number of logs entries that should be waited for.
        ///     If minEntries is zero this method will wait the full timeout before checking for the
        ///     entries.</param>
        private IEnumerable<LogEntry> GetEntries(DateTime startTime, string testId, int minEntries)
        {
            TimeSpan totalSleepTime = TimeSpan.Zero;
            while (totalSleepTime < _timeout)
            {
                TimeSpan sleepTime = minEntries > 0 ? _sleepInterval : _timeout;
                totalSleepTime += sleepTime;
                Thread.Sleep(sleepTime);

                // Convert the time to RFC3339 UTC format.
                string time = XmlConvert.ToString(startTime, XmlDateTimeSerializationMode.Utc);
                var request =  new ListLogEntriesRequest
                {
                    ResourceNames = { $"projects/{_projectId}" },
                    Filter = $"timestamp >= \"{time}\""
                };

                var results = _client.ListLogEntries(request);
                var entries = results.Where(p => p.TextPayload.Contains(testId)).ToList();
                if (minEntries == 0 || entries.Count() >= minEntries)
                {
                    return entries;
                }
            }
            return new List<LogEntry>();
        }

        [Fact]
        public async Task Logging_SizedBufferNoLogs()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<SizedBufferErrorLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            // No entries should be found as not enough entries were created to
            // flush the buffer.
            Assert.Empty(GetEntries(startTime, testId, 0));
        }

        [Fact]
        public async Task Logging_NoBuffer()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await client.GetAsync($"/Main/Debug/{testId}");
                await client.GetAsync($"/Main/Info/{testId}");
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            // NoBufferLoggerTestApplication does not support debug or info logs.
            var results = GetEntries(startTime, testId, 3);
            Assert.Equal(3, results.Count());
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
        }

        [Fact]
        public async Task Logging_SizedBuffer()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<SizedBufferErrorLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                for (int i = 0; i < 250; i++)
                {
                    await client.GetAsync($"/Main/Debug/{testId}");
                    await client.GetAsync($"/Main/Info/{testId}");
                    await client.GetAsync($"/Main/Warning/{testId}");
                    await client.GetAsync($"/Main/Error/{testId}");
                    await client.GetAsync($"/Main/Critical/{testId}");
                    await client.GetAsync($"/Main/Exception/{testId}");
                }
            }

            // Just check that a large portion of logs entires were pushed.  Not all
            // will be pushed as some may be in the buffer.
            var results = GetEntries(startTime, testId, 500);
            Assert.True(results.Count() >= 500);
            Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Debug));
            Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Info));
            Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
        }


        [Fact]
        public async Task Logging_TimedBuffer()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<TimedBufferWarningLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();

                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");

                var noResults = GetEntries(startTime, testId, 0);
                Assert.Empty(noResults);
                Thread.Sleep(TimeSpan.FromSeconds(10));

                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            // The fourth entry is not pushed as it is buffered after the last push.
            var results = GetEntries(startTime, testId, 3);
            Assert.Equal(3, results.Count());
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
            Assert.Equal(2, results.Count(l => l.Severity == LogSeverity.Error));
            Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
        }

        [Fact]
        public async Task Logging_MonitoredResource()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferResourceLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            var results = GetEntries(startTime, testId, 3);
            Assert.Equal(3, results.Count());
            var resourceType = NoBufferResourceLoggerTestApplication.s_resource.Type;
            var buildResources = results.Where(e => e.Resource.Type.Equals(resourceType));
            Assert.Equal(3, buildResources.Count());
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/> and associated classes.
    /// </summary>
    public class LoggerTestApplication
    {
        protected string ProjectId;

        public LoggerTestApplication()
        {
            ProjectId = Utils.GetProjectIdFromEnvironment();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void SetupRoutes(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Main}/{action=Index}/{id}");
            });
        }
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above.
    /// </summary>
    public class NoBufferWarningLoggerTestApplication : LoggerTestApplication
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(LogLevel.Warning, null, BufferOptions.NoBuffer());
            loggerFactory.AddGoogle(ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above and has a <see cref="MonitoredResource"/> of 'build'.
    /// </summary>
    public class NoBufferResourceLoggerTestApplication : LoggerTestApplication
    {
        public static readonly MonitoredResource s_resource = new MonitoredResource
        {
            Type = "build",
            Labels =
            {
                { "project_id", "" },
                { "build_id", "" }
            }
        };

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(
                LogLevel.Warning, s_resource, BufferOptions.NoBuffer());
            loggerFactory.AddGoogle(ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with a <see cref="BufferType.Sized"/>
    /// buffer that will accept all logs of level error or above.
    /// </summary>
    public class SizedBufferErrorLoggerTestApplication : LoggerTestApplication
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(LogLevel.Error);
            loggerFactory.AddGoogle(ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with a <see cref="BufferType.Timed"/>
    /// buffer, that will be able to flush after one minute that will accept all logs of level
    /// warning or above.
    /// </summary>
    public class TimedBufferWarningLoggerTestApplication : LoggerTestApplication
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            var options = BufferOptions.TimedBuffer(TimeSpan.FromSeconds(5));
            LoggerOptions loggerOptions = LoggerOptions.Create(LogLevel.Warning, null, options);
            loggerFactory.AddGoogle(ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// A controller for the <see cref="LoggerTestApplication"/> used to generate simple log entries.
    /// </summary>
    public class MainController : Controller
    {
        private readonly ILogger _logger;        

        public MainController(ILoggerFactory loggerFactory)
        {            
            _logger = loggerFactory.CreateLogger(nameof(_logger));
        }

        public string Index(string id) => GetMessage(nameof(Index), id);

        public string Debug(string id)
        {
            string message = GetMessage(nameof(Debug), id);
            _logger.LogDebug(message);
            return message;
        }

        public string Info(string id)
        {
            string message = GetMessage(nameof(Info), id);
            _logger.LogInformation(message);
            return message;
        }

        public string Warning(string id)
        {
            string message = GetMessage(nameof(Warning), id);
            _logger.LogWarning(message);
            return message;
        }

        public string Error(string id)
        {
            string message = GetMessage(nameof(Error), id);
            _logger.LogError(message);
            return message;
        }

        public string Critical(string id)
        {
            string message = GetMessage(nameof(Critical), id);
            _logger.LogCritical(message);
            return message;
        }

        public string Exception(string id)
        {
            string message = GetMessage(nameof(Exception), id);
            try
            {
                throw new Exception("Exception to throw.");
            }
            catch (Exception e)
            {
                _logger.LogCritical(message, e);
            } 
            return message;
        }

        private string GetMessage(string message, string id) => $"{message} - {id}";
    }
}
