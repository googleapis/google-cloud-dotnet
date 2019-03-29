// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.Diagnostics;

namespace Google.Cloud.Spanner.V1.Internal.Logging
{
    /// <summary>
    /// This class is for internal use and not meant to be consumed directly.
    /// </summary>
    internal class DefaultLogger : Logger
    {
        /// <inheritdoc />
        protected override void LogImpl(LogLevel level, string message, Exception exception) =>
            WriteLine(exception == null ? $"{level}: {message}" : $"{level}: {message}, Exception: {exception}");

        /// <inheritdoc />
        protected override void LogPerformanceEntries(IEnumerable<string> entries)
        {
            string separator = Environment.NewLine + "  ";
            WriteLine($"Performance:{separator}{string.Join(separator, entries)}");
        }

        private void WriteLine(string line) => Trace.TraceInformation(line);
    }
}