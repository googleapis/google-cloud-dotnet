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
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    // Note: SpannerConnection cannot be mocked because it's a sealed
    // class so there are limits to what can be tested here.
    public class SpannerBatchCommandTests
    {
        [Fact]
        public void ConnectionConstructor()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            Assert.Empty(command.Commands);
            Assert.Same(connection, command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.None, command.CommandType);
        }

        [Fact]
        public void TransactionConstructor()
        {
            var connection = new SpannerConnection();
            var pool = new FakeSessionPool();
            var session = PooledSession.FromSessionName(pool, new SessionName("project", "instance", "database", "session"));

            var transaction = new SpannerTransaction(connection, TransactionMode.ReadWrite, session: session, timestampBound: null, isRetriable: false);
            var command = new SpannerBatchCommand(transaction);

            Assert.Empty(command.Commands);
            Assert.Same(connection, command.Connection);
            Assert.Same(transaction, command.Transaction);
            Assert.Equal(SpannerBatchCommandType.None, command.CommandType);
        }

        public static IEnumerable<object[]> ValidCommands
        {
            get
            {
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        "DELETE FROM myTable WHERE Key=@key",
                        new SpannerParameterCollection { { "key", SpannerDbType.Int64, 5} })),
                    "DELETE FROM myTable WHERE Key=@key",
                    1
                };
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        new SpannerCommand { CommandText = "UPDATE myTable SET Value = 5 WHERE Key = 1" })),
                    "UPDATE myTable SET Value = 5 WHERE Key = 1",
                    0
                };
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        SpannerCommandTextBuilder.CreateDmlTextBuilder("INSERT INTO myTable (Key, Value) SELECT Key, Value + 1 FROM myTable WHERE KEY = @Key"),
                        new SpannerParameterCollection { { "key", SpannerDbType.Int64, 3} })),
                    "INSERT INTO myTable (Key, Value) SELECT Key, Value + 1 FROM myTable WHERE KEY = @Key",
                    1
                };
            }
        }

        [Theory]
        [MemberData(nameof(ValidCommands))]
        public void AddValidCommands(Action<SpannerBatchCommand> addCommandAction, string expectedCommandText, int expectedParametersCount)
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            addCommandAction(command);

            Assert.Equal(1, command.Commands.Count);
            Assert.Equal(expectedCommandText, command.Commands[0].CommandText, ignoreCase: true);

            Assert.Equal(expectedParametersCount, command.Commands[0].Parameters.Count);

            Assert.Same(connection, command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.BatchDml, command.CommandType);
        }

        [Fact]
        public void AddSeveralCommands()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            var expectedCommandsInOrder = new List<string>();
            foreach (var testCase in ValidCommands)
            {
                ((Action<SpannerBatchCommand>)testCase[0])(command);
                expectedCommandsInOrder.Add((string)testCase[1]);
            }

            Assert.Equal(expectedCommandsInOrder, command.Commands.Select(c => c.CommandText), StringComparer.OrdinalIgnoreCase);

            Assert.Same(connection, command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.BatchDml, command.CommandType);
        }

        [Fact]
        public void AddNonDmlCommand_FromEmpty()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);
            Assert.Throws<InvalidOperationException>(() => command.Add("drop database myDatabase"));
        }

        [Fact]
        public void AddNonDmlCommand_FromValid()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            command.Add(
                "DELETE FROM myTable WHERE Key=@key",
                new SpannerParameterCollection { { "key", SpannerDbType.Int64, 5 } });

            Assert.Throws<InvalidOperationException>(() => command.Add("drop database myDatabase"));
        }

        [Fact]
        public void CommandPriorityDefaultsToUnspecified()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            var command = transaction.CreateBatchDmlCommand();
            Assert.Equal(Priority.Unspecified, command.Priority);
        }

        [Fact]
        public async Task CommandIncludesPriority()
        {
            var priority = Priority.High;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.Priority = priority;
            command.ExecuteNonQuery();
            transaction.Commit();

            await spannerClientMock.Received(1).ExecuteBatchDmlAsync(
                Arg.Is<ExecuteBatchDmlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task EphemeralTransactionIncludesPriorityOnBatchDmlAndCommit()
        {
            var priority = Priority.Medium;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.Priority = priority;
            command.ExecuteNonQuery();

            await spannerClientMock.Received(1).ExecuteBatchDmlAsync(
                Arg.Is<ExecuteBatchDmlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        public static TheoryData<TimeSpan?> ValidMaxCommitDelayValues => SpannerTransactionTests.ValidMaxCommitDelayValues;

        public static TheoryData<TimeSpan?> InvalidMaxCommitDelayValues => SpannerTransactionTests.InvalidMaxCommitDelayValues;

        [Fact]
        public void MaxCommitDelay_DefaultsToNull()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateBatchDmlCommand();

            Assert.Null(command.MaxCommitDelay);
        }

        [Theory, MemberData(nameof(ValidMaxCommitDelayValues))]
        public void MaxCommitDelay_Valid(TimeSpan? maxCommitDelay)
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateBatchDmlCommand();

            command.MaxCommitDelay = maxCommitDelay;

            Assert.Equal(maxCommitDelay, command.MaxCommitDelay);
        }

        [Theory, MemberData(nameof(InvalidMaxCommitDelayValues))]
        public void MaxCommitDelay_Invalid(TimeSpan? maxCommitDelay)
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateBatchDmlCommand();

            Assert.Throws<ArgumentOutOfRangeException>(() => command.MaxCommitDelay = maxCommitDelay);
        }

        [Fact]
        public async Task MaxCommitDelay_DefaultsToNull_ImplicitTransaction()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
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
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.MaxCommitDelay = maxCommitDelay;
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
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.MaxCommitDelay = transactionMaxCommitDelay;

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.MaxCommitDelay = commandMaxCommitDelay;
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
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.MaxCommitDelay = commandMaxCommitDelay;
            command.ExecuteNonQuery();

            transaction.Commit();

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
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
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                connection.Open(SpannerTransactionCreationOptions.Default, new SpannerTransactionOptions { MaxCommitDelay = transactionMaxCommitDelay });
                var command = connection.CreateBatchDmlCommand();
                command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
                command.MaxCommitDelay = commandMaxCommitDelay;
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
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                connection.Open();
                var command = connection.CreateBatchDmlCommand();
                command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
                command.MaxCommitDelay = commandMaxCommitDelay;
                command.ExecuteNonQuery();

                scope.Complete();
            }

            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task CommandIncludesRequestAndTransactionTag()
        {
            var requestTag = "request-tag-1";
            var transactionTag = "transaction-tag-1";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.Tag = transactionTag;

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.Tag = requestTag;
            command.ExecuteNonQuery();
            transaction.Commit();

            await spannerClientMock.Received(1).ExecuteBatchDmlAsync(
                Arg.Is<ExecuteBatchDmlRequest>(request => request.RequestOptions.RequestTag == requestTag && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
            await spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
        }

        private class FakeSessionPool : SessionPool.ISessionPool
        {
            public SpannerClient Client => throw new NotImplementedException();
            public IClock Clock => SystemClock.Instance;
            public SessionPoolOptions Options { get; } = new SessionPoolOptions();
            public bool TracksSessions => throw new NotImplementedException();

            public void Release(PooledSession session, ByteString transactionId, bool deleteSession) =>  throw new NotImplementedException();
            public void Detach(PooledSession session) => throw new NotImplementedException();

            public Task<PooledSession> RefreshedOrNewAsync(PooledSession session, V1.TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) =>
                throw new NotImplementedException();
        }
    }
}
