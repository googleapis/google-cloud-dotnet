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
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    internal sealed class SpecifiedApisCriterion : IBatchCriterion
    {
        private readonly HashSet<string> _apis;

        internal SpecifiedApisCriterion(IEnumerable<string> apis)
        {
            _apis = new HashSet<string>(apis);
        }

        public IEnumerable<ReleaseProposal> GetProposals(
            RootLayout rootLayout,
            ApiCatalog catalog,
            Func<string, StructuredVersion, StructuredVersion> versionIncrementer,
            string defaultMessage,
            Action<int, int> progressCallback)
        {
            using var repo = new Repository(rootLayout.RepositoryRoot);

            int progress = 0;
            foreach (var api in catalog.Apis)
            {
                if (!_apis.Contains(api.Id))
                {
                    continue;
                }
                progressCallback?.Invoke(++progress, _apis.Count);

                if (api.BlockRelease is string blockReason)
                {
                    Console.WriteLine($"Skipping {api.Id} due to block: {blockReason}");
                    continue;
                }
                
                var newVersion = versionIncrementer(api.Id, api.StructuredVersion);

                yield return ReleaseProposal.CreateFromHistory(rootLayout, repo, api.Id, newVersion, defaultMessage);
            }
        }
    }
}
