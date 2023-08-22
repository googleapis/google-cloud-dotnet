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

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.ReleaseProgressReporter;
using Octokit;

// Note: CommandLineParser has not been used here for the sake of simplicity.
if (args.Length < 1)
{
    throw new UserErrorException("Please specify the progress point: 'start' or 'finish'.");
}

var progress = args[0];
PullRequestDetails pr = PullRequestDetails.FromUrl(GetRequiredEnvironmentVariable("AUTORELEASE_PR"));
GitHubClient client = await GetGitHubClientFromEnvironment();
PublishReporter reporter = new PublishReporter(client, pr);

switch (progress)
{
    case "start":
        await reporter.StartAsync();
        break;
    case "finish":
        bool status = Convert.ToBoolean(args[1]);
        string publishDetails = Environment.GetEnvironmentVariable("PUBLISH_DETAILS") ?? "";
        await reporter.FinishAsync(status, publishDetails);
        break;
    default:
        throw new UserErrorException($"Invalid progress point: '{progress}'. Available options are (start, finish)");
}

async Task<GitHubClient> GetGitHubClientFromEnvironment()
{
    var appId = File.ReadAllText(GetRequiredEnvironmentVariable("APP_ID_PATH"));
    string? accessToken = Environment.GetEnvironmentVariable("GITHUB_TOKEN");
    if (accessToken is null)
    {
        // Admittedly these are only required when GITHUB_TOKEN isn't set, but it's close enough.
        string privateKeyPath = GetRequiredEnvironmentVariable("GITHUB_PRIVATE_KEY_PATH");
        var installationId = File.ReadAllText(GetRequiredEnvironmentVariable("INSTALLATION_ID_PATH"));
        accessToken = await GitHub.FetchGitHubAccessTokenFromPrivateKey(privateKeyPath, appId, installationId);
    }
    return new GitHubClient(new ProductHeaderValue(appId))
    {
        Credentials = new Credentials(accessToken)
    };
}

string GetRequiredEnvironmentVariable(string variable)
{
    var value = Environment.GetEnvironmentVariable(variable) ?? "";
    if (value == "")
    {
        throw new UserErrorException($"Environment variable '{variable}' must be set and non-empty.");
    }
    return value;
}
