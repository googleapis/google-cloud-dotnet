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
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.AggregateField;

namespace Google.Cloud.Firestore;

/// <summary>
/// A query for running an aggregation over a [StructuredQuery][google.firestore.v1.StructuredQuery].
/// </summary>
public sealed class AggregateQuery : IEquatable<AggregateQuery>
{
    private readonly Query _query;
    private readonly IReadOnlyList<AggregateField> _aggregateFields;

    internal AggregateQuery(Query query)
    {
        _query = GaxPreconditions.CheckNotNull(query, nameof(query));
        _aggregateFields = new List<AggregateField>();
    }

    internal AggregateQuery(Query query, IReadOnlyList<AggregateField> aggregateFields)
    {
        _query = GaxPreconditions.CheckNotNull(query, nameof(query));
        _aggregateFields = aggregateFields;
    }

    internal AggregateQuery WithAggregateField(AggregateField aggregateField)
    {
        var newAggregations = new List<AggregateField>(_aggregateFields) { aggregateField };
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
        Dictionary<string, Value> data = new Dictionary<string, Value>();
        await responseStream.ForEachAsync(response => ProcessResponse(response), cancellationToken).ConfigureAwait(false);
        GaxPreconditions.CheckState(readTime != null, "The stream returned from RunAggregationQuery did not provide a read timestamp.");
        return new AggregateQuerySnapshot(this, readTime.Value, count, data);

        void ProcessResponse(RunAggregationQueryResponse response)
        {
            var aggregateFields = response.Result.AggregateFields;
            if (count is null && aggregateFields?.TryGetValue(CountAlias, out var countValue) == true)
            {
                GaxPreconditions.CheckState(countValue.ValueTypeCase == Value.ValueTypeOneofCase.IntegerValue, "The count was not an integer.");
                count = countValue.IntegerValue;
            }
            if (aggregateFields != null)
            {
                foreach (var mapField in aggregateFields)
                {
                    data.Add(mapField.Key, mapField.Value);
                }
            }
            readTime ??= Timestamp.FromProtoOrNull(response.ReadTime);
        }
    }

    // Note: this *could* just return FirestoreClient.RunAggregationQueryStream, as it's only called
    // from GetSnapshotAsync which could ensure it disposes of the response. However, it's simplest
    // to keep this implementation in common with Query.StreamResponsesAsync, which effectively
    // needs to use an iterator block so we can return an IAsyncEnumerable from Query.StreamAsync.
    private async IAsyncEnumerable<RunAggregationQueryResponse> GetAggregationQueryResponseStreamAsync(ByteString transactionId, [EnumeratorCancellation] CancellationToken cancellationToken)
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
        using var response = _query.Database.Client.RunAggregationQuery(request, settings);
        IAsyncEnumerable<RunAggregationQueryResponse> stream = response.GetResponseStream();
        await foreach (var result in stream.ConfigureAwait(false))
        {
            yield return result;
        }
    }

    internal StructuredAggregationQuery ToStructuredAggregationQuery()
    {
        var aggregations = _aggregateFields.Select(aggregateField => aggregateField.Aggregation).ToList();

        return new()
        {
            StructuredQuery = _query.ToStructuredQuery(),
            Aggregations = { aggregations }
        };
    }

    /// <inheritdoc />
    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(_query.GetHashCode(), GaxEqualityHelpers.GetListHashCode(_aggregateFields));

    /// <summary> 
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
    public bool Equals(AggregateQuery other) =>
        other != null && _query.Equals(other._query) && GaxEqualityHelpers.ListsEqual(_aggregateFields, other._aggregateFields);

    /// <inheritdoc/>
    public override bool Equals(object obj) => Equals(obj as AggregateQuery);
}
