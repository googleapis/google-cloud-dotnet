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

using static Google.Cloud.Datastore.V1.AggregationQuery.Types;
using static Google.Cloud.Datastore.V1.AggregationQuery.Types.Aggregation.Types;

namespace Google.Cloud.Datastore.V1;

/// <summary>
/// Factory for different types of Aggregations.
/// </summary>
public static class Aggregations
{
    /// <summary>
    /// Returns an instance of count(*) aggregation.
    /// </summary>
    /// <param name="alias">A string used to retrieve the result of this aggregation.
    /// If this is not provided, Datastore will pick a default name with a prefix of <c>property_</c>
    /// followed by an auto-incremented ID, e.g. <c>property_1</c>.
    /// </param>
    /// <returns>A count(*) aggregation.</returns>
    public static Aggregation Count(string alias = "") =>
        new Aggregation { Count = new Count(), Alias = alias };

    /// <summary>
    /// Returns an instance of a sum aggregation for the specified property.
    /// </summary>
    /// <param name="property">Property for which the sum is to be calculated. Must not be null.</param>
    /// <param name="alias">A string used to retrieve the result of this aggregation.
    /// If this is not provided, Datastore will pick a default name with a prefix of <c>property_</c>
    /// followed by an auto-incremented ID, e.g. <c>property_1</c>.
    /// </param>
    /// <returns>A sum aggregation for the specified property.</returns>
    public static Aggregation Sum(string property, string alias = "") =>
        new() { Sum = new Sum { Property = new PropertyReference(property) }, Alias = alias };

    /// <summary>
    /// Returns an instance of an average aggregation for the specified property.
    /// </summary>
    /// <param name="property">Property for which the average is to be calculated. Must not be null.</param>
    /// <param name="alias">A string used to retrieve the result of this aggregation.
    /// If this is not provided, Datastore will pick a default name with a prefix of <c>property_</c>
    /// followed by an auto-incremented ID, e.g. <c>property_1</c>.
    /// </param>
    /// <returns>An average aggregation for the specified property.</returns>
    public static Aggregation Average(string property, string alias = "") =>
        new() { Avg = new Avg { Property = new PropertyReference(property) }, Alias = alias };
}
