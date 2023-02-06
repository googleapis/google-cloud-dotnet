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
///  Factory for different types of Aggregations.
/// </summary>
public static class Aggregations
{
    /// <summary>
    /// Returns an instance of count(*) aggregation.
    /// </summary>
    /// <param name="alias">A string used to retrieve the result of this aggregation.
    /// If not provided, Datastore will pick a default name following the format `property_&lt;incremental_id++>`
    /// eg. property_1
    /// </param>
    /// <returns>A count(*) aggregation.</returns>
    public static Aggregation Count(string alias = "") =>
        new Aggregation { Count = new Count(), Alias = alias };
}
