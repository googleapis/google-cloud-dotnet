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
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class LoggingTest : IClassFixture<LogValidatingFixture>
    {
        private readonly LogValidatingFixture _fixture;

        public LoggingTest(LogValidatingFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Logging_WarningPlus()
        {
            string testId = IdGenerator.FromGuid();

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Debug/{testId}");
                await client.GetAsync($"/Main/Info/{testId}");
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            // NoBufferLoggerTestApplication does not support debug or info logs.
            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(3, results.Count());
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            });
        }

        [Fact]
        public async Task Logging_ManyEntries()
        {
            string testId = IdGenerator.FromGuid();

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
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
            }
            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(1000, results.Count);
                Assert.DoesNotContain(results, l => l.Severity == LogSeverity.Debug);
                Assert.DoesNotContain(results, l => l.Severity == LogSeverity.Info);
                Assert.Equal(250, results.Count(l => l.Severity == LogSeverity.Warning));
                Assert.Equal(250, results.Count(l => l.Severity == LogSeverity.Error));
                Assert.Equal(500, results.Count(l => l.Severity == LogSeverity.Critical)); // Exception and Critical
            });
        }

        [Fact]
        public async Task Logging_MonitoredResource()
        {
            string testId = IdGenerator.FromDateTime();

            var builder = new WebHostBuilder().UseStartup<NoBufferResourceLoggerTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

            }

            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(3, results.Count());
                var resourceType = NoBufferResourceLoggerTestApplication.Resource.Type;
                var buildResources = results.Where(e => e.Resource.Type.Equals(resourceType));
                Assert.Equal(3, buildResources.Count());
            });
        }

        [Fact]
        public async Task Logging_Scope()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Scope/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.Scope), testId);
                Assert.Equal(message, results.Single().JsonPayload.Fields["message"].StringValue);
                Assert.Contains("Scope => ", results.Single().JsonPayload.Fields["scope"].StringValue);
            });
        }

        [Fact]
        public async Task Logging_FormatParameter()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/FormatParameters/{testId}");
            }
            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.FormatParameters), testId);
                var json = results.Single().JsonPayload.Fields;
                Assert.Equal(message, json["message"].StringValue);
                var formatParams = json["format_parameters"]?.StructValue?.Fields;
                Assert.NotNull(formatParams);
                Assert.Equal(3, formatParams.Count);
                Assert.Equal(nameof(MainController.FormatParameters), formatParams["message"].StringValue);
                Assert.Equal(testId, formatParams["id"].StringValue);
                Assert.Equal("{message} - {id}", formatParams["{OriginalFormat}"].StringValue);
            });
        }

        [Fact]
        public async Task Logging_ScopeFormatParameter()
        {
            string testId = IdGenerator.FromGuid();

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/ScopeFormatParameters/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.ScopeFormatParameters), testId);
                var json = results.Single().JsonPayload.Fields;
                Assert.Equal(message, json["message"].StringValue);

                var parentScopes = json["parent_scopes"]?.ListValue?.Values;
                Assert.NotNull(parentScopes);
                var expectedScope = Value.ForStruct(new Struct
                {
                    Fields =
                    {
                        { "id", Value.ForString(testId) },
                        { "{OriginalFormat}", Value.ForString(nameof(MainController.ScopeFormatParameters) + " - {id}") }
                    }
                });
                Assert.Single(parentScopes, expectedScope);
            });
        }

        [Fact]
        public async Task Logging_Trace()
        {
            string traceId = "105445aa7843bc8bf206b12000100f00";
            string testId = IdGenerator.FromGuid();

            var builder = new WebHostBuilder().UseStartup<NoBufferWarningLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader,
                    TraceHeaderContext.Create(traceId, 81237123, null).ToString());
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                Assert.Contains(TestEnvironment.GetTestProjectId(), results.Single().Trace);
                Assert.Contains(traceId, results.Single().Trace);
            });
        }

        [Fact]
        public async Task Logging_Labels()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<WarningWithLabelsLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var entry = results.Single();
                Assert.Equal(3, entry.Labels.Count);
                Assert.Equal("some-value", entry.Labels["some-key"]);
                Assert.Equal("Hello, World!", entry.Labels["Foo"]);
                Assert.NotEmpty(entry.Labels["trace_identifier"]);
            });
        }

        [Fact]
        public async Task Logging_DiagnosticsOutput()
        {
            var writer = new StringWriter();
            // This is an odd way to pass in a value, but it works...
            var builder = new WebHostBuilder()
                .ConfigureServices(service => service.AddSingleton<TextWriter>(writer))
                .UseStartup<DiagnosticsOutputLoggerTestApplication>();
            using (var server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{IdGenerator.FromGuid()}");
                await client.GetAsync($"/Main/Warning/{IdGenerator.FromGuid()}");
                await client.GetAsync($"/Main/Warning/{IdGenerator.FromGuid()}");
            }

            // Despite multiple log entries (several per call), we should only have one diagnostic log.
            var diagnostics = writer.ToString();
            var lines = diagnostics.Split('\n');
            Assert.Equal(2, lines.Length);
            Assert.Contains("GoogleLogger will write logs", lines[0]);
            Assert.Empty(lines[1]);
        }

        [Fact]
        public async Task Logging_NoServiceProvider()
        {
            string testId = IdGenerator.FromDateTime();

            var builder = new WebHostBuilder()
                .ConfigureLogging(loggingBuilder =>
                {
                    var projectId = TestEnvironment.GetTestProjectId();
                    var provider = GoogleLoggerProvider.Create(serviceProvider: null, projectId, LoggerOptions.Create(LogLevel.Warning));
                    loggingBuilder.AddProvider(provider);                    
                })
                .UseStartup<VanillaApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

            }
            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(3, results.Count());
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            });
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
            services.AddHttpContextAccessor();
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

    public class DiagnosticsOutputLoggerTestApplication : LoggerTestApplication
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            SetupRoutes(app);
            var writer = app.ApplicationServices.GetRequiredService<TextWriter>();
            LoggerOptions loggerOptions = LoggerOptions.Create(loggerDiagnosticsOutput: writer);
            loggerFactory.AddGoogle(app.ApplicationServices, ProjectId, loggerOptions);
        }
    }

    /// <summary>
    /// Application that doesn't perform any diagnostic configuration itself.
    /// </summary>
    public class VanillaApplication
    {
        public virtual void ConfigureServices(IServiceCollection services) =>
            services.AddMvc();

        public void Configure(IApplicationBuilder app) =>
            app.UseMvc(routes => routes.MapRoute(name: "default", template: "{controller=Main}/{action=Index}/{id}"));
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

        public string Debug(string id)
        {
            string message = EntryData.GetMessage(nameof(Debug), id);
            _logger.LogDebug(message);
            return message;
        }

        public string Info(string id)
        {
            string message = EntryData.GetMessage(nameof(Info), id);
            _logger.LogInformation(message);
            return message;
        }

        public string Warning(string id)
        {
            string message = EntryData.GetMessage(nameof(Warning), id);
            _logger.LogWarning(message);
            return message;
        }

        public string Error(string id)
        {
            string message = EntryData.GetMessage(nameof(Error), id);
            _logger.LogError(message);
            return message;
        }

        public string Critical(string id)
        {
            string message = EntryData.GetMessage(nameof(Critical), id);
            _logger.LogCritical(message);
            return message;
        }

        public string Scope(string id)
        {
            using (_logger.BeginScope(nameof(Scope)))
            {
                string message = EntryData.GetMessage(nameof(Scope), id);
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

        public string ScopeFormatParameters(string id)
        {
            using (_logger.BeginScope(nameof(ScopeFormatParameters) + " - {id}", id))
            {
                string message = EntryData.GetMessage(nameof(ScopeFormatParameters), id);
                _logger.LogCritical(message);
                return message;
            }
        }

        public string Exception(string id)
        {
            string message = EntryData.GetMessage(nameof(Exception), id);
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
    }

    internal class FooLogEntryLabelProvider : ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Foo"] = "Hello, World!";
        }
    }
}
