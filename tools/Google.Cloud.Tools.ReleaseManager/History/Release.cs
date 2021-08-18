// Copyright 2019 Google LLC
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

namespace Google.Cloud.Tools.ReleaseManager.History
{
    internal sealed class Release
    {
        public StructuredVersion Version { get; }
        public IReadOnlyList<GitCommit> Commits { get; }
        public DateTime ReleaseDate { get; }

        private Release(StructuredVersion version, DateTimeOffset? releaseDate, IEnumerable<GitCommit> commits) =>
            (Version, ReleaseDate, Commits) = (version, (releaseDate ?? DateTimeOffset.Now).UtcDateTime, commits.ToList().AsReadOnly());

        public Release(StructuredVersion version, Commit tagCommit, IEnumerable<GitCommit> commits)
            : this(version, tagCommit?.GetDate(), commits)
        {
        }

        public Release(StructuredVersion version, Tag tag, IEnumerable<GitCommit> commits)
            : this(version, tag?.GetDate(), commits)
        {
        }

        public static IEnumerable<Release> LoadReleases(Repository repo, ApiCatalog catalog, ApiMetadata api)
        {
            var id = api.Id;
            var commitPredicate = GitHelpers.CreateCommitPredicate(repo, catalog, api);

            List<Release> releases = new List<Release>();
            StructuredVersion currentVersion = StructuredVersion.FromString(api.Version);
            Commit currentTagCommit = null;

            // "Pending" as in "haven't been yielded in a release yet"
            List<GitCommit> pendingCommits = new List<GitCommit>();

            var tagPrefix = $"{id}-";
            var versionsCommitId = repo.Tags
                .Where(tag => tag.FriendlyName.StartsWith(tagPrefix))
                .ToDictionary(tag => tag.Target.Id, tag => tag.FriendlyName.Substring(tagPrefix.Length));

            foreach (var commit in repo.Head.Commits)
            {
                if (commitPredicate(commit))
                {
                    pendingCommits.Add(new GitCommit(commit));
                }
                if (versionsCommitId.TryGetValue(commit.Id, out string version) && !version.StartsWith("0."))
                {
                    yield return new Release(currentVersion, currentTagCommit, pendingCommits);
                    // Release constructor clones the list, so we're safe to clear it.
                    pendingCommits.Clear();
                    currentTagCommit = commit;
                    currentVersion = StructuredVersion.FromString(version);
                }
            }

            if (pendingCommits.Count != 0)
            {
                yield return new Release(currentVersion, currentTagCommit, pendingCommits);
            }
        }
    }
}
