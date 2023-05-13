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
using System;
using System.Collections.Generic;
using Xunit;
using static Google.Cloud.Firestore.AggregateField;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests;
public class AggregateQuerySnapshotTest
{
    private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

    [Fact]
    public void VerifyAllMembers()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Count();
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        int sampleCount = 10;
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, sampleCount, null);
        Assert.Equal(sampleCount, aggQuerySnapshot.Count);
        Assert.Equal(sampleReadTime, aggQuerySnapshot.ReadTime);
        Assert.Equal(aggQuery, aggQuerySnapshot.Query);
    }

    [Fact]
    public void VerifyAllMembers_Aggregates()
    {
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new Dictionary<string, Value>() { { "Count", new Value() { IntegerValue = 20 } },
            { "Sum_bar", new Value() { IntegerValue = 20 } }, { "Avg_bar", new Value() { DoubleValue = 20 } } };
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"), Average("bar"), Count());
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, null, data);

        Assert.Equal(20, aggQuerySnapshot.GetValue<Value>("Sum_bar").IntegerValue);
        Assert.Equal(20, aggQuerySnapshot.GetValue<Value>("Avg_bar").DoubleValue);
        Assert.Equal(20, aggQuerySnapshot.GetValue<Value>("Count").IntegerValue);
    }

    [Fact]
    public void Equality()
    {
        AggregateQuery aggQuery1 = s_db.Collection("col").Count();
        AggregateQuery aggQuery2 = s_db.Collection("col1").Count();
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        int sampleCount = 10;
        var control = new AggregateQuerySnapshot(aggQuery1, sampleReadTime, sampleCount, null);

        EqualityTester.AssertEqual(control,
            equal: new[] {
                // All the members are equal.
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(1, 2)), 10, null),
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(1, 2)), 10, new Dictionary<string, Value>() { { "Count", new Value() { IntegerValue = 20 } } })
            },
            unequal: new[] {
                // Unequal aggregate query
                new AggregateQuerySnapshot(aggQuery2, sampleReadTime, sampleCount, null),
                // Null count.
                new AggregateQuerySnapshot(aggQuery2, sampleReadTime, null, null),
                // Same aggregate query and count but different read time. 
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(3, 4)), sampleCount, null),
                // Same aggregate query but different read time and count.
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(3, 4)), 20, null)
            });
    }

    [Fact]
    public void Equality_Dictionary()
    {
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"), Average("bar"), Count());
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new Dictionary<string, Value>() { { "Count", new Value() { IntegerValue = 20 } }, { "Sum_bar", new Value() { IntegerValue = 20 } }, { "Avg_bar", new Value() { DoubleValue = 20 } } };
        var control = new AggregateQuerySnapshot(aggQuery, sampleReadTime, 20, data);

        EqualityTester.AssertEqual(control,
            equal: new[] {
                // All the members are equal.
                new AggregateQuerySnapshot(s_db.Collection("col").Aggregate(Sum("bar"), Average("bar"), Count()), Timestamp.FromProto(CreateProtoTimestamp(1, 2)), 20,
                    new Dictionary<string, Value>() { { "Count", new Value() { IntegerValue = 20 } }, { "Sum_bar", new Value() { IntegerValue = 20 } }, { "Avg_bar", new Value() { DoubleValue = 20 } } })
            },
            unequal: new[] {
                // Unequal aggregate query
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(1, 2)), 20, data),
                // Same aggregate query but different read time
                new AggregateQuerySnapshot(aggQuery, Timestamp.FromProto(CreateProtoTimestamp(3, 4)), 20, data)
            });
    }

    [Fact]
    public void GetValue()
    {
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new Dictionary<string, Value>() { { "Sum_bar", new Value() { IntegerValue = 20 } } };
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"));
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, null, data);

        Assert.Equal(20, aggQuerySnapshot.GetValue<long>("Sum_bar")); // Alias input
        Assert.Equal(20, aggQuerySnapshot.GetValue<long>(Sum("bar"))); // AggregateField input
        Assert.NotNull(aggQuerySnapshot.GetValue<object>(Sum("bar"))); // Object type output
        Assert.Throws<InvalidOperationException>(() => aggQuerySnapshot.GetValue<Value>("check")); // Invalid input
    }

    [Fact]
    public void TryGetValue()
    {
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        var data = new Dictionary<string, Value>() { { "Sum_bar", new Value() { IntegerValue = 20 } } };
        AggregateQuery aggQuery = s_db.Collection("col").Aggregate(Sum("bar"));
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, null, data);

        Assert.True(aggQuerySnapshot.TryGetValue("Sum_bar", out long scores)); // Alias input
        Assert.Equal(20, scores);
        Assert.True(aggQuerySnapshot.TryGetValue(Sum("bar"), out long sumscore)); // AggregateField input
        Assert.Equal(20, sumscore);
        Assert.True(aggQuerySnapshot.TryGetValue("Sum_bar", out object _)); // Object type output
        Assert.False(aggQuerySnapshot.TryGetValue("Foo", out string _)); // Invalid input
    }
}
