// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Octokit;
using System;

namespace Google.Cloud.Tools.ReleaseManager;

internal static class GitHubHelpers
{
    internal const string RepositoryOwner = "googleapis";
    internal const string RepositoryName = "google-cloud-dotnet";

    private const string ApplicationName = "google-cloud-dotnet-release-manager";

    private const string AccessTokenEnvironmentVariable = "GITHUB_ACCESS_TOKEN";

    /// <summary>
    /// Fetches a GitHub access token from the GITHUB_ACCESS_TOKEN environment variable,
    /// failing if the environment variable is missing/empty.
    /// </summary>
    internal static string GetGitHubAccessToken()
    {
        string gitHubToken = Environment.GetEnvironmentVariable(AccessTokenEnvironmentVariable);
        if (string.IsNullOrEmpty(gitHubToken))
        {
            throw new UserErrorException($"This command requires a non-empty value for the {AccessTokenEnvironmentVariable} environment variable.");
        }
        return gitHubToken;
    }

    /// <summary>
    /// Creates a GitHub client with the specified token.
    /// </summary>
    internal static GitHubClient CreateGitHubClient(string gitHubToken) =>
        new GitHubClient(new ProductHeaderValue(ApplicationName))
        {
            Credentials = new Octokit.Credentials(gitHubToken)
        };
}
