// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.Datastore.V1.QueryResultBatch.Types;

namespace Google.Cloud.Datastore.V1;

/// <summary>
/// Represents the result of an <see cref="AggregationQuery"/>.
/// </summary>
public sealed class AggregationQueryResults
{
    /// <summary>
    /// The result of the aggregation functions, ex: `COUNT(*) AS  total_entities`.
    /// The key is the [alias][google.datastore.v1.AggregationQuery.Aggregation.alias] assigned
    /// to the aggregation function on input and the size of this map equals the number
    /// of aggregation functions in the query.
    /// </summary>
    private readonly Dictionary<string, Value> _aggregateProperties;

    /// <summary>
    /// The condition that caused the query to complete, indicating whether more
    /// results are available beyond the query limit or end cursor, or whether
    /// the data has been exhausted.
    /// </summary>
    public MoreResultsType MoreResults { get; }

    /// <summary>
    /// The time at which the snapshot was read. This will be null if the query was only
    /// planned, and not executed.
    /// </summary>
    public Timestamp ReadTime { get; }

    /// <summary>
    /// The information about planning and execution (if any) of the query. This will
    /// be null if no analysis was requested.
    /// </summary>
    public ExplainMetrics Metrics { get; }

    private AggregationQueryResults(MoreResultsType moreResults, Timestamp readTime, Dictionary<string, Value> aggregateProperties, ExplainMetrics metrics)
    {
        MoreResults = moreResults;
        ReadTime = readTime;
        _aggregateProperties = aggregateProperties;
        Metrics = metrics;
    }

    /// <summary>
    /// Returns the result of the aggregation function that is assigned to the given alias.
    /// Will be null if <see paramref="alias" /> was not specified in the original query.
    /// </summary>
    /// <param name="alias">The alias of the aggregation function that was provided in the aggregation query.
    /// If not provided,  Datastore will pick a default name following the format
    /// `property_&lt;incremental_id++>`. For example:
    ///```text
    ///```
    /// AGGREGATE
    ///   COUNT_UP_TO(1) AS count_up_to_1,
    ///   COUNT_UP_TO(2),
    ///   COUNT_UP_TO(3) AS count_up_to_3,
    ///   COUNT_UP_TO(4)
    /// OVER (
    ///   ...
    /// );
    /// ```
    ///
    /// becomes:
    /// ```text
    /// ```
    /// AGGREGATE
    ///   COUNT_UP_TO(1) AS count_up_to_1,
    ///   COUNT_UP_TO(2) AS property_1,
    ///   COUNT_UP_TO(3) AS count_up_to_3,
    ///   COUNT_UP_TO(4) AS property_2
    /// OVER (
    ///   ...
    /// );</param>
    /// <returns>The result of the aggregation function corresponding to the given alias.</returns>
    public Value this[string alias] => _aggregateProperties.TryGetValue(alias, out var value) ? value : null;

    internal static AggregationQueryResults FromRunAggregationQueryResponse(RunAggregationQueryResponse response)
    {
        var batch = response.Batch ?? new AggregationResultBatch();
        var aggregateProperties = batch.AggregationResults
            .SelectMany(result => result.AggregateProperties)
            .ToDictionary(pair => pair.Key, pair => pair.Value);
        return new AggregationQueryResults(batch.MoreResults, batch.ReadTime, aggregateProperties, response.ExplainMetrics);
    }
}
