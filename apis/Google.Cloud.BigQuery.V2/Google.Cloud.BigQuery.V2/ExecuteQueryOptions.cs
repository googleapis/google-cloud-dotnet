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

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>ExecuteQuery</c> operations.
    /// </summary>
    public sealed class ExecuteQueryOptions
    {
        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }        

        /// <summary>
        /// Whether to look for the result in the query cache.
        /// If not set, this is effectively true.
        /// </summary>
        public bool? UseQueryCache { get; set; }

        /// <summary>
        /// The default dataset to assume for any unqualified table names in the query.
        /// If this is not set, all table names must be fully qualified.
        /// </summary>
        public DatasetReference DefaultDataset { get; set; }

        // Note: we default the QueryRequest to set UseLegacySql to false
        // in BigQueryClientImpl. This option is nullable for potential merging purposes.

        /// <summary>
        /// Set to true to use legacy SQL instead of standard SQL.
        /// </summary>
        public bool? UseLegacySql { get; set; }

        internal void ModifyRequest(QueryRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (UseQueryCache != null)
            {
                request.UseQueryCache = UseQueryCache;
            }
            if (DefaultDataset != null)
            {
                request.DefaultDataset = DefaultDataset;
            }
            if (UseLegacySql != null)
            {
                request.UseLegacySql = UseLegacySql;
            }

            // TODO: more options. DryRun would be useful, but we have no way of returning the results...
        }

        /// <summary>
        /// Returns a <see cref="GetQueryResultsOptions"/> with equivalent options, to be used
        /// for subsequent requests.
        /// </summary>
        internal GetQueryResultsOptions ToGetQueryResultsOptions() =>
            new GetQueryResultsOptions
            {
                PageSize = PageSize
            };
    }
}
