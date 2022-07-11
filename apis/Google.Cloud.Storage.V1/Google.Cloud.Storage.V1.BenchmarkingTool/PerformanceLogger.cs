// Copyright 2022 Google Inc. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Google.Cloud.Storage.V1.BenchmarkingTool;

internal class PerformanceLogger
{
    private readonly object _lockObj = new object();
    private readonly string _logFile;

    internal PerformanceLogger(string logFolder)
    {
        _logFile = $"{logFolder}/BenchmarkResults_{DateTime.UtcNow.ToString("yyyy-MM-dd_HH-mm-ss-fff", CultureInfo.InvariantCulture)}.csv";
    }

    /// <summary>
    /// Log collection of values in comma separated format.
    /// </summary>
    internal void Log(IEnumerable<string> values) => Log(string.Join(",", values));

    /// <summary>
    /// Log Message.
    /// </summary>
    internal void Log(string message)
    {
        lock (_lockObj)
        {
            WriteMessage(message);
        }
    }

    // Should be called within the lock
    private void WriteMessage(string message) =>
        File.AppendAllLines(_logFile, new[] { message });
}
