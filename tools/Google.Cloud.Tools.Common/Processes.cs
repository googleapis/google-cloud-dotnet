// Copyright 2019 Google LLC
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
using System.Diagnostics;

namespace Google.Cloud.Tools.Common
{
    public static class Processes
    {
        /// <summary>
        /// Runs the dotnet tool with the given working directory and arguments.
        /// </summary>
        public static void RunDotnet(string workingDirectory, params string[] args)
        {
            string joinedArguments = string.Join(" ", args);
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = joinedArguments,
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            var process = Process.Start(psi);
            // We assume there isn't so much output that this will block. Otherwise we'd have to read it in a different thread etc.
            // 10s limit stops us from hanging forever...
            process.WaitForExit(10000);
            if (process.ExitCode != 0)
            {
                var output = process.StandardOutput.ReadToEnd();
                var error = process.StandardError.ReadToEnd();
                throw new Exception($"dotnet exit code {process.ExitCode}. Directory: {workingDirectory}. Args: {joinedArguments}. Output: {output}. Error: {error}");
            }
        }
    }
}
