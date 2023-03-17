// Copyright 2018, Google LLC
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

using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    /// Tests for Query.CreateDocumentSnapshotComparer
    /// </summary>
    public partial class QueryTest
    {
        [Fact]
        public void MissingDocumentSnapshotsAreRejected()
        {
            var query = s_db.Collection("col");
            var comparer = query.CreateDocumentSnapshotComparer();
            var doc = CreateSnapshot("doc", 1, 1);
            var missing = DocumentSnapshot.ForMissingDocument(s_db, s_db.Document("col/doc2").Path, new Timestamp(10, 2));
            Assert.Throws<ArgumentException>(() => comparer.Compare(doc, missing));
            Assert.Throws<ArgumentException>(() => comparer.Compare(missing, doc));
        }

        [Fact]
        public void DocumentsWithoutOrderedFieldsAreRejected()
        {
            var query = s_db.Collection("col").OrderBy("foo");
            var comparer = query.CreateDocumentSnapshotComparer();
            var doc1 = CreateSnapshot("doc1", 1, 1);
            var doc2 = CreateSnapshot("doc2", 1, 1);
            Assert.Throws<InvalidOperationException>(() => comparer.Compare(doc1, doc2));
        }

        [Fact]
        public void EmptyQuery_OrderByDocId()
        {
            var query = s_db.Collection("col");
            AssertDocsInOrder(query,
                CreateSnapshot("doc1", 10, 5),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc3", 3, 1),
                CreateSnapshot("doc4", 15, 15)
            );
        }

        [Fact]
        public void OrderByAscendingDocId()
        {
            var query = s_db.Collection("col").OrderBy(FieldPath.DocumentId);
            AssertDocsInOrder(query,
                CreateSnapshot("doc1", 10, 5),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc3", 3, 1),
                CreateSnapshot("doc4", 15, 15)
            );
        }

        [Fact]
        public void OrderByDescendingDocId()
        {
            var query = s_db.Collection("col").OrderByDescending(FieldPath.DocumentId);
            AssertDocsInOrder(query,
                CreateSnapshot("doc4", 15, 15),
                CreateSnapshot("doc3", 3, 1),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc1", 10, 5)
            );
        }

        [Fact]
        public void OrderByValue_AllUnique()
        {
            var query = s_db.Collection("col").OrderBy("value1");
            AssertDocsInOrder(query,
                CreateSnapshot("doc3", 3, 1),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc1", 10, 5),
                CreateSnapshot("doc4", 15, 15)
            );
        }

        [Fact]
        public void OrderByValueDescending_AllUnique()
        {
            var query = s_db.Collection("col").OrderByDescending("value1");
            AssertDocsInOrder(query,
                CreateSnapshot("doc4", 15, 15),
                CreateSnapshot("doc1", 10, 5),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc3", 3, 1)
            );
        }

        [Fact]
        public void OrderByValue_DocumentIdForTieBreak()
        {
            var query = s_db.Collection("col").OrderBy("value1");
            AssertDocsInOrder(query,
                CreateSnapshot("doc3", 3, 1),
                CreateSnapshot("doc1", 8, 5),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc4", 15, 15)
            );
        }

        [Fact]
        public void OrderByValueDescending_DocumentIdForTieBreak()
        {
            var query = s_db.Collection("col").OrderByDescending("value1");
            // Last ordering was descending, so doc2 comes before doc1.
            AssertDocsInOrder(query,
                CreateSnapshot("doc4", 15, 15),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc1", 8, 5),
                CreateSnapshot("doc3", 3, 1)
            );
        }

        [Fact]
        public void OrderByTwoValues()
        {
            var query = s_db.Collection("col").OrderBy("value1").OrderBy("value2");
            AssertDocsInOrder(query,
                CreateSnapshot("doc4", 3, 5),
                CreateSnapshot("doc1", 8, 5),
                CreateSnapshot("doc3", 8, 5),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc5", 15, 15)
            );
        }

        [Fact]
        public void OrderByTwoValues_SecondIsDescending()
        {
            var query = s_db.Collection("col").OrderBy("value1").OrderByDescending("value2");
            AssertDocsInOrder(query,
                CreateSnapshot("doc4", 3, 5),
                CreateSnapshot("doc2", 8, 9),
                CreateSnapshot("doc3", 8, 5),
                CreateSnapshot("doc1", 8, 5),
                CreateSnapshot("doc5", 15, 15)
            );
        }

        private static void AssertDocsInOrder(Query query, params DocumentSnapshot[] docs)
        {
            // Fixed seed for reproducibility.
            var rng = new Random(100);
            var comparer = query.CreateDocumentSnapshotComparer();
            // This is slightly simpler than getting all permutations. Randomness in tests isn't great, but
            // we'll almost certainly hit every permutation anyway, given the size we have.
            for (int i = 0; i < 50; i++)
            {
                var unordered = Shuffle(docs, rng).ToList();
                unordered.Sort(comparer);
                // Assert based on ID rather than content, for cleaner error reporting.
                Assert.Equal(docs.Select(doc => doc.Reference.Id), unordered.Select(doc => doc.Reference.Id));
            }
        }

        public static IEnumerable<T> Shuffle<T>(IEnumerable<T> source, Random rng)
        {
            T[] elements = source.ToArray();
            // Note i > 0 to avoid final pointless iteration
            for (int i = elements.Length - 1; i > 0; i--)
            {
                // Swap element "i" with a random earlier element it (or itself)
                int swapIndex = rng.Next(i + 1);
                T tmp = elements[i];
                elements[i] = elements[swapIndex];
                elements[swapIndex] = tmp;
            }
            // Lazily yield (avoiding aliasing issues etc)
            return elements;
        }

        private static DocumentSnapshot CreateSnapshot(string docId, int value1, int value2)
        {
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = s_db.Document($"col/{docId}").Path,
                Fields = { { "value1", CreateValue(value1) }, { "value2", CreateValue(value2) } }
            };
            return DocumentSnapshot.ForDocument(s_db, proto, readTime);
        }
    }
}
