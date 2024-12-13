// Copyright 2021 Google LLC
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

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    /// <summary>
    /// Criterion for "just release everything that has changes".
    /// </summary>
    public sealed class ReleaseAllCriterion : IBatchCriterion
    {
        /// <summary>
        /// If this is set to true, any APIs which would only generate
        /// release notes of "updated dependencies only" (i.e. no commits
        /// have meaningful release notes) are skipped, but the commits are reported.
        /// </summary>
        public bool SkipIfNoReleaseNotes { get; set; }

        /// <summary>
        /// If this is set to true, any APIs which would only generate
        /// release notes related to documentation are skipped.
        /// </summary>
        public bool SkipDocumentationOnly { get; set; }

        IEnumerable<ReleaseProposal> IBatchCriterion.GetProposals(
            ApiCatalog catalog,
            Func<string, StructuredVersion, StructuredVersion> versionIncrementer,
            string defaultMessage,
            Action<int, int> progressCallback)
        {
            var rootLayout = RootLayout.ForCurrentDirectory();
            using var repo = new Repository(rootLayout.RepositoryRoot);

            progressCallback?.Invoke(0, catalog.Apis.Count);
            Console.WriteLine($"Analyzing changes by API (this may take a few minutes)");
            var pendingChangesByApi = GitHelpers.GetPendingChangesByApi(repo, catalog);
            Console.WriteLine($"Finish analyzing changes.");

            // Map from package group ID to all the changed APIs within it.
            var skippedPackageGroups = new Dictionary<string, List<string>>();

            int progress = 0;
            foreach (var api in catalog.Apis)
            {
                progressCallback?.Invoke(++progress, catalog.Apis.Count);
                var commits = pendingChangesByApi[api].Commits;

                // Don't propose packages that haven't changed.
                // Note that this will also not propose a release for APIs that haven't
                // yet *been* released - which is probably fine. (We don't want to accidentally
                // launch something due to not paying attention.)
                if (commits.Count == 0)
                {
                    continue;
                }

                if (api.BlockRelease is string blockRelease)
                {
                    Console.WriteLine($"Release of {api.Id} is blocked: {blockRelease}");
                    continue;
                }

                if (SkipIfNoReleaseNotes)
                {
                    if (!commits.Any(c => c.GetReleaseNoteElements().Any(note => note.PublishInReleaseNotes)))
                    {
                        Console.WriteLine($"Skipping {api.Id} which has {commits.Count} commit(s), but none generate release notes:");
                        foreach (var commit in commits)
                        {
                            string truncatedTitle = commit.Title.Substring(0, Math.Min(commit.Title.Length, 60));
                            Console.WriteLine($"  {commit.HashPrefix}: {truncatedTitle}");
                        }
                        Console.WriteLine();
                        continue;
                    }
                }

                if (SkipDocumentationOnly)
                {
                    if (!commits.Any(c => c.GetReleaseNoteElements().Any(note => note.PublishInReleaseNotes && note.Type != History.ReleaseNoteElementType.Docs)))
                    {
                        Console.WriteLine($"Skipping {api.Id} which only contains documentation/trivial changes");
                        Console.WriteLine();
                        continue;
                    }
                }

                // Don't even bother proposing package groups at the moment.
                if (api.PackageGroup is { Id: string packageGroupId })
                {
                    if (!skippedPackageGroups.TryGetValue(packageGroupId, out var changedApis))
                    {
                        changedApis = new List<string>();
                        skippedPackageGroups[packageGroupId] = changedApis;
                    }
                    changedApis.Add(api.Id);
                    continue;
                }

                var newVersion = versionIncrementer(api.Id, api.StructuredVersion);

                yield return ReleaseProposal.CreateFromHistory(repo, api.Id, newVersion, defaultMessage);
            }

            if (skippedPackageGroups.Any())
            {
                Console.WriteLine("Additionally, the following package groups had changes:");
                foreach (var pair in skippedPackageGroups.OrderBy(pair => pair.Key, StringComparer.Ordinal))
                {
                    Console.WriteLine($"{pair.Key}: Changes in {string.Join(",", pair.Value)}");
                }
            }
        }
    }
}
