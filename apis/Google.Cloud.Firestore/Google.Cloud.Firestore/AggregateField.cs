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
/// Defines an <see cref="Aggregation"/> that produces a single result.
/// </summary>
public sealed class AggregateField : IEquatable<AggregateField>
{
    internal const string CountAlias = "Count";

    internal Aggregation Aggregation { get; }

    private AggregateField(Aggregation aggregation) => Aggregation = aggregation;

    /// <summary>
    /// It uses the server side aggregation <see cref="Aggregation.Count"/> to get the count.
    /// The `COUNT(*)` aggregation function operates on the entire document so it does not require a field reference.
    /// </summary>
    /// <returns>Returns a new instance of <see cref="AggregateField"/>.</returns>
    public static AggregateField Count() => new(new Aggregation { Count = new Count(), Alias = CountAlias });

    /// <summary>
    /// It uses the server side aggregation <see cref="Aggregation.Sum"/> to get the sum on any field.
    /// </summary>
    /// <param name="field">The mandatory field on which the Sum aggregation is performed.</param>
    /// <param name="alias" cref="Aggregation.Alias"> An optional parameter to store the alias.
    /// If none is provided by user , one is generated based on the field names formatted as "operator"_"field".
    /// </param>
    /// <returns>Returns a new instance of <see cref="AggregateField"/>.</returns>
    public static AggregateField Sum(string field, string alias = null)
    {
        GaxPreconditions.CheckNotNull(field, nameof(field));
        return new(new Aggregation { Sum = new Sum() { Field = FieldPath.FromDotSeparatedString(field).ToFieldReference() }, Alias = alias ?? $"Sum_{field}" });
    }

    /// <summary>
    /// It uses the server side aggregation <see cref="Aggregation.Avg"/> to get the average value.
    /// </summary>
    /// <param name="field">The mandatory field on which the Average aggregation is performed.</param>
    /// <param name="alias" cref="Aggregation.Alias"> An optional parameter to store the alias.
    /// If none is provided by user , one is generated based on the field names formatted as "operator"_"field".
    /// </param>
    /// <returns>Returns a new instance of <see cref="AggregateField"/>.</returns>
    public static AggregateField Average(string field, string alias = null)
    {
        GaxPreconditions.CheckNotNull(field, nameof(field));
        return new(new Aggregation { Avg = new Avg() { Field = FieldPath.FromDotSeparatedString(field).ToFieldReference() }, Alias = alias ?? $"Avg_{field}" });
    }

    /// <summary>
    /// Determines whether <paramref name="other"/> is equal to this instance.
    /// </summary>
    /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
    public bool Equals(AggregateField other) => other != null && Aggregation.Equals(other.Aggregation);

    /// <inheritdoc />
    public override int GetHashCode() => Aggregation.GetHashCode();
}
