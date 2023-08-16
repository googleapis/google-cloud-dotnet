// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
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
using Google.Cloud.Diagnostics.Common.Tests.Logging;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
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
            consumer ??= new SimpleConsumer<LogEntry>();
            monitoredResource ??= MonitoredResourceBuilder.GlobalResource;
            logTarget ??= s_defaultLogTarget;
            var options = LoggingOptions.Create(logLevel, logName, labels, monitoredResource, retryOptions: retryOptions);
            var serviceContext = ServiceContextUtils.CreateServiceContext(serviceName, version);
            return new GoogleLogger(consumer, logTarget, serviceContext, options, LogName, s_clock, serviceProvider);
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
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope"))
            {
                logger.Log(LogLevel.Error, 0, LogMessage, null, Formatter);
            }

            var entry = Assert.Single(consumer.Items);
            Assert.Equal(LogMessage, entry.JsonPayload.Fields["message"].StringValue);
            Assert.Equal("scope", entry.JsonPayload.Fields["scope"].StringValue);
        }

        [Fact]
        public void BeginScope_WithFormattedScope()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope {Foo}, {Bar}", 42, "Baz"))
            {
                logger.LogError(LogMessage);
            }

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.Equal("scope 42, Baz", json["scope"].StringValue);

            var parentScopes = json["parent_scopes"].ListValue.Values;
            var parentScope0 = Assert.Single(parentScopes).StructValue.Fields;
            Assert.Equal(3, parentScope0.Count);
            Assert.Equal("42", parentScope0["Foo"].StringValue);
            Assert.Equal("Baz", parentScope0["Bar"].StringValue);
            Assert.Equal("scope {Foo}, {Bar}", parentScope0["{OriginalFormat}"].StringValue);
        }

        [Fact]
        public void BeginScope_DigitOnlyFormatParametersHaveUnderscorePrefix()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, logLevel: LogLevel.Information);
            using (logger.BeginScope("scope {0}, {1}", 42, "Baz"))
            {
                logger.LogError(LogMessage);
            }

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.Equal("scope 42, Baz", json["scope"].StringValue);
            var parentScopes = json["parent_scopes"].ListValue.Values;
            var parentScope0 = Assert.Single(parentScopes).StructValue.Fields;
            Assert.Equal(3, parentScope0.Count);
            Assert.Equal("42", parentScope0["_0"].StringValue);
            Assert.Equal("Baz", parentScope0["_1"].StringValue);
            Assert.Equal("scope {0}, {1}", parentScope0["{OriginalFormat}"].StringValue);
        }

        [Fact]
        public void BeginScope_WithNestedFormattedScope()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, logLevel: LogLevel.Information);
            using (logger.BeginScope("first {Foo}", 42))
            {
                using (logger.BeginScope("second {Bar}", "Baz"))
                {
                    logger.LogError(LogMessage);
                }
            }

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.Equal("first 42 => second Baz", json["scope"].StringValue);
            var parentScopes = json["parent_scopes"].ListValue.Values;
            Assert.Equal(2, parentScopes.Count);

            var scope0 = parentScopes[0].StructValue.Fields;
            var scope1 = parentScopes[1].StructValue.Fields;
            Assert.Equal(2, scope0.Count);
            Assert.Equal("Baz", scope0["Bar"].StringValue);
            Assert.Equal("second {Bar}", scope0["{OriginalFormat}"].StringValue);

            Assert.Equal(2, scope1.Count);
            Assert.Equal("42", scope1["Foo"].StringValue);
            Assert.Equal("first {Foo}", scope1["{OriginalFormat}"].StringValue);
        }

        [Fact]
        public void BeginScope_WithFormattedMessageAndScope()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, logLevel: LogLevel.Information);
            var message = "a {things} message with stuff";
            var logParam = "log";
            using (logger.BeginScope("scope {Foo}", 42))
            {
                logger.LogError(message, logParam);
            }

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal("a log message with stuff", json["message"].StringValue);
            Assert.Equal("scope 42", json["scope"].StringValue);

            var formatParams = json["format_parameters"].StructValue.Fields;
            Assert.Equal(2, formatParams.Count);
            Assert.Equal(logParam, formatParams["things"].StringValue);
            Assert.Equal(message, formatParams["{OriginalFormat}"].StringValue);

            var parentScopes = json["parent_scopes"].ListValue.Values;
            var parentScope0 = Assert.Single(parentScopes).StructValue.Fields;
            Assert.Equal(2, parentScope0.Count);
            Assert.Equal("42", parentScope0["Foo"].StringValue);
            Assert.Equal("scope {Foo}", parentScope0["{OriginalFormat}"].StringValue);
        }

        [Fact]
        public void BeginScope_Nested()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, logLevel: LogLevel.Information);
            using (logger.BeginScope("parent"))
            {
                using (logger.BeginScope("child"))
                {
                    logger.Log(LogLevel.Error, 0, LogMessage, null, Formatter);
                }
            }

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.Equal("parent => child", json["scope"].StringValue);
        }

        [Fact]
        public void IsEnabled()
        {
            var logger = GetLogger(new SimpleConsumer<LogEntry>(), LogLevel.Warning);
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
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer);
            logger.Log(LogLevel.Information, 0, LogMessage, s_exception, null);
            Assert.Empty(consumer.Items);
        }

        [Fact]
        public void Log_NotEnabled()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer);
            logger.Log(LogLevel.Debug, 0, LogMessage, s_exception, Formatter);
            Assert.Empty(consumer.Items);
        }

        [Fact]
        public void Log_EmptyFormattedMessage()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer);
            logger.Log(LogLevel.Debug, 0, "", null, Formatter);
            Assert.Empty(consumer.Items);
        }

        [Fact]
        public void Log()
        {
            var message = "a {things} message with stuff";
            var logStr = "log";
            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, labels, null, BaseLogName);

            logger.LogError(28, s_exception, message, logStr);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;

            Assert.Equal(new LogName(ProjectId, BaseLogName).ToString(), entry.LogName);
            Assert.Equal(LogLevel.Error.ToLogSeverity(), entry.Severity);
            Assert.True(string.IsNullOrWhiteSpace(entry.Trace));
            Assert.Equal(Timestamp.FromDateTime(s_dateTime), entry.Timestamp);
            Assert.Equal("a log message with stuff", json["message"].StringValue);
            Assert.Equal(LogName, json["log_name"].StringValue);
            Assert.Equal(28, json["event_id"].StructValue.Fields["id"].NumberValue);

            var formatParameters = json["format_parameters"].StructValue.Fields;
            Assert.Equal(2, formatParameters.Count);
            Assert.Equal(logStr, formatParameters["things"].StringValue);

            Assert.False(json.ContainsKey("scope"));
            Assert.Equal(MonitoredResourceBuilder.GlobalResource, entry.Resource);
            var label = Assert.Single(entry.Labels);
            Assert.Equal("some-key", label.Key);
            Assert.Equal("some-value", label.Value);
        }

        [Fact]
        public void Log_EventName()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, null, BaseLogName);
            var eventId = new EventId(11, "some-event");
            logger.LogError(eventId, s_exception, LogMessage);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.Equal(11, json["event_id"].StructValue.Fields["id"].NumberValue);
            Assert.Equal("some-event", json["event_id"].StructValue.Fields["name"].StringValue);
        }

        [Fact]
        public void Log_DigitOnlyFormatParametersHaveUnderscorePrefix()
        {
            var message = "a {123} message with {other} stuff";
            var logStr1 = "log";
            var logStr2 = "other-log";

            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, labels, null, BaseLogName);
            logger.LogError(28, s_exception, message, logStr1, logStr2);

            var entry = Assert.Single(consumer.Items);
            Assert.Single(entry.Labels);
            var formatParameters = entry.JsonPayload.Fields["format_parameters"].StructValue.Fields;
            Assert.Equal(3, formatParameters.Count);
            Assert.Equal(logStr1, formatParameters["_123"].StringValue);
            Assert.Equal(logStr2, formatParameters["other"].StringValue);
            Assert.Equal(message, formatParameters["{OriginalFormat}"].StringValue);
        }

        [Fact]
        public void Log_NoFormatParams()
        {
            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, null, BaseLogName);
            logger.LogError(LogMessage);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(new LogName(ProjectId, BaseLogName).ToString(), entry.LogName);
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.False(json.ContainsKey("format_parameters"));
        }

        [Fact]
        public void Log_Trace()
        {
            string traceId = "external_trace_id";
            ulong spanId = 1;
            string fullTraceName = TraceTarget.ForProject(ProjectId).GetFullTraceName(traceId);

            var services = new ServiceCollection();
            services.AddSingleton<ITraceContext>(new SimpleTraceContext(traceId, spanId, true));
            var serviceProvider = new DefaultServiceProviderFactory().CreateServiceProvider(services);

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, serviceProvider, BaseLogName);
            logger.Log(LogLevel.Error, 0, LogMessage, s_exception, Formatter);

            var entry = Assert.Single(consumer.Items);
            Assert.Equal(new LogName(ProjectId, BaseLogName).ToString(), entry.LogName);
            Assert.Equal(fullTraceName, entry.Trace);
            Assert.Equal($"{spanId:x16}", entry.SpanId);
        }

        [Fact]
        public void Log_Labels()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ILogEntryLabelProvider>(new FooLogEntryLabelProvider());
            services.AddSingleton<ILogEntryLabelProvider>(new BarLogEntryLabelProvider());
            var serviceProvider = new DefaultServiceProviderFactory().CreateServiceProvider(services);

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, serviceProvider, BaseLogName);
            logger.LogInformation(LogMessage);

            var entry = Assert.Single(consumer.Items);
            var labelFoo = entry.Labels.First();
            var labelBar = entry.Labels.Skip(1).Single();
            Assert.Equal("Foo", labelFoo.Key);
            Assert.Equal("Hello", labelFoo.Value);

            Assert.Equal("Bar", labelBar.Key);
            Assert.Equal("World", labelBar.Value);
        }

        [Fact]
        public void Log_Exception()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ILogEntryLabelProvider>(new FooLogEntryLabelProvider());
            services.AddSingleton<ILogEntryLabelProvider>(new BarLogEntryLabelProvider());
            var serviceProvider = new DefaultServiceProviderFactory().CreateServiceProvider(services);

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, serviceProvider, BaseLogName);
            logger.LogError(new EventId(11, "some-event"), new Exception("Exception message"), LogMessage);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal(LogMessage, json["message"].StringValue);
            Assert.Contains("System.Exception", json["exception"].StringValue);
            Assert.Contains("Exception message", json["exception"].StringValue);
        }

        [Fact]
        public void Log_DoesNotLogIfNullLabels()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ILogEntryLabelProvider>(new EmptyLogEntryLabelProvider());
            var serviceProvider = new DefaultServiceProviderFactory().CreateServiceProvider(services);

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, serviceProvider, BaseLogName);
            logger.LogInformation(LogMessage);

            Assert.Empty(consumer.Items);
        }

        [Fact]
        public void Log_ThrowsIfNullLabels_RetryOptionsPropagateExceptions()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ILogEntryLabelProvider>(new EmptyLogEntryLabelProvider());
            var serviceProvider = new DefaultServiceProviderFactory().CreateServiceProvider(services);

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, serviceProvider, BaseLogName, retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate));
            Assert.Throws<ArgumentNullException>(() => logger.LogInformation(LogMessage));
            Assert.Empty(consumer.Items);
        }

        [Fact]
        public void Log_Labels_DefaultLabelsFirst()
        {
            var labels = new Dictionary<string, string> { { "some-key", "some-value" } };

            var services = new ServiceCollection();
            services.AddSingleton<ILogEntryLabelProvider>(new FooLogEntryLabelProvider());
            services.AddSingleton<ILogEntryLabelProvider>(new BarLogEntryLabelProvider());
            var serviceProvider = new DefaultServiceProviderFactory().CreateServiceProvider(services);

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, labels, serviceProvider, BaseLogName);
            logger.LogInformation(LogMessage);

            var entry = Assert.Single(consumer.Items);
            Assert.Equal(new LogName(ProjectId, BaseLogName).ToString(), entry.LogName);

            var defaultLabel = entry.Labels.First();
            var labelFoo = entry.Labels.Skip(1).First();
            var labelBar = entry.Labels.Skip(2).Single();

            Assert.Equal("some-key", defaultLabel.Key);
            Assert.Equal("some-value", defaultLabel.Value);

            Assert.Equal("Foo", labelFoo.Key);
            Assert.Equal("Hello", labelFoo.Value);

            Assert.Equal("Bar", labelBar.Key);
            Assert.Equal("World", labelBar.Value);
        }

        [Fact]
        public void Log_ServiceContext()
        {
            var message = "a message with stuff";
            var logStr = "log";

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, null, BaseLogName, serviceName: "dummyService", version: "v1.0.0-alpha01");
            logger.LogError(28, s_exception, message, logStr);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            var serviceContext = json["serviceContext"].StructValue.Fields;
            Assert.Equal("a message with stuff", json["message"].StringValue);
            Assert.Equal("dummyService", serviceContext["service"].StringValue);
            Assert.Equal("v1.0.0-alpha01", serviceContext["version"].StringValue);
        }

        [Fact]
        public void Log_ServiceContext_OnlyServiceName()
        {
            var message = "a message with stuff";
            var logStr = "log";

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, null, BaseLogName, serviceName: "dummyService");
            logger.LogError(28, s_exception, message, logStr);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            var serviceContext = json["serviceContext"].StructValue.Fields;
            Assert.Equal("a message with stuff", json["message"].StringValue);
            Assert.Equal("dummyService", serviceContext["service"].StringValue);
            Assert.False(serviceContext.ContainsKey("version"));
        }

        [Fact]
        public void Log_ServiceContext_OnlyVersion()
        {
            var message = "a message with stuff";
            var logStr = "log";

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, null, BaseLogName, version: "v1.0.0-alpha01");
            logger.LogError(28, s_exception, message, logStr);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            var serviceContext = json["serviceContext"].StructValue.Fields;
            Assert.Equal("a message with stuff", json["message"].StringValue);
            Assert.False(serviceContext.ContainsKey("service"));
            Assert.Equal("v1.0.0-alpha01", serviceContext["version"].StringValue);
        }

        [Fact]
        public void Log_NoServiceContext()
        {
            var message = "a message with stuff";
            var logStr = "log";

            var consumer = new SimpleConsumer<LogEntry>();
            var logger = GetLogger(consumer, LogLevel.Information, null, null, BaseLogName);
            logger.LogError(28, s_exception, message, logStr);

            var entry = Assert.Single(consumer.Items);
            var json = entry.JsonPayload.Fields;
            Assert.Equal("a message with stuff", json["message"].StringValue);
            Assert.False(json.ContainsKey("serviceContext"));
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
