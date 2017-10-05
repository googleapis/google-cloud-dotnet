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
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Data.Tests
{
    public class FirestoreDbTest
    {
        [Fact]
        public void Create()
        {
            var client = new FakeFirestoreClient();
            var db = FirestoreDb.Create("proj", "db", client);
            Assert.Equal("projects/proj/databases/db", db.RootPath);
            Assert.Equal("projects/proj/databases/db/documents", db.DocumentsPath);
            Assert.Same(client, db.Client);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var client = new FakeFirestoreClient();
            var db = await FirestoreDb.CreateAsync("proj", "db", client);
            Assert.Equal("projects/proj/databases/db", db.RootPath);
            Assert.Equal("projects/proj/databases/db/documents", db.DocumentsPath);
            Assert.Same(client, db.Client);
        }

        [Fact]
        public void Document_Valid()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc2 = db.Document("col1/doc1/col2/doc2");
            var col2 = doc2.Parent;
            var doc1 = col2.Parent;
            var col1 = doc1.Parent;
            Assert.Null(col1.Parent);
            Assert.Equal("col1", col1.Id);
            Assert.Equal("doc1", doc1.Id);
            Assert.Equal("col2", col2.Id);
            Assert.Equal("doc2", doc2.Id);
            Assert.Equal("projects/proj/databases/db/documents/col1", col1.Path);
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1", doc1.Path);
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1/col2", col2.Path);
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1/col2/doc2", doc2.Path);
        }

        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("a/b/c")]
        [InlineData("a//b")]
        [InlineData("a/b/")]
        [InlineData("a/b//")]
        [InlineData("/a/b")]
        [InlineData("//a/b")]
        public void Document_Invalid(string path)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            Assert.Throws<ArgumentException>(() => db.Document(path));
        }

        [Fact]
        public void Collection()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var col2 = db.Collection("col1/doc1/col2");
            var doc1 = col2.Parent;
            var col1 = doc1.Parent;
            Assert.Null(col1.Parent);
            Assert.Equal("col1", col1.Id);
            Assert.Equal("doc1", doc1.Id);
            Assert.Equal("col2", col2.Id);
            Assert.Equal("projects/proj/databases/db/documents/col1", col1.Path);
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1", doc1.Path);
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1/col2", col2.Path);
        }

        [Theory]
        [InlineData("")]
        [InlineData("a/b")]
        [InlineData("a/b/c/d")]
        [InlineData("a//b/c")]
        [InlineData("a/")]
        [InlineData("a//")]
        [InlineData("/a")]
        [InlineData("//a")]
        public void Collection_Invalid(string path)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            Assert.Throws<ArgumentException>(() => db.Collection(path));
        }

        [Fact]
        public void GetDocumentReferenceFromResourcePath_Valid()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            string path = "projects/proj/databases/db/documents/col1/doc1/col2/doc2";
            var doc = db.GetDocumentReferenceFromResourceName(path);
            Assert.Equal(path, doc.Path);
        }

        [Theory]
        [InlineData("")]
        [InlineData("projects/other/databases/db/documents/col1/doc1")]
        [InlineData("projects/proj/databases/otherdb/documents/col1/doc1")]
        [InlineData("projects/other/databases/db/documents/col1/doc1/col2")]
        [InlineData("projects/other/databases/db/documents/col1")]
        [InlineData("projects/other/databases/db/documents/")]
        [InlineData("projects/other/databases/db/documents")]
        public void GetDocumentReferenceFromResourcePath_Invalid(string path)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            Assert.Throws<ArgumentException>(() => db.GetDocumentReferenceFromResourceName(path));
        }
    }
}
