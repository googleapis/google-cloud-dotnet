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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Google.Cloud.Tools.Common
{
    public static class Processes
    {
        /// <summary>
        /// Runs the dotnet tool with the given working directory and arguments.
        /// </summary>
        public static void RunDotnet(string workingDirectory, params string[] args) => RunDotnetImpl(workingDirectory, sensitiveArgs: false, args);

        /// <summary>
        /// Runs the dotnet tool with the given working directory and arguments, but unlike
        /// <see cref="RunDotnet(string, string[])"/>, the arguments are not logged in the event of failure.
        /// (The output and error content are still logged, however.)
        /// </summary>
        public static void RunDotnetWithSensitiveArgs(string workingDirectory, params string[] args) => RunDotnetImpl(workingDirectory, sensitiveArgs: true, args);

        private static void RunDotnetImpl(string workingDirectory, bool sensitiveArgs, string[] args)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            args.ToList().ForEach(psi.ArgumentList.Add);

            var process = Process.Start(psi);
            TimeSpan timeout = TimeSpan.FromMinutes(5);
            // We assume there isn't so much output that this will block. Otherwise we'd have to read it in a different thread etc.
            // 5 minute limit stops us from hanging forever...
            if (!process.WaitForExit((int) timeout.TotalMilliseconds))
            {
                throw new Exception($"dotnet process didn't complete after {(int) timeout.TotalSeconds}s. Aborting tool.");
            }
            if (process.ExitCode != 0)
            {
                var output = process.StandardOutput.ReadToEnd();
                var error = process.StandardError.ReadToEnd();
                var loggedArgs = sensitiveArgs ? "(redacted)" : string.Join(" ", args);
                throw new Exception($"dotnet exit code {process.ExitCode}. Directory: {workingDirectory}. Args: {loggedArgs}. Output: {output}. Error: {error}");
            }
        }

        public static void RunBashScript(string workingDirectory, string script, params string[] args) =>
            RunBashScript(workingDirectory, script, (IEnumerable<string>) args);

        public static void RunBashScript(string workingDirectory, string script, IEnumerable<string> args)
        {
            var bash = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? @"C:\Program Files\Git\bin\bash.exe" // Hardcoding this is a bit odd, but it's not like this is general purpose...
                : "/bin/bash";
            var processArguments = args.Prepend($"./{script}").ToList();

            var psi = new ProcessStartInfo
            {
                FileName = bash,
                WorkingDirectory = workingDirectory
            };
            processArguments.ForEach(psi.ArgumentList.Add);
            var process = Process.Start(psi)!;
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                throw new Exception($"Process terminated with exit code {process.ExitCode}");
            }
        }

        /// <summary>
        /// Starts the given ProcessStartInfo as a new process, redirecting its standard output/error to the console (optionally filtering it),
        /// and waits for it to end.
        /// </summary>
        /// <param name="psi">The ProcessStartInfo to start. This is modified for redirection purposes.</param>
        /// <param name="descriptionForFailure">The description to use if the process fails.</param>
        /// <param name="outputPredicate">Predicate to apply to output lines; if specified, only lines matching the predicate are written to the console.</param>
        /// <exception cref="UserErrorException">The process terminated with a non-zero exit code.</exception>
        public static void RunAndPropagateOutput(ProcessStartInfo psi, string descriptionForFailure, Func<string, bool> outputPredicate = null)
        {
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            var proc = Process.Start(psi);
            proc.OutputDataReceived += HandleData(Console.Out);
            proc.ErrorDataReceived += HandleData(Console.Error);
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            proc.WaitForExit();
            if (proc.ExitCode != 0)
            {
                throw new UserErrorException($"{descriptionForFailure} failed with exit code {proc.ExitCode}");
            }

            DataReceivedEventHandler HandleData(TextWriter writer) =>
                (object sender, DataReceivedEventArgs e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data) && (outputPredicate?.Invoke(e.Data) ?? true))
                    {
                        writer.WriteLine(e.Data);
                    }
                };
        }
    }
}
