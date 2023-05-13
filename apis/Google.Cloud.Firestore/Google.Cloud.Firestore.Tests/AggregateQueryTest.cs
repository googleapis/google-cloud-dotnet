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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.V1;
using NSubstitute;
using NSubstitute.Extensions;
using System;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.AggregateField;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Google.Cloud.Firestore.Tests;

public class AggregateQueryTest
{
    private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
    private static readonly Query s_query = s_db.Collection("col");

    [Fact]
    public void DuplicateAliases()
    {
        Assert.Throws<ArgumentException>(() => s_query.Aggregate(Count(), Count()));
        Assert.Throws<ArgumentException>(() => s_query.Aggregate(Sum("x"), Sum("x")));
        Assert.Throws<ArgumentException>(() => s_query.Aggregate(Sum("x", "alias"), Average("y", "alias")));
        Assert.Throws<ArgumentException>(() => s_query.Aggregate(Count(), Sum("x", "Count")));
    }

    [Fact]
    public void NullAggregateField()
    {
        Assert.Throws<ArgumentException>(() => new AggregateQuery(s_query, new[] { Count(), null }));
    }

    [Fact]
    public void TestToStructuredAggregationQuery()
    {
        var aggregateQuery = s_query.Aggregate(Count(), Sum("x", "custom_alias"), Average("y"));
        var expectedStructuredAggregationQuery = new StructuredAggregationQuery
        {
            StructuredQuery = s_query.ToStructuredQuery(),
            Aggregations =
            {
                new Aggregation() { Alias = "A1", Count = new() },
                new Aggregation() { Alias = "A2", Sum = new() { Field = new FieldReference { FieldPath = "x" } } },
                new Aggregation() { Alias = "A3", Avg = new() { Field = new FieldReference { FieldPath = "y" } } },
            }
        };
        Assert.Equal(expectedStructuredAggregationQuery, aggregateQuery.ToStructuredAggregationQuery());
    }

    [Fact]
    public async Task GetSnapshotAsync_QueryAndReadTimeArePropagated()
    {
        var mock = Substitute.ForPartsOf<FirestoreClient>();
        var db = FirestoreDb.Create("proj", "db", mock);
        var query = db.Collection("col").Select("Name");
        var sampleReadTime = CreateProtoTimestamp(1, 3);
        var request = new RunAggregationQueryRequest
        {
            Parent = query.ParentPath,
            StructuredAggregationQuery = new StructuredAggregationQuery
            {
                StructuredQuery = query.ToStructuredQuery(),
                Aggregations = { new Aggregation { Alias = "A1", Count = new Count() } }
            }
        };
        var response = new FakeAggregationQueryStream(new[]
        {
            new RunAggregationQueryResponse { ReadTime = sampleReadTime, Result = new AggregationResult() }
        });
        mock.Configure().RunAggregationQuery(request, Arg.Any<CallSettings>()).Returns(response);

        var aggregateQuery = query.Count();
        var snapshot = await aggregateQuery.GetSnapshotAsync();

        Assert.Equal(aggregateQuery, snapshot.Query);
        Assert.Equal(Timestamp.FromProto(sampleReadTime), snapshot.ReadTime);
        // We didn't provide a count in the response.
        Assert.Null(snapshot.Count);
    }

    [Fact]
    public async Task GetSnapshotAsync_ResultsAreMapped()
    {
        FirestoreClient mock = Substitute.ForPartsOf<FirestoreClient>();
        var db = FirestoreDb.Create("proj", "db", mock);
        var sampleReadTime = CreateProtoTimestamp(1, 3);
        var query = db.Collection("HighScoreCollection").WhereEqualTo("Player", "Tina");
        var request = new RunAggregationQueryRequest
        {
            Parent = query.ParentPath,
            StructuredAggregationQuery = new StructuredAggregationQuery
            {
                StructuredQuery = query.ToStructuredQuery(),
                Aggregations =
                {
                    new Aggregation { Alias = "A1", Count = new Count() },
                    new Aggregation { Alias = "A2", Sum = new Sum() { Field = new FieldReference { FieldPath = "Score" } } },
                    new Aggregation { Alias = "A3", Avg = new Avg() { Field = new FieldReference { FieldPath = "Level" } } }
                }
            }
        };

        // First return a read time, then the sum and average results, then the count.
        // It's likely we'll always get everything back in one go, but this checks we go through all the responses.
        var sumAvgResult = new AggregationResult
        {
            AggregateFields =
            {
                { "A2", CreateValue(20) },
                { "A3", CreateValue(2.5) }
            }
        };
        var countResult = new AggregationResult { AggregateFields = { { "A1", CreateValue(5) } } };

        var response = new FakeAggregationQueryStream(new[]
        {
            new RunAggregationQueryResponse { ReadTime = sampleReadTime, Result = new AggregationResult() },
            new RunAggregationQueryResponse { Result = sumAvgResult },
            new RunAggregationQueryResponse { Result = countResult },
        });

        mock.Configure().RunAggregationQuery(request, Arg.Any<CallSettings>()).Returns(response);
        var aggregateQuery = query.Aggregate(Count(), Sum("Score"), Average("Level", "AverageLevel"));
        var snapshot = await aggregateQuery.GetSnapshotAsync();
        Assert.Equal(aggregateQuery, snapshot.Query);
        Assert.Equal(Timestamp.FromProto(sampleReadTime), snapshot.ReadTime);
        Assert.Equal(5, snapshot.Count);
        Assert.Equal(5, snapshot.GetValue<int>("Count"));
        Assert.Equal(20, snapshot.GetValue<int>("Sum_Score"));
        Assert.Equal(2.5, snapshot.GetValue<double>("AverageLevel"));
    }

    [Fact]
    public void Equality_JustCount()
    {
        var control = s_query.Count();
        EqualityTester.AssertEqual(control,
            equal: new[]
            {
                new AggregateQuery(s_db.Collection("col"), new[] { Count() }),
                // Aggregate query returned by count
                s_db.Collection("col").Count()
            },
            unequal: new[]
            {
                // Same query but without any aggregation
                new AggregateQuery(s_db.Collection("col"), new AggregateField[0]),
                // Different query
                s_db.Collection("col1").Count()
            });
    }

    [Fact]
    public void Equality_MixedAggregates()
    {
        var control = s_query.Aggregate(Sum("foo"), Average("bar"), Count());
        EqualityTester.AssertEqual(control,
            equal: new[]
            {
                new AggregateQuery(s_db.Collection("col"), new[] { Sum("foo"), Average("bar"), Count() }),
                // Different ordering
                s_db.Collection("col").Aggregate(Sum("foo"), Average("bar"), Count())
            },
            unequal: new[]
            {
                // Different aggregations
                s_db.Collection("col").Count(),
                // Different query
                s_db.Collection("col1").Aggregate(Sum("foo"), Average("bar"), Count()),
                // Different ordering
                s_db.Collection("col").Aggregate(Count(), Average("bar"), Sum("foo")),
                // Same order of sum/average/count, but different fields
                s_db.Collection("col").Aggregate(Sum("bar"), Average("foo"), Count())
            });
    }
}
