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
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class DocumentSetTest
    {
        private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

        [Fact]
        public void Empty()
        {
            var empty = DocumentSet.Empty(PathComparer.Instance);
            Assert.Empty(empty);
            Assert.Equal(0, empty.Count);

            var docRef = CreateSnapshot("col1/doc1").Reference;
            Assert.False(empty.Contains(docRef));
            Assert.Equal(-1, empty.IndexOf(docRef));
            Assert.False(empty.TryGetDocument(docRef, out var snapshot));
            Assert.Null(snapshot);
        }

        [Fact]
        public void WithDocumentAdded()
        {
            var doc1 = CreateSnapshot("col1/doc1");
            var doc2 = CreateSnapshot("col1/doc2");
            var doc3 = CreateSnapshot("col1/doc3");
            // First create a set with 2 documents (doc1 and doc3)
            var set2 = DocumentSet.Empty(PathComparer.Instance)
                .WithDocumentAdded(doc3)
                .WithDocumentAdded(doc1);

            // Examine the set in various ways
            Assert.Equal(2, set2.Count);
            Assert.Equal(new[] { doc1, doc3 }, set2.ToList());
            Assert.Equal(0, set2.IndexOf(doc1.Reference));
            Assert.Equal(1, set2.IndexOf(doc3.Reference));
            Assert.True(set2.TryGetDocument(doc1.Reference, out var result));
            Assert.Same(doc1, result);
            Assert.False(set2.TryGetDocument(doc2.Reference, out result));
            Assert.Null(result);
            Assert.True(set2.TryGetDocument(doc3.Reference, out result));
            Assert.Same(doc3, result);

            // Now add doc2, which should go between doc1 and doc3
            var set3 = set2.WithDocumentAdded(doc2);
            // This shouldn't have modified the existing set
            Assert.Equal(2, set2.Count);
            Assert.Equal(new[] { doc1, doc3 }, set2.ToList());

            // But the new set should have all three documents
            Assert.Equal(3, set3.Count);
            Assert.Equal(new[] { doc1, doc2, doc3 }, set3.ToList());
            Assert.Equal(0, set3.IndexOf(doc1.Reference));
            Assert.Equal(1, set3.IndexOf(doc2.Reference));
            Assert.Equal(2, set3.IndexOf(doc3.Reference));
            Assert.True(set3.TryGetDocument(doc1.Reference, out result));
            Assert.Same(doc1, result);
            Assert.True(set3.TryGetDocument(doc2.Reference, out result));
            Assert.Same(doc2, result);
            Assert.True(set3.TryGetDocument(doc3.Reference, out result));
            Assert.Same(doc3, result);

            // Adding an existing element shouldn't have any effect
            var set3Again = set3.WithDocumentAdded(doc1);
            Assert.Equal(3, set3Again.Count);
        }

        [Fact]
        public void WithDocumentRemoved()
        {
            var doc1 = CreateSnapshot("col1/doc1");
            var doc2 = CreateSnapshot("col1/doc2");
            var doc3 = CreateSnapshot("col1/doc3");
            // First create a set with 2 documents (doc1, doc2 and doc3)
            var set3 = DocumentSet.Empty(PathComparer.Instance)
                .WithDocumentAdded(doc1)
                .WithDocumentAdded(doc2)
                .WithDocumentAdded(doc3);

            // Now remove doc2
            var set2 = set3.WithDocumentRemoved(doc2.Reference);
            // This shouldn't have modified the existing set
            Assert.Equal(3, set3.Count);
            Assert.Equal(new[] { doc1, doc2, doc3 }, set3.ToList());

            // But the new set should only have two documents, still in order
            Assert.Equal(2, set2.Count);
            Assert.Equal(new[] { doc1, doc3 }, set2.ToList());
            Assert.Equal(0, set2.IndexOf(doc1.Reference));
            Assert.Equal(1, set2.IndexOf(doc3.Reference));
            Assert.True(set2.TryGetDocument(doc1.Reference, out var result));
            Assert.Same(doc1, result);
            Assert.False(set2.TryGetDocument(doc2.Reference, out result));
            Assert.Null(result);
            Assert.True(set2.TryGetDocument(doc3.Reference, out result));
            Assert.Same(doc3, result);

            // Trying to remove doc2 again should give the same reference back
            Assert.Same(set2, set2.WithDocumentRemoved(doc2.Reference));
        }

        [Fact]
        public void ValueBasedComparer()
        {
            var doc1 = CreateSnapshot("col1/doc1", 5);
            var doc2 = CreateSnapshot("col1/doc2", 3);
            var doc3 = CreateSnapshot("col1/doc3", 1);
            var doc4 = CreateSnapshot("col1/doc4", 6);
            // Just validate the documents are in the right order after adding in a different
            // order - that the field value is being used rather than just the path.
            // (In practice, the comparer we use will always use the path as part of the comparison.)
            var set = DocumentSet.Empty(FieldValueComparer.Instance)
                .WithDocumentAdded(doc1)
                .WithDocumentAdded(doc2)
                .WithDocumentAdded(doc3)
                .WithDocumentAdded(doc4);
            Assert.Equal(4, set.Count);
            Assert.Equal(new[] { doc3, doc2, doc1, doc4 }, set.ToList());
        }

        private DocumentSnapshot CreateSnapshot(string path, int value = 0)
        {
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = s_db.Document(path).Path,
                Fields = { { "field", CreateValue(value) } }
            };
            return DocumentSnapshot.ForDocument(s_db, proto, readTime);
        }

        private class PathComparer : IComparer<DocumentSnapshot>
        {
            public static IComparer<DocumentSnapshot> Instance { get; } = new PathComparer();

            public int Compare(DocumentSnapshot x, DocumentSnapshot y) => x.Reference.CompareTo(y.Reference);
        }

        private class FieldValueComparer : IComparer<DocumentSnapshot>
        {
            private static readonly FieldPath s_field = new FieldPath("field");

            public static IComparer<DocumentSnapshot> Instance { get; } = new FieldValueComparer();

            public int Compare(DocumentSnapshot x, DocumentSnapshot y) =>
                ValueComparer.Instance.Compare(x.ExtractValue(s_field), y.ExtractValue(s_field));
        }
    }
}
