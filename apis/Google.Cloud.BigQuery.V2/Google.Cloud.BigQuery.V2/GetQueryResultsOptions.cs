// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>GetQueryResults</c> operations.
    /// </summary>
    public sealed class GetQueryResultsOptions
    {
        /// <summary>
        /// Default overall timeout - if this is changed, modify the <see cref="Timeout"/> documentation
        /// accordingly.
        /// </summary>
        internal static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(5);

        // Properties used when making GetQueryResults service requests

        /// <summary>
        /// How long to wait for the query to complete before failing.
        /// If not set, this is effectively 5 minutes.
        /// </summary>
        public TimeSpan? Timeout { get; set; }

        // Properties used to construct a ListRowsOptions later...

        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// If set, the zero-based index of the first row of results to retrieve.
        /// If this property is non-null, <see cref="PageToken"/> must be null.
        /// </summary>
        public ulong? StartIndex { get; set; }

        /// <summary>
        /// The page token to use continue retrieving results after a previous request.
        /// If this property is non-null, <see cref="StartIndex"/> must be null.
        /// </summary>
        public string PageToken { get; set; }

        internal void ModifyRequest(GetQueryResultsRequest request)
        {
            // Nothing to do? We may have something later...
        }

        internal ListRowsOptions ToListRowsOptions()
        {
            if (PageToken != null && StartIndex != null)
            {
                throw new ArgumentException($"Cannot specify both {nameof(PageToken)} and {nameof(StartIndex)}");
            }

            return new ListRowsOptions
            {
                PageSize = PageSize,
                StartIndex = StartIndex,
                PageToken = PageToken
            };
        }
    }
}
