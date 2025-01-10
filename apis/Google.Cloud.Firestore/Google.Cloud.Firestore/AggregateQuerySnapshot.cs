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
using Google.Cloud.Firestore.V1;
using Google.Protobuf.Collections;
using System;

namespace Google.Cloud.Firestore;

/// <summary>
/// An immutable snapshot of aggregate query results.
/// </summary>
public sealed class AggregateQuerySnapshot : IEquatable<AggregateQuerySnapshot>, IDeserializationContext
{
    /// <summary>
    /// The data within the snapshot. This is a MapField as that provides equality and hashing out of the box.
    /// </summary>
    private readonly MapField<string, Value> _data;
    private readonly Timestamp? _readTime;

    /// <summary>
    /// The query producing this snapshot.
    /// </summary>
    public AggregateQuery Query { get; }

    /// <summary>
    /// The time at which the snapshot was read.
    /// </summary>
    public Timestamp ReadTime => _readTime ?? throw new InvalidOperationException("No read time available");

    /// <summary>
    /// Number of documents that matches the query. May be null when count aggregation is not applied on the Query.
    /// Note that when the query contains a limit, the count is restricted by that limit.
    /// </summary>
    public long? Count => _data.TryGetValue(AggregateField.CountAlias, out var value) &&
        value.ValueTypeCase == Value.ValueTypeOneofCase.IntegerValue
        ? value.IntegerValue : null;

    internal AggregateQuerySnapshot(AggregateQuery query, Timestamp? readTime, MapField<string, Value> data)
    {
        Query = query;
        _readTime = readTime;
        _data = data;
    }

    /// <summary>
    /// Fetches the value from the dictionary, throwing an exception if the value does not exist.
    /// </summary>
    /// <param name="alias">The parameter to match the alias of aggregation result to be fetched. Must not be null.</param>
    /// <exception cref="InvalidOperationException">The field does not exist in the dictionary.</exception>
    /// <returns>The deserialized value.</returns>
    public T GetValue<T>(string alias)
    {        
        GaxPreconditions.CheckNotNull(alias, nameof(alias));
        _ = _data.TryGetValue(alias, out var value);
        GaxPreconditions.CheckState(value != null, $"Field {alias} not found in results");
        return (T) ValueDeserializer.Deserialize(this, value, typeof(T));
    }

    /// <summary>
    /// Fetches the value from the dictionary, throwing an exception if the value does not exist.
    /// </summary>
    /// <param name="aggregateField">The aggregate field to fetch. Must not be null.</param>
    /// <exception cref="InvalidOperationException">The field does not exist in the dictionary.</exception>
    /// <returns>The deserialized value.</returns>
    public T GetValue<T>(AggregateField aggregateField)
    {
        GaxPreconditions.CheckNotNull(aggregateField, nameof(aggregateField));
        return GetValue<T>(aggregateField.Alias);
    }

    // Note: TryGetValue is internal right now, as we're not 100% convinced we want it in the public API.
    // It can easily be removed or made public when we're more certain either way.

    /// <summary>
    /// Attempts to fetch the given value from the dictionary, returning whether or not it was found, and fetching the value if it was found.
    /// </summary>
    /// <typeparam name="T">The type to be casted to, if it is found.</typeparam>
    /// <param name="alias">The parameter to match the alias of aggregation result to be fetched. Must not be null.</param>
    /// <param name="value">When this method returns, contains the casted value if the field was found, or the default value
    /// of <typeparamref name="T"/> otherwise.</param>
    /// <returns>True if the field was found; false otherwise.</returns>
    internal bool TryGetValue<T>(string alias, out T value)
    {
        GaxPreconditions.CheckNotNull(alias, nameof(alias));
        _ = _data.TryGetValue(alias, out var result);
        if (result == null)
        {
            value = default;
            return false;
        }
        value = (T) ValueDeserializer.Deserialize(this, result, typeof(T));
        return true;
    }

    /// <summary>
    /// Attempts to fetch the given value from the dictionary, returning whether or not it was found, and fetching the value if it was found.
    /// </summary>
    /// <typeparam name="T">The type to be casted to, if it is found.</typeparam>
    /// <param name="aggregateField">The aggregate field to fetch. Must not be null.</param>
    /// <param name="value">When this method returns, contains the casted value if the field was found, or the default value
    /// of <typeparamref name="T"/> otherwise.</param>
    /// <returns>True if the field was found; false otherwise.</returns>
    internal bool TryGetValue<T>(AggregateField aggregateField, out T value)
    {
        GaxPreconditions.CheckNotNull(aggregateField, nameof(aggregateField));
        return TryGetValue<T>(aggregateField.Alias, out value);
    }

    /// <summary>
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
    public bool Equals(AggregateQuerySnapshot other) =>
        other != null && Query.Equals(other.Query) && ReadTime.Equals(other.ReadTime) && _data.Equals(other._data);

    /// <inheritdoc />
    public override bool Equals(object obj) => Equals(obj as AggregateQuerySnapshot);

    /// <inheritdoc />
    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(Query.GetHashCode(), ReadTime.GetHashCode(), _data.GetHashCode());

    // Explicit interface implementation of IDeserializationContext members.

    FirestoreDb IDeserializationContext.Database => Query.Database;
    DocumentReference IDeserializationContext.DocumentReference =>
        throw new InvalidOperationException($"{nameof(IDeserializationContext.DocumentReference)} has no meaning for {nameof(AggregateQuerySnapshot)}");
    Timestamp? IDeserializationContext.CreateTime =>
        throw new InvalidOperationException($"{nameof(IDeserializationContext.CreateTime)} has no meaning for {nameof(AggregateQuerySnapshot)}");
    Timestamp? IDeserializationContext.UpdateTime =>
        throw new InvalidOperationException($"{nameof(IDeserializationContext.UpdateTime)} has no meaning for {nameof(AggregateQuerySnapshot)}");
}
