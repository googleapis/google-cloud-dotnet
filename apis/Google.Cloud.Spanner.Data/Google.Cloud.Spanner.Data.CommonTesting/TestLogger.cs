// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    public class TestLogger : Logger
    {
        public static TestLogger Instance { get; } = new TestLogger();
        
        private TestLogger()
        {
            LogLevel = V1.Internal.Logging.LogLevel.Debug;
        }

        public static void Install() => SetDefaultLogger(Instance);

        protected override void LogImpl(V1.Internal.Logging.LogLevel level, string message, Exception exception) =>
            WriteLine(exception == null ? $"{level}: {message}" : $"{level}: {message}, Exception: {exception}");

        protected override void LogPerformanceEntries(IEnumerable<string> entries)
        {
            WriteLine("Performance:");
            foreach (var entry in entries)
            {
                WriteLine($"  {entry}");
            }
        }

        private void WriteLine(string line)
        {
            try
            {
                FileLogger.Log(line);
            }
            catch (Exception)
            {
                // Eat the exception.  This can happen if we try to output a log
                // after a test has completed (some action occurred asynchronously).
            }
        }
    }
}
