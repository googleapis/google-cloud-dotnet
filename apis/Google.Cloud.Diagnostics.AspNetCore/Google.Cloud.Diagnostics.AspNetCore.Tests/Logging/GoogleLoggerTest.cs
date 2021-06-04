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

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.Tests
#else
#error unknown target framework
#endif
{
    public class GoogleLoggerTest
    {
        private const string LogMessage = "a log message";
        private const string LogName = "log-name";
        private const string BaseLogName = "aspnetcore";
        private const string ProjectId = "pid";
        private const string ExpectedGcpLogBaseUrl = "https://console.cloud.google.com/logs/viewer";
        private static readonly DateTime s_dateTime = DateTime.UtcNow;
        private static readonly Exception s_exception = new Exception("some message");
        private static readonly IClock s_clock = new FakeClock(s_dateTime);
        private static readonly LogTarget s_defaultLogTarget = LogTarget.ForProject(ProjectId);

        /// <summary>
        /// Function to format a string and exception.  Used to test logging.
        /// </summary>
        private string Formatter(string message, Exception ex)
            => ex == null ? message : $"{message} - {ex.Message}";

        private GoogleLogger GetLogger(
            IConsumer<LogEntry> consumer = null, LogLevel logLevel = LogLevel.Information,
            Dictionary<string, string> labels = null, IServiceProvider serviceProvider = null,
            string logName = null,
            MonitoredResource monitoredResource = null, LogTarget logTarget = null,
            RetryOptions retryOptions = null,
            string serviceName = null,
            string version = null)
        {
            consumer ??= new Mock<IConsumer<LogEntry>>(MockBehavior.Strict).Object;
            monitoredResource ??= MonitoredResourceBuilder.GlobalResource;
            logTarget ??= s_defaultLogTarget;
            LoggerOptions options = LoggerOptions.CreateWithServiceContext(
                logLevel, logName, labels, monitoredResource, retryOptions: retryOptions, serviceName: serviceName, version: version);
            return new GoogleLogger(consumer, logTarget, options, LogName, s_clock, serviceProvider);
        }

        [Fact]
        public void GetGcpConsoleLogsUrl()
        {
            GoogleLogger logger = GetLogger();
            Uri actualUrl = logger.GetGcpConsoleLogsUrl();
            string query = actualUrl.Query;

            Assert.StartsWith(ExpectedGcpLogBaseUrl, actualUrl.ToString());
            Assert.Contains("resource=global", query);
            Assert.Contains("project=pid", query);
            Assert.Contains("minLogLevel=200", query);
            Assert.Contains("logName=projects/pid/logs/aspnetcore", query);
            Assert.DoesNotContain("organizationId=", query);
        }

        [Fact]
        public void GetGcpConsoleLogsUrl_NonDefault()
        {
            GoogleLogger logger = GetLogger(logLevel: LogLevel.Error, monitoredResource: new MonitoredResource() { Type = "dummy-type"}, logName: "custom-name");
            Uri actualUrl = logger.GetGcpConsoleLogsUrl();
            string query = actualUrl.Query;

            Assert.StartsWith(ExpectedGcpLogBaseUrl, actualUrl.ToString());
            Assert.Contains("resource=dummy-type", query);
            Assert.Contains("project=pid", query);
            Assert.Contains("minLogLevel=500", query);
            Assert.Contains("logName=projects/pid/logs/custom-name", query);
            Assert.DoesNotContain("organizationId=", query);
        }

        [Fact]
        public void GetGcpConsoleLogsUrl_Organization()
        {
            GoogleLogger logger = GetLogger(logTarget: LogTarget.ForOrganization("12345"));
            string query = logger.GetGcpConsoleLogsUrl().Query;

            Assert.Contains("organizationId=12345", query);
            Assert.DoesNotContain("project=", query);
        }

        [Fact]
        public void GetGcpConsoleLogsUrl_Gae()
        {
            GoogleLogger logger = GetLogger(monitoredResource: MonitoredResourceBuilder.FromPlatform(new Platform(
                    new GaePlatformDetails("project-id", "instance", "service", "version"))));
            string query = logger.GetGcpConsoleLogsUrl().Query;

            Assert.Contains($"resource=gae_app", query);
        }

        /// <summary>
        /// See comment in production code for the purpose of this test.
        /// </summary>
        [Fact]
        public void GetGcpConsoleLogsUrl_GkeContainerToContainer()
        {
            var resource = new MonitoredResource
            {
                Type = "gke_container"
            };
            GoogleLogger logger = GetLogger(monitoredResource: resource);
            string query = logger.GetGcpConsoleLogsUrl().Query;

            Assert.Contains($"resource=container", query);
        }

        [Fact]
        public void BeginScope()
        {
            Predicate<IEnumerable<LogEntry>> matcher = (l) =>
                l.Single().JsonPayload.Fields["message"].StringValue == LogMessage &&
                l.Single().JsonPayload.Fields["scope"].StringValue == "scope";
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope"))
            {
                logger.Log(LogLevel.Error, 0, LogMessage, null, Formatter);
            }
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void BeginScope_WithFormattedScope()
        {
            Predicate<IEnumerable<LogEntry>> matcher = l =>
            {
                var json = l.Single().JsonPayload.Fields;
                var parentScopes = json["parent_scopes"].ListValue.Values;
                var parentScope0 = parentScopes[0].StructValue.Fields;
                return json["message"].StringValue == LogMessage &&
                       json["scope"].StringValue == "scope 42, Baz" &&
                       parentScopes.Count == 1 &&
                       parentScope0.Count == 3 &&
                       parentScope0["Foo"].StringValue == "42" &&
                       parentScope0["Bar"].StringValue == "Baz" &&
                       parentScope0["{OriginalFormat}"].StringValue == "scope {Foo}, {Bar}";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope {Foo}, {Bar}", 42, "Baz"))
            {
                logger.LogError(LogMessage);
            }

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void BeginScope_DigitOnlyFormatParametersHaveUnderscorePrefix()
        {
            Predicate<IEnumerable<LogEntry>> matcher = l =>
            {
                var json = l.Single().JsonPayload.Fields;
                var parentScopes = json["parent_scopes"].ListValue.Values;
                var parentScope0 = parentScopes[0].StructValue.Fields;
                return json["message"].StringValue == LogMessage &&
                       json["scope"].StringValue == "scope 42, Baz" &&
                       parentScopes.Count == 1 &&
                       parentScope0.Count == 3 &&
                       parentScope0["_0"].StringValue == "42" &&
                       parentScope0["_1"].StringValue == "Baz" &&
                       parentScope0["{OriginalFormat}"].StringValue == "scope {0}, {1}";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope {0}, {1}", 42, "Baz"))
            {
                logger.LogError(LogMessage);
            }

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void BeginScope_WithNestedFormattedScope()
        {
            Predicate<IEnumerable<LogEntry>> matcher = l =>
            {
                var json = l.Single().JsonPayload.Fields;
                var parentScopes = json["parent_scopes"].ListValue.Values;
                var scope0 = parentScopes[0].StructValue.Fields;
                var scope1 = parentScopes[1].StructValue.Fields;

                return json["message"].StringValue == LogMessage &&
                       json["scope"].StringValue == "first 42 => second Baz" &&
                       parentScopes.Count == 2 &&
                       scope0.Count == 2 &&
                       scope0["{OriginalFormat}"].StringValue == "second {Bar}" &&
                       scope0["Bar"].StringValue == "Baz" &&
                       scope1.Count == 2 &&
                       scope1["{OriginalFormat}"].StringValue == "first {Foo}" &&
                       scope1["Foo"].StringValue == "42";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, logLevel: LogLevel.Information);
            using (logger.BeginScope("first {Foo}", 42))
            {
                using (logger.BeginScope("second {Bar}", "Baz"))
                {
                    logger.LogError(LogMessage);
                }
            }

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void BeginScope_WithFormattedMessageAndScope()
        {
            var message = "a {things} message with stuff";
            var logParam = "log";

            Predicate<IEnumerable<LogEntry>> matcher = l =>
            {
                var json = l.Single().JsonPayload.Fields;
                var formatParams = json["format_parameters"].StructValue.Fields;
                var parentScopes = json["parent_scopes"].ListValue.Values;
                var parentScope0 = parentScopes[0].StructValue.Fields;
                return json["message"].StringValue == "a log message with stuff" &&
                       json["scope"].StringValue == "scope 42" &&
                       formatParams.Count == 2 &&
                       formatParams["things"].StringValue == logParam &&
                       formatParams["{OriginalFormat}"].StringValue == message &&
                       parentScopes.Count == 1 &&
                       parentScope0.Count == 2 &&
                       parentScope0["Foo"].StringValue == "42" &&
                       parentScope0["{OriginalFormat}"].StringValue == "scope {Foo}";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope {Foo}", 42))
            {
                logger.LogError(message, logParam);
            }

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void BeginScope_Nested()
        {
            Predicate<IEnumerable<LogEntry>> matcher = (l) =>
                l.Single().JsonPayload.Fields["message"].StringValue == LogMessage &&
                l.Single().JsonPayload.Fields["scope"].StringValue == "parent => child";
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information);
            using (logger.BeginScope("parent"))
            {
                using (logger.BeginScope("child"))
                {
                    logger.Log(LogLevel.Error, 0, LogMessage, null, Formatter);
                }
            }
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void IsEnabled()
        {
            var logger = GetLogger(new Mock<IConsumer<LogEntry>>().Object, LogLevel.Warning);
            Assert.False(logger.IsEnabled(LogLevel.Trace));
            Assert.False(logger.IsEnabled(LogLevel.Debug));
            Assert.False(logger.IsEnabled(LogLevel.Information));
            Assert.True(logger.IsEnabled(LogLevel.Warning));
            Assert.True(logger.IsEnabled(LogLevel.Error));
            Assert.True(logger.IsEnabled(LogLevel.Critical));
            Assert.True(logger.IsEnabled(LogLevel.None));
        }

        [Fact]
        public void Log_NullFormatter()
        {
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object);
            logger.Log(LogLevel.Information, 0, LogMessage, s_exception, null);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never());
        }

        [Fact]
        public void Log_NotEnabled()
        {
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object);
            logger.Log(LogLevel.Debug, 0, LogMessage, s_exception, Formatter);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never());
        }

        [Fact]
        public void Log_EmptyFormattedMessage()
        {
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object);
            logger.Log(LogLevel.Debug, 0, "", null, Formatter);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never());
        }

        [Fact]
        public void Log()
        {
            var message = "a {things} message with stuff";
            var logStr = "log";

            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };
            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                KeyValuePair<string, string> label = entry.Labels.Single();
                var json = entry.JsonPayload.Fields;
                return entry.LogName == new LogName(ProjectId, BaseLogName).ToString() &&
                    entry.Severity == LogLevel.Error.ToLogSeverity() &&
                    string.IsNullOrWhiteSpace(entry.Trace) &&
                    entry.Timestamp.Equals(Timestamp.FromDateTime(s_dateTime)) &&
                    json["message"].StringValue == "a log message with stuff" &&
                    json["log_name"].StringValue == LogName &&
                    json["event_id"].StructValue.Fields["id"].NumberValue == 28 &&
                    json["format_parameters"].StructValue.Fields.Count == 2 &&
                    json["format_parameters"].StructValue.Fields["things"].StringValue == logStr &&
                    !json.ContainsKey("scope") &&
                    entry.Resource.Equals(MonitoredResourceBuilder.GlobalResource) &&
                    label.Key == "some-key" &&
                    label.Value == "some-value";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, labels, null, BaseLogName);
            logger.LogError(28, s_exception, message, logStr);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_EventName()
        {
            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var json = entry.JsonPayload.Fields;
                return entry.LogName == new LogName(ProjectId, BaseLogName).ToString() &&
                    json["message"].StringValue == LogMessage &&
                    json["event_id"].StructValue.Fields["id"].NumberValue == 11 &&
                    json["event_id"].StructValue.Fields["name"].StringValue == "some-event";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, null, null, BaseLogName);
            var eventId = new EventId(11, "some-event");
            logger.LogError(eventId, s_exception, LogMessage);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_DigitOnlyFormatParametersHaveUnderscorePrefix()
        {
            var message = "a {123} message with {other} stuff";
            var logStr1 = "log";
            var logStr2 = "other-log";

            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };
            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                KeyValuePair<string, string> label = entry.Labels.Single();
                var formatParameters = entry.JsonPayload.Fields["format_parameters"].StructValue.Fields;
                return formatParameters.Count == 3 &&
                    formatParameters["_123"].StringValue == logStr1 &&
                    formatParameters["other"].StringValue == logStr2 &&
                    formatParameters["{OriginalFormat}"].StringValue == message;
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, labels, null, BaseLogName);
            logger.LogError(28, s_exception, message, logStr1, logStr2);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_NoFormatParams()
        {
            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var json = entry.JsonPayload.Fields;
                return entry.LogName == new LogName(ProjectId, BaseLogName).ToString() &&
                    json["message"].StringValue == LogMessage &&
                    !json.ContainsKey("format_parameters");
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, null, null, BaseLogName);
            logger.LogError(LogMessage);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Trace()
        {
            string traceId = "external_trace_id";
            string spanId = "external_span_id";
            string fullTraceName = TraceTarget.ForProject(ProjectId).GetFullTraceName(traceId);

            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                return entry.LogName == new LogName(ProjectId, BaseLogName).ToString() &&
                    entry.Trace == fullTraceName &&
                    entry.SpanId == spanId;
            };

            var mockServiceProvider = new Mock<IServiceProvider>();
            var mockExternalTraceProvider = new Mock<IExternalTraceProvider>();
            mockServiceProvider.Setup(sp => sp.GetService(typeof(IExternalTraceProvider))).Returns(mockExternalTraceProvider.Object);
            mockExternalTraceProvider.Setup(
                sp => sp.GetCurrentTraceContext(It.IsAny<IServiceProvider>()))
                .Returns(new TraceContextForLogEntry(traceId, spanId));

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, serviceProvider: mockServiceProvider.Object, logName: BaseLogName);
            logger.Log(LogLevel.Error, 0, LogMessage, s_exception, Formatter);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Labels()
        {
            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var labelFoo = entry.Labels.First();
                var labelBar = entry.Labels.Skip(1).Single();

                return entry.LogName == new LogName(ProjectId, BaseLogName).ToString() &&
                    labelFoo.Key == "Foo" &&
                    labelFoo.Value == "Hello" &&
                    labelBar.Key == "Bar" &&
                    labelBar.Value == "World";
            };

            var mockServiceProvider = new Mock<IServiceProvider>();
            mockServiceProvider.Setup(sp => sp.GetService(typeof(IEnumerable<ILogEntryLabelProvider>)))
                .Returns(new ILogEntryLabelProvider[] { new FooLogEntryLabelProvider(), new BarLogEntryLabelProvider() });

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, serviceProvider: mockServiceProvider.Object, logName: BaseLogName);
            logger.LogInformation(LogMessage);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Exception()
        {
            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                return entry.JsonPayload.Fields.TryGetValue("message", out var message) &&
                    message.StringValue == LogMessage &&
                    entry.JsonPayload.Fields.TryGetValue("exception", out var exception) &&
                    exception.StringValue.Contains("System.Exception") &&
                    exception.StringValue.Contains("Exception message");
            };

            var mockServiceProvider = new Mock<IServiceProvider>();
            mockServiceProvider.Setup(sp => sp.GetService(typeof(IEnumerable<ILogEntryLabelProvider>)))
                .Returns(new ILogEntryLabelProvider[] { new FooLogEntryLabelProvider(), new BarLogEntryLabelProvider() });

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            ILogger logger = GetLogger(mockConsumer.Object, LogLevel.Information, serviceProvider: mockServiceProvider.Object, logName: BaseLogName);
            logger.LogError(new EventId(11, "some-event"), new Exception("Exception message"), LogMessage);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_DoesNotLogIfNullLabels()
        {
            var mockServiceProvider = new Mock<IServiceProvider>();
            mockServiceProvider.Setup(sp => sp.GetService(typeof(IEnumerable<ILogEntryLabelProvider>)))
                .Returns(new ILogEntryLabelProvider[] { new EmptyLogEntryLabelProvider() });

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, serviceProvider: mockServiceProvider.Object, logName: BaseLogName);
            logger.LogInformation(LogMessage);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never);
        }

        [Fact]
        public void Log_ThrowsIfNullLabels_RetryOptionsPropagateExceptions()
        {
            var mockServiceProvider = new Mock<IServiceProvider>();
            mockServiceProvider.Setup(sp => sp.GetService(typeof(IEnumerable<ILogEntryLabelProvider>)))
                .Returns(new ILogEntryLabelProvider[] { new EmptyLogEntryLabelProvider() });

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, serviceProvider: mockServiceProvider.Object, logName: BaseLogName, retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate));
            Assert.Throws<ArgumentNullException>(() => logger.LogInformation(LogMessage));
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never);
        }

        [Fact]
        public void Log_Labels_DefaultLabelsFirst()
        {
            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };

            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();

                var defaultLabel = entry.Labels.First();
                var labelFoo = entry.Labels.Skip(1).First();
                var labelBar = entry.Labels.Skip(2).Single();

                return entry.LogName == new LogName(ProjectId, BaseLogName).ToString() &&
                    defaultLabel.Key == "some-key" &&
                    defaultLabel.Value == "some-value" &&
                    labelFoo.Key == "Foo" &&
                    labelFoo.Value == "Hello" &&
                    labelBar.Key == "Bar" &&
                    labelBar.Value == "World";
            };

            var mockServiceProvider = new Mock<IServiceProvider>();
            mockServiceProvider.Setup(sp => sp.GetService(typeof(IEnumerable<ILogEntryLabelProvider>)))
                .Returns(new ILogEntryLabelProvider[] { new FooLogEntryLabelProvider(), new BarLogEntryLabelProvider() });

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information, labels: labels, serviceProvider: mockServiceProvider.Object, logName: BaseLogName);
            logger.LogInformation(LogMessage);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_ServiceContext()
        {
            var message = "a message with stuff";
            var logStr = "log";

            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var json = entry.JsonPayload.Fields;
                return json["message"].StringValue == "a message with stuff" &&
                    json["serviceContext"].StructValue.Fields["service"].StringValue == "dummyService" &&
                    json["serviceContext"].StructValue.Fields["version"].StringValue == "v1.0.0-alpha01";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(
                mockConsumer.Object, LogLevel.Information, null, null, BaseLogName, serviceName: "dummyService", version: "v1.0.0-alpha01");
            logger.LogError(28, s_exception, message, logStr);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_ServiceContext_OnlyServiceName()
        {
            var message = "a message with stuff";
            var logStr = "log";

            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var json = entry.JsonPayload.Fields;
                return json["message"].StringValue == "a message with stuff" &&
                    json["serviceContext"].StructValue.Fields["service"].StringValue == "dummyService" &&
                    !json["serviceContext"].StructValue.Fields.ContainsKey("version");
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(
                mockConsumer.Object, LogLevel.Information, null, null, BaseLogName, serviceName: "dummyService");
            logger.LogError(28, s_exception, message, logStr);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_ServiceContext_OnlyVersion()
        {
            var message = "a message with stuff";
            var logStr = "log";

            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var json = entry.JsonPayload.Fields;
                return json["message"].StringValue == "a message with stuff" &&
                    !json["serviceContext"].StructValue.Fields.ContainsKey("service") &&
                    json["serviceContext"].StructValue.Fields["version"].StringValue == "v1.0.0-alpha01";
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(
                mockConsumer.Object, LogLevel.Information, null, null, BaseLogName, version: "v1.0.0-alpha01");
            logger.LogError(28, s_exception, message, logStr);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_NoServiceContext()
        {
            var message = "a message with stuff";
            var logStr = "log";

            Predicate<IEnumerable<LogEntry>> matcher = logEntries =>
            {
                LogEntry entry = logEntries.Single();
                var json = entry.JsonPayload.Fields;
                return json["message"].StringValue == "a message with stuff" &&
                    !json.ContainsKey("serviceContext");
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(
                mockConsumer.Object, LogLevel.Information, null, null, BaseLogName);
            logger.LogError(28, s_exception, message, logStr);
            mockConsumer.VerifyAll();
        }
    }

    internal class FooLogEntryLabelProvider : ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Foo"] = "Hello";
        }
    }

    internal class BarLogEntryLabelProvider : ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Bar"] = "World";
        }
    }

    internal class EmptyLogEntryLabelProvider : ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Null"] = null;
            labels["Empty"] = string.Empty;
        }
    }
}
