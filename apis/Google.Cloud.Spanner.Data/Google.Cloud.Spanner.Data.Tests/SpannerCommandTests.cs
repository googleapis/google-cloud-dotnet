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
using Google.Api.Gax.Testing;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;
using static Google.Cloud.Spanner.Data.SpannerConversionOptions;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerCommandTests
    {
        [Fact]
        public void CommandTypeSupportsOnlyCommandText()
        {
            var command = new SpannerCommand();
            Assert.Throws<NotSupportedException>(() => command.CommandType = CommandType.StoredProcedure);
            Assert.Throws<NotSupportedException>(() => command.CommandType = CommandType.TableDirect);
            command.CommandType = CommandType.Text;
            Assert.Equal(CommandType.Text, command.CommandType);
        }

        [Fact]
        public void UpdateRowSourceNotSupported()
        {
            var command = new SpannerCommand();
            Assert.Throws<NotSupportedException>(() => command.UpdatedRowSource = UpdateRowSource.Both);
            Assert.Throws<NotSupportedException>(() => command.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord);
            Assert.Throws<NotSupportedException>(() => command.UpdatedRowSource = UpdateRowSource.OutputParameters);
            command.UpdatedRowSource = UpdateRowSource.None;
            Assert.Equal(UpdateRowSource.None, command.UpdatedRowSource);
        }

        [Fact]
        public void PrepareNoop()
        {
            var command = new SpannerCommand();
            command.Prepare();
        }

        [Fact]
        public void CreatesSpannerParameter()
        {
            var command = new SpannerCommand();
            Assert.IsType<SpannerParameter>(command.CreateParameter());
        }

        [Fact]
        public void CloneQuery()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
        }

        [Fact]
        public void CloneUpdateWithParameters()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateUpdateCommand(
                "T", new SpannerParameterCollection
                {
                    {"P1", SpannerDbType.String},
                    {"P2", SpannerDbType.Float64}
                });

            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
            Assert.Equal(command.Parameters.Count, command2.Parameters.Count);
            Assert.NotSame(command.Parameters, command2.Parameters);
            Assert.True(command.Parameters.SequenceEqual(command2.Parameters, new SpannerParameterEqualityComparer()));
        }

        [Fact]
        public void CloneWithQueryOptions()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.QueryOptions = QueryOptions.Empty
                .WithOptimizerVersion("1")
                .WithOptimizerStatisticsPackage("auto_20191128_14_47_22UTC");
            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
            Assert.Equal(command.QueryOptions, command2.QueryOptions);
        }

        [Fact]
        public void CommandHasConnectionQueryOptions()
        {
            const string connOptimizerVersion = "1";
            const string connOptimizerStatisticsPackage = "stats_package_1";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            connection.QueryOptions = QueryOptions.Empty
                .WithOptimizerVersion(connOptimizerVersion)
                .WithOptimizerStatisticsPackage(connOptimizerStatisticsPackage);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == connOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == connOptimizerStatisticsPackage),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommandHasQueryOptionsFromEnvironment()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            const string envOptimizerVersion = "2";
            const string envOptimizerStatisticsPackage = "stats_package_2";
            RunActionWithEnvQueryOptions(() =>
            {
                // Optimizer version set through environment variable has higher
                // precedence than version set through connection.
                const string connOptimizerVersion = "1";
                const string connOptimizerStatisticsPackage = "stats_package_1";
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
                connection.QueryOptions = QueryOptions.Empty
                    .WithOptimizerVersion(connOptimizerVersion)
                    .WithOptimizerStatisticsPackage(connOptimizerStatisticsPackage);

                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                using var reader = command.ExecuteReader();
                Assert.True(reader.HasRows);
            }, envOptimizerVersion, envOptimizerStatisticsPackage);

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == envOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == envOptimizerStatisticsPackage),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommandHasQueryOptionsSetOnCommand()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            const string cmdOptimizerVersion = "3";
            const string cmdOptimizerStatisticsPackage = "stats_package_3";
            const string envOptimizerVersion = "2";
            const string envOptimizerStatisticsPackage = "stats_package_2";
            RunActionWithEnvQueryOptions(() =>
            {
                const string connOptimizerVersion = "1";
                const string connOptimizerStatisticsPackage = "stats_package_1";
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
                connection.QueryOptions = QueryOptions.Empty
                    .WithOptimizerVersion(connOptimizerVersion)
                    .WithOptimizerStatisticsPackage(connOptimizerStatisticsPackage);

                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.QueryOptions = QueryOptions.Empty
                    .WithOptimizerVersion(cmdOptimizerVersion)
                    .WithOptimizerStatisticsPackage(cmdOptimizerStatisticsPackage);
                using var reader = command.ExecuteReader();
                Assert.True(reader.HasRows);
            }, envOptimizerVersion, envOptimizerStatisticsPackage);

            // Optimizer version set at a command level has higher precedence
            // than version set through the connection or the environment
            // variable.
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == cmdOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == cmdOptimizerStatisticsPackage),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void ExecuteSqlRequestHasDirectedReadOptionsSetOnCommand()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.DirectedReadOptions = DirectedReadTests.IncludeDirectedReadOptions;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.DirectedReadOptions.Equals(DirectedReadTests.IncludeDirectedReadOptions)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void ReadRequestHasDirectedReadOptionsSetOnCommand()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateReadCommand("FOO", ReadOptions.FromColumns("Col1", "Col2"), KeySet.All);
            command.DirectedReadOptions = DirectedReadTests.IncludeDirectedReadOptions;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.DirectedReadOptions.Equals(DirectedReadTests.IncludeDirectedReadOptions)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task PartitionHasDirectedReadOptionsSetOnCommand()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupPartitionAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.ReadOnly.WithIsDetached(true), transactionOptions: null, cancellationToken: default);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithLimit(10), KeySet.All);
            command.Transaction = transaction;
            var partitions = await command.GetReaderPartitionsAsync(PartitionOptions.Default.WithPartitionSizeBytes(0).WithMaxPartitions(10));

            // Normally we would send this information to another client to read, but we are just simulating it here
            // by serializing and deserializing the information locally.
            var existingTransactionOptions = SpannerTransactionCreationOptions.FromReadOnlyTransactionId(TransactionId.FromBase64String(transaction.TransactionId.ToBase64String()));
            foreach (var partition in partitions)
            {
                var tx = await connection.BeginTransactionAsync(existingTransactionOptions, transactionOptions: null, cancellationToken: default);
                var cmd = connection.CreateCommandWithPartition(CommandPartition.FromBase64String(partition.ToBase64String()), tx);
                cmd.DirectedReadOptions = DirectedReadTests.IncludeDirectedReadOptions;
                using var reader = await cmd.ExecuteReaderAsync();
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Received(10).StreamingRead(
                Arg.Is<ReadRequest>(request => request.DirectedReadOptions.Equals(DirectedReadTests.IncludeDirectedReadOptions)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CloneWithPriority()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Priority = Priority.Low;
            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
            Assert.Equal(command.Priority, command2.Priority);
        }

        [Fact]
        public void CommandPriorityDefaultsToUnspecified()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            Assert.Equal(Priority.Unspecified, command.Priority);
        }

        [Fact]
        public async Task CommitPriorityDefaultsToUnspecified()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(Priority.Unspecified)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommandIncludesPriority()
        {
            var priority = Priority.High;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Priority = priority;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CommitIncludesPriority()
        {
            var commitPriority = Priority.Medium;
            var commandPriority = Priority.High;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.TransactionOptions.CommitPriority = commitPriority;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            command.Priority = commandPriority;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(commandPriority)),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(commitPriority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CommitPriorityCanBeSetAfterCommandExecution()
        {
            var priority = Priority.Medium;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            // Execute a command on the transaction.
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            // Verify that we can set the commit priority after a command has been executed.
            transaction.TransactionOptions.CommitPriority = priority;
            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task PriorityCanBeSetToUnspecified()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.TransactionOptions.CommitPriority = Priority.Unspecified;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            command.Priority = Priority.Unspecified;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Unspecified),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Unspecified),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task RunWithRetryableTransactionWithCommitPriority()
        {
            var priority = Priority.Low;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync_Fails(1, StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(0))
                .SetupRollbackAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            connection.Builder.SessionPoolManager.SpannerSettings.Scheduler = new NoOpScheduler();

            await connection.RunWithRetriableTransactionAsync(async tx =>
            {
                tx.TransactionOptions.CommitPriority = priority;
                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.Transaction = tx;
                using var reader = await command.ExecuteReaderAsync();
                Assert.True(reader.HasRows);
            });
            spannerClientMock.Received(2).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Unspecified),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(2).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MutationCommandIncludesPriority()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateInsertCommand("FOO");
            command.Priority = Priority.High;
            command.ExecuteNonQuery();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.High),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void PdmlCommandIncludesPriority()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.RowCountLowerBound);
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("DELETE FROM Users WHERE Active=False");
            command.Priority = Priority.Low;
            command.ExecutePartitionedUpdate();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Low),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task EphemeralTransactionIncludesPriorityOnDmlCommandAndCommit()
        {
            var priority = Priority.Medium;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.RowCountExact)
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("UPDATE FOO SET BAR=1 WHERE ID=1");
            command.Priority = priority;
            command.ExecuteNonQuery();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CloneWithTags()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Tag = "tag-1";
            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
            Assert.Equal(command.Tag, command2.Tag);
        }

        [Fact]
        public void CommandIncludesRequestTag()
        {
            var tag = "tag-1";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Tag = tag;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == tag && request.RequestOptions.TransactionTag == ""),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CommandIncludesRequestAndTransactionTag()
        {
            var requestTag1 = "request-tag-1";
            var requestTag2 = "request-tag-2";
            var transactionTag = "transaction-tag-1";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.TransactionOptions.Tag = transactionTag;

            var command1 = connection.CreateSelectCommand("SELECT * FROM FOO");
            command1.Transaction = transaction;
            command1.Tag = requestTag1;
            using (var reader = command1.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            var command2 = connection.CreateSelectCommand("SELECT * FROM FOO");
            command2.Transaction = transaction;
            command2.Tag = requestTag2;
            using (var reader = command2.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            // Execute a statement without a request tag on the same transaction.
            var command3 = connection.CreateSelectCommand("SELECT * FROM FOO");
            command3.Transaction = transaction;
            using (var reader = command3.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == requestTag1 && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == requestTag2 && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task TransactionTagChangesIgnoredAfterCommandExecution()
        {
            var transactionTag = "transaction-tag-1";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            // Execute a command on the transaction without a transaction tag.
            var command1 = connection.CreateSelectCommand("SELECT * FROM FOO");
            command1.Transaction = transaction;
            using (var reader = command1.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.TransactionOptions.Tag = transactionTag;

            transaction.Commit();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void TransactionTagIgnoredForReadOnlyTransaction()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction(
                SpannerTransactionCreationOptions.ReadOnly, new SpannerTransactionOptions { Tag = "transaction-tag-1" });

            // Execute a command on the transaction without a transaction tag.
            var command1 = connection.CreateSelectCommand("SELECT * FROM FOO");
            command1.Transaction = transaction;
            using (var reader = command1.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task TagsCanBeSetToNull()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.TransactionOptions.Tag = null;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            command.Tag = null;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task RunWithRetryableTransactionWithTransactionTag()
        {
            var transactionTag = "retryable-tx-tag";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync_Fails(1, StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(0))
                .SetupRollbackAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            connection.Builder.SessionPoolManager.SpannerSettings.Scheduler = new NoOpScheduler();

            await connection.RunWithRetriableTransactionAsync(async tx =>
            {
                tx.TransactionOptions.Tag = transactionTag;
                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.Transaction = tx;
                command.Tag = null;
                using var reader = await command.ExecuteReaderAsync();
                Assert.True(reader.HasRows);
            });
            spannerClientMock.Received(2).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(2).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
        }

        public static TheoryData<TimeSpan?> ValidMaxCommitDelayValues => SpannerTransactionTests.ValidMaxCommitDelayValues;

        public static TheoryData<TimeSpan?> InvalidMaxCommitDelayValues => SpannerTransactionTests.InvalidMaxCommitDelayValues;

        [Fact]
        public void MaxCommitDelay_DefaultsToNull()
        {
            var command = new SpannerCommand();

            Assert.Null(command.EphemeralTransactionOptions.MaxCommitDelay);
        }

        [Theory, MemberData(nameof(ValidMaxCommitDelayValues))]
        public void MaxCommitDelay_Valid(TimeSpan? maxCommitDelay)
        {
            var command = new SpannerCommand();

            command.EphemeralTransactionOptions.MaxCommitDelay = maxCommitDelay;

            Assert.Equal(maxCommitDelay, command.EphemeralTransactionOptions.MaxCommitDelay);
        }

        [Theory, MemberData(nameof(InvalidMaxCommitDelayValues))]
        public void MaxCommitDelay_Invalid(TimeSpan? maxCommitDelay)
        {
            var command = new SpannerCommand();

            Assert.Throws<ArgumentOutOfRangeException>(() => command.EphemeralTransactionOptions.MaxCommitDelay = maxCommitDelay);
        }

        [Fact]
        public async Task MaxCommitDelay_DefaultsToNull_ExplicitTransaction()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_Propagates_ExplicitTransaction()
        {
            var maxCommitDelay = TimeSpan.FromMilliseconds(100);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.TransactionOptions.MaxCommitDelay = maxCommitDelay;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(maxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_CanBeSetAfterCommandExecution_ExplicitTransaction()
        {
            var maxCommitDelay = TimeSpan.FromMilliseconds(100);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.TransactionOptions.MaxCommitDelay = maxCommitDelay;
            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(maxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_Propagates_RunWithRetryableTransaction()
        {
            var maxCommitDelay = TimeSpan.FromMilliseconds(100);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync_Fails(1, StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(0))
                .SetupRollbackAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            connection.Builder.SessionPoolManager.SpannerSettings.Scheduler = new NoOpScheduler();

            await connection.RunWithRetriableTransactionAsync(async tx =>
            {
                tx.TransactionOptions.MaxCommitDelay = maxCommitDelay;
                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.Transaction = tx;
                using var reader = await command.ExecuteReaderAsync();
                Assert.True(reader.HasRows);
            });

            await spannerClientMock.Received(2).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(maxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_DefaultsToNull_ImplicitTransaction()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateInsertCommand("FOO");
            command.ExecuteNonQuery();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_Propagates_ImplicitTransaction()
        {
            var maxCommitDelay = TimeSpan.FromMilliseconds(100);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateInsertCommand("FOO");
            command.EphemeralTransactionOptions.MaxCommitDelay = maxCommitDelay;
            command.ExecuteNonQuery();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(maxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_SetOnCommand_SetOnExplicitTransaction_CommandIgnored()
        {
            var transactionMaxCommitDelay = TimeSpan.FromMilliseconds(100);
            var commandMaxCommitDelay = TimeSpan.FromMilliseconds(300);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.TransactionOptions.MaxCommitDelay = transactionMaxCommitDelay;

            var command = connection.CreateInsertCommand("FOO");
            command.Transaction = transaction;
            command.EphemeralTransactionOptions.MaxCommitDelay = commandMaxCommitDelay;

            command.ExecuteNonQuery();

            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(transactionMaxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_SetOnCommand_UnsetOnExplicitTransaction_CommandIgnored()
        {
            var commandMaxCommitDelay = TimeSpan.FromMilliseconds(300);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = connection.CreateInsertCommand("FOO");
            command.Transaction = transaction;
            command.EphemeralTransactionOptions.MaxCommitDelay = commandMaxCommitDelay;

            command.ExecuteNonQuery();

            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_DefaultsToNull_AmbientTransaction()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                connection.Open();
                var command = connection.CreateInsertCommand("FOO");
                command.ExecuteNonQuery();

                scope.Complete();
            }

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_Propagates_AmbientTransaction()
        {
            var maxCommitDelay = TimeSpan.FromMilliseconds(100);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                connection.Open(SpannerTransactionCreationOptions.ReadWrite, new SpannerTransactionOptions { MaxCommitDelay = maxCommitDelay});
                var command = connection.CreateInsertCommand("FOO");
                command.ExecuteNonQuery();

                scope.Complete();
            }

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(maxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_SetOnCommand_SetOnAmbientTransaction_CommandIgnored()
        {
            var transactionMaxCommitDelay = TimeSpan.FromMilliseconds(100);
            var commandMaxCommitDelay = TimeSpan.FromMilliseconds(300);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                connection.Open(SpannerTransactionCreationOptions.ReadWrite, new SpannerTransactionOptions { MaxCommitDelay = transactionMaxCommitDelay});
                var command = connection.CreateInsertCommand("FOO");
                command.EphemeralTransactionOptions.MaxCommitDelay = commandMaxCommitDelay;
                command.ExecuteNonQuery();

                scope.Complete();
            }

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(transactionMaxCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task MaxCommitDelay_SetOnCommand_UnsetOnAmbientTransaction_CommandIgnored()
        {
            var commandMaxCommitDelay = TimeSpan.FromMilliseconds(300);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                connection.Open();
                var command = connection.CreateInsertCommand("FOO");
                command.EphemeralTransactionOptions.MaxCommitDelay = commandMaxCommitDelay;
                command.ExecuteNonQuery();

                scope.Complete();
            }

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task TransactionOptions_Propagates_ExplicitTransaction()
        {
            SpannerTransactionCreationOptions transactionCreationOptions = SpannerTransactionCreationOptions.ReadWrite.WithExcludeFromChangeStreams(true);
            TransactionSelector expectedTransactionSelector = new TransactionSelector
            {
                Begin = new V1.TransactionOptions
                {
                    ExcludeTxnFromChangeStreams = true,
                    ReadWrite = new V1.TransactionOptions.Types.ReadWrite()
                }
            };

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.None)
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = await connection.BeginTransactionAsync(transactionCreationOptions, transactionOptions: null, cancellationToken: default);

            var command = connection.CreateDmlCommand("DELETE FROM Foo");
            command.Transaction = transaction;
            await command.ExecuteNonQueryAsync();

            transaction.Commit();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.Transaction.Equals(expectedTransactionSelector)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task TransactionOptions_Propagates_RunWithRetryableTransaction()
        {
            SpannerTransactionCreationOptions transactionCreationOptions = SpannerTransactionCreationOptions.ReadWrite.WithExcludeFromChangeStreams(true);
            TransactionSelector expectedTransactionSelector = new TransactionSelector
            {
                Begin = new V1.TransactionOptions
                {
                    ExcludeTxnFromChangeStreams = true,
                    ReadWrite = new V1.TransactionOptions.Types.ReadWrite()
                }
            };

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.None)
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            await connection.RunWithRetriableTransactionAsync(async tx =>
            {
                var command = connection.CreateDmlCommand("DELETE FROM Foo");
                command.Transaction = tx;
                await command.ExecuteNonQueryAsync();
            }, transactionCreationOptions, transactionOptions: null, cancellationToken: default);

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.Transaction.Equals(expectedTransactionSelector)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task TransactionOptions_Propagates_ImplicitTransaction()
        {
            SpannerTransactionCreationOptions transactionCreationOptions = SpannerTransactionCreationOptions.ReadWrite.WithExcludeFromChangeStreams(true);
            TransactionSelector expectedTransactionSelector = new TransactionSelector
            {
                Begin = new V1.TransactionOptions
                {
                    ExcludeTxnFromChangeStreams = true,
                    ReadWrite = new V1.TransactionOptions.Types.ReadWrite()
                }
            };

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.None)
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("DELETE FROM Foo");
            command.EphemeralTransactionCreationOptions = transactionCreationOptions;
            await command.ExecuteNonQueryAsync();

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.Transaction.Equals(expectedTransactionSelector)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task TransactionOptions_Propagates_AmbientTransaction()
        {
            SpannerTransactionCreationOptions transactionCreationOptions = SpannerTransactionCreationOptions.ReadWrite.WithExcludeFromChangeStreams(true);
            TransactionSelector expectedTransactionSelector = new TransactionSelector
            {
                Begin = new V1.TransactionOptions
                {
                    ExcludeTxnFromChangeStreams = true,
                    ReadWrite = new V1.TransactionOptions.Types.ReadWrite()
                }
            };

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.None)
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                await connection.OpenAsync(transactionCreationOptions, options: null, cancellationToken: default);
                var command = connection.CreateDmlCommand("DELETE FROM Foo");
                await command.ExecuteNonQueryAsync();

                scope.Complete();
            }

            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Is<ExecuteSqlRequest>(request => request.Transaction.Equals(expectedTransactionSelector)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void ClientCreatedWithEmulatorDetection()
        {
            SpannerClient spannerClient = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClient
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            var sessionPoolOptions = new SessionPoolOptions
            {
                MaintenanceLoopDelay = TimeSpan.Zero
            };

            var sessionPoolManager = new SessionPoolManager(
                sessionPoolOptions, spannerClient.Settings, spannerClient.Settings.Logger,
                (_o, _s, _l) =>
                {
                    Assert.True(_o.UsesEmulator);
                    return Task.FromResult(spannerClient);
                });

            SpannerConnectionStringBuilder builder = new SpannerConnectionStringBuilder
            {
                DataSource = DatabaseName.Format(SpannerClientHelpers.ProjectId, SpannerClientHelpers.Instance, SpannerClientHelpers.Database),
                SessionPoolManager = sessionPoolManager,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction,
                EnvironmentVariableProvider = key => key == "SPANNER_EMULATOR_HOST" ? "localhost" : null
            };
            var connection = new SpannerConnection(builder);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            spannerClient.Received(1).ExecuteStreamingSql(
                Arg.Any<ExecuteSqlRequest>(),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void ExecuteReaderHasResourceHeader()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Any<ExecuteSqlRequest>(),
                Arg.Is<CallSettings>(settings => HasResourcePrefixHeader(settings)));
        }

        [Fact]
        public void PdmlRetriedOnEosError()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDmlThrowingEosError();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("UPDATE abc SET xyz = 1 WHERE Id > 1");
            long rowCount = command.ExecutePartitionedUpdate();
            Assert.True(rowCount > 0);
            spannerClientMock.Received(3).ExecuteStreamingSql(
                Arg.Any<ExecuteSqlRequest>(),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ParallelMutationCommandsOnAmbientTransaction_OnlyCreateOneSpannerTransactionAsync()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var tables = new string[] { "TAB1", "TAB2", "TAB3" };
                await Task.WhenAll(tables.Select(table =>
                {
                    using var cmd = connection.CreateInsertCommand(table);
                    return cmd.ExecuteNonQueryAsync();
                }));
                scope.Complete();
            }

            await spannerClientMock.Received(1).CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.Mutations.Count == 3),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CanCreateReadCommand()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateReadCommand(
                "Foo", ReadOptions.FromColumns("Col1", "Col2"), KeySet.FromParameters(new SpannerParameterCollection
                {
                    {"key1", SpannerDbType.String, "test"},
                    {"key2", SpannerDbType.Int64, 10}
                }));
            Assert.Equal("Foo", command.SpannerCommandTextBuilder.TargetTable);
            Assert.Equal(new List<string> { "Col1", "Col2" }, command.SpannerCommandTextBuilder.ReadOptions?.Columns);
        }

        [Fact]
        public async Task CanExecuteReadCommand()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand(
                "Foo", ReadOptions.FromColumns(new List<string> { "Col1", "Col2" }), KeySet.FromParameters(new SpannerParameterCollection
                {
                    {"string", SpannerDbType.String, "test"},
                    {"bytes", SpannerDbType.Bytes, new byte[] {1, 2, 3}},
                    {"int64", SpannerDbType.Int64, "10"},
                    {"float32", SpannerDbType.Float32, 2.718f},
                    {"float64", SpannerDbType.Float64, 3.14},
                    {"numeric", SpannerDbType.Numeric, SpannerNumeric.Parse("6.626")},
                    {"pgnumeric", SpannerDbType.PgNumeric, PgNumeric.Parse("16.626")},
                    {"date", SpannerDbType.Date, new DateTime(2021, 9, 8, 0, 0, 0, DateTimeKind.Utc)},
                    {"timestamp", SpannerDbType.Timestamp, new DateTime(2021, 9, 8, 15, 22, 59, DateTimeKind.Utc)},
                    {"bool", SpannerDbType.Bool, true},
                    {"interval", SpannerDbType.Interval, Interval.Parse("P1Y2M3D")},
                }));
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Received().StreamingRead(
                Arg.Is<ReadRequest>(request => request.Table == "Foo"), Arg.Any<CallSettings>());
            spannerClientMock.Received().StreamingRead(
                Arg.Is<ReadRequest>(request => request.Columns.Equals(new RepeatedField<string> { "Col1", "Col2" })), Arg.Any<CallSettings>());
            spannerClientMock.Received().StreamingRead(
                Arg.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { Keys = {  new ListValue { Values =
                {
                    new Value { StringValue = "test"},
                    new Value { StringValue = Convert.ToBase64String(new byte[] {1, 2, 3})},
                    new Value { StringValue = "10" },
                    new Value { NumberValue = 2.718f },
                    new Value { NumberValue = 3.14 },
                    new Value { StringValue = "6.626" },
                    new Value { StringValue = "16.626" },
                    new Value { StringValue = "2021-09-08" },
                    new Value { StringValue = "2021-09-08T15:22:59Z" },
                    new Value { BoolValue = true },
                    new Value { StringValue = "P1Y2M3D" },
                } } } })),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CanExecuteReadAllCommand()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2"), KeySet.All);
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { All = true })),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CanExecuteReadCommandWithKeyRange()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand(
                "Foo", ReadOptions.FromColumns("Col1", "Col2"),
                KeySet.FromRanges(KeyRange.ClosedOpen(new Key("test_begin"), new Key("test_end"))));
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { Ranges = { new [] { new V1.KeyRange
                {
                    StartClosed = new ListValue { Values = { new Value { StringValue = "test_begin" } } },
                    EndOpen = new ListValue { Values = { new Value { StringValue = "test_end" } } }
                } } } } )),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CanExecuteReadCommandWithKeyCollection()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand(
                "Foo", ReadOptions.FromColumns("Col1", "Col2"),
                KeySet.FromKeys(new Key("key1"), new Key("key2"), new Key("key3")));
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { Keys =
                {
                    new ListValue { Values = { new Value { StringValue = "key1" } } },
                    new ListValue { Values = { new Value { StringValue = "key2" } } },
                    new ListValue { Values = { new Value { StringValue = "key3" } } },
                } } )),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CanExecuteReadCommandWithIndex()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithIndexName("IdxBar"), KeySet.All);
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.Index == "IdxBar"),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CanExecuteReadCommandWithLimit()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithLimit(10), KeySet.All);
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.Limit == 10),
                Arg.Any<CallSettings>());
        }

        [Theory, CombinatorialData]
        public async Task CanExecuteReadPartitionedReadCommand(bool dataBoostEnabled)
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupPartitionAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.ReadOnly.WithIsDetached(true), transactionOptions: null, cancellationToken: default);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithLimit(10), KeySet.All);
            command.Transaction = transaction;
            var partitions = await command.GetReaderPartitionsAsync(PartitionOptions.Default.WithPartitionSizeBytes(0).WithMaxPartitions(10).WithDataBoostEnabled(dataBoostEnabled));

            Assert.Equal(dataBoostEnabled, CommandPartition.FromBase64String(partitions.FirstOrDefault().ToBase64String()).Request.DataBoostEnabled);

            // Normally we would send this information to another client to read, but we are just simulating it here
            // by serializing and deserializing the information locally.
            var existingTransactionOptions = SpannerTransactionCreationOptions.FromReadOnlyTransactionId(TransactionId.FromBase64String(transaction.TransactionId.ToBase64String()));
            foreach (var partition in partitions)
            {
                var tx = await connection.BeginTransactionAsync(existingTransactionOptions, transactionOptions: null, cancellationToken: default);
                var cmd = connection.CreateCommandWithPartition(CommandPartition.FromBase64String(partition.ToBase64String()), tx);
                var reader = await cmd.ExecuteReaderAsync();
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Received(10).StreamingRead(
                Arg.Is<ReadRequest>(request =>
                    !request.PartitionToken.IsEmpty &&
                    request.DataBoostEnabled == dataBoostEnabled &&
                    object.Equals(request.Transaction.Id.ToBase64(), transaction.TransactionId.Id)),
                Arg.Any<CallSettings>());
        }

        public static IEnumerable<object[]> ConfiguredSpannerDbTypes()
        {
            // Format : ClrToSpannerTypeDefaultMappings value, Parameter value, expected SpannerDbType.
            // Decimal mappings.
            yield return new object[] { default, 3.14m, SpannerDbType.Numeric };
            yield return new object[] { DecimalToFloat64, 3.14m, SpannerDbType.Float64 };
            yield return new object[] { DecimalToNumeric, 3.14m, SpannerDbType.Numeric };
            yield return new object[] { DecimalToPgNumeric, 3.14m, SpannerDbType.PgNumeric };

            // DateTime mappings.
            yield return new object[] { default, new DateTime(2022, 05, 26, 12, 12, 12), SpannerDbType.Timestamp };
            yield return new object[] { DateTimeToTimestamp, new DateTime(2022, 05, 26, 12, 12, 12), SpannerDbType.Timestamp };
            yield return new object[] { DateTimeToDate, new DateTime(2022, 05, 26, 12, 12, 12), SpannerDbType.Date };
        }

        [Theory]
        [MemberData(nameof(ConfiguredSpannerDbTypes))]
        public void ExecuteStreamingSql_ParameterDefaultsToConfiguredType(string clrToSpannerTypeMapping, object value, SpannerDbType spannerDbType)
        {
            var builder = new SpannerConnectionStringBuilder();
            if (!string.IsNullOrWhiteSpace(clrToSpannerTypeMapping))
            {
                builder.ClrToSpannerTypeDefaultMappings = clrToSpannerTypeMapping;
            }

            var parameter = new SpannerParameter
            {
                ParameterName = "p",
                Value = value
            };
            var actualValue = RunExecuteStreamingSqlWithParameter(builder, parameter).Fields["p"];
            var expectedValue = spannerDbType.ToProtobufValue(parameter.Value);
            Assert.Equal(expectedValue, actualValue);
        }

        public static IEnumerable<object[]> ConfiguredClrTypes()
        {
            // Format : SpannerToClrTypeDefaultMappings value, value, SpannerDbType, expected CLR type.
            // Float64 mappings.
            yield return new object[] { default, 3.14d, SpannerDbType.Float64, typeof(double) };

            //// Date mappings.
            yield return new object[] { default, "2022-05-26", SpannerDbType.Date, typeof(DateTime) };
            yield return new object[] { DateToDateTime, "2022-05-26", SpannerDbType.Date, typeof(DateTime) };
            yield return new object[] { DateToSpannerDate, "2022-05-26", SpannerDbType.Date, typeof(SpannerDate) };
        }

        [Theory]
        [MemberData(nameof(ConfiguredClrTypes))]
        public void ExecuteReadRequest_ColumnDefaultsToConfiguredClrType(string spannerToClrTypeMapping, object dbValue, SpannerDbType dbType, System.Type clrType)
        {
            var builder = new SpannerConnectionStringBuilder();
            if (!string.IsNullOrWhiteSpace(spannerToClrTypeMapping))
            {
                builder.SpannerToClrTypeDefaultMappings = spannerToClrTypeMapping;
            }
            var options = SpannerConversionOptions.ForConnectionStringBuilder(builder);
            Value protobufValue = RunReadRequest(builder, dbType, dbValue).Values[0];
            // This is a hack, but simpler to do what DataReader does behind the scenes.
            var clrValue = dbType.ConvertToClrType<object>(protobufValue, options);
            // Check that CLR type of value is as expected.
            Assert.Equal(clrType, clrValue.GetType());
        }

        private Struct RunExecuteStreamingSqlWithParameter(SpannerConnectionStringBuilder builder, SpannerParameter parameter)
        {
            var request = new ExecuteSqlRequest();
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql(request);

            var connection = BuildSpannerConnection(spannerClientMock, builder);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Parameters.Add(parameter);
            using var reader = command.ExecuteReader();
            Assert.True(reader.HasRows);
            spannerClientMock.Received(1).ExecuteStreamingSql(
                Arg.Any<ExecuteSqlRequest>(),
                Arg.Any<CallSettings>());
            return request.Params;
        }

        // TODO: Ensure that builder is correctly used.
        private ListValue RunReadRequest(SpannerConnectionStringBuilder builder, SpannerDbType dbType, object value)
        {
            var request = new ReadRequest();
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead(request);

            var connection = BuildSpannerConnection(spannerClientMock, builder);

            var command = connection.CreateReadCommand(
                 "Foo", ReadOptions.FromColumns(new List<string> { "Col1" }),
                 KeySet.FromParameters(new SpannerParameterCollection
                     {
                        { "p", dbType, value }
                     }));
            using var reader = command.ExecuteReader();
            Assert.True(reader.HasRows);
            // Handle the cases of Float64 and Date for now.
            Value val = dbType == SpannerDbType.Float64 ? Value.ForNumber((double)value) : Value.ForString((string)value);
            spannerClientMock.Received(1).StreamingRead(
                Arg.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet
                {
                    Keys = { new ListValue { Values = { val } } }
                })),
                Arg.Any<CallSettings>());
            return request.KeySet.Keys[0];
        }

        internal static SpannerConnection BuildSpannerConnection(SpannerClient spannerClientMock) =>
            BuildSpannerConnection(spannerClientMock, new SpannerConnectionStringBuilder());

        /// <summary>
        /// Builds a spanner connection based on the given mock and connection string builder.
        /// The connection string builder will be mutated during the course of this method.
        /// </summary>
        internal static SpannerConnection BuildSpannerConnection(SpannerClient spannerClient, SpannerConnectionStringBuilder builder)
        {
            var sessionPoolOptions = new SessionPoolOptions
            {
                MaintenanceLoopDelay = TimeSpan.Zero
            };

            var sessionPoolManager = new SessionPoolManager(sessionPoolOptions, spannerClient.Settings, spannerClient.Settings.Logger, (_o, _s, _l) => Task.FromResult(spannerClient));
            sessionPoolManager.SpannerSettings.Scheduler = spannerClient.Settings.Scheduler;
            sessionPoolManager.SpannerSettings.Clock = spannerClient.Settings.Clock;

            builder.DataSource = DatabaseName.Format(SpannerClientHelpers.ProjectId, SpannerClientHelpers.Instance, SpannerClientHelpers.Database);
            builder.SessionPoolManager = sessionPoolManager;
            return new SpannerConnection(builder);
        }

        private void RunActionWithEnvQueryOptions(Action action, string envOptimizerVersion, string envOptimizerStatisticsPackage)
        {
            // Save existing value of environment variable.
            const string optimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            const string optimizerStatisticsPackageVariable = "SPANNER_OPTIMIZER_STATISTICS_PACKAGE";
            string savedOptimizerVersion = Environment.GetEnvironmentVariable(optimizerVersionVariable);
            string savedOptimizerStatisticsPackage = Environment.GetEnvironmentVariable(optimizerStatisticsPackageVariable);
            Environment.SetEnvironmentVariable(optimizerVersionVariable, envOptimizerVersion);
            Environment.SetEnvironmentVariable(optimizerStatisticsPackageVariable, envOptimizerStatisticsPackage);

            try
            {
                action();
            }
            finally
            {
                // Set the environment back.
                Environment.SetEnvironmentVariable(optimizerVersionVariable, savedOptimizerVersion);
                Environment.SetEnvironmentVariable(optimizerStatisticsPackageVariable, savedOptimizerStatisticsPackage);
            }
        }

        private bool HasResourcePrefixHeader(CallSettings callSettings)
        {
            var expectedDatabaseName = DatabaseName.FromProjectInstanceDatabase(
                SpannerClientHelpers.ProjectId, SpannerClientHelpers.Instance,
                SpannerClientHelpers.Database);

            var metadata = new Metadata();
            callSettings.HeaderMutation?.Invoke(metadata);
            Metadata.Entry entry = Assert.Single(metadata, e => e.Key == SpannerClientImpl.ResourcePrefixHeader);
            return expectedDatabaseName.ToString() == entry.Value;
        }
    }
}
