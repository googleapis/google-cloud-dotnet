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

using System;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class DocumentReferenceTest
    {
        [Fact]
        public void Equality()
        {
            var client = new FakeFirestoreClient();
            var db1 = FirestoreDb.Create("proj", "db", client);
            var db2 = FirestoreDb.Create("proj", "db", client);
            var db3 = FirestoreDb.Create("proj", "otherdb", client);

            var control = db1.Document("col1/doc1/col2/doc2");
            var equal = new[]
            {                
                db1.Document("col1/doc1/col2/doc2"),
                db2.Document("col1/doc1/col2/doc2"),
                db1.Collection("col1").Document("doc1").Collection("col2").Document("doc2")
            };
            var unequal = new[]
            {
                db1.Document("col1x/doc1/col2/doc2"),
                db1.Document("col1/doc1x/col2/doc2"),
                db1.Document("col1/doc1/col2x/doc2"),
                db1.Document("col1/doc1/col2/doc2x"),
                db3.Document("col1/doc1/col2/doc2"),
                db1.Document("col1/doc1"),
                db1.Document("col2/doc2"),
            };
            EqualityTester.AssertEqual(control, equal, unequal);
        }

        [Fact]
        public void Formatting()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("col1/doc1");
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1", doc.ToString());
        }

        [Fact]
        public void Properties()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("col1/doc1");
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1", doc.Path);
            Assert.Equal("doc1", doc.Id);
            Assert.Same(db, doc.Database);
            Assert.Equal(db.Collection("col1"), doc.Parent);
        }

        [Theory]
        [InlineData("col1/doc1", "col2", "col1/doc1/col2")]
        [InlineData("col1/doc1/col2/doc2", "col3", "col1/doc1/col2/doc2/col3")]
        [InlineData("col1/doc1", "col2/doc2/col3", "col1/doc1/col2/doc2/col3")]
        [InlineData("col1/doc1/col2/doc2", "col3/doc3/col4", "col1/doc1/col2/doc2/col3/doc3/col4")]
        public void Collection_Valid(string documentPath, string relativePath, string expectedAbsolutePath)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var document = db.Document(documentPath);
            var coll = document.Collection(relativePath);
            Assert.Equal(db.Collection(expectedAbsolutePath), coll);
        }

        [Fact]
        public void Collection_Specified()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("root/doc");
            var collection = doc.Collection("col");
            Assert.Equal(collection, db.Collection("root/doc/col"));
        }

        [Fact]
        public void Collection_Null()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("root/doc");
            Assert.Throws<ArgumentNullException>(() => doc.Collection(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData("a/b")]
        [InlineData("a//b")]
        [InlineData("a//b/c")]
        public void Collection_Invalid(string id)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var document = db.Document("root/doc");
            Assert.Throws<ArgumentException>(() => document.Collection(id));
        }

        [Theory]
        // Vary one property at a time
        [InlineData("p1", "d1", "col1/doc1", "p2", "d1", "col1/doc1")]
        [InlineData("p1", "d1", "col1/doc1", "p1", "d2", "col1/doc1")]
        [InlineData("p1", "d1", "col1/doc1", "p1", "d1", "col2/doc1")]
        [InlineData("p1", "d1", "col1/doc1", "p1", "d1", "col1/doc2")]

        // Precedence of properties
        [InlineData("p1", "d2", "col1/doc1", "p2", "d1", "col1/doc1")] // Project before database
        [InlineData("p1", "d1", "col9/doc9", "p1", "d2", "col1/doc1")] // Database before path
        [InlineData("p1", "d1", "col1/doc2", "p1", "d1", "col2/doc1")] // Collection before document
        // (More details path tests in PathComparerTest)
        public void CompareTo(
            string smallerProject, string smallerDb, string smallerPath,
            string largerProject, string largerDb, string largerPath)
        {
            var client = new FakeFirestoreClient();
            var smaller = FirestoreDb.Create(smallerProject, smallerDb, client).Document(smallerPath);
            var larger = FirestoreDb.Create(largerProject, largerDb, client).Document(largerPath);
            ComparisonTester.AssertComparison(smaller, larger);
        }

        [Fact]
        public void CompareTo_Null()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var document = db.Document("root/doc");
            ComparisonTester.AssertComparison(null, document);
        }
    }
}
