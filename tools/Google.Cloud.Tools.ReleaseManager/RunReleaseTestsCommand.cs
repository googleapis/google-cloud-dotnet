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
                Console.WriteLine($"Skipping commit {commit.Sha}; no/wrong release ID");
                continue;
            }
            seenReleaseId = true;

            // Definitely in the release; test the library for this commit.
            var libraryId = GetReleaseLibrary(commit);
            if (libraryId.StartsWith(ContainerOptions.UtilityDocsLibraryPrefix, StringComparison.Ordinal))
            {
                Console.WriteLine($"Skipping integration tests for {libraryId}; it's a docs package.");
                continue;
            }
            Console.WriteLine($"Testing {libraryId} at {commit.Sha}");

            Commands.Checkout(repo, commit.Sha);

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
