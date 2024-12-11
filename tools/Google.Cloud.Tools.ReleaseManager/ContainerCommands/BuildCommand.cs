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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Builds and optionally tests a library (or multiple libraries). Expected options:
/// - repo-root: the root of the google-cloud-dotnet repository
/// - api-path: (related to api-root) e.g. google/cloud/functions/v2
///   optional; when omitted, all configured APIs are built
///  - test: whether or not to run tests after building (true/false)
///    optional; defaults to false  
/// </summary>
public class BuildCommand : IContainerCommand
{
    public int Execute(Dictionary<string, string> options)
    {
        var repoRoot = options["repo-root"];
        var apiPath = options.GetValueOrDefault("api-path");
        var generatorInput = Path.Combine(repoRoot, DirectoryLayout.GeneratorInput);
        var catalog = ApiCatalog.LoadFromGeneratorInput(generatorInput);

        // Note: this (test support) is speculative.
        var test = options.GetValueOrDefault("test") == "true";

        var processArguments = new List<string> { "./build.sh" };
        if (!test)
        {
            processArguments.Add("--notests");
        }

        // By default, we build all configured APIs.
        // If an API path is configured, we build just that.
        // While build.sh without any arguments will query the API catalog, we might as well
        // pass them in directly, so we don't need to rebuild ReleaseManager.
        if (apiPath is not null)
        {
            var targetApi = catalog.Apis.SingleOrDefault(api => api.ProtoPath == apiPath);
            if (targetApi is null)
            {
                Console.WriteLine($"API path '{apiPath}' is not configured for any API.");
                return 1;
            }
            processArguments.Add(targetApi.Id);
        }
        else
        {
            processArguments.AddRange(catalog.Apis.Select(api => api.Id));
        }

        var psi = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            WorkingDirectory = repoRoot
        };
        processArguments.ForEach(psi.ArgumentList.Add);

        var process = Process.Start(psi)!;
        process.WaitForExit();
        if (process.ExitCode != 0)
        {
            Console.WriteLine("Error during build");
        }
        return process.ExitCode;
    }
}
