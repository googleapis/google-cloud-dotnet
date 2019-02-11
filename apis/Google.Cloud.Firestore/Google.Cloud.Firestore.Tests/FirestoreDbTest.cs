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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using Grpc.Core;
using Moq;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public partial class FirestoreDbTest
    {
        [Fact]
        public void Create_WithDatabase()
        {
            var client = new FakeFirestoreClient();
            var db = FirestoreDb.Create("proj", "db", client);
            Assert.Equal("projects/proj/databases/db", db.RootPath);
            Assert.Equal("projects/proj/databases/db/documents", db.DocumentsPath);
            Assert.Same(client, db.Client);
        }

        [Fact]
        public void Create_PublicMethodUsesDefaultDatabase()
        {
            var client = new FakeFirestoreClient();
            var db = FirestoreDb.Create("proj", client);
            Assert.Equal("projects/proj/databases/(default)", db.RootPath);
            Assert.Equal("projects/proj/databases/(default)/documents", db.DocumentsPath);
            Assert.Same(client, db.Client);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var client = new FakeFirestoreClient();
            var db = await FirestoreDb.CreateAsync("proj", client);
            Assert.Equal("projects/proj/databases/(default)", db.RootPath);
            Assert.Equal("projects/proj/databases/(default)/documents", db.DocumentsPath);
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

        // Use the overload accepting a transaction for this test
        [Fact]
        public async Task GetAllSnapshotsAsync()
        {
            string docName1 = "projects/proj/databases/db/documents/col1/doc1";
            string docName2 = "projects/proj/databases/db/documents/col2/doc2";
            ByteString transaction = ByteString.CopyFromUtf8("abc");
            var mock = CreateMockClient();
            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                // Note that we request docName2 twice, as per the caller's request:
                // the library doesn't perform any elision.
                Documents = { docName1, docName2, docName2 },
                Transaction = transaction
            };
            var responses = new[]
            {
                // Deliberately not in the requested order
                new BatchGetDocumentsResponse
                {
                    Found = new Document
                    {
                        Name = docName2, CreateTime = CreateProtoTimestamp(0, 1), UpdateTime = CreateProtoTimestamp(0, 2),
                        Fields = { { "Name", CreateValue("Test") } }
                    },
                    ReadTime = CreateProtoTimestamp(1, 3)
                },
                new BatchGetDocumentsResponse { Missing = docName1, ReadTime = CreateProtoTimestamp(1, 2) },
            };
            mock.Setup(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>())).Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var docRef1 = db.Document("col1/doc1");
            var docRef2 = db.Document("col2/doc2");
            var results = await db.GetAllSnapshotsAsync(new[] { docRef1, docRef2, docRef2 }, transaction, fieldMask: null, default);

            Assert.Equal(3, results.Count);
            // Note that this is the first result from the request, not the first from the response -
            // the method returns them in request order, not response order.
            var snapshot1 = results[0];
            Assert.False(snapshot1.Exists);
            Assert.Equal(new Timestamp(1, 2), snapshot1.ReadTime);
            Assert.Equal(docRef1, snapshot1.Reference);

            var snapshot2 = results[1];
            Assert.True(snapshot2.Exists);
            Assert.Equal(new Timestamp(0, 1), snapshot2.CreateTime);
            Assert.Equal(new Timestamp(0, 2), snapshot2.UpdateTime);
            Assert.Equal(new Timestamp(1, 3), snapshot2.ReadTime);
            Assert.Equal(docRef2, snapshot2.Reference);
            Assert.Equal("Test", snapshot2.GetValue<string>("Name"));

            // The third result element is just a reference to the same snapshot.
            Assert.Same(results[1], results[2]);
        }

        // Use the overload that doesn't accept a transaction for this test, just for coverage
        [Fact]
        public async Task GetAllSnapshotsAsync_ServerError()
        {
            string docName1 = "projects/proj/databases/db/documents/col1/doc1";
            string docName2 = "projects/proj/databases/db/documents/col2/doc2";
            var mock = CreateMockClient();
            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                Documents = { docName1, docName2 }
            };
            // The server only returns information about docName1, not docName2
            var responses = new[]
            {
                new BatchGetDocumentsResponse { Missing = docName1, ReadTime = CreateProtoTimestamp(1, 2) },
            };
            mock.Setup(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>())).Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var docRef1 = db.Document("col1/doc1");
            var docRef2 = db.Document("col2/doc2");

            await Assert.ThrowsAsync<InvalidOperationException>(async () => await db.GetAllSnapshotsAsync(new[] { docRef1, docRef2 }));
        }

        [Fact]
        public async Task GetDocumentSnapshotsAsync()
        {
            string docName1 = "projects/proj/databases/db/documents/col1/doc1";
            string docName2 = "projects/proj/databases/db/documents/col2/doc2";
            var mock = CreateMockClient();
            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                Documents = { docName1, docName2 }
            };
            var responses = new[]
            {
                // Deliberately not in the requested order
                new BatchGetDocumentsResponse
                {
                    Found = new Document
                    {
                        Name = docName2, CreateTime = CreateProtoTimestamp(0, 1), UpdateTime = CreateProtoTimestamp(0, 2),
                        Fields = { { "Name", CreateValue("Test") } }
                    },
                    ReadTime = CreateProtoTimestamp(1, 3)
                },
                new BatchGetDocumentsResponse { Missing = docName1, ReadTime = CreateProtoTimestamp(1, 2) },
            };
            mock.Setup(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>())).Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var docRef1 = db.Document("col1/doc1");
            var docRef2 = db.Document("col2/doc2");
            var results = await db.GetDocumentSnapshotsAsync(new[] { docRef1, docRef2 }, transactionId: null, fieldMask: null, default);
            Assert.Equal(2, results.Count);
            // Note that this is the second result, not the first - we get them back in response order, not request order.
            // (If we need to ensure request order, that can be done as a separate method layered on this one.)
            var snapshot1 = results[1];
            Assert.False(snapshot1.Exists);
            Assert.Equal(new Timestamp(1, 2), snapshot1.ReadTime);
            Assert.Equal(docRef1, snapshot1.Reference);

            var snapshot2 = results[0];
            Assert.True(snapshot2.Exists);
            Assert.Equal(new Timestamp(0, 1), snapshot2.CreateTime);
            Assert.Equal(new Timestamp(0, 2), snapshot2.UpdateTime);
            Assert.Equal(new Timestamp(1, 3), snapshot2.ReadTime);
            Assert.Equal(docRef2, snapshot2.Reference);
            Assert.Equal("Test", snapshot2.GetValue<string>("Name"));
        }

        [Fact]
        public async Task GetDocumentSnapshotsAsync_WithTransaction()
        {
            // This test is about checking the transaction is copied...
            var transactionId = ByteString.CopyFrom(1, 2, 3, 4);
            string docName = "projects/proj/databases/db/documents/col1/doc1";
            var mock = CreateMockClient();
            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                Documents = { docName },
                Transaction = transactionId
            };
            var responses = new[]
            {
                new BatchGetDocumentsResponse { Missing = docName, ReadTime = CreateProtoTimestamp(1, 2) },
            };
            mock.Setup(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>())).Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var results = await db.GetDocumentSnapshotsAsync(new[] { db.Document("col1/doc1") }, transactionId, fieldMask: null, default);
        }

        [Fact]
        public async Task GetDocumentSnapshotsAsync_WithFieldMask()
        {
            string docName = "projects/proj/databases/db/documents/col1/doc1";
            var mock = CreateMockClient();
            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                Documents = { docName },
                Mask = new DocumentMask { FieldPaths = { "a", "b" } }
            };
            var responses = new[]
            {
                new BatchGetDocumentsResponse { Missing = docName, ReadTime = CreateProtoTimestamp(1, 2) },
            };
            mock.Setup(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>())).Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var fieldMask = new FieldMask("a", "b");
            var results = await db.GetDocumentSnapshotsAsync(new[] { db.Document("col1/doc1") }, transactionId: null, fieldMask, default);
        }

        [Fact]
        public async Task GetDocumentSnapshotsAsync_UnknownResponseCase()
        {
            string docName = "projects/proj/databases/db/documents/col1/doc1";
            var mock = CreateMockClient();
            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                Documents = { docName },
            };
            var responses = new[] { new BatchGetDocumentsResponse { ReadTime = CreateProtoTimestamp(1, 2) } };
            mock.Setup(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>())).Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            await Assert.ThrowsAsync<InvalidOperationException>(() => db.GetDocumentSnapshotsAsync(new[] { db.Document("col1/doc1") }, transactionId: null, fieldMask: null, default));
        }

        [Fact]
        public async Task GetDocumentSnapshotsAsync_Retry()
        {
            string docName = "projects/proj/databases/db/documents/col1/doc1";
            var mock = CreateMockClient();
            mock.Object.Settings.Clock = new FakeClock();
            mock.Object.Settings.Scheduler = new NoOpScheduler();

            var request = new BatchGetDocumentsRequest
            {
                Database = "projects/proj/databases/db",
                Documents = { docName }
            };

            var responses = new[]
            {
                new BatchGetDocumentsResponse { Missing = docName, ReadTime = CreateProtoTimestamp(1, 2) },
            };
            var errorResponses = responses.Where(r => throw new RpcException(new Status(StatusCode.Unavailable, "Bang")));
            mock.SetupSequence(c => c.BatchGetDocuments(request, It.IsAny<CallSettings>()))
                .Returns(new FakeDocumentStream(errorResponses))
                .Returns(new FakeDocumentStream(errorResponses))
                .Returns(new FakeDocumentStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var docRef = db.Document("col1/doc1");
            var results = await db.GetDocumentSnapshotsAsync(new[] { docRef }, transactionId: null, fieldMask: null, default);
            Assert.Equal(1, results.Count);
        }

        [Fact]
        public void WithWarningLogger()
        {
            var originalDb = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var loggingDb = originalDb.WithWarningLogger(message => { });
            Assert.Equal(originalDb.ProjectId, loggingDb.ProjectId);
            Assert.Equal(originalDb.DatabaseId, loggingDb.DatabaseId);
            Assert.Same(originalDb.Client, loggingDb.Client);
        }

        [Fact]
        public void LogWarning_NoLogger()
        {
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            db.LogWarning("Message");
        }

        [Fact]
        public void LogWarning_WithLogger()
        {
            string result = null;
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient()).WithWarningLogger(message => result = message);
            db.LogWarning("Message");
            Assert.Equal("Message", result);
        }

        private static Mock<FirestoreClient> CreateMockClient()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            mock.SetupProperty(c => c.Settings, FirestoreSettings.GetDefault());
            return mock;
        }
    }
}
