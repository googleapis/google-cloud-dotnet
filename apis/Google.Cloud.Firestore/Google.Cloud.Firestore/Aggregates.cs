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

using Google.Cloud.Firestore.V1;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;

namespace Google.Cloud.Firestore;

/// <summary>
/// Factory for different <see cref="Aggregation"/>.
/// </summary>
internal static class Aggregates
{
    /// <summary>
    /// The "alias" to specify in the <see cref="RunAggregationQueryRequest"/> proto when running a count query.
    /// The actual value is not meaningful, but will be used to get the count out of the <see cref="RunAggregationQueryResponse"/>.
    /// </summary>
    internal const string CountAlias = "Count";
    internal static Aggregation CreateCountAggregate()
    {
        return new Aggregation { Count = new Count(), Alias = CountAlias };
    }
}
