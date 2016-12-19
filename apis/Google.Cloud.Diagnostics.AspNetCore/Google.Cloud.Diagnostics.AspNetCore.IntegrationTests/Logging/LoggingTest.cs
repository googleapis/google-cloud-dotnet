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

using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.Logging.V2;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Google.Cloud.Diagnostics.Common;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using Google.Protobuf.WellKnownTypes;
using System.Xml;
using System.Threading;
using System.Linq;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class LoggingTest
    {
        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId;


        /// <summary>Client to use to send RPCs.</summary>
        private readonly LoggingServiceV2Client _client;

        public LoggingTest()
        {
            _projectId = Utils.GetProjectIdFromEnvironment();
            _client = LoggingServiceV2Client.Create();
        }

        private TestServer GetServer()
        {
            return new TestServer(new WebHostBuilder().
                UseStartup<LoggerTestApplication>());
        }

        private ListLogEntriesRequest GetRequest(DateTime dateTime)
        {
            
            string time = XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc);

            return new ListLogEntriesRequest {
                ResourceNames = { $"projects/{_projectId}" },
                Filter = $"timestamp >= \"{time}\""
            };
        }

        private IEnumerable<LogEntry> GetEntries(DateTime datetime, int minEntries)
        {
            var results = _client.ListLogEntries(GetRequest(startTime));
            var entries = results.Where(p => p.TextPayload.Contains(testId));
        }

        [Fact]
        public async Task Test()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<SmallSizedBufferLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();

                await client.GetAsync($"/Main/Debug/{testId}");
                await client.GetAsync($"/Main/Info/{testId}");
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            Thread.Sleep(10000);
            var results = _client.ListLogEntries(GetRequest(startTime));
            var entries = results.Where(p => p.TextPayload.Contains(testId));
            foreach (var entry in entries)
            {
                var temp = entry;
            }

        }
    }

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

    public class SmallSizedBufferLoggerTestApplication : LoggerTestApplication
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(LogLevel.Warning, BufferOptions.SizedBuffer(1));
            loggerFactory.AddGoogle(ProjectId, loggerOptions);
        }
    }

    public class SizedBufferLoggerTestApplication : LoggerTestApplication
    {
        public void ConfigureLogging(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(LogLevel.Error);
            loggerFactory.AddGoogle(ProjectId, loggerOptions);
        }
    }

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

        private string GetMessage(string message, string id) => $"{message} - {id}";
    }


}
