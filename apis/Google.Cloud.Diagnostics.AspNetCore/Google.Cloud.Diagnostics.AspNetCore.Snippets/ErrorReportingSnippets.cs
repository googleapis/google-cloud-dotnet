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
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    [SnippetOutputCollector]
    public class ErrorReportingSnippetsTests : IDisposable
    {
        private static readonly ErrorEventEntryPolling s_polling = new ErrorEventEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public ErrorReportingSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            _server = new TestServer(builder);
            _client = _server.CreateClient();
        }

        /// <summary>
        /// Test for the snippet sample ReportUnhandledExceptions which is a
        /// configuration sample. Only way to test that the configuration is ok
        /// is to check that logging of errors works as expected.
        /// </summary>
        [Fact]
        public async Task Logs_UnhandledException()
        {
            await Assert.ThrowsAsync<Exception>(()
                => _client.GetAsync($"/ErrorLoggingSamples/{nameof(ErrorLoggingSamplesController.ThrowsException)}/{_testId}"));

            var errorEvent = s_polling.GetEvents(_testId, 1).Single();

            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorLoggingSamplesController.ThrowsException));
        }

        /// <summary>
        /// Test for the snippet sample LogExceptions. On the snippet we need to show 
        /// the method signature to show injection of the logger from services, and also
        /// we need the method to live in a MVC controller so that the logger is properly
        /// injected. Because of that we can't have the snippet being the test itself.
        /// </summary>
        [Fact]
        public async Task Logs_Explicitly()
        {
            var response = await _client.GetAsync($"/ErrorLoggingSamples/{nameof(ErrorLoggingSamplesController.CatchesAndLogsException)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvent = s_polling.GetEvents(_testId, 1).Single();

            // Verifying with function name ThrowsExceptions because that is the function
            // that actually throws the Exception so will be the one included as
            // ErrorEvent.Context.ReportLocation.FunctionName
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorLoggingSamplesController.ThrowsException));
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleExceptionLogger"/>
    /// and associated classes.
    /// </summary>
    internal class ErrorReportingTestApplication
    {
        public const string Service = EntryData.Service;
        public const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        // Sample: ReportUnhandledExceptions
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGoogleExceptionLogging(options =>
            {
                // Replace ProjectId with your Google Cloud Project ID.
                options.ProjectId = ProjectId;
                // Replace Service with a name or identifier for the service.
                options.ServiceName = Service;
                // Replace Version with a version for the service.
                options.Version = Version;
            });

            // ...any other services your application requires.

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Use before handling any requests to ensure all unhandled exceptions are reported.
            app.UseGoogleExceptionLogging();

            // ...any other configuration your application requires.

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        // End sample
    }

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorLoggingSamplesController : Controller
    {
        /// <summary>Throws an <see cref="Exception"/>.</summary>
        public void ThrowsException(string id)
        {
            throw new Exception(id);
        }

        // Sample: LogExceptions
        /// <summary>
        /// This method catches an exception thrown by another method and explicitly
        /// logs that exception.
        /// The <see cref="IExceptionLogger"/> is populated by dependency injection 
        /// thanks to the use of the <see cref="FromServicesAttribute"/> attribute.
        /// </summary>
        public void CatchesAndLogsException(string id, [FromServices]IExceptionLogger exceptionLogger)
        {
            try
            {
                // This method call throws an exception.
                ThrowsException(id);
            }
            catch (Exception e)
            {
                exceptionLogger.Log(e);
            }
        }
        // End sample
    }
}
