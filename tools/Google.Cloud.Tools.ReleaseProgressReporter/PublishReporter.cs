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

namespace Google.Cloud.Tools.ReleaseProgressReporter;

/// <summary>
/// Helper class used to report the releases.
/// </summary>
public class PublishReporter
{
    private readonly string _appId;
    private readonly string _pr;
    private readonly string _installationId;
    private readonly string _privateKeyPath;
    private readonly string _githubToken;

    public PublishReporter(string appId, string pr, string installationId, string privateKeyPath, string githubToken)
    {
        _appId = appId;
        _pr = pr;
        _installationId = installationId;
        _privateKeyPath = privateKeyPath;
        _githubToken = githubToken;
    }

    private async Task<string> GetGitHubTokenAsync()
    {
        var keySource = new GitHubJwt.FilePrivateKeySource(_privateKeyPath);
        var generator = new GitHubJwt.GitHubJwtFactory
        (
            keySource,
            new GitHubJwt.GitHubJwtFactoryOptions
            {
                AppIntegrationId = Convert.ToInt32(_appId),
                ExpirationSeconds = 60 // 10 minutes is the maximum time allowed.
            }
        );
        var baseClient = new GitHubClient(new ProductHeaderValue(_appId))
        {
            Credentials = new Credentials(generator.CreateEncodedJwtToken(), AuthenticationType.Bearer)
        };
        var response = await baseClient.GitHubApps.CreateInstallationToken(Convert.ToInt64(_installationId)).ConfigureAwait(false);
        return response.Token;
    }

    /// <summary>
    /// Publish the start of the release process on the given PR.
    /// </summary>
    public async Task StartAsync()
    {
        var token = _githubToken ?? await GetGitHubTokenAsync();
        var github = new GitHub(_appId, token);
        var prDetails = PullRequestDetails.FromUrl(_pr);
        var buildUrl = Environment.GetEnvironmentVariable("CLOUD_LOGGING_URL");

        if (string.IsNullOrEmpty(buildUrl))
        {
            var buildId = Environment.GetEnvironmentVariable("KOKORO_BUILD_ID");
            if (!string.IsNullOrEmpty(buildId))
            {
                buildUrl = $"http://sponge/{buildId}";
            }
        }
        string message = string.IsNullOrEmpty(buildUrl) ?
            "The release build has started, but the build log URL could not be determined."
            : $"The release build has started; the log can be viewed [here]({buildUrl}).";

        await github.CreatePullRequestCommentAsync(prDetails.RepoName, prDetails.Owner, prDetails.Id, message).ConfigureAwait(false);
    }

    /// <summary>
    /// Publish the end of the release process on the given PR.
    /// </summary>
    public async Task FinishAsync(bool buildSucceeded, string details)
    {
        var token = _githubToken ?? await GetGitHubTokenAsync();
        var github = new GitHub(_appId, token);
        var prDetails = PullRequestDetails.FromUrl(_pr);
        string message;
        string label;
        if (buildSucceeded)
        {
            message = "Release build succeeded";
            label = "autorelease: published";
        }
        else
        {
            message = "The release build failed! Please investigate!";
            label = "autorelease: failed";
        }
        message += "\n" + details;
        await github.CreatePullRequestCommentAsync(prDetails.RepoName, prDetails.Owner, prDetails.Id, message).ConfigureAwait(false);
        await github.UpdatePullLabelsAsync(prDetails.RepoName, prDetails.Owner, prDetails.Id, label, labelToRemove: "autorelease: tagged").ConfigureAwait(false);
    }
}
