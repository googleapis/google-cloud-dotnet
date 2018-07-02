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

using Google.Cloud.Diagnostics.Common;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class GoogleWebApiExceptionLoggerTest
    {
        private static readonly Exception _exception = new Exception("oops...");
        private static readonly HttpActionContext _context = new HttpActionContext();

        [Fact]
        public void Log()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleWebApiExceptionLogger(mockContextLogger.Object);

            logger.Log(_exception, _context);
            mockContextLogger.Verify(lb => lb.Log(_exception, It.IsNotNull<HttpActionContextWrapper>()));
        }

        [Fact]
        public void Log_NoContext()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleWebApiExceptionLogger(mockContextLogger.Object);

            logger.Log(_exception);
            mockContextLogger.Verify(lb => lb.Log(_exception, It.IsNotNull<HttpActionContextWrapper>()));
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleWebApiExceptionLogger(mockContextLogger.Object);
            mockContextLogger.Setup(lb => lb.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));

            await logger.LogAsync(_exception, _context);
            mockContextLogger.Verify(lb => lb.LogAsync(_exception, It.IsNotNull<HttpActionContextWrapper>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task LogAsync_NoContext()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleWebApiExceptionLogger(mockContextLogger.Object);
            mockContextLogger.Setup(lb => lb.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));

            await logger.LogAsync(_exception);
            mockContextLogger.Verify(lb => lb.LogAsync(_exception, It.IsNotNull<HttpActionContextWrapper>(), It.IsAny<CancellationToken>()));
        }
    }
}
