// Copyright 2018 Google LLC
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

using NodaTime;
using NodaTime.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Tools.ProcessBuildTimingLog
{
    /// <summary>
    /// The separated parts of a raw log line.
    /// </summary>
    public class LogEntry
    {
        private static readonly char[] s_separators = { ' ' };
        public string Action { get; }
        public Instant Timestamp { get; }

        private LogEntry(string action, Instant timestamp) =>
            (Action, Timestamp) = (action, timestamp);

        public static LogEntry FromLogLine(string line)
        {
            string[] bits = line.Split(s_separators, 2);
            if (bits.Length != 2)
            {
                throw new ArgumentException("Invalid log line: {line}");
            }
            var instant = OffsetDateTimePattern.ExtendedIso.Parse(bits[0]).Value.ToInstant();
            return new LogEntry(bits[1], instant);
        }
    }
}
