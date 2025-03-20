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
using static System.Net.Mime.MediaTypeNames;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Builds and optionally tests a library (or multiple libraries). Expected options:
/// - repo-root: the root of the google-cloud-dotnet repository
/// - generator-output: the directory containing the results of a previous generate command
/// - test: whether or not to run tests after building (true/false)
///    optional; defaults to false
/// - api-path: (relative to api-root) e.g. google/cloud/functions/v2
/// - library-id: e.g. Google.Cloud.Functions.V2
///
/// Exactly one of repo-root or generator-output must be specified. When repo-root is specified,
/// the library is built including handwritten code etc. When generator-output is specified, this
/// builds the result of "raw" generation, without any additional configuration etc.
/// 
/// Only one of api-path or library-id may be specified. If neither is specified,
/// all configured libraries are built. If api-path is specified, only the library
/// related to that API path is built. If library-id is specified, that library is built - but
/// this may consist of multiple packages, if it identifies a package group. (In other words,
/// it's the ID of a library in pipeline-state.json, not necessarily an ID in "apis" in the API
/// catalog.)
///
/// The library-id option is only valid when repo-root is specified. The api-path option is
/// required when repo-root is not specified. (It's invalid to specify just "generator-output".)
/// </summary>
public class BuildCommand : IContainerCommand
{
    public int Execute(Dictionary<string, string> options)
    {
        var repoRoot = options.GetValueOrDefault(ContainerOptions.RepoRootOption);
        var generatorOutput = options.GetValueOrDefault(ContainerOptions.GeneratorOutputOption);
        var apiPath = options.GetValueOrDefault(ContainerOptions.ApiPathOption);
        var libraryId = options.GetValueOrDefault(ContainerOptions.LibraryIdOption);

        if (repoRoot is null == generatorOutput is null)
        {
            throw new UserErrorException($"Exactly one of --{ContainerOptions.RepoRootOption} or --{ContainerOptions.GeneratorOutputOption} must be specified.");
        }

        if (apiPath is not null && libraryId is not null)
        {
            throw new UserErrorException($"At most one of --{ContainerOptions.ApiPathOption} or --{ContainerOptions.LibraryIdOption} must be specified.");
        }

        // Build unconfigured: there must be an api path
        if (generatorOutput is not null)
        {
            if (apiPath is null)
            {
                throw new UserErrorException($"When specifying --{ContainerOptions.GeneratorOutputOption}, --{ContainerOptions.ApiPathOption} must be specified.");
            }
            return BuildUnconfigured(generatorOutput, apiPath);
        }
        else
        {
            var test = options.GetValueOrDefault(ContainerOptions.TestOption) == "true";
            var apis = DeriveConfiguredApisToBuild(repoRoot, apiPath, libraryId);
            return BuildConfigured(repoRoot, apis, test);
        }
    }

    private static List<ApiMetadata> DeriveConfiguredApisToBuild(string repoRoot, string apiPath, string libraryId)
    {
        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);

        return libraryId is null && apiPath is null ? catalog.Apis
            : apiPath is not null ? FindApisFromApiPath()
            : FindApisFromLibraryId();

        List<ApiMetadata> FindApisFromApiPath()
        {
            var api = catalog.Apis.SingleOrDefault(api => api.ProtoPath == apiPath)
                ?? throw new UserErrorException($"API path {apiPath} is not configured");
            return new() { api };
        }
        List<ApiMetadata> FindApisFromLibraryId() =>
           catalog.PackageGroups.FirstOrDefault(pg => pg.Id == libraryId) is PackageGroup group
           ? group.PackageIds.Select(id => catalog[id]).ToList()
           : new() { catalog[libraryId] };
    }

    /// <summary>
    /// Build code from the repo root, using our normal build scripts.
    /// </summary>
    private int BuildConfigured(string repoRoot, List<ApiMetadata> apis, bool test)
    {
        var processArguments = new List<string> { "./build.sh" };
        if (!test)
        {
            processArguments.Add("--notests");
        }

        processArguments.AddRange(apis.Select(api => api.Id));

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
    private int BuildUnconfigured(string generatorOutput, string apiPath)
    {
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
