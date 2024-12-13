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
        private const string DowngradeOverrideEnvironmentVariable = "DOWNGRADE_OVERRIDE";

        public CommitCommand()
            : base("commit", "Commit the current set of changes with an appropriate commit message")
        {
        }

        protected override int ExecuteImpl(string[] args) => InternalExecute();

        internal int InternalExecute()
        {
            var diffs = FindChangedVersions();
            if (diffs.Count != 1)
            {
                throw new UserErrorException($"Can only automate a single-package release commit with exactly 1 release. Found {diffs.Count}. Did you mean 'commit-group'?");
            }
            var diff = diffs[0];
            if (diff.NewVersion is null)
            {
                throw new UserErrorException($"Cannot automate a release commit for a deleted API.");
            }
            // Prevent accidentally downgrading (i.e. lowering the version number).
            if (diff.OldVersion is not null &&
                StructuredVersion.FromString(diff.NewVersion).CompareTo(StructuredVersion.FromString(diff.OldVersion)) < 0 &&
                Environment.GetEnvironmentVariable(DowngradeOverrideEnvironmentVariable) != diff.NewVersion)
            {
                throw new UserErrorException(
                    $"Cannot downgrade from {diff.OldVersion} to {diff.NewVersion} without override. Set {DowngradeOverrideEnvironmentVariable}={diff.NewVersion} to override.");
            }
            var rootLayout = RootLayout.ForCurrentDirectory();
            var apiCatalog = ApiCatalog.Load(rootLayout);
            var api = apiCatalog[diff.Id];
            string header = $"Release {diff.Id} version {diff.NewVersion}";
            var bodyLines = GetCommitBodyLines();
            string message = string.Join("\n", new[] { header, "" }.Concat(bodyLines));

            using var repo = new Repository(rootLayout.RepositoryRoot);
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
            return 0;

            IEnumerable<string> GetCommitBodyLines()
            {
                // Handle APIs such as Google.Cloud.OsLogin.Common, where we don't really need a history entry.
                if (api.NoVersionHistory)
                {
                    return new[] { "This library has no dedicated release history. Changes are typically recorded in other libraries, or are just dependency updates." };
                }

                // Anything else really should have a history.
                var historyFilePath = HistoryFile.GetPathForPackage(rootLayout, diff.Id);
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
                if (section.Lines.Any(line => line.Contains(HistoryFile.FixmeBlockingRelease)))
                {
                    throw new UserErrorException("History file requires editing before release");
                }

                return new[] { "Changes in this release:", "" }.Concat(section.Lines.Skip(2));
            }
        }
    }
}
