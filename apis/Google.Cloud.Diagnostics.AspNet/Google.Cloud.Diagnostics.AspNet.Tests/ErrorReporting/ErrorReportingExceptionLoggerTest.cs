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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using Google.Cloud.Diagnostics.Common;
using Moq;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ErrorReportingExceptionLoggerTest
    {
        /// <summary>An <see cref="ExceptionContext"/>.</summary>
        private static readonly ExceptionLoggerContext s_simpleContext =
            new ExceptionLoggerContext(new ExceptionContext(
                new Exception(), ExceptionCatchBlocks.HttpServer, new HttpRequestMessage()));

        [Fact]
        public void ShouldLog()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new ErrorReportingExceptionLogger(mockContextLogger.Object);

            Assert.True(logger.ShouldLog(s_simpleContext));
            Assert.False(logger.ShouldLog(null));
        }

        [Fact]
        public void Log()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            var logger = new ErrorReportingExceptionLogger(mockContextLogger.Object);

            logger.Log(s_simpleContext);
            mockContextLogger.Verify(cl => cl.Log(s_simpleContext.Exception, It.IsAny<ExceptionLoggerContextWrapper>()));
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockContextLogger = new Mock<IContextExceptionLogger>();
            mockContextLogger.Setup(cl => cl.LogAsync(
                It.IsAny<Exception>(), It.IsAny<IContextWrapper>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));
            var logger = new ErrorReportingExceptionLogger(mockContextLogger.Object);

            await logger.LogAsync(s_simpleContext, CancellationToken.None);
            mockContextLogger.Verify(cl => cl.LogAsync(
                s_simpleContext.Exception, It.IsAny<ExceptionLoggerContextWrapper>(), It.IsAny<CancellationToken>()));
        }
    }
}