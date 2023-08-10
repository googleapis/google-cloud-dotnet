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

namespace Google.Cloud.Tools.ReleaseTool
{
    public class GitHub
    {
        private readonly string _appId;
        private readonly string _githubToken;
        private readonly GitHubClient _client;
        public GitHub(string appId, string githubToken)
        {
            _githubToken = githubToken;
            _appId = appId;
            _client = new GitHubClient(new ProductHeaderValue(_appId))
            {
                Credentials = new Credentials(_githubToken, AuthenticationType.Bearer)
            };
        }

        public async Task<IReadOnlyList<PullRequest>> listPullRequestsAsync(string repoName, string owner)
        {
            return await _client.PullRequest.GetAllForRepository(owner, repoName);
        }

        public async Task<PullRequest> GetPullRequestAsync(string repoName, string owner, int number)
        {
            return await _client.PullRequest.Get(owner, repoName, number);
        }

        public async Task<PullRequest> CreatePullRequestAsync(string repoName, string owner, string title, string head, string body, string baseBranch = "master")
        {
            return await _client.PullRequest.Create(owner, repoName, new NewPullRequest(title, head, baseBranch));
        }

        public async Task<IssueComment> CreatePullRequestCommentAsync(string repoName, string owner, int number, string comment)
        {
            return await _client.Issue.Comment.Create(owner, repoName, number, comment);
        }

        public async Task<IReadOnlyList<Octokit.Label>> AddIssueLabel(string repoName, string owner, int number, string[] labels)
        {
            return await _client.Issue.Labels.AddToIssue(owner, repoName, number, labels);
        }

        public async Task<IReadOnlyList<Octokit.Label>> UpdatePullLabelsAsync(string repoName, string owner, int number, string[] newLabelsToAdd, string[] oldLablesToRemove)
        {
            foreach (var label in oldLablesToRemove)
            {
                await _client.Issue.Labels.RemoveFromIssue(owner, repoName, number, label);
            }
            return await AddIssueLabel(repoName, owner, number, newLabelsToAdd);
        }
    }
}
