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
/// Helper class for GitHub API activities that aren't simply exposed via <see cref="GitHubClient"/>.
/// </summary>
public static class GitHub
{    
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
