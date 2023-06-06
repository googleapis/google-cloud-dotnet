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

using Xunit;
using static Google.Cloud.Datastore.V1.AggregationQuery.Types;
using static Google.Cloud.Datastore.V1.AggregationQuery.Types.Aggregation.Types;
using static Google.Cloud.Datastore.V1.Aggregations;

namespace Google.Cloud.Datastore.V1.Tests;
public class AggregationsTest
{
    [Fact]
    public void AggregationTest()
    {
        Assert.Equal(new Aggregation { Count = new Count() }, Count());
        Assert.Equal(new Aggregation { Sum = new Sum { Property = new PropertyReference("age") }}, Sum("age"));
        Assert.Equal(new Aggregation { Avg = new Avg { Property = new PropertyReference("age") }}, Average("age"));        
    }

    [Fact]
    public void AggregationTest_WithAlias()
    {
        Assert.Equal(new Aggregation { Count = new Count(), Alias = "count" }, Count("count"));
        Assert.Equal(new Aggregation { Sum = new Sum { Property = new PropertyReference("age") }, Alias = "sum_alias" }, Sum("age", "sum_alias"));
        Assert.Equal(new Aggregation { Avg = new Avg { Property = new PropertyReference("age") }, Alias = "age_alias" }, Average("age", "age_alias"));
    }
}
