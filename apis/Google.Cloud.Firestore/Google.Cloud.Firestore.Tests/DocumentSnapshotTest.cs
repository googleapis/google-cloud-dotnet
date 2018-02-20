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

using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Collections.Generic;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

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
        public void ConvertTo()
        {
            var doc = GetSampleSnapshot();
            var sample = doc.ConvertTo<SampleData>();
            Assert.Equal("Test", sample.Name);
            Assert.Equal(20, sample.Nested.Score);
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
                Fields = { ValueSerializer.SerializeMap(poco) }
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
    }
}
