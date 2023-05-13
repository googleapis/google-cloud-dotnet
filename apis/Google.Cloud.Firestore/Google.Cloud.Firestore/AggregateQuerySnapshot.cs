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
using System;
using System.Collections.Generic;

namespace Google.Cloud.Firestore;

/// <summary>
/// An immutable snapshot of aggregate query results.
/// </summary>
public sealed class AggregateQuerySnapshot : IEquatable<AggregateQuerySnapshot>
{
    private readonly Dictionary<string, Value> _data;

    /// <summary>
    /// The query producing this snapshot.
    /// </summary>
    public AggregateQuery Query { get; }

    /// <summary>
    /// The time at which the snapshot was read.
    /// </summary>
    public Timestamp ReadTime { get; }

    /// <summary>
    /// Number of documents that matches the query. May be null when count aggregation is not applied on the Query.
    /// Note that when the query contains a limit, the count is restricted by that limit.
    /// </summary>
    public long? Count { get; }


    internal AggregateQuerySnapshot(AggregateQuery query, Timestamp readTime, long? count, Dictionary<string, Value> data)
    {
        Query = query;
        ReadTime = readTime;
        Count = count;
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
        var context = new DeserializationContext(this);
        return (T) ValueDeserializer.Deserialize(context, value, typeof(T));
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
        return GetValue<T>(aggregateField.Aggregation.Alias);
    }

    /// <summary>
    /// Attempts to fetch the given value from the dictionary, returning whether or not it was found, and fetching the value if it was found.
    /// </summary>
    /// <typeparam name="T">The type to be casted to, if it is found.</typeparam>
    /// <param name="alias">The parameter to match the alias of aggregation result to be fetched. Must not be null.</param>
    /// <param name="value">When this method returns, contains the casted value if the field was found, or the default value
    /// of <typeparamref name="T"/> otherwise.</param>
    /// <returns>True if the field was found; false otherwise.</returns>
    public bool TryGetValue<T>(string alias, out T value)
    {
        GaxPreconditions.CheckNotNull(alias, nameof(alias));
        _ = _data.TryGetValue(alias, out var result);
        if (result == null)
        {
            value = default;
            return false;
        }
        var context = new DeserializationContext(this);
        value = (T) ValueDeserializer.Deserialize(context, result, typeof(T));
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
    public bool TryGetValue<T>(AggregateField aggregateField, out T value)
    {
        GaxPreconditions.CheckNotNull(aggregateField, nameof(aggregateField));
        return TryGetValue<T>(aggregateField.Aggregation.Alias, out value);
    }

    /// <summary> 
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
    public bool Equals(AggregateQuerySnapshot other) =>
        other != null && Query.Equals(other.Query) && ReadTime.Equals(other.ReadTime) && Count == other.Count;

    /// <inheritdoc />
    public override bool Equals(object obj) => Equals(obj as AggregateQuerySnapshot);

    /// <inheritdoc />
    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(Query.GetHashCode(), ReadTime.GetHashCode(), Count?.GetHashCode() ?? 0);
}
