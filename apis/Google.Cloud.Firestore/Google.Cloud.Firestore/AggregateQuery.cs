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
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore;

/// <summary>
/// A query for running server-side aggregations. Instances of this can be created using
/// <see cref="Query.Count"/> and <see cref="Query.Aggregate(Google.Cloud.Firestore.AggregateField, Google.Cloud.Firestore.AggregateField[])"/>.
/// </summary>
public sealed class AggregateQuery : IEquatable<AggregateQuery>
{
    private readonly Query _query;
    private readonly IReadOnlyList<AggregateField> _aggregateFields;

    internal FirestoreDb Database => _query.Database;

    internal AggregateQuery(Query query, IReadOnlyList<AggregateField> aggregateFields)
    {
        _query = GaxPreconditions.CheckNotNull(query, nameof(query));
        _aggregateFields = GaxPreconditions.CheckNotNull(aggregateFields, nameof(aggregateFields));

        var aliasSet = new HashSet<string>(StringComparer.Ordinal);
        foreach (var field in aggregateFields)
        {
            GaxPreconditions.CheckArgument(field is not null, nameof(aggregateFields), "All aggregate fields must be non-null.");
            GaxPreconditions.CheckArgument(aliasSet.Add(field.Alias), nameof(aggregateFields), "All aliases in an aggregate query must be unique.");
        }
    }

    /// <summary>
    /// Asynchronously takes a snapshot of the result after applying the aggregate functions on the query.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token for the operation.</param>
    /// <returns>A <see cref="AggregateQuerySnapshot"/> which contains results of the Aggregate functions.</returns>
    public Task<AggregateQuerySnapshot> GetSnapshotAsync(CancellationToken cancellationToken = default) =>
        GetSnapshotAsync(null, cancellationToken);

    /// <summary>
    /// Returns an explanation for this query, optionally executing it.
    /// </summary>
    /// <param name="options">The <see cref="ExplainOptions"/> to use. Must not be null.</param>
    /// <param name="cancellationToken">A cancellation token for the operation.</param>
    /// <returns>A <see cref="PlanSummary"/> for this query.</returns>
    public async Task<ExplainResults<AggregateQuerySnapshot>> ExplainAsync(ExplainOptions options, CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(options, nameof(options));
        return await ExecuteAggregateQueryAsync(transactionId: null, options.Proto, cancellationToken).ConfigureAwait(false);
    }

    internal async Task<AggregateQuerySnapshot> GetSnapshotAsync(ByteString transactionId, CancellationToken cancellationToken)
    {
        var results = await ExecuteAggregateQueryAsync(transactionId, explainOptions: null, cancellationToken).ConfigureAwait(false);
        return results.Snapshot;
    }

    internal async Task<ExplainResults<AggregateQuerySnapshot>> ExecuteAggregateQueryAsync(ByteString transactionId, V1.ExplainOptions explainOptions, CancellationToken cancellationToken)
    {
        var query = ToStructuredAggregationQuery();
        IAsyncEnumerable<RunAggregationQueryResponse> responseStream = GetAggregationQueryResponseStreamAsync(transactionId, explainOptions, cancellationToken);
        Timestamp? readTime = null;

        // This is a map from the user-specified alias to the resulting value.
        // Doing all the translation here means AggregateQuerySnapshot doesn't need to know anything about
        // the internal mappings.
        MapField<string, Value> data = new();

        // It would be nice to use ToDictionary, but that doesn't provide the index.
        Dictionary<string, string> queryAliasToUserAlias = new(StringComparer.Ordinal);
        for (int i = 0; i < _aggregateFields.Count; i++)
        {
            var aggregate = _aggregateFields[i];
            queryAliasToUserAlias[aggregate.GetAliasForIndex(i)] = aggregate.Alias;
        }
        ExplainMetrics metrics = null;
        await responseStream.ForEachAsync(ProcessResponse, cancellationToken).ConfigureAwait(false);
        bool planOnly = explainOptions?.Analyze == false;
        GaxPreconditions.CheckState(readTime is not null || planOnly, "The stream returned from RunAggregationQueryQuery did not provide a read timestamp.");
        GaxPreconditions.CheckState(explainOptions is null || metrics is not null, "The stream returned from RunAggregationQuery did not provide metrics.");

        var snapshot = planOnly ? null : new AggregateQuerySnapshot(this, readTime.Value, data);
        return new ExplainResults<AggregateQuerySnapshot>(snapshot, metrics);

        void ProcessResponse(RunAggregationQueryResponse response)
        {
            if (response.Result?.AggregateFields is { } aggregateFields)
            {
                foreach (var pair in aggregateFields)
                {
                    if (queryAliasToUserAlias.TryGetValue(pair.Key, out string userAlias))
                    {
                        data[userAlias] = pair.Value;
                    }
                }
            }
            readTime ??= Timestamp.FromProtoOrNull(response.ReadTime);
            metrics = response.ExplainMetrics;
        }
    }

    // Note: this *could* just return FirestoreClient.RunAggregationQueryStream, as it's only called
    // from GetSnapshotAsync which could ensure it disposes of the response. However, it's simplest
    // to keep this implementation in common with Query.StreamResponsesAsync, which effectively
    // needs to use an iterator block so we can return an IAsyncEnumerable from Query.StreamAsync.
    private async IAsyncEnumerable<RunAggregationQueryResponse> GetAggregationQueryResponseStreamAsync(ByteString transactionId, V1.ExplainOptions explainOptions, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        RunAggregationQueryRequest request = new RunAggregationQueryRequest
        {
            Parent = _query.ParentPath,
            StructuredAggregationQuery = ToStructuredAggregationQuery(),
            ExplainOptions = explainOptions
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

    // Visible for testing
    internal StructuredAggregationQuery ToStructuredAggregationQuery() =>
        new()
        {
            StructuredQuery = _query.ToStructuredQuery(),
            Aggregations = { _aggregateFields.Select((aggregateField, index) => aggregateField.GetAggregationForIndex(index)) }
        };

    /// <inheritdoc />
    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(_query.GetHashCode(), GaxEqualityHelpers.GetListHashCode(_aggregateFields));

    /// <summary>
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.
    /// The order of aggregate fields is considered relevant for equality and hashing purposes, even though it is
    /// expected to return the same results.
    /// </returns>
    public bool Equals(AggregateQuery other) =>
        other != null && _query.Equals(other._query) && GaxEqualityHelpers.ListsEqual(_aggregateFields, other._aggregateFields);

    /// <inheritdoc/>
    public override bool Equals(object obj) => Equals(obj as AggregateQuery);
}
