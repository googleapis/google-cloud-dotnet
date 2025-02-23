// Copyright 2020 Google LLC
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

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using Xunit;

namespace Google.Cloud.Logging.Console.Tests;

public class GoogleCloudConsoleFormatterTest
{
    // The expected Json string for a simple log entry with no trace information and no scope information, comprising of just message, category and severity.
    private const string ExpectedSimpleLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\"}\n";

    [Fact]
    public void SimplestLog()
    {
        var actualJson = LogSimpleLogEntry();
        Assert.Equal(ExpectedSimpleLogEntryJson, actualJson);
    }

    [Fact]
    public void InvalidLogLevel_Throws()
    {
        var formatter = CreateFormatter();
        var logEntry = new LogEntry<string>((LogLevel)8, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
        var writer = new StringWriter { NewLine = "\n" };

        Assert.Throws<ArgumentOutOfRangeException>(() => formatter.Write(logEntry, scopeProvider: null, writer));
    }

    [Fact]
    public void NoMessageAndNoException_EmptyMessage()
    {
        var formatter = CreateFormatter();
        var logEntry = new LogEntry<string>(LogLevel.Debug, "LogCategory", new EventId(1), null, exception: null, (state, exception) => state);
        var writer = new StringWriter { NewLine = "\n" };
        formatter.Write(logEntry, scopeProvider: null, writer);

        var expectedJson = "{\"message\":\"\",\"category\":\"LogCategory\",\"severity\":\"DEBUG\"}\n";
        var actualJson = writer.ToString();

        Assert.Equal(expectedJson, actualJson);
    }

    [Fact]
    public void Log_CorrectScopeInformation()
    {
        var options = new GoogleCloudConsoleFormatterOptions { IncludeScopes = true };

        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push("Inner Scope");

        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"scopes\":[\"Inner Scope\"]}\n";
        var actualJson = LogSimpleLogEntry(options, scopeProvider);

        Assert.Equal(expectedJson, actualJson);
    }

    [Fact]
    public void Log_EmptyScopeArrayIsIgnored()
    {
        var options = new GoogleCloudConsoleFormatterOptions { IncludeScopes = true };

        var scopeProvider = new LoggerExternalScopeProvider();
        var actualJson = LogSimpleLogEntry(options, scopeProvider);

        Assert.Equal(ExpectedSimpleLogEntryJson, actualJson);
    }

    [Fact]
    public void Log_KeyValuePair()
    {
        var formatter = CreateFormatter();

        var _state = new ReadOnlyCollection<KeyValuePair<string, object>>(new List<KeyValuePair<string, object>>
        {
            new KeyValuePair<string, object>("A", "Sample value 1"),
            new KeyValuePair<string, object>("B", "Sample value 2"),
        });

        var logEntry = new LogEntry<IReadOnlyCollection<KeyValuePair<string, object>>>(LogLevel.Information, "LogCategory", new EventId(1), _state, exception: null, (state, exception) => state.ToString());
        var writer = new StringWriter { NewLine = "\n" };

        formatter.Write(logEntry, scopeProvider: null, writer);

        var actualJson = writer.ToString();

        var actualState = JsonDocument.Parse(actualJson);
        var actualValueA = actualState.RootElement.GetProperty("format_parameters").GetProperty("A").GetString();
        var actualValueB = actualState.RootElement.GetProperty("format_parameters").GetProperty("B").GetString();

        Assert.Equal("Sample value 1", actualValueA);
        Assert.Equal("Sample value 2", actualValueB);
    }

    [Fact]
    public void ConsoleLoggerOptions_OptionChange_IsReloaded()
    {
        var monitor = new TestFormatterOptionsMonitor<GoogleCloudConsoleFormatterOptions>(new GoogleCloudConsoleFormatterOptions());
        var formatter = new GoogleCloudConsoleFormatter(monitor);
        var scopeProvider = new LoggerExternalScopeProvider();

        var logEntry = new LogEntry<string>(LogLevel.Information, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
        var writer = new StringWriter { NewLine = "\n" };
        formatter.Write(logEntry, scopeProvider: scopeProvider, writer);
        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\"}\n";
        var actualJson = writer.ToString();

        Assert.Equal(expectedJson, actualJson);

        monitor.Set(new GoogleCloudConsoleFormatterOptions { IncludeScopes = true });

        var writerScope = new StringWriter { NewLine = "\n" };
        using (scopeProvider.Push('x'))
        {
            formatter.Write(logEntry, scopeProvider: scopeProvider, writerScope);
        }
        var actualJsonWithScope = writerScope.ToString();
        var expectedJsonWithScope = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"scopes\":[\"x\"]}\n";

        Assert.Equal(expectedJsonWithScope, actualJsonWithScope);
    }

    [Fact]
    public void ConsoleLoggerOptions_NoProjectId_TraceInformationIsNotLogged()
    {
        // TraceGoogleCloudProjectId is not set.

        using var activity = new Activity("my-activity").Start();
        var actualJson = LogSimpleLogEntry();

        Assert.Equal(ExpectedSimpleLogEntryJson, actualJson);
    }

    [Fact]
    public void Log_NoActivity_TraceInformationIsNotLogged()
    {
        // Set the TraceGoogleCloudProjectId.
        var options = new GoogleCloudConsoleFormatterOptions { TraceGoogleCloudProjectId = "my-project-id" };

        // Since we haven't started an activity, Activity.Current will be null.
        var actualJson = LogSimpleLogEntry(options);

        Assert.Equal(ExpectedSimpleLogEntryJson, actualJson);
    }

    [Fact]
    public void Log_TraceInformationIsLogged()
    {
        // Trace information is logged, only if:
        // 1. TraceGoogleCloudProjectId is set.
        // 2. Activity.Current is not null; and
        // 3. Activity.Current.TraceId does not have the default value.

        // Set the TraceGoogleCloudProjectId.
        string traceProjectId = "my-project-id";
        var options = new GoogleCloudConsoleFormatterOptions { TraceGoogleCloudProjectId = traceProjectId };

        // Start an activity.
        using var activity = new Activity("my-activity").Start();

        // JsonWriter writes boolean as JSON literal true or false.
        // We could use JsonConvert but for tests, direct literal is easy and simpler.
        var expectedTraceSampled = activity.Recorded ? "true" : "false";

        var expectedJson = $"{{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"logging.googleapis.com/trace\":\"projects/{traceProjectId}/traces/{activity.TraceId}\",\"logging.googleapis.com/spanId\":\"{activity.SpanId}\",\"logging.googleapis.com/trace_sampled\":{expectedTraceSampled}}}\n";
        var actualJson = LogSimpleLogEntry(options);

        Assert.Equal(expectedJson, actualJson);
    }

    public class SimpleAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        /// <summary>
        /// Augment with a simple key-value pair.
        /// </summary>
        public void AugmentFormattedLogEntry<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, Utf8JsonWriter writer)
        {
            writer.WriteString("simple_key", "simple_value");
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions simpleOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new SimpleAugmenter() };

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_SimplestLog()
    {
        var expectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"simple_key\":\"simple_value\"}\n";

        var actualJson = LogSimpleLogEntry(simpleOptions);
        Assert.Equal(expectedAugmentedLogEntryJson, actualJson);
    }

    public class ComplexAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        /// <summary>
        /// Augment with a complex object.
        /// </summary>
        public void AugmentFormattedLogEntry<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, Utf8JsonWriter writer)
        {
            writer.WriteStartObject("complex_key");
            writer.WriteString("nested_key", "nested_value");
            writer.WriteEndObject();
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions complexOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new ComplexAugmenter() };

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_ComplexLog()
    {
        var expectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"complex_key\":{\"nested_key\":\"nested_value\"}}\n";

        var actualJson = LogSimpleLogEntry(complexOptions);
        Assert.Equal(expectedAugmentedLogEntryJson, actualJson);
    }

    public class FlatScopeAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        /// <summary>
        /// Augment with scope information.
        /// </summary>
        public void AugmentFormattedLogEntry<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, Utf8JsonWriter writer)
        {
            writer.WriteStartArray("augmentedScopes");
            scopeProvider.ForEachScope((scope, state) =>
            {
                state.WriteStringValue(scope.ToString());
            }, writer);
            writer.WriteEndArray();
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions flatScopeOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new FlatScopeAugmenter() };

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_ScopeInformation()
    {
        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push("1 Outer Scope");
        scopeProvider.Push("2 Inner Scope");

        var expectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"augmentedScopes\":[\"1 Outer Scope\",\"2 Inner Scope\"]}\n";

        var actualJson = LogSimpleLogEntry(flatScopeOptions, scopeProvider);
        Assert.Equal(expectedAugmentedLogEntryJson, actualJson);
    }

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_DefaultsToNull()
    {
        var defaultOptions = new GoogleCloudConsoleFormatterOptions();
        Assert.Null(defaultOptions.LogAugmenter);
    }

    public class ExtraEndObjectAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        /// <summary>
        /// Augment with a complex object.
        /// </summary>
        public void AugmentFormattedLogEntry<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, Utf8JsonWriter writer)
        {
            writer.WriteStartObject("complex_key");
            writer.WriteString("nested_key", "nested_value");
            writer.WriteEndObject();
            writer.WriteEndObject(); // Extra WriteEndObject
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions extraEndOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new ExtraEndObjectAugmenter() };

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_ExtraEndObjectShouldThrow()
    {
        Assert.Throws<InvalidOperationException>(() => LogSimpleLogEntry(extraEndOptions));
    }

    public class DepthMismatchAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        /// <summary>
        /// Augment with a complex object.
        /// </summary>
        public void AugmentFormattedLogEntry<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, Utf8JsonWriter writer)
        {
            writer.WriteStartObject("complex_key");
            writer.WriteString("nested_key", "nested_value");
            // Missing WriteEndObject
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions depthMismatchOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new DepthMismatchAugmenter() };

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_DepthMismatchShouldThrow()
    {
        Assert.Throws<InvalidOperationException>(() => LogSimpleLogEntry(depthMismatchOptions));
    }

    private static GoogleCloudConsoleFormatter CreateFormatter(GoogleCloudConsoleFormatterOptions options = null)
    {
        options ??= new GoogleCloudConsoleFormatterOptions();
        return new GoogleCloudConsoleFormatter(options);
    }

    // Logs a simple log entry to a StringWriter and returns the corresponding Json string based on specified GoogleCloudConsoleFormatterOptions and IExternalScopeProvider.
    private static string LogSimpleLogEntry(GoogleCloudConsoleFormatterOptions options = null, IExternalScopeProvider scopeProvider = null)
    {
        // Create a simple log entry and return its Json string based on specified parameters.
        LogEntry<string> logEntry = new LogEntry<string>(LogLevel.Information, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
        return LogLogEntry(logEntry, options, scopeProvider);
    }

    private static string LogLogEntry<T>(LogEntry<T> logEntry, GoogleCloudConsoleFormatterOptions options, IExternalScopeProvider scopeProvider = null)
    {
        var writer = new StringWriter { NewLine = "\n" };
        var formatter = CreateFormatter(options);
        formatter.Write(logEntry, scopeProvider: scopeProvider, writer);
        return writer.ToString();
    }
}
