// Copyright 2025 Google LLC
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
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Everything that needs to run for utility docs. (Most container commands are effectively skipped.)
/// </summary>
internal static class UtilityDocCommands
{
    internal static int Execute(string subcommand, ContainerOptions options)
    {
        string docsName = options.UtilityDocsName;
        switch (subcommand)
        {
            // Docs publication is exactly the same as for a library (except we don't have any
            // nuget packages).
            case ContainerCommand.PublishLibrary:
                return new PublishLibraryCommand().Execute(options);
            case ContainerCommand.IntegrationTestLibrary:
                // We package the docs up here effectively as a test, so that by the time
                // we get to the actual PackageLibrary command, we're confident. (It's unfortunate
                // that that means doing things multiple times, but it won't be run very often.)
                PackageDocs(docsName, options);
                return 0;
            case ContainerCommand.PackageLibrary:
                PackageDocs(docsName, options);
                CopyDocsBundle(options);
                return 0;
            default:
                Console.WriteLine($"Skipping {subcommand} for utility docs package {docsName}");
                return 0;
        }
    }

    private static void PackageDocs(string docsName, ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var layout = RootLayout.ForRepositoryRoot(repoRoot);
        var pipelineState = PipelineState.Load(layout);
        var libraryId = options.RequireOption(options.LibraryId);
        var library = pipelineState.Libraries.Single(lib => lib.Id == libraryId);

        // Just to avoid warnings from anything we need to build.
        using var _ = SourceLinkFixer.Create(repoRoot);

        Processes.RunBashScript(Path.Combine(repoRoot, "docs"), "generate-devsite-utilities.sh", docsName, library.CurrentVersion);
    }

    private static void CopyDocsBundle(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var outputDirectory = options.RequireOption(options.Output);

        var docsOutput = Path.Combine(repoRoot, "docs", "output");
        var bundles = Directory.GetFiles(docsOutput, "*.tar.gz");
        if (bundles.Length != 1)
        {
            throw new Exception($"Expected a single tar.gz bundle to be generated. Actual count: {bundles.Length}");
        }
        var bundle = bundles[0];
        // Rename the bundle into the format expected by our publication proces.
        var targetFile = Path.Combine(outputDirectory, Path.GetFileName(bundle).Replace("docfx-dotnet-", "devsite-"));
        Console.WriteLine($"Copying {bundle} to {targetFile}");
        File.Copy(bundle, targetFile);
    }
}
