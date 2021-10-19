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
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Moq;
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
        private const string _traceId = "trace-id";
        private const ulong _spanId = 1;

        private static readonly bool _isWindows = TestEnvironment.IsWindows();
        private static readonly Struct _serviceContext = ServiceContextUtils.CreateServiceContext(_service, _version);

        public ErrorReportingContextExceptionLoggerTest()
        {
            var tracerMock = new Mock<IManagedTracer>(MockBehavior.Strict);

            tracerMock.Setup(t => t.GetCurrentTraceId()).Returns(_traceId);
            tracerMock.Setup(t => t.GetCurrentSpanId()).Returns(_spanId);
            ContextTracerManager.SetCurrentTracer(tracerMock.Object);
        }

        [Fact]
        [Obsolete("Both EventTarget.ForLogging and ErrorReportingOptions.Create are obsolete.")]
        public void Log_Compat()
        {
            var eventTarget = EventTarget.ForLogging("pid", loggingClient: new ThrowingLoggingClient());
            var options = ErrorReportingOptions.Create(eventTarget);
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                consumer, eventTarget, _serviceContext, options, null);
            logger.Log(CreateException(), new FakeContextWrapper());

            ValidateSingleEntry(consumer, _method, _uri, _userAgent, options, eventTarget);
        }

        [Fact]
        public void Log()
        {
            var eventTarget = EventTarget.ForProject("pid");
            var options = ErrorReportingOptions.CreateInstance();
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                consumer, eventTarget, _serviceContext, options, null);
            logger.Log(CreateException(), new FakeContextWrapper());

            ValidateSingleEntry(consumer, _method, _uri, _userAgent, options, eventTarget);
        }

        [Fact]
        [Obsolete("Both EventTarget.ForLogging and ErrorReportingOptions.Create are obsolete.")]
        public void Log_Simple_Compat()
        {
            var eventTarget = EventTarget.ForLogging("pid", loggingClient: new ThrowingLoggingClient());
            var options = ErrorReportingOptions.Create(eventTarget);
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                 consumer, eventTarget, _serviceContext, options, null);
            logger.Log(CreateException(), new EmptyContextWrapper());

            ValidateSingleEntry(consumer, "", "", "", options, eventTarget);
        }

        [Fact]
        public void Log_Simple()
        {
            var eventTarget = EventTarget.ForProject("pid");
            var options = ErrorReportingOptions.CreateInstance();
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                 consumer, eventTarget, _serviceContext, options, null);
            logger.Log(CreateException(), new EmptyContextWrapper());

            ValidateSingleEntry(consumer, "", "", "", options, eventTarget);
        }


        [Fact]
        [Obsolete("Both EventTarget.ForLogging and ErrorReportingOptions.Create are obsolete.")]
        public async Task LogAsync_Compat()
        {
            var eventTarget = EventTarget.ForLogging("pid", loggingClient: new ThrowingLoggingClient());
            var options = ErrorReportingOptions.Create(eventTarget);
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                consumer, eventTarget, _serviceContext, options, null);
            await logger.LogAsync(CreateException(), new FakeContextWrapper());

            ValidateSingleEntry(consumer, _method, _uri, _userAgent, options, eventTarget);
        }

        [Fact]
        public async Task LogAsync()
        {
            var eventTarget = EventTarget.ForProject("pid");
            var options = ErrorReportingOptions.CreateInstance();
            var consumer = new FakeConsumer();

            IContextExceptionLogger logger = new ErrorReportingContextExceptionLogger(
                consumer, eventTarget, _serviceContext, options, null);
            await logger.LogAsync(CreateException(), new FakeContextWrapper());

            ValidateSingleEntry(consumer, _method, _uri, _userAgent, options, eventTarget);
        }

        private void ValidateSingleEntry(FakeConsumer consumer, string method, string uri, string userAgent, ErrorReportingOptions options, EventTarget eventTarget)
        {
            var entries = consumer.Entries.ToList();
            if (entries.Count != 1)
            {
                Assert.True(false, $"Expected single matching entry. Received:\n{string.Join("\n", entries)}");
            }
            var entry = entries[0];
            var json = entry.JsonPayload?.Fields;

            Assert.Equal(eventTarget.LogTarget.GetFullLogName(options.LogName), entry.LogName);
            var currentSeconds = Timestamp.FromDateTime(DateTime.UtcNow).Seconds;
            Assert.InRange(entry.Timestamp.Seconds, currentSeconds - 10, currentSeconds);
            Assert.Equal(options.MonitoredResource, entry.Resource);
            Assert.Equal(LogSeverity.Error, entry.Severity);
            Assert.Contains(_exceptionMessage, json["message"].StringValue);

            var context = json["context"]?.StructValue?.Fields;
            var httpRequest = context["httpRequest"]?.StructValue?.Fields;
            Assert.Equal(method, httpRequest["method"].StringValue);
            Assert.Equal(uri, httpRequest["url"].StringValue);
            Assert.Equal(userAgent, httpRequest["userAgent"].StringValue);

            var reportLocation = context["reportLocation"]?.StructValue?.Fields;
            if (_isWindows)
            {
                Assert.InRange(reportLocation["lineNumber"].NumberValue, 1, 5000); // Longer than this file should ever be...
                Assert.NotEqual("", reportLocation["filePath"].StringValue);
            }
            Assert.Equal(nameof(CreateException), reportLocation["functionName"].StringValue);

            var serviceContext = json["serviceContext"]?.StructValue?.Fields;
            Assert.Equal(_service, serviceContext["service"].StringValue);
            Assert.Equal(_version, serviceContext["version"].StringValue);

            Assert.Contains(_traceId, entry.Trace);
            Assert.Equal($"{_spanId:x16}", entry.SpanId);
            Assert.True(entry.TraceSampled);
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
