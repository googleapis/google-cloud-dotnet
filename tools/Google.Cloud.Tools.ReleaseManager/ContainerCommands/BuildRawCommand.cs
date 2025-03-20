// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Builds code generated for an API, without any other context (no handwritten code etc). Expected options:
/// - generator-output: the directory containing the results of a previous generate command; required
/// - api-path: (relative to api-root) e.g. google/cloud/functions/v2; required
///
/// Exactly one of repo-root or generator-output must be specified. When repo-root is specified,
/// the library is built including handwritten code etc. When generator-output is specified, this
/// builds the result of "raw" generation, without any additional configuration etc.
/// </summary>
public class BuildRawCommand : IContainerCommand
{
    public int Execute(Dictionary<string, string> options)
    {
        var generatorOutput = options.GetValueOrDefault(ContainerOptions.GeneratorOutputOption);
        var apiPath = options.GetValueOrDefault(ContainerOptions.ApiPathOption);

        if (generatorOutput is null)
        {
            throw new UserErrorException($"--{ContainerOptions.GeneratorOutputOption} must be specified.");
        }

        if (apiPath is null)
        {
            throw new UserErrorException($"--{ContainerOptions.ApiPathOption} must be specified.");
        }

        var apiRoot = Path.Combine(generatorOutput, apiPath);
        if (!Directory.Exists(apiRoot))
        {
            Console.WriteLine($"Expected directory '{apiRoot}' does not exist");
            return 1;
        }

        var solutions = Directory.GetFiles(apiRoot, "*.sln");
        if (solutions.Length != 1)
        {
            Console.WriteLine($"{solutions.Length} solution files in output directory. Aborting.");
            return 1;
        }
        var solution = Path.GetFileName(solutions[0]); ;
        Console.WriteLine($"Building {solution}");

        var psi = new ProcessStartInfo
        {
            FileName = "/usr/bin/dotnet",
            WorkingDirectory = apiRoot
        };
        var processArguments = new List<string> { "build", "-nologo", "-clp:NoSummary", "-v", "quiet", solution };
        processArguments.ForEach(psi.ArgumentList.Add);
        return ExecuteBuildProcess(psi);
    }

    private static int ExecuteBuildProcess(ProcessStartInfo psi)
    {
        var process = Process.Start(psi)!;
        process.WaitForExit();
        Console.WriteLine(process.ExitCode == 0 ? "Build complete" : "Error during build");
        return process.ExitCode;
    }
}
