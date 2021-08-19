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
        /// Whether or not to rewrite the root README.md file for each release.
        /// This is normally a good idea, but if you're releasing APIs which are adjacent
        /// to each other in the README, the README file (and only that) will cause
        /// conflicts. In such cases, it's simpler to create a single PR regenerating the README
        /// after all the release PRs have been merged.
        /// Defaults to true.
        /// </summary>
        public bool RewriteReadme { get; set; } = true;

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
        /// Find all libraries with changes matching the given set of commits.
        /// </summary>
        public KnownCommitsCriterion KnownCommits { get; set; }

        /// <summary>
        /// Match exactly the APIs specified.
        /// </summary>
        public List<string> SpecifiedApis { get; set; }

        /// <summary>
        /// Validates that this configuration is reasonable.
        /// </summary>
        public void Validate()
        {
            var specifiedCriteria = new object[]
            {
                KnownCommits,
                SpecifiedApis
            }.Count(c => c is object);
            if (specifiedCriteria != 1)
            {
                throw new UserErrorException("A batch release must specify exactly one criterion.");
            }
        }

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
        }
    }
}
