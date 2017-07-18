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
using Microsoft.Owin.Testing;
using Owin;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Xunit;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;

namespace Google.Cloud.Diagnostics.AspNet.IntegrationTests
{
    public class ExceptionLoggerTest
    {
        internal static string _projectId { get; private set; }
        internal static string _testId { get; private set; }

        private readonly ErrorEventEntryPolling _polling = new ErrorEventEntryPolling();

        public ExceptionLoggerTest()
        {
            _projectId = Utils.GetProjectIdFromEnvironment();
            _testId = Utils.GetTestId();
        }

        [Fact]
        public async Task ErrorReportingTest()
        {
            DateTime startTime = DateTime.UtcNow;

            // Create a test server and make an http.
            using (TestServer server = TestServer.Create<ErrorReportingApplication>())
            {
                await server.HttpClient.GetAsync("");

                var errorEvent = _polling.GetEvents(startTime, _testId, 1).Single();
                Assert.Contains(_testId, errorEvent.Message);
            }
        }

        /// <summary>
        /// A simple http handler that just throws an exception with the <see cref="_testId"/>
        /// as the message.
        /// </summary>
        private class ThrowErrorHandler : HttpMessageHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                throw new Exception(_testId);
            }
        };

        /// <summary>
        /// A simple <see cref="HttpApplication"/> that registers a <see cref="ErrorReportingExceptionLogger"/>
        /// </summary>
        private class ErrorReportingApplication : HttpApplication
        {
            public void Configuration(IAppBuilder app)
            {
                HttpConfiguration config = new HttpConfiguration();
                config.Routes.MapHttpRoute("", "", null, null, new ThrowErrorHandler());
                config.Services.Add(typeof(System.Web.Http.ExceptionHandling.IExceptionLogger),
                    ErrorReportingExceptionLogger.Create(_projectId, _testId, _testId));
                app.UseWebApi(config);
            }
        }
    }
}
