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
    private readonly GitHubClient _client;
    private readonly PullRequestDetails _pullRequest;

    public PublishReporter(GitHubClient client, PullRequestDetails pullRequest)
    {
        _client = client;
        _pullRequest = pullRequest;
    }

    /// <summary>
    /// Publish the start of the release process on the given PR.
    /// </summary>
    public async Task StartAsync()
    {
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
        
        await _pullRequest.AddComment(_client, message);
    }

    /// <summary>
    /// Publish the end of the release process on the given PR.
    /// </summary>
    public async Task FinishAsync(bool buildSucceeded, string details)
    {
        (string message, string label) = buildSucceeded
            ? ("Release build succeeded.", "autorelease: published")
            : ("The release build failed! Please investigate!", "autorelease: failed");
        message += "\n" + details;
        await _pullRequest.AddComment(_client, message);
        await _pullRequest.AddLabel(_client, label);
        await _pullRequest.RemoveLabel(_client, "autorelease: tagged");
    }
}
