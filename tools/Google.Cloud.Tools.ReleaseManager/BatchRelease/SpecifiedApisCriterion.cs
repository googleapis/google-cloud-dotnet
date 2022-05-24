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
    internal sealed class SpecifiedApisCriterion : IBatchCriterion
    {
        private readonly HashSet<string> _apis;

        internal SpecifiedApisCriterion(IEnumerable<string> apis)
        {
            _apis = new HashSet<string>(apis);
        }

        public IEnumerable<ReleaseProposal> GetProposals(ApiCatalog catalog, Func<string, StructuredVersion, StructuredVersion> versionIncrementer)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using var repo = new Repository(root);

            foreach (var api in catalog.Apis)
            {
                if (!_apis.Contains(api.Id))
                {
                    continue;
                }
                var newVersion = versionIncrementer(api.Id, api.StructuredVersion);

                yield return ReleaseProposal.CreateFromHistory(repo, api.Id, newVersion);
            }
        }
    }
}
