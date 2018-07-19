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
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    [SnippetOutputCollector]
    public class DiagnosticsSnippetsTests : IDisposable
    {
        private const string Service = "service-name";
        private const string Version = "version-id";
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly DateTime _startTime;

        public DiagnosticsSnippetsTests()
        {
            // Sample: UseGoogleDiagnostics
            var webHostBuilder = new WebHostBuilder()
                // Replace ProjectId with your Google Cloud Project ID.
                // Replace Service with a name or identifier for the service.
                // Replace Version with a version for the service.
                .UseGoogleDiagnostics(ProjectId, Service, Version)
                .UseStartup<Startup>();
            // End sample

            _server = new TestServer(webHostBuilder);
            _client = _server.CreateClient();

            _testId = Utils.GetTestId();
            _startTime = DateTime.UtcNow;
        }

        /// <summary>
        /// When activating diagnostics the three aspects of it should work, Trace, Loggin and Error Logging.
        /// This tests that Error Logging works.
        /// </summary>
        [Fact]
        public async Task Logs_UnhandledException()
        {
            await Assert.ThrowsAsync<Exception>(() => _client.GetAsync($"/ErrorLoggingSamples/ThrowsException/{_testId}"));

            ErrorReportingSnippetsTests.PollAndVerifyErrorEvent(_startTime, _testId, "ThrowsException");
        }

        /// <summary>
        /// When activating diagnostics the three aspects of it should work, Trace, Loggin and Error Logging.
        /// This tests that Trace works.
        /// </summary>
        [Fact]
        public async Task Traces_Block()
        {
            HttpResponseMessage response = await _client.GetAsync($"/TraceSamples/TraceHelloWorld/{_testId}");

            TraceSnippetsTests.PollAndVerifyTrace(Timestamp.FromDateTime(_startTime), "/TraceSamples/TraceHelloWorld/", _testId, response);
        }

        /// <summary>
        /// When activating diagnostics the three aspects of it should work, Trace, Loggin and Error Logging.
        /// This tests that Logging works.
        /// </summary>
        [Fact]
        public async Task Logs_Information()
        {
            await _client.GetAsync($"/LoggingSamples/LogInformation/{_testId}");

            LoggingSnippetsTests.PollAndVerifyLog(_startTime, _testId);
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }
}
