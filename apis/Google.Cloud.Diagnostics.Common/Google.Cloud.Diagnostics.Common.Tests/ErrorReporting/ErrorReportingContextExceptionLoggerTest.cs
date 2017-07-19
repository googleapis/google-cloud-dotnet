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

using System;
using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Logging.V2;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ErrorReportingContextExceptionLoggerTest
    {
        private const string _service = "service";
        private const string _version = "version";
        private const string _exceptionMessage = "some message";
        private const string _method = "GET";
        private const string _uri = "https://google.com/";
        private const string _userAgent = "user-agent";
        private const int _statusCode = 409;

        private static readonly bool _isWindows = Utils.IsWindows();

        [Fact]
        public void Log()
        {
            var options = ErrorReportingOptions.Create(
                EventTarget.ForLogging("pid", loggingClient: new Mock<LoggingServiceV2Client>().Object));
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(IsContext(_method, _uri, _userAgent, _statusCode, options)));

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                mockConsumer.Object, _service, _version, options);

            logger.Log(CreateException(), new FakeContextWrapper());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Simple()
        {
            var options = ErrorReportingOptions.Create(
                EventTarget.ForLogging("pid", loggingClient: new Mock<LoggingServiceV2Client>().Object));
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(IsContext("", "", "", 0, options)));

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                 mockConsumer.Object, _service, _version, options);

            logger.Log(CreateException(), new EmptyContextWrapper());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task LogAsync()
        {
            var options = ErrorReportingOptions.Create(
                EventTarget.ForLogging("pid", loggingClient: new Mock<LoggingServiceV2Client>().Object));
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.ReceiveAsync(
                IsContext(_method, _uri, _userAgent, _statusCode, options), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                mockConsumer.Object, _service, _version, options);

            await logger.LogAsync(CreateException(), new FakeContextWrapper());

            mockConsumer.VerifyAll();
        }

        internal IEnumerable<LogEntry> IsContext(
            string method, string uri, string userAgent, int statusCode, ErrorReportingOptions options)
        {
            return Match.Create<IEnumerable<LogEntry>>(enumerable => {
                var e = enumerable.Single();
                var eventTarget = options.EventTarget;
                
                var json = e.JsonPayload?.Fields;
                var message = json["message"].StringValue;
                var context = json["context"]?.StructValue?.Fields;
                var httpRequest = context["httpRequest"]?.StructValue?.Fields;
                var methodVal = httpRequest["method"].StringValue;
                var urlVal = httpRequest["url"].StringValue;
                var userAgentVal = httpRequest["userAgent"].StringValue;
                var responseStatusCodeVal = httpRequest["responseStatusCode"].NumberValue;
                var reportLocation = context["reportLocation"]?.StructValue?.Fields;
                var filePathVal = reportLocation["filePath"].StringValue;
                var lineNumberVal = reportLocation["lineNumber"].NumberValue;
                var functionNameVal = reportLocation["functionName"].StringValue;
                var serviceContext = json["serviceContext"]?.StructValue?.Fields;
                var serviceVal = serviceContext["service"].StringValue;
                var versionVal = serviceContext["version"].StringValue;

                return e.LogName == eventTarget.LogTarget.GetFullLogName(eventTarget.LogName) &&
                    e.Timestamp.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                    e.Resource == eventTarget.MonitoredResource &&
                    e.Severity == Logging.Type.LogSeverity.Error &&
                    message.Contains(_exceptionMessage) &&
                    method.Equals(methodVal) &&
                    uri.Equals(urlVal) &&
                    userAgent.Equals(userAgentVal) &&
                    statusCode  == responseStatusCodeVal &&
                    (!_isWindows || lineNumberVal > 0) &&
                    (!_isWindows || !string.IsNullOrEmpty(filePathVal)) &&
                    nameof(CreateException).Equals(functionNameVal) &&
                    _service.Equals(serviceVal) &&
                    _version.Equals(versionVal);
            });
        }

        /// <summary>Create a thrown exception with message.</summary>
        private Exception CreateException()
        {
            try
            {
                throw new Exception(_exceptionMessage);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private class FakeContextWrapper : IContextWrapper
        {
            string IContextWrapper.GetHttpMethod() => _method;
            int IContextWrapper.GetStatusCode() => _statusCode;
            string IContextWrapper.GetUri() => _uri;
            string IContextWrapper.GetUserAgent() => _userAgent;
        }

        private class EmptyContextWrapper : IContextWrapper
        {
            string IContextWrapper.GetHttpMethod() => null;
            int IContextWrapper.GetStatusCode() => 0;
            string IContextWrapper.GetUri() => null;
            string IContextWrapper.GetUserAgent() => null;
        }
    }
}
