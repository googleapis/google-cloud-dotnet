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

#region

using System;
using System.Threading.Tasks;
using Google.Api.Gax;
using Xunit;
using Google.Cloud.ClientTesting;

#endregion

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    [CollectionDefinition(nameof(TestDatabaseFixture))]
    public class TestDatabaseFixture : CloudProjectFixtureBase, ICollectionFixture<TestDatabaseFixture>
    {
        private const long NumPartitionReadRows = 10000;
        private readonly Lazy<Task> _creationTask;

        public string SpannerHost { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_HOST", null);
        public string SpannerPort { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_PORT", null);
        public string SpannerInstance { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_INSTANCE", "spannerintegration");
        public string SpannerDatabase { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_DATABASE", "t_" + Guid.NewGuid().ToString("N").Substring(0, 28));

        // Connection string including database, generated from the above properties
        // Connection string without the database, generated from the above properties
        public string ConnectionString { get; }
        public string NoDbConnectionString { get; }

        // Constants, effectively
        public int TestTableRowCount { get; } = 15;
        public string TestTable { get; } = "TestTable";
        public string DataAdapterTestTable { get; } = "DataTestTable";
        public string StressTestTable { get; } = "bookTable";
        public string ChunkingTestTable { get; } = "chunkTable";

        public TestDatabaseFixture()
        {
            var builder = new SpannerConnectionStringBuilder
            {
                Host = SpannerHost,
                DataSource = $"projects/{ProjectId}/instances/{SpannerInstance}"
            };
            if (SpannerPort != null)
            {
                builder.Port = int.Parse(SpannerPort);
            }
            NoDbConnectionString = builder.ConnectionString;
            ConnectionString = builder.WithDatabase(SpannerDatabase).ConnectionString;

            _creationTask = new Lazy<Task>(EnsureTestDatabaseImplAsync);
        }

        private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
        {
            string value = Environment.GetEnvironmentVariable(name);
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }

        public override void Dispose()
        {
            using (var connection = new SpannerConnection(NoDbConnectionString))
            {
                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {SpannerDatabase}");
                dropCommand.ExecuteNonQuery();
            }
            SpannerConnection.ClearPooledResourcesAsync().WaitWithUnwrappedExceptions();
        }

        public async Task<SpannerConnection> GetTestDatabaseConnectionAsync()
        {
            await EnsureTestDatabaseAsync();
            return new SpannerConnection(ConnectionString);
        }

        public Task EnsureTestDatabaseAsync() => _creationTask.Value;

        private async Task EnsureTestDatabaseImplAsync()
        {
            TestLogger.Install();
            await Task.Delay(1); // this line exists so the others can be commented.
            await CreateDatabaseAsync();
            await Task.WhenAll(
                CreateTableAsync(),
                CreateTypeTableAsync(),
                CreatePartitionReadTableAsync(),
                CreateTxTableAsync()).ConfigureAwait(false);
            await Task.WhenAll(FillSampleData(TestTable), FillSampleData(DataAdapterTestTable), FillOrderData());
        }

        private async Task CreateDatabaseAsync()
        {
            using (var connection = new SpannerConnection(NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand($"CREATE DATABASE {SpannerDatabase}");
                await createCmd.ExecuteNonQueryAsync();
            }
        }

        private async Task CreateTxTableAsync()
        {
            var typeTable = @"CREATE TABLE TX (
                              K                   STRING(MAX) NOT NULL,
                              Int64Value          INT64,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)";

            await ExecuteDdlAsync(typeTable);
        }

        private async Task CreatePartitionReadTableAsync()
        {
            var partitionTable = @"CREATE TABLE Orders (
                                OrderID STRING(MAX) NOT NULL,
                                OrderDate TIMESTAMP,
                                Product STRING(MAX) NOT NULL
                            ) PRIMARY KEY (OrderID)";

            await ExecuteDdlAsync(partitionTable);
        }

        private async Task FillOrderData()
        {
            using (var connection = new SpannerConnection(ConnectionString))
            {
                await connection.OpenAsync();
                for (var i = 0; i < NumPartitionReadRows / 5000; i++)
                {
                    using (var tx = await connection.BeginTransactionAsync())
                    using (var cmd = connection.CreateInsertCommand("Orders", new SpannerParameterCollection
                    {
                        {"OrderID", SpannerDbType.String},
                        {"OrderDate", SpannerDbType.Timestamp},
                        {"Product", SpannerDbType.String}
                    }))
                    {
                        cmd.Transaction = tx;
                        for (var x = 1; x < 5000; x++)
                        {
                            cmd.Parameters["OrderID"].Value = Guid.NewGuid().ToString();
                            cmd.Parameters["OrderDate"].Value = DateTime.Now.Subtract(TimeSpan.FromDays(x));
                            cmd.Parameters["Product"].Value = $"Widget#{x}";
                            cmd.ExecuteNonQuery();
                        }
                        await tx.CommitAsync();
                    }
                }
            }
        }

        private async Task ExecuteDdlAsync(string ddlStatement)
        {
            using (var connection = new SpannerConnection(ConnectionString))
            {
                var createCmd = connection.CreateDdlCommand(ddlStatement);
                await createCmd.ExecuteNonQueryAsync();
            }
        }

        private async Task CreateTypeTableAsync()
        {
            var typeTable = @"CREATE TABLE T ( 
                  K                   STRING(MAX) NOT NULL,
                  BoolValue           BOOL,
                  Int64Value          INT64,
                  Float64Value        FLOAT64,
                  StringValue         STRING(MAX),
                  BytesValue          BYTES(MAX),
                  TimestampValue      TIMESTAMP,
                  DateValue           DATE,
                  BoolArrayValue      ARRAY<BOOL>,
                  Int64ArrayValue     ARRAY<INT64>,
                  Float64ArrayValue   ARRAY<FLOAT64>,
                  StringArrayValue    ARRAY<STRING(MAX)>,
                  BytesArrayValue     ARRAY<BYTES(MAX)>,
                  TimestampArrayValue ARRAY<TIMESTAMP>,
                  DateArrayValue      ARRAY<DATE>,
                ) PRIMARY KEY (K)";

            await ExecuteDdlAsync(typeTable);
        }

        private async Task CreateTableAsync()
        {
            string createTableStatement = $@"CREATE TABLE {TestTable} (
                                            Key                STRING(MAX) NOT NULL,
                                            StringValue        STRING(MAX),
                                          ) PRIMARY KEY (Key)";
            string createDataTableStatement = $@"CREATE TABLE {DataAdapterTestTable} (
                                            Key                STRING(MAX) NOT NULL,
                                            StringValue        STRING(MAX),
                                          ) PRIMARY KEY (Key)";
            string createStressTableStatement = $@"CREATE TABLE {StressTestTable} (
                                            ID           STRING(MAX) NOT NULL,
                                            Title        STRING(MAX),
                                          ) PRIMARY KEY (ID)";
            string createChunkingTableStatement = $@"CREATE TABLE {ChunkingTestTable} ( 
                                            K                   STRING(MAX) NOT NULL,
                                            StringValue         STRING(MAX),
                                            BytesValue          BYTES(MAX),
                                            StringArrayValue    ARRAY<STRING(MAX)>,
                                            BytesArrayValue     ARRAY<BYTES(MAX)>,
                                          ) PRIMARY KEY (K)";

            var index1 = "CREATE INDEX TestTableByValue ON TestTable(StringValue)";
            var index2 = "CREATE INDEX TestTableByValueDesc ON TestTable(StringValue DESC)";

            await Task.WhenAll(
                ExecuteDdlAsync(createTableStatement),
                ExecuteDdlAsync(createDataTableStatement),
                ExecuteDdlAsync(createStressTableStatement),
                ExecuteDdlAsync(createChunkingTableStatement));
            await ExecuteDdlAsync(index1);
            await ExecuteDdlAsync(index2);
        }

        private async Task FillSampleData(string testTable)
        {
            using (var connection = new SpannerConnection(ConnectionString))
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginTransactionAsync())
                {
                    var cmd = connection.CreateInsertCommand(
                        testTable,
                        new SpannerParameterCollection
                        {
                            {"Key", SpannerDbType.String},
                            {"StringValue", SpannerDbType.String}
                        });
                    cmd.Transaction = tx;

                    for (var i = 0; i < TestTableRowCount; ++i)
                    {
                        cmd.Parameters["Key"].Value = "k" + i;
                        cmd.Parameters["StringValue"].Value = "v" + i;
                        await cmd.ExecuteNonQueryAsync();
                    }

                    await tx.CommitAsync();
                }
            }
        }
    }
}
