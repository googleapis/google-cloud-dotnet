// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SessionPoolTests
    {
        private static readonly TransactionOptions s_defaultTransactionOptions = new TransactionOptions();

        public SessionPoolTests(ITestOutputHelper outputHelper)
        {
            TestLogger.Install();
            // Uncomment these lines to debug a specific test.
            // TestLogger.TestOutputHelper = outputHelper;
            // TestLogger.Install();
            // Logger.LogLevel = V1.Logging.LogLevel.Debug;
        }

        private static readonly DatabaseName s_defaultName =
            DatabaseName.Parse("projects/project1/instances/instance1/databases/database1");

        private static T[] DuplicateTaskAsync<T>(Func<T> factory, int count) =>
            Enumerable.Range(0, count).Select(_ => factory()).ToArray();

        /// <summary>
        /// Creates <paramref name="parallelCount"/> write sessions simultaneously over
        /// <paramref name="iterations"/> number of iterations.
        /// </summary>
        private async Task CreateReleaseWriteSessions(
            SessionPool pool,
            SpannerClient client,
            int iterations,
            int parallelCount)
        {
            // We yield to increase contention among parallel tasks that are kicked off.
            // This increases the amount of work they are doing on another thread.
            await Task.Yield();
            for (var i = 0; i < iterations; i++)
            {
                var readWriteOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };
                var writeSessions = await Task.WhenAll(
                        DuplicateTaskAsync(() => CreateSessionAsync(pool, client, readWriteOptions), parallelCount));

                await Task.Delay(TimeSpan.FromMilliseconds(10));

                foreach (var session in writeSessions)
                {
                    var transaction = await TransactionPool.BeginPooledTransactionAsync(client, session, readWriteOptions);
                    await TransactionPool.CommitAsync(transaction, session, new Mutation[0], SpannerOptions.Instance.Timeout, CancellationToken.None);
                    pool.ReleaseToPool(client, session);
                }
            }
        }

        /// <summary>
        /// Creates <paramref name="parallelCount"/> read sessions simultaneously over
        /// <paramref name="iterations"/> number of iterations.
        /// </summary>
        private async Task CreateReleaseReadSessions(
            SessionPool pool,
            SpannerClient client,
            int iterations,
            int parallelCount)
        {
            // We yield to increase contention among parallel tasks that are kicked off.
            // This increases the amount of work they are doing on another thread.
            await Task.Yield();
            for (var i = 0; i < iterations; i++)
            {
                var readOptions = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() };
                var readSessions = await Task.WhenAll(
                        DuplicateTaskAsync(() => CreateSessionAsync(pool, client, readOptions), parallelCount));

                await Task.Delay(TimeSpan.FromMilliseconds(10));

                foreach (var session in readSessions)
                {
                    pool.ReleaseToPool(client, session);
                }
            }
        }

        [Fact]
        public void CanCreateSessionPool()
        {
            using (new SessionPool()) { }
        }

        [Fact]
        public async Task ClientsHaveDifferentPools()
        {
            using (var pool = new SessionPool())
            {
                var client1 = new FakeClient();
                var client2 = new FakeClient();

                var session1 = await CreateSessionAsync(pool, client1);
                pool.ReleaseToPool(client1, session1);

                var session2 = await CreateSessionAsync(pool, client2);

                Assert.NotSame(session1, session2);
                Assert.Equal(1, client1.Sessions.Count);
                Assert.Equal(1, client2.Sessions.Count);
            }
        }

        [Fact]
        public async Task CanClearResources()
        {
            var client = new FakeClient();
            var session = await CreateSessionAsync(SessionPool.Default, client);
            SessionPool.Default.ReleaseToPool(client, session);
            await SpannerConnection.ClearPooledResourcesAsync();
            Assert.Equal(0, SessionPool.Default.CurrentPooledSessions);
        }

        [Fact]
        public async Task DatabasesHaveDifferentPools()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();

                var session1 = await CreateSessionAsync(pool, client);
                pool.ReleaseToPool(client, session1);

                var session2 = await pool.CreateSessionFromPoolAsync(
                    client, "newproject", "newinstance", "newdbid", s_defaultTransactionOptions, CancellationToken.None);

                Assert.NotSame(session1, session2);
                Assert.Equal(2, client.Sessions.Count);
            }
        }

        [Fact]
        public async Task EmptyPoolCreatesNewSession()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();
                var session = await CreateSessionAsync(pool, client);

                Assert.Single(client.Sessions, session);
                Assert.Single(client.SessionDatabases, s_defaultName);
            }
        }

        [Fact]
        public async Task ExpiredSessionsNotPooled()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();
                var session = await CreateSessionAsync(pool, client);

                SessionPool.MarkSessionExpired(session);
                pool.ReleaseToPool(client, session);
                var session2 = await CreateSessionAsync(pool, client);

                Assert.NotSame(session, session2);
                Assert.Equal(2, client.Sessions.Count);
            }
        }

        [Fact]
        public async Task MaxActiveViolation_WaitOnResourcesExhausted_Blocks()
        {
            using (var pool = new SessionPool())
            {
                pool.Options.WaitOnResourcesExhausted = true;
                pool.Options.MaximumActiveSessions = 2;

                var client = new FakeClient();
                var session1 = await CreateSessionAsync(pool, client);
                var session2 = await CreateSessionAsync(pool, client);
                var createTask = CreateSessionAsync(pool, client);

                await Task.WhenAll(createTask, ReleaseAfterDelay(session1));
                Assert.Same(session1, await createTask);

                async Task ReleaseAfterDelay(Session session)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(10));
                    pool.ReleaseToPool(client, session);
                }
            }
        }

        [Fact]
        public async Task MaxActiveViolation_NoWaitOnResourcesExhausted_Throws()
        {
            using (var pool = new SessionPool())
            {
                pool.Options.WaitOnResourcesExhausted = false;
                pool.Options.MaximumActiveSessions = 2;

                var client = new FakeClient();
                var session1 = await CreateSessionAsync(pool, client);
                var session2 = await CreateSessionAsync(pool, client);

                var exception = Assert.ThrowsAsync<RpcException>(() => CreateSessionAsync(pool, client));
            }
        }

        [Fact]
        public async Task MaxPoolSizeNotViolated()
        {
            using (var pool = new SessionPool())
            {
                pool.Options.MaximumPooledSessions = 2;

                var client = new FakeClient();
                var sessions = await Task.WhenAll(
                    CreateSessionAsync(pool, client),
                    CreateSessionAsync(pool, client),
                    CreateSessionAsync(pool, client));

                pool.ReleaseToPool(client, sessions[0]);
                pool.ReleaseToPool(client, sessions[1]);
                pool.ReleaseToPool(client, sessions[2]);

                var actualSize = pool.GetPoolSize(client, s_defaultName.ProjectId, s_defaultName.InstanceId, s_defaultName.DatabaseId);
                Assert.Equal(2, actualSize);
            }
        }

        [Fact]
        public async Task SessionPreWarmTx()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();

                var txOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };
                var session1 = await CreateSessionAsync(pool, client, txOptions);

                var transactionAwaited = await TransactionPool.BeginPooledTransactionAsync(client, session1, txOptions);

                Transaction transaction;
                Assert.True(client.Transactions.TryPop(out transaction));
                Assert.Same(transaction, transactionAwaited);
                await TransactionPool.CommitAsync(transaction, session1, new Mutation[0], SpannerOptions.Instance.Timeout, CancellationToken.None);

                // Releasing should create a new transaction as a prewarm
                pool.ReleaseToPool(client, session1);
                Transaction preWarmTx;
                var stopwatch = Stopwatch.StartNew();
                while (!client.Transactions.TryPop(out preWarmTx))
                {
                    await Task.Yield();
                    //everything is simulated, so the prewarm should be immediate.
                    Assert.True(stopwatch.Elapsed < TimeSpan.FromMilliseconds(500));
                }

                var session2 = await CreateSessionAsync(pool, client, txOptions);
                var transaction2 = await TransactionPool.BeginPooledTransactionAsync(client, session2, txOptions);

                Assert.Same(preWarmTx, transaction2);
                Assert.True(client.Transactions.IsEmpty);
            }
        }

        [Fact]
        public async Task SessionStress()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();
                var stressTasks = new List<Task>();
                stressTasks.AddRange(DuplicateTaskAsync(() => CreateReleaseReadSessions(pool, client, 25, 3), 5));
                stressTasks.AddRange(DuplicateTaskAsync(() => CreateReleaseWriteSessions(pool, client, 25, 3), 5));
                await Task.WhenAll(stressTasks);

                // There are 10 parallel stressors each creating no more than
                // 3 simultaneous sessions. Therefore the maximum number of created
                // sessions should be no more than 30.
                Assert.True(client.Sessions.Count <= 30);
            }
        }

        [Fact]
        public async Task SynchronousRelease()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();

                var session1 = await CreateSessionAsync(pool, client);

                pool.ReleaseToPool(client, session1);
                var session2 = await CreateSessionAsync(pool, client);

                Assert.Same(session1, session2);
            }
        }

        [Fact]
        public async Task SessionCreateIsThrottled()
        {
            using (var pool = new SessionPool())
            {
                pool.Options.MaximumConcurrentSessionCreates = 2;

                // We use a specially designed mock that records simultaneous create calls.
                // Moq actually does internal synchronization that disallows parallel calls.
                var mockClient = new ParallelSpannerClient();

                var sessionList = Enumerable.Range(0, 100)
                    .Select(x => CreateSessionAsync(pool, mockClient))
                    .ToList();

                await Task.WhenAll(sessionList);
                Assert.True(mockClient.MaxConcurrentRequests <= pool.Options.MaximumConcurrentSessionCreates);
            }
        }

        [Fact]
        public void SessionPoolDefaultTimeout()
        {
            SessionPoolOptions options = new SessionPoolOptions();
            Assert.Equal(options.Timeout,
                (int)SpannerSettings.GetDefault().CommitSettings.Timing.Retry.TotalExpiration.Timeout.Value.TotalSeconds);
        }

        [Fact]
        public async Task TransactionOptionsAreMatched()
        {
            using (var pool = new SessionPool())
            {
                var client = new FakeClient();

                var readWriteOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };

                // First acquire and use a session with a read/write transaction
                var rwSession = await CreateSessionAsync(pool, client, readWriteOptions);
                var transaction = await TransactionPool.BeginPooledTransactionAsync(client, rwSession, readWriteOptions);

                // Acquire a second session using the default transaction options
                var readOnlySession = await CreateSessionAsync(pool, client, s_defaultTransactionOptions);
                Assert.NotSame(rwSession, readOnlySession);

                // Finish with the read-only session
                pool.ReleaseToPool(client, readOnlySession);

                // Finish with the read/write session
                await TransactionPool.CommitAsync(transaction, rwSession, new Mutation[0], SpannerOptions.Instance.Timeout, CancellationToken.None);
                pool.ReleaseToPool(client, rwSession);

                // At this point, our MRU list has:
                // - The r/w session
                // - The read-only session
                // If we ask for another read-only session, we should skip the r/w one, and get back the read-only one.
                // This test needs the r/w session to be there, as if the match attempt doesn't find anything, we just return
                // the most recently used session.

                var readOnlySession2 = await CreateSessionAsync(pool, client, s_defaultTransactionOptions);
                Assert.Same(readOnlySession, readOnlySession2);
            }

        }

        /// <summary>
        /// Helper to create a session with default project/instance/database arguments.
        /// (Most tests use these.)
        /// </summary>
        private static Task<Session> CreateSessionAsync(SessionPool pool, SpannerClient client, TransactionOptions options = null) =>
            pool.CreateSessionFromPoolAsync(
                client, s_defaultName.ProjectId, s_defaultName.InstanceId, s_defaultName.DatabaseId,
                options ?? s_defaultTransactionOptions, CancellationToken.None);

        private class ParallelSpannerClient : SpannerClient
        {
            private int _concurrentRequests = 0;
            private readonly object _sync = new object();

            public int MaxConcurrentRequests { get; private set; } = 0;

            /// <inheritdoc />
            public override async Task<Session> CreateSessionAsync(DatabaseName database, CancellationToken cancellationToken)
            {
                Interlocked.Increment(ref _concurrentRequests);
                lock (_sync)
                {
                    MaxConcurrentRequests = Math.Max(MaxConcurrentRequests, _concurrentRequests);
                }
                try
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(10), cancellationToken);
                    var mockSession = new Session
                    {
                        Name = $"{s_defaultName}/sessions/{Guid.NewGuid()}"
                    };
                    return mockSession;
                }
                finally
                {
                    Interlocked.Decrement(ref _concurrentRequests);
                }
            }
        }

        private class FakeClient : SpannerClient
        {
            public ConcurrentStack<Transaction> Transactions { get; } = new ConcurrentStack<Transaction>();
            public ConcurrentBag<Session> Sessions { get; } = new ConcurrentBag<Session>();
            public ConcurrentBag<DatabaseName> SessionDatabases { get; } = new ConcurrentBag<DatabaseName>();

            public FakeClient()
            {
                Settings = SpannerSettings.GetDefault();
            }

            public override async Task<Session> CreateSessionAsync(CreateSessionRequest request, CallSettings callSettings = null)
            {
                await Task.Yield();
                var dbName = request.DatabaseAsDatabaseName;
                SessionDatabases.Add(dbName);
                var session = new Session
                {
                    SessionName = new SessionName(dbName.ProjectId, dbName.InstanceId, dbName.DatabaseId, IdGenerator.FromGuid())
                };
                Sessions.Add(session);
                return session;
            }

            public override async Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, CallSettings callSettings = null)
            {
                await Task.Yield();
                var transaction = new Transaction { Id = ByteString.CopyFromUtf8(IdGenerator.FromGuid()) };
                Transactions.Push(transaction);
                return transaction;
            }

            public override async Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings = null)
            {
                await Task.Yield();
                return new CommitResponse { CommitTimestamp = Timestamp.FromDateTime(DateTime.UtcNow) };
            }
        }
    }
}
