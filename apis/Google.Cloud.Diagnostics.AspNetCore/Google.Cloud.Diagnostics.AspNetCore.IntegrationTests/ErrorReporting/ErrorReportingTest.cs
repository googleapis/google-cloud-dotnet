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

using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.ErrorReporting.V1Beta1;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class ErrorReportingTest
    {
        private readonly ErrorEventEntryPolling _polling = new ErrorEventEntryPolling();

        private readonly bool _isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        [Fact]
        public async Task NoExceptions()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/ErrorReporting/Index/{testId}");

                var errorEvents = _polling.GetEvents(startTime, testId, 0);
                Assert.Empty(errorEvents);
            }
        }

        [Fact]
        public async Task ManualLog()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/ErrorReporting/ThrowCatchLog/{testId}");

                var errorEvents = _polling.GetEvents(startTime, testId, 1);
                Assert.Single(errorEvents);
                VerifyErrorEvent(errorEvents.First(), testId, "ThrowCatchLog");
            }
        }

        [Fact]
        public async Task LogsException()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));

                var errorEvents = _polling.GetEvents(startTime, testId, 1);
                Assert.Single(errorEvents);
                VerifyErrorEvent(errorEvents.First(), testId, "ThrowsException");
            }
        }

        [Fact]
        public async Task LogsMultipleExceptions()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));
                await Assert.ThrowsAsync<ArgumentException>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsArgumentException/{testId}"));
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));

                var errorEvents = _polling.GetEvents(startTime, testId, 4);
                Assert.Equal(4, errorEvents.Count());

                var exceptionEvents = errorEvents.Where(e => e.Message.Contains("ThrowsException"));
                Assert.Equal(3, exceptionEvents.Count());
                foreach (var errorEvent in exceptionEvents)
                {
                    VerifyErrorEvent(errorEvent, testId, "ThrowsException");
                }

                var argumentExceptionEvents = errorEvents.Where(e => e.Message.Contains("ThrowsArgumentException"));
                Assert.Single(argumentExceptionEvents);
                VerifyErrorEvent(argumentExceptionEvents.First(), testId, "ThrowsArgumentException");
            }
        }

        /// <summary>
        /// Checks that an <see cref="ErrorEvent"/> contains valid data.
        /// </summary>
        /// <param name="errorEvent">The event to check.</param>
        /// <param name="testId">The id of the test.</param>
        /// <param name="functionName">The name of the function the error occurred in.</param>
        private void VerifyErrorEvent(ErrorEvent errorEvent, string testId, string functionName)
        {
            Assert.Equal(ErrorReportingTestApplication.Service, errorEvent.ServiceContext.Service);
            Assert.Equal(ErrorReportingTestApplication.Version, errorEvent.ServiceContext.Version);

            Assert.Contains(functionName, errorEvent.Message);
            Assert.Contains(testId, errorEvent.Message);

            Assert.Equal(HttpMethod.Get.Method, errorEvent.Context.HttpRequest.Method);
            Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.HttpRequest.Url));
            Assert.True(errorEvent.Context.HttpRequest.ResponseStatusCode >= 200);

            if (_isWindows)
            {
                Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.ReportLocation.FilePath));
                Assert.True(errorEvent.Context.ReportLocation.LineNumber > 0);
            }
            Assert.Equal(functionName, errorEvent.Context.ReportLocation.FunctionName);
        }

        /// <summary>
        /// A simple web application base to test the <see cref="GoogleExceptionLogger"/>
        /// and associated classes.
        /// </summary>
        private class ErrorReportingTestApplication
        {
            public const string Service = "service-name";
            public const string Version = "version-id";
            protected readonly string ProjectId = Utils.GetProjectIdFromEnvironment();

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddGoogleExceptionLogging(options =>
                {
                    options.ProjectId = ProjectId;
                    options.ServiceName = Service;
                    options.Version = Version;
                });
                services.AddMvc();
            }

            public void Configure(IApplicationBuilder app)
            {
                app.UseGoogleExceptionLogging();

                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=ErrorReporting}/{action=Index}/{id}");
                });
            }
        }
    }

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorReportingController : Controller
    {
        private readonly IExceptionLogger _exceptionLogger;
        public ErrorReportingController(IExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        /// <summary>Catches and handles a thrown <see cref="Exception"/>.</summary>
        public string Index(string id)
        {
            var message = GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch
            {
                // Do nothing.
            }
            return message;
        }

        /// <summary>Throws an <see cref="Exception"/>.</summary>
        public string ThrowsException(string id)
        {
            string message = GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        /// <summary>Throws an <see cref="ArgumentException"/>.</summary>
        public string ThrowsArgumentException(string id)
        {
            string message = GetMessage(nameof(ThrowsArgumentException), id);
            throw new ArgumentException(message);
        }

        /// <summary>Catches and logs a thrown <see cref="Exception"/>.</summary>
        public string ThrowCatchLog(string id)
        {
            var message = GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
            {
                _exceptionLogger.Log(e);
            }
            return message;
        }

        private string GetMessage(string message, string id) => $"{message} - {id}";
    }
}
