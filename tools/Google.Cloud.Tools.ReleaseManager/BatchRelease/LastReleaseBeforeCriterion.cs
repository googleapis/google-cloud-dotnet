// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
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
using System.Globalization;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease;

public sealed class LastReleaseBeforeCriterion : IBatchCriterion
{
    private readonly DateTimeOffset _cutoff;

    public LastReleaseBeforeCriterion(string isoCutoff)
    {
        _cutoff = DateTimeOffset.ParseExact(isoCutoff, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
    }

    IEnumerable<ReleaseProposal> IBatchCriterion.GetProposals(
        RootLayout rootLayout,
        ApiCatalog catalog,
        Func<string, StructuredVersion, StructuredVersion> versionIncrementer,
        string defaultMessage,
        Action<int, int> progressCallback)
    {
        using var repo = new Repository(rootLayout.RepositoryRoot);

        var allTags = repo.Tags.OrderByDescending(GitHelpers.GetDate).ToList();

        int progress = 0;
        foreach (var api in catalog.Apis)
        {
            progressCallback?.Invoke(++progress, catalog.Apis.Count);
            string expectedTagPrefix = $"{api.Id}-";
            var latestRelease = allTags.FirstOrDefault(tag => tag.FriendlyName.StartsWith(expectedTagPrefix, StringComparison.Ordinal));

            // If we've never released, or the last release was on/after the cut-off date, skip.
            if (latestRelease is null || GitHelpers.GetDate(latestRelease) >= _cutoff)
            {
                continue;
            }

            if (api.BlockRelease is string blockReason)
            {
                Console.WriteLine($"Skipping {api.Id} due to block: {blockReason}");
                continue;
            }

            var newVersion = versionIncrementer(api.Id, api.StructuredVersion);
            yield return ReleaseProposal.CreateFromHistory(rootLayout, repo, api.Id, newVersion, defaultMessage);
        }
        yield break;
    }
}
