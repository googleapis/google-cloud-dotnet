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
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class GoogleExceptionLoggerTest
    {
        private static readonly Exception _exception = new Exception("opps..");

        [Fact]
        public void Log()
        {
            var mockAccessor = new Mock<IHttpContextAccessor>();
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleExceptionLogger(mockContextLogger.Object, mockAccessor.Object);

            logger.Log(_exception, new DefaultHttpContext());
            mockContextLogger.Verify(lb => lb.Log(_exception, It.IsAny<HttpContextWrapper>()));
        }

        [Fact]
        public void Log_NoContext()
        {
            var mockAccessor = new Mock<IHttpContextAccessor>();
            mockAccessor.Setup(a => a.HttpContext).Returns(new DefaultHttpContext());
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleExceptionLogger(mockContextLogger.Object, mockAccessor.Object);

            logger.Log(_exception);
            mockContextLogger.Verify(lb => lb.Log(_exception, It.IsAny<HttpContextWrapper>()));
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockAccessor = new Mock<IHttpContextAccessor>();
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            mockContextLogger.Setup(lb => lb.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            var logger = new GoogleExceptionLogger(mockContextLogger.Object, mockAccessor.Object);

            await logger.LogAsync(_exception, new DefaultHttpContext());
            mockContextLogger.Verify(lb => lb.LogAsync(_exception, It.IsAny<HttpContextWrapper>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task LogAsync_NoContext()
        {
            var mockAccessor = new Mock<IHttpContextAccessor>();
            mockAccessor.Setup(a => a.HttpContext).Returns(new DefaultHttpContext());
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            mockContextLogger.Setup(lb => lb.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            var logger = new GoogleExceptionLogger(mockContextLogger.Object, mockAccessor.Object);

            await logger.LogAsync(_exception);
            mockContextLogger.Verify(lb => lb.LogAsync(_exception, It.IsAny<HttpContextWrapper>(), It.IsAny<CancellationToken>()));
        }
    }
}