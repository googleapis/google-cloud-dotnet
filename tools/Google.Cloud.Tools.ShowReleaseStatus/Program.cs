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

namespace Google.Cloud.Tools.ShowReleaseStatus
{
    /// <summary>
    /// Tool to show the release status of each package in the API catalog.
    /// Note that this is based on git tags for efficiency: please make sure you have the latest tags before running.
    /// </summary>
    class Program
    {
        private static readonly TimeSpan AttentionAge = TimeSpan.FromDays(28);

        static void Main(string[] args)
        {
            bool attentionOnly = args.Contains("--attention");

            var root = DirectoryLayout.DetermineRootDirectory();
            var apis = ApiMetadata.LoadApis();

            using (var repo = new Repository(root))
            {
                var diff = repo.Diff;
                var tags = repo.Tags;
                var shaToTimestamp = repo.Commits.ToDictionary(commit => commit.Sha, commit => commit.Committer.When);

                foreach (var api in apis)
                {
                    DisplayApi(attentionOnly, api, tags, shaToTimestamp);
                }
            }
        }

        private static void DisplayApi(bool attentionOnly, ApiMetadata api, TagCollection tags, Dictionary<string, DateTimeOffset> shaToTimestamp)
        {
            string tagPrefix = $"{api.Id}-";
            var releases = tags
                .Where(tag => tag.FriendlyName.StartsWith(tagPrefix))
                .Where(tag => shaToTimestamp.ContainsKey(tag.Target.Sha))
                .Select(tag => new PackageRelease(api.Id, tag.FriendlyName.Substring(tagPrefix.Length), shaToTimestamp[tag.Target.Sha]))
                .OrderByDescending(release => release.Timestamp)
                .ToList();
            var lastGa = releases.FirstOrDefault(release => release.IsGa);
            var lastPrerelease = releases.FirstOrDefault(release => !release.IsGa);

            if (attentionOnly && !NeedsAttention(api, lastPrerelease, lastGa))
            {
                return;
            }

            Console.WriteLine(api.Id);
            if (lastGa is null && lastPrerelease is null)
            {
                Console.WriteLine("No releases");
            }
            else
            {
                // Only display a prerelease if it's more recent than the last GA
                if (lastPrerelease != null && (lastGa is null || lastPrerelease.Timestamp > lastGa.Timestamp))
                {
                    Console.WriteLine($"Last prerelease: {lastPrerelease}");
                }
                if (lastGa != null)
                {
                    Console.WriteLine($"Last GA: {lastGa}");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// A release needs attention if it's a package that *can* go GA (so not an API beta),
        /// and its last prerelease was after its last GA (or there is no GA)
        /// but that prerelease is at least 28 days old... and the API itself is GA.
        /// </summary>
        private static bool NeedsAttention(ApiMetadata api, PackageRelease prerelease, PackageRelease ga)
        {
            if (!api.CanHaveGaRelease)
            {
                return false;
            }
            if (prerelease == null)
            {
                return false;
            }
            if (ga != null && prerelease.Timestamp < ga.Timestamp)
            {
                return false;
            }
            return prerelease.Timestamp + AttentionAge < DateTimeOffset.UtcNow;
        }
    }
}
