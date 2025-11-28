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
using System.Text.Json.Nodes;
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
    public void Log_ScopeNameValuePairs_NoEmitNumericTypes()
    {
        var options = new GoogleCloudConsoleFormatterOptions { IncludeScopes = true };

        // Just a subset of types; we're more exhaustive for format parameter testing.
        var scope = new List<KeyValuePair<string, object>>
        {
            new("string", "text"),
            new("int", 1),
            new("long", 2L)
        };

        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push(scope);

        var actualJson = LogSimpleLogEntry(options, scopeProvider);
        var actualJsonEntry = JsonDocument.Parse(actualJson);

        var expectedScopeValues = new Dictionary<string, JsonValue>
        {
            { "string", JsonValue.Create("text") },
            { "int", JsonValue.Create("1") },
            { "long", JsonValue.Create("2") },
        };
        AssertScopeObject(expectedScopeValues, actualJsonEntry);
    }

    [Fact]
    public void Log_ScopeNameValuePairs_EmitNumericTypes()
    {
        var options = new GoogleCloudConsoleFormatterOptions { IncludeScopes = true, EmitNumericTypes = true };

        // Just a subset of types; we're more exhaustive for format parameter testing.
        var scope = new List<KeyValuePair<string, object>>
        {
            new("string", "text"),
            new("int", 1),
            new("long", 2L)
        };

        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push(scope);

        var actualJson = LogSimpleLogEntry(options, scopeProvider);
        var actualJsonEntry = JsonDocument.Parse(actualJson);

        var expectedScopeValues = new Dictionary<string, JsonValue>
        {
            { "string", JsonValue.Create("text") },
            { "int", JsonValue.Create(1) },
            { "long", JsonValue.Create("2") },
        };
        AssertScopeObject(expectedScopeValues, actualJsonEntry);
    }

    [Fact]
    public void Log_ScopeInteger_NoEmitNumericTypes()
    {
        var options = new GoogleCloudConsoleFormatterOptions { IncludeScopes = true };

        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push(1);

        var actualJson = LogSimpleLogEntry(options, scopeProvider);
        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"scopes\":[\"1\"]}\n";

        Assert.Equal(expectedJson, actualJson);
    }

    [Fact]
    public void Log_ScopeInteger_EmitNumericTypes()
    {
        var options = new GoogleCloudConsoleFormatterOptions { IncludeScopes = true, EmitNumericTypes = true };

        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push(1);

        var actualJson = LogSimpleLogEntry(options, scopeProvider);
        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"scopes\":[1]}\n";

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

        var state = new ReadOnlyCollection<KeyValuePair<string, object>>(new List<KeyValuePair<string, object>>
        {
            new KeyValuePair<string, object>("A", "Sample value 1"),
            new KeyValuePair<string, object>("B", "Sample value 2"),
        });

        var logEntry = new LogEntry<IReadOnlyCollection<KeyValuePair<string, object>>>(LogLevel.Information, "LogCategory", new EventId(1), state, exception: null, (state, exception) => state.ToString());
        var writer = new StringWriter { NewLine = "\n" };

        formatter.Write(logEntry, scopeProvider: null, writer);

        var actualJson = writer.ToString();
        var actualJsonEntry = JsonDocument.Parse(actualJson);

        var expectedFormatParameters = new Dictionary<string, JsonValue>
        {
            { "A", JsonValue.Create("Sample value 1") },
            { "B", JsonValue.Create("Sample value 2") }
        };
        AssertFormatParameters(expectedFormatParameters, actualJsonEntry);
    }

    [Fact]
    public void Log_FormatParameterTypes_DefaultOptions()
    {
        var formatter = CreateFormatter();

        var state = new ReadOnlyCollection<KeyValuePair<string, object>>(new List<KeyValuePair<string, object>>
        {
            // The names here are C# names rather than System.Single etc just for convenience; it's only a test.
            new KeyValuePair<string, object>("string", "text"),
            new KeyValuePair<string, object>("bool", true),
            new KeyValuePair<string, object>("byte", (byte) 1),
            new KeyValuePair<string, object>("sbyte", (sbyte) 1),
            new KeyValuePair<string, object>("short", (short) 1),
            new KeyValuePair<string, object>("ushort", (ushort) 1),
            new KeyValuePair<string, object>("int", 1),
            new KeyValuePair<string, object>("uint", (uint) 1),
            new KeyValuePair<string, object>("long", 1L),
            new KeyValuePair<string, object>("ulong", 1UL),
            new KeyValuePair<string, object>("float", 1.5f),
            new KeyValuePair<string, object>("double", 1.5d),
            new KeyValuePair<string, object>("float-nan", float.NaN),
            new KeyValuePair<string, object>("double-nan", double.NaN),
            new KeyValuePair<string, object>("float-inf-pos", float.PositiveInfinity),
            new KeyValuePair<string, object>("double-inf-pos", double.PositiveInfinity),
            new KeyValuePair<string, object>("float-inf-neg", float.NegativeInfinity),
            new KeyValuePair<string, object>("double-inf-neg", double.NegativeInfinity),
            new KeyValuePair<string, object>("decimal", 1.50m),
            new KeyValuePair<string, object>("null", null),
        });

        var logEntry = new LogEntry<IReadOnlyCollection<KeyValuePair<string, object>>>(LogLevel.Information, "LogCategory", new EventId(1), state, exception: null, (state, exception) => state.ToString());
        var writer = new StringWriter { NewLine = "\n" };

        formatter.Write(logEntry, scopeProvider: null, writer);

        var actualJson = writer.ToString();
        var actualJsonEntry = JsonDocument.Parse(actualJson);

        var expectedFormatParameters = new Dictionary<string, JsonValue>
        {
            { "string", JsonValue.Create("text") },
            { "bool", JsonValue.Create("True") },
            { "byte", JsonValue.Create("1") },
            { "sbyte", JsonValue.Create("1") },
            { "short", JsonValue.Create("1") },
            { "ushort", JsonValue.Create("1") },
            { "int", JsonValue.Create("1") },
            { "uint", JsonValue.Create("1") },
            { "long", JsonValue.Create("1") },
            { "ulong", JsonValue.Create("1") },
            { "float", JsonValue.Create("1.5") },
            { "double", JsonValue.Create("1.5") },
            { "float-nan", JsonValue.Create("NaN") },
            { "double-nan", JsonValue.Create("NaN") },
            { "float-inf-pos", JsonValue.Create("Infinity") },
            { "double-inf-pos", JsonValue.Create("Infinity") },
            { "float-inf-neg", JsonValue.Create("-Infinity") },
            { "double-inf-neg", JsonValue.Create("-Infinity") },
            { "decimal", JsonValue.Create("1.50") },
            { "null", JsonValue.Create("") }
        };
        AssertFormatParameters(expectedFormatParameters, actualJsonEntry);
    }

    [Fact]
    public void Log_FormatParameterTypes_EmitNumericTypes()
    {
        var options = new GoogleCloudConsoleFormatterOptions { EmitNumericTypes = true };
        var formatter = CreateFormatter(options);

        var state = new ReadOnlyCollection<KeyValuePair<string, object>>(new List<KeyValuePair<string, object>>
        {
            // The names here are C# names rather than System.Single etc just for convenience; it's only a test.
            new KeyValuePair<string, object>("string", "text"),
            new KeyValuePair<string, object>("bool", true),
            new KeyValuePair<string, object>("byte", (byte) 1),
            new KeyValuePair<string, object>("sbyte", (sbyte) 1),
            new KeyValuePair<string, object>("short", (short) 1),
            new KeyValuePair<string, object>("ushort", (ushort) 1),
            new KeyValuePair<string, object>("int", 1),
            new KeyValuePair<string, object>("uint", (uint) 1),
            new KeyValuePair<string, object>("long", 1L),
            new KeyValuePair<string, object>("ulong", 1UL),
            new KeyValuePair<string, object>("float", 1.5f),
            new KeyValuePair<string, object>("double", 1.5d),
            new KeyValuePair<string, object>("float-nan", float.NaN),
            new KeyValuePair<string, object>("double-nan", double.NaN),
            new KeyValuePair<string, object>("float-inf-pos", float.PositiveInfinity),
            new KeyValuePair<string, object>("double-inf-pos", double.PositiveInfinity),
            new KeyValuePair<string, object>("float-inf-neg", float.NegativeInfinity),
            new KeyValuePair<string, object>("double-inf-neg", double.NegativeInfinity),
            new KeyValuePair<string, object>("decimal", 1.50m),
            new KeyValuePair<string, object>("null", null),
        });

        var logEntry = new LogEntry<IReadOnlyCollection<KeyValuePair<string, object>>>(LogLevel.Information, "LogCategory", new EventId(1), state, exception: null, (state, exception) => state.ToString());
        var writer = new StringWriter { NewLine = "\n" };

        formatter.Write(logEntry, scopeProvider: null, writer);

        var actualJson = writer.ToString();
        var actualJsonEntry = JsonDocument.Parse(actualJson);

        var expectedFormatParameters = new Dictionary<string, JsonValue>
        {
            { "string", JsonValue.Create("text") },
            { "bool", JsonValue.Create("True") },
            { "byte", JsonValue.Create(1) },
            { "sbyte", JsonValue.Create(1) },
            { "short", JsonValue.Create(1) },
            { "ushort", JsonValue.Create(1) },
            { "int", JsonValue.Create(1) },
            { "uint", JsonValue.Create(1) },
            // 64-bit integers are still represented as strings
            { "long", JsonValue.Create("1") },
            { "ulong", JsonValue.Create("1") },
            { "float", JsonValue.Create(1.5) },
            { "double", JsonValue.Create(1.5) },
            // NaN/infinity are still represented as strings
            { "float-nan", JsonValue.Create("NaN") },
            { "double-nan", JsonValue.Create("NaN") },
            { "float-inf-pos", JsonValue.Create("Infinity") },
            { "double-inf-pos", JsonValue.Create("Infinity") },
            { "float-inf-neg", JsonValue.Create("-Infinity") },
            { "double-inf-neg", JsonValue.Create("-Infinity") },
            // Decimals are still represented as strings
            { "decimal", JsonValue.Create("1.50") },
            { "null", JsonValue.Create("") }
        };
        AssertFormatParameters(expectedFormatParameters, actualJsonEntry);
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

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_SimplestLog()
    {
        var expectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"simple_key\":\"simple_value\"}\n";

        var simpleOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new SimpleAugmenter() };
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

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_ComplexLog()
    {
        var expectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"complex_key\":{\"nested_key\":\"nested_value\"}}\n";

        var complexOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new ComplexAugmenter() };
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

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_ScopeInformation()
    {
        var scopeProvider = new LoggerExternalScopeProvider();
        scopeProvider.Push("1 Outer Scope");
        scopeProvider.Push("2 Inner Scope");

        var expectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"augmentedScopes\":[\"1 Outer Scope\",\"2 Inner Scope\"]}\n";

        var flatScopeOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new FlatScopeAugmenter() };
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

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_ExtraEndObjectShouldThrow()
    {
        var extraEndOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new ExtraEndObjectAugmenter() };
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

    [Fact]
    public void ConsoleLoggerOptions_LogAugmenter_DepthMismatchShouldThrow()
    {
        var depthMismatchOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new DepthMismatchAugmenter() };
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
        var writer = new StringWriter { NewLine = "\n" };
        var formatter = CreateFormatter(options);
        formatter.Write(logEntry, scopeProvider: scopeProvider, writer);
        return writer.ToString();
    }

    private static void AssertFormatParameters(Dictionary<string, JsonValue> expectedValues, JsonDocument actualJsonEntry)
    {
        var formatParametersElement = actualJsonEntry.RootElement.GetProperty("format_parameters");
        Assert.Equal(JsonValueKind.Object, formatParametersElement.ValueKind);
        var formatParameters = JsonObject.Create(formatParametersElement);
        Assert.Equal(expectedValues.Count, formatParameters.Count);
        foreach (var pair in expectedValues)
        {
            var actualValue = (JsonValue) formatParameters[pair.Key];
            // Emit the JSON for the property to make it easier to tell what's going on when something fails.
            // The spaces at the start and end are to differentiate between the quotes added by xUnit and those in the actual values being compared.
            Assert.Equal($"  \"{pair.Key}\": {pair.Value.ToJsonString()}  ", $"  \"{pair.Key}\": {formatParameters[pair.Key].ToJsonString()}  ");
        }
    }

    private static void AssertScopeObject(Dictionary<string, JsonValue> expectedValues, JsonDocument actualJsonEntry)
    {
        var scopesElement = actualJsonEntry.RootElement.GetProperty("scopes");
        Assert.Equal(JsonValueKind.Array, scopesElement.ValueKind);
        // We're only checking the first element in the scopes array
        var firstScopeObject = JsonObject.Create(scopesElement[0]);
        Assert.Equal(expectedValues.Count, firstScopeObject.Count);
        foreach (var pair in expectedValues)
        {
            var actualValue = (JsonValue) firstScopeObject[pair.Key];
            // Emit the JSON for the property to make it easier to tell what's going on when something fails.
            // The spaces at the start and end are to differentiate between the quotes added by xUnit and those in the actual values being compared.
            Assert.Equal($"  \"{pair.Key}\": {pair.Value.ToJsonString()}  ", $"  \"{pair.Key}\": {firstScopeObject[pair.Key].ToJsonString()}  ");
        }
    }
}
