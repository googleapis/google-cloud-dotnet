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
    /// Command to show packages whose last release was a pre-release, but which represent a GA
    /// API (and should therefore be considered for a GA release).
    /// </summary>
    public class ShowLaggingCommand : CommandBase
    {
        public ShowLaggingCommand() : base("show-lagging", "Shows pre-release packages where a GA should be considered, and unreleased packages")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            Console.WriteLine("Lagging packages (package ID, current version, date range of current version prerelease series):");
            var catalog = ApiCatalog.Load(RootLayout);
            using (var repo = new Repository(RootLayout.RepositoryRoot))
            {
                var allTags = repo.Tags.OrderByDescending(GetDate).ToList();
                foreach (var api in catalog.Apis)
                {
                    MaybeShowLagging(allTags, api);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Unreleased (at current minor) packages:");
            foreach (var api in catalog.Apis.Where(api => api.Version.EndsWith("00") && api.BlockRelease is null))
            {
                Console.WriteLine($"{api.Id,-50}{api.Version,-20}");
            }

            Console.WriteLine();
            Console.WriteLine("Release-blocked packages:");
            foreach (var api in catalog.Apis.Where(api => api.BlockRelease is not null))
            {
                Console.WriteLine($"{api.Id,-50}{api.BlockRelease}");
            }
            return 0;
        }

        private static void MaybeShowLagging(List<Tag> allTags, ApiMetadata api)
        {
            var currentVersion = api.StructuredVersion;
            // Skip anything that is naturally pre-release (in the API), or where the current release is GA already.
            if (!api.CanHaveGaRelease || currentVersion.Prerelease is null)
            {
                return;
            }

            // Find all the existing prereleases for the expected "next GA" release.
            var expectedGa = StructuredVersion.FromMajorMinorPatch(currentVersion.Major, currentVersion.Minor, currentVersion.Patch, prerelease: null);
            string expectedGaPrefix = $"{api.Id}-{expectedGa}";
            var matchingReleaseTags = allTags.Where(tag => tag.FriendlyName.StartsWith(expectedGaPrefix, StringComparison.Ordinal)).ToList();

            // Skip if we haven't even released the current prerelease.
            if (matchingReleaseTags.Count == 0)
            {
                return;
            }

            var latest = GetDate(matchingReleaseTags.First());
            var earliest = GetDate(matchingReleaseTags.Last());

            string dateRange = latest == earliest
                ? $"{latest:yyyy-MM-dd}"
                : $"{earliest:yyyy-MM-dd} - {latest:yyyy-MM-dd}";
            Console.WriteLine($"{api.Id,-50}{api.Version,-20}{dateRange}");
        }

        private static DateTimeOffset GetDate(Tag tag) =>
            GetDate((Commit) tag.PeeledTarget);

        private static DateTimeOffset GetDate(Commit commit) =>
            (commit.Author ?? commit.Committer).When;

    }
}
