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
using System;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class CollectionReferenceTest
    {
        [Fact]
        public void Equality()
        {
            var client = new FakeFirestoreClient();
            var db1 = FirestoreDb.Create("proj", "db", client);
            var db2 = FirestoreDb.Create("proj", "db", client);
            var db3 = FirestoreDb.Create("proj", "otherdb", client);

            var control = db1.Collection("col1/doc1/col2");
            var equal = new[]
            {
                db1.Collection("col1/doc1/col2"),
                db2.Collection("col1/doc1/col2"),
                db1.Collection("col1").Document("doc1").Collection("col2")
            };
            var unequal = new[]
            {
                db1.Collection("col1x/doc1/col2"),
                db1.Collection("col1/doc1x/col2"),
                db1.Collection("col1/doc1/col2x"),
                db3.Collection("col1/doc1/col2"),
                db1.Collection("col1"),
                db1.Collection("col2"),
            };
            EqualityTester.AssertEqual(control, equal, unequal);
        }

        [Fact]
        public void Formatting()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("col1/doc1/col2");
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1/col2", collection.ToString());
        }

        [Fact]
        public void Properties()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("col1/doc1/col2");
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1/col2", collection.Path);
            Assert.Equal("col2", collection.Id);
            Assert.Same(db, collection.Database);
            Assert.Equal(db.Document("col1/doc1"), collection.Parent);
        }

        [Fact]
        public void RootCollection()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            Assert.Equal("projects/proj/databases/db/documents/root", collection.Path);
            Assert.Null(collection.Parent);
        }

        [Theory]
        [InlineData("col1", "doc1", "col1/doc1")]
        [InlineData("col1/doc1/col2", "doc2", "col1/doc1/col2/doc2")]
        [InlineData("col1", "doc1/col2/doc2", "col1/doc1/col2/doc2")]
        [InlineData("col1/doc1/col2", "doc2/col3/doc3", "col1/doc1/col2/doc2/col3/doc3")]
        public void Document_Valid(string collectionPath, string relativePath, string expectedAbsolutePath)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection(collectionPath);
            var doc = collection.Document(relativePath);
            Assert.Equal(db.Document(expectedAbsolutePath), doc);
        }

        [Fact]
        public void Document_Null()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            Assert.Throws<ArgumentNullException>(() => collection.Document(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData("a/b")]
        [InlineData("a//b")]
        [InlineData("a//b/c")]
        public void Document_Invalid(string id)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            Assert.Throws<ArgumentException>(() => collection.Document(id));
        }

        [Fact]
        public void Document_GeneratedId()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            var doc = collection.Document();
            Assert.Equal(collection, doc.Parent);
            // Can't guarantee what it is...
            Assert.Equal(20, doc.Id.Length);
            // But we shouldn't get the same one twice
            Assert.NotEqual(doc.Id, collection.Document().Id);
        }

        [Theory]
        // Vary one property at a time
        [InlineData("p1", "d1", "col1/doc1/col3", "p2", "d1", "col1/doc1/col3")]
        [InlineData("p1", "d1", "col1/doc1/col3", "p1", "d2", "col1/doc1/col3")]
        [InlineData("p1", "d1", "col1/doc1/col3", "p1", "d1", "col2/doc1/col3")]
        [InlineData("p1", "d1", "col1/doc1/col3", "p1", "d1", "col1/doc2/col3")]

        // Precedence of properties
        [InlineData("p1", "d2", "col1/doc1/col3", "p2", "d1", "col1/doc1/col3")] // Project before database
        [InlineData("p1", "d1", "col9/doc9/col3", "p1", "d2", "col1/doc1/col3")] // Database before path
        [InlineData("p1", "d1", "col1/doc2/col3", "p1", "d1", "col2/doc1/col3")] // Collection before document
        // (More details path tests in PathComparerTest)
        public void CompareTo(
            string smallerProject, string smallerDb, string smallerPath,
            string largerProject, string largerDb, string largerPath)
        {
            var client = new FakeFirestoreClient();
            var smaller = FirestoreDb.Create(smallerProject, smallerDb, client).Collection(smallerPath);
            var larger = FirestoreDb.Create(largerProject, largerDb, client).Collection(largerPath);
            ComparisonTester.AssertComparison(smaller, larger);
        }

        [Fact]
        public void CompareTo_Null()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            ComparisonTester.AssertComparison(null, collection);
        }
    }
}
