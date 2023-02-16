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
using Moq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;

namespace Google.Cloud.Firestore.Tests;
public class AggregateQueryTest
{
    private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
    private static readonly Query s_query = s_db.Collection("col");

    [Fact]
    public void TestToStructuredAggregationQuery()
    {
        var expectedStructuredAggregationQuery = new StructuredAggregationQuery
        {
            StructuredQuery = s_query.ToStructuredQuery(),
            Aggregations = { new Aggregation { Alias = "Count", Count = new Count() } }
        };
        Assert.Equal(expectedStructuredAggregationQuery, s_query.Count().ToStructuredAggregationQuery());
    }

    [Fact]
    public async Task GetSnapshotAsync_VerifySnapshotMembers()
    {
        Mock<FirestoreClient> mock = new() { CallBase = true };
        var db = FirestoreDb.Create("proj", "db", mock.Object);
        var query = db.Collection("col").Select("Name");
        var sampleReadTime = CreateProtoTimestamp(1, 3);
        var request = new RunAggregationQueryRequest
        {
            Parent = query.ParentPath,
            StructuredAggregationQuery = new StructuredAggregationQuery
            {
                StructuredQuery = query.ToStructuredQuery(),
                Aggregations = { new Aggregation { Alias = "Count", Count = new Count() } }
            }
        };
        var response = new FakeAggregationQueryStream(new[]
        {
            new RunAggregationQueryResponse { ReadTime = sampleReadTime, Result = new AggregationResult() }
        });
        mock.Setup(c => c.RunAggregationQuery(request, It.IsAny<CallSettings>())).Returns(response);
        var aggregateQuery = query.Count();
        var snapshot = await aggregateQuery.GetSnapshotAsync();
        Assert.Equal(aggregateQuery, snapshot.Query);
        Assert.Equal(Timestamp.FromProto(sampleReadTime), snapshot.ReadTime);
    }

    [Fact]
    public void Equality()
    {
        var control = s_query.Count();
        EqualityTester.AssertEqual(control,
            equal: new[]
            {
                new AggregateQuery(s_db.Collection("col")).WithAggregation(Aggregates.CreateCountAggregate()),
                // Aggregate query returned by count.
                s_db.Collection("col").Count()
            },
            unequal: new[]
            {
                // same query but without any aggregation.
                new AggregateQuery(s_db.Collection("col")),
                // un-equal query.
                new AggregateQuery(s_db.Collection("col1"))
            });
    }
}
