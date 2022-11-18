// Copyright 2022 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types;

namespace Google.Cloud.Firestore;

/// <summary>
/// A query for running an aggregation over a [StructuredQuery][google.firestore.v1.StructuredQuery]. Currently only "count(*)" aggregation is supported.
/// </summary>
public sealed class AggregateQuery : IEquatable<AggregateQuery>
{
    private readonly Query _query;
    private readonly IReadOnlyList<Aggregation> _aggregations;

    internal AggregateQuery(Query query)
    {
        _query = GaxPreconditions.CheckNotNull(query, nameof(query));
        _aggregations = new List<Aggregation>();
    }

    private AggregateQuery(Query query, IReadOnlyList<Aggregation> aggregations)
    {
        _query = GaxPreconditions.CheckNotNull(query, nameof(query));
        _aggregations = aggregations;
    }

    internal AggregateQuery WithAggregation(Aggregation aggregation)
    {
        var newAggregations = new List<Aggregation>(_aggregations);
        newAggregations.Add(aggregation);
        return new AggregateQuery(_query, newAggregations);
    }

    /// <summary>
    /// Asynchronously takes a snapshot of the result after applying the aggregate functions on the query.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token for the operation.</param>
    /// <returns>A <see cref="AggregateQuerySnapshot"/> which contains results of the Aggregate functions.</returns>
    public Task<AggregateQuerySnapshot> GetSnapshotAsync(CancellationToken cancellationToken = default) =>
        GetSnapshotAsync(null, cancellationToken);

    internal async Task<AggregateQuerySnapshot> GetSnapshotAsync(ByteString transactionId, CancellationToken cancellationToken)
    {
        IAsyncEnumerable<RunAggregationQueryResponse> responseStream = GetAggregationQueryResponseStreamAsync(transactionId, cancellationToken);
        Timestamp? readTime = null;
        long? count = null;
        await responseStream.ForEachAsync(response => ProcessResponse(response), cancellationToken).ConfigureAwait(false);
        GaxPreconditions.CheckState(readTime != null, "The stream returned from RunAggregationQuery did not provide a read timestamp.");
        return new AggregateQuerySnapshot(this, readTime.Value, count);

        void ProcessResponse(RunAggregationQueryResponse response)
        {
            if (count is null && response.Result.AggregateFields?.TryGetValue(Aggregates.CountAlias, out var countValue) == true)
            {
                GaxPreconditions.CheckState(countValue.ValueTypeCase == Value.ValueTypeOneofCase.IntegerValue, "The count was not an integer.");
                count = countValue.IntegerValue;
            }
            readTime ??= Timestamp.FromProtoOrNull(response.ReadTime);
        }
    }

    private IAsyncEnumerable<RunAggregationQueryResponse> GetAggregationQueryResponseStreamAsync(ByteString transactionId, CancellationToken cancellationToken)
    {
        RunAggregationQueryRequest request = new RunAggregationQueryRequest
        {
            Parent = _query.ParentPath,
            StructuredAggregationQuery = ToStructuredAggregationQuery()
        };
        if (transactionId != null)
        {
            request.Transaction = transactionId;
        }
        var settings = CallSettings.FromCancellationToken(cancellationToken);
        var response = _query.Database.Client.RunAggregationQuery(request, settings);
        return response.GetResponseStream();
    }

    internal StructuredAggregationQuery ToStructuredAggregationQuery() =>
        new StructuredAggregationQuery
        {
            StructuredQuery = _query.ToStructuredQuery(),
            Aggregations = { _aggregations }
        };

    /// <inheritdoc />
    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(_query.GetHashCode(), GaxEqualityHelpers.GetListHashCode(_aggregations));

    /// <summary> 
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
    public bool Equals(AggregateQuery other) =>
        other != null && _query.Equals(other._query) && GaxEqualityHelpers.ListsEqual(_aggregations, other._aggregations);

    /// <inheritdoc/>
    public override bool Equals(object obj) => Equals(obj as AggregateQuery);
}
