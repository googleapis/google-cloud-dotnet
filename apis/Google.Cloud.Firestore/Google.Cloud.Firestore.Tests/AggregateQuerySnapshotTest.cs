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

using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.V1;
using Google.Protobuf.Collections;
using System;
using Xunit;
using static Google.Cloud.Firestore.AggregateField;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests;
public class AggregateQuerySnapshotTest
{
    private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

    [Fact]
    public void CountIsFetchedFromData()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Count();
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new MapField<string, Value> { { "Count", CreateValue(20) } };
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);
        Assert.Equal(20, aggQuerySnapshot.Count);
        Assert.Equal(sampleReadTime, aggQuerySnapshot.ReadTime);
        Assert.Equal(aggQuery, aggQuerySnapshot.Query);
    }

    [Fact]
    public void NoCount()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"));
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new MapField<string, Value> { { "Sum_bar", CreateValue(20) } };
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);
        Assert.Null(aggQuerySnapshot.Count);
    }

    [Fact]
    public void NonIntegerCount()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Count();
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new MapField<string, Value> { { "Count", CreateValue(1.5) } };
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);
        Assert.Null(aggQuerySnapshot.Count);
    }

    [Fact]
    public void VerifyAllMembers_NonCountAggregates()
    {
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = CreateData(20, 1.5, null);
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"), Average("bar"));
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);
        Assert.Equal(sampleReadTime, aggQuerySnapshot.ReadTime);
        Assert.Equal(aggQuery, aggQuerySnapshot.Query);

        Assert.Equal(20, aggQuerySnapshot.GetValue<Value>("Sum_bar").IntegerValue);
        Assert.Equal(1.5, aggQuerySnapshot.GetValue<Value>("Avg_bar").DoubleValue);
    }

    [Fact]
    public void Equality()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"), Average("bar"), Count());
        AggregateQuery aggQuery2 = s_db.Collection("col").Aggregate(Sum("bar"), Average("bar"), Count());
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = CreateData(20, 1.5, 10);
        var equalData = CreateData(20, 1.5, 10);
        var unequalData1 = CreateData(20, 1.5, 30);
        var unequalData2 = CreateData(20, 1.5, 10);
        unequalData2["Sum_other"] = CreateValue(20);
        var control = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);

        EqualityTester.AssertEqual(control,
            equal: new[] {
                // All the members are equal.
                new AggregateQuerySnapshot(aggQuery2, Timestamp.FromProto(CreateProtoTimestamp(1, 2)), equalData),
            },
            unequal: new[] {
                // Unequal aggregate query
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), sampleReadTime, data),
                // Same aggregate query but different read time
                new AggregateQuerySnapshot(aggQuery, Timestamp.FromProto(CreateProtoTimestamp(3, 4)), data),
                // Different data but for same keys
                new AggregateQuerySnapshot(aggQuery, sampleReadTime, unequalData1),
                // More keys (which probably wouldn't happen with the same aggregate query, but...)
                new AggregateQuerySnapshot(aggQuery, sampleReadTime, unequalData2),
            });
    }

    [Fact]
    public void GetValue()
    {
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new MapField<string, Value>() { { "Sum_bar", CreateValue(20) } };
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"));
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);

        // Alias key
        Assert.Equal(20, aggQuerySnapshot.GetValue<long>("Sum_bar"));

        // AggregateField key
        Assert.Equal(20, aggQuerySnapshot.GetValue<long>(Sum("bar")));

        // Object type output
        Assert.Equal(20L, aggQuerySnapshot.GetValue<object>(Sum("bar")));

        // Missing key
        Assert.Throws<InvalidOperationException>(() => aggQuerySnapshot.GetValue<Value>("check"));
    }

    [Fact]
    public void TryGetValue()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"));
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = CreateData(20, 1.5, 10);
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, data);

        // Alias key
        Assert.True(aggQuerySnapshot.TryGetValue("Sum_bar", out long sum));
        Assert.Equal(20, sum);
        Assert.True(aggQuerySnapshot.TryGetValue("Avg_bar", out double avg));
        Assert.Equal(1.5, avg);
        Assert.True(aggQuerySnapshot.TryGetValue("Count", out long count));
        Assert.Equal(10, count);

        // AggregateField key
        Assert.True(aggQuerySnapshot.TryGetValue(Sum("bar"), out sum));
        Assert.Equal(20, sum);
        Assert.True(aggQuerySnapshot.TryGetValue(Count(), out count));
        Assert.Equal(10, count);

        // Object type output
        Assert.True(aggQuerySnapshot.TryGetValue("Sum_bar", out object sumObj));
        Assert.Equal(20L, sumObj);
        Assert.True(aggQuerySnapshot.TryGetValue("Avg_bar", out object avgObj));
        Assert.Equal(1.5, avgObj);
        Assert.True(aggQuerySnapshot.TryGetValue("Count", out object countObj));
        Assert.Equal(10L, countObj);

        // Missing key
        Assert.False(aggQuerySnapshot.TryGetValue("Foo", out object _));
    }

    private static MapField<string, Value> CreateData(long sum, double avg, long? count)
    {
        var data = new MapField<string, Value>
        {
            { "Sum_bar", CreateValue(sum) },
            { "Avg_bar", CreateValue(avg) }
        };
        if (count != null)
        {
            data["Count"] = new Value { IntegerValue = count.Value };
        }
        return data;
    }
}
