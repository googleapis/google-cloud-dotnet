// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Tools.Common;
using LibGit2Sharp;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.TagReleases
{
    /// <summary>
    /// Tool to tag releases on GitHub for any projects where there's no existing tag
    /// with the currently-specified version.
    /// 
    /// Steps taken:
    /// 
    /// - Find the current head of the master branch on github
    /// - Check that the local repo is at the same commit
    /// - Check that the local repo has no pending changes to apis.json
    /// - Work out which packages would need to be tagged
    /// - Check that there are no project references outside that package set
    /// - Request confirmation of tagging
    /// - Perform tagging
    /// </summary>
    internal class Program
    {
        private const string RepositoryOwner = "googleapis";
        private const string RepositoryName = "google-cloud-dotnet";
        private const string TargetBranch = "master";
        private const string ApplicationName = "google-cloud-dotnet-tagreleases";

        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Arguments: <github access token>");
                return 1;
            }
            try
            {
                return MainAsync(args).GetAwaiter().GetResult();
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Configuration error: {e.Message}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 1;
            }
        }

        private static async Task<int> MainAsync(string[] args)
        {
            var client = new GitHubClient(new ProductHeaderValue(ApplicationName))
            {
                Credentials = new Octokit.Credentials(args[0])
            };
            var commit = await FetchRemoteCommitAsync(client);
            ValidateLocalRepository(commit);
            var apis = ApiMetadata.LoadApis();
            var newReleases = ComputeNewReleasesAsync(apis);
            ValidateChanges(newReleases);
            if (!ConfirmReleases(newReleases))
            {
                return 0;
            }

            await MakeReleasesAsync(client, newReleases, commit);
            Console.WriteLine();
            Console.WriteLine($"Release tags created. Please start the Kokoro release job with commit hash \"{commit.Sha}\" and wait for an email with the result.");
            Console.WriteLine($"For a manual release, run ./buildrelease.sh {commit.Sha}");
            return 0;
        }

        private static async Task<GitHubCommit> FetchRemoteCommitAsync(GitHubClient client)
        {
            var commit = await client.Repository.Commit.Get(RepositoryOwner, RepositoryName, TargetBranch);
            Console.WriteLine($"Current GitHub {TargetBranch} commit: {commit.Sha}");
            return commit;
        }

        private static void ValidateLocalRepository(GitHubCommit expectedCommit)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new LibGit2Sharp.Repository(root))
            {
                string tip = repo.Head.Tip.Sha;
                if (tip != expectedCommit.Sha)
                {
                    throw new UserErrorException($"Current local commit: {tip}. Aborting.");
                }
                var status = repo.RetrieveStatus("apis/apis.json");
                if (status != FileStatus.Unaltered)
                {
                    throw new UserErrorException($"Expected apis.json to be unaltered. Current status: {status}. Aborting.");
                }
            }
        }

        private static List<ApiMetadata> ComputeNewReleasesAsync(List<ApiMetadata> allApis)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new LibGit2Sharp.Repository(root))
            {
                var tags = repo.Tags.Select(tag => tag.FriendlyName).ToList();
                var noChange = allApis.Where(api => tags.Contains($"{api.Id}-{api.Version}") || api.Version.EndsWith("00")).ToList();
                return allApis.Except(noChange).ToList();
            }
        }

        /// <summary>
        /// Validates the set of changes.
        /// </summary>
        /// <remarks>
        /// <para>Current checks:</para>
        /// <para>
        /// Project references (in production code) are okay so long as all the targets of the references
        /// are also going to be released. If this is not the case, the dependencies within the target could be different
        /// to the ones in the public package version, causing a dependency issue in the package we're about to publish.
        /// (This caused issue #1280 for example.)
        /// </para>
        /// </remarks>
        private static void ValidateChanges(List<ApiMetadata> newReleases)
        {
            var newReleaseNames = newReleases.Select(api => api.Id).ToList();
            foreach (var api in newReleases)
            {
                var projectReferences = api.Dependencies.Where(p => p.Value == "project").Select(p => p.Key);
                var badReferences = projectReferences.Except(newReleaseNames).ToList();
                if (badReferences.Any())
                {
                    throw new UserErrorException(
                        $"Project {api.Id} contains project references to projects outside the release set: {string.Join(", ", badReferences)}");
                }
            }
        }

        private static bool ConfirmReleases(List<ApiMetadata> newReleases)
        {
            Console.WriteLine("APIs requiring a new release:");
            newReleases.ForEach(api => Console.WriteLine($"{api.Id,-50} v{api.Version}"));

            if (!newReleases.Any())
            {
                Console.WriteLine("No releases need to be created. Exiting.");
                return false;
            }

            Console.WriteLine("Go ahead and create releases? (y/n)");
            string response = Console.ReadLine();
            return response == "y";
        }

        private static async Task MakeReleasesAsync(GitHubClient client, List<ApiMetadata> newReleases, GitHubCommit commit)
        {
            var originalMessage = commit.Commit.Message;
            var unwrappedMessage = string.Join("\n", UnwrapLines(originalMessage.Split('\n')));

            foreach (var api in newReleases)
            {
                var gitRelease = new NewRelease($"{api.Id}-{api.Version}")
                {
                    Prerelease = !api.IsReleaseVersion,
                    Name = $"{api.Version} release of {api.Id}",
                    TargetCommitish = commit.Sha,
                    Body = unwrappedMessage
                };
                // We could parallelize, but there's very little point.
                await client.Repository.Release.Create(RepositoryOwner, RepositoryName, gitRelease);
                Console.WriteLine($"Created release for {api.Id}");
            }
        }

        /// <summary>
        /// Unwraps the given sequence of lines to be more suitable for a GitHub commit/release message.
        /// (GitHub Markdown formatting breaks on newlines, which can be annoying.)
        /// </summary>
        private static IEnumerable<string> UnwrapLines(IEnumerable<string> lines)
        {
            var builder = new StringBuilder();
            foreach (var line in lines)
            {
                bool emptyLine = string.IsNullOrWhiteSpace(line);
                // Don't unwrap lists or empty lines.
                if (line.StartsWith("- ") || line.StartsWith("* ") || line.StartsWith(" ") || emptyLine)
                {
                    if (builder.Length > 0)
                    {
                        yield return builder.ToString();
                        builder.Clear();
                    }
                }
                if (builder.Length > 0)
                {
                    builder.Append(" ");
                }
                builder.Append(line);

                // Yield immediately for Markdown line breaks or empty lines
                if (line.EndsWith("  ") || emptyLine)
                {
                    yield return builder.ToString();
                    builder.Clear();
                }
            }
            // Yield anything we still have
            if (builder.Length > 0)
            {
                yield return builder.ToString();
            }
        }
    }
}
