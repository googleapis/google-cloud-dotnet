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
using Moq;
using System;
using System.Web;
using System.Web.Mvc;
using Xunit;


namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ErrorReportingExceptionFilterTest
    {
        /// <summary>Creates an <see cref="ExceptionContext"/>.</summary>
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
                Exception = new Exception()
            };
        }

        [Fact]
        public void Log()
        {
            ExceptionContext context = CreateSimpleContext();
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var filter = new ErrorReportingExceptionFilter(mockContextLogger.Object);

            filter.OnException(context);
            mockContextLogger.Verify(cl => cl.Log(context.Exception, It.IsAny<ExceptionContextWrapper>()));
        }
    }
}
