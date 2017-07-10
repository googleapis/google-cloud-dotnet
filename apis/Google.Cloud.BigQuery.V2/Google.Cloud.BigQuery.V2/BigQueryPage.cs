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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A page of rows loaded into memory from a <see cref="BigQueryResults"/>, up to a given maximum count.
    /// A page token may be present to indicate that more results are available.
    /// </summary>
    public sealed class BigQueryPage
    {
        /// <summary>
        /// Reference to the job this result set was fetched from.
        /// </summary>
        public JobReference JobReference { get; }

        /// <summary>
        /// Reference to the table this result set was fetched from.
        /// </summary>
        public TableReference TableReference { get; }

        /// <summary>
        /// The rows returned in the query.
        /// </summary>
        public IReadOnlyList<BigQueryRow> Rows { get; }

        /// <summary>
        /// Schema of the results (even if there are no rows).
        /// </summary>
        public TableSchema Schema { get; }

        /// <summary>
        /// If non-null, indicates more results may be available. Use this page
        /// token to fetch subsequent rows. This will never be present if fewer rows
        /// are returned than were requested, and will never be empty.
        /// </summary>
        public string NextPageToken { get; }

        /// <summary>
        /// Constructs a result set with the given rows and schema, retrieved from the specified job.
        /// This constructor exists for the sake of testing.
        /// </summary>
        /// <param name="rows">The rows returned in the query. Must not be null.</param>
        /// <param name="schema">The schema of the results. Must not be null.</param>
        /// <param name="jobReference">Reference to the job this result set was fetched from. Must not be null.</param>
        /// <param name="tableReference">Reference to the table this result set was fetched from. Must not be null.</param>
        /// <param name="nextPageToken">The page token to use to fetch further results. May be null, indicating
        /// that there are no more results.</param>
        public BigQueryPage(List<BigQueryRow> rows, TableSchema schema, JobReference jobReference, TableReference tableReference, string nextPageToken)
        {
            Rows = GaxPreconditions.CheckNotNull(rows, nameof(rows));
            Schema = GaxPreconditions.CheckNotNull(schema, nameof(schema));
            JobReference = GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            TableReference = GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            NextPageToken = nextPageToken;
        }

        internal BigQueryPage(Page<BigQueryRow> page, TableSchema schema, JobReference jobReference, TableReference tableReference)
        {
            GaxPreconditions.CheckNotNull(page, nameof(page));
            // This feels unnecessarily inefficient, as page._resources will be a list already, but never mind.
            // (Page<T> should probably expose an IList<T>...)
            Rows = page.ToList();
            Schema = GaxPreconditions.CheckNotNull(schema, nameof(schema));
            JobReference = GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            TableReference = GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            NextPageToken = page.NextPageToken;
        }
    }
}
