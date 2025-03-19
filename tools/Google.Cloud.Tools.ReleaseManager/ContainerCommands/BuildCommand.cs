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
        var repoRoot = options.GetValueOrDefault("repo-root");
        var generatorOutput = options.GetValueOrDefault("generator-output");

        if (repoRoot is null == generatorOutput is null)
        {
            Console.WriteLine("Exactly one of --repo-root or --generator-output must be specified.");
            return 1;
        }

        return repoRoot is not null
            ? BuildConfigured(options, repoRoot)
            : BuildUnconfigured(options, generatorOutput);
    }

    /// <summary>
    /// Build code from the repo root, using our normal build scripts.
    /// </summary>
    private int BuildConfigured(Dictionary<string, string> options, string repoRoot)
    {
        var apiPath = options.GetValueOrDefault("api-path");
        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);

        // Note: this (test support) is speculative.
        var test = options.GetValueOrDefault("test") == "true";

        var processArguments = new List<string> { "./build.sh" };
        if (!test)
        {
            processArguments.Add("--notests");
        }

        List<string> apiIds = new();
        // By default, we build all configured APIs.
        // If an API path is configured, we build just that.
        // While build.sh without any arguments will query the API catalog, we might as well
        // pass them in directly, so we don't need to rebuild ReleaseManager.
        if (apiPath is not null)
        {
            var targetApi = catalog.Apis.SingleOrDefault(api => api.ProtoPath == apiPath);
            if (targetApi is null)
            {
                // Maybe what was passed in wasn't a proto path, but a library ID (as per the pipeline-state.json, so it may be a package group ID)...
                // This is probably a temporary measure - we'll probably end up with different options for api-path vs library-id.
                if (catalog.PackageGroups.FirstOrDefault(pg => pg.Id == apiPath) is PackageGroup group)
                {
                    apiIds.AddRange(group.PackageIds);
                }
                else if (catalog.TryGetApi(apiPath, out targetApi))
                {
                    apiIds.Add(targetApi.Id);
                }
                else
                {
                    // No, we really don't have anything we can identify that way.
                    Console.WriteLine($"API path '{apiPath}' is not configured for any API.");
                    return 1;
                }
            }
            else
            {
                apiIds.Add(targetApi.Id);
            }
        }
        else
        {
            apiIds.AddRange(catalog.Apis.Select(api => api.Id));
        }

        processArguments.AddRange(apiIds);

        var psi = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            WorkingDirectory = repoRoot
        };
        processArguments.ForEach(psi.ArgumentList.Add);
        return ExecuteBuildProcess(psi);
    }

    /// <summary>
    /// Build code from the repo root, using our normal build scripts.
    /// </summary>
    private int BuildUnconfigured(Dictionary<string, string> options, string generatorOutput)
    {
        string apiPath = options["api-path"];

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
