// Copyright 2017 Google Inc. All Rights Reserved.
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
using Moq;
using System;
using System.Web;
using System.Web.Mvc;
using Xunit;


namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ErrorReportingExceptionFilterTest
    {
        private static readonly ErrorReportingMatching s_matcher =
            new ErrorReportingMatching(ErrorReportingUtils.IsWindows);

        /// <summary>
        /// Creates an <see cref="ExceptionContext"/> that matches expected 
        /// context of <see cref="ErrorReportingMatching.IsSimpleContext"/>.
        /// </summary>
        private ExceptionContext CreateSimpleContext()
        {
            var mockRequest = new Mock<HttpRequestBase>();
            var mockResponse = new Mock<HttpResponseBase>();
            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request).Returns(mockRequest.Object);
            mockContext.Setup(c => c.Response).Returns(mockResponse.Object);

            return new ExceptionContext
            {
                HttpContext = mockContext.Object,
                Exception = new Exception(ErrorReportingMatching.ExceptionMessage)
            };
        }

        /// <summary>
        /// Creates an <see cref="ExceptionContext"/> that matches expected 
        /// context of <see cref="ErrorReportingMatching.IsComplexContext"/>.
        /// </summary>
        private ExceptionContext CreateComplexContext()
        {
            var mockRequest = new Mock<HttpRequestBase>();
            mockRequest.Setup(r => r.HttpMethod).Returns(ErrorReportingMatching.DeleteMethod);
            mockRequest.Setup(r => r.Url).Returns(ErrorReportingMatching.GoogleUri);
            mockRequest.Setup(r => r.UserAgent).Returns(ErrorReportingMatching.UserAgent);

            var mockResponse = new Mock<HttpResponseBase>();
            mockResponse.Setup(r => r.StatusCode).Returns(ErrorReportingMatching.ConflictStatusCode);

            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request).Returns(mockRequest.Object);
            mockContext.Setup(c => c.Response).Returns(mockResponse.Object);

            return new ExceptionContext
            {
                HttpContext = mockContext.Object,
                Exception = s_matcher.CreateException()
            };
        }
        
        private ErrorReportingExceptionFilter CreateFilter(IConsumer<ReportedErrorEvent> consumer)
            => new ErrorReportingExceptionFilter(consumer, ErrorReportingMatching.ServiceName, ErrorReportingMatching.VersionName);

        [Fact]
        public void Log()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(s_matcher.IsComplexContext()));

            ErrorReportingExceptionFilter filter = CreateFilter(mockConsumer.Object);
            filter.OnException(CreateComplexContext());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Simple()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(s_matcher.IsSimpleContext()));

            ErrorReportingExceptionFilter filter = CreateFilter(mockConsumer.Object);
            filter.OnException(CreateSimpleContext());

            mockConsumer.VerifyAll();
        }
    }
}
