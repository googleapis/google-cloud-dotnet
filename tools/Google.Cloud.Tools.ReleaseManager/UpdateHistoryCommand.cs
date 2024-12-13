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

        protected override int ExecuteImpl(string[] args)
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
            return 0;
        }

        private static void Execute(string id)
        {
            var rootLayout = RootLayout.ForCurrentDirectory();
            var catalog = ApiCatalog.Load(rootLayout);
            var api = catalog[id];
            if (api.NoVersionHistory)
            {
                Console.WriteLine($"Skipping version history update for {id}");
                return;
            }
            string historyFilePath = HistoryFile.GetPathForPackage(rootLayout, id);

            using var repo = new Repository(rootLayout.RepositoryRoot);
            var releases = Release.LoadReleases(repo, catalog, api).ToList();
            var historyFile = HistoryFile.Load(historyFilePath);
            var sectionsInserted = historyFile.MergeReleases(releases, defaultMessage: null);
            if (sectionsInserted.Count != 0)
            {
                historyFile.Save(historyFilePath);
                var relativePath = Path.GetRelativePath(rootLayout.RepositoryRoot, historyFilePath)
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
}
