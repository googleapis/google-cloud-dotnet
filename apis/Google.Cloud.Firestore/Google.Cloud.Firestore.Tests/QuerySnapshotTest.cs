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
    }
}
