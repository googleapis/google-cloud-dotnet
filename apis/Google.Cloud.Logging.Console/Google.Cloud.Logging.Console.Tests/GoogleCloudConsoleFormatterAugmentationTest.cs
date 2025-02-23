// Copyright 2025 Google LLC
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
using System.IO;
using System.Text.Json;
using Xunit;

namespace Google.Cloud.Logging.Console.Tests;

public class GoogleCloudConsoleFormatterAugmentationTest
{
    private const string ExpectedSimpleLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\"}\n";

    private const string ExpectedAugmentedLogEntryJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"simple_key\":\"simple_value\"}\n";
    public class SimpleAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        /// <summary>
        /// Augment with a simple key-value pair.
        /// </summary>
        public void AugmentLog<T>(LogEntry<T> logEntry, Utf8JsonWriter writer)
        {
            writer.WriteString("simple_key", "simple_value");
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions simpleOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new SimpleAugmenter() };

    [Fact]
    public void SimplestLog()
    {
        var actualJson = LogSimpleLogEntry(simpleOptions);
        Assert.Equal(ExpectedAugmentedLogEntryJson, actualJson);
    }

    private class ErrorAnnotationAugmenter : IGoogleCloudConsoleLogAugmenter
    {
        private static readonly JsonEncodedText s_jsonPayloadTypePropertyName = JsonEncodedText.Encode("@type");
        private static readonly JsonEncodedText s_jsonPayloadTypePropertyValue = JsonEncodedText.Encode("type.googleapis.com/google.devtools.clouderrorreporting.v1beta1.ReportedErrorEvent");
        public void AugmentLog<T>(LogEntry<T> logEntry, Utf8JsonWriter writer)
        {
            if (logEntry.LogLevel >= LogLevel.Error)
            {
                writer.WriteString(s_jsonPayloadTypePropertyName, s_jsonPayloadTypePropertyValue);
            }
        }
    }
    private readonly GoogleCloudConsoleFormatterOptions errorAnnotationOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = new ErrorAnnotationAugmenter() };

    [Theory]
    [InlineData(LogLevel.Trace)]
    [InlineData(LogLevel.Debug)]
    [InlineData(LogLevel.Information)]
    [InlineData(LogLevel.Warning)]
    public void NonErrorLogTest(LogLevel logLevel)
    {
        LogEntry<string> logEntry = new LogEntry<string>(logLevel, "LogCategory", new EventId(1), "Not so bad", exception: null, (state, exception) => state);
        var actualJson = LogLogEntry(logEntry, errorAnnotationOptions);
        Assert.DoesNotContain("@type", actualJson);
        Assert.DoesNotContain("type.googleapis.com/google.devtools.clouderrorreporting.v1beta1.ReportedErrorEvent", actualJson);
    }

    [Theory]
    [InlineData(LogLevel.Error)]
    [InlineData(LogLevel.Critical)]
    public void ErrorLogTest(LogLevel logLevel)
    {
        LogEntry<string> logEntry = new LogEntry<string>(logLevel, "LogCategory", new EventId(1), "Not so bad", exception: null, (state, exception) => state);
        var actualJson = LogLogEntry(logEntry, errorAnnotationOptions);
        Assert.Contains("\"@type\":\"type.googleapis.com/google.devtools.clouderrorreporting.v1beta1.ReportedErrorEvent\"", actualJson);
    }


    private readonly GoogleCloudConsoleFormatterOptions NullAnnotationOptions = new GoogleCloudConsoleFormatterOptions { LogAugmenter = null };

    [Fact]
    public void NullAugmentLogTest()
    {
        var actualJson = LogSimpleLogEntry(NullAnnotationOptions);
        Assert.Equal(ExpectedSimpleLogEntryJson, actualJson);
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
        var formatter = new GoogleCloudConsoleFormatter(options);
        formatter.Write(logEntry, scopeProvider: scopeProvider, writer);
        return writer.ToString();
    }
}
