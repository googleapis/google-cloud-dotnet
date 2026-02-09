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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using NSubstitute;
using NSubstitute.Extensions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class PooledSessionTests
    {
        private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
        private static readonly Session s_sampleSession = new Session { SessionName = s_sampleSessionName };
        private static readonly DatabaseName s_databaseName = DatabaseName.FromProjectInstanceDatabase("project", "instance", "database");
        private static readonly TransactionOptions s_readWriteOptions = new TransactionOptions { ReadWrite = new() };
        private static readonly TransactionOptions s_readOnlyOptions = new TransactionOptions { ReadOnly = new() };
        private static readonly TransactionOptions s_partitionedDml = new TransactionOptions { PartitionedDml = new() };
        private static readonly TransactionOptions s_noneOptions = new TransactionOptions { };
        private static readonly ByteString s_transactionId = ByteString.CopyFromUtf8("transaction");
        private static readonly TimeSpan s_releaseWaitTime = TimeSpan.FromSeconds(1);
        private static readonly CallSettings s_callSettings = CallSettings.FromCancellationToken(default);

        public static TheoryData<TransactionOptions> NoTransactionOptionsData => new TheoryData<TransactionOptions>
        {
            { null },
            { s_noneOptions },
        };

        [Theory]
        [MemberData(nameof(NoTransactionOptionsData))]
        public async Task NoTransactionOptions(TransactionOptions options)
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, options, false, false));

            // Make a successful request
            client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

            await client.Received(1).ExecuteSqlAsync(
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
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readOnlyOptions, true, false));

            // Make a successful request
            client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

            await client.Received(1).ExecuteSqlAsync(
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
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null));

            // Make a successful request
            client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

            await client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Equal(s_transactionId, request.Transaction.Id);
                }),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task InlinedTransaction()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false));

            // Make a successful request
            client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet
                {
                    Metadata = new ResultSetMetadata
                    {
                        Transaction = new Transaction { Id = s_transactionId }
                    }
                }));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

            Assert.Equal(s_transactionId, pooledSession.TransactionId);

            await client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Equal(s_readWriteOptions, request.Transaction.Begin);
                }),
                Arg.Any<CallSettings>());
            await client.DidNotReceive().BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ReleaseToPool_FurtherRpcsInvalid()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false));

            // Release the session immediately
            pooledSession.ReleaseToPool(false);
            // We wait a little in real time because ReleaseToPool ends up disposing but
            // in a fire and forget manner.
            await Task.Delay(s_releaseWaitTime);

            // We now can't make RPCs
            await Assert.ThrowsAsync<ObjectDisposedException>(
                () => pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings));

            await client.DidNotReceive().ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>());
            await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ReleaseToPool_ReadOnlyTransactionNotRolledBack()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readOnlyOptions, false, false));

            pooledSession.ReleaseToPool(false);
            // We wait a little in real time because ReleaseToPool ends up disposing but
            // in a fire and forget manner.
            await Task.Delay(s_releaseWaitTime);

            await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ReleaseToPool_PartitionedDmlTransactionNotRolledBack()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_partitionedDml, false, false));

            pooledSession.ReleaseToPool(false);

            await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ReleaseToPool_CommittedTransactionNotRolledBack()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null));

            client.Configure()
                .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new CommitResponse()));

            await pooledSession.CommitAsync(new CommitRequest(), s_callSettings);
            await client.Received(1).CommitAsync(
                Arg.Do<CommitRequest>(request =>
                    Assert.Equal(s_transactionId, request.TransactionId)),
                Arg.Any<CallSettings>());

            pooledSession.ReleaseToPool(false);
            // We wait a little in real time because ReleaseToPool ends up disposing but
            // in a fire and forget manner.
            await Task.Delay(s_releaseWaitTime);

            await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ReleaseToPool_RolledBackTransactionNotRolledBack()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null));

            client.Configure()
                .RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new CommitResponse()));

            await pooledSession.RollbackAsync(new RollbackRequest(), s_callSettings);
            await client.Received(1).RollbackAsync(
                Arg.Do<RollbackRequest>(request =>
                    Assert.Equal(s_transactionId, request.TransactionId)),
                Arg.Any<CallSettings>());
            client.ClearReceivedCalls();

            pooledSession.ReleaseToPool(false);
            // We wait a little in real time because ReleaseToPool ends up disposing but
            // in a fire and forget manner.
            await Task.Delay(s_releaseWaitTime);

            await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ReleaseToPool_ReadWriteUncommittedTransactionRolledBack()
        {
            var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
            var pooledSession = new PooledSession(ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false));

            client.Configure()
                .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet
                {
                    Metadata = new ResultSetMetadata
                    {
                        Transaction = new Transaction { Id = s_transactionId }
                    }
                }));

            client.Configure()
                .RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new CommitResponse()));

            await pooledSession.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
            await client.Received(1).ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(request =>
                {
                    Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                    Assert.Equal(s_readWriteOptions, request.Transaction.Begin);
                }),
                Arg.Any<CallSettings>());

            pooledSession.ReleaseToPool(false);
            // We wait a little in real time because ReleaseToPool ends up disposing but
            // in a fire and forget manner.
            await Task.Delay(s_releaseWaitTime);

            await client.Received(1).RollbackAsync(
                Arg.Do<RollbackRequest>(request =>
                    Assert.Equal(s_transactionId, request.TransactionId)),
                Arg.Any<CallSettings>());
        }
    }
}
