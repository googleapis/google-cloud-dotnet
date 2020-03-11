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

using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Tests;
using Google.Cloud.Spanner.V1.Internal.Logging;
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
        public void CommandHasConnectionQueryOptions()
        {
            const string optimizerVersion = "1";
            Mock<SpannerClient> spannerClientMock = SetupExecuteStreamingSql(optimizerVersion);

            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            var queryOptions = new QueryOptions().WithOptimizerVersion(optimizerVersion);
            connection.QueryOptions = queryOptions;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                // Do nothing.
            }
        }

        [Fact]
        public void CommandHasOptimizerVersionFromEnvironment()
        {
            // Save existing value of environment variable.
            const string optimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            string savedOptimizerVersion = Environment.GetEnvironmentVariable(optimizerVersionVariable);
            const string envOptimizerVersion = "2";
            Environment.SetEnvironmentVariable(optimizerVersionVariable, envOptimizerVersion);

            // Optimizer version set through environment variable has higher
            // precedence than version set through connection.
            Mock<SpannerClient> spannerClientMock = SetupExecuteStreamingSql(envOptimizerVersion);

            const string optimizerVersion = "1";
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            var queryOptions = new QueryOptions().WithOptimizerVersion(optimizerVersion);
            connection.QueryOptions = queryOptions;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            using (var reader = command.ExecuteReader())
            {
                // Do nothing.
            }

            // Set the environment back.
            Environment.SetEnvironmentVariable(optimizerVersionVariable, savedOptimizerVersion);
        }

        [Fact]
        public void CommandHasOptimizerVersionSetOnCommand()
        {
            // Save existing value of environment variable.
            const string optimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            string savedOptimizerVersion = Environment.GetEnvironmentVariable(optimizerVersionVariable);
            const string envOptimizerVersion = "2";
            Environment.SetEnvironmentVariable(optimizerVersionVariable, envOptimizerVersion);

            var cmdOptimizerVersion = "3";
            // Optimizer version set at a command level has higher precedence
            // than version set through the connection or the environment
            // variable.
            Mock<SpannerClient> spannerClientMock = SetupExecuteStreamingSql(cmdOptimizerVersion);

            const string optimizerVersion = "1";
            SpannerConnection connection = BuildSpannerConnection(spannerClientMock);
            var queryOptions = new QueryOptions().WithOptimizerVersion(optimizerVersion);
            connection.QueryOptions = queryOptions;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            command.QueryOptions = new QueryOptions().WithOptimizerVersion(cmdOptimizerVersion);
            using (var reader = command.ExecuteReader())
            {
                // Do nothing.
            }

            // Set the environment back.
            Environment.SetEnvironmentVariable(optimizerVersionVariable, savedOptimizerVersion);
        }

        private Mock<SpannerClient> SetupExecuteStreamingSql(string optimizerVersion)
        {
            Mock<SpannerClient> spannerClientMock = SpannerClientHelpers
                .CreateMockClient(Logger.DefaultLogger, MockBehavior.Strict);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .Setup(client => client.ExecuteStreamingSql(
                    It.Is<ExecuteSqlRequest>(request => request.QueryOptions.OptimizerVersion == optimizerVersion),
                    It.IsAny<CallSettings>()))
                .Returns<ExecuteSqlRequest, CallSettings>((request, _) =>
                {
                    // Returning null since we can't return a SpannerClient.ExecuteStreamingSqlStream()
                    // since it's an abstract class.
                    return null;
                });
            return spannerClientMock;
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
    }
}
