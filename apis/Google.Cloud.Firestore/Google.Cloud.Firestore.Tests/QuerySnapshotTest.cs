// Copyright 2018 Google LLC
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

using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class QuerySnapshotTest
    {
        private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

        [Fact]
        public void ConvenienceMembers()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var query = db.Collection("col1");
            var readTime = new Timestamp(10, 2);
            var doc1 = DocumentSnapshot.ForMissingDocument(db, "projects/proj/databases/db/documents/col1/doc1", readTime);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = "projects/proj/databases/db/documents/col1/doc2"
            };
            var doc2 = DocumentSnapshot.ForDocument(db, proto, readTime);
            var docs = new[] { doc1, doc2 };

            var querySnapshot = new QuerySnapshot(query, docs, readTime);

            Assert.Equal(2, querySnapshot.Count);
            // Indexer
            Assert.Same(doc1, querySnapshot[0]);
            Assert.Same(doc2, querySnapshot[1]);
            Assert.Throws<ArgumentOutOfRangeException>(() => querySnapshot[-1]);
            Assert.Throws<ArgumentOutOfRangeException>(() => querySnapshot[2]);
            // Use IEnumerable<DocumentSnapshot>
            Assert.Equal(docs, querySnapshot);
            // OfType forces the use of non-generic IEnumerable
            Assert.Equal(docs, querySnapshot.OfType<DocumentSnapshot>());
        }

        [Fact]
        public void Equality()
        {
            var query = s_db.Collection("col1");
            var readTime = new Timestamp(10, 2);
            var doc1 = GetSampleSnapshot("doc1");
            var doc2 = GetSampleSnapshot("doc2");
            var doc3 = GetSampleSnapshot("doc3");

            var docs = new[] { doc1, doc2 };
            var control = new QuerySnapshot(query, docs, readTime);
            EqualityTester.AssertEqual(control,
                // Distinct but equal values for query and snapshots, but a different timestamp
                equal: new[] { new QuerySnapshot(s_db.Collection("col1"), new[] { GetSampleSnapshot("doc1"), doc2 }, new Timestamp(12, 13)) },
                unequal: new[] {
                    // Unequal query
                    new QuerySnapshot(query.Offset(0), docs, readTime),
                    // No doc2
                    new QuerySnapshot(query, new[] { doc1 }, readTime),
                    // Extra doc3
                    new QuerySnapshot(query, new[] { doc1, doc2, doc3 }, readTime),
                    // Order matters
                    new QuerySnapshot(query, new[] { doc2, doc1 }, readTime),
                });
        }

        private static DocumentSnapshot GetSampleSnapshot(string docId)
        {
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = $"projects/proj/databases/db/documents/col1/{docId}",
                Fields = { ValueSerializer.SerializeMap(new { Name = docId }) }
            };
            return DocumentSnapshot.ForDocument(s_db, proto, readTime);
        }

    }
}
