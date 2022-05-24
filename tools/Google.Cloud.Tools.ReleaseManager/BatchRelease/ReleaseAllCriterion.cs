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

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    /// <summary>
    /// Criterion for "just release everything that has changes", currently
    /// with no additional config.
    /// </summary>
    public sealed class ReleaseAllCriterion : IBatchCriterion
    {
        IEnumerable<ReleaseProposal> IBatchCriterion.GetProposals(ApiCatalog catalog, Func<string, StructuredVersion, StructuredVersion> versionIncrementer)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using var repo = new Repository(root);
            var pendingChangesByApi = GitHelpers.GetPendingChangesByApi(repo, catalog);

            foreach (var api in catalog.Apis)
            {
                // Don't even bother proposing package groups at the moment.
                if (api.PackageGroup is object)
                {
                    continue;
                }
                // Don't propose packages that haven't changed.
                // Note that this will also not propose a release for APIs that haven't
                // yet *been* released - which is probably fine. (We don't want to accidentally
                // launch something due to not paying attention.)
                if (pendingChangesByApi[api].Commits.Count == 0)
                {
                    continue;
                }
                var newVersion = versionIncrementer(api.Id, api.StructuredVersion);

                yield return ReleaseProposal.CreateFromHistory(repo, api.Id, newVersion);
            }
        }
    }
}
