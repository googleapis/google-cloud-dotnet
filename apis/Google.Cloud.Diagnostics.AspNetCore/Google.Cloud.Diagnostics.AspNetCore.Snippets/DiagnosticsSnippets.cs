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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
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
    public class DiagnosticsSnippetsTests : IDisposable
    {
        private const string Service = EntryData.Service;
        private const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly DateTimeOffset _startTime;

        public DiagnosticsSnippetsTests()
        {
#if NETCOREAPP3_1
            // Sample: UseGoogleDiagnostics_Core3
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    // Replace ProjectId with your Google Cloud Project ID.
                    // Replace Service with a name or identifier for the service.
                    // Replace Version with a version for the service.
                    .UseGoogleDiagnostics(ProjectId, Service, Version)
                    .UseStartup<Startup>());
            // End sample
            hostBuilder.ConfigureWebHost(webBuilder => webBuilder.UseTestServer());
#elif NETCOREAPP2_1 || NET461
            // Sample: UseGoogleDiagnostics
            var hostBuilder = new WebHostBuilder()
                // Replace ProjectId with your Google Cloud Project ID.
                // Replace Service with a name or identifier for the service.
                // Replace Version with a version for the service.
                .UseGoogleDiagnostics(ProjectId, Service, Version)
                .UseStartup<Startup>();
            // End sample
#else
#error unknown target framework
#endif
            _server = GetTestServer(hostBuilder);
            _client = _server.CreateClient();

            _testId = IdGenerator.FromDateTime();
            _startTime = DateTimeOffset.UtcNow;
        }

        /// <summary>
        /// When activating diagnostics the three aspects of it should work, Trace, Loggin and Error Logging.
        /// This tests that Error Logging works.
        /// </summary>
        [Fact]
        public async Task Logs_UnhandledException()
        {
            await Assert.ThrowsAsync<Exception>(() => _client.GetAsync($"/ErrorLoggingSamples/{nameof(ErrorLoggingSamplesController.ThrowsException)}/{_testId}"));

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(ErrorEventEntryPolling.Default, _testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorLoggingSamplesController.ThrowsException));
        }

        /// <summary>
        /// When activating diagnostics the three aspects of it should work, Trace, Loggin and Error Logging.
        /// This tests that Trace works.
        /// </summary>
        [Fact]
        public async Task Traces_Block()
        {
            var uri = $"/TraceSamplesConstructor/{nameof(TraceSamplesConstructorController.TraceHelloWorld)}/{_testId}";
            var response = await _client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, _testId);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
        }

        /// <summary>
        /// When activating diagnostics the three aspects of it should work, Trace, Loggin and Error Logging.
        /// This tests that Logging works.
        /// </summary>
        [Fact]
        public async Task Logs_Information()
        {
            await _client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");

            LoggingSnippetsTests.PollAndVerifyLog(LogEntryPolling.Default, _startTime, _testId);
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }
}
