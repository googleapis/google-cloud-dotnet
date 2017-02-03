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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using Google.Cloud.ErrorReporting.V1Beta1;
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
using System.Web.Http.ExceptionHandling;
using Xunit;
using Google.Cloud.Diagnostics.Common;

namespace Google.Cloud.Diagnostics.AspNet.IntegrationTests
{
    public class ExceptionLoggerTest
    {
        private static string ProjectId;
        private static string TestId;

        public ExceptionLoggerTest()
        {
            ProjectId = Utils.GetProjectIdFromEnvironment();
            TestId = Utils.GetTestId();
        }

        [Fact]
        public async Task ErrorReportingTest()
        {
            Task<ErrorStatsServiceClient> clientTask = ErrorStatsServiceClient.CreateAsync();

            // Create a test server and make an http.
            using (TestServer server = TestServer.Create<ErrorReportingApplication>())
            {
                await server.HttpClient.GetAsync("");

                // Create a request that will filter on the TestId which is set to the service and version.
                ListGroupStatsRequest request = new ListGroupStatsRequest
                {
                    ProjectName = new ProjectName(ProjectId).ToString(),
                    ServiceFilter = new ServiceContextFilter
                    {
                        Service = TestId,
                        Version = TestId
                    }
                };

                // Check that we have the proper results and the TestId shows up in the error.
                ErrorStatsServiceClient client = await clientTask;
                ErrorGroupStats stats = await client.ListGroupStatsAsync(request).FirstOrDefault();
                Assert.NotNull(stats);
                Assert.True(stats.Count > 0);
                Assert.Contains(TestId, stats.Representative.Message);
            }
        }

        /// <summary>
        /// A simple http handler that just throws an exception with the <see cref="TestId"/>
        /// as the message.
        /// </summary>
        private class ThrowErrorHandler : HttpMessageHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                throw new Exception(TestId);
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
                var options = ErrorReportingOptions.Create(ReportEventsTo.ErrorReporting());
                config.Services.Add(typeof(IExceptionLogger),
                    ErrorReportingExceptionLogger.Create(ProjectId, TestId, TestId, options));
                app.UseWebApi(config);
            }
        }
    }
}
