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
using static Google.Cloud.Tools.ReleaseManager.GitHubHelpers;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class PushCommand : CommandBase
    {
        private const string AssigneeEnvironmentVariable = "RELEASE_PR_ASSIGNEE";
        private const string AutoreleasePendingLabel = "autorelease: pending";
        private const string AutomergeExactLabel = "automerge: exact";

        public PushCommand()
            : base("push", "Push the current branch to GitHub and create a pull request with an autorelease tag")
        {
        }

        protected override int ExecuteImpl(string[] args) => InternalExecute();

        internal int InternalExecute()
        {
            var gitHubToken = GetGitHubAccessToken();
            var gitHubClient = CreateGitHubClient(gitHubToken);

            using var repo = new Repository(RootLayout.RepositoryRoot);
            ValidateNoChanges(repo);
            // TODO: "--force" mode to skip this.
            ValidateProjectReferences();
            var upstream = GetUpstreamRemote(repo);

            string branch = PushBranch(repo, upstream, gitHubToken);
            CreatePullRequest(repo, gitHubClient, branch);
            return 0;
        }

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
            var catalog = ApiCatalog.Load(RootLayout);
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

        private Remote GetUpstreamRemote(Repository repo)
        {
            var upstreamRemote = repo.Network.Remotes.FirstOrDefault(r => r.Name == "upstream");
            if (upstreamRemote is null)
            {
                throw new UserErrorException("No upstream remote configured");
            }
            string actualUrl = upstreamRemote.Url;
            string expectedUrl = $"https://github.com/{GitHubHelpers.RepositoryOwner}/{RepositoryName}.git";
            if (expectedUrl != actualUrl)
            {
                throw new UserErrorException($"Upstream remote is not as expected. Actual URL: {actualUrl}. Expected URL: {expectedUrl}");
            }
            return upstreamRemote;
        }

        /// <summary>
        /// Pushes the local branch to the given remote.
        /// </summary>
        /// <returns>The name of the branch it's been pushed to.</returns>
        private string PushBranch(Repository repo, Remote upstream, string gitHubToken)
        {
            var currentBranch = repo.Head;
            var remoteBranchName = $"release-pr-{DateTime.UtcNow:yyyyMMddTHHmmss'Z'}";
            CredentialsHandler credentials = (url, user, cred) => new UsernamePasswordCredentials { Username = RepositoryOwner, Password = gitHubToken };
            // TODO: Work out why I can't pass currentBranch.FriendlyName in as the src.
            repo.Network.Push(upstream, $"HEAD:refs/heads/{remoteBranchName}", new PushOptions { CredentialsProvider = credentials });

            return remoteBranchName;
        }

        private void CreatePullRequest(Repository repo, GitHubClient gitHubClient, string branch)
        {
            // Oktokit is async-heavy, but we don't want to make ICommand asynchronous just for that.
            CreatePullRequestAsync().GetAwaiter().GetResult();

            async Task CreatePullRequestAsync()
            {
                string head = $"{RepositoryOwner}:{branch}";

                var commitMessage = repo.Commits.First().Message;
                var commitMessageLines = commitMessage.Replace("\r", "").Split('\n').ToList();
                var pullRequestLines = UnwrapLines(commitMessageLines);

                var request = new NewPullRequest(pullRequestLines.First(), head, "main")
                {
                    Body = string.Join('\n', pullRequestLines.Skip(1))
                };
                var pullRequest = await gitHubClient.PullRequest.Create(RepositoryOwner, RepositoryName, request);

                // Note: using a collection initializer looks reasonable, but fails with an NRE, because the Labels
                // property is lazily initialized :(
                var issueUpdate = new IssueUpdate();
                issueUpdate.AddLabel(AutoreleasePendingLabel);
                issueUpdate.AddLabel(AutomergeExactLabel);
                string assignee = Environment.GetEnvironmentVariable(AssigneeEnvironmentVariable);
                if (!string.IsNullOrEmpty(assignee))
                {
                    issueUpdate.AddAssignee(assignee);
                }
                await gitHubClient.Issue.Update(RepositoryOwner, RepositoryName, pullRequest.Number, issueUpdate);

                // The PR link is useful to be able to click on, and occasionally the release branch is useful.
                Console.WriteLine($"Created branch {branch} and PR {pullRequest.HtmlUrl}");
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
