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
using Google.Cloud.ErrorReporting.V1Beta1;
using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using System.Threading;
using System.Threading.Tasks;

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
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(IsContext(_method, _uri, _userAgent, _statusCode)));

            IContextExceptionLogger logger =
                new ErrorReportingContextExceptionLogger(mockConsumer.Object, _service, _version);

            logger.Log(CreateException(), new FakeContextWrapper());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Simple()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(IsContext("", "", "", 0)));

            IContextExceptionLogger logger =
                new ErrorReportingContextExceptionLogger(mockConsumer.Object, _service, _version);

            logger.Log(CreateException(), new EmptyContextWrapper());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.ReceiveAsync(
                IsContext(_method, _uri, _userAgent, _statusCode), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));

            IContextExceptionLogger logger =
                new ErrorReportingContextExceptionLogger(mockConsumer.Object, _service, _version);

            await logger.LogAsync(CreateException(), new FakeContextWrapper());

            mockConsumer.VerifyAll();
        }

        internal IEnumerable<ReportedErrorEvent> IsContext(string method, string uri, string userAgent, int statusCode)
        {
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.Single();
                return e.Message.Contains(_exceptionMessage) &&
                    e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                    e.Context.HttpRequest.Method.Equals(method) &&
                    e.Context.HttpRequest.Url.Contains(uri) &&
                    e.Context.HttpRequest.UserAgent.Equals(userAgent) &&
                    e.Context.HttpRequest.ResponseStatusCode == statusCode &&
                    (!_isWindows || e.Context.ReportLocation.LineNumber > 0) &&
                    (!_isWindows || !string.IsNullOrEmpty(e.Context.ReportLocation.FilePath)) &&
                    e.Context.ReportLocation.FunctionName.Equals(nameof(CreateException)) &&
                    e.ServiceContext.Service.Equals(_service) &&
                    e.ServiceContext.Version.Equals(_version);
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
