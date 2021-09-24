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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    // Please update README.md when modifying this file.

    /// <summary>
    /// Configuration for the BatchReleaseCommand.
    /// </summary>
    public class BatchReleaseConfig
    {
        /// <summary>
        /// When true, each release (and history) is confirmed manually at the console.
        /// Defaults to true.
        /// </summary>
        public bool ConfirmRelease { get; set; } = true;

        /// <summary>
        /// When true, indicates which libraries would be released and what the history update would
        /// look like, but doesn't make any changes or release anything. Defaults to true.
        /// </summary>
        public bool DryRun { get; set; } = true;

        /// <summary>
        /// When true, display the new history text (both in dry-run mode and "do it" mode).
        /// Defaults to true. Typically this is only disabled when everything will have the same history.
        /// </summary>
        public bool ShowHistory { get; set; } = true;

        // Library selection criteria. These properties are effectively mutually exclusive.

        /// <summary>
        /// Release everything that has changed and already has at least one release.
        /// </summary>
        public ReleaseAllCriterion ReleaseAll { get; set; }

        /// <summary>
        /// Find all libraries with changes matching the given set of commits.
        /// </summary>
        public KnownCommitsCriterion KnownCommits { get; set; }

        /// <summary>
        /// Match exactly the APIs specified.
        /// </summary>
        public List<string> SpecifiedApis { get; set; }

        internal IEnumerable<IBatchCriterion> GetCriteria()
        {
            if (KnownCommits is object)
            {
                yield return KnownCommits;
            }
            if (SpecifiedApis is object)
            {
                yield return new SpecifiedApisCriterion(SpecifiedApis);
            }
            if (ReleaseAll is object)
            {
                yield return ReleaseAll;
            }
        }
    }
}
