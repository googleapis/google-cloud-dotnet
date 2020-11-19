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

using LibGit2Sharp;
using System;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    internal static class GitHelpers
    {
        /// <summary>
        /// Creates a predicate which determines whether or not a commit affects an API.
        /// Note that this does *not* observe commit overrides with "skip" (yet).
        /// </summary>
        /// <param name="id">The ID of the API to create a predicate for.</param>
        /// <returns>The predicate.</returns>
        internal static Func<Commit, bool> CreateCommitPredicate(Repository repo, string id)
        {
            var pathPrefix = $"apis/{id}/{id}/";
            var projectFile = $"apis/{id}/{id}/{id}.csproj";
            Func<string, bool> pathFilter = path => path.StartsWith(pathPrefix) && path != projectFile;
            return CommitContainsApi;

            bool CommitContainsApi(Commit commit)
            {
                if (commit.Parents.Count() != 1)
                {
                    return false;
                }
                var tree = commit.Tree;
                var parentTree = commit.Parents.First().Tree;
                // If nothing has changed under apis/{id}/{id}, it's definitely not relevant.
                if (tree[pathPrefix]?.Target.Sha == parentTree[pathPrefix]?.Target.Sha)
                {
                    return false;
                }
                // Otherwise, check whether something *other* than the project file has changed.
                var comparison = repo.Diff.Compare<TreeChanges>(parentTree, tree);
                // Some versions return forward slashes, some return backslashes :(
                return comparison.Select(change => change.Path.Replace('\\', '/')).Any(pathFilter);
            }
        }

        internal static DateTimeOffset GetDate(this Tag tag) =>
            ((Commit) tag.PeeledTarget).GetDate();

        internal static DateTimeOffset GetDate(this Commit commit) =>
            (commit.Author ?? commit.Committer).When;

        internal static string GetHashPrefix(this Commit commit) => commit.Sha.Substring(0, 7);
    }
}
