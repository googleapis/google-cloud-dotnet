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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    internal static class GitHelpers
    {
        /// <summary>
        /// Creates a predicate which determines whether or not a commit affects an API.
        /// Note that this does *not* observe commit overrides with "skip" (yet).
        /// </summary>
        /// <param name="api">The API to create a predicate for.</param>
        /// <returns>The predicate.</returns>
        internal static Func<Commit, bool> CreateCommitPredicate(Repository repo, ApiCatalog catalog, ApiMetadata api)
        {
            // Work out which APIs we need to collect history for. This includes the API itself,
            // and any API dependencies in this repo that don't keep history files themselves.
            var apiIds = new HashSet<string>(GetHistoryApiIds(catalog, api));

            var predicates = apiIds.Select(id => CreateCommitPredicateForPathPrefix($"apis/{id}/{id}/")).ToList();
            return commit => predicates.Any(p => p(commit));
        }

        internal static Func<Commit, bool> CreateCommitPredicateForPathPrefix(string pathPrefix) =>
            commit =>
            {
                if (commit.Parents.Count() != 1)
                {
                    return false;
                }
                var tree = commit.Tree;
                var parentTree = commit.Parents.First().Tree;
                return tree[pathPrefix]?.Target.Sha != parentTree[pathPrefix]?.Target.Sha;
            };

        /// <summary>
        /// Returns the APIs IDs from which the version history of the given API is constructed.
        /// This includes (transitively) dependencies using a "project" value (i.e. current HEAD)
        /// that don't maintain their own version history.
        /// </summary>
        private static IEnumerable<string> GetHistoryApiIds(ApiCatalog catalog, ApiMetadata api)
        {
            yield return api.Id;
            foreach (var (key, value) in api.Dependencies)
            {
                if (value != "project" ||
                    !catalog.TryGetApi(key, out var dependency) ||
                    !dependency.NoVersionHistory)
                {
                    continue;
                }
                // Note: this recursion would become really inefficient in a deep tree - but
                // we simply don't have many dependencies like this.
                foreach (var id in GetHistoryApiIds(catalog, dependency))
                {
                    yield return id;
                }
            }
        }

        internal static DateTimeOffset GetDate(this Tag tag) =>
            ((Commit) tag.PeeledTarget).GetDate();

        internal static DateTimeOffset GetDate(this Commit commit) =>
            (commit.Author ?? commit.Committer).When;

        internal static string GetHashPrefix(this Commit commit) => GetHashPrefix(commit.Sha);
        internal static string GetHashPrefix(string hash) => hash.Substring(0, 7);

        /// <summary>
        /// Gets the set of pending changes for each API. Note that the release in the dictionary value
        /// has the current version and date, but the pending changes (not the list of changes *in* that release).
        /// </summary>
        internal static Dictionary<ApiMetadata, Release> GetPendingChangesByApi(Repository repo, ApiCatalog catalog)
        {
            var allTags = repo.Tags.OrderByDescending(GetDate).ToList();
            return catalog.Apis.ToDictionary(api => api, api => GetPendingChanges(api));

            // TODO: Optimize this; it's pretty slow due to checking lots of paths all the time.
            // We can probably find the oldest commit we care about, and work out all the APIs that have changed on
            // a per-commit basis after that. But it gets complex quite quickly...

            Release GetPendingChanges(ApiMetadata api)
            {
                string expectedTagPrefix = $"{api.Id}-";
                var latestRelease = allTags.FirstOrDefault(tag => tag.FriendlyName.StartsWith(expectedTagPrefix, StringComparison.Ordinal));

                if (latestRelease is null)
                {
                    // TODO: Work out what to do for unreleased APIs.
                    // We should potentially go back to "the commit that first added the API" but that
                    // may be tricky to work out.
                    return new Release(api.StructuredVersion, tag: null, new GitCommit[0]);
                }

                var laterCommits = repo.Commits.TakeWhile(commit => commit.Sha != latestRelease?.Target.Sha);
                var relevantCommits = laterCommits
                    .Where(CreateCommitPredicate(repo, catalog, api))
                    .Where(commit => !CommitOverrides.IsSkipped(commit))
                    .Select(commit => new GitCommit(commit))
                    .ToList();

                return new Release(api.StructuredVersion, latestRelease, relevantCommits);
            }
        }
    }
}
