// Copyright 2023 Google LLC
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

using Octokit;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseProgressReporter;

/// <summary>
/// Holds the details of the pull request.
/// </summary>
public class PullRequestDetails
{
    public string Owner { get; }
    public string RepoName { get; }
    public int Id { get; }

    public PullRequestDetails(string owner, string repoName, int id)
    {
        Owner = owner;
        RepoName = repoName;
        Id = id;
    }

    /// <summary>
    /// Extracts PR details from the given PR URL.
    /// </summary>
    /// <param name="url">The URL of the PR to extract the details from.</param>
    public static PullRequestDetails FromUrl(string url)
    {
        var match = Regex.Match(url, @"https://github\.com/(?<owner>.+?)/(?<repo>.+?)/pull/(?<number>\d+?)$");

        if (!match.Success)
        {
            throw new ArgumentException("Not a PR URL.");
        }

        return new PullRequestDetails(match.Groups["owner"].Value,
            match.Groups["repo"].Value,
            int.Parse(match.Groups["number"].Value));
    }

    public static PullRequestDetails? FromEnvironmentVariable()
    {
        var pullRequestUrl = Environment.GetEnvironmentVariable("AUTORELEASE_PR");
        return string.IsNullOrEmpty(pullRequestUrl) ? null : FromUrl(pullRequestUrl);
    }

    public static async Task<PullRequestDetails?> FromLocalRepo(GitHubClient client)
    {
        Console.WriteLine("Determining PR to report progress on");
        // Otherwise, use the current local repo to work out where to fetch pull requests from.
        // We currently assume that we're in a single level subdirectory (so ".." is the repo root) - because that's how
        // the tool is always used at the moment. If that turns out to be a problem, we can make this smarter.
        using var localRepo = new LibGit2Sharp.Repository("..");
        var headCommit = localRepo.Head.Tip.Sha;
        Console.WriteLine($"Searching for a PR with head/merge commit {headCommit}");

        var remote = localRepo.Network.Remotes.FirstOrDefault();
        if (remote is null)
        {
            Console.WriteLine("Local git repository has no remotes.");
            return null;
        }

        var match = Regex.Match(remote.PushUrl, @"https://github\.com/(?<owner>.+?)/(?<repo>.+?)\.git$");
        if (!match.Success)
        {
            Console.WriteLine($"Cannot determine owner and repo from push URL '{remote.PushUrl}'");
            return null;
        }
        string owner = match.Groups["owner"].Value;
        string repo = match.Groups["repo"].Value;

        Console.WriteLine("Fetching PRs");
        // We only fetch PRs created in the last 28 days, to avoid fetching huge numbers of ancient PRs.
        // PR autodetection is a convenience feature anyway: if we're really doing something unusual with
        // old release PRs, we can specify the environment variable.
        var now = DateTimeOffset.UtcNow;
        var request = new SearchIssuesRequest
        {
            Repos = new RepositoryCollection { { owner, repo } },
            Type = IssueTypeQualifier.PullRequest,
            Created = new DateRange(now.AddDays(-28), now)
        };
        var result = await client.Search.SearchIssues(request);
        Console.WriteLine($"Fetched {result.Items.Count} PRs");
        // Search from the most recent PR first.
        foreach (var item in result.Items.OrderByDescending(item => item.Number))
        {
            var pullRequest = await client.PullRequest.Get(owner, repo, item.Number);
            // There are two different commits that may be relevant here. We test and report both of them.
            var sha1 = pullRequest.Head.Sha;
            var sha2 = pullRequest.MergeCommitSha;
            Console.WriteLine($"PR {item.Number} commits: {sha1} / {sha2}");
            if (sha1 == headCommit || sha2 == headCommit)
            {
                Console.WriteLine($"Detected PR {item.Number} as the release PR.");
                return new PullRequestDetails(owner, repo, item.Number);
            }
        }
        return null;
    }

    /// <summary>
    /// Adds a comment to the pull request.
    /// </summary>
    /// <param name="client">The client to use to add the comment.</param>
    /// <param name="comment">The comment to add on the pull request.</param>
    public async Task<IssueComment> AddComment(GitHubClient client, string comment) =>
        await client.Issue.Comment.Create(Owner, RepoName, Id, comment);

    /// <summary>
    /// Adds the given label to the pull request.
    /// </summary>
    /// <param name="client">The client to use to add the label.</param>
    /// <param name="label">Label to add on the pull request.</param>
    public async Task AddLabel(GitHubClient client, string label) =>
        await client.Issue.Labels.AddToIssue(Owner, RepoName, Id, new string[] { label });

    /// <summary>
    /// Removes the given label from the pull request. If the label does not exist,
    /// the API error is swallowed.
    /// </summary>
    /// <param name="client">The client to use to add the label.</param>
    /// <param name="label">Label to remove on the pull request.</param>
    public async Task RemoveLabel(GitHubClient client, string label)
    {
        try
        {
            await client.Issue.Labels.RemoveFromIssue(Owner, RepoName, Id, label);
        }
        catch (NotFoundException)
        {
            Console.WriteLine($"Label '{label}' not found (when trying to remove)");
        }
    }
}
