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
using System.Collections.Generic;
using System.Linq;

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
            using (var repo = new Repository(root))
            {
                var allTags = repo.Tags.OrderByDescending(GitHelpers.GetDate).ToList();
                foreach (var api in catalog.Apis)
                {
                    MaybeShowStale(repo, allTags, api);
                }
            }
        }

        private static void MaybeShowStale(Repository repo, List<Tag> allTags, ApiMetadata api)
        {
            string expectedTagName = $"{api.Id}-{api.Version}";
            var latestRelease = allTags.FirstOrDefault(tag => tag.FriendlyName == expectedTagName);

            // If we don't have any releases for the API (or couldn't find the tag), skip it.
            if (latestRelease is null)
            {
                return;
            }

            var laterCommits = repo.Commits.TakeWhile(commit => commit.Sha != latestRelease.Target.Sha);
            var relevantCommits = laterCommits.Where(GitHelpers.CreateCommitPredicate(repo, api.Id)).ToList();

            // No changes
            if (relevantCommits.Count == 0)
            {
                return;
            }

            string changes = relevantCommits.Count == 1 ? "change" : "changes";
            Console.WriteLine($"{api.Id,-50} {latestRelease.GetDate():yyyy-MM-dd}: {api.Version} + {relevantCommits.Count} {changes}");
        }
    }
}
