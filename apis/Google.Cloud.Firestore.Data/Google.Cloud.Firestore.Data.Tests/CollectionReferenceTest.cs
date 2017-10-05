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

namespace Google.Cloud.Firestore.Data.Tests
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

        [Fact]
        public void Document_Specified()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            var doc = collection.Document("doc");
            Assert.Equal(doc, db.Document("root/doc"));
        }

        [Fact]
        public void Document_Generated()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            var doc = collection.Document(null);
            Assert.Equal(collection, doc.Parent);
            // Can't guarantee what it is...
            Assert.Equal(20, doc.Id.Length);
            // But we shouldn't get the same one twice
            Assert.NotEqual(doc.Id, collection.Document(null).Id);
        }

        [Theory]
        [InlineData("")]
        [InlineData("a/b/c")]
        public void Document_Invalid(string id)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection("root");
            Assert.Throws<ArgumentException>(() => collection.Document(id));
        }
    }
}
