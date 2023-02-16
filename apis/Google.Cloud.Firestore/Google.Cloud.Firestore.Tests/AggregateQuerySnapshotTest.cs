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
using Xunit;
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
        var aggQuerySnapshot = new AggregateQuerySnapshot(aggQuery, sampleReadTime, sampleCount);
        Assert.Equal(sampleCount, aggQuerySnapshot.Count);
        Assert.Equal(sampleReadTime, aggQuerySnapshot.ReadTime);
        Assert.Equal(aggQuery, aggQuerySnapshot.Query);
    }

    [Fact]
    public void Equality()
    {
        AggregateQuery aggQuery1 = s_db.Collection("col").Count();
        AggregateQuery aggQuery2 = s_db.Collection("col1").Count();
        var sampleReadTime = Timestamp.FromProto(CreateProtoTimestamp(1, 2));
        int sampleCount = 10;
        var control = new AggregateQuerySnapshot(aggQuery1, sampleReadTime, sampleCount);

        EqualityTester.AssertEqual(control,
            equal: new[] {
                // All the members are equal.
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(1, 2)), 10)
            },
            unequal: new[] {
                // Unequal aggregate query
                new AggregateQuerySnapshot(aggQuery2, sampleReadTime, sampleCount),
                // Null count.
                new AggregateQuerySnapshot(aggQuery2, sampleReadTime, null),
                // Same aggregate query and count but different read time. 
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(3, 4)), sampleCount),
                // Same aggregate query but different read time and count.
                new AggregateQuerySnapshot(s_db.Collection("col").Count(), Timestamp.FromProto(CreateProtoTimestamp(3, 4)), 20)
            });
    }
}
