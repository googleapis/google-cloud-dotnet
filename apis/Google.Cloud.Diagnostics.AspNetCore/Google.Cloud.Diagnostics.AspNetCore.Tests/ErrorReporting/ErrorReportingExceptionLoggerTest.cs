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
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class ErrorReportingExceptionLoggerTest
    {
        private const string _serviceName = "SomeService";
        private const string _version = "1.0.0";
        private const string _googleHost = "www.google.com";
        private const string _userAgentValue = "user-agent-1.0";
        private static readonly string s_deleteMethod = HttpMethod.Delete.ToString();
        private static readonly string s_exceptionMessage = "some exception message";
        private const int _conflictStatusCode = StatusCodes.Status409Conflict;

        /// <summary>
        /// Matcher to check if a <see cref="ReportedErrorEvent"/> matches a 
        /// simple <see cref="HttpContext"/> and <see cref="Exception"/>.
        /// </summary>
        private IEnumerable<ReportedErrorEvent> IsSimpleContext()
        {
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.First();
                return e.Message.Contains(s_exceptionMessage) &&
                e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                string.IsNullOrEmpty(e.Context.HttpRequest.Method) &&
                e.Context.HttpRequest.Url.Contains(_googleHost) &&
                string.IsNullOrEmpty(e.Context.HttpRequest.UserAgent) &&
                e.Context.HttpRequest.ResponseStatusCode == StatusCodes.Status200OK &&
                e.Context.ReportLocation.LineNumber == 0 &&
                string.IsNullOrEmpty(e.Context.ReportLocation.FilePath) &&
                string.IsNullOrEmpty(e.Context.ReportLocation.FunctionName) &&
                e.ServiceContext.Service.Equals(_serviceName) &&
                e.ServiceContext.Version.Equals(_version);
            });
        }

        /// <summary>
        /// Matcher to check if a <see cref="ReportedErrorEvent"/> matches a 
        /// complex <see cref="HttpContext"/> and <see cref="Exception"/>.
        /// </summary>
        private IEnumerable<ReportedErrorEvent> IsComplexContext()
        {
            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.First();
                return e.Message.Contains(s_exceptionMessage) &&
                e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                e.Context.HttpRequest.Method.Equals(s_deleteMethod) &&
                e.Context.HttpRequest.Url.Contains(_googleHost) &&
                e.Context.HttpRequest.UserAgent.Equals(_userAgentValue) &&
                e.Context.HttpRequest.ResponseStatusCode == _conflictStatusCode &&
                (!isWindows || e.Context.ReportLocation.LineNumber > 0) &&
                (!isWindows || !string.IsNullOrEmpty(e.Context.ReportLocation.FilePath)) &&
                e.Context.ReportLocation.FunctionName.Equals(nameof(CreateException)) &&
                e.ServiceContext.Service.Equals(_serviceName) &&
                e.ServiceContext.Version.Equals(_version);
            });
        }

        /// <summary>
        /// Create a thrown exception.
        /// </summary>
        private Exception CreateException()
        {
            try
            {
                throw new Exception(s_exceptionMessage);
            }
            catch (Exception e)
            {
                return  e;
            }
        }

        /// <summary>
        /// Create a filled <see cref="HttpContext"/>
        /// </summary>
        private HttpContext CreateComplexContext()
        {
            var context = new DefaultHttpContext();
            var request = context.Request;
            request.Method = s_deleteMethod;
            request.Host = new HostString(_googleHost);
            request.Headers["User-Agent"] = _userAgentValue;

            var response = context.Response;
            response.StatusCode = _conflictStatusCode;

            return context;
        }
        
        [Fact]
        public async Task Report_Simple()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            var logger = ErrorReportingExceptionLogger.Create(
                mockConsumer.Object, _serviceName, _version);

            var context = new DefaultHttpContext();
            context.Request.Host = new HostString(_googleHost);

            mockConsumer.Setup(c => c.ReceiveAsync(IsSimpleContext(), default(CancellationToken)))
                .Returns(CommonUtils.CompletedTask);
            await logger.LogAsync(context, new Exception(s_exceptionMessage));
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task Report_Complex()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            var logger = ErrorReportingExceptionLogger.Create(
                mockConsumer.Object, _serviceName, _version);

            mockConsumer.Setup(c => c.ReceiveAsync(IsComplexContext(), default(CancellationToken)))
                .Returns(CommonUtils.CompletedTask);
            await logger.LogAsync(CreateComplexContext(), CreateException());
            mockConsumer.VerifyAll();
        }
    }
}
