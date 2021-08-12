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
using System.Collections.Generic;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    public sealed class KnownCommitsCriterion: IBatchCriterion
    {
        /// <summary>
        /// If set, override the natural history with this text.
        /// </summary>
        public string HistoryOverride { get; set; }

        /// <summary>
        /// The set of commits to expect. Only libraries with exactly this set of
        /// commits since the previous release are bumped.
        /// </summary>
        public HashSet<string> Commits { get; set; }

        IEnumerable<ReleaseProposal> IBatchCriterion.GetProposals(ApiCatalog catalog)
        {
            return null;
        }
    }
}
