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

#endregion

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    [CollectionDefinition(nameof(TestDatabaseFixture))]
    public class TestDatabaseFixture : IDisposable, ICollectionFixture<TestDatabaseFixture>
    {
        private readonly Lazy<Task> _creationTask;

        public string TestInstanceName => "spannerintegration";

        public string TestProjectName => Environment.GetEnvironmentVariable("TEST_PROJECT") ?? "cloud-sharp-jenkins";

        public string ConnectionString => "Data Source=projects/" + TestProjectName + "/instances/" + TestInstanceName
            + "/databases/" + DatabaseName;

        public string NoDbConnectionString => "Data Source=projects/" + TestProjectName + "/instances/" +
            TestInstanceName;

        // scratch can be used to run tests on a precreated db.
        // all tests are designed to be re-run on an exiting db (previously written state will
        // not cause failures).
        // if you use a scratch database, be sure to comment out the database
        // creation and disposal methods.
        private string DatabaseName { get; } = //"scratch";
            "t_" + Guid.NewGuid().ToString("N").Substring(0, 28);

        public int TestTableRowCount { get; } = 15;

        public string TestTable { get; } = "TestTable";

        public string DataAdapterTestTable { get; } = "DataTestTable";

        public string StressTestTable { get; } = "bookTable";
        public string ChunkingTestTable { get; } = "chunkTable";

        public TestDatabaseFixture() => _creationTask = new Lazy<Task>(EnsureTestDatabaseImplAsync);

        public void Dispose()
        {
            using (var connection = new SpannerConnection(NoDbConnectionString))
            {
                var dropCommand = connection.CreateDdlCommand("DROP DATABASE " + DatabaseName);
                dropCommand.ExecuteNonQueryAsync().ResultWithUnwrappedExceptions();
            }
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
                CreateTxTableAsync()).ConfigureAwait(false);
            await Task.WhenAll(FillSampleData(TestTable), FillSampleData(DataAdapterTestTable));
        }

        private async Task CreateDatabaseAsync()
        {
            using (var connection = new SpannerConnection(NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand("CREATE DATABASE " + DatabaseName);
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
