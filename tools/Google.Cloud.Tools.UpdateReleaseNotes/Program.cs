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
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.UpdateReleaseNotes
{
    /// <summary>
    /// Tool to update history.md for any single API, based on git logs.
    /// This is similar to Google.Cloud.Tools.GenerateReleaseNotes, but that just spits all
    /// changes out onto the console.
    /// </summary>
    class Program
    {
        private const string MarkdownFile = "history.md";

        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please specify the API, e.g. Google.Cloud.Storage.V1");
                return 1;
            }
            try
            {
                Execute(args[0]);
                return 0;
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Configuration error: {e.Message}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 1;
            }
        }

        private static void Execute(string id)
        {
            var catalog = ApiMetadata.LoadApis();
            var api = catalog.FirstOrDefault(x => x.Id == id) ?? throw new UserErrorException($"Unknown API: {id}");
            string historyFilePath = Path.Combine(DirectoryLayout.ForApi(id).DocsSourceDirectory, MarkdownFile);

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                var releases = LoadReleases(repo, api).ToList();
                if (!File.Exists(historyFilePath))
                {
                    File.WriteAllText(historyFilePath, "# Version history\r\n\r\n");
                }
                var historyFile = HistoryFile.Load(historyFilePath);
                historyFile.MergeReleases(releases);
                historyFile.Save(historyFilePath);
            }
        }

        private static IEnumerable<Release> LoadReleases(Repository repo, ApiMetadata api)
        {
            var id = api.Id;
            var pathPrefix = $"apis/{id}/{id}/";
            var projectFile = $"apis/{id}/{id}/{id}.csproj";
            // Some versions return forward slashes, some return backslashes :(
            Func<string, bool> pathFilter = path => path.Replace('\\', '/').StartsWith(pathPrefix) && path != projectFile;

            List<Release> releases = new List<Release>();
            StructuredVersion currentVersion = new StructuredVersion(api.Version);
            Commit currentTagCommit = null;
            
            // "Pending" as in "haven't been yielded in a release yet"
            List<Commit> pendingCommits = new List<Commit>();

            var tagPrefix = $"{id}-";
            var versionsCommitId = repo.Tags
                .Where(tag => tag.FriendlyName.StartsWith(tagPrefix))
                .ToDictionary(tag => tag.Target.Id, tag => tag.FriendlyName.Substring(tagPrefix.Length));

            foreach (var commit in repo.Branches["master"].Commits)
            {
                if (CommitContainsApi(commit))
                {
                    pendingCommits.Add(commit);
                }
                if (versionsCommitId.TryGetValue(commit.Id, out string version) && !version.StartsWith("0."))
                {
                    yield return new Release(currentVersion, currentTagCommit, pendingCommits);
                    // Release constructor clones the list, so we're safe to clear it.
                    pendingCommits.Clear();
                    currentTagCommit = commit;
                    currentVersion = new StructuredVersion(version);
                }
            }

            if (pendingCommits.Count != 0)
            {
                yield return new Release(currentVersion, currentTagCommit, pendingCommits);
            }

            bool CommitContainsApi(Commit commit)
            {
                if (commit.Parents.Count() != 1)
                {
                    return false;
                }
                var tree = commit.Tree;
                var parentTree = commit.Parents.First().Tree;
                var comparison = repo.Diff.Compare<TreeChanges>(parentTree, tree);
                return comparison.Select(change => change.Path).Any(pathFilter);
            }
        }
    }
}
