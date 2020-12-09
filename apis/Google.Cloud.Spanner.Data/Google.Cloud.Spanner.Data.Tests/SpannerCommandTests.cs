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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Tests;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using Moq;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Google.Api.Gax.Testing;

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
            Assert.True(command.Parameters.SequenceEqual(command2.Parameters));
        }

        [Fact]
        public void CloneWithQueryOptions()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.QueryOptions = QueryOptions.Empty.WithOptimizerVersion("1");
            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
            Assert.Equal(command.QueryOptions, command2.QueryOptions);
        }

        [Fact]
        public void CommandHasConnectionQueryOptions()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            const string connOptimizerVersion = "1";
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            var queryOptions = QueryOptions.Empty.WithOptimizerVersion(connOptimizerVersion);
            connection.QueryOptions = queryOptions;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.QueryOptions.OptimizerVersion == connOptimizerVersion),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void CommandHasOptimizerVersionFromEnvironment()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            const string envOptimizerVersion = "2";
            RunActionWithEnvOptimizerVersion(() =>
            {
                // Optimizer version set through environment variable has higher
                // precedence than version set through connection.
                const string connOptimizerVersion = "1";
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
                var queryOptions = QueryOptions.Empty.WithOptimizerVersion(connOptimizerVersion);
                connection.QueryOptions = queryOptions;

                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                using (var reader = command.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                }
            }, envOptimizerVersion);

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.QueryOptions.OptimizerVersion == envOptimizerVersion),
                It.IsAny<CallSettings>()), Times.Once());
        }

        [Fact]
        public void CommandHasOptimizerVersionSetOnCommand()
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteStreamingSql();

            var cmdOptimizerVersion = "3";
            // Optimizer version set at a command level has higher precedence
            // than version set through the connection or the environment
            // variable.
            const string envOptimizerVersion = "2";
            RunActionWithEnvOptimizerVersion(() =>
            {
                const string connOptimizerVersion = "1";
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
                var queryOptions = QueryOptions.Empty.WithOptimizerVersion(connOptimizerVersion);
                connection.QueryOptions = queryOptions;

                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                command.QueryOptions = QueryOptions.Empty.WithOptimizerVersion(cmdOptimizerVersion);
                using (var reader = command.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                }
            }, envOptimizerVersion);

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request => request.QueryOptions.OptimizerVersion == cmdOptimizerVersion),
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
                sessionPoolOptions, spannerClient.Settings.Logger,
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

        internal static SpannerConnection BuildSpannerConnection(Mock<SpannerClient> spannerClientMock)
        {
            var spannerClient = spannerClientMock.Object;
            var sessionPoolOptions = new SessionPoolOptions
            {
                MaintenanceLoopDelay = TimeSpan.Zero
            };

            var sessionPoolManager = new SessionPoolManager(sessionPoolOptions, spannerClient.Settings.Logger, (_o, _s, _l) => Task.FromResult(spannerClient));
            sessionPoolManager.SpannerSettings.Scheduler = spannerClient.Settings.Scheduler;
            sessionPoolManager.SpannerSettings.Clock = spannerClient.Settings.Clock;

            SpannerConnectionStringBuilder builder = new SpannerConnectionStringBuilder
            {
                DataSource = DatabaseName.Format(SpannerClientHelpers.ProjectId, SpannerClientHelpers.Instance, SpannerClientHelpers.Database),
                SessionPoolManager = sessionPoolManager
            };

            return new SpannerConnection(builder);
        }

        private void RunActionWithEnvOptimizerVersion(Action action, string envOptimizerVersion)
        {
            // Save existing value of environment variable.
            const string optimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            string savedOptimizerVersion = Environment.GetEnvironmentVariable(optimizerVersionVariable);
            Environment.SetEnvironmentVariable(optimizerVersionVariable, envOptimizerVersion);

            try
            {
                action();
            }
            finally
            {
                // Set the environment back.
                Environment.SetEnvironmentVariable(optimizerVersionVariable, savedOptimizerVersion);
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
