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

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Convenience utility for diagnostic logging while developing tests.
    /// Console output is hidden by default; this file writes timestamped messages to testlog.txt
    /// in the current directory. Calls to this class should be removed before merging.
    /// </summary>
    public static class FileLogger
    {
        private const string FileName = "testlog.txt";
        private static readonly object s_lock = new object();
        private static bool s_firstEntry = true;

        public static void LogWithCallerMember(string message, [CallerMemberName] string caller = null) =>
            Log($"{caller}: {message}");

        public static void LogWithCallerSource(string message, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) =>
            Log($"{file}:{line}: {message}");

        public static void Log(string message)
        {
            lock (s_lock)
            {
                if (s_firstEntry)
                {
                    s_firstEntry = false;
                    WriteMessage("=== Test started === ");
                }
                WriteMessage(message);
            }
        }

        // Should be called within the lock
        private static void WriteMessage(string message) =>
            File.AppendAllText(FileName, FormatLine(message));

        private static string FormatLine(string message) =>
            $"{DateTime.UtcNow:yyyy-MM-ddTHH:mm:ss.fff'Z'}: {message}{Environment.NewLine}";
    }
}
