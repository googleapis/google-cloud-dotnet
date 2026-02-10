// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

namespace Google.Cloud.Spanner.V1.Tests;

public class ManagedTransactionTests
{
    private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
    private static readonly Session s_sampleSession = new Session { SessionName = s_sampleSessionName };
    private static readonly DatabaseName s_databaseName = DatabaseName.FromProjectInstanceDatabase("project", "instance", "database");
    private static readonly TransactionOptions s_readWriteOptions = new TransactionOptions { ReadWrite = new() };
    private static readonly TransactionOptions s_readOnlyOptions = new TransactionOptions { ReadOnly = new() };
    private static readonly TransactionOptions s_partitionedDml = new TransactionOptions { PartitionedDml = new() };
    private static readonly TransactionOptions s_noneOptions = new TransactionOptions { };
    private static readonly ByteString s_transactionId = ByteString.CopyFromUtf8("transaction");
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
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, options, false, false);

        // Make a successful request
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new ResultSet()));

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

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
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readOnlyOptions, true, false);

        // Make a successful request
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new ResultSet()));

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

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
        var transaction = ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null);

        // Make a successful request
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new ResultSet()));

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

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
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

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

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        Assert.Equal(s_transactionId, transaction.TransactionId);

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
    public async Task InlinedTransaction_FallsBackToExplicit()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

        var firstCallSelectorCase = TransactionSelector.SelectorOneofCase.None;
        var secondCallSelectorCase = TransactionSelector.SelectorOneofCase.None;
        ByteString secondCallTransactionId = null;

        // First call fails (simulating inlining failure)
        // Second call succeeds (retry with explicit transaction)
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(
                callInfo =>
                {
                    firstCallSelectorCase = callInfo.Arg<ExecuteSqlRequest>().Transaction.SelectorCase;
                    throw new Exception("Inlining failed");
                },
                callInfo =>
                {
                    var req = callInfo.Arg<ExecuteSqlRequest>();
                    secondCallSelectorCase = req.Transaction.SelectorCase;
                    secondCallTransactionId = req.Transaction.Id;
                    return Task.FromResult(new ResultSet());
                }
            );

        // Explicit begin transaction succeeds
        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new Transaction { Id = s_transactionId }));

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        Assert.Equal(s_transactionId, transaction.TransactionId);

        // Verify BeginTransaction was called
        await client.Received(1).BeginTransactionAsync(
            Arg.Do<BeginTransactionRequest>(request =>
            {
                Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                Assert.Equal(s_readWriteOptions, request.Options);
            }),
            Arg.Any<CallSettings>());

        // Verify captured states
        Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, firstCallSelectorCase);
        Assert.Equal(TransactionSelector.SelectorOneofCase.Id, secondCallSelectorCase);
        Assert.Equal(s_transactionId, secondCallTransactionId);
    }

    [Fact]
    public async Task DisposeAsync_FurtherRpcsInvalid()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

        await transaction.DisposeAsync();

        // We now can't make RPCs
        await Assert.ThrowsAsync<ObjectDisposedException>(
            () => transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings));

        await client.DidNotReceive().ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>());
        await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task DisposeAsync_ReadOnlyTransactionNotRolledBack()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readOnlyOptions, false, false);

        await transaction.DisposeAsync();

        await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task DisposeAsync_PartitionedDmlTransactionNotRolledBack()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_partitionedDml, false, false);

        await transaction.DisposeAsync();

        await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task DisposeAsync_CommittedTransactionNotRolledBack()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var transaction = ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null);

        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        await transaction.CommitAsync(new CommitRequest(), s_callSettings);
        await client.Received(1).CommitAsync(
            Arg.Do<CommitRequest>(request =>
                Assert.Equal(s_transactionId, request.TransactionId)),
            Arg.Any<CallSettings>());

        await transaction.DisposeAsync();

        await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task DisposeAsync_RolledBackTransactionNotRolledBack()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var transaction = ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null);

        client.Configure()
            .RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.CompletedTask);

        await transaction.RollbackAsync(new RollbackRequest(), s_callSettings);
        await client.Received(1).RollbackAsync(
            Arg.Do<RollbackRequest>(request =>
                Assert.Equal(s_transactionId, request.TransactionId)),
            Arg.Any<CallSettings>());
        client.ClearReceivedCalls();

        await transaction.DisposeAsync();

        await client.DidNotReceive().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task DisposeAsync_ReadWriteUncommittedTransactionRolledBack()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

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
            .Returns(Task.CompletedTask);

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        await client.Received(1).ExecuteSqlAsync(
            Arg.Do<ExecuteSqlRequest>(request =>
            {
                Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
                Assert.Equal(s_readWriteOptions, request.Transaction.Begin);
            }),
            Arg.Any<CallSettings>());

        await transaction.DisposeAsync();

        await client.Received(1).RollbackAsync(
            Arg.Do<RollbackRequest>(request =>
                Assert.Equal(s_transactionId, request.TransactionId)),
            Arg.Any<CallSettings>());
    }
}
