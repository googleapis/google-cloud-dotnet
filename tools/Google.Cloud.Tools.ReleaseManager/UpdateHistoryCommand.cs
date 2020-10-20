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
using Google.Cloud.Tools.ReleaseManager.History;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class UpdateHistoryCommand : CommandBase
    {
        public UpdateHistoryCommand()
            : base("update-history", "Update the release history file for each changed version")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            foreach (var diff in FindChangedVersions())
            {
                if (diff.NewVersion is null)
                {
                    Console.WriteLine($"{diff.Id} has been deleted; no history required.");
                }
                else
                {
                    Execute(diff.Id);
                }
            }
        }

        private static void Execute(string id)
        {
            var catalog = ApiCatalog.Load();
            var api = catalog[id];
            if (api.NoVersionHistory)
            {
                Console.WriteLine($"Skipping version history update for {id}");
                return;
            }
            string historyFilePath = HistoryFile.GetPathForPackage(id);

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                var releases = LoadReleases(repo, api).ToList();
                if (!File.Exists(historyFilePath))
                {
                    File.WriteAllText(historyFilePath, "# Version history\r\n\r\n");
                }
                var historyFile = HistoryFile.Load(historyFilePath);
                var sectionsInserted = historyFile.MergeReleases(releases);
                if (sectionsInserted.Count != 0)
                {
                    historyFile.Save(historyFilePath);
                    var relativePath = Path.GetRelativePath(DirectoryLayout.DetermineRootDirectory(), historyFilePath)
                        .Replace('\\', '/');
                    Console.WriteLine($"Updated version history file: {relativePath}");
                    Console.WriteLine("New content:");
                    Console.WriteLine();
                    foreach (var line in sectionsInserted.SelectMany(section => section.Lines))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        private static IEnumerable<Release> LoadReleases(Repository repo, ApiMetadata api)
        {
            var id = api.Id;
            var commitPredicate = GitHelpers.CreateCommitPredicate(repo, api.Id);

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
