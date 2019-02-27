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
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.IntegrationTests
{
    public class ErrorReportingTest : IDisposable
    {
        private static readonly ErrorEventEntryPolling s_polling = new ErrorEventEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public ErrorReportingTest()
        {
            _testId = IdGenerator.FromDateTime();

            _server = TestServer.Create<ErrorReportingTestApplication>();
            _client = _server.HttpClient;
        }

        [Fact]
        public async Task LogsException()
        {
            var response = await _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}");
            var contentTask = response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(s_polling, _testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException));

            var content = await contentTask;
            Assert.Contains(nameof(ErrorReportingController.ThrowsException), content);
            Assert.Contains(_testId, content);
        }

        [Fact]
        public async Task LogsMultipleExceptions()
        {
            var requestTask1 = _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}");
            var requestTask2 = _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsArgumentException)}/{_testId}");
            var requestTask3 = _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}");
            var requestTask4 = _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}");

            var response = await requestTask1;
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            response = await requestTask2;
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            response = await requestTask3;
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            response = await requestTask4;
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

            var errorEvents = ErrorEventEntryVerifiers.VerifyMany(s_polling, _testId, 4);

            var exceptionEvents = errorEvents
                .Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsException)));
            Assert.Equal(3, exceptionEvents.Count());
            foreach (var errorEvent in exceptionEvents)
            {
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException));
            }

            var argumentExceptionEvent = errorEvents
                .Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsArgumentException)))
                .Single();
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(argumentExceptionEvent, _testId, nameof(ErrorReportingController.ThrowsArgumentException));
        }

        [Fact]
        public async Task LogsThrownInHttpMessageHandler()
        {
            var response = await _client.GetAsync($"handler/{_testId}");

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(s_polling, _testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, "SendAsync");
        }

        [Fact]
        public async Task ManualLog_GoogleLogger()
        {
            var response = await _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowCatchWithGoogleLogger)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(s_polling, _testId);
            ErrorEventEntryVerifiers.VerifyErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowCatchWithGoogleLogger));
        }

        [Fact]
        public async Task ManualLog_GoogleWebApiLogger()
        {
            var response = await _client.GetAsync($"api/ErrorReporting/{nameof(ErrorReportingController.ThrowCatchWithGoogleWebApiLogger)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(s_polling, _testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowCatchWithGoogleWebApiLogger));
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

            private static void Register(HttpConfiguration config)
            {
                config.Services.Add(typeof(System.Web.Http.ExceptionHandling.IExceptionLogger),
                    ErrorReportingExceptionLogger.Create(TestEnvironment.GetTestProjectId(), EntryData.Service, EntryData.Version));

                config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

                // Web API routes
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
                config.Routes.MapHttpRoute(
                    name: "MessageHandler",
                    routeTemplate: "handler/{id}",
                    null, null,
                    new ThrowErrorHandler());
            }
        }
    }

    /// <summary>
    /// A simple http handler that just throws an exception.
    /// </summary>
    public class ThrowErrorHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string id = request.GetRouteData().Values["id"].ToString();
            string message = EntryData.GetMessage(nameof(SendAsync), id);
            throw new Exception(message);
        }
    };

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorReportingController : ApiController
    {
        /// <summary>Throws and catches exception.</summary>
        [HttpGet]
        public string Index(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
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
        [HttpGet]
        public string ThrowsException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        /// <summary>Throws an <see cref="ArgumentException"/>.</summary>
        [HttpGet]
        public string ThrowsArgumentException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsArgumentException), id);
            throw new ArgumentException(message);
        }

        /// <summary>Throws, catches and logs an <see cref="Exception"/> using the
        /// general purpose <see cref="GoogleExceptionLogger"></summary>
        [HttpGet]
        public string ThrowCatchWithGoogleLogger(string id)
        {
            var exceptionLogger = GoogleExceptionLogger.Create(TestEnvironment.GetTestProjectId(), EntryData.Service, EntryData.Version);
            var message = EntryData.GetMessage(nameof(ThrowCatchWithGoogleLogger), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
            {
                exceptionLogger.Log(e);
            }
            return message;
        }

        /// <summary>Throws, catches and logs an <see cref="Exception"/> using the
        /// Web Api specific <see cref="GoogleWebApiExceptionLogger"></summary>
        [HttpGet]
        public string ThrowCatchWithGoogleWebApiLogger(string id)
        {
            var exceptionLogger = GoogleWebApiExceptionLogger.Create(TestEnvironment.GetTestProjectId(), EntryData.Service, EntryData.Version);
            var message = EntryData.GetMessage(nameof(ThrowCatchWithGoogleWebApiLogger), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
            {
                exceptionLogger.Log(e, ActionContext);
            }
            return message;
        }
    }
}
