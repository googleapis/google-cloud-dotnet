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

using Google.Devtools.Clouderrorreporting.V1Beta1;
using Microsoft.Owin.Testing;
using Owin;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Xunit;

namespace Google.Devtools.AspNet.IntegrationTests
{
    public class CloudErrorReportingExceptionLoggerIntregrationTest
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";
        private static string ProjectId;
        private static string TestId;

        public CloudErrorReportingExceptionLoggerIntregrationTest()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            TestId = DateTime.UtcNow.ToString("'test'_yyyyMMddTHHmmssfff", CultureInfo.InvariantCulture);
        }

        [Fact]
        public void ErrorReportingTest()
        {
            // Create a test server and make an http request.
            using (TestServer server = TestServer.Create<ErrorReportingApplication>())
            {
                server.HttpClient.GetAsync("").Wait();

                // Create a request that will filter on the TestId which is set to the service and version.
                ListGroupStatsRequest request = new ListGroupStatsRequest
                {
                    ProjectName = ErrorStatsServiceClient.FormatProjectName(ProjectId),
                    ServiceFilter = new ServiceContextFilter
                    {
                        Service = TestId,
                        Version = TestId
                    }
                };

                // Check that we have the proper results and the TestId shows up in the error.
                ErrorStatsService.ErrorStatsServiceClient grpcClient = ErrorStatsServiceClient.Create().GrpcClient;
                ListGroupStatsResponse listResponse = grpcClient.ListGroupStats(request);
                Assert.NotEmpty(listResponse.ErrorGroupStats);
                ErrorGroupStats stats = listResponse.ErrorGroupStats[0];
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
        /// A simple <see cref="HttpApplication"/> that registers a <see cref="CloudErrorReportingExceptionLogger"/>
        /// </summary>
        private class ErrorReportingApplication : HttpApplication
        {
            public void Configuration(IAppBuilder app)
            {
                HttpConfiguration config = new HttpConfiguration();
                config.Routes.MapHttpRoute("", "", null, null, new ThrowErrorHandler());
                config.Services.Add(typeof(IExceptionLogger),
                    CloudErrorReportingExceptionLogger.Create(ProjectId, TestId, TestId));
                app.UseWebApi(config);
            }
        }
    }
}
