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
using Google.Cloud.Spanner.Admin.Database.V1;
using Xunit;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Google.Cloud.Spanner.Data.Snippets
{
    // ReSharper disable once ClassNeverInstantiated.Global
    [CollectionDefinition(nameof(SnippetFixture))]
    public class SnippetFixture : IDisposable, ICollectionFixture<SnippetFixture>
    {
        private readonly Lazy<Task> _creationTask;

        public string TestInstanceName => "spannerintegration";

        public string TestProjectName => Environment.GetEnvironmentVariable("TEST_PROJECT") ?? "cloud-sharp-jenkins";

        public string ConnectionString => $"Data Source=projects/{TestProjectName}/instances/{TestInstanceName}"
            + $"/databases/{TestDatabaseName}";

        private string NoDbConnectionString => $"Data Source=projects/{TestProjectName}/instances/{TestInstanceName}";

        public string TestDatabaseName { get; } =
            "t_" + Guid.NewGuid().ToString("N").Substring(0, 28);

        public int TestTableRowCount { get; } = 15;

        public string TestTableName { get; } = "TestTable";

        public SnippetFixture() => _creationTask = new Lazy<Task>(EnsureTestDatabaseImplAsync);

        public void Dispose()
        {
            var databaseAdminClient = DatabaseAdminClient.Create();
            databaseAdminClient.DropDatabase(
                new DatabaseName(TestProjectName, TestInstanceName, TestDatabaseName));
        }

        public Task EnsureTestDatabaseAsync() => _creationTask.Value;

        private async Task EnsureTestDatabaseImplAsync()
        {
            await CreateDatabaseAsync().ConfigureAwait(false);
            await CreateTableAsync().ConfigureAwait(false);
            await FillSampleData(TestTableName);
        }

        private async Task CreateDatabaseAsync()
        {
            using (var connection = new SpannerConnection(NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand($"CREATE DATABASE {TestDatabaseName}");
                await createCmd.ExecuteNonQueryAsync();
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

        private async Task CreateTableAsync()
        {
            string createTableStatement = $@"CREATE TABLE {TestTableName} (
                                            Key                STRING(MAX) NOT NULL,
                                            StringValue        STRING(MAX),
                                            Int64Value         INT64,
                                          ) PRIMARY KEY (Key)";

            const string index1 = "CREATE INDEX TestTableByValue ON TestTable(StringValue)";
            const string index2 = "CREATE INDEX TestTableByValueDesc ON TestTable(StringValue DESC)";

            await ExecuteDdlAsync(createTableStatement);
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
                            {"StringValue", SpannerDbType.String},
                            {"Int64Value", SpannerDbType.Int64}
                        });
                    cmd.Transaction = tx;

                    for (var i = 0; i < TestTableRowCount; ++i)
                    {
                        cmd.Parameters["Key"].Value = "k" + i;
                        cmd.Parameters["StringValue"].Value = "v" + i;
                        cmd.Parameters["Int64Value"].Value = i;
                        await cmd.ExecuteNonQueryAsync();
                    }

                    await tx.CommitAsync();
                }
            }
        }
    }
}
