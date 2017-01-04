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
using Google.Cloud.ErrorReporting.V1Beta1;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.ErrorReporting.V1Beta1.QueryTimeRange.Types;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTest
{
    public class ErrorReportingTest
    {
        /// <summary>Total time to spend sleeping when looking for error events.</summary>
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

        /// <summary>Time to sleep between checks for error events.</summary>
        private readonly TimeSpan _sleepInterval = TimeSpan.FromSeconds(2);

        /// <summary>A query time range of one hour.</summary>
        private readonly QueryTimeRange s_oneHour = new QueryTimeRange { Period = Period._1Hour };

        /// <summary>Project to run the test on.</summary>
        private readonly ProjectName _projectName;

        /// <summary>Client to use to send RPCs.</summary>
        private readonly ErrorStatsServiceClient _client;

        public ErrorReportingTest()
        {
            _projectName = new ProjectName(Utils.GetProjectIdFromEnvironment());
            _client = ErrorStatsServiceClient.Create();
        }

        /// <summary>
        /// Gets error events that contain the passed in testId in the message.  Will poll
        /// and wait for the entries to appear.
        /// </summary>
        /// <param name="startTime">The earliest error event time that will be looked at.</param>
        /// <param name="testId">The test id to filter error events on.</param>
        /// <param name="minEntries">The minimum number of error events that should be waited for.
        ///     If minEntries is zero this method will wait the full timeout before checking for the
        ///     entries.</param>
        private IEnumerable<ErrorEvent> GetEvents(DateTime startTime, string testId, int minEntries)
        {
            TimeSpan totalSleepTime = TimeSpan.Zero;
            while (totalSleepTime < _timeout)
            {
                TimeSpan sleepTime = minEntries > 0 ? _sleepInterval : _timeout;
                totalSleepTime += sleepTime;
                Thread.Sleep(sleepTime);

                List<ErrorEvent> errorEvents = new List<ErrorEvent>();
                var groups = _client.ListGroupStats(_projectName, s_oneHour);
                foreach (var group in groups)
                {
                    ListEventsRequest request = new ListEventsRequest
                    {
                        ProjectName = _projectName.ToString(),
                        GroupId = group.Group.GroupId,
                        TimeRange = s_oneHour
                    };

                    var events = _client.ListEvents(request);
                   errorEvents.AddRange(events.Where(e => e.Message.Contains(testId)));
                }

                if (minEntries == 0 || errorEvents.Count() >= minEntries)
                {
                    return errorEvents;
                }
            }
            return new List<ErrorEvent>();
        }

        [Fact]
        public async Task NoExceptions()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await client.GetAsync($"/ErrorReporting/Index/{testId}");
            }

            var errorEvents = GetEvents(startTime, testId, 0);
            Assert.Empty(errorEvents);
        }

        [Fact]
        public async Task LogsException()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            using (TestServer server = new TestServer(builder))
            {
                var client = server.CreateClient();
                await Assert.ThrowsAsync<Exception>(() =>
                    client.GetAsync($"/ErrorReporting/ThrowsException/{testId}"));
            }

            var errorEvents = GetEvents(startTime, testId, 1);
            Assert.Single(errorEvents);
            VerifyErrorEvent(errorEvents.First(), testId, "ThrowsException");
        }

        [Fact]
        public async Task LogsMultipleException()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
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
            }

            var errorEvents = GetEvents(startTime, testId, 1);
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

        /// <summary>
        /// Checks that an <see cref="ErrorEvent"/> contains valid data.
        /// </summary>
        /// <param name="errorEvent">The event to check.</param>
        /// <param name="testId">The id of the test.</param>
        /// <param name="functionName">The name of the function the error occured in.</param>
        private void VerifyErrorEvent(ErrorEvent errorEvent, string testId, string functionName)
        {
            Assert.Equal(ErrorReportingTestApplication.Service, errorEvent.ServiceContext.Service);
            Assert.Equal(ErrorReportingTestApplication.Version, errorEvent.ServiceContext.Version);

            Assert.Contains(functionName, errorEvent.Message);
            Assert.Contains(testId, errorEvent.Message);

            Assert.Equal(HttpMethod.Get.Method, errorEvent.Context.HttpRequest.Method);
            Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.HttpRequest.Url));
            Assert.True(errorEvent.Context.HttpRequest.ResponseStatusCode >= 200);

            Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.ReportLocation.FilePath));
            Assert.Equal(functionName, errorEvent.Context.ReportLocation.FunctionName);
            Assert.True(errorEvent.Context.ReportLocation.LineNumber > 0);
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="ErrorReportingExceptionLogger"/> and associated classes.
    /// </summary>
    public class ErrorReportingTestApplication
    {
        public const string Service = "service-name";
        public const string Version = "version-id";
        private readonly string _projectId;

        public ErrorReportingTestApplication()
        {
            _projectId = Utils.GetProjectIdFromEnvironment();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.ReportExceptionsToGoogle(_projectId, Service, Version);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ErrorReporting}/{action=Index}/{id}");
            });
        }
    }

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorReportingController : Controller
    {
        public ErrorReportingController() {}

        /// <summary>Cathces and handles a thrown <see cref="Exception"/>.</summary>
        public string Index(string id) {
            var message = GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
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

        private string GetMessage(string message, string id) => $"{message} - {id}";
    }
}
