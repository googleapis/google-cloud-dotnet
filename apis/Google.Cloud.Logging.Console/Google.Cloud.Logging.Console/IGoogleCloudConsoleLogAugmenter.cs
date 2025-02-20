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

using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace Google.Cloud.Logging.Console;


/// <summary>
/// Interface for augmenting log entry formatting with custom information.
/// <cref>AugmentLog</cref> is called for each log entry to add custom information to the log entry formatting.
/// </summary>
public interface IGoogleCloudConsoleLogAugmenter
{
    /// <summary>
    /// Augments the log entry formatting with custom information.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="logEntry"></param>
    /// <param name="writer"></param>
    void AugmentLog<T>(LogEntry<T> logEntry, Utf8JsonWriter writer);
}