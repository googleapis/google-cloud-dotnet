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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Builds and optionally tests a library (or multiple libraries). Expected options:
/// - repo-root: the root of the google-cloud-dotnet repository; required
/// - test: whether or not to run tests after building (true/false)
///    optional; defaults to false
/// - library-id: e.g. Google.Cloud.Functions.V2; when not specified, all configured libraries are built
///
/// Note that the "library-id" is a library in the Librarian sense; it may map to multiple NuGet
/// packages (configured via a package group in the API catalog).
/// </summary>
public class BuildLibraryCommand : IContainerCommand
{
    public int Execute(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var libraryId = options.LibraryId;

        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);
        var apis = libraryId is null ? catalog.Apis
            : catalog.PackageGroups.FirstOrDefault(pg => pg.Id == libraryId) is PackageGroup group ? group.PackageIds.Select(id => catalog[id]).ToList()
            : new() { catalog[libraryId] };
        return BuildConfigured(repoRoot, apis, options.Test);
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

    private static int ExecuteBuildProcess(ProcessStartInfo psi)
    {
        var process = Process.Start(psi)!;
        process.WaitForExit();
        Console.WriteLine(process.ExitCode == 0 ? "Build complete" : "Error during build");
        return process.ExitCode;
    }
}
