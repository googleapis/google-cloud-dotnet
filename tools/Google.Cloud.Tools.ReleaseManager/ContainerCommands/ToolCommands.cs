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
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Everything that needs to run for dotnet tools under the tools/ directory.
/// This is invoked for any library starting "Google.Cloud.Tools"
/// </summary>
internal static class ToolCommands
{
    internal static int Execute(string subcommand, ContainerOptions options)
    {
        return subcommand switch
        {
            // Package publication is exactly the same as for a library.
            // (We've already built the package at that point.)
            ContainerCommand.PublishLibrary => new PublishLibraryCommand().Execute(options),
            ContainerCommand.IntegrationTestLibrary => IntegrationTest(options),
            ContainerCommand.PackageLibrary => Package(options),
            ContainerCommand.BuildLibrary => Build(options),
            ContainerCommand.PrepareLibraryRelease => AdjustVersion(options),
            _ => LogSkip(subcommand, options.LibraryId),
        };

        static int LogSkip(string subcommand, string libraryId)
        {
            Console.WriteLine($"Skipping {subcommand} for tool {libraryId}");
            return 0;
        }
    }

    private static int Build(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        Processes.RunDotnet(repoRoot, "build",
            "-c", "Release",
            $"tools/{options.LibraryId}");

        MaybeTest(options, "Tests");
        return 0;
    }

    private static int Package(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var outputDirectory = options.RequireOption(options.Output);
        // All tools are owned by "google-cloud"
        File.WriteAllText(Path.Combine(outputDirectory, PackageLibraryCommand.PackageOwnerFile), "google-cloud");
        Processes.RunDotnet(repoRoot, "pack",
            "-c", "Release",
            "-o", outputDirectory,
            $"tools/{options.LibraryId}");
        var packages = Directory.GetFiles(outputDirectory, "*.nupkg");
        foreach (var package in packages)
        {
            // Run from the container directory to use the tool configuration from there.
            Processes.RunDotnet("/app", "generate-sbom", package);
        }
        return 0;
    }

    private static int IntegrationTest(ContainerOptions options)
    {
        MaybeTest(options, "IntegrationTests");
        return 0;
    }

    private static void MaybeTest(ContainerOptions options, string suffix)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var testDirectory = Path.Combine(repoRoot, "tools", $"{options.LibraryId}.{suffix}");
        if (Directory.Exists(testDirectory))
        {
            Processes.RunDotnet(repoRoot, "test", "-c", "Release", testDirectory);
        }
    }

    private static int AdjustVersion(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var projectFile = Path.Combine(repoRoot, $"tools/{options.LibraryId}/{options.LibraryId}.csproj");
        var text = File.ReadAllText(projectFile);
        var modified = Regex.Replace(text, "<Version>[^<]+</Version>", options.Version);
        File.WriteAllText(projectFile, modified);
        return 0;
    }
}
