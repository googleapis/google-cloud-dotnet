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
            VerifyExecuteSqlRequestQueryOptions(
                spannerClientMock, command, connOptimizerVersion, connOptimizerStatisticsPackage);
        }

        [Fact]
        public void CommandHasQueryOptionsFromEnvironment()
        {
            const string envOptimizerVersion = "2";
            const string envOptimizerStatisticsPackage = "stats_package_2";
            RunActionWithEnvQueryOptions(() =>
            {
                Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                    .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
                spannerClientMock
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteStreamingSql();

                const string connOptimizerVersion = "1";
                const string connOptimizerStatisticsPackage = "stats_package_1";
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
                connection.QueryOptions = QueryOptions.Empty
                    .WithOptimizerVersion(connOptimizerVersion)
                    .WithOptimizerStatisticsPackage(connOptimizerStatisticsPackage);

                var command = connection.CreateSelectCommand("SELECT * FROM FOO");
                // Optimizer version set through environment variable has higher
                // precedence than version set through connection.
                VerifyExecuteSqlRequestQueryOptions(
                    spannerClientMock, command, envOptimizerVersion, envOptimizerStatisticsPackage);
            }, envOptimizerVersion, envOptimizerStatisticsPackage);
        }

        [Fact]
        public void CommandHasQueryOptionsSetOnCommand()
        {
            const string envOptimizerVersion = "2";
            const string envOptimizerStatisticsPackage = "stats_package_2";
            RunActionWithEnvQueryOptions(() =>
            {
                const string cmdOptimizerVersion = "3";
                const string cmdOptimizerStatisticsPackage = "stats_package_3";
                Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                    .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
                spannerClientMock
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteStreamingSql();

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
                // Optimizer version set at a command level has higher precedence
                // than version set through the connection or the environment
                // variable.
                VerifyExecuteSqlRequestQueryOptions(
                    spannerClientMock, command, cmdOptimizerVersion, cmdOptimizerStatisticsPackage);
            }, envOptimizerVersion, envOptimizerStatisticsPackage);
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

        private SpannerConnection BuildSpannerConnection(Mock<SpannerClient> spannerClientMock)
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

        private void VerifyExecuteSqlRequestQueryOptions(
            Mock<SpannerClient> spannerClientMock, SpannerCommand command,
            string expectedOptimizerVersion, string expectedOptimizerStatisticsPackage)
        {
            using (var reader = command.ExecuteReader())
            {
                Assert.True(reader.HasRows);
            }

            spannerClientMock.Verify(client => client.ExecuteStreamingSql(
                It.Is<ExecuteSqlRequest>(request =>
                    request.QueryOptions.OptimizerVersion == expectedOptimizerVersion &&
                    request.QueryOptions.OptimizerStatisticsPackage == expectedOptimizerStatisticsPackage),
                It.IsAny<CallSettings>()));
        }
    }
}
