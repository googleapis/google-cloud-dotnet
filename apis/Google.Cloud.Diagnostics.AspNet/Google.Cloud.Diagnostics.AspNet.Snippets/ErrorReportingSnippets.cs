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
using Microsoft.Owin.Testing;
using Owin;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Snippets
{
    [SnippetOutputCollector]
    public class ErrorReportingSnippetsTests : IDisposable
    {
        private const string Service = EntryData.Service;
        private const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private static readonly ErrorEventEntryPolling s_polling = new ErrorEventEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public ErrorReportingSnippetsTests()
        {
            _testId = IdGenerator.FromDateTime();

            _server = TestServer.Create<ErrorReportingTestApplication>();
            _client = _server.HttpClient;
        }

        /// <summary>
        /// Test for sample RegisterExceptionLoggerWebApi. Only way to test the
        /// configuration sample is to actually see if uncaught exceptions are logged.
        /// </summary>
        [Fact]
        public async Task LogsException()
        {
            var response = await _client.GetAsync(
                $"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}");

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

            var errorEvent = s_polling.GetEvents(_testId, 1).Single();

            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(
                errorEvent, _testId, nameof(ErrorReportingController.ThrowsException));
        }

        [Fact]
        public async Task ManualLog_GoogleWebApiLogger()
        {
            var response = await _client.GetAsync(
                $"api/Home/{nameof(HomeController.CatchesAndLogsExceptions)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvent = s_polling.GetEvents(_testId, 1).Single();
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(
                errorEvent, _testId, "DoSomething");
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }

        /// <summary>
        /// A simple HttpApplication that registers an <see cref="ErrorReportingExceptionLogger"/>
        /// as part of the services.
        /// </summary>
        private class ErrorReportingTestApplication : HttpApplication
        {
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

                // Any other actions your app might need.

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

        /// <summary>
        /// A controller for the <see cref="ErrorReportingTestApplication"/> used to test exception logging.
        /// </summary>
        public class ErrorReportingController : ApiController
        {
            /// <summary>Throws an <see cref="Exception"/>.</summary>
            [HttpGet]
            public string ThrowsException(string id)
            {
                string message = EntryData.GetMessage(nameof(ThrowsException), id);
                throw new Exception(message);
            }
        }

        /// <summary>
        /// A more cleancut version of a controller for <see cref="ErrorReportingTestApplication"/>
        /// because it will be shown entirely as a snippet.
        /// </summary>
        // Sample: LogExceptionsWebApi
        public class HomeController : ApiController
        {
            // On this sample, we explicitly create an instance of the Web Api specific
            // GoogleWebApiExceptionLogger.
            // This is a dependency that you will probably want to inject
            // using the dependency injection mechanism of your choice.
            IWebApiExceptionLogger exceptionLogger = GoogleWebApiExceptionLogger.Create(
                // Replace ProjectId with your Google Cloud Project ID.
                // Replace Service with a name or identifier for the service.
                // Replace Version with a version for the service.
                ProjectId, Service, Version);

            /// <summary>This action method catches and logs an <see cref="Exception"/> using the
            /// Web Api specific <see cref="GoogleWebApiExceptionLogger"></summary>
            [HttpGet]
            public string CatchesAndLogsExceptions(string id)
            {
                try
                {
                    // Do something which happens to throw an Exception
                    DoSomething(id);
                }
                catch (Exception e)
                {
                    exceptionLogger.Log(e, ActionContext);
                }
                return "Something done succesfully.";
            }

            // This is normally not required, but ensures that "DoSomething" is in the stack
            // trace. The method is otherwise inlined by the JIT compiler for release builds in
            // some environments.
            [MethodImpl(MethodImplOptions.NoInlining)]
            private void DoSomething(string id)
            {
                throw new Exception(id);
            }
        }
        // End sample
    }
}
