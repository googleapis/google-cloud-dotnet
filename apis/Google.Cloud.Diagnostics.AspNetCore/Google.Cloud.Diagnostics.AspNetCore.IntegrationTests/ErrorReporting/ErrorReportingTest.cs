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
        public Task NoExceptions_ErrorReporting()
            => NoExceptions<ReportToErrorReportingTestApplication>();

        [Fact]
        public Task ManualLog_ErrorReporting()
            => ManualLog<ReportToErrorReportingTestApplication>();

        [Fact]
        public Task LogsException_ErrorReporting()
            => LogsException<ReportToErrorReportingTestApplication>();

        [Fact]
        public Task LogsMultipleExceptions_ErrorReporting()
            => LogsMultipleExceptions<ReportToErrorReportingTestApplication>();

        [Fact]
        public Task NoExceptions_Logging()
            => NoExceptions<ReportToLoggingTestApplication>();

        [Fact]
        public Task ManualLog_Logging()
            => ManualLog<ReportToLoggingTestApplication>();

        [Fact]
        public Task LogsException_Logging()
            => LogsException<ReportToLoggingTestApplication>();

        [Fact]
        public Task LogsMultipleExceptions_Logging()
            => LogsMultipleExceptions<ReportToLoggingTestApplication>();

        /// <summary>
        /// Test helper that will run a <see cref="TestServer"/> with a start up class,
        /// send a request to the server that will throw and catch and exception.  It 
        /// will ensure no error event was reported from  the test server to the error
        /// reporting api.
        /// </summary>
        /// <typeparam name="T">The type of the start up class for the test server.</typeparam>
        private async Task NoExceptions<T>() where T : class
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<T>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await client.GetAsync($"/ErrorReporting/Index/{testId}");

                var errorEvents = _polling.GetEvents(startTime, testId, 0);
                Assert.Empty(errorEvents);
            }
        }

        /// <summary>
        /// Test helper that will run a <see cref="TestServer"/> with a start up class,
        /// send a request to the server and ensure an error event was reported from 
        /// the test server that was manually logged.
        /// </summary>
        /// <typeparam name="T">The type of the start up class for the test server.</typeparam>
        private async Task ManualLog<T>() where T : class
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<T>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await client.GetAsync($"/ErrorReporting/ThrowCatchLog/{testId}");

                var errorEvents = _polling.GetEvents(startTime, testId, 1);
                Assert.Single(errorEvents);
                VerifyErrorEvent(errorEvents.First(), testId, "ThrowCatchLog");
            }
        }

        /// <summary>
        /// Test helper that will run a <see cref="TestServer"/> with a start up class,
        /// send a request to the server and ensure an uncaught error event was reported from 
        /// the test server to the error reporting api.
        /// </summary>
        /// <typeparam name="T">The type of the start up class for the test server.</typeparam>
        private async Task LogsException<T>() where T : class
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<T>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));

                var errorEvents = _polling.GetEvents(startTime, testId, 1);
                Assert.Single(errorEvents);
                VerifyErrorEvent(errorEvents.First(), testId, "ThrowsException");
            }
        }

        /// <summary>
        /// Test helper that will run a <see cref="TestServer"/> with a start up class,
        /// send multiple requests to the server and ensure multiple error events were
        /// reported from  the test server to the error reporting api.
        /// </summary>
        /// <typeparam name="T">The type of the start up class for the test server.</typeparam>
        private async Task LogsMultipleExceptions<T>() where T : class
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<T>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
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
            Assert.Equal(BaseErrorReportingTestApplication.Service, errorEvent.ServiceContext.Service);
            Assert.Equal(BaseErrorReportingTestApplication.Version, errorEvent.ServiceContext.Version);

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
        /// A <see cref="BaseErrorReportingTestApplication"/> that will report events through the
        /// error reporting api.
        /// </summary>
        private class ReportToErrorReportingTestApplication : BaseErrorReportingTestApplication
        {
            public override ErrorReportingOptions GetOptions() =>
                ErrorReportingOptions.Create(EventTarget.ForErrorReporting(ProjectId));
        }

        /// <summary>
        /// A <see cref="BaseErrorReportingTestApplication"/> that will report events through the
        /// logging api.
        /// </summary>
        private class ReportToLoggingTestApplication : BaseErrorReportingTestApplication
        {
            public override ErrorReportingOptions GetOptions() => null;
        }

        /// <summary>
        /// A simple web application base to test the <see cref="GoogleExceptionLogger"/>
        /// and associated classes.
        /// </summary>
        private abstract class BaseErrorReportingTestApplication
        {
            public const string Service = "service-name";
            public const string Version = "version-id";
            protected readonly string ProjectId = Utils.GetProjectIdFromEnvironment();

            public abstract ErrorReportingOptions GetOptions();

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddGoogleExceptionLogging(ProjectId, Service, Version, GetOptions());
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
