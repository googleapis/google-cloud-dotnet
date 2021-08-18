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
    public sealed class CommitCommand : CommandBase
    {
        public CommitCommand()
            : base("commit", "Commit the current set of changes with an appropriate commit message")
        {
        }

        protected override void ExecuteImpl(string[] args) => InternalExecute();

        internal void InternalExecute()
        {
            var diffs = FindChangedVersions();
            if (diffs.Count != 1)
            {
                throw new UserErrorException($"Can only automate a single-package release commit with exactly 1 release. Found {diffs.Count}. Did you mean 'commit-multiple'?");
            }
            var diff = diffs[0];
            if (diff.NewVersion is null)
            {
                throw new UserErrorException($"Cannot automate a release commit for a deleted API.");
            }

            var historyFilePath = HistoryFile.GetPathForPackage(diff.Id);
            if (!File.Exists(historyFilePath))
            {
                throw new UserErrorException($"Cannot automate a release commit without a version history file.");
            }

            var historyFile = HistoryFile.Load(historyFilePath);
            var section = historyFile.Sections.FirstOrDefault(s => s.Version?.ToString() == diff.NewVersion);
            if (section is null)
            {
                throw new UserErrorException($"Unable to find history file section for {diff.NewVersion}. Cannot automate a release commit in this state.");
            }

            string header = $"Release {diff.Id} version {diff.NewVersion}";
            var message = string.Join("\n", new[] { header, "", "Changes in this release:", "" }.Concat(section.Lines.Skip(2)));

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                RepositoryStatus status = repo.RetrieveStatus();
                // TODO: Work out whether this is enough, and whether we actually need all of these.
                // We basically want git add --all.
                AddAll(status.Modified);
                AddAll(status.Missing);
                AddAll(status.Untracked);
                repo.Index.Write();
                var signature = repo.Config.BuildSignature(DateTimeOffset.UtcNow);
                var commit = repo.Commit(message, signature, signature);
                Console.WriteLine($"Created commit {commit.Sha}. Review the message and amend if necessary.");

                void AddAll(IEnumerable<StatusEntry> entries)
                {
                    foreach (var entry in entries)
                    {
                        repo.Index.Add(entry.FilePath);
                    }
                }
            }
        }
    }
}
