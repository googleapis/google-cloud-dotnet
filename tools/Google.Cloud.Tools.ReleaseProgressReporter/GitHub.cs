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

using GitHubJwt;
using Octokit;

namespace Google.Cloud.Tools.ReleaseProgressReporter;

/// <summary>
/// Helper class to call GitHub APIs.
/// </summary>
public class GitHub
{
    private readonly GitHubClient _githubClient;

    public GitHub(string appId, string accessToken)
    {
        _githubClient = new GitHubClient(new ProductHeaderValue(appId))
        {
            Credentials = new Credentials(accessToken)
        };
    }

    /// <summary>
    /// Lists all the pull requests in the given repository.
    /// </summary>
    /// <param name="owner">The Owner of GitHub repository.</param>
    /// <param name="repoName">The GitHub repository name.</param>
    public async Task<IReadOnlyList<PullRequest>> ListPullRequestsAsync(string owner, string repoName) =>
        await _githubClient.PullRequest.GetAllForRepository(owner, repoName);

    /// <summary>
    /// Get the specific pull request from the given GitHub repository.
    /// </summary>
    /// <param name="owner">The Owner of GitHub repository.</param>
    /// <param name="repoName">The GitHub repository name.</param>
    /// <param name="number">Pull request number.</param>
    public async Task<PullRequest> GetPullRequestAsync(string owner, string repoName, int number) =>
        await _githubClient.PullRequest.Get(owner, repoName, number);

    /// <summary>
    /// Creates a pull request on the given GitHub repository.
    /// </summary>
    /// <param name="owner">The Owner of GitHub repository.</param>
    /// <param name="repoName">The GitHub repository name.</param>
    /// <param name="head">The branch (or git ref) where your changes are implemented. Must not be null.</param>
    /// <param name="baseBranch">The branch (or git ref) you want your changes pulled into. Must not be null.</param>
    /// <param name="title">The title of the pull request.</param>
    public async Task<PullRequest> CreatePullRequestAsync(string owner, string repoName, string head, string baseBranch, string title) =>
        await _githubClient.PullRequest.Create(owner, repoName, new NewPullRequest(title, head, baseBranch));

    /// <summary>
    /// Adds a comment on the given pull request.
    /// </summary>
    /// <param name="owner">The Owner of GitHub repository.</param>
    /// <param name="repoName">The GitHub repository name.</param>
    /// <param name="number">Pull request identifier.</param>
    /// <param name="comment">The comment to add on the pull request.</param>
    public async Task<IssueComment> CreatePullRequestCommentAsync(string owner, string repoName, int number, string comment) =>
        await _githubClient.Issue.Comment.Create(owner, repoName, number, comment);

    /// <summary>
    /// Adds the given label to the given pull request.
    /// </summary>
    /// <param name="owner">The Owner of GitHub repository.</param>
    /// <param name="repoName">The GitHub repository name.</param>
    /// <param name="number">Pull request identifier.</param>
    /// <param name="labels">Labels to add on the pull request.</param>
    public async Task<IReadOnlyList<Label>> AddIssueLabel(string owner, string repoName, int number, string[] labels) =>
        await _githubClient.Issue.Labels.AddToIssue(owner, repoName, number, labels);

    /// <summary>
    /// Adds the new labels and remove the given old labels.
    /// </summary>
    /// <param name="repoName">The GitHub repository name.</param>
    /// <param name="owner">The Owner of GitHub repository.</param>
    /// <param name="number">Pull request identifier.</param>
    /// <param name="newLabelsToAdd">New labels to add on the pull request.</param>
    /// <param name="oldLablesToRemove">Old labels to remove from the pull request.</param>
    public async Task<IReadOnlyList<Label>> UpdatePullLabelsAsync(string owner, string repoName, int number, string labelToAdd, string labelToRemove)
    {
        await _githubClient.Issue.Labels.RemoveFromIssue(owner, repoName, number, labelToRemove);
        return await AddIssueLabel(owner, repoName, number, new string[] { labelToAdd });
    }

    /// <summary>
    /// Fetches a GitHub access token, requested from a JWT signed with a private key.
    /// </summary>
    /// <param name="privateKeyPath">The path to the private key file.</param>
    /// <param name="appId">The ID of the application the key is associated with.</param>
    /// <param name="installationId">The ID of the installation the key is associated with.</param>
    public static async Task<string> FetchGitHubAccessTokenFromPrivateKey(string privateKeyPath, string appId, string installationId)
    {
        var keySource = new FilePrivateKeySource(privateKeyPath);
        var generator = new GitHubJwtFactory
        (
            keySource,
            new GitHubJwtFactoryOptions
            {
                AppIntegrationId = int.Parse(appId),
                ExpirationSeconds = 60 // 10 minutes is the maximum time allowed.
            }
        );
        var baseClient = new GitHubClient(new ProductHeaderValue(appId))
        {
            Credentials = new Credentials(generator.CreateEncodedJwtToken(), AuthenticationType.Bearer)
        };
        var response = await baseClient.GitHubApps.CreateInstallationToken(long.Parse(installationId)).ConfigureAwait(false);
        return response.Token;
    }
}
