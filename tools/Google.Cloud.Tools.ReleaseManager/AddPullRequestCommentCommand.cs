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

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Tool to add a comment to a pull request (or issue).
/// This is expected to be used in GitHub Actions.
/// </summary>
public class AddPullRequestCommentCommand : CommandBase
{
    private static readonly Regex StartEscapeSequence = new Regex("\u001b\\[1;\\d+m");
    private static readonly Regex EndEscapeSequence = new Regex("\u001b\\[0m");

    public AddPullRequestCommentCommand() : base("add-pr-comment", "Adds a comment to a pull request from file contents", "file", "pr", "token")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string file = args[0];
        int pr = int.Parse(args[1]);
        string gitHubToken = args[2];

        var client = GitHubHelpers.CreateGitHubClient(gitHubToken);
        string comment = ReplaceEscapeSequences(File.ReadAllText(file));
        try
        {
            client.Issue.Comment.Create(GitHubHelpers.RepositoryOwner, GitHubHelpers.RepositoryName, pr, comment).GetAwaiter().GetResult();
        }
        catch (OverflowException ex) when (ex.StackTrace.Contains("Octokit.Internal.JsonHttpPipeline.DeserializeResponse"))
        {
            // Octokit has issues with some response fields being int that need to be long.
            // See https://github.com/octokit/octokit.net/issues/1979 as an example (there are a few others).
            // We saw this on https://github.com/googleapis/google-cloud-dotnet/actions/runs/9370907399/job/25798969208?pr=13086
            // and plenty other releases, which stops merge-on-green merging release PRs, because the diff-checker fails, even
            // though it actually ran and added the comment with the differences found.

            // So, in general, if we see an overflow exception during response parsing we assume the call succeeded.
            // We don't use the response anyway so that's fine.
        }
        return 0;
    }

    private static string ReplaceEscapeSequences(string text)
    {
        text = StartEscapeSequence.Replace(text, "**");
        text = EndEscapeSequence.Replace(text, "**");
        return text;
    }
}
