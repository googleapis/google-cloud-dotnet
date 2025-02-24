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
using System.Text.Json;

namespace Google.Cloud.Logging.Console;

/// <summary>
/// Allows augmenting formatted log entries with information not included by <see cref="GoogleCloudConsoleFormatter"/>.
/// </summary>
public interface IGoogleCloudConsoleLogAugmenter
{
    /// <summary>
    /// Augments the formatted log entry with information not included by <see cref="GoogleCloudConsoleFormatter"/>.
    /// </summary>
    /// <typeparam name="TState">The type of the state information attached to the log entry.</typeparam>
    /// <param name="logEntry">The log entry that's being formatted.</param>
    /// <param name="scopeProvider">The provider of scope data.</param>
    /// <param name="writer">
    /// The JSON writer containing the start of the formatted log entry, meaning that
    /// <see cref="Utf8JsonWriter.WriteStartObject()" /> has been called for the top level JSON object and some fields have been written
    /// but <see cref="Utf8JsonWriter.WriteEndObject" /> is yet to be called for the top level JSON object.
    /// Do not call <see cref="Utf8JsonWriter.WriteEndObject" /> for the top level JSON object.
    /// </param>
    void AugmentFormattedLogEntry<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, Utf8JsonWriter writer);
}