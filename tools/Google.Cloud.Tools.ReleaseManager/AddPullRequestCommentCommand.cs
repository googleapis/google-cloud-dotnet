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
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Tool to add a comment to a pull request (or issue).
/// This is expected to be used in GitHub Actions.
/// </summary>
public class AddPullRequestCommentCommand : CommandBase
{
    private const string RepositoryOwner = "googleapis";
    private const string RepositoryName = "google-cloud-dotnet";
    private const string ApplicationName = "google-cloud-dotnet-release-manager";

    public AddPullRequestCommentCommand() : base("add-pr-comment", "Adds a comment to a pull request from file contents", "file", "pr", "token")
    {
    }

    protected override void ExecuteImpl(string[] args)
    {
        string file = args[0];
        int pr = int.Parse(args[1]);
        string gitHubToken = args[2];

        var client = new GitHubClient(new ProductHeaderValue(ApplicationName))
        {
            Credentials = new Octokit.Credentials(gitHubToken)
        };
        string comment = File.ReadAllText(file);
        client.Issue.Comment.Create(RepositoryOwner, RepositoryName, pr, comment).GetAwaiter().GetResult();
    }
}
