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

using Google.Cloud.Firestore.IntegrationTests.Models;
using Google.Cloud.Firestore.V1;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.AggregateField;
using static Google.Cloud.Firestore.IntegrationTests.FirestoreAssert;

namespace Google.Cloud.Firestore.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class RunInTransactionTest
    {
        private readonly FirestoreFixture _fixture;

        public RunInTransactionTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task SimpleTransaction()
        {
            var db = _fixture.FirestoreDb;
            var doc1 = _fixture.NonQueryCollection.Document();
            var doc2 = _fixture.NonQueryCollection.Document();

            // The callback here doesn't really need to be in a transaction. We could use a write batch instead.
            // However, it's fine for testing.
            await db.RunTransactionAsync(async transaction =>
            {
                // Simple way of making it a "true" async lambda expression
                await Task.Yield();
                transaction.Create(doc1, new { Name = "test1" });
                transaction.Create(doc2, new { Name = "test2" });
            });
            var snapshot1 = await doc1.GetSnapshotAsync();
            var snapshot2 = await doc2.GetSnapshotAsync();
            AssertSerialized(snapshot1, new { Name = "test1" });
            AssertSerialized(snapshot2, new { Name = "test2" });
        }

        /// <summary>
        /// Provoking a retry is tricky. This method has two transactions, each just incrementing a counter.
        /// A CountdownEvent is used to ensure that they've both read the same document before they then both
        /// try to commit. One will "win", and the other will be retries.
        /// </summary>
        [Fact]
        public async Task TransactionWithRetry()
        {
            int attempts = 0;
            var db = _fixture.FirestoreDb;
            var doc = await _fixture.NonQueryCollection.AddAsync(new { Count = 0 });
            var latch = new CountdownEvent(2);

            var t1 = db.RunTransactionAsync(IncrementCounter);
            var t2 = db.RunTransactionAsync(IncrementCounter);
            await Task.WhenAll(t1, t2);

            // We only had two increment transactions, but one needed to retry
            Assert.Equal(3, attempts);
            var result = await doc.GetSnapshotAsync();
            Assert.Equal(2, result.GetValue<int>("Count"));

            async Task IncrementCounter(Transaction transaction)
            {
                var snapshot = await transaction.GetSnapshotAsync(doc);
                Interlocked.Increment(ref attempts);
                // We wouldn't want to signal again when retrying. Nothing is going
                // to *increment* CurrentCount, so this should be safe.
                if (latch.CurrentCount != 0)
                {
                    latch.Signal();
                }
                if (!latch.Wait(TimeSpan.FromSeconds(10)))
                {
                    throw new TimeoutException();
                }
                transaction.Set(doc, new { Count = snapshot.GetValue<int>("Count") + 1 });
            }
        }

        /// <summary>
        /// As TransactionWithRetry, but preventing retries from happening. We expect one transaction
        /// to succeed, and the other to fail - it would have retried (as above) but the options prevent that.
        /// </summary>
        [Fact]
        public async Task TransactionNeedingRetryWithOnlyOneAttempt()
        {
            int attempts = 0;
            var db = _fixture.FirestoreDb;
            var doc = await _fixture.NonQueryCollection.AddAsync(new { Count = 0 });
            var latch = new CountdownEvent(2);

            var t1 = db.RunTransactionAsync(IncrementCounter, TransactionOptions.ForMaxAttempts(1));
            var t2 = db.RunTransactionAsync(IncrementCounter, TransactionOptions.ForMaxAttempts(1));
            await Assert.ThrowsAsync<RpcException>(() => Task.WhenAll(t1, t2));

            // Exactly one of the transactions should be faulted.
            Assert.True(t1.IsFaulted ^ t2.IsFaulted);

            Assert.Equal(2, attempts);
            var result = await doc.GetSnapshotAsync();
            Assert.Equal(1, result.GetValue<int>("Count"));

            async Task IncrementCounter(Transaction transaction)
            {
                var snapshot = await transaction.GetSnapshotAsync(doc);
                Interlocked.Increment(ref attempts);
                // We wouldn't want to signal again when retrying. Nothing is going
                // to *increment* CurrentCount, so this should be safe.
                if (latch.CurrentCount != 0)
                {
                    latch.Signal();
                }
                if (!latch.Wait(TimeSpan.FromSeconds(10)))
                {
                    throw new TimeoutException();
                }
                transaction.Set(doc, new { Count = snapshot.GetValue<int>("Count") + 1 });
            }
        }

        [Fact]
        public async Task TransactionWithCount()
        {
            var collection = _fixture.HighScoreCollection;
            await _fixture.FirestoreDb.RunTransactionAsync(async txn =>
            {
                var aggQuery = collection.Count();
                var snapshot = await txn.GetSnapshotAsync(aggQuery);
                Assert.Equal(HighScore.Data.Length, snapshot.Count);
            });
        }

        [Fact]
        public async Task TransactionWithAggregation()
        {
            var collection = _fixture.HighScoreCollection;
            await _fixture.FirestoreDb.RunTransactionAsync(async txn =>
            {
                var aggQuery = collection.Aggregate(Sum("Score","SumOfScores"), Average("Score"), Count());
                var snapshot = await txn.GetSnapshotAsync(aggQuery);
                Assert.Equal(HighScore.Data.Sum(c => c.Score), snapshot.GetValue<long>("SumOfScores"));
                Assert.Equal(HighScore.Data.Average(c => c.Score), snapshot.GetValue<double>("Avg_Score"));
                Assert.Equal(HighScore.Data.Length, snapshot.GetValue<long>("Count"));
            });
        }
    }
}
