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

using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class TransactionTest
    {
        [Fact]
        public async Task BeginTransaction_Properties()
        {
            var cancellationToken = new CancellationTokenSource().Token;
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, cancellationToken);
            Assert.Equal("transaction 1", transaction.TransactionId.ToStringUtf8());
            Assert.Equal(cancellationToken, transaction.CancellationToken);
            Assert.Same(db, transaction.Database);
        }

        [Fact]
        public async Task NoCommitsBeforeCommitCall()
        {
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, default);
            Assert.Equal("transaction 1", transaction.TransactionId.ToStringUtf8());

            var doc = db.Document("col/doc");
            var snapshot = await transaction.GetSnapshotAsync(doc);
            Assert.Equal("transaction 1", snapshot.GetValue<string>("transaction"));
            var query = await transaction.GetSnapshotAsync(db.Collection("col"));
            Assert.Empty(query.Documents);

            transaction.Create(doc, new { Name = "Test" });
            transaction.Update(doc, new Dictionary<FieldPath, object> { { new FieldPath("Name"), "Test2" } });
            transaction.Set(doc, new { Name = "Test3" });
            transaction.Delete(doc);
        }

        [Fact]
        public async Task GetSnapshotAsync_FailsAfterWrite()
        {
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, default);
            var doc = db.Document("col/doc");
            transaction.Delete(doc);
            await Assert.ThrowsAsync<InvalidOperationException>(() => transaction.GetSnapshotAsync(doc));
        }

        [Fact]
        public async Task GetAllSnapshotsAsync_FailsAfterWrite()
        {
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, default);
            var doc1 = db.Document("col/doc1");
            var doc2 = db.Document("col/doc2");
            transaction.Delete(doc1);
            await Assert.ThrowsAsync<InvalidOperationException>(() => transaction.GetAllSnapshotsAsync(new[] { doc1, doc2 }));
        }

        [Fact]
        public async Task GetSnaphotAsync_FailsAfterWrite()
        {
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, default);
            var doc = db.Document("col/doc");
            transaction.Delete(doc);
            await Assert.ThrowsAsync<InvalidOperationException>(() => transaction.GetSnapshotAsync(doc.Parent));
        }

        [Fact]
        public async Task GetSnaphsotAsync_AggregationQuery()
        {
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, default);
            var query = db.Collection("col");
            var aggQuery = query.Count();
            var snapshot = await transaction.GetSnapshotAsync(aggQuery);
            Assert.Equal(aggQuery, snapshot.Query);
            Assert.NotNull(snapshot);
        }

        [Fact]
        public async Task GetSnaphotAsync_FailAfterWriteForAggregationQuery()
        {
            var db = CreateFirestoreDbExpectingNoCommits();
            var transaction = await Transaction.BeginAsync(db, null, default);
            var doc = db.Document("col/doc");
            transaction.Delete(doc);
            await Assert.ThrowsAsync<InvalidOperationException>(() => transaction.GetSnapshotAsync(doc.Parent));
        }

        [Fact]
        public async Task CommitAsync()
        {
            var client = new TransactionTestingClient();
            var db = FirestoreDb.Create("proj", "db", client);
            var transaction = await Transaction.BeginAsync(db, null, default);
            var doc = db.Document("col/doc");
            // A simple write of each kind, just to check they're all passed along as expected.
            transaction.Create(doc, new { Name = "Test" });
            transaction.Update(doc, new Dictionary<FieldPath, object> { { new FieldPath("Name"), "Test2" } });
            transaction.Set(doc, new { Name = "Test3" });
            transaction.Delete(doc);
            await transaction.CommitAsync();

            var expectedRequest = new CommitRequest
            {
                Database = "projects/proj/databases/db",                
                Transaction = ByteString.CopyFromUtf8("transaction 1"),
                Writes =
                {
                    // Create
                    new Write
                    {
                        CurrentDocument = new V1.Precondition { Exists = false },
                        Update = new Document
                        {
                            Name = doc.Path,
                            Fields = { { "Name", CreateValue("Test") } }
                        }
                    },
                    // Update
                    new Write
                    {
                        CurrentDocument = new V1.Precondition { Exists = true },
                        Update = new Document
                        {
                            Name = doc.Path,
                            Fields = { { "Name", CreateValue("Test2") } }
                        },
                        UpdateMask = new DocumentMask { FieldPaths = { "Name" } }
                    },
                    // Set
                    new Write
                    {
                        Update = new Document
                        {
                            Name = doc.Path,
                            Fields = { { "Name", CreateValue("Test3") } }
                        },
                    },
                    // Delete
                    new Write { Delete = doc.Path }
                }
            };
            Assert.Equal(new[] { expectedRequest }, client.CommitRequests);
            Assert.Empty(client.RollbackRequests);
        }

        [Fact]
        public async Task RollbackAsync()
        {
            var client = new TransactionTestingClient();
            var db = FirestoreDb.Create("proj", "db", client);
            var transaction = await Transaction.BeginAsync(db, null, default);
            await transaction.RollbackAsync();
            var expectedRequest = new RollbackRequest
            {
                Database = "projects/proj/databases/db",
                Transaction = ByteString.CopyFromUtf8("transaction 1")
            };
            Assert.Empty(client.CommitRequests);
            Assert.Equal(new[] { expectedRequest }, client.RollbackRequests);
        }

        private FirestoreDb CreateFirestoreDbExpectingNoCommits() =>
            FirestoreDb.Create("proj", "db", new TransactionTestingClient(int.MaxValue, new NotSupportedException()));
    }
}
