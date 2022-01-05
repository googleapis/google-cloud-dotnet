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

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Logging.Type;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
#else
#error unknown target framework
#endif
{
    using static TestServerHelpers;

    public class DiagnosticsTests
    {
        public DiagnosticsTests()
        {
            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();
        }

        [SkippableFact]
        public async Task UseGoogleDiagnostics_ConfiguresServices_Default()
        {
            Skip.If((await Platform.InstanceAsync()).Type == PlatformType.Unknown,
                "Default configuration can only be used when running on GCP.");

            var testId = IdGenerator.FromDateTime();
            var startTime = DateTime.UtcNow;

            var hostBuilder = GetHostBuilder(webHostBuilder =>
                webHostBuilder.ConfigureServices(services =>
                    services.AddGoogleDiagnosticsForAspNetCore()));

            using var server = GetTestServer(hostBuilder);
            using var client = server.CreateClient();
            await TestTrace(testId, startTime, client);
            await TestLogging(testId, startTime, client);
            await TestErrorReporting(testId, client, verifyServiceAndVersion: false);
        }

        [Fact]
        public void UseGoogleDiagnostics_ConfiguresServices()
        {
            var hostBuilder = GetHostBuilder(webHostBuilder => webHostBuilder.ConfigureServices(
                services => services.AddGoogleDiagnosticsForAspNetCore("tmp", "app", "1.0.0")));

            using var server = GetTestServer(hostBuilder);
            var services = GetServices(server);

            // Test tracing
            Assert.NotNull(services.GetService<IHttpContextAccessor>());
            Assert.NotNull(services.GetService<IManagedTracer>());

            // Test exception logging
            Assert.NotNull(services.GetService<IExceptionLogger>());
            Assert.NotNull(services.GetService<IContextExceptionLogger>());
        }

        [Fact]
        public async Task UseGoogleDiagnostics_ConfiguresComponents()
        {
            var testId = IdGenerator.FromDateTime();
            var startTime = DateTime.UtcNow;

            var hostBuilder = GetHostBuilder(webHostBuilder =>
                webHostBuilder.ConfigureServices(services =>
                    services.AddGoogleDiagnosticsForAspNetCore(
                        TestEnvironment.GetTestProjectId(), EntryData.Service, EntryData.Version)));

            using var server = GetTestServer(hostBuilder);
            using var client = server.CreateClient();
            await TestTrace(testId, startTime, client);
            await TestLogging(testId, startTime, client);
            await TestErrorReporting(testId, client);
        }

        [Fact]
        public async Task UseGoogleDiagnostics_ValidateDependencyInjection()
        {
            var testId = IdGenerator.FromDateTime();
            var startTime = DateTime.UtcNow;

            var hostBuilder = GetHostBuilder(webHostBuilder =>
                webHostBuilder
                    .UseDefaultServiceProvider(options => options.ValidateScopes = true)
                    .ConfigureServices(services =>
                        services.AddGoogleDiagnosticsForAspNetCore(
                            TestEnvironment.GetTestProjectId(), EntryData.Service, EntryData.Version,
                            traceOptions: TraceOptions.Create(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate)),
                            loggingOptions: LoggingOptions.Create(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate)),
                            errorReportingOptions: ErrorReportingOptions.CreateInstance(retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate)))));

            using var server = GetTestServer(hostBuilder);
            using var client = server.CreateClient();
            await TestTrace(testId, startTime, client);
            await TestLogging(testId, startTime, client);
            await TestErrorReporting(testId, client);
        }

        [Fact]
        public async Task UseGoogleDiagnostics_ConfiguresComponentsFromHostBuilderContext()
        {
            var testId = IdGenerator.FromDateTime();
            var startTime = DateTime.UtcNow;
            var configurationData = new Dictionary<string, string>
            {
                { "project_id", TestEnvironment.GetTestProjectId() },
                { "module_id", EntryData.Service },
                { "version_id", EntryData.Version }
            };

            var hostBuilder = GetHostBuilder(webHostBuilder =>
                webHostBuilder
                    .ConfigureServices((ctx, services) =>
                        services.AddGoogleDiagnosticsForAspNetCore(
                            ctx.Configuration["project_id"], ctx.Configuration["module_id"], ctx.Configuration["version_id"]))
                    .ConfigureAppConfiguration((hostContext, configBuilder) => configBuilder.AddInMemoryCollection(configurationData)));

            using var server = GetTestServer(hostBuilder);
            using var client = server.CreateClient();
            await TestTrace(testId, startTime, client);
            await TestLogging(testId, startTime, client);
            await TestErrorReporting(testId, client);
        }

        private static async Task TestLogging(string testId, DateTime startTime, HttpClient client)
        {
            await client.GetAsync($"/Main/Warning/{testId}");
            var results = LogEntryPolling.Default.GetEntries(startTime, testId, 1, LogSeverity.Warning);

            Assert.Single(results);
            var result = results.Single();
            Assert.Single(result.Labels);
            var label = result.Labels.Single();
            Assert.Equal("trace_identifier", label.Key);
            Assert.NotEmpty(label.Value);
        }

        private static async Task TestTrace(string testId, DateTimeOffset startTime, HttpClient client)
        {
            var uri = $"/Trace/{nameof(TraceController.Trace)}/{testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), testId);

            var response = await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);

            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        private static async Task TestErrorReporting(string testId, HttpClient client, bool verifyServiceAndVersion = true)
        {
            await Assert.ThrowsAsync<Exception>(() => client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{testId}"));
            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(ErrorEventEntryPolling.Default, testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, testId, nameof(ErrorReportingController.ThrowsException));
        }
    }
}
