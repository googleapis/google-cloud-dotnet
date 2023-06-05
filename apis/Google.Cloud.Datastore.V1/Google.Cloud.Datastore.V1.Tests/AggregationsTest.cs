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

using System.Collections.Generic;
using Xunit;
using static Google.Cloud.Datastore.V1.AggregationQuery.Types;
using static Google.Cloud.Datastore.V1.Aggregations;

namespace Google.Cloud.Datastore.V1.Tests;
public class AggregationsTest
{
    [Fact]
    public void AggregationTest()
    {
        var avgAgg = Average("age");
        var sumAgg = Sum("height");
        List<Aggregation> aggregations = new List<Aggregation> { avgAgg, sumAgg };

        AggregationQuery aggQuery = new AggregationQuery()
        {
            Aggregations = { Average("age"), Sum("height") }
        };       

        Assert.Equal(aggregations, aggQuery.Aggregations);
    }

    [Fact]
    public void AggregationTest_WithAlias()
    {
        var avgAgg = Average("age", "Avg_age");
        var sumAgg = Sum("height", "Sum_height");
        List<Aggregation> aggregations = new List<Aggregation> { avgAgg, sumAgg };

        AggregationQuery aggQuery = new AggregationQuery()
        {
            Aggregations = { Average("age", "Avg_age"), Sum("height", "Sum_height") }
        };

        Assert.Equal(aggregations, aggQuery.Aggregations);
    }
}
