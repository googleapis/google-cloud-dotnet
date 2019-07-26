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

using Google.Cloud.ClientTesting;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

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

        private static readonly bool _isWindows = TestEnvironment.IsWindows();

        [Fact]
        public void Log()
        {
            var options = ErrorReportingOptions.Create(
                EventTarget.ForLogging("pid", loggingClient: new ThrowingLoggingClient()));
            var consumer = new FakeConsumer();
            
            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                consumer, _service, _version, options);
            logger.Log(CreateException(), new FakeContextWrapper());

            ValidateSingleEntry(consumer, _method, _uri, _userAgent, options);
        }

        [Fact]
        public void Log_Simple()
        {
            var options = ErrorReportingOptions.Create(
                EventTarget.ForLogging("pid", loggingClient: new ThrowingLoggingClient()));
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                 consumer, _service, _version, options);
            logger.Log(CreateException(), new EmptyContextWrapper());

            ValidateSingleEntry(consumer, "", "", "", options);
        }

        [Fact]
        public async Task LogAsync()
        {
            var options = ErrorReportingOptions.Create(
                EventTarget.ForLogging("pid", loggingClient: new ThrowingLoggingClient()));
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                consumer, _service, _version, options);
            await logger.LogAsync(CreateException(), new FakeContextWrapper());

            ValidateSingleEntry(consumer, _method, _uri, _userAgent, options);
        }

        private void ValidateSingleEntry(FakeConsumer consumer, string method, string uri, string userAgent, ErrorReportingOptions options)
        {
            var entries = consumer.Entries.ToList();
            if (entries.Count == 1 && Matches(entries[0], method, uri, userAgent, options))
            {
                return;
            }
            Assert.True(false, $"Expected single matching entry. Received:\n{string.Join("\n", entries)}");
        }

        private bool Matches(LogEntry entry, string method, string uri, string userAgent, ErrorReportingOptions options)
        {
            var json = entry.JsonPayload?.Fields;
            var eventTarget = options.EventTarget;
            
            var message = json["message"].StringValue;
            var context = json["context"]?.StructValue?.Fields;
            var httpRequest = context["httpRequest"]?.StructValue?.Fields;
            var methodVal = httpRequest["method"].StringValue;
            var urlVal = httpRequest["url"].StringValue;
            var userAgentVal = httpRequest["userAgent"].StringValue;
            var reportLocation = context["reportLocation"]?.StructValue?.Fields;
            var filePathVal = reportLocation["filePath"].StringValue;
            var lineNumberVal = reportLocation["lineNumber"].NumberValue;
            var functionNameVal = reportLocation["functionName"].StringValue;
            var serviceContext = json["serviceContext"]?.StructValue?.Fields;
            var serviceVal = serviceContext["service"].StringValue;
            var versionVal = serviceContext["version"].StringValue;

            return entry.LogName == eventTarget.LogTarget.GetFullLogName(eventTarget.LogName) &&
                entry.Timestamp.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                entry.Resource == eventTarget.MonitoredResource &&
                entry.Severity == Logging.Type.LogSeverity.Error &&
                message.Contains(_exceptionMessage) &&
                method.Equals(methodVal) &&
                uri.Equals(urlVal) &&
                userAgent.Equals(userAgentVal) &&
                (!_isWindows || lineNumberVal > 0) &&
                (!_isWindows || !string.IsNullOrEmpty(filePathVal)) &&
                nameof(CreateException).Equals(functionNameVal) &&
                _service.Equals(serviceVal) &&
                _version.Equals(versionVal);
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
            string IContextWrapper.GetUri() => _uri;
            string IContextWrapper.GetUserAgent() => _userAgent;
        }

        private class EmptyContextWrapper : IContextWrapper
        {
            string IContextWrapper.GetHttpMethod() => null;
            string IContextWrapper.GetUri() => null;
            string IContextWrapper.GetUserAgent() => null;
        }

        private class FakeConsumer : IConsumer<LogEntry>
        {
            internal ConcurrentBag<LogEntry> Entries { get; } = new ConcurrentBag<LogEntry>();

            public void Dispose()
            {
            }

            public void Receive(IEnumerable<LogEntry> items)
            {
                foreach (var item in items)
                {
                    Entries.Add(item);
                }
            }

            public Task ReceiveAsync(IEnumerable<LogEntry> items, CancellationToken cancellationToken = default)
            {
                Receive(items);
                return Task.CompletedTask;
            }
        }

        /// <summary>
        /// Logging client that will just throw if any methods are called.
        /// </summary>
        private class ThrowingLoggingClient : LoggingServiceV2Client
        {
        }
    }
}
