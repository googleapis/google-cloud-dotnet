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
using System;

namespace Google.Cloud.Firestore;

/// <summary>
/// An immutable snapshot of aggregate query results.
/// </summary>
public sealed class AggregateQuerySnapshot : IEquatable<AggregateQuerySnapshot>
{
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

    internal AggregateQuerySnapshot(AggregateQuery query, Timestamp readTime, long? count)
    {
        Query = query;
        ReadTime = readTime;
        Count = count;
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
