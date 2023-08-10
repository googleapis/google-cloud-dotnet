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

namespace Google.Cloud.Tools.ReleaseTool
{
    public class PublishReporter
    {
        private string GetGitHubToken(string appId, string installationId, string privateKey)
        {
            var generator = new GitHubJwt.GitHubJwtFactory
                (
                    new GitHubJwt.StringPrivateKeySource(privateKey),
                    new GitHubJwt.GitHubJwtFactoryOptions
                    {
                        AppIntegrationId = Convert.ToInt32(appId),
                        ExpirationSeconds = 600 // 10 minutes is the maximum time allowed
                    }
                );
            Console.WriteLine("github JWT has been generated");
            return generator.CreateEncodedJwtToken();
        }

        public async Task StartAsync(string appId, string installationId, string privateKey, string pr) =>
            await StartAsync(GetGitHubToken(appId, installationId, privateKey), pr, appId);

        public async Task StartAsync(string githubToken, string pr, string appId)
        {
            var github = new GitHub(appId, githubToken);
            var prDetails = PRDetailsExtractor.ExtractPRDetails(pr);
            var buildUrl = Environment.GetEnvironmentVariable("CLOUD_LOGGING_URL");

            if (string.IsNullOrEmpty(buildUrl))
            {
                var buildId = Environment.GetEnvironmentVariable("KOKORO_BUILD_ID");
                if (!string.IsNullOrEmpty(buildId))
                {
                    buildUrl = $"http://sponge/{buildId}";
                }
            }
            string message = "";
            if (string.IsNullOrEmpty(buildUrl))
            {
                message = $"The release build has started, the log can be viewed [here]({buildUrl}). :sunflower:";
            }
            else
            {
                message = "The release build has started, but the build log URL could not be determined. :broken_heart:";
            }
            await github.CreatePullRequestCommentAsync(prDetails.RepoName, prDetails.Owner, prDetails.Id, message).ConfigureAwait(false);
        }

        public async Task FinishAsync(string appId, string installationId, string privateKey, string pr, bool status, string details) =>
            await FinishAsync(GetGitHubToken(appId, installationId, privateKey), pr, appId, status, details);

        public async Task FinishAsync(string githubToken, string pr,string appId, bool status, string details)
        {
            var github = new GitHub(appId, githubToken);
            var prDetails = PRDetailsExtractor.ExtractPRDetails(pr);
            string message;
            IList<string> labels = new List<string>();

            if (status == true)
            {
                message = ":egg: You hatched a release! The release build finished successfully! :purple_heart:";
                labels.Add("autorelease: published");
            }
            else
            {
                message = "The release build failed! Please investigate!";
                labels.Add("autorelease: failed");
            }
            message += "\n" + details;
            await github.CreatePullRequestCommentAsync(prDetails.RepoName, prDetails.Owner, prDetails.Id, message).ConfigureAwait(false);
            await github.UpdatePullLabelsAsync(prDetails.RepoName, prDetails.Owner, prDetails.Id, labels.ToArray(), new string[] { "autorelease: tagged" }).ConfigureAwait(false);
        }
    }

}
