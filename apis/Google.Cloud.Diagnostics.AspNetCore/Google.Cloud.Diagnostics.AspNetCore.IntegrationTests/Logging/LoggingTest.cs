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
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Logging.Type;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class LoggingTest
    {
        private readonly LogEntryPolling _polling = new LogEntryPolling();

        [Fact]
        public async Task Logging_SizedBufferNoLogs()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<SizedBufferErrorLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

                // No entries should be found as not enough entries were created to
                // flush the buffer.
                Assert.Empty(_polling.GetEntries(startTime, testId, 0, LogSeverity.Default));
            }
        }

        [Fact]
        public async Task Logging_DisposeFlush()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<SizedBufferErrorLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            // While we normally should not have entries we disposed of the server
            // which should flush the buffer.
            var results = _polling.GetEntries(startTime, testId, 2, LogSeverity.Error);
            Assert.Equal(2, results.Count());
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
            Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
        }

        [Fact]
        public async Task Logging_NoBuffer()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Debug/{testId}");
                await client.GetAsync($"/Main/Info/{testId}");
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

                // NoBufferLoggerTestApplication does not support debug or info logs.
                var results = _polling.GetEntries(startTime, testId, 3, LogSeverity.Warning);
                Assert.Equal(3, results.Count());
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            }
        }

        [Fact]
        public async Task Logging_SizedBuffer()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<SizedBufferErrorLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                for (int i = 0; i < 250; i++)
                {
                    await client.GetAsync($"/Main/Debug/{testId}");
                    await client.GetAsync($"/Main/Info/{testId}");
                    await client.GetAsync($"/Main/Warning/{testId}");
                    await client.GetAsync($"/Main/Error/{testId}");
                    await client.GetAsync($"/Main/Critical/{testId}");
                    await client.GetAsync($"/Main/Exception/{testId}");
                }

                // Just check that a large portion of logs entires were pushed.  Not all
                // will be pushed as some may be in the buffer.
                var results = _polling.GetEntries(startTime, testId, 500, LogSeverity.Default);
                Assert.True(results.Count() >= 500);
                Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Debug));
                Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Info));
                Assert.Null(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            }
        }


        [Fact]
        public async Task Logging_TimedBuffer()
        {
            // To ensure this test does not take too long and to not wait for the buffer to
            // flush itself we use custom polling to check for the initial check that no
            // entries exist.
            var quickPolling = new LogEntryPolling(TimeSpan.FromSeconds(10));
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<TimedBufferWarningLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");

                var noResults = quickPolling.GetEntries(startTime, testId, 0, LogSeverity.Warning);
                Assert.Empty(noResults);

                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
                Thread.Sleep(TimeSpan.FromSeconds(20));

                var results = _polling.GetEntries(startTime, testId, 4, LogSeverity.Warning);
                Assert.Equal(4, results.Count());
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.Equal(2, results.Count(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            }
        }

        [Fact]
        public async Task Logging_MonitoredResource()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferResourceLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

                var results = _polling.GetEntries(startTime, testId, 3, LogSeverity.Warning);
                Assert.Equal(3, results.Count());
                var resourceType = NoBufferResourceLoggerTestApplication.Resource.Type;
                var buildResources = results.Where(e => e.Resource.Type.Equals(resourceType));
                Assert.Equal(3, buildResources.Count());
            }
        }

        [Fact]
        public async Task Logging_Scope()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferResourceLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Scope/{testId}");
                var results = _polling.GetEntries(startTime, testId, 1, LogSeverity.Critical);
                var message = MainController.GetMessage(nameof(MainController.Scope), testId);
                Assert.Equal(message, results.Single().JsonPayload.Fields["message"].StringValue);
                Assert.Contains("Scope => ", results.Single().JsonPayload.Fields["scope"].StringValue);
            }
        }

        [Fact]
        public async Task Logging_FormatParameter()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferResourceLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/FormatParameters/{testId}");
                var results = _polling.GetEntries(startTime, testId, 1, LogSeverity.Critical);
                var message = MainController.GetMessage(nameof(MainController.FormatParameters), testId);
                var json = results.Single().JsonPayload.Fields;
                Assert.Equal(message, json["message"].StringValue);
                var formatParams = json["format_parameters"]?.StructValue?.Fields;
                Assert.NotNull(formatParams);
                Assert.Equal(3, formatParams.Count);
                Assert.Equal(nameof(MainController.FormatParameters), formatParams["message"].StringValue);
                Assert.Equal(testId, formatParams["id"].StringValue);
                Assert.Equal("{message} - {id}", formatParams["{OriginalFormat}"].StringValue);
            }
        }

        [Fact]
        public async Task Logging_Trace()
        {
            string traceId = "105445aa7843bc8bf206b12000100f00";
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader,
                    TraceHeaderContext.Create(traceId, 81237123, null).ToString());
                await client.GetAsync($"/Main/Critical/{testId}");
                var results = _polling.GetEntries(startTime, testId, 1, LogSeverity.Critical);
                Assert.Contains(TestEnvironment.GetTestProjectId(), results.Single().Trace);
                Assert.Contains(traceId, results.Single().Trace);
            }
        }

        [Fact]
        public async Task Logging_Labels()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<WarningWithLabelsLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                var results = _polling.GetEntries(startTime, testId, 1, LogSeverity.Warning);
                var entry = results.Single();
                Assert.Equal(3, entry.Labels.Count);
                Assert.Equal("some-value", entry.Labels["some-key"]);
                Assert.Equal("Hello, World!", entry.Labels["Foo"]);
                Assert.NotEmpty(entry.Labels["trace_identifier"]);
            }
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/> and associated classes.
    /// </summary>
    public abstract class LoggerTestApplication
    {
        protected string ProjectId;

        public LoggerTestApplication()
        {
            ProjectId = TestEnvironment.GetTestProjectId();
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = ProjectId;
            // Don't actually trace anything.
            options.Options = TraceOptions.Create(qpsSampleRate: 0.00000001);
            });
            services.AddMvc();
        }

        public void SetupRoutes(IApplicationBuilder app)
        {
            app.UseGoogleTrace()
                .UseMvc(routes =>
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
            LoggerOptions loggerOptions = LoggerOptions.Create(
                LogLevel.Warning, null, null, null, BufferOptions.NoBuffer());
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above and has a <see cref="MonitoredResource"/> of 'build'.
    /// </summary>
    public class NoBufferResourceLoggerTestApplication : LoggerTestApplication
    {
        public static readonly MonitoredResource Resource = new MonitoredResource
        {
            Type = "build",
            Labels =
            {
                { "project_id", "some-pid" },
                { "build_id", "some-build-id" }
            }
        };

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(
                LogLevel.Warning, null, null, Resource, BufferOptions.NoBuffer());
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, loggerOptions);
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
            LoggerOptions loggerOptions = LoggerOptions.Create(
                LogLevel.Error, null, null, null, BufferOptions.SizedBuffer());
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, loggerOptions);
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
            var options = BufferOptions.TimedBuffer(TimeSpan.FromSeconds(20));
            LoggerOptions loggerOptions = LoggerOptions.Create(
                LogLevel.Warning, null, null, null, options);
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> and a <see cref="ILogEntryLabelProvider"/>,
    /// that accept all logs of level warning or above.
    /// </summary>
    public class WarningWithLabelsLoggerTestApplication : LoggerTestApplication
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
            services.AddLogEntryLabelProvider<FooLogEntryLabelProvider>();
            services.AddLogEntryLabelProvider<TraceIdLogEntryLabelProvider>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };
            SetupRoutes(app);
            LoggerOptions loggerOptions = LoggerOptions.Create(
                LogLevel.Warning, null, labels, null, BufferOptions.NoBuffer());
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, loggerOptions);
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

        public string Scope(string id)
        {
            using (_logger.BeginScope(nameof(Scope)))
            {
                string message = GetMessage(nameof(Scope), id);
                _logger.LogCritical(message);
                return message;
            }
        }

        public string FormatParameters(string id)
        {
            string message = "{message} - {id}";
            _logger.LogCritical(message, nameof(FormatParameters), id);
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

        public static string GetMessage(string message, string id) => $"{message} - {id}";
    }

    internal class FooLogEntryLabelProvider : ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Foo"] = "Hello, World!";
        }
    }
}
