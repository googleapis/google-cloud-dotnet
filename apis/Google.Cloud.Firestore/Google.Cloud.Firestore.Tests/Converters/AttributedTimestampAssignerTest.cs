// Copyright 2019, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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

using Google.Cloud.Firestore.Converters;
using System;
using Xunit;
using BclType = System.Type;
using WKT = Google.Protobuf.WellKnownTypes;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;

namespace Google.Cloud.Firestore.Tests.Converters
{
    public class AttributedTimestampAssignerTest
    {
        [Fact]
        public void PopulateTimestamps()
        {
            var target = new AllTimestampOptionsModel();
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var snapshot = GetSampleSnapshot(db, "doc1");

            AttributedTimestampAssigner.MaybeAssignTimestamps(target, snapshot);

            Assert.Equal(snapshot.CreateTime.Value.ToDateTime(), target.CreateDateTime);
            Assert.Equal(snapshot.CreateTime.Value.ToDateTimeOffset(), target.CreateDateTimeOffset);
            Assert.Equal(snapshot.CreateTime, target.CreateTimestamp);
            Assert.Equal(snapshot.CreateTime.Value.ToDateTime(), target.NullableCreateDateTime);
            Assert.Equal(snapshot.CreateTime.Value.ToDateTimeOffset(), target.NullableCreateDateTimeOffset);
            Assert.Equal(snapshot.CreateTime, target.NullableCreateTimestamp);
            Assert.Equal(snapshot.CreateTime.Value.ToProto(), target.CreateTimestampProto);

            Assert.Equal(snapshot.UpdateTime.Value.ToDateTime(), target.UpdateDateTime);
            Assert.Equal(snapshot.UpdateTime.Value.ToDateTimeOffset(), target.UpdateDateTimeOffset);
            Assert.Equal(snapshot.UpdateTime, target.UpdateTimestamp);
            Assert.Equal(snapshot.UpdateTime.Value.ToDateTime(), target.NullableUpdateDateTime);
            Assert.Equal(snapshot.UpdateTime.Value.ToDateTimeOffset(), target.NullableUpdateDateTimeOffset);
            Assert.Equal(snapshot.UpdateTime, target.NullableUpdateTimestamp);
            Assert.Equal(snapshot.UpdateTime.Value.ToProto(), target.UpdateTimestampProto);

            Assert.Equal(snapshot.ReadTime.ToDateTime(), target.ReadDateTime);
            Assert.Equal(snapshot.ReadTime.ToDateTimeOffset(), target.ReadDateTimeOffset);
            Assert.Equal(snapshot.ReadTime, target.ReadTimestamp);
            Assert.Equal(snapshot.ReadTime.ToDateTime(), target.NullableReadDateTime);
            Assert.Equal(snapshot.ReadTime.ToDateTimeOffset(), target.NullableReadDateTimeOffset);
            Assert.Equal(snapshot.ReadTime, target.NullableReadTimestamp);
            Assert.Equal(snapshot.ReadTime.ToProto(), target.ReadTimestampProto);
        }

        [Fact]
        public void MissingDocumentTimestamps()
        {
            var target = new AllTimestampOptionsModel();
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var readTime = new Timestamp(1, 100);
            var snapshot = DocumentSnapshot.ForMissingDocument(db, db.Document("col1/doc1").Path, readTime);

            AttributedTimestampAssigner.MaybeAssignTimestamps(target, snapshot);

            Assert.Equal(default, target.CreateDateTime);
            Assert.Equal(default, target.CreateDateTimeOffset);
            Assert.Equal(default, target.CreateTimestamp);
            Assert.Null(target.NullableCreateDateTime);
            Assert.Null(target.NullableCreateDateTimeOffset);
            Assert.Null(target.NullableCreateTimestamp);
            Assert.Null(target.CreateTimestampProto);

            Assert.Equal(default, target.UpdateDateTime);
            Assert.Equal(default, target.UpdateDateTimeOffset);
            Assert.Equal(default, target.UpdateTimestamp);
            Assert.Null(target.NullableUpdateDateTime);
            Assert.Null(target.NullableUpdateDateTimeOffset);
            Assert.Null(target.NullableUpdateTimestamp);
            Assert.Null(target.UpdateTimestampProto);

            Assert.Equal(readTime.ToDateTime(), target.ReadDateTime);
            Assert.Equal(readTime.ToDateTimeOffset(), target.ReadDateTimeOffset);
            Assert.Equal(readTime, target.ReadTimestamp);
            Assert.Equal(readTime.ToDateTime(), target.NullableReadDateTime);
            Assert.Equal(readTime.ToDateTimeOffset(), target.NullableReadDateTimeOffset);
            Assert.Equal(readTime, target.NullableReadTimestamp);
            Assert.Equal(readTime.ToProto(), target.ReadTimestampProto);
        }

        [FirestoreData]
        private class AllTimestampOptionsModel
        {
            /// <summary>
            /// A timestamp that isn't part of a snapshot. This is used to ensure we're actually setting properties
            /// rather than just leaving them.
            /// </summary>
            private static readonly Timestamp s_sampleOtherTimestamp = new Timestamp(-1, 123);

            [FirestoreDocumentCreateTimestamp] public DateTime CreateDateTime { get; set; } = s_sampleOtherTimestamp.ToDateTime();
            [FirestoreDocumentCreateTimestamp] public DateTimeOffset CreateDateTimeOffset { get; set; } = s_sampleOtherTimestamp.ToDateTimeOffset();
            [FirestoreDocumentCreateTimestamp] public Timestamp CreateTimestamp { get; set; } = s_sampleOtherTimestamp;
            [FirestoreDocumentCreateTimestamp] public DateTime? NullableCreateDateTime { get; set; } = s_sampleOtherTimestamp.ToDateTime();
            [FirestoreDocumentCreateTimestamp] public DateTimeOffset? NullableCreateDateTimeOffset { get; set; } = s_sampleOtherTimestamp.ToDateTimeOffset();
            [FirestoreDocumentCreateTimestamp] public Timestamp? NullableCreateTimestamp { get; set; } = s_sampleOtherTimestamp;
            [FirestoreDocumentCreateTimestamp] public WKT::Timestamp CreateTimestampProto { get; set; } = s_sampleOtherTimestamp.ToProto();

            [FirestoreDocumentUpdateTimestamp] public DateTime UpdateDateTime { get; set; } = s_sampleOtherTimestamp.ToDateTime();
            [FirestoreDocumentUpdateTimestamp] public DateTimeOffset UpdateDateTimeOffset { get; set; } = s_sampleOtherTimestamp.ToDateTimeOffset();
            [FirestoreDocumentUpdateTimestamp] public Timestamp UpdateTimestamp { get; set; } = s_sampleOtherTimestamp;
            [FirestoreDocumentUpdateTimestamp] public DateTime? NullableUpdateDateTime { get; set; } = s_sampleOtherTimestamp.ToDateTime();
            [FirestoreDocumentUpdateTimestamp] public DateTimeOffset? NullableUpdateDateTimeOffset { get; set; } = s_sampleOtherTimestamp.ToDateTimeOffset();
            [FirestoreDocumentUpdateTimestamp] public Timestamp? NullableUpdateTimestamp { get; set; } = s_sampleOtherTimestamp;
            [FirestoreDocumentUpdateTimestamp] public WKT::Timestamp UpdateTimestampProto { get; set; } = s_sampleOtherTimestamp.ToProto();

            [FirestoreDocumentReadTimestamp] public DateTime ReadDateTime { get; set; } = s_sampleOtherTimestamp.ToDateTime();
            [FirestoreDocumentReadTimestamp] public DateTimeOffset ReadDateTimeOffset { get; set; } = s_sampleOtherTimestamp.ToDateTimeOffset();
            [FirestoreDocumentReadTimestamp] public Timestamp ReadTimestamp { get; set; } = s_sampleOtherTimestamp;
            [FirestoreDocumentReadTimestamp] public DateTime? NullableReadDateTime { get; set; } = s_sampleOtherTimestamp.ToDateTime();
            [FirestoreDocumentReadTimestamp] public DateTimeOffset? NullableReadDateTimeOffset { get; set; } = s_sampleOtherTimestamp.ToDateTimeOffset();
            [FirestoreDocumentReadTimestamp] public Timestamp? NullableReadTimestamp { get; set; }
            [FirestoreDocumentReadTimestamp] public WKT::Timestamp ReadTimestampProto { get; set; } = s_sampleOtherTimestamp.ToProto();
        }

        [Theory]
        [InlineData(typeof(ReadOnlyProperty))]
        [InlineData(typeof(WrongPropertyType))]
        [InlineData(typeof(Indexer))]
        [InlineData(typeof(StaticProperty))]
        [InlineData(typeof(AlsoHasFirestorePropertyAttribute))]
        [InlineData(typeof(MultipleTimestampProperties))]
        public void InvalidAttributes(BclType type)
        {
            var target = Activator.CreateInstance(type);
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var snapshot = GetSampleSnapshot(db, "doc1");

            Assert.Throws<InvalidOperationException>(() => AttributedTimestampAssigner.MaybeAssignTimestamps(target, snapshot));
        }

        [FirestoreData]
        private class ReadOnlyProperty
        {
            [FirestoreDocumentCreateTimestamp]
            public Timestamp Timestamp => default;
        }

        [FirestoreData]
        private class WrongPropertyType
        {
            [FirestoreDocumentCreateTimestamp]
            public int Timestamp { get; set; }
        }

        [FirestoreData]
        private class Indexer
        {
            [FirestoreDocumentCreateTimestamp]
            public Timestamp this[int index]
            {
                get => default;
                set { }
            }
        }

        [FirestoreData]
        private class StaticProperty
        {
            [FirestoreDocumentCreateTimestamp]
            public static Timestamp Timestamp { get; set; }
        }

        [FirestoreData]
        private class AlsoHasFirestorePropertyAttribute
        {
            [FirestoreDocumentCreateTimestamp, FirestoreProperty]
            public Timestamp Timestamp { get; set; }
        }

        [FirestoreData]
        private class MultipleTimestampProperties
        {
            [FirestoreDocumentCreateTimestamp, FirestoreDocumentUpdateTimestamp]
            public Timestamp Timestamp { get; set; }
        }
    }
}
