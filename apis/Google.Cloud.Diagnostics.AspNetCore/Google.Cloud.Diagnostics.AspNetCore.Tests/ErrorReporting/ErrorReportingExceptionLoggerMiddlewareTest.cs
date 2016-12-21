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

using Google.Cloud.ErrorReporting.V1Beta1;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests.ErrorReporting
{
    public class ErrorReportingExceptionLoggerMiddlewareTest
    {

        [Fact]
        public async Task Invoke_NoLogs()
        {
            var mockLogger = new Mock<IExceptionLogger<ReportErrorEventResponse>>();
            RequestDelegate requestDelegate = delegate (HttpContext context) { return Task.CompletedTask; };
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, mockLogger.Object);

            await middleware.Invoke(new DefaultHttpContext());

            mockLogger.Verify(l => l.LogAsync(It.IsAny<DefaultHttpContext>(), It.IsAny<Exception>()), Times.Never());
            mockLogger.Verify(l => l.Log(It.IsAny<DefaultHttpContext>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public async Task Invoke_LogsAndThrows()
        {
            var mockLogger = new Mock<IExceptionLogger<ReportErrorEventResponse>>();
            RequestDelegate requestDelegate = delegate (HttpContext context) { throw new Exception(); };
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, mockLogger.Object);

            await Assert.ThrowsAsync<Exception>(() => middleware.Invoke(new DefaultHttpContext()));

            mockLogger.Verify(l => l.LogAsync(It.IsAny<DefaultHttpContext>(), It.IsAny<Exception>()), Times.Once());
            mockLogger.Verify(l => l.Log(It.IsAny<DefaultHttpContext>(), It.IsAny<Exception>()), Times.Never());
        }
    }
}
