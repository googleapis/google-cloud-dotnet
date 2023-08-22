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
    /// Extract the PR details from the given PR URL.
    /// It returns the <see cref="PullRequestDetails"/> if the PR URL is correct otherwise raise an exception.
    /// </summary>
    /// <param name="url">The URL of the PR to extract the details from.</param>
    public static PullRequestDetails FromUrl(string url)
    {
        var match = Regex.Match(url, @"https://github\.com/(?<owner>.+?)/(?<repo>.+?)/pull/(?<number>\d+?)$");

        if (!match.Success)
        {
            throw new Exception("Not a PR URL.");
        }

        return new PullRequestDetails(match.Groups["owner"].Value,
            match.Groups["repo"].Value,
            int.Parse(match.Groups["number"].Value));
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
    public async Task<IReadOnlyList<Label>> AddLabel(GitHubClient client, string label) =>
        await client.Issue.Labels.AddToIssue(Owner, RepoName, Id, new string[] { label });

    /// <summary>
    /// Removes the given label from the pull request.
    /// </summary>
    /// <param name="client">The client to use to add the label.</param>
    /// <param name="label">Label to remove on the pull request.</param>
    public async Task<IReadOnlyList<Label>> RemoveLabel(GitHubClient client, string label) =>
        await client.Issue.Labels.RemoveFromIssue(Owner, RepoName, Id, label);
}
