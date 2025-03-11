// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Api.Gax;
using static Google.Cloud.Datastore.V1.ReadOptions.Types;

namespace Google.Cloud.Datastore.V1;

/// <summary>
/// A Datastore query with additional options for features such as read consistency and profiling.
/// </summary>
public sealed class DatastoreQuery
{
    /// <summary>
    /// The aggregation query to execute. For regular queries, this must be null.
    /// For aggregation queries, exactly one of this property or <see cref="GqlQuery"/>
    /// must be set when the query is executed.
    /// </summary>
    public AggregationQuery AggregationQuery { get; set; }

    /// <summary>
    /// The GQL query to execute. For regular queries, exactly one of this property or <see cref="Query"/>
    /// must be set when the query is executed. For aggregation queries,
    /// exactly one of this property or <see cref="AggregationQuery"/> must be set when the query is executed.
    /// </summary>
    public GqlQuery GqlQuery { get; set; }

    /// <summary>
    /// The structured query to execute. For regular queries, exactly one of this property or <see cref="GqlQuery"/>
    /// must be set when the query is executed. For aggregation queries, this must be null.
    /// </summary>
    public Query Query { get; set; }

    /// <summary>
    /// The profiling (explain) options to use for query execution, if any.
    /// </summary>
    public ExplainOptions ExplainOptions { get; set; }

    /// <summary>
    /// The level of read consistency to apply, if any. This property is ignored when the query is executed in a transaction.
    /// </summary>
    public ReadConsistency? ReadConsistency { get; set; }

    internal RunQueryRequest ToRequest(string projectId, string databaseId, PartitionId partitionId)
    {
        var request = new RunQueryRequest
        {
            ProjectId = projectId,
            DatabaseId = databaseId,
            PartitionId = partitionId,
            ReadOptions = GetReadOptions(ReadConsistency),
            ExplainOptions = ExplainOptions
        };
        GaxPreconditions.CheckState(AggregationQuery is null, "{0} must not be set when executing a regular query", nameof(AggregationQuery));
        switch (GqlQuery, Query)
        {
            case (GqlQuery gqlQuery, null): request.GqlQuery = gqlQuery;
                break;
            case (null, Query query): request.Query = query;
                break;
            default:
                GaxPreconditions.CheckState(false, "Exactly one of {0} and {1} must be set", nameof(GqlQuery), nameof(Query));
                break;
        }
        return request;
    }

    internal RunAggregationQueryRequest ToAggregationRequest(string projectId, string databaseId, PartitionId partitionId)
    {
        var request = new RunAggregationQueryRequest
        {
            ProjectId = projectId,
            DatabaseId = databaseId,
            PartitionId = partitionId,
            ReadOptions = GetReadOptions(ReadConsistency),
            ExplainOptions = ExplainOptions
        };
        GaxPreconditions.CheckState(Query is null, "{0} must not be set when executing a regular query", nameof(Query));
        switch (GqlQuery, AggregationQuery)
        {
            case (GqlQuery gqlQuery, null):
                request.GqlQuery = gqlQuery;
                break;
            case (null, AggregationQuery aggregationQuery):
                request.AggregationQuery = aggregationQuery;
                break;
            default:
                GaxPreconditions.CheckState(false, "Exactly one of {0} and {1} must be set", nameof(GqlQuery), nameof(AggregationQuery));
                break;
        }
        return request;
    }

    private static ReadOptions GetReadOptions(ReadConsistency? readConsistency) =>
        readConsistency == null ? null : new ReadOptions { ReadConsistency = readConsistency.Value };
}
