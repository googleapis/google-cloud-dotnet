// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
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
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

using WKT = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests
{
    public class DocumentSnapshotTest
    {
        [Fact]
        public void MissingDocument()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var document = DocumentSnapshot.ForMissingDocument(db, "projects/proj/databases/db/documents/col1/doc1/col2/doc2", readTime);
            Assert.Equal(db.Document("col1/doc1/col2/doc2"), document.Reference);
            Assert.Equal("doc2", document.Id);
            Assert.Same(db, document.Database);
            Assert.Null(document.Document);
            Assert.Null(document.CreateTime);
            Assert.Null(document.UpdateTime);
            Assert.Equal(readTime, document.ReadTime);
            Assert.False(document.Exists);
            Assert.Null(document.ToDictionary());
            Assert.Null(document.ConvertTo<SampleData>());
            Assert.Throws<InvalidOperationException>(() => document.GetValue<string>("name"));
            Assert.Throws<InvalidOperationException>(() => document.GetValue<string>(new FieldPath("name")));
            Assert.False(document.TryGetValue("name", out string name1));
            Assert.False(document.TryGetValue(new FieldPath("name"), out string name2));
        }

        [Fact]
        public void ExistingDocument()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2"
            };
            var document = DocumentSnapshot.ForDocument(db, proto, readTime);
            Assert.Equal(db.Document("col1/doc1/col2/doc2"), document.Reference);
            Assert.Equal("doc2", document.Id);
            Assert.Same(db, document.Database);
            Assert.Same(proto, document.Document);
            Assert.Equal(new Timestamp(1, 10), document.CreateTime);
            Assert.Equal(new Timestamp(2, 20), document.UpdateTime);
            Assert.Equal(readTime, document.ReadTime);
            Assert.True(document.Exists);
            // Tests for data access are performed separately.
        }

        [Fact]
        public void ConvertTo_CustomType()
        {
            var doc = GetSampleSnapshot();
            var sample = doc.ConvertTo<SampleData>();
            Assert.Equal("Test", sample.Name);
            Assert.Equal(20, sample.Nested.Score);
        }

        [Fact]
        public void ConvertTo_ProtoValueDictionary()
        {
            var doc = GetSampleSnapshot();
            // Conversion should clone the values
            var dictionary = doc.ConvertTo<Dictionary<string, Value>>();
            dictionary["Name"].StringValue = "Modified";

            // So fetching a field should show the original value
            Assert.Equal("Test", doc.GetValue<string>("Name"));

            // And deserializing again should show the original value too
            var sample = doc.ConvertTo<SampleData>();
            Assert.Equal("Test", sample.Name);
        }

        [Fact]
        public void GetValue_ProtoValue()
        {
            var doc = GetSampleSnapshot();
            var expected = new Value { StringValue = "Test" };
            var actual = doc.GetValue<Value>("Name");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToDictionary()
        {
            var doc = GetSampleSnapshot();
            var sample = doc.ToDictionary();
            Assert.Equal("Test", sample["Name"]);
            Assert.Equal(20L, ((Dictionary<string, object>) sample["Nested"])["Score"]);
        }

        // string overloads just call FieldPath overloads, so we just test with strings

        [Fact]
        public void GetValue()
        {
            var doc = GetSampleSnapshot();
            Assert.Equal("Test", doc.GetValue<string>("Name"));
            Assert.Equal(20, doc.GetValue<int>("Nested.Score"));
            Assert.Null(doc.GetValue<string>("NullField"));
        }

        [Fact]
        public void GetValue_CloneTimestamp()
        {
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2",
                Fields =
                {
                    { "Timestamp", new Value { TimestampValue = CreateProtoTimestamp(1, 30) } },
                }
            };
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var snapshot = DocumentSnapshot.ForDocument(db, proto, readTime);
            // If we ask for the field twice, the results should be independent. (We clone the value.)
            var fieldValue1 = snapshot.GetValue<WKT::Timestamp>("Timestamp");
            var fieldValue2 = snapshot.GetValue<WKT::Timestamp>("Timestamp");
            Assert.NotSame(fieldValue1, fieldValue2);
            Assert.Equal(fieldValue1, fieldValue2);

            fieldValue1.Nanos = 999;
            Assert.NotEqual(fieldValue1, fieldValue2);
        }

        [Fact]
        public void GetValue_CloneLatLng()
        {
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2",
                Fields =
                {
                    { "GeoPoint", new Value { GeoPointValue = new Type.LatLng { Latitude = 2.5, Longitude = 3.75 } } }
                }
            };
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var snapshot = DocumentSnapshot.ForDocument(db, proto, readTime);

            // If we ask for the field twice, the results should be independent. (We clone the value.)
            var fieldValue1 = snapshot.GetValue<Type.LatLng>("GeoPoint");
            var fieldValue2 = snapshot.GetValue<Type.LatLng>("GeoPoint");
            Assert.NotSame(fieldValue1, fieldValue2);
            Assert.Equal(fieldValue1, fieldValue2);

            fieldValue1.Longitude = 4.5;
            Assert.NotEqual(fieldValue1, fieldValue2);
        }

        [Fact]
        public void TryGetValue()
        {
            var doc = GetSampleSnapshot();
            Assert.True(doc.TryGetValue("Name", out string name));
            Assert.True(doc.TryGetValue("Nested.Score", out int score));
            Assert.True(doc.TryGetValue("NullField", out string shouldBeNull));
            Assert.Equal("Test", name);
            Assert.Equal(20, score);
            Assert.Null(shouldBeNull);
            Assert.False(doc.TryGetValue("Foo", out string foo));
            Assert.False(doc.TryGetValue("Nested.Foo", out string nestedFoo));
        }

        [Fact]
        public void ContainsField()
        {
            var doc = GetSampleSnapshot();
            Assert.True(doc.ContainsField("Name"));
            Assert.True(doc.ContainsField("Nested"));
            Assert.True(doc.ContainsField("Nested.Score"));
            Assert.True(doc.ContainsField("NullField"));
            Assert.False(doc.ContainsField("Missing"));
            Assert.False(doc.ContainsField("Nested.Missing"));
            Assert.False(doc.ContainsField("Nested.Score.Missing"));
        }

        [Fact]
        public void Equality()
        {
            var control = GetSampleSnapshot();
            var equalDb = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

            // Equal (but distinct) everything
            var doc1 = control.Document.Clone();
            var equal1 = DocumentSnapshot.ForDocument(equalDb, doc1, control.ReadTime);

            var doc2 = control.Document.Clone();
            doc2.CreateTime = null;
            doc2.UpdateTime = null;
            // Different create/update times
            var equal2 = DocumentSnapshot.ForDocument(equalDb, doc2, control.ReadTime);

            // Different read time
            var equal3 = DocumentSnapshot.ForDocument(equalDb, doc2, new Timestamp(10, 3));

            // Different fields
            var doc4 = doc1.Clone();
            doc4.Fields["other"] = new Value { StringValue = "different" };
            var unequal1 = DocumentSnapshot.ForDocument(equalDb, doc4, control.ReadTime);

            // Different name
            var doc5 = doc1.Clone();
            doc5.Name += "x";
            var unequal2 = DocumentSnapshot.ForDocument(equalDb, doc5, control.ReadTime);

            EqualityTester.AssertEqual(control, new[] { equal1, equal2, equal3 }, new[] { unequal1, unequal2 });
        }

        [Fact]
        public void Equality_Missing()
        {
            var nonMissing = GetSampleSnapshot();
            var db = nonMissing.Database;
            var doc = nonMissing.Document;

            var control = DocumentSnapshot.ForMissingDocument(db, doc.Name, new Timestamp(1, 2));
            var equal = DocumentSnapshot.ForMissingDocument(db, doc.Name, new Timestamp(1, 3));
            var unequal1 = DocumentSnapshot.ForMissingDocument(db, doc.Name + "x", new Timestamp(1, 2));
            var unequal2 = DocumentSnapshot.ForDocument(db, doc, new Timestamp(1, 2));

            EqualityTester.AssertEqual(control, new[] { equal }, new[] { unequal1, unequal2 });
        }

        [Fact]
        public void ConvertTo_ValueType()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2",
                Fields =
                {
                    ["Name"] = CreateValue("text"),
                    ["Value"] = CreateValue(100)
                }
            };
            var document = DocumentSnapshot.ForDocument(db, proto, readTime);
            var value = document.ConvertTo<SerializationTestData.CustomValueType>();
            Assert.Equal("text", value.Name);
            Assert.Equal(100, value.Value);
        }

        [Fact]
        public void ConvertTo_Missing()
        {
            var sample = GetSampleSnapshot();
            var document = DocumentSnapshot.ForMissingDocument(sample.Database, sample.Document.Name, new Timestamp(1, 2));

            // Deserializing ends up with the default value of the value type. That's slightly annoying, but
            // users can always use the Exists property instead.
            Assert.Equal(0, document.ConvertTo<int>());

            var custom = document.ConvertTo<SerializationTestData.CustomValueType>();
            Assert.Null(custom.Name);
            Assert.Equal(0, custom.Value);
        }

        [Fact]
        public void ConvertTo_WithId()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2",
                Fields =
                {
                    ["Name"] = ProtoHelpers.CreateValue("text"),
                    ["Value"] = ProtoHelpers.CreateValue(100)
                }
            };
            var document = DocumentSnapshot.ForDocument(db, proto, readTime);

            var converted = document.ConvertTo<SampleDataWithDocumentId>();
            Assert.Equal("text", converted.Name);
            Assert.Equal(100, converted.Value);
            Assert.Equal("doc2", converted.DocumentId);
        }

        [Fact]
        public void ConvertTo_WithNestedId()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2",
                Fields =
                {
                    ["Nested"] = CreateMap(("Name", CreateValue("text")), ("Value", CreateValue(100))),
                    ["OuterName"] = CreateValue("Outer name")
                }
            };
            var document = DocumentSnapshot.ForDocument(db, proto, readTime);

            var converted = document.ConvertTo<SampleDataWithNestedDocumentId>();
            Assert.Equal("Outer name", converted.OuterName);
            Assert.Equal("text", converted.Nested.Name);
            Assert.Equal(100, converted.Nested.Value);
            Assert.Equal("doc2", converted.Nested.DocumentId);
        }

        [Fact]
        public void ConvertTo_WithTimestamps()
        {
            var snapshot = GetSampleSnapshot();
            var sample = snapshot.ConvertTo<SampleDataWithTimestamps>();
            Assert.Equal(snapshot.CreateTime, sample.CreateTimestamp);
            Assert.Equal(snapshot.UpdateTime, sample.UpdateTimestamp);
            Assert.Equal(snapshot.ReadTime, sample.ReadTimestamp);
        }

        private static DocumentSnapshot GetSampleSnapshot()
        {
            var poco = new SampleData
            {
                Name = "Test",
                Nested = new NestedData { Score = 20 }
            };
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc1/col2/doc2",
                Fields = { ValueSerializer.SerializeMap(SerializationContext.Default, poco) }
            };
            return DocumentSnapshot.ForDocument(db, proto, readTime);
        }

        [FirestoreData]
        private class SampleData
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public NestedData Nested { get; set; }

            [FirestoreProperty]
            public string NullField { get; set; }
        }

        [FirestoreData]
        private class NestedData
        {
            [FirestoreProperty]
            public int Score { get; set; }
        }

        [FirestoreData]
        private class SampleDataWithDocumentId
        {
            [FirestoreDocumentId]
            public string DocumentId { get; set; }

            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public int Value { get; set; }
        }

        [FirestoreData]
        private class SampleDataWithNestedDocumentId
        {
            [FirestoreProperty]
            public SampleDataWithDocumentId Nested { get; set; }

            [FirestoreProperty]
            public string OuterName { get; set; }
        }

        [FirestoreData]
        private class SampleDataWithTimestamps
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public NestedData Nested { get; set; }

            [FirestoreDocumentCreateTimestamp]
            public Timestamp CreateTimestamp { get; set; }

            [FirestoreDocumentUpdateTimestamp]
            public Timestamp UpdateTimestamp { get; set; }

            [FirestoreDocumentReadTimestamp]
            public Timestamp ReadTimestamp { get; set; }
        }
    }
}
