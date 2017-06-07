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
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.Admin.Database.V1;

#endregion

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public class TestDatabaseFixture : IDisposable
    {
        private readonly Lazy<Task> _creationTask;

        public string TestInstanceName => "myspanner";

        public string TestProjectName => "spanneref";

        public string ConnectionString => "Data Source=projects/" + TestProjectName + "/instances/" + TestInstanceName
            + "/databases/" + DatabaseName;

        private string NoDbConnectionString => "Data Source=projects/" + TestProjectName + "/instances/" +
            TestInstanceName;

        // scratch can be used to run tests on a precreated db.
        // all tests are designed to be re-run on an exiting db (previously written state will
        // not cause failures).
        // if you use a scratch database, be sure to comment out the database
        // creation and disposal methods.
        public string DatabaseName { get; } = "t_" + Guid.NewGuid().ToString("N").Substring(0, 28);

        public string TestTable { get; } = "TestTable";

        public TestDatabaseFixture() => _creationTask = new Lazy<Task>(EnsureTestDatabaseImplAsync);

        public void Dispose()
        {
            //TODO(benwu):DROP Database is not supported in DDL form yet.
            var databaseAdminClient = DatabaseAdminClient.Create();

            databaseAdminClient.DropDatabase(
                new DatabaseName(TestProjectName, TestInstanceName, DatabaseName));
        }

        public async Task<SpannerConnection> GetTestDatabaseConnectionAsync()
        {
            await EnsureTestDatabaseAsync();
            return new SpannerConnection(ConnectionString);
        }

        public Task EnsureTestDatabaseAsync() => _creationTask.Value;

        private async Task EnsureTestDatabaseImplAsync()
        {
            await CreateDatabaseAsync();
            await Task.WhenAll(
                CreateTableAsync(),
                CreateTypeTableAsync(),
                CreateTxTableAsync()).ConfigureAwait(false);
            await FillSampleData();
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
            var index1 = "CREATE INDEX TestTableByValue ON TestTable(StringValue)";
            var index2 = "CREATE INDEX TestTableByValueDesc ON TestTable(StringValue DESC)";

            await ExecuteDdlAsync(createTableStatement);
            await ExecuteDdlAsync(index1);
            await ExecuteDdlAsync(index2);
        }

        public async Task FillSampleData()
        {
            using (var connection = new SpannerConnection(ConnectionString))
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginTransactionAsync())
                {
                    var cmd = connection.CreateInsertCommand(
                        TestTable,
                        new SpannerParameterCollection
                        {
                            {"Key", SpannerDbType.String},
                            {"StringValue", SpannerDbType.String}
                        });
                    cmd.Transaction = tx;

                    for (var i = 0; i < 15; ++i)
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
