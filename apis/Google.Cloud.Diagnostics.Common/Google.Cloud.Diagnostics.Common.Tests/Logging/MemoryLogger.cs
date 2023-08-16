// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Diagnostics.Common.Tests.Logging;

/// <summary>
/// Logger implementation that retains log entries in memory, for test purposes.
/// Adapted from https://github.com/GoogleCloudPlatform/functions-framework-dotnet/blob/main/src/Google.Cloud.Functions.Testing/MemoryLogger.cs
/// </summary>
public class MemoryLogger : ILogger
{
    private readonly string _categoryName;
    private readonly ConcurrentQueue<TestLogEntry> _logEntries = new ConcurrentQueue<TestLogEntry>();
    private readonly IExternalScopeProvider _scopeProvider = new LoggerExternalScopeProvider();

    /// <summary>
    /// Creates a logger with the given category name.
    /// </summary>
    /// <param name="categoryName">The category name of the logger.</param>
    public MemoryLogger(string categoryName) => _categoryName = categoryName;

    /// <summary>
    /// Creates a list of the log entries in this logger. The returned list is an independent clone
    /// of the current set of log entries. This call does not affect the state of the logger.
    /// </summary>
    /// <returns>A list of log entries in the logger.</returns>
    public List<TestLogEntry> ListLogEntries() => _logEntries.ToList();

    /// <inheritdoc />
    public IDisposable BeginScope<TState>(TState state) => _scopeProvider.Push(state);

    /// <summary>
    /// Returns true for any log level other than None; filtering is expected
    /// to be provided by other infrastructure.
    /// </summary>
    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    /// <summary>
    /// Formats the log entry as a <see cref="TestLogEntry"/> and retains it in memory.
    /// </summary>
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        var entry = TestLogEntry.Create(_categoryName, logLevel, eventId, state, exception, formatter, _scopeProvider);
        _logEntries.Enqueue(entry);
    }
}
