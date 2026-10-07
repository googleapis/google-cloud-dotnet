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

using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1.FirestoreClient;

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

        [Theory]
        [MemberData(nameof(SnapshotActions))]
        public async Task SnapshotMethods_InFlightCancellation_CancelsPendingRead(Func<Transaction, CancellationToken, Task> executeRead)
        {
            // Set up a transaction with a pending read operation.
            using var callerCts = new CancellationTokenSource();
            var db = FirestoreDb.Create("proj", "db", new PendingReadClient());
            var transaction = await Transaction.BeginAsync(db, null, default);
            var readTask = executeRead(transaction, callerCts.Token);

            // Cancel the caller token while the read is in flight.
            callerCts.Cancel();

            // Verify the pending read observes cancellation and throws.
            // Timeout guards against hanging if cancellation fails to propagate.
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => readTask.WaitAsync(TimeSpan.FromSeconds(5)));
        }

        public static TheoryData<Func<Transaction, CancellationToken, Task>> SnapshotActions => new()
        {
            (tx, token) => tx.GetSnapshotAsync(tx.Database.Document("col/doc"), token),
            (tx, token) => tx.GetAllSnapshotsAsync(new[] { tx.Database.Document("col/doc") }, null, token),
            (tx, token) => tx.GetSnapshotAsync(tx.Database.Collection("col"), token),
            (tx, token) => tx.GetSnapshotAsync(tx.Database.Collection("col").Count(), token),
        };

        /// <summary>
        /// A testing client that keeps read operations in flight until cancelled via CallSettings.
        /// </summary>
        private class PendingReadClient : TransactionTestingClient
        {
            // Override read RPCs to return streams that remain pending until cancelled.
            public override BatchGetDocumentsStream BatchGetDocuments(BatchGetDocumentsRequest req, CallSettings s = null) => new DocStream(s);
            public override RunQueryStream RunQuery(RunQueryRequest req, CallSettings s = null) => new QueryStream(s);
            public override RunAggregationQueryStream RunAggregationQuery(RunAggregationQueryRequest req, CallSettings s = null) => new AggStream(s);

            private class DocStream(CallSettings s) : BatchGetDocumentsStream
            {
                public override AsyncServerStreamingCall<BatchGetDocumentsResponse> GrpcCall { get; } = CreateCall<BatchGetDocumentsResponse>(s);
            }

            private class QueryStream(CallSettings s) : RunQueryStream
            {
                public override AsyncServerStreamingCall<RunQueryResponse> GrpcCall { get; } = CreateCall<RunQueryResponse>(s);
            }

            private class AggStream(CallSettings s) : RunAggregationQueryStream
            {
                public override AsyncServerStreamingCall<RunAggregationQueryResponse> GrpcCall { get; } = CreateCall<RunAggregationQueryResponse>(s);
            }

            // Creates a stream that stays pending until the CallSettings cancellation token is cancelled.
            private static AsyncServerStreamingCall<T> CreateCall<T>(CallSettings s)
            {
                var token = s?.CancellationToken ?? default;
                var tcs = new TaskCompletionSource<bool>();
                token.Register(() => tcs.TrySetCanceled(token));
                return new(new PendingReader<T>(tcs.Task), null, null, null, () => { });
            }

            // Stream reader whose MoveNext hangs on the uncompleted task until cancellation occurs.
            private class PendingReader<T>(Task<bool> task) : IAsyncStreamReader<T>
            {
                public T Current => default;
                public Task<bool> MoveNext(CancellationToken cancellationToken) => task;
            }
        }

        private FirestoreDb CreateFirestoreDbExpectingNoCommits() =>
            FirestoreDb.Create("proj", "db", new TransactionTestingClient(int.MaxValue, new NotSupportedException()));
    }
}
