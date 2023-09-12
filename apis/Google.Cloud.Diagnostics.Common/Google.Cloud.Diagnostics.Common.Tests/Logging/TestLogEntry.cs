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
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.Common.Tests.Logging;

/// <summary>
/// A very simplified representation of a log entry, aimed at testing.
/// Adapted from https://github.com/GoogleCloudPlatform/functions-framework-dotnet/blob/main/src/Google.Cloud.Functions.Testing/TestLogEntry.cs
/// </summary>
public sealed class TestLogEntry
{
    private static readonly IReadOnlyList<object> EmptyScopeList = new List<object>().AsReadOnly();

    /// <summary>
    /// The category name of the log entry.
    /// </summary>
    public string CategoryName { get; }

    /// <summary>
    /// The level of the log entry.
    /// </summary>
    public LogLevel Level { get; }

    /// <summary>
    /// The exception in the log entry, or null if there was no exception.
    /// </summary>
    public Exception Exception { get; }

    /// <summary>
    /// The event ID of the log entry.
    /// </summary>
    public EventId EventId { get; }

    /// <summary>
    /// The message of the log entry.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// The scopes of the log entry. This is never null, but may be empty.
    /// </summary>
    public IReadOnlyList<object> Scopes { get; }

    private TestLogEntry(string categoryName, LogLevel level, EventId eventId, string message, Exception exception, IReadOnlyList<object> scopes) =>
        (CategoryName, Level, EventId, Message, Exception, Scopes) =
        (categoryName, level, eventId, message, exception, scopes);

    internal static TestLogEntry Create<TState>(
        string categoryName, LogLevel logLevel, EventId eventId,
        TState state, Exception exception, Func<TState, Exception, string> formatter,
        IExternalScopeProvider scopeProvider)
    {
        var message = formatter(state, exception);
        List<object> scopes = null;
        scopeProvider.ForEachScope((scope, state) =>
        {
            if (scope is null)
            {
                return;
            }
            if (scopes is null)
            {
                scopes = new List<object>();
            }
            scopes.Add(scope);
        }, state: (object) null);

        return new TestLogEntry(categoryName, logLevel, eventId, message, exception, scopes?.AsReadOnly() ?? EmptyScopeList);
    }

    /// <summary>
    /// Returns a diagnostic form of the log entry, in the form "[Level]: Message",
    /// to simplify debugging.
    /// </summary>
    /// <returns>A diagnostic form of the log entry.</returns>
    public override string ToString() => $"[{Level}]: {Message}";
}
