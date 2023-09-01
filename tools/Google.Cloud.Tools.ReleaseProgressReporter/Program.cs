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

using Google.Cloud.Tools.ReleaseProgressReporter;
using Octokit;

// Note: CommandLineParser has not been used here for the sake of simplicity.
if (args.Length < 1)
{
    throw new Exception("Please specify the progress point: 'publish-reporter-script', 'start' or 'finish'.");
}

var progress = args[0];

switch (progress)
{
    case "publish-reporter-script":
        using (var stream = typeof(PublishReporter).Assembly.GetManifestResourceStream("Google.Cloud.Tools.ReleaseProgressReporter.publish_reporter.sh"))
        {
            if (stream is null)
            {
                throw new Exception("Unable to load reporter script");
            }
            var script = new StreamReader(stream).ReadToEnd();
            Console.WriteLine(script);
        }
        break;
    case "start":
        var startReporter = await CreatePublishReporter();
        await startReporter.StartAsync();
        break;
    case "finish":
        bool status = Convert.ToBoolean(args[1]);
        string publishDetails = Environment.GetEnvironmentVariable("PUBLISH_DETAILS") ?? "";
        var finishReporter = await CreatePublishReporter();
        await finishReporter.FinishAsync(status, publishDetails);
        break;
    default:
        throw new Exception($"Invalid progress point: '{progress}'. Available options are (publish-reporter-script, start, finish)");
}

async Task<PublishReporter> CreatePublishReporter()
{
    PullRequestDetails pr = PullRequestDetails.FromUrl(GetRequiredEnvironmentVariable("AUTORELEASE_PR"));
    GitHubClient client = await GetGitHubClientFromEnvironment();
    return new PublishReporter(client, pr);
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
        throw new Exception($"Environment variable '{variable}' must be set and non-empty.");
    }
    return value;
}
