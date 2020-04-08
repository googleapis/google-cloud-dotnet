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
    /// - Fetch all tags from GitHub
    /// - Fetch API catalog from specified commit on GitHub
    /// - Work out which packages would need to be tagged
    /// - Check that there are no project references outside that package set
    /// - Request confirmation of tagging
    /// - Perform tagging
    /// </summary>
    internal class Program
    {
        private const string RepositoryOwner = "googleapis";
        private const string RepositoryName = "google-cloud-dotnet";
        private const string ApplicationName = "google-cloud-dotnet-tagreleases";

        private readonly Config _config;
        private readonly GitHubClient _client;

        private Program(Config config)
        {
            _config = config;
            _client = new GitHubClient(new ProductHeaderValue(ApplicationName))
            {
                Credentials = new Credentials(config.GitHubToken)
            };
        }

        /// <summary>
        /// Skeleton of execution, with no real business logic. This method has been
        /// separated from <see cref="RunAsync"/> for clarity.
        /// </summary>
        private static async Task<int> Main(string[] args)
        {
            try
            {
                var config = Config.FromCommandLine(args);
                if (!config.IsValid)
                {
                    config.DisplayUsage();
                    return 1;
                }
                var program = new Program(config);
                await program.RunAsync();
                return 0;
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

        private async Task RunAsync()
        {
            var apis = await LoadApis();
            var tags = await FetchTags();
            var newReleases = ComputeNewReleases(apis, tags);
            if (!newReleases.Any())
            {
                Console.WriteLine($"No releases need to be created for {_config.Committish}. Exiting.");
                return;
            }
            var commit = await FetchAndDisplayCommit();

            CheckProjectReferences(newReleases);
            if (ConfirmReleases(newReleases))
            {
                await CreateReleasesAsync(newReleases, commit);
            }            
        }

        private async Task<List<ApiMetadata>> LoadApis()
        {
            var allContents = await _client.Repository.Content.GetAllContentsByRef(RepositoryOwner, RepositoryName, ApiMetadata.RelativeCatalogPath, _config.Committish);
            var json = allContents.Single().Content;
            return ApiMetadata.LoadApisFromJson(json);
        }

        private async Task<List<string>> FetchTags()
        {
            // We have a lot of tags - fetch a large number at a time to make this a lot quicker.
            Console.WriteLine($"Fetching all tags from GitHub");
            var tags = await _client.Repository.GetAllTags(RepositoryOwner, RepositoryName, new ApiOptions { PageSize = 2000 });
            Console.WriteLine($"Fetched {tags.Count} tags");
            return tags.Select(tag => tag.Name).ToList();
        }

        private async Task<GitHubCommit> FetchAndDisplayCommit()
        {
            var commit = await _client.Repository.Commit.Get(RepositoryOwner, RepositoryName, _config.Committish);
            Console.WriteLine($"Commit to tag: {commit.Sha}");
            // Make sure it's clear which part of the output is the commit message.
            Console.WriteLine("---------");
            Console.WriteLine(commit.Commit.Message);
            Console.WriteLine("---------");
            return commit;
        }

        private List<ApiMetadata> ComputeNewReleases(List<ApiMetadata> allApis, List<string> tags)
        {
            var noChange = allApis.Where(api => tags.Contains($"{api.Id}-{api.Version}") || api.Version.EndsWith("00")).ToList();
            return allApis.Except(noChange).ToList();
        }

        /// <summary>
        /// Check for invalid project references.
        /// Project references (in production code) are okay so long as all the targets of the references
        /// are also going to be released. If this is not the case, the dependencies within the target could be different
        /// to the ones in the public package version, causing a dependency issue in the package we're about to publish.
        /// (This caused issue #1280 for example.)
        /// </remarks>
        private void CheckProjectReferences(List<ApiMetadata> newReleases)
        {
            if (_config.SkipProjectReferenceCheck)
            {
                return;
            }
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

        private bool ConfirmReleases(List<ApiMetadata> newReleases)
        {
            Console.WriteLine("APIs requiring a new release:");
            newReleases.ForEach(api => Console.WriteLine($"{api.Id,-50} v{api.Version}"));

            Console.Write("Go ahead and create releases? (y/n) ");
            string response = Console.ReadLine();
            return response == "y";
        }

        private async Task CreateReleasesAsync(List<ApiMetadata> newReleases, GitHubCommit commit)
        {
            var originalMessage = commit.Commit.Message;
            var unwrappedMessage = string.Join("\n", UnwrapLines(originalMessage.Split('\n')));

            Console.WriteLine("Creating releases with tags:");
            foreach (var api in newReleases)
            {
                var tag = $"{api.Id}-{api.Version}";
                var gitRelease = new NewRelease(tag)
                {
                    Prerelease = !api.IsReleaseVersion,
                    Name = $"{api.Id} version {api.Version}",
                    TargetCommitish = commit.Sha,
                    Body = unwrappedMessage
                };
                // We could parallelize, but there's very little point.
                await _client.Repository.Release.Create(RepositoryOwner, RepositoryName, gitRelease);
                Console.WriteLine(tag);
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
