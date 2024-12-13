// Copyright 2024 Google LLC
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

using Octokit;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Command to show packages which have been tagged but not published.
/// </summary>
public class ShowPendingReleasesCommand : CommandBase
{
    public ShowPendingReleasesCommand() : base("show-pending-releases", "Shows releases which have been tagged but not published")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var gitHubToken = GitHubHelpers.GetGitHubAccessToken();
        var gitHubClient = GitHubHelpers.CreateGitHubClient(gitHubToken);

        // Oktokit is async-heavy, but we don't want to make ICommand asynchronous just for that.
        return ExecuteAsync(gitHubClient).GetAwaiter().GetResult();
    }

    private async Task<int> ExecuteAsync(GitHubClient client)
    {
        Console.WriteLine("Fetching tags");
        var tags = await client.Repository.GetAllTags(GitHubHelpers.RepositoryOwner, GitHubHelpers.RepositoryName);

        Console.WriteLine("Fetching PRs");
        var request = new SearchIssuesRequest
        {
            Repos = new RepositoryCollection { { GitHubHelpers.RepositoryOwner, GitHubHelpers.RepositoryName } },
            Type = IssueTypeQualifier.PullRequest,
            Labels = new[] { "autorelease: tagged" }
        };
        var result = await client.Search.SearchIssues(request);
        if (result.IncompleteResults)
        {
            Console.WriteLine("Warning: potentially incomplete results");
        }
        foreach (var item in result.Items.OrderBy(item => item.Number))
        {
            // There may be a way to do this without fetching the PR separately, but it's not too bad (and it's simple this way).
            // (Using Issue.PullRequest doesn't give us the information we need.)
            var pullRequest = await client.PullRequest.Get(GitHubHelpers.RepositoryOwner, GitHubHelpers.RepositoryName, item.Number);
            var sha = pullRequest.MergeCommitSha;
            var matchingTags = tags.Where(tag => tag.Commit.Sha == sha).ToList();
            if (matchingTags.Count != 1)
            {
                Console.WriteLine($"Error: Tag count {matchingTags.Count} for {pullRequest.HtmlUrl}");
                Console.WriteLine();
                continue;
            }

            // We print the tag name and the AUTORELEASE_PR value in exactly the form needed for manual release triggering.
            Console.WriteLine(matchingTags[0].Name);
            Console.WriteLine($"AUTORELEASE_PR={pullRequest.HtmlUrl}");
            Console.WriteLine();
        }
        Console.WriteLine($"Total pending releases: {result.Items.Count}");
        return 0;
    }
}
