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
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.ErrorReporting.V1Beta1;
using Microsoft.Owin.Testing;
using Owin;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Snippets
{
    [SnippetOutputCollector]
    public class ErrorReportingSnippets
    {
        private readonly ErrorEventEntryPolling _polling = new ErrorEventEntryPolling();

        [Fact]
        public async Task LogsException()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            using (TestServer server = TestServer.Create<ErrorReportingSnippetsApplication>())
            using (var client = server.HttpClient)
            {
                var response = await client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{testId}");

                Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

                var errorEvent = _polling.GetEvents(startTime, testId, 1).Single();
                VerifyFullLogging(errorEvent, testId, nameof(ErrorReportingController.ThrowsException));
            }
        }

        [Fact]
        public async Task ManualLog_GoogleWebApiLogger()
        {
            string testId = Utils.GetTestId();
            DateTime startTime = DateTime.UtcNow;

            using (TestServer server = TestServer.Create<ErrorReportingSnippetsApplication>())
            using (var client = server.HttpClient)
            {
                var response = await client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.CatchesAndLogsException)}/{testId}");
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);

                var errorEvent = _polling.GetEvents(startTime, testId, 1).Single();
                VerifyFullLogging(errorEvent, testId, nameof(ErrorReportingController.ThrowsException));
            }
        }

        internal static void VerifyFullLogging(ErrorEvent errorEvent, string testId, string functionName)
        {
            VerifyErrorLogging(errorEvent, testId, functionName);
            VerifyHttpContextLogging(errorEvent);
        }

        /// <summary>
        /// Checks that an <see cref="ErrorEvent"/> contains valid data.
        /// </summary>
        /// <param name="errorEvent">The event to check.</param>
        /// <param name="testId">The id of the test.</param>
        /// <param name="functionName">The name of the function the error occurred in.</param>
        internal static void VerifyErrorLogging(ErrorEvent errorEvent, string testId, string functionName)
        {
            Assert.Equal(ErrorReportingSnippetsApplication.Service, errorEvent.ServiceContext.Service);
            Assert.Equal(ErrorReportingSnippetsApplication.Version, errorEvent.ServiceContext.Version);

            Assert.Contains(functionName, errorEvent.Message);
            Assert.Contains(testId, errorEvent.Message);

            if (Utils.IsWindows())
            {
                Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.ReportLocation.FilePath));
                Assert.True(errorEvent.Context.ReportLocation.LineNumber > 0);
            }
            Assert.Equal(functionName, errorEvent.Context.ReportLocation.FunctionName);
        }

        /// <summary>
        /// Only for automatic logging, in self hosted web apis <see cref="HttpContext.Current"/>
        /// is <code>null</code>.
        /// </summary>
        internal static void VerifyHttpContextLogging(ErrorEvent errorEvent)
        {
            Assert.Equal(HttpMethod.Get.Method, errorEvent.Context.HttpRequest.Method);
            Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.HttpRequest.Url));
        }

        internal static string GetMessage(string message, string id) => $"{message} - {id}";
    }

    internal class ErrorReportingSnippetsApplication : HttpApplication
    {
        public const string Service = "service-name";
        public const string Version = "version-id";
        public static readonly string ProjectId = Utils.GetProjectIdFromEnvironment();

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            Register(config);
            app.UseWebApi(config);
        }

        // Sample: RegisterExceptionLoggerWebApi
        private static void Register(HttpConfiguration config)
        {
            // Add a catch all for the uncaught exceptions.
            // Replace ProjectId with your Google Cloud Project ID.
            // Replace Service with a name or identifier for the service.
            // Replace Version with a version for the service.
            config.Services.Add(typeof(System.Web.Http.ExceptionHandling.IExceptionLogger),
                ErrorReportingExceptionLogger.Create(ProjectId, Service, Version));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        // End sample
    }

    public class ErrorReportingController : ApiController
    {
        public const string Service = "service-name";
        public const string Version = "version-id";
        public static readonly string ProjectId = Utils.GetProjectIdFromEnvironment();

        /// <summary>Throws an <see cref="Exception"/>.
        /// Needed to test the RegisterExceptionLoggerWebApi snippet.</summary>
        [HttpGet]
        public string ThrowsException(string id)
        {
            string message = ErrorReportingSnippets.GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        // Sample: LogExceptionsWebApi
        /// <summary>
        /// This method catches an exception thrown by another method and explicitly
        /// logs that exception.
        /// </summary>
        [HttpGet]
        public string CatchesAndLogsException(string id)
        {
            GoogleWebApiExceptionLogger exceptionLogger = GoogleWebApiExceptionLogger.Create(ProjectId, Service, Version);
            try
            {
                // This method call throws an exception.
                ThrowsException(id);
            }
            catch (Exception e)
            {
                exceptionLogger.Log(e, ActionContext);
            }

            return $"{nameof(CatchesAndLogsException)} executed succesfully for id = {id}";
        }
        // End sample
    }
}
