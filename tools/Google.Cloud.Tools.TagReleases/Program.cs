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
        private const string RepositoryOwner = "GoogleCloudPlatform";
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
            var newReleases = await ComputeNewReleasesAsync(client, apis);
            ValidateChanges(newReleases);

            if (!ConfirmReleases(apis, newReleases))
            {
                return 0;
            }

            await MakeReleasesAsync(client, newReleases, commit);
            Console.WriteLine();
            Console.WriteLine($"Release tags created. Please start the Kokoro release job with commit hash \"{commit}\" and wait for an email with the result.");
            Console.WriteLine($"For a manual release, run ./buildrelease.sh {commit}");
            return 0;
        }

        private static async Task<string> FetchRemoteCommitAsync(GitHubClient client)
        {
            var remoteBranch = await client.Repository.Branch.Get(RepositoryOwner, RepositoryName, TargetBranch);
            string sha = remoteBranch.Commit.Sha;
            Console.WriteLine($"Current GitHub {TargetBranch} commit: {sha}");
            return sha;
        }

        private static void ValidateLocalRepository(string expectedCommit)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new LibGit2Sharp.Repository(root))
            {
                string tip = repo.Head.Tip.Sha;
                if (tip != expectedCommit)
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

        private static async Task<List<ApiMetadata>> ComputeNewReleasesAsync(GitHubClient client, List<ApiMetadata> allApis)
        {
            var tags = (await client.Repository.GetAllTags(RepositoryOwner, RepositoryName)).Select(tag => tag.Name);
            var noChange = allApis.Where(api => tags.Contains($"{api.Id}-{api.Version}") || api.Version.EndsWith("00")).ToList();
            return allApis.Except(noChange).ToList();
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

        private static bool ConfirmReleases(List<ApiMetadata> allApis, List<ApiMetadata> newReleases)
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

        private static async Task MakeReleasesAsync(GitHubClient client, List<ApiMetadata> newReleases, string commit)
        {
            foreach (var api in newReleases)
            {
                var gitRelease = new NewRelease($"{api.Id}-{api.Version}")
                {
                    Prerelease = !api.IsReleaseVersion,
                    Name = $"{api.Version} release of {api.Id}",
                    TargetCommitish = commit
                };
                // We could parallelize, but there's very little point.
                await client.Repository.Release.Create(RepositoryOwner, RepositoryName, gitRelease);
                Console.WriteLine($"Created release for {api.Id}");
            }
        }       
    }
}
