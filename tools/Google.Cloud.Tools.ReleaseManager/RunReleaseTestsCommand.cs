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
using Google.Cloud.Tools.ReleaseManager.ContainerCommands;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public sealed class RunReleaseTestsCommand : CommandBase
{
    private const string ReleaseIdPrefix = "Librarian-Release-ID: ";
    private const string ReleaseLibraryPrefix = "Librarian-Release-Library: ";

    public RunReleaseTestsCommand() : base("run-release-tests", "Runs integration tests for a release PR", new[] { "release-id" })
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string targetReleaseId = args[0];
        using var repo = new Repository(RootLayout.RepositoryRoot);

        bool seenReleaseId = false;
        var testCommand = new IntegrationTestLibraryCommand();

        var releasesToTest = new List<ReleaseCommit>();

        // We go back until we *have* seen the target release ID,
        // then continue until we see a commit with a different/absent release ID.
        foreach (var commit in GetCommitSequence(repo.Head.Tip))
        {
            string commitReleaseId = GetReleaseId(commit);
            if (commitReleaseId != targetReleaseId)
            {
                if (seenReleaseId)
                {
                    // We're done.
                    break;
                }
                // Keep looking back.
                Log($"Skipping commit {commit.Sha}; no/wrong release ID");
                continue;
            }
            seenReleaseId = true;

            // Definitely in the release; potentially test the library for this commit.
            var libraryId = GetReleaseLibrary(commit);
            if (libraryId.StartsWith(ContainerOptions.UtilityDocsLibraryPrefix, StringComparison.Ordinal))
            {
                Log($"Skipping integration tests for {libraryId}; it's a docs package.");
                continue;
            }
            if (libraryId.StartsWith(ContainerCommand.ToolsLibraryPrefix, StringComparison.Ordinal))
            {
                Log($"Skipping additional integration tests for {libraryId}; it's a tools package.");
                continue;
            }

            // Note: this checks for the presence of integration tests at HEAD rather than at the given commit.
            // It's *theoretically possible* that there were integration tests at the given commit which have
            // since been deleted, but it's staggeringly unlikely - and this command is only run for
            // extra confidence with respect to Windows. (The integration tests will be run on Linux in the release job
            // anyway.)
            if (!HasIntegrationTests(RootLayout.CreateRepositoryApiLayout(libraryId)))
            {
                Log($"Skipping additional integration tests for {libraryId}; there are no handwritten snippets or integration tests.");
                continue;
            }

            releasesToTest.Add(new(libraryId, commit));
        }

        Log($"Running integration tests for {releasesToTest.Count} releases");

        foreach (var (libraryId, commit) in releasesToTest)
        {
            Log($"Checking out repo at commit {commit.Sha}");
            Commands.Checkout(repo, commit.Sha);

            Log($"Testing {libraryId} at {commit.Sha}");
            var commandArgs = new Dictionary<string, string>
            {
                { ContainerOptions.LibraryIdOption, libraryId },
                { ContainerOptions.RepoRootOption, RootLayout.RepositoryRoot },
            };
            var result = testCommand.Execute(new ContainerOptions(commandArgs));
            if (result != 0)
            {
                return result;
            }
            Console.WriteLine();
        }
        Console.WriteLine("All tests passed for all release commits.");
        return 0;

        void Log(string message) =>
            Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z {message}");
    }

    private record ReleaseCommit(string LibraryId, Commit commit);

    /// <summary>
    /// Checks whether files to run integration tests exist at the given commit.
    /// If there are no snippets, no integration tests there's no point in checking out the repo.
    /// Note that this returns false for a library which only has smoke tests, as we expect
    /// this command to be run basically for Windows testing. A lot of libraries have smoke
    /// tests but are otherwise purely generated - we don't need to test those.
    /// </summary>
    private static bool HasIntegrationTests(RepositoryApiLayout apiLayout)
    {
        string apiRoot = apiLayout.SourceDirectory;
        string id = apiLayout.Id;
        if (!Directory.Exists(apiRoot))
        {
            // This is probably a package group, so we should run the tests.
            // If it's entirely incorrect, we'll figure that out when we try to run the tests.
            return true;
        }
        // If an IntegrationTests directory exists at all, there will be integration tests.
        if (Directory.Exists(Path.Combine(apiRoot, $"{id}.IntegrationTests")))
        {
            return true;
        }
        // Most libraries will have a snippets directory, but we only
        // want to run the tests if there are handwritten files in it.
        var snippetsDirectory = Path.Combine(apiRoot, $"{id}.Snippets");
        if (!Directory.Exists(snippetsDirectory))
        {
            return false;
        }
        foreach (var file in Directory.EnumerateFiles(snippetsDirectory, "*.cs"))
        {
            if (!file.EndsWith(".g.cs", StringComparison.Ordinal))
            {
                return true;
            }
        }
        // All snippets are generated; skip.
        return false;
    }

    private static IEnumerable<Commit> GetCommitSequence(Commit commit)
    {
        while (true)
        {
            yield return commit;
            var parents = commit.Parents.ToList();
            if (parents.Count != 1)
            {
                throw new UserErrorException($"Commit {commit.Sha} has multiple parents");
            }
            commit = parents[0];
        }
    }

    private static string GetReleaseId(Commit commit) =>
        commit
            .Message
            .Split('\n')
            .FirstOrDefault(line => line.StartsWith(ReleaseIdPrefix))
            ?.Substring(ReleaseIdPrefix.Length);

    private static string GetReleaseLibrary(Commit commit) =>
        commit
            .Message
            .Split('\n')
            .FirstOrDefault(line => line.StartsWith(ReleaseLibraryPrefix))
            ?.Substring(ReleaseLibraryPrefix.Length)
            ?? throw new UserErrorException($"No release library in for {commit.Sha}");
}
