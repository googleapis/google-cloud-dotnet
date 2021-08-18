// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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
using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository = LibGit2Sharp.Repository;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class PushCommand : CommandBase
    {
        private const string AccessTokenEnvironmentVariable = "GITHUB_ACCESS_TOKEN";
        private const string RepositoryOwner = "googleapis";
        private const string RepositoryName = "google-cloud-dotnet";
        private const string ApplicationName = "google-cloud-dotnet-release-manager";
        private const string AutoreleasePendingLabel = "autorelease: pending";

        public PushCommand()
            : base("push", "Push the current branch to GitHub and create a pull request with an autorelease tag")
        {
        }

        protected override void ExecuteImpl(string[] args) => InternalExecute();

        internal void InternalExecute()
        {
            string gitHubToken = Environment.GetEnvironmentVariable(AccessTokenEnvironmentVariable);
            if (string.IsNullOrEmpty(gitHubToken))
            {
                throw new UserErrorException($"This command requires a non-empty value for the {AccessTokenEnvironmentVariable} environment variable.");
            }
            var gitHubClient = CreateGitHubClient(gitHubToken);

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                ValidateNoChanges(repo);
                // TODO: "--force" mode to skip this.
                ValidateProjectReferences();
                var origin = GetOriginRemote(repo);

                string branch = PushBranch(repo, origin, gitHubToken);
                CreatePullRequest(repo, gitHubClient, origin, branch);
            }
        }

        private GitHubClient CreateGitHubClient(string gitHubToken) =>
            new GitHubClient(new ProductHeaderValue(ApplicationName))
            {
                Credentials = new Octokit.Credentials(gitHubToken)
            };

        private void ValidateNoChanges(Repository repo)
        {
            RepositoryStatus status = repo.RetrieveStatus();
            if (status.IsDirty)
            {
                throw new UserErrorException($"Cannot execute '{Command}' command while the local repository contains uncommitted changes.");
            }
        }

        private void ValidateProjectReferences()
        {
            var catalog = ApiCatalog.Load();
            var newReleaseIds = FindChangedVersions().Select(change => change.Id).ToList();
            foreach (var id in newReleaseIds)
            {
                var api = catalog[id];
                var projectReferences = api.Dependencies.Where(p => p.Value == "project").Select(p => p.Key);
                var badReferences = projectReferences.Except(newReleaseIds).ToList();
                if (badReferences.Any())
                {
                    throw new UserErrorException(
                        $"Project {api.Id} contains project references to projects outside the release set: {string.Join(", ", badReferences)}");
                }
            }
        }

        private Remote GetOriginRemote(Repository repo)
        {
            var originRemote = repo.Network.Remotes.FirstOrDefault(r => r.Name == "origin");
            if (originRemote is null)
            {
                throw new UserErrorException("No origin remote configured");
            }
            string url = originRemote.Url;
            if (!url.StartsWith("https://github.com/"))
            {
                throw new UserErrorException($"Origin remote is not on GitHub. Url: {url}");
            }
            // TODO: Do we mind if the origin remote is googleapis/google-cloud-dotnet?
            // Probably not, so long as we don't use a primary branch.
            return originRemote;
        }

        /// <summary>
        /// Pushes the local branch to the given remote.
        /// </summary>
        /// <returns>The name of the branch it's been pushed to.</returns>
        private string PushBranch(Repository repo, Remote origin, string gitHubToken)
        {
            var currentBranch = repo.Head;
            var remoteBranchName = $"release-pr-{DateTime.UtcNow:yyyyMMddTHHmm'Z'}";
            Console.WriteLine($"Pushing {currentBranch.FriendlyName} to {remoteBranchName} on origin");
            CredentialsHandler credentials = (url, user, cred) => new UsernamePasswordCredentials { Username = gitHubToken, Password = "" };
            // TODO: Work out why I can't pass currentBranch.FriendlyName in as the src.
            repo.Network.Push(origin, $"HEAD:refs/heads/{remoteBranchName}", new PushOptions { CredentialsProvider = credentials });

            return remoteBranchName;
        }

        private void CreatePullRequest(Repository repo, GitHubClient gitHubClient, Remote origin, string branch)
        {
            // Oktokit is async-heavy, but we don't want to make ICommand asynchronous just for that.
            CreatePullRequestAsync().GetAwaiter().GetResult();

            async Task CreatePullRequestAsync()
            {
                string user = origin.Url.Substring("https://github.com/".Length).Split('/').First();
                string head = $"{user}:{branch}";

                var commitMessage = repo.Commits.First().Message;
                var commitMessageLines = commitMessage.Replace("\r", "").Split('\n').ToList();
                var pullRequestLines = UnwrapLines(commitMessageLines);

                var request = new NewPullRequest(pullRequestLines.First(), head, "master")
                {
                    Body = string.Join('\n', pullRequestLines.Skip(1))
                };
                var pullRequest = await gitHubClient.PullRequest.Create(RepositoryOwner, RepositoryName, request);
                Console.WriteLine($"Created pull request {pullRequest.Number}");

                // Note: using a collection initializer looks reasonable, but fails with an NRE, because the Labels
                // property is lazily initialized :(
                var issueUpdate = new IssueUpdate();
                issueUpdate.AddLabel(AutoreleasePendingLabel);
                await gitHubClient.Issue.Update(RepositoryOwner, RepositoryName, pullRequest.Number, issueUpdate);

                Console.WriteLine($"Applied '{AutoreleasePendingLabel}' label to pull request.");
                Console.WriteLine($"Done! When the following pull request is reviewed and merged, it will be automatically released:");
                // We put the pull request URL on a line on its own to make it easier to copy/paste. 
                Console.WriteLine(pullRequest.HtmlUrl);
            }
        }

        /// <summary>
        /// Unwraps the given sequence of lines to be more suitable for a GitHub PR/release message.
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
