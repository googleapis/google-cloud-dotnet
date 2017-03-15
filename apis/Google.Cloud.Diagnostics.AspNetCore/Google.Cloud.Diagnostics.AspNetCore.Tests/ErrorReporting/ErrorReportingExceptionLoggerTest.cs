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
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.ErrorReporting.V1Beta1;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class ErrorReportingExceptionLoggerTest
    {
        private static readonly string s_googleUri = ErrorReportingMatching.GoogleUri.ToString();
        private static readonly ErrorReportingMatching s_matcher = new ErrorReportingMatching(
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows), defaultUri: s_googleUri);

        /// <summary>
        /// Creates a <see cref="HttpContext"/> that matches expected 
        /// context of <see cref="ErrorReportingMatching.IsComplexContext"/>.
        /// </summary>
        private HttpContext CreateComplexContext()
        {
            var context = new DefaultHttpContext();
            var request = context.Request;
            request.Method = ErrorReportingMatching.DeleteMethod;
            request.Host = new HostString(s_googleUri);
            request.Headers["User-Agent"] = ErrorReportingMatching.UserAgent;

            var response = context.Response;
            response.StatusCode = ErrorReportingMatching.ConflictStatusCode;

            return context;
        }

        [Fact]
        public async Task Report_Simple()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            var logger = new GoogleExceptionLogger(
                mockConsumer.Object, ErrorReportingMatching.ServiceName, ErrorReportingMatching.VersionName);

            var context = new DefaultHttpContext();
            context.Request.Host = new HostString(s_googleUri);
            context.Response.StatusCode = 0;

            mockConsumer.Setup(c => c.ReceiveAsync(s_matcher.IsSimpleContext(), default(CancellationToken)))
                .Returns(CommonUtils.CompletedTask);
            await logger.LogAsync(context, new Exception(ErrorReportingMatching.ExceptionMessage));
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task Report_Complex()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            var logger = new GoogleExceptionLogger(
                mockConsumer.Object, ErrorReportingMatching.ServiceName, ErrorReportingMatching.VersionName);

            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            mockConsumer.Setup(c => c.ReceiveAsync(s_matcher.IsComplexContext(), default(CancellationToken)))
                .Returns(CommonUtils.CompletedTask);
            await logger.LogAsync(CreateComplexContext(), s_matcher.CreateException());
            mockConsumer.VerifyAll();
        }
    }
}
