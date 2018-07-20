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

using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Diagnostics.Common.IntegrationTests.ErrorReporting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class ErrorReportingTest
    {
        private readonly ErrorEventEntryPolling _polling = new ErrorEventEntryPolling();

        [Fact]
        public async Task NoExceptions()
        {
            string testId = IdGenerator.FromDateTime();
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
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/ErrorReporting/ThrowCatchLog/{testId}");

                var errorEvents = _polling.GetEvents(startTime, testId, 1);
                Assert.Single(errorEvents);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvents.First(), testId, "ThrowCatchLog");
            }
        }

        [Fact]
        public async Task LogsException()
        {
            string testId = IdGenerator.FromDateTime();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            using (var client = server.CreateClient())
            {
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));

                var errorEvents = _polling.GetEvents(startTime, testId, 1);
                Assert.Single(errorEvents);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvents.First(), testId, "ThrowsException");
            }
        }

        [Fact]
        public async Task LogsMultipleExceptions()
        {
            string testId = IdGenerator.FromDateTime();
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
                    ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, testId, "ThrowsException");
                }

                var argumentExceptionEvents = errorEvents.Where(e => e.Message.Contains("ThrowsArgumentException"));
                Assert.Single(argumentExceptionEvents);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(argumentExceptionEvents.First(), testId, "ThrowsArgumentException");
            }
        }

        /// <summary>
        /// A simple web application base to test the <see cref="GoogleExceptionLogger"/>
        /// and associated classes.
        /// </summary>
        private class ErrorReportingTestApplication
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddGoogleExceptionLogging(options =>
                {
                    options.ProjectId = TestEnvironment.GetTestProjectId();
                    options.ServiceName = ErrorEventEntryData.Service;
                    options.Version = ErrorEventEntryData.Version;
                })
                .AddMvc();
            }

            public void Configure(IApplicationBuilder app)
            {
                app.UseGoogleExceptionLogging()
                    .UseMvc(routes =>
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
            var message = ErrorEventEntryData.GetMessage(nameof(Index), id);
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
            string message = ErrorEventEntryData.GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        /// <summary>Throws an <see cref="ArgumentException"/>.</summary>
        public string ThrowsArgumentException(string id)
        {
            string message = ErrorEventEntryData.GetMessage(nameof(ThrowsArgumentException), id);
            throw new ArgumentException(message);
        }

        /// <summary>Catches and logs a thrown <see cref="Exception"/>.</summary>
        public string ThrowCatchLog(string id)
        {
            var message = ErrorEventEntryData.GetMessage(nameof(Index), id);
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
    }
}
