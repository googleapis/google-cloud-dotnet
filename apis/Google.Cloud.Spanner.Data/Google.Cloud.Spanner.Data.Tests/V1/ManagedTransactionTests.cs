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
using Google.Protobuf.WellKnownTypes;
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

        // First call fails (simulating inlining failure)
        // Second call succeeds (retry with explicit transaction)
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(_ => throw new Exception("Inlining failed"), _ => Task.FromResult(new ResultSet()));
        // Explicit begin transaction succeeds
        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new Transaction { Id = s_transactionId }));

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        Assert.Equal(s_transactionId, transaction.TransactionId);
        Received.InOrder(() =>
        {
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, req.Transaction.SelectorCase)),
                Arg.Any<CallSettings>());
            client.BeginTransactionAsync(
                Arg.Do<BeginTransactionRequest>(req =>
                {
                    Assert.Equal(s_sampleSessionName, req.SessionAsSessionName);
                    Assert.Equal(s_readWriteOptions, req.Options);
                }),
                Arg.Any<CallSettings>());
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(s_transactionId, req.Transaction.Id)),
                Arg.Any<CallSettings>());
        });
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
            Arg.Do<CommitRequest>(request => Assert.Equal(s_transactionId, request.TransactionId)),
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
            Arg.Do<RollbackRequest>(request => Assert.Equal(s_transactionId, request.TransactionId)),
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
            Arg.Do<RollbackRequest>(request => Assert.Equal(s_transactionId, request.TransactionId)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task ExecuteSqlAsync_UpdatesPrecommitToken()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);
        var precommitToken = new MultiplexedSessionPrecommitToken { SeqNum = 1, PrecommitToken = ByteString.CopyFromUtf8("token1") };

        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new ResultSet
            {
                PrecommitToken = precommitToken,
                Metadata = new ResultSetMetadata { Transaction = new Transaction { Id = s_transactionId } }
            }));
        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        // Execute SQL, which should update the precommit token
        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        // Commit, which should use the precommit token.
        await transaction.CommitAsync(new CommitRequest { TransactionId = s_transactionId }, s_callSettings);

        await client.Received(1).CommitAsync(
            Arg.Is<CommitRequest>(r => r.PrecommitToken.Equals(precommitToken)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task ExecuteBatchDmlAsync_UpdatesPrecommitToken()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);
        var precommitToken = new MultiplexedSessionPrecommitToken { SeqNum = 1, PrecommitToken = ByteString.CopyFromUtf8("token1") };

        client.Configure()
            .ExecuteBatchDmlAsync(Arg.Any<ExecuteBatchDmlRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new ExecuteBatchDmlResponse
            {
                PrecommitToken = precommitToken,
                ResultSets = { new ResultSet { Metadata = new ResultSetMetadata { Transaction = new Transaction { Id = s_transactionId } } } }
            }));
        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        // Execute Batch DML, which should update the precommit token
        await transaction.ExecuteBatchDmlAsync(new ExecuteBatchDmlRequest(), s_callSettings);
        // Commit, which should use the precommit token.
        await transaction.CommitAsync(new CommitRequest { TransactionId = s_transactionId }, s_callSettings);

        await client.Received(1).CommitAsync(
            Arg.Is<CommitRequest>(r => r.PrecommitToken.Equals(precommitToken)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task CommitAsync_RetryOnPrecommitToken()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var transaction = ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null);
        var precommitToken1 = new MultiplexedSessionPrecommitToken { SeqNum = 1, PrecommitToken = ByteString.CopyFromUtf8("token1") };
        // First commit attempt returns a retry with precommit token
        var retryResponse = new CommitResponse { PrecommitToken = precommitToken1 };

        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(
                Task.FromResult(retryResponse), // First call returns retry
                Task.FromResult(new CommitResponse()) // Second call returns success
            );

        await transaction.CommitAsync(new CommitRequest { TransactionId = s_transactionId }, s_callSettings);

        Received.InOrder(() =>
        {
            client.CommitAsync(
                Arg.Do<CommitRequest>(req => Assert.Null(req.PrecommitToken)),
                Arg.Any<CallSettings>());
            client.CommitAsync(
                Arg.Do<CommitRequest>(req => Assert.Equal(precommitToken1, req.PrecommitToken)),
                Arg.Any<CallSettings>());
        });
    }

    [Fact]
    public async Task PrecommitToken_Monotonicity()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);
        var token1 = new MultiplexedSessionPrecommitToken { SeqNum = 1, PrecommitToken = ByteString.CopyFromUtf8("token1") };
        var token2 = new MultiplexedSessionPrecommitToken { SeqNum = 2, PrecommitToken = ByteString.CopyFromUtf8("token2") };
        var token3 = new MultiplexedSessionPrecommitToken { SeqNum = 3, PrecommitToken = ByteString.CopyFromUtf8("token3") };

        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(
                // First call sets token1
                Task.FromResult(new ResultSet { PrecommitToken = token1, Metadata = new ResultSetMetadata { Transaction = new Transaction { Id = s_transactionId } } }),
                // Second call sets token3
                Task.FromResult(new ResultSet { PrecommitToken = token3 }),
                // Third call tries to set token2 (should be ignored because token3 > token2)
                Task.FromResult(new ResultSet { PrecommitToken = token2 })
            );
        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        // Update to token1
        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        // Update to token3
        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        // Attempt to update to token2 (should be ignored)
        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        // Commit should use token3
        await transaction.CommitAsync(new CommitRequest { TransactionId = s_transactionId }, s_callSettings);

        await client.Received(1).CommitAsync(
            Arg.Do<CommitRequest>(req => Assert.Equal(token3, req.PrecommitToken)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task ConcurrentCommands_WaitForInlining()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);
        var inliningResultSetTcs = new TaskCompletionSource<ResultSet>();

        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            // We return a running task on the first time this is called, just to simulate an inlining call taking some time and control the test.
            .Returns(inliningResultSetTcs.Task, Task.FromResult(new ResultSet()));

        // Start two commands. One of them will be the "first" one and will trigger inlining by calling ExecuteSqlAsync with Transaction.Begin.
        // The other will wait on inlining to be completed before calling ExecuteSqlAsync.
        var task1 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        var task2 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        // Allow inlining to complete.
        inliningResultSetTcs.SetResult(new ResultSet { Metadata = new ResultSetMetadata { Transaction = new Transaction { Id = s_transactionId } } });
        // Wait for both commands to complete.
        await Task.WhenAll(task1, task2);

        // Verify calls:
        // 1. First call with Begin transaction (inline)
        // 2. Second call with Id (explicitly set from result of first)
        Received.InOrder(() =>
        {
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, req.Transaction.SelectorCase)),
                Arg.Any<CallSettings>());
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(s_transactionId, req.Transaction.Id)),
                Arg.Any<CallSettings>());
        });
    }

    [Fact]
    public async Task ConcurrentCommands_WaitForExplicit()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);
        var explicitTxTcs = new TaskCompletionSource<Transaction>();


        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            // Fail (inlining) on the first call to force explicit transaction creation.
            .Returns(_ => throw new Exception("Inline failed"), _ => Task.FromResult(new ResultSet()));
        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(explicitTxTcs.Task);

        // Start two commands. One of them will be the "first" one and will trigger creation by calling ExecuteSqlAsync with Transaction.Begin.
        // That will fail and then it will trigger an explicit BeginTransaction.
        // The other will wait on the transaction creation task to be completed before calling ExecuteSqlAsync.
        var task1 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        var task2 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        // Allow explicit creation to complete.
        explicitTxTcs.SetResult(new Transaction { Id = s_transactionId });
        // Wait for both commands to complete.
        await Task.WhenAll(task1, task2);

        Received.InOrder(() =>
        {
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, req.Transaction.SelectorCase)),
                Arg.Any<CallSettings>());
            client.BeginTransactionAsync(
                Arg.Do<BeginTransactionRequest>(req =>
                {
                    Assert.Equal(s_sampleSessionName, req.SessionAsSessionName);
                    Assert.Equal(s_readWriteOptions, req.Options);
                }),
                Arg.Any<CallSettings>());
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(s_transactionId, req.Transaction.Id)),
                Arg.Any<CallSettings>());
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(s_transactionId, req.Transaction.Id)),
                Arg.Any<CallSettings>());
        });
    }

    [Fact]
    public async Task ConcurrentCommands_FailIfCreationFails()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);
        var failingExplicitTxTcs = new TaskCompletionSource<Transaction>();

        // Fail (inlining) to force explicit transaction creation.
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(_ => Task.FromException(new Exception("Inline failed")));
        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(failingExplicitTxTcs.Task);

        // Start two commands. They will both eventually fail because transaction creation fails both inline and explicit.
        var task1 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        var task2 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        // Allow explicit transaction creation to fail.
        failingExplicitTxTcs.SetException(new Exception("Creation failed"));

        await Assert.ThrowsAsync<Exception>(() => task1);
        await Assert.ThrowsAsync<Exception>(() => task2);

        Received.InOrder(() =>
        {
            client.ExecuteSqlAsync(
                Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, req.Transaction.SelectorCase)),
                Arg.Any<CallSettings>());
            client.BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>());
        });
        // Make sure only one ExecuteSqlAsync call was made, the second task failed while waiting for the transaction.
        await client.Received(1).ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task ConcurrentCommands_UseExistingTransaction()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        // Create transaction with existing ID
        var transaction = ManagedTransaction.FromTransaction(client, s_sampleSession, s_transactionId, s_readWriteOptions, null);

        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new ResultSet()));

        // Start multiple commands
        var task1 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        var task2 = transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);
        await Task.WhenAll(task1, task2);

        // Verify no BeginTransaction
        await client.DidNotReceive().BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>());
        // Verify ExecuteSqlAsync called with ID
        await client.Received(2).ExecuteSqlAsync(
            Arg.Do<ExecuteSqlRequest>(req => Assert.Equal(s_transactionId, req.Transaction.Id)), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task CommitAsync_WithMutationsOnly_UsesMutationKey()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new Transaction { Id = s_transactionId }));
        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        var mutation = new Mutation { Insert = new Mutation.Types.Write { Table = "Users", Columns = { "Id" }, Values = { new ListValue { Values = { Value.ForString("1") } } } } };
        var commitRequest = new CommitRequest { Mutations = { mutation } };
        await transaction.CommitAsync(commitRequest, s_callSettings);

        // Verify BeginTransaction was called with the mutation key
        await client.Received(1).BeginTransactionAsync(
            Arg.Do<BeginTransactionRequest>(req => Assert.Equal(mutation, req.MutationKey)),
            Arg.Any<CallSettings>());
        // Verify commit was called with the transaction ID returned by BeginTransaction
        await client.Received(1).CommitAsync(
            Arg.Do<CommitRequest>(req => Assert.Equal(s_transactionId, req.TransactionId)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task CommitAsync_WithMutationsOnly_Delete_UsesMutationKey()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new Transaction { Id = s_transactionId }));
        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        var mutation = new Mutation { Delete = new Mutation.Types.Delete { Table = "Users", KeySet = new KeySet { Keys = { new ListValue { Values = { Value.ForString("1") } } } } } };
        var commitRequest = new CommitRequest { Mutations = { mutation } };
        await transaction.CommitAsync(commitRequest, s_callSettings);

        // Verify BeginTransaction was called with the mutation key
        await client.Received(1).BeginTransactionAsync(
            Arg.Do<BeginTransactionRequest>(req => Assert.Equal(mutation, req.MutationKey)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task CommitAsync_WithMutationsOnly_DeleteAll_DoesNotUseMutationKey()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new Transaction { Id = s_transactionId }));
        client.Configure()
            .CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new CommitResponse()));

        var mutation = new Mutation { Delete = new Mutation.Types.Delete { Table = "Users", KeySet = new KeySet { All = true } } };
        var commitRequest = new CommitRequest { Mutations = { mutation } };
        await transaction.CommitAsync(commitRequest, s_callSettings);

        // Verify BeginTransaction was called without a mutation key because the delete was "All"
        await client.Received(1).BeginTransactionAsync(
            Arg.Do<BeginTransactionRequest>(req => Assert.Null(req.MutationKey)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task TransactionTag_PropagatedToExplicitBeginTransaction()
    {
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        var sessionOptions = ManagedSessionOptions.Create(s_databaseName, client);
        var transaction = ManagedTransaction.FromTransactionOptions(sessionOptions, s_sampleSession, s_readWriteOptions, false, false);

        // Fail inlining to force explicit BeginTransaction
        client.Configure()
            .ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
            .Returns(_ => throw new Exception("Inlining failed"), _ => Task.FromResult(new ResultSet()));
        client.Configure()
            .BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(new Transaction { Id = s_transactionId }));

        var request = new ExecuteSqlRequest { RequestOptions = new RequestOptions { TransactionTag = "my-tag" } };
        await transaction.ExecuteSqlAsync(request, s_callSettings);

        // Verify BeginTransaction received the tag
        await client.Received(1).BeginTransactionAsync(
            Arg.Do<BeginTransactionRequest>(req => Assert.Equal("my-tag", req.RequestOptions.TransactionTag)),
            Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task RouteToLeader_PropagatedToHeader()
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

        await transaction.ExecuteSqlAsync(new ExecuteSqlRequest(), s_callSettings);

        await client.Received(1).ExecuteSqlAsync(
            Arg.Any<ExecuteSqlRequest>(),
            Arg.Do<CallSettings>(cs => Assert.True(HasLeaderRoutingHeader(cs))));
    }

    private static bool HasLeaderRoutingHeader(CallSettings cs)
    {
        var metadata = new Grpc.Core.Metadata();
        cs.HeaderMutation?.Invoke(metadata);
        var entry = metadata.Get("x-goog-spanner-route-to-leader");
        return string.Equals(entry?.Value, "true", StringComparison.OrdinalIgnoreCase);
    }
}
