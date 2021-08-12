// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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
using LibGit2Sharp;
using System;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Command to show APIs that may need re-releasing, i.e. where there are
    /// non-project-file commits since the last release.
    /// </summary>
    public sealed class ShowStaleCommand : CommandBase
    {
        public ShowStaleCommand() : base("show-stale", "Shows stale APIs, which may need a new release")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            var catalog = ApiCatalog.Load();
            using var repo = new Repository(root);
            var pendingChangesByApi = GitHelpers.GetPendingChangesByApi(repo, catalog);

            // TODO: Work out what to do with unreleased APIs. Do we want to show them or not?
            foreach (var api in catalog.Apis)
            {
                var release = pendingChangesByApi[api];
                var commits = release.Commits;
                if (commits.Count == 0)
                {
                    continue;
                }
                string changes = commits.Count == 1 ? "change" : "changes";
                Console.WriteLine($"{api.Id,-50} {release.ReleaseDate:yyyy-MM-dd}: {release.Version} + {commits.Count} {changes}");
            }
        }
    }
}
