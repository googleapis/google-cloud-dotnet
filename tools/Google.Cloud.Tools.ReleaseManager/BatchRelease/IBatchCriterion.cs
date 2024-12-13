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
using System;
using System.Collections.Generic;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    internal interface IBatchCriterion
    {
        /// <summary>
        /// Returns the proposed releases for all APIs in the catalog
        /// </summary>
        /// <param name="catalog">The local API catalog.</param>
        /// <param name="defaultMessage">A customized default message for APIs with no commit history messages.</param>
        /// <param name="versionIncrementer">A function to increment from one version to another, based on an ID.</param>
        /// <param name="progressCallback">
        /// A callback to invoke with progess.
        /// The first argument is the number of API candidates meaningfully considered;
        /// the second is the total number of API candidates that will be considered.
        /// </param>
        IEnumerable<ReleaseProposal> GetProposals(
            RootLayout rootLayout,
            ApiCatalog catalog,
            Func<string, StructuredVersion, StructuredVersion> versionIncrementer,
            string defaultMessage,
            Action<int, int> progressCallback);
    }
}
