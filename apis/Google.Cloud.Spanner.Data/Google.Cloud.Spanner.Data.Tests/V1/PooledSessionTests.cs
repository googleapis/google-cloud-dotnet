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

using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Protobuf;
using Grpc.Core;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.PoolRewrite.Tests
{
    // TODO: the mocking isn't ideal at the moment. We want to verify that only the calls we've set up are made, and only the right
    // number of times, but Moq ends up being annoying in terms of the Settings property. This is definitely solvable, but needs
    // more experience with Moq, I suspect.
    public class PooledSessionTests
    {
        private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
        // In various tests we don't care whether things are evicted "on" or "after" a particular tick, so add one tick.
        private static readonly TimeSpan OneTick = TimeSpan.FromTicks(1);

        [Fact]
        public void FromSessionName_BasicProperties()
        {
            var pool = new FakeSessionPool();

            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            Assert.Same(s_sampleSessionName, pooledSession.SessionName);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.False(pooledSession.RequiresRefresh);
            Assert.False(pooledSession.ServerExpired);
            Assert.Null(pooledSession.TransactionId);
            Assert.Equal(TransactionOptions.ModeOneofCase.None, pooledSession.TransactionMode);
        }

        [Fact]
        public void Expiry()
        {
            var pool = new FakeSessionPool();
            var options = pool.Options;
            var clock = (FakeClock) options.Clock;
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
            var clock = (FakeClock)options.Clock;

            var originalTime = clock.GetCurrentDateTimeUtc();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            var halfRefresh = TimeSpan.FromTicks(options.IdleSessionRefreshDelay.Ticks / 2);
            clock.Advance(halfRefresh);

            // Make a successful request
            var request = new BeginTransactionRequest();
            var response = new Transaction();
            pool.Mock.Setup(client => client.BeginTransactionAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(response);
            await pooledSession.BeginTransactionAsync(request, 5, CancellationToken.None);

            // The request will have extended the refresh time.
            Assert.Equal(clock.GetCurrentDateTimeUtc() + options.IdleSessionRefreshDelay, pooledSession.RefreshTimeForTest);
        }

        [Fact]
        public async Task DetectSessionExpiry()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a request which fails due to the session not being found (because it has expired).
            var request = new BeginTransactionRequest();
            pool.Mock.Setup(client => client.BeginTransactionAsync(request, It.IsAny<CallSettings>()))
                .ThrowsAsync(new RpcException(new Status(StatusCode.NotFound, "Session not found")));
            await Assert.ThrowsAsync<RpcException>(() => pooledSession.BeginTransactionAsync(request, 5, CancellationToken.None));
            Assert.True(pooledSession.ServerExpired);
        }

        [Fact]
        public async Task RequestSessionIsPopulated()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a successful request
            var request = new BeginTransactionRequest();
            pool.Mock.Setup(client => client.BeginTransactionAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(new Transaction());
            await pooledSession.BeginTransactionAsync(request, 5, CancellationToken.None);
            
            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
        }

        [Fact]
        public void WithTransaction()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var mode = TransactionOptions.ModeOneofCase.PartitionedDml;
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, mode);
            Assert.Equal(mode, sessionWithTransaction.TransactionMode);
            Assert.Equal(transactionId, sessionWithTransaction.TransactionId);
            Assert.Equal(s_sampleSessionName, sessionWithTransaction.SessionName);
        }

        [Fact]
        public async Task RequestTransactionIsPopulated()
        {
            var pool = new FakeSessionPool();
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var mode = TransactionOptions.ModeOneofCase.ReadWrite;
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, mode);

            // Make a successful request
            var request = new CommitRequest();
            pool.Mock.Setup(client => client.CommitAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(new CommitResponse());
            await sessionWithTransaction.CommitAsync(request, 5, CancellationToken.None);

            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(transactionId, request.TransactionId);
        }

        [Fact]
        public async Task ExecuteSqlAsync_RequestTransactionIsPopulatedWhenPresent()
        {
            var pool = new FakeSessionPool();
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var mode = TransactionOptions.ModeOneofCase.ReadWrite;
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, mode);

            // Make a successful request
            var request = new ExecuteSqlRequest();
            pool.Mock.Setup(client => client.ExecuteSqlAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(new ResultSet());
            await sessionWithTransaction.ExecuteSqlAsync(request, 5, CancellationToken.None);

            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(transactionId, request.Transaction.Id);
        }

        [Fact]
        public async Task ExecuteSqlAsync_RequestTransactionIsLeftAlonePopulatedWhenPresent()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a successful request
            var request = new ExecuteSqlRequest { Transaction = new TransactionSelector { Begin = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() } } };
            pool.Mock.Setup(client => client.ExecuteSqlAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(new ResultSet());
            await pooledSession.ExecuteSqlAsync(request, 5, CancellationToken.None);

            // The call modifies the request's session, but not transaction.
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, request.Transaction.SelectorCase);
            Assert.Equal(new TransactionOptions.Types.ReadOnly(), request.Transaction.Begin.ReadOnly);
        }

        [Fact]
        public void ReleaseToPool_NoDelete()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            pooledSession.ReleaseToPool(false);
            Assert.False(pool.ReleasedSessionDeleted);
        }

        [Fact]
        public void ReleaseToPool_ForceDelete()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            pooledSession.ReleaseToPool(true);
            Assert.True(pool.ReleasedSessionDeleted);
        }

        [Fact]
        public async Task ReleaseToPool_SessionInvalidatedByServer()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a request which fails due to the session not being found (because it has expired).
            var request = new BeginTransactionRequest();
            pool.Mock.Setup(client => client.BeginTransactionAsync(request, It.IsAny<CallSettings>()))
                .ThrowsAsync(new RpcException(new Status(StatusCode.NotFound, "Session not found")));
            await Assert.ThrowsAsync<RpcException>(() => pooledSession.BeginTransactionAsync(request, 5, CancellationToken.None));

            // When we release the session, the pool should delete it even if we didn't ask it to.
            pooledSession.ReleaseToPool(false);
            Assert.True(pool.ReleasedSessionDeleted);
        }

        [Fact]
        public void ReleaseToPool_SessionExpired()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Let it go past its eviction time
            var clock = (FakeClock) pool.Options.Clock;
            clock.Advance(pool.Options.PoolEvictionDelay + OneTick);

            // When we release the session, the pool should delete it even if we didn't ask it to.
            pooledSession.ReleaseToPool(false);
            Assert.True(pool.ReleasedSessionDeleted);
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
                () => pooledSession.BeginTransactionAsync(new BeginTransactionRequest(), 5, CancellationToken.None));
        }

        private class FakeSessionPool : SessionPool.ISessionPool
        {
            public Mock<SpannerClient> Mock { get; }
            public SpannerClient Client => Mock.Object;
            public SessionPoolOptions Options { get; }

            public bool? ReleasedSessionDeleted { get; private set; }

            internal FakeSessionPool()
            {
                Mock = new Mock<SpannerClient>(MockBehavior.Strict);
                Mock.SetupProperty(client => client.Settings, SpannerSettings.GetDefault());
                Options = new SessionPoolOptions
                {
                    Clock = new FakeClock(),
                    Scheduler = new FakeScheduler(),
                    SessionEvictionJitter = RetrySettings.NoJitter,
                    SessionRefreshJitter = RetrySettings.NoJitter
                };
            }

            public void Release(PooledSession session, bool deleteSession)
            {
                ReleasedSessionDeleted = deleteSession;
            }
        }
    }
}
