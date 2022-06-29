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
using System.IO;
using System.Text.Json;
using Xunit;

namespace Google.Cloud.Logging.Console.Tests;

public class GoogleCloudConsoleFormatterTest
{
    [Fact]
    public void SimplestLog()
    {
        var formatter = CreateFormatter();
        var logEntry = new LogEntry<string>(LogLevel.Information, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
        var writer = new StringWriter { NewLine = "\n" };
        formatter.Write(logEntry, scopeProvider: null, writer);
        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\"}\n";
        var actualJson = writer.ToString();

        Assert.Equal(expectedJson, actualJson);
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
        var formatter = CreateFormatter(new GoogleCloudConsoleFormatterOptions { IncludeScopes = true });

        var logEntry = new LogEntry<string>(LogLevel.Information, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
        var writer = new StringWriter { NewLine = "\n" };

        var scopeProvider = new LoggerExternalScopeProvider();

        scopeProvider.Push("Inner Scope");

        formatter.Write(logEntry, scopeProvider: scopeProvider, writer);
        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\",\"scopes\":[\"Inner Scope\"]}\n";
        var actualJson = writer.ToString();

        Assert.Equal(expectedJson, actualJson);
    }

    [Fact]
    public void Log_EmptyScopeArrayIsIgnored()
    {
        var formatter = CreateFormatter(new GoogleCloudConsoleFormatterOptions { IncludeScopes = true });

        var logEntry = new LogEntry<string>(LogLevel.Information, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
        var writer = new StringWriter { NewLine = "\n" };

        var scopeProvider = new LoggerExternalScopeProvider();

        formatter.Write(logEntry, scopeProvider: scopeProvider, writer);
        var expectedJson = "{\"message\":\"test\",\"category\":\"LogCategory\",\"severity\":\"INFO\"}\n";
        var actualJson = writer.ToString();

        Assert.Equal(expectedJson, actualJson);
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

    private static GoogleCloudConsoleFormatter CreateFormatter(GoogleCloudConsoleFormatterOptions options = null)
    {
        options ??= new GoogleCloudConsoleFormatterOptions();
        return new GoogleCloudConsoleFormatter(options);
    }
}
