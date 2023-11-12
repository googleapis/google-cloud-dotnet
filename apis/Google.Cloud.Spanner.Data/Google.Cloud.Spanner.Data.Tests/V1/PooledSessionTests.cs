// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Grpc.Core;
using NSubstitute;
using NSubstitute.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions;
using ResourceInfo = Google.Rpc.ResourceInfo;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class PooledSessionTests
    {
        private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
        // In various tests we don't care whether things are evicted "on" or "after" a particular tick, so add one tick.
        private static readonly TimeSpan OneTick = TimeSpan.FromTicks(1);
        private static readonly TransactionOptions s_readWriteOptions = new TransactionOptions { ReadWrite = new() };
        private static readonly TransactionOptions s_readOnlyOptions = new TransactionOptions { ReadOnly = new() };
        private static readonly TransactionOptions s_partitionedDml = new TransactionOptions { PartitionedDml = new() };

        [Fact]
        public void FromSessionName_BasicProperties()
        {
            var pool = new FakeSessionPool();

            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            Assert.Equal(s_sampleSessionName, pooledSession.SessionName);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.False(pooledSession.RequiresRefresh);
            Assert.False(pooledSession.ServerExpired);
            Assert.Null(pooledSession.TransactionId);
            Assert.Equal(ModeOneofCase.None, pooledSession.TransactionMode);
        }

        [Fact]
        public void Expiry()
        {
            var pool = new FakeSessionPool();
            var options = pool.Options;
            var clock = pool.Clock;
            var originalTime = clock.GetCurrentDateTimeUtc();

            // If we evict sessions before we refresh them, things get weird.
            Assert.True(options.IdleSessionRefreshDelay < options.PoolEvictionDelay);

            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.False(pooledSession.RequiresRefresh);

            // Detect the need for a refresh
            clock.AdvanceTo(originalTime + options.IdleSessionRefreshDelay + OneTick);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.True(pooledSession.RequiresRefresh);

            // Detect the need for eviction
            clock.AdvanceTo(originalTime + options.PoolEvictionDelay + OneTick);
            Assert.True(pooledSession.ShouldBeEvicted);
            Assert.True(pooledSession.RequiresRefresh);
        }

        // TODO: We'd quite like to check the next three methods for all operations (and maybe more?), but it's not easy to parameterize.
        // Options:
        // - Live with lots of duplication
        // - Live without good unit test coverage
        // - Have horribly complex parameterization

        [Fact]
        public async Task AutoRefreshOnSuccessfulRpc()
        {
            var pool = new FakeSessionPool();
            var options = pool.Options;
            var clock = pool.Clock;

            var originalTime = clock.GetCurrentDateTimeUtc();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            var halfRefresh = TimeSpan.FromTicks(options.IdleSessionRefreshDelay.Ticks / 2);
            clock.Advance(halfRefresh);

            // Make a successful request
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));
            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default);

            // The request will have extended the refresh time.
            Assert.Equal(clock.GetCurrentDateTimeUtc() + options.IdleSessionRefreshDelay, pooledSession.RefreshTimeForTest);

            _ = pool.Client.Received(1).ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task DetectSessionExpiry()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a request which fails due to the session not being found (because it has expired).
            var exception = CreateSessionExpiredException();
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromException<ResultSet>(exception));

            await Assert.ThrowsAsync<RpcException>(() => pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default));
            Assert.True(pooledSession.ServerExpired);

            _ = pool.Client.Received(1).ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task NoTransactionOptions()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a successful request
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default);

            _ = pool.Client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Null(request.Transaction);
                }),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task SingleUseTransactionOptions()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName).WithTransactionOptions(s_readOnlyOptions, true);

            // Make a successful request
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default);

            _ = pool.Client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Equal(s_readOnlyOptions, request.Transaction.SingleUse);
                }),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ExplicitTransaction()
        {
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName).WithTransaction(transactionId, s_readWriteOptions, false);

            // Make a successful request
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default);

            _ = pool.Client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Equal(transactionId, request.Transaction.Id);
                }),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task InlinedTransaction()
        {
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName).WithTransactionOptions(s_readWriteOptions, false);

            // Make a successful request
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet
                {
                    Metadata = new ResultSetMetadata
                    {
                        Transaction = new Transaction { Id = transactionId }
                    }
                }));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default);

            Assert.Equal(transactionId, pooledSession.TransactionId);

            _ = pool.Client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Equal(s_readWriteOptions, request.Transaction.Begin);
                }),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void WithTransaction()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, s_partitionedDml, singleUseTransaction: false);
            Assert.Equal(s_partitionedDml.ModeCase, sessionWithTransaction.TransactionMode);
            Assert.Equal(transactionId, sessionWithTransaction.TransactionId);
            Assert.Equal(s_sampleSessionName, sessionWithTransaction.SessionName);
        }

        [Fact]
        public void ReleaseToPool_NoDelete()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            pooledSession.ReleaseToPool(false);
            Assert.False(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public void ReleaseToPool_ForceDelete()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            pooledSession.ReleaseToPool(true);
            Assert.True(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_SessionInvalidatedByServer()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a request which fails due to the session not being found (because it has expired).
            var exception = CreateSessionExpiredException();
            pool.Client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromException<ResultSet>(exception));

            await Assert.ThrowsAsync<RpcException>(() => pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default));

            // When we release the session, the pool should delete it even if we didn't ask it to.
            pooledSession.ReleaseToPool(false);
            Assert.True(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);

            _ = pool.Client.Received(1).ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public void ReleaseToPool_SessionExpired()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Let it go past its eviction time
            var clock = pool.Clock;
            clock.Advance(pool.Options.PoolEvictionDelay + OneTick);

            // When we release the session, the pool should delete it even if we didn't ask it to.
            pooledSession.ReleaseToPool(false);
            Assert.True(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_FurtherRpcsInvalid()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Release the session immediately
            pooledSession.ReleaseToPool(false);

            // We now can't make RPCs
            await Assert.ThrowsAsync<ObjectDisposedException>(
                () => pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), default));
        }

        [Fact]
        public void ReleaseToPool_ReadOnlyTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            var pooledSession = CreateWithTransaction(pool, s_readOnlyOptions);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public void ReleaseToPool_PartitionedDmlTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            var pooledSession = CreateWithTransaction(pool, s_partitionedDml);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_CommittedTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            pool.Client.Configure().CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new CommitResponse()));

            var pooledSession = CreateWithTransaction(pool, s_readWriteOptions);
            await pooledSession.CommitAsync(new CommitRequest(), null);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_RolledBackTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            pool.Client.Configure().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.CompletedTask);

            var pooledSession = CreateWithTransaction(pool, s_readWriteOptions);
            await pooledSession.RollbackAsync(new RollbackRequest(), null);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public void ReleaseToPool_ReadWriteUncommittedTransactionRolledBack()
        {
            var pool = new FakeSessionPool();
            var pooledSession = CreateWithTransaction(pool, s_readWriteOptions);
            pooledSession.ReleaseToPool(false);
            Assert.Equal(pool.RolledBackTransaction, pooledSession.TransactionId);
        }

        private static RpcException CreateSessionExpiredException() =>
            new RpcException(new Status(StatusCode.NotFound, "Session not found"),
                new Metadata { { ExecuteHelper.ResourceInfoMetadataKey, new ResourceInfo { ResourceType = ExecuteHelper.SessionResourceType }.ToByteArray() } });

        private PooledSession CreateWithTransaction(SessionPool.ISessionPool pool, TransactionOptions options)
        {
            ByteString transactionId = ByteString.CopyFromUtf8(Guid.NewGuid().ToString());
            return PooledSession.FromSessionName(pool, s_sampleSessionName).WithTransaction(transactionId, options, singleUseTransaction: false);
        }

        internal class FakeSessionPool : SessionPool.ISessionPool
        {
            public SpannerClient Client { get; }
            public SessionPoolOptions Options { get; }
            IClock SessionPool.ISessionPool.Clock => Clock;
            public FakeClock Clock => (FakeClock) Client.Settings.Clock;
            public Logger Logger { get; } = Logger.DefaultLogger;

            public bool? ReleasedSessionDeleted { get; private set; }
            public ByteString RolledBackTransaction { get; private set; }

            internal FakeSessionPool()
            {
                Client = SpannerClientHelpers.CreateMockClient(Logger);
                Options = new SessionPoolOptions
                {
                    SessionEvictionJitter = RetrySettings.NoJitter,
                    SessionRefreshJitter = RetrySettings.NoJitter
                };
            }

            public void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession)
            {
                RolledBackTransaction = transactionToRollback;
                ReleasedSessionDeleted = deleteSession;
            }

            public void Detach(PooledSession session) => throw new NotImplementedException();

            public Task<PooledSession> RefreshedOrNewAsync(PooledSession session, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) =>
                throw new NotImplementedException();
        }
    }
}
