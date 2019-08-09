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

using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.V1;
using System;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;
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

            var querySnapshot = QuerySnapshot.ForDocuments(query, docs, readTime);

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
            var doc1 = GetSampleSnapshot(s_db, "doc1");
            var doc2 = GetSampleSnapshot(s_db, "doc2");
            var doc3 = GetSampleSnapshot(s_db, "doc3");

            var docs = new[] { doc1, doc2 };
            var control = QuerySnapshot.ForDocuments(query, docs, readTime);
            EqualityTester.AssertEqual(control,
                // Distinct but equal values for query and snapshots, but a different timestamp
                equal: new[] { QuerySnapshot.ForDocuments(s_db.Collection("col1"), new[] { GetSampleSnapshot(s_db, "doc1"), doc2 }, new Timestamp(12, 13)) },
                unequal: new[] {
                    // Unequal query
                    QuerySnapshot.ForDocuments(query.Offset(0), docs, readTime),
                    // No doc2
                    QuerySnapshot.ForDocuments(query, new[] { doc1 }, readTime),
                    // Extra doc3
                    QuerySnapshot.ForDocuments(query, new[] { doc1, doc2, doc3 }, readTime),
                    // Order matters
                    QuerySnapshot.ForDocuments(query, new[] { doc2, doc1 }, readTime),
                });

            // Note: no test for the changes being compared. It would be overkill at the moment.
        }

        [Fact]
        public void GeneratedChanges()
        {
            var query = s_db.Collection("col1");
            var readTime = new Timestamp(10, 2);
            var doc1 = GetSampleSnapshot(s_db, "doc1");
            var doc2 = GetSampleSnapshot(s_db, "doc2");
            var snapshot = QuerySnapshot.ForDocuments(query, new[] { doc1, doc2 }, readTime);

            Assert.Equal(new DocumentChange(doc1, DocumentChange.Type.Added, null, 0), snapshot.Changes[0]);
            Assert.Equal(new DocumentChange(doc2, DocumentChange.Type.Added, null, 1), snapshot.Changes[1]);
        }

        [Fact]
        public void SnapshotFromChanges()
        {
            var query = s_db.Collection("col1");
            var readTime = new Timestamp(10, 2);
            var doc1 = GetSampleSnapshot(s_db, "doc1");
            var doc2 = GetSampleSnapshot(s_db, "doc2");
            var documentSet = DocumentSet.Empty(query.CreateDocumentSnapshotComparer())
                .WithDocumentAdded(doc1)
                .WithDocumentAdded(doc2);
            var changes = new[] { new DocumentChange(doc2, DocumentChange.Type.Added, null, 1) };

            // It's fine for the list to be a different length; the document set is *all* the
            // documents, whereas changes is just the delta from the previous snapshot.
            var snapshot = QuerySnapshot.ForChanges(query, documentSet, changes, readTime);

            Assert.Equal(changes, snapshot.Changes);
            Assert.Equal(new[] { doc1, doc2 }, snapshot.Documents);
            Assert.Equal(new[] { doc1, doc2 }, snapshot.ToList());
        }
    }
}
