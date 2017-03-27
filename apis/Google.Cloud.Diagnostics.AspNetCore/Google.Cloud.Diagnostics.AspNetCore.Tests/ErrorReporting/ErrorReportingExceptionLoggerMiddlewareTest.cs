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
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class ErrorReportingExceptionLoggerMiddlewareTest
    {
        [Fact]
        public async Task Invoke_NoLogs()
        {
            var mockLogger = new Mock<IExceptionLogger>();
            RequestDelegate requestDelegate = context => Task.CompletedTask;
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, mockLogger.Object);

            await middleware.Invoke(new DefaultHttpContext());

            mockLogger.Verify(l => l.LogAsync(It.IsAny<Exception>(), It.IsAny<DefaultHttpContext>(), CancellationToken.None), Times.Never());
        }

        [Fact]
        public async Task Invoke_LogsAndThrows()
        {
            var mockLogger = new Mock<IExceptionLogger>();
            RequestDelegate requestDelegate = context => { throw new Exception(); };
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, mockLogger.Object);

            await Assert.ThrowsAsync<Exception>(() => middleware.Invoke(new DefaultHttpContext()));

            mockLogger.Verify(l => l.LogAsync(It.IsAny<Exception>(), It.IsAny<DefaultHttpContext>(), CancellationToken.None), Times.Once());
        }
    }
}
