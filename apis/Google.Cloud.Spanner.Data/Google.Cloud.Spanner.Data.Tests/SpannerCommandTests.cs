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
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

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
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
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

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == connOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == connOptimizerStatisticsPackage),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void CommandHasQueryOptionsFromEnvironment()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
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
                using (var reader = command.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                }
            }, envOptimizerVersion, envOptimizerStatisticsPackage);

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == envOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == envOptimizerStatisticsPackage),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void CommandHasQueryOptionsSetOnCommand()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
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
                using (var reader = command.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                }
            }, envOptimizerVersion, envOptimizerStatisticsPackage);

            // Optimizer version set at a command level has higher precedence
            // than version set through the connection or the environment
            // variable.
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == cmdOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == cmdOptimizerStatisticsPackage),
            It.IsAny<CallSettings>()), Times.Once());
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
        public void CommitPriorityDefaultsToUnspecified()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            Assert.Equal(Priority.Unspecified, transaction.CommitPriority);
        }

        [Fact]
        public void CommandIncludesPriority()
        {
            var priority = Priority.High;
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
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
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public void CommitIncludesPriority()
        {
            var commitPriority = Priority.Medium;
            var commandPriority = Priority.High;
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.CommitPriority = commitPriority;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            command.Priority = commandPriority;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(commandPriority)),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(commitPriority)),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void CommitPriorityCanBeSetAfterCommandExecution()
        {
            var priority = Priority.Medium;
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
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
            transaction.CommitPriority = priority;
            transaction.Commit();

            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void CommitPriorityCannotBeSetForReadOnlyTransaction()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginReadOnlyTransaction();
            Assert.Throws<InvalidOperationException>(() => transaction.CommitPriority = Priority.High);
        }

        [Fact]
        public void PriorityCanBeSetToUnspecified()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.CommitPriority = Priority.Unspecified;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            command.Priority = Priority.Unspecified;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Unspecified),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Unspecified),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void RunWithRetryableTransactionWithCommitPriority()
        {
            var priority = Priority.Low;
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync_Fails(1, StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(0))
                .SetupRollbackAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            connection.Builder.SessionPoolManager.SpannerSettings.Scheduler = new NoOpScheduler();

            connection.RunWithRetriableTransaction(tx =>
            {
                tx.CommitPriority = priority;
                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.Transaction = tx;
                using (var reader = command.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                }
            });
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Unspecified),
                It.IsAny<CallSettings>()), Times.Exactly(2));
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                It.IsAny<CallSettings>()), Times.Exactly(2));
        }

        [Fact]
        public void MutationCommandIncludesPriority()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateInsertCommand("FOO");
            command.Priority = Priority.High;
            command.ExecuteNonQuery();

            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.High),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void PdmlCommandIncludesPriority()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.RowCountLowerBound);
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("DELETE FROM Users WHERE Active=False");
            command.Priority = Priority.Low;
            command.ExecutePartitionedUpdate();

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == RequestOptions.Types.Priority.Low),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void EphemeralTransactionIncludesPriorityOnDmlCommandAndCommit()
        {
            var priority = Priority.Medium;
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDml(ResultSetStats.RowCountOneofCase.RowCountExact)
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("UPDATE FOO SET BAR=1 WHERE ID=1");
            command.Priority = priority;
            command.ExecuteNonQuery();

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                It.IsAny<CallSettings>()), Times.Once());
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
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
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
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == tag && request.RequestOptions.TransactionTag == ""),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public void CommandIncludesRequestAndTransactionTag()
        {
            var requestTag1 = "request-tag-1";
            var requestTag2 = "request-tag-2";
            var transactionTag = "transaction-tag-1";
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.Tag = transactionTag;

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

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == requestTag1 && request.RequestOptions.TransactionTag == transactionTag),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == requestTag2 && request.RequestOptions.TransactionTag == transactionTag),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == transactionTag),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == transactionTag),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void TransactionTagCannotBeSetAfterCommandExecution()
        {
            var transactionTag = "transaction-tag-1";
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
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
            Assert.Throws<InvalidOperationException>(() => transaction.Tag = transactionTag);

            transaction.Commit();

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void TransactionTagCannotBeSetForReadOnlyTransaction()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginReadOnlyTransaction();
            Assert.Throws<InvalidOperationException>(() => transaction.Tag = "transaction-tag-1");
        }

        [Fact]
        public void TagsCanBeSetToNull()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.Tag = null;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.Transaction = transaction;
            command.Tag = null;
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            transaction.Commit();

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == ""),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void RunWithRetryableTransactionWithTransactionTag()
        {
            var transactionTag = "retryable-tx-tag";
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSql()
                .SetupCommitAsync_Fails(1, StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(0))
                .SetupRollbackAsync();
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            connection.Builder.SessionPoolManager.SpannerSettings.Scheduler = new NoOpScheduler();

            connection.RunWithRetriableTransaction(tx =>
            {
                tx.Tag = transactionTag;
                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.Transaction = tx;
                command.Tag = null;
                using (var reader = command.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                }
            });
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.RequestOptions.TransactionTag == transactionTag),
                It.IsAny<CallSettings>()), Times.Exactly(2));
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.RequestOptions.TransactionTag == transactionTag),
                It.IsAny<CallSettings>()), Times.Exactly(2));
        }

        [Fact]
        public void ClientCreatedWithEmulatorDetection()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            var spannerClient = spannerClientMock.Object;
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
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.IsAny<ExecuteSqlRequest>(),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void ExecuteReaderHasResourceHeader()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.IsAny<ExecuteSqlRequest>(),
                It.Is<CallSettings>(settings => HasResourcePrefixHeader(settings))), Times.Once());
        }

        [Fact]
        public void PdmlRetriedOnEosError()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteStreamingSqlForDmlThrowingEosError();

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateDmlCommand("UPDATE abc SET xyz = 1 WHERE Id > 1");
            long rowCount = command.ExecutePartitionedUpdate();
            Assert.True(rowCount > 0);
            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.IsAny<ExecuteSqlRequest>(),
                It.IsAny<CallSettings>()), Times.Exactly(3));
        }

        [Fact]
        public async Task ParallelMutationCommandsOnAmbientTransaction_OnlyCreateOneSpannerTransactionAsync()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
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

            spannerClientMock.Verify(client => client.CommitAsync(
                It.IsAny<CommitRequest>(), It.IsAny<CallSettings>()), Times.Once());
            spannerClientMock.Verify(client => client.CommitAsync(
                It.Is<CommitRequest>(request => request.Mutations.Count == 3),
                It.IsAny<CallSettings>()), Times.Once());
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
                    {"float64", SpannerDbType.Float64, 3.14},
                    {"numeric", SpannerDbType.Numeric, SpannerNumeric.Parse("6.626")},
                    {"date", SpannerDbType.Date, new DateTime(2021, 9, 8, 0, 0, 0, DateTimeKind.Utc)},
                    {"timestamp", SpannerDbType.Timestamp, new DateTime(2021, 9, 8, 15, 22, 59, DateTimeKind.Utc)},
                    {"bool", SpannerDbType.Bool, true},
                }));
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.Table == "Foo"),
                It.IsAny<CallSettings>()));
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.Columns.Equals(new RepeatedField<string> { "Col1", "Col2" })),
                It.IsAny<CallSettings>()));
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { Keys = {  new ListValue{ Values =
                {
                    new Value { StringValue = "test"},
                    new Value { StringValue = Convert.ToBase64String(new byte[] {1, 2, 3})},
                    new Value { StringValue = "10" },
                    new Value { NumberValue = 3.14 },
                    new Value { StringValue = "6.626" },
                    new Value { StringValue = "2021-09-08" },
                    new Value { StringValue = "2021-09-08T15:22:59Z" },
                    new Value { BoolValue = true },
                } } } })),
                It.IsAny<CallSettings>()));
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
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { All = true })),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public async Task CanExecuteReadCommandWithKeyRange()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand(
                "Foo", ReadOptions.FromColumns("Col1", "Col2"),
                KeySet.FromRanges(KeyRange.ClosedOpen(new Key("test_begin"), new Key("test_end"))));
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { Ranges = { new [] { new V1.KeyRange
                {
                    StartClosed = new ListValue { Values = { new Value { StringValue = "test_begin" } } },
                    EndOpen = new ListValue { Values = { new Value { StringValue = "test_end" } } }
                } } } } )),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public async Task CanExecuteReadCommandWithKeyCollection()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand(
                "Foo", ReadOptions.FromColumns("Col1", "Col2"),
                KeySet.FromKeys(new Key("key1"), new Key("key2"), new Key("key3")));
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.KeySet.Equals(new V1.KeySet { Keys =
                {
                    new ListValue { Values = { new Value { StringValue = "key1" } } },
                    new ListValue { Values = { new Value { StringValue = "key2" } } },
                    new ListValue { Values = { new Value { StringValue = "key3" } } },
                } } )),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public async Task CanExecuteReadCommandWithIndex()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithIndexName("IdxBar"), KeySet.All);
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.Index == "IdxBar"),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public async Task CanExecuteReadCommandWithLimit()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithLimit(10), KeySet.All);
            using var reader = await command.ExecuteReaderAsync();
            Assert.True(reader.HasRows);
            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => request.Limit == 10),
                It.IsAny<CallSettings>()));
        }

        [Fact]
        public async Task CanExecuteReadPartitionedReadCommand()
        {
            var spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupPartitionAsync()
                .SetupStreamingRead();

            var connection = BuildSpannerConnection(spannerClientMock);
            var transaction = await connection.BeginReadOnlyTransactionAsync();
            var command = connection.CreateReadCommand("Foo", ReadOptions.FromColumns("Col1", "Col2").WithLimit(10), KeySet.All);
            command.Transaction = transaction;
            var partitions = await command.GetReaderPartitionsAsync(0, 10);
            foreach (var partition in partitions)
            {
                // Normally we would send this information to another client to read, but we are just simulating it here
                // by serializing and deserializing the information locally.
                var tx = connection.BeginReadOnlyTransaction(TransactionId.FromBase64String(transaction.TransactionId.ToBase64String()));
                var cmd = connection.CreateCommandWithPartition(CommandPartition.FromBase64String(partition.ToBase64String()), tx);
                var reader = await cmd.ExecuteReaderAsync();
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Verify(client => client.StreamingRead(
                It.Is<ReadRequest>(request => !request.PartitionToken.IsEmpty && object.Equals(request.Transaction.Id.ToBase64(), transaction.TransactionId.Id)),
                It.IsAny<CallSettings>()), Times.Exactly(10));
        }

        internal static SpannerConnection BuildSpannerConnection(Mock<SpannerClient> spannerClientMock)
        {
            var spannerClient = spannerClientMock.Object;
            var sessionPoolOptions = new SessionPoolOptions
            {
                MaintenanceLoopDelay = TimeSpan.Zero
            };

            var sessionPoolManager = new SessionPoolManager(sessionPoolOptions, spannerClient.Settings, spannerClient.Settings.Logger, (_o, _s, _l) => Task.FromResult(spannerClient));
            sessionPoolManager.SpannerSettings.Scheduler = spannerClient.Settings.Scheduler;
            sessionPoolManager.SpannerSettings.Clock = spannerClient.Settings.Clock;

            SpannerConnectionStringBuilder builder = new SpannerConnectionStringBuilder
            {
                DataSource = DatabaseName.Format(SpannerClientHelpers.ProjectId, SpannerClientHelpers.Instance, SpannerClientHelpers.Database),
                SessionPoolManager = sessionPoolManager
            };

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
