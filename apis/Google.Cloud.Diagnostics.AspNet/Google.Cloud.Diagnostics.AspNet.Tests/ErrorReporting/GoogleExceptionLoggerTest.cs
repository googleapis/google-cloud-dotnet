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
using Xunit;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class GoogleExceptionLoggerTest
    {
        private static readonly Exception _exception = new Exception("opps...");
        private static readonly HttpRequest _request = new HttpRequest("filename.cs", "http://google.com", "");
        private static readonly HttpResponse _response = new HttpResponse(new StreamWriter(new MemoryStream()));
        private static readonly HttpContext _context = new HttpContext(_request, _response);

        [Fact]
        public void Log()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleExceptionLogger(mockContextLogger.Object);

            logger.Log(_exception, _context);
            mockContextLogger.Verify(lb => lb.Log(_exception, It.IsAny<HttpContextWrapper>()));
        }

        [Fact]
        public void Log_NoContext()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleExceptionLogger(mockContextLogger.Object);
            HttpContext.Current = _context;

            logger.Log(_exception);
            mockContextLogger.Verify(lb => lb.Log(_exception, It.IsAny<HttpContextWrapper>()));
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleExceptionLogger(mockContextLogger.Object);
            mockContextLogger.Setup(lb => lb.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));

            await logger.LogAsync(_exception, _context);
            mockContextLogger.Verify(lb => lb.LogAsync(_exception, It.IsAny<HttpContextWrapper>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task LogAsync_NoContext()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new GoogleExceptionLogger(mockContextLogger.Object);
            mockContextLogger.Setup(lb => lb.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));
            HttpContext.Current = _context;

            await logger.LogAsync(_exception);
            mockContextLogger.Verify(lb => lb.LogAsync(_exception, It.IsAny<HttpContextWrapper>(), It.IsAny<CancellationToken>()));
        }
    }
}
