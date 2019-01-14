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
using Grpc.Core;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public partial class FirestoreDbTest
    {
        // Just check the basics of each overload...
        [Fact]
        public async Task RunTransactionAsync_CommitSuccess_NoResult()
        {
            var client = new TransactionTestingClient();
            var db = FirestoreDb.Create("proj", "db", client);
            await db.RunTransactionAsync(async transaction =>
            {
                await transaction.GetSnapshotAsync(db.Document("col/x"));
                transaction.Create(db.Document("col/doc1"), new { Name = "Test" });
                transaction.Delete(db.Document("col/doc2"));
            });
            Assert.Equal(new[] { CreateCommitRequest("transaction 1") }, client.CommitRequests);
            Assert.Empty(client.RollbackRequests);
        }

        [Fact]
        public async Task RunTransactionAsync_CommitSuccess_WithResult()
        {
            var client = new TransactionTestingClient();
            var db = FirestoreDb.Create("proj", "db", client);
            var result = await db.RunTransactionAsync(CreateCountingCallback());
            Assert.Equal(1, result);
            Assert.Equal(new[] { CreateCommitRequest("transaction 1") }, client.CommitRequests);
            Assert.Empty(client.RollbackRequests);
        }

        // In-depth testing is only performed for the main work method
        [Fact]
        public async Task RunTransactionAsync_RollbackAndRetry()
        {
            var client = new TransactionTestingClient(2, CreateRpcException(StatusCode.Aborted));
            var db = FirestoreDb.Create("proj", "db", client);
            var result = await db.RunTransactionAsync(CreateCountingCallback());
            // Two failures were retries, so our callback executed 3 times.
            Assert.Equal(3, result);

            var expectedCommitRequests = new[]
            {
                CreateCommitRequest("transaction 1"),
                CreateCommitRequest("transaction 2; retrying transaction 1"),
                CreateCommitRequest("transaction 3; retrying transaction 2")
            };
            var expectedRollbackRequests = new[]
            {
                CreateRollbackRequest("transaction 1"),
                CreateRollbackRequest("transaction 2; retrying transaction 1"),
            };
            Assert.Equal(expectedCommitRequests, client.CommitRequests);
            Assert.Equal(expectedRollbackRequests, client.RollbackRequests);
        }

        [Theory]
        [InlineData(StatusCode.DeadlineExceeded)]
        [InlineData(StatusCode.Cancelled)]
        public async Task RunTransactionAsync_RollbackNoRetryOnCommitFailure(StatusCode code)
        {
            var client = new TransactionTestingClient(1, CreateRpcException(code));
            var db = FirestoreDb.Create("proj", "db", client);
            await Assert.ThrowsAsync<RpcException>(() => db.RunTransactionAsync(CreateCountingCallback()));
            Assert.Equal(new[] { CreateCommitRequest("transaction 1") }, client.CommitRequests);
            Assert.Equal(new[] { CreateRollbackRequest("transaction 1") }, client.RollbackRequests);
        }

        [Theory]
        [InlineData(StatusCode.FailedPrecondition)]
        [InlineData(StatusCode.Internal)]
        [InlineData(StatusCode.PermissionDenied)]
        public async Task RunTransactionAsync_NoRollbackOnCommitFailure(StatusCode code)
        {
            var client = new TransactionTestingClient(1, CreateRpcException(code));
            var db = FirestoreDb.Create("proj", "db", client);
            await Assert.ThrowsAsync<RpcException>(() => db.RunTransactionAsync(CreateCountingCallback()));
            Assert.Equal(new[] { CreateCommitRequest("transaction 1") }, client.CommitRequests);
            Assert.Empty(client.RollbackRequests);
        }

        [Fact]
        public async Task RunTransactionAsync_RollbackOnlyOnCallbackFailure()
        {
            var client = new TransactionTestingClient(2, CreateRpcException(StatusCode.Aborted));
            var db = FirestoreDb.Create("proj", "db", client);

            var exception = await Assert.ThrowsAsync<IOException>(() => db.RunTransactionAsync<int>(
                async transaction =>
                {
                    await transaction.GetSnapshotAsync(db.Document("col/x"));
                    throw new IOException("Bang!");
                }));
            Assert.Equal("Bang!", exception.Message);

            Assert.Empty(client.CommitRequests);
            Assert.Equal(new[] { CreateRollbackRequest("transaction 1") }, client.RollbackRequests);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(2)]
        [InlineData(10)]
        public async Task RunTransactionAsync_TooManyRetries(int? userSpecifiedAttempts)
        {
            int actualAttempts = userSpecifiedAttempts ?? TransactionOptions.Default.MaxAttempts;
            var options = userSpecifiedAttempts == null ? null : TransactionOptions.ForMaxAttempts(userSpecifiedAttempts.Value);

            var client = new TransactionTestingClient(actualAttempts, CreateRpcException(StatusCode.Aborted));
            var db = FirestoreDb.Create("proj", "db", client);
            var exception = await Assert.ThrowsAsync<RpcException>(() => db.RunTransactionAsync(CreateCountingCallback(), options));
            Assert.Equal(StatusCode.Aborted, exception.Status.StatusCode);
            // We should have made as many attempts as we were allowed, and all should have been rolled back.
            Assert.Equal(actualAttempts, client.CommitRequests.Count);
            Assert.Equal(actualAttempts, client.RollbackRequests.Count);
        }

        /// <summary>
        /// Creates a request that creates projects/proj/databases/db/documents/col/doc1 and
        /// deletes projects/proj/databases/db/documents/col/doc2 - the operations performed in
        /// our RunTransactionAsync tests.
        /// </summary>
        private static CommitRequest CreateCommitRequest(string transactionId) =>
            new CommitRequest
            {
                Database = "projects/proj/databases/db",
                Transaction = ByteString.CopyFromUtf8(transactionId),
                Writes =
                {
                        // Create
                        new Write
                        {
                            CurrentDocument = new V1.Precondition { Exists = false },
                            Update = new Document
                            {
                                Name = "projects/proj/databases/db/documents/col/doc1",
                                Fields = { { "Name", CreateValue("Test") } }
                            }
                        },
                        // Delete
                        new Write { Delete = "projects/proj/databases/db/documents/col/doc2" },
                }
            };

        /// <summary>
        /// Creates a callback that returns how many times it's executed so far.
        /// In each iteration, it fetches a document, creates another, and deletes a third.
        /// The commit from this callback should be the same as returned by <see cref="CreateCommitRequest(string)"/>.
        /// </summary>
        private Func<Transaction, Task<int>> CreateCountingCallback()
        {
            int callbackCount = 0;
            return async transaction =>
            {
                var db = transaction.Database;
                callbackCount++;
                await transaction.GetSnapshotAsync(db.Document("col/x"));
                transaction.Create(db.Document("col/doc1"), new { Name = "Test" });
                transaction.Delete(db.Document("col/doc2"));
                return callbackCount;
            };
        }


        private static RollbackRequest CreateRollbackRequest(string transactionId) =>
            new RollbackRequest
            {
                Database = "projects/proj/databases/db",
                Transaction = ByteString.CopyFromUtf8(transactionId)
            };

        private static RpcException CreateRpcException(StatusCode code) => new RpcException(new Status(code, "Bang"));
    }
}
