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
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Implementation for commands which are run against repositories other than google-cloud-dotnet.
/// These are basically to have a consistent release process against all repositories.
/// </summary>
internal static class NonGoogleCloudDotnetCommands
{
    // The environment variable populated by Librarian to tell us the owner of the published NuGet packages.
    private const string NugetPackageOwnerEnvironmentVariable = "NUGET_PACKAGE_OWNER";

    private static readonly ImmutableHashSet<string> ValidSubcommands = new[]
    {
        ContainerCommand.BuildLibrary,
        ContainerCommand.PrepareLibraryRelease,
        ContainerCommand.IntegrationTestLibrary,
        ContainerCommand.PackageLibrary
    }.ToImmutableHashSet(StringComparer.Ordinal);

    internal static int Execute(string subcommand, ContainerOptions options)
    {
        if (!ValidSubcommands.Contains(subcommand))
        {
            throw new ArgumentException($"Subcommand {subcommand} not implemented for non-google-cloud-dotnet repositories.");
        }
        RootLayout layout = RootLayout.ForRepositoryRoot(options.RepoRoot);
        var libraryId = options.RequireOption(options.LibraryId);
        var state = PipelineState.Load(layout);
        var library = state.Libraries.Single(lib => lib.Id == libraryId);
        var libraryPaths = new LibraryPaths(options.RepoRoot, library);

        return subcommand switch
        {
            ContainerCommand.BuildLibrary => BuildLibrary(options, libraryPaths),
            ContainerCommand.PrepareLibraryRelease => PrepareLibraryRelease(options, libraryPaths),
            ContainerCommand.IntegrationTestLibrary => IntegrationTestLibrary(options, libraryPaths),
            ContainerCommand.PackageLibrary => PackageLibrary(options, libraryPaths),
            _ => throw new InvalidOperationException($"Bug; should have rejected {subcommand} earlier")
        };
    }

    // The following commands expect more in the library state than Librarian requires, in terms of source paths.
    // (This is all compatible with Librarian though.)
    // We expect:
    // - A single .sln file, which is a solution to build.
    // - A directory for each relevant project (including test projects); the project file must have the same name as the directory.
    // - Unit test projects must end in ".Tests"
    // - Integration test projects must end in ".IntegrationTests"
    // - Any *listed* project which isn't a test or integration test is packaged, unless it has IsPackable=false.
    // - Versions are updated by finding any packable project *or* XML file that contains a <Version> element.
    private static int BuildLibrary(ContainerOptions options, LibraryPaths paths)
    {
        using var _ = SourceLinkFixer.Create(options.RepoRoot);

        Console.WriteLine($"Building {Path.GetFileName(paths.SolutionFile)}");
        Processes.RunDotnet(options.RepoRoot, "build", "-c", "Release", paths.SolutionFile);
        if (options.Test)
        {
            foreach (var testProject in paths.UnitTestProjects)
            {
                Console.WriteLine($"Testing {Path.GetFileName(testProject)}");
                Processes.RunDotnet(options.RepoRoot, "test", "-c", "Release", testProject);
            }
        }
        return 0;
    }

    private static readonly Regex VersionElement = new Regex("<Version>[^<]+</Version>");
    private static int PrepareLibraryRelease(ContainerOptions options, LibraryPaths paths)
    {
        var version = options.RequireOption(options.Version);
        // We load these as text files to avoid having to worry about preserving formatting.
        var updatedAny = false;
        foreach (var file in paths.PackableProjects.Concat(paths.XmlFiles))
        {
            var text = File.ReadAllText(file);
            var modified = VersionElement.Replace(text, $"<Version>{version}</Version>");
            if (modified != text)
            {
                Console.WriteLine($"Updated version in {file}");
                File.WriteAllText(file, modified);
                updatedAny = true;
            }
        }
        if (!updatedAny)
        {
            throw new UserErrorException("Unable to find a version identifier in any files");
        }
        // TODO: Release notes
        return 0;
    }

    private static int IntegrationTestLibrary(ContainerOptions options, LibraryPaths paths)
    {
        using var _ = SourceLinkFixer.Create(options.RepoRoot);

        foreach (var testProject in paths.IntegrationTestProjects)
        {
            Console.WriteLine($"Testing {Path.GetFileName(testProject)}");
            Processes.RunDotnet(options.RepoRoot, "test", "-c", "Release", testProject);
        }
        return 0;
    }

    private static int PackageLibrary(ContainerOptions options, LibraryPaths paths)
    {
        using var _ = SourceLinkFixer.Create(options.RepoRoot);

        // Outside google-cloud-dotnet, we assume all packages for a given repo will have the same owner,
        // so it's just populated in pipeline-config.json.
        var packageOwner = Environment.GetEnvironmentVariable(NugetPackageOwnerEnvironmentVariable);
        if (string.IsNullOrEmpty(packageOwner))
        {
            throw new InvalidOperationException($"Required environment variable '{NugetPackageOwnerEnvironmentVariable}' is not specified.");
        }

        var output = options.RequireOption(options.Output);
        File.WriteAllText(Path.Combine(output, PackageLibraryCommand.PackageOwnerFile), packageOwner);
        foreach (var packableProject in paths.PackableProjects)
        {
            Console.WriteLine($"Packing {Path.GetFileName(packableProject)}");
            Processes.RunDotnet(options.RepoRoot,
                "pack",
                "-c", "Release",
                "-o", options.Output,
                packableProject);
        }
        foreach (var package in Directory.GetFiles(output, "*.nupkg"))
        {
            // Run from the container directory to use the tool configuration from there.
            Processes.RunDotnet("/app", "generate-sbom", package);
        }
        return 0;
    }

    /// <summary>
    /// Paths within a library. These are all absolute.
    /// </summary>
    private class LibraryPaths
    {
        public ImmutableList<string> AllPaths { get; }
        public string SolutionFile { get; }
        public ImmutableList<string> UnitTestProjects { get; }
        public ImmutableList<string> IntegrationTestProjects { get; }
        public ImmutableList<string> PackableProjects { get; }
        public ImmutableList<string> XmlFiles { get; }

        internal LibraryPaths(string repoRoot, LibraryState library)
        {
            AllPaths = library.SourcePaths.Select(p => Path.Combine(repoRoot, p)).ToImmutableList();
            SolutionFile = AllPaths.Single(sp => sp.EndsWith(".sln", StringComparison.Ordinal));

            var projects = AllPaths
                .Where(Directory.Exists)
                .Select(p => Path.Combine(p, Path.GetFileName(p) + ".csproj"))
                .Where(File.Exists)
                .ToList();
            UnitTestProjects = projects.Where(p => p.EndsWith(".Tests.csproj", StringComparison.Ordinal)).ToImmutableList();
            IntegrationTestProjects = projects.Where(p => p.EndsWith(".IntegrationTests.csproj", StringComparison.Ordinal)).ToImmutableList();
            PackableProjects = projects
                .Except(UnitTestProjects)
                .Except(IntegrationTestProjects)
                .Where(IsPackable)
                .ToImmutableList();
            XmlFiles = AllPaths.Where(p => p.EndsWith(".xml", StringComparison.Ordinal)).ToImmutableList();

            bool IsPackable(string project)
            {
                XDocument document = XDocument.Load(project);
                return !document.Root.Elements("PropertyGroup").Elements("IsPackable").Any(p => p.Value == "false" || p.Value == "False");
            }
        }
    }
}
