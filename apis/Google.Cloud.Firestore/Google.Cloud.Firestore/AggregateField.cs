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

using Google.Api.Gax;
using System;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;

namespace Google.Cloud.Firestore;

/// <summary>
/// Represents a single aggregation within an <see cref="AggregateQuery"/>.
/// </summary>
public sealed class AggregateField : IEquatable<AggregateField>
{
    internal const string CountAlias = "Count";

    /// <summary>
    /// The aggregation, with no alias applied. This is cloned in <see cref="GetAggregationForIndex(int)"/>
    /// </summary>
    private Aggregation Aggregation { get; }

    /// <summary>
    /// The alias for this aggregate field. This is either specified explicitly on construction,
    /// or may be defaulted.
    /// </summary>
    public string Alias { get; }

    private AggregateField(Aggregation aggregation, string alias)
    {
        Aggregation = aggregation;
        Alias = alias;
    }

    /// <summary>
    /// Creates an <see cref="AggregateField"/> representing a server-side count aggregation function.
    /// The `COUNT(*)` aggregation function operates on the entire document so it does not require a field reference.
    /// </summary>
    /// <returns>Returns a new instance of <see cref="AggregateField"/>.</returns>
    public static AggregateField Count() => new(new Aggregation { Count = new Count() }, CountAlias);

    /// <summary>
    /// Creates an <see cref="AggregateField"/> representing a server-side sum aggregation function.
    /// </summary>
    /// <param name="field">The field on which the sum aggregation is performed. Must not be null.</param>
    /// <param name="alias" cref="Aggregation.Alias">Optional alias to identify the result of the aggregation in <see cref="AggregateQuerySnapshot"/>.
    /// If this is null, an alias of the form "Sum_{field}" is used.
    /// </param>
    /// <returns>Returns a new instance of <see cref="AggregateField"/>.</returns>
    public static AggregateField Sum(string field, string alias = null)
    {
        GaxPreconditions.CheckNotNull(field, nameof(field));
        return new(new Aggregation { Sum = new Sum { Field = FieldPath.FromDotSeparatedString(field).ToFieldReference() } }, alias ?? $"Sum_{field}");
    }

    /// <summary>
    /// It uses the server side aggregation <see cref="Aggregation.Avg"/> representing a server-side average aggregation function.
    /// </summary>
    /// <param name="field">The field on which the average aggregation is performed. Must not be null.</param>
    /// <param name="alias" cref="Aggregation.Alias">Optional alias to identify the result of the aggregation in <see cref="AggregateQuerySnapshot"/>.
    /// If this is null, an alias of the form "Avg_{field}" is used.
    /// </param>
    /// <returns>Returns a new instance of <see cref="AggregateField"/>.</returns>
    public static AggregateField Average(string field, string alias = null)
    {
        GaxPreconditions.CheckNotNull(field, nameof(field));
        return new(new Aggregation { Avg = new Avg { Field = FieldPath.FromDotSeparatedString(field).ToFieldReference() } }, alias ?? $"Avg_{field}");
    }

    /// <summary>
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
    public bool Equals(AggregateField other) => other != null && Aggregation.Equals(other.Aggregation) && Alias.Equals(other.Alias);

    /// <inheritdoc />
    public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(Aggregation.GetHashCode(), Alias.GetHashCode());

    /// <summary>
    /// Returns an aggregation which uses a generated alias based on the index of the field within the aggregate
    /// query. This avoids long aliases within the query (and therefore the results), and removes problems of
    /// long field names becoming too long when prefixed. These aliases are effectively internal: they're mapped back to the
    /// original aliases when creating the <see cref="AggregateQuerySnapshot"/>.
    /// </summary>
    /// <remarks>The current implementation is to return aggregations with aliases of A1, A2 etc.</remarks>
    /// <param name="index">The zero-based index for the field within the aggregate query.</param>
    /// <returns>An aggregation with a suitable alias for the given index.</returns>
    internal Aggregation GetAggregationForIndex(int index)
    {
        var ret = Aggregation.Clone();
        ret.Alias = GetAliasForIndex(index);
        return ret;
    }

    /// <summary>
    /// Returns the alias to use in the RPC request for the query. See <see cref="GetAggregationForIndex(int)"/>
    /// for more details.
    /// The current implementation is to return aggregations with aliases of A1, A2 etc - which isn't actually
    /// instance specific, but we may change that.
    /// </summary>
    /// <param name="index">The zero-based index for the field within the aggregate query.</param>
    /// <returns>A suitable alias for the given index.</returns>
    internal string GetAliasForIndex(int index) => $"A{index + 1}";
}
