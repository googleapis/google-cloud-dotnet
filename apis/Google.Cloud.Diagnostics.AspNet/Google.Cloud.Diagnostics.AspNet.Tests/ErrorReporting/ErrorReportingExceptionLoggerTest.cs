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
using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.ErrorReporting.V1Beta1;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ErrorReportingExceptionLoggerTest
    {
        private static readonly ErrorReportingMatching s_matcher = 
            new ErrorReportingMatching(ErrorReportingUtils.IsWindows, defaultMethod: "GET");

        private static readonly ProductInfoHeaderValue s_userAgentValue = 
            new ProductInfoHeaderValue(ErrorReportingMatching.UserAgentKey, ErrorReportingMatching.UserAgentValue);

        /// <summary>
        /// An <see cref="ExceptionContext"/> that matches expected 
        /// context of <see cref="ErrorReportingMatching.IsSimpleContext"/>.
        /// </summary>
        private static readonly ExceptionLoggerContext s_simpleContext =
            new ExceptionLoggerContext(new ExceptionContext(
                new Exception(ErrorReportingMatching.ExceptionMessage),
                    ExceptionCatchBlocks.HttpServer, new HttpRequestMessage()));

        /// <summary>
        /// Creates an <see cref="ExceptionLoggerContext"/> that matches expected 
        /// context of <see cref="ErrorReportingMatching.IsComplexContext"/>.
        /// </summary>
        private ExceptionLoggerContext CreateComplexContext()
        {
            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = new HttpMethod(ErrorReportingMatching.DeleteMethod);
            requestMessage.RequestUri = ErrorReportingMatching.GoogleUri;
            requestMessage.Headers.UserAgent.Add(s_userAgentValue);

            var responseMessage = new HttpResponseMessage();
            responseMessage.StatusCode = (HttpStatusCode)ErrorReportingMatching.ConflictStatusCode;

            var exceptionContext = new ExceptionContext(
                s_matcher.CreateException(), ExceptionCatchBlocks.HttpServer, requestMessage, responseMessage);
            return new ExceptionLoggerContext(exceptionContext);
        }

        private ErrorReportingExceptionLogger CreateLogger(IConsumer<ReportedErrorEvent> consumer)
        {
            var loggerBase = new ErrorReportingExceptionLoggerBase(consumer, ErrorReportingMatching.ServiceName, ErrorReportingMatching.VersionName);
            return new ErrorReportingExceptionLogger(loggerBase);
        }

        [Fact]
        public void ShouldLog()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();

            var logger = CreateLogger(mockConsumer.Object);

            Assert.True(logger.ShouldLog(s_simpleContext));
            Assert.False(logger.ShouldLog(null));
        }

        [Fact]
        public void Log()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(s_matcher.IsComplexContext()));

            var logger = CreateLogger(mockConsumer.Object);
            logger.Log(CreateComplexContext());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Simple()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(s_matcher.IsSimpleContext()));

            var logger = CreateLogger(mockConsumer.Object);
            logger.Log(s_simpleContext);

            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.ReceiveAsync(s_matcher.IsComplexContext(), default(CancellationToken)))
                .Returns(Task.FromResult(new ReportErrorEventResponse()));

            var logger = CreateLogger(mockConsumer.Object);
            await logger.LogAsync(CreateComplexContext(), CancellationToken.None);

            mockConsumer.VerifyAll();
        }
    }
}