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

using Google.Protobuf;
using System.Collections.Generic;
using static Google.Cloud.Datastore.V1.QueryResultBatch.Types;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// A complete set of query results, fetched and stored in memory. Results are
    /// fetched from a <see cref="LazyDatastoreQuery"/> or <see cref="AsyncLazyDatastoreQuery"/>
    /// until the query-specified limit or end cursor is reached, or no more results are available.
    /// </summary>
    public sealed class DatastoreQueryResults
    {
        /// <summary>
        /// The entities returned by the query.
        /// </summary>
        public IReadOnlyList<Entity> Entities { get; }

        /// <summary>
        /// The condition that caused the query to complete, indicating whether more
        /// results are available beyond the query limit or end cursor, or whether
        /// the data has been exhausted.
        /// </summary>
        public MoreResultsType MoreResults { get; }

        /// <summary>
        /// The cursor at the end of the results. This will never be null. FIXME - it will be for explain queries...
        /// </summary>
        public ByteString EndCursor { get; }

        internal ExplainMetrics Metrics { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExecutionStats ExecutionStats => Metrics?.ExecutionStats;

        /// <summary>
        /// 
        /// </summary>
        public PlanSummary PlanSummary => Metrics?.PlanSummary;

        internal DatastoreQueryResults(
            IReadOnlyList<Entity> entities,
            MoreResultsType endCondition,
            ByteString endCursor,
            ExplainMetrics metrics)
        {
            MoreResults = endCondition;
            Entities = entities;
            EndCursor = endCursor;
            Metrics = metrics;
        }
    }
}
