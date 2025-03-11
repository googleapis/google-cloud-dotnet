// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;

namespace Google.Cloud.Datastore.V1.Tests;

public class DatastoreQueryTest
{
    private static readonly GqlQuery s_gqlQuery = new GqlQuery();
    private static readonly Query s_query = new Query();
    private static readonly AggregationQuery s_aggregationQuery = new AggregationQuery();
    private static readonly PartitionId s_partitionId = new PartitionId();

    public static TheoryData<DatastoreQuery> InvalidRegularQueries = new()
    {
        new DatastoreQuery(),
        new DatastoreQuery { AggregationQuery = s_aggregationQuery },
        new DatastoreQuery { AggregationQuery = s_aggregationQuery, Query = s_query },
        new DatastoreQuery { GqlQuery = s_gqlQuery, Query = s_query },
    };

    public static TheoryData<DatastoreQuery> InvalidAggregationQueries = new()
    {
        new DatastoreQuery(),
        new DatastoreQuery { Query = s_query },
        new DatastoreQuery { AggregationQuery = s_aggregationQuery, Query = s_query },
        new DatastoreQuery { GqlQuery = s_gqlQuery, AggregationQuery = s_aggregationQuery },
    };

    [Fact]
    public void ToRequest_Valid()
    {
        var query = new DatastoreQuery { Query = s_query };
        var expected = new RunQueryRequest
        {
            Query = s_query,
            ProjectId = "project",
            DatabaseId = "database",
            PartitionId = s_partitionId
        };
        var actual = query.ToRequest("project", "database", s_partitionId);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(InvalidRegularQueries))]
    public void ToRequest_Invalid(DatastoreQuery query) =>
        Assert.Throws<InvalidOperationException>(() => query.ToRequest("project", "database", s_partitionId));

    [Fact]
    public void ToAggregationRequest_Valid()
    {
        var query = new DatastoreQuery { AggregationQuery = s_aggregationQuery };
        var expected = new RunAggregationQueryRequest
        {
            AggregationQuery = s_aggregationQuery,
            ProjectId = "project",
            DatabaseId = "database",
            PartitionId = s_partitionId
        };
        var actual = query.ToAggregationRequest("project", "database", s_partitionId);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(InvalidAggregationQueries))]
    public void ToAggregationRequest_Invalid(DatastoreQuery query) =>
        Assert.Throws<InvalidOperationException>(() => query.ToAggregationRequest("project", "database", s_partitionId));
}
