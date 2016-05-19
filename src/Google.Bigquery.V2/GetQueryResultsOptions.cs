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

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Options for <c>GetQueryResults</c> operations.
    /// </summary>
    public sealed class GetQueryResultsOptions
    {
        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// If set, the zero-based index of the first row of results to retrieve.
        /// </summary>
        public ulong? StartIndex { get; set; }

        /// <summary>
        /// How long to wait for the query to complete before returning.
        /// If not set, this is effectively 10 seconds.
        /// </summary>
        public TimeSpan? Timeout { get; set; }

        internal void ModifyRequest(GetQueryResultsRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (StartIndex != null)
            {
                request.StartIndex = StartIndex;
            }
            if (Timeout != null)
            {
                request.TimeoutMs = (long) Timeout.Value.TotalMilliseconds;
            }
        }
    }
}
