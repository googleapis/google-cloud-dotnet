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
    /// Options for <c>CreateQueryJob</c> and <c>ExecuteQuery</c> operations.
    /// </summary>
    public sealed class QueryOptions : JobCreationOptions
    {
        /// <summary>
        /// A destination table to write the results into.
        /// If this is not specified, the results will be stored in a temporary table.
        /// </summary>
        public TableReference DestinationTable { get; set; }

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

        /// <summary>
        /// If true, allows the query to produce arbitrarily large result sets at a slight cost
        /// in performance. <see cref="DestinationTable"/> must be set in order to use this option.
        /// </summary>
        public bool? AllowLargeResults { get; set; }

        /// <summary>
        /// Specifies whether the operation is allowed to create new tables.
        /// If not set, this is effectively <see cref="CreateDisposition.CreateIfNeeded"/>.
        /// </summary>
        public CreateDisposition? CreateDisposition { get; set; }

        /// <summary>
        /// Specifies the behavior if the destination table exists.
        /// If not set, this is effectively <see cref="WriteDisposition.WriteIfEmpty"/>.
        /// </summary>
        public WriteDisposition? WriteDisposition { get; set; }

        /// <summary>
        /// Flattens all nested and repeated fields in the query results.
        /// If not set, this is effectively true. If this is set to false,
        /// <see cref="DestinationTable"/> must be specified and <see cref="AllowLargeResults"/>
        /// must be set to true.
        /// </summary>
        public bool? FlattenResults { get; set; }

        /// <summary>
        /// Limits the billing tier of the job. If the query uses resources beyond this tier,
        /// it will fail.
        /// If not set, this is effectively the project default.
        /// </summary>
        public int? MaximumBillingTier { get; set; }

        /// <summary>
        /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
        /// If not set, this is effectively the project default.
        /// </summary>
        public long? MaximumBytesBilled { get; set; }

        /// <summary>
        /// The priority of the query.
        /// </summary>
        public QueryPriority? Priority { get; set; }

        // Note: we default the JobConfigurationQuery to set UseLegacySql to false
        // in BigQueryClientImpl. This option is nullable for potential merging purposes.

        /// <summary>
        /// Set to true to use legacy SQL instead of standard SQL.
        /// </summary>
        public bool? UseLegacySql { get; set; }

        /// <summary>
        /// If set to true, don't actually run this job. A valid query will return a mostly empty response
        /// with some processing statistics, while an invalid query will return the same error it would if it wasn't a dry run.
        /// This option can be used to determine the schema of the query without running it. The resulting
        /// <see cref="BigQueryJob"/> has no job ID, so cannot be polled for completion, but the <see cref="BigQueryJob.Resource"/>
        /// contains all the information returned by the server.
        /// </summary>
        public bool? DryRun { get; set; }

        internal void ModifyRequest(JobConfigurationQuery query)
        {
            // Note: no validation of combinations (flatten results etc). Leave this to the server,
            // to avoid restrictions getting out of date.
            if (AllowLargeResults != null)
            {
                query.AllowLargeResults = AllowLargeResults;
            }
            if (CreateDisposition != null)
            {
                query.CreateDisposition = EnumMap.ToApiValue(CreateDisposition.Value);
            }
            if (DefaultDataset != null)
            {
                query.DefaultDataset = DefaultDataset;
            }
            if (DestinationTable != null)
            {
                query.DestinationTable = DestinationTable;
            }
            if (FlattenResults != null)
            {
                query.FlattenResults = FlattenResults;
            }
            if (MaximumBillingTier != null)
            {
                query.MaximumBillingTier = MaximumBillingTier;
            }
            if (MaximumBytesBilled != null)
            {
                query.MaximumBytesBilled = MaximumBytesBilled;
            }
            if (Priority != null)
            {
                query.Priority = EnumMap.ToApiValue(Priority.Value);
            }
            if (UseQueryCache != null)
            {
                query.UseQueryCache = UseQueryCache;
            }
            if (WriteDisposition != null)
            {
                query.WriteDisposition = EnumMap.ToApiValue(WriteDisposition.Value);
            }
            if (UseLegacySql != null)
            {
                query.UseLegacySql = UseLegacySql;
            }
        }
    }
}
