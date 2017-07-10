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
using static Google.Apis.Bigquery.v2.TabledataResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>ListRows</c> operations.
    /// </summary>
    public sealed class ListRowsOptions
    {
        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Page token, returned by a previous call, identifying the result set.
        /// If this property is non-null, <see cref="StartIndex"/> must be null.
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Zero-based index of the starting row to read.
        /// If this property is non-null, <see cref="PageToken"/> must be null.
        /// </summary>
        public ulong? StartIndex { get; set; }

        internal void ModifyRequest(ListRequest request)
        {
            if (PageToken != null && StartIndex != null)
            {
                throw new ArgumentException($"Cannot specify both {nameof(PageToken)} and {nameof(StartIndex)}");
            }

            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (PageToken != null)
            {
                request.PageToken = PageToken;
            }
            if (StartIndex != null)
            {
                request.StartIndex = StartIndex;
            }
        }

        internal ListRowsOptions Clone() => new ListRowsOptions
        {
            PageSize = PageSize,
            PageToken = PageToken,
            StartIndex = StartIndex
        };
    }
}
