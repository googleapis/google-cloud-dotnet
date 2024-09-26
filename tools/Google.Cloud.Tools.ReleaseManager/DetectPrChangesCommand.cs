// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.VersionCompat;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Compares the current PR with the state before the PR for APIs, both
/// in terms of the previous "latest" code and the previous NuGet release (if any).
/// </summary>
public class DetectPrChangesCommand : ICommand
{
    public string Description => "Detects changes in a pull request. Expected to be called from detect-pr-changes.sh.";

    public string Command => "detect-pr-changes";

    public string ExpectedArguments => "<pre-PR git directory> <[id [id...]]";

    public int Execute(string[] args)
    {
        string oldCommitDirectory = args[0];
        bool anyFailures = false;
        var catalog = ApiCatalog.Load();
        var tags = LoadRepositoryTags();

        var apiIds = args.Skip(1).ToList();
        foreach (var id in apiIds)
        {
            if (!catalog.TryGetApi(id, out var api))
            {
                LogHeader($"{id} has been deleted");
                continue;
            }
            anyFailures |= CompareApi(oldCommitDirectory, tags, api);
        }

        return anyFailures ? 1 : 0;

        HashSet<string> LoadRepositoryTags()
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using var repo = new Repository(root);
            return new HashSet<string>(repo.Tags.Select(tag => tag.FriendlyName));
        }
    }

    /// <summary>
    /// Compares old and previous-release versions of an API with the current code.
    /// </summary>
    /// <remarks>This is a long and rambly method as it accumulates a lot of information
    /// along the way (TFMs, output locations etc). We could potentially refactor much of it into a class,
    /// but it's simpler to keep it like this for now.</remarks>
    /// <returns>Whether the comparison has failed in some way.</returns>
    private bool CompareApi(string oldCommitDirectory, HashSet<string> tags, ApiMetadata api)
    {
        string id = api.Id;
        LogHeader($"Finding changes in {id}...");

        // Initial presence checks, working out the old/new locations and TFMs.
        var projectFile = $"apis/{id}/{id}/{id}.csproj";
        var oldProjectFile = Path.Combine(oldCommitDirectory, projectFile);
        var newProjectFile = projectFile;
        if (!File.Exists(oldProjectFile))
        {
            Console.WriteLine("API does not exist in earlier commit. Nothing to compare.");
            return false;
        }

        if (!File.Exists(newProjectFile))
        {
            Console.WriteLine($"{id} is in the API catalog, but the project file doesn't exist. Please investigate.");
            return true;
        }
        string oldTfm = FindTfm(oldProjectFile);
        string newTfm = FindTfm(newProjectFile);

        if (oldTfm != newTfm)
        {
            Console.WriteLine($"Note: old/new TFMs are different: {oldTfm}/{newTfm}");
        }

        // Build both the old and new assemblies.
        LogHeader($"Comparing old and new versions (by source)");
        Processes.RunDotnet(".", "build", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", "-f", oldTfm, oldProjectFile);
        Processes.RunDotnet(".", "build", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", "-f", newTfm, newProjectFile);
        string oldAssemblyFile = Path.Combine(oldCommitDirectory, $"apis/{id}/{id}/bin/Release/{oldTfm}/{id}.dll");
        string newAssemblyFile = $"apis/{id}/{id}/bin/Release/{newTfm}/{id}.dll";

        // Now compare them
        var oldAssembly = Assemblies.LoadFile(oldAssemblyFile);
        var newAssembly = Assemblies.LoadFile(newAssemblyFile);
        var diffs = Assemblies.Compare(oldAssembly, newAssembly, null);
        diffs.PrintDifferences(Level.Major, FormatDetail.Brief);
        diffs.PrintDifferences(Level.Minor, FormatDetail.Brief);
        Console.WriteLine($"Diff level: {diffs.Level}");
        // Stop if we've found breaking changes, unless it's a beta-level API.
        if (diffs.Major.Any() && api.CanHaveGaRelease)
        {
            return true;
        }

        // Now for the package version... this uses code from the existing CheckVersionCompatibilityCommand.
        Console.WriteLine();
        LogHeader($"Comparing with previous NuGet package");
        try
        {
            CheckVersionCompatibilityCommand.CheckCompatibilityWithPreviousRelease(tags, api);
        }
        catch (UserErrorException ex)
        {
            Console.WriteLine(ex.Message);
            return true;
        }
        LogHeader($"Finished comparisons for {id}");
        Console.WriteLine();

        // All is well.
        return false;

        string FindTfm(string file)
        {
            XDocument doc = XDocument.Load(file);
            var frameworks = doc.Root?.Element("PropertyGroup")?.Element("TargetFrameworks")?.Value?.Split(';')
                ?? throw new UserErrorException($"Unable to find any TargetFrameworks in '{file}'");
            return frameworks.FirstOrDefault(f => f.StartsWith("netstandard")) ?? frameworks.First();
        }
    }

    private static void LogHeader(string text) =>
        Console.WriteLine($"\u001b[1;35m{text}\u001b[0m");
}
