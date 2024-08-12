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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

// All samples now use a connection string variable declared before the start of the snippet.
// There are pros and cons for this:
// - Pro: The tests still run correctly when the fixture specifies extra configuration, e.g. credentials or host
// - Pro: The code is shorter (as connection string building can be verbose, particularly when already indented)
// - Con: There are fewer examples of building a connection string
// - Unsure: Arguably a connection string should be built elsewhere and reused, rather than appearing in the
//           code that creates a SpannerConnection. We need to see what actual usage tends towards.
//
// The table name of "TestTable" is hard-coded here, rather than taken from _fixture.TableName. This probably
// leads to simpler snippets.

namespace Google.Cloud.Spanner.Data.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(SampleTableFixture))]
    [FileLoggerBeforeAfterTest]
    public class SpannerConnectionSnippets
    {
        private readonly SampleTableFixture _fixture;

        public SpannerConnectionSnippets(SampleTableFixture fixture) => _fixture = fixture;

        [Fact]
        public void CreateConnection()
        {
            // Snippet: #ctor(string, ChannelCredentials)
            string connectionString = "Data Source=projects/my-project/instances/my-instance/databases/my-db";
            SpannerConnection connection = new SpannerConnection(connectionString);
            Console.WriteLine(connection.Project);
            Console.WriteLine(connection.SpannerInstance);
            Console.WriteLine(connection.Database);
            // End snippet

            Assert.Equal("my-project", connection.Project);
            Assert.Equal("my-instance", connection.SpannerInstance);
            Assert.Equal("my-db", connection.Database);
        }

        [Fact]
        public async Task CreateDatabaseAsync()
        {
            string databaseName = $"{_fixture.Database.SpannerDatabase}_extra";
            string connectionString = new SpannerConnectionStringBuilder(_fixture.ConnectionString)
                .WithDatabase(databaseName)
                .ConnectionString;

            // Sample: CreateDatabaseAsync
            // Additional: CreateDdlCommand(*,*)
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                SpannerCommand createDbCmd = connection.CreateDdlCommand($"CREATE DATABASE {databaseName}");
                await createDbCmd.ExecuteNonQueryAsync();

                SpannerCommand createTableCmd = connection.CreateDdlCommand(
                    @"CREATE TABLE TestTable (
                                            Key                STRING(MAX) NOT NULL,
                                            StringValue        STRING(MAX),
                                            Int64Value         INT64,
                                          ) PRIMARY KEY (Key)");
                await createTableCmd.ExecuteNonQueryAsync();
            }
            // End sample

            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                SpannerCommand createDbCmd = connection.CreateDdlCommand($"DROP DATABASE {databaseName}");
                await createDbCmd.ExecuteNonQueryAsync();
            }
        }

        [Fact]
        public async Task EphemeralRetry()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: EphemeralRetry
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.OpenAsync();

                // The following commands will be executed within an exclusive ephemeral transaction.
                // If the transaction is aborted, execution of the command will be automatically retried.
                SpannerCommand cmd = connection.CreateInsertCommand("TestTable");
                cmd.Parameters.Add("Key", SpannerDbType.String, Guid.NewGuid().ToString("N"));
                cmd.Parameters.Add("StringValue", SpannerDbType.String, "hello");
                cmd.Parameters.Add("Int64Value", SpannerDbType.Int64, 8);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                Console.WriteLine($"{rowsAffected} rows written...");
            }
            // End sample
        }

        [Fact]
        public async Task InsertDataAsync()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: InsertDataAsync
            // Additional: RunWithRetriableTransactionAsync(*,*,*)
            // Additional: RunWithRetriableTransactionAsync(*,*)
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.OpenAsync();

                // If the transaction is aborted, RunWithRetriableTransactionAsync will
                // retry the whole unit of work with a fresh transaction each time.
                await connection.RunWithRetriableTransactionAsync(async transaction =>
                {
                    SpannerCommand cmd = connection.CreateInsertCommand("TestTable");
                    SpannerParameter keyParameter = cmd.Parameters.Add("Key", SpannerDbType.String);
                    SpannerParameter stringValueParameter = cmd.Parameters.Add("StringValue", SpannerDbType.String);
                    SpannerParameter int64ValueParameter = cmd.Parameters.Add("Int64Value", SpannerDbType.Int64);
                    cmd.Transaction = transaction;

                    // This executes 5 distinct insert commands using the retriable transaction.
                    // The mutations will be effective once the transaction has committed successfully.
                    for (int i = 0; i < 5; i++)
                    {
                        keyParameter.Value = Guid.NewGuid().ToString("N");
                        stringValueParameter.Value = $"StringValue{i}";
                        int64ValueParameter.Value = i;
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        Console.WriteLine($"{rowsAffected} rows written...");
                    }
                });
            }
            // End sample
        }

        [Fact]
        public async Task DmlUpdate()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: Dml
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.OpenAsync();

                // If the transaction is aborted, RunWithRetriableTransactionAsync will
                // retry the whole unit of work with a fresh transaction each time.
                // Please be aware that the whole unit of work needs to be prepared
                // to be called more than once.
                await connection.RunWithRetriableTransactionAsync(async transaction =>
                {
                    SpannerCommand cmd = connection.CreateDmlCommand(
                        "UPDATE TestTable SET StringValue='Updated' WHERE Int64Value=@value");
                    cmd.Parameters.Add("value", SpannerDbType.Int64, 10);
                    cmd.Transaction = transaction;
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine($"{rowsAffected} rows updated...");
                });
            }
            // End sample
        }

        [Fact]
        public async Task PartitionedDmlUpdate()
        {
            string connectionString = _fixture.ConnectionString;

            await RetryHelpers.ExecuteWithRetryAsync(async () =>
            {
                // Sample: PartitionedDml
                using (SpannerConnection connection = new SpannerConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SpannerCommand cmd = connection.CreateDmlCommand(
                        "UPDATE TestTable SET TestTable.StringValue='Updated in partitions' WHERE TestTable.Int64Value=@value");
                    cmd.Parameters.Add("value", SpannerDbType.Int64, 9);
                    long rowsAffected = await cmd.ExecutePartitionedUpdateAsync();
                    Console.WriteLine($"{rowsAffected} rows updated...");
                }
                // End sample
            });
        }

        [Fact]
        public async Task BatchDml()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: BatchDml
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.OpenAsync();

                // If the transaction is aborted, RunWithRetriableTransactionAsync will
                // retry the whole unit of work with a fresh transaction each time.
                // Please be aware that the whole unit of work needs to be prepared
                // to be called more than once.
                await connection.RunWithRetriableTransactionAsync(async (transaction) =>
                {
                    SpannerBatchCommand cmd = transaction.CreateBatchDmlCommand();

                    cmd.Add(
                        "UPDATE TestTable SET StringValue='Updated' WHERE Int64Value=@value",
                        new SpannerParameterCollection { { "value", SpannerDbType.Int64, 5 } });

                    cmd.Add(
                        "DELETE FROM TestTable WHERE Int64Value=@value",
                        new SpannerParameterCollection { { "value", SpannerDbType.Int64, 250 } });

                    IEnumerable<long> rowsAffected = await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine($"{rowsAffected.ElementAt(0)} rows updated...");
                    Console.WriteLine($"{rowsAffected.ElementAt(1)} rows deleted...");
                });
            }
            // End sample
        }

        [Fact]
        public async Task CommitTimestampAsync()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: CommitTimestamp
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.OpenAsync();

                string createTableStatement =
                    @"CREATE TABLE UsersHistory (
                    Id INT64 NOT NULL,
                    CommitTs TIMESTAMP NOT NULL OPTIONS
                        (allow_commit_timestamp=true),
                    Name STRING(MAX) NOT NULL,
                    Email STRING(MAX),
                    Deleted BOOL NOT NULL,
                    ) PRIMARY KEY(Id, CommitTs DESC)";

                await connection.CreateDdlCommand(createTableStatement).ExecuteNonQueryAsync();

                // Create a command for inserting rows.
                SpannerCommand cmd = connection.CreateInsertCommand("UsersHistory",
                    new SpannerParameterCollection
                    {
                        { "Id", SpannerDbType.Int64 },
                        { "CommitTs", SpannerDbType.Timestamp, SpannerParameter.CommitTimestamp },
                        { "Name", SpannerDbType.String },
                        { "Deleted", SpannerDbType.Bool , false}
                    });

                int rowsAffected = 0;

                // If the transaction is aborted, RunWithRetriableTransactionAsync will
                // retry the whole unit of work with a fresh transaction each time.
                // Please be aware that the whole unit of work needs to be prepared
                // to be called more than once.
                await connection.RunWithRetriableTransactionAsync(async transaction =>
                {
                    // Insert a first row
                    cmd.Parameters["Id"].Value = 10L;
                    cmd.Parameters["Name"].Value = "Demo 1";
                    cmd.Transaction = transaction;
                    rowsAffected += await cmd.ExecuteNonQueryAsync();
                });

                await connection.RunWithRetriableTransactionAsync(async transaction =>
                {
                    // Insert a second row
                    cmd.Parameters["Id"].Value = 11L;
                    cmd.Parameters["Name"].Value = "Demo 2";
                    cmd.Transaction = transaction;
                    rowsAffected += await cmd.ExecuteNonQueryAsync();
                });

                Console.WriteLine($"{rowsAffected} rows written...");

                // Display the inserted values
                SpannerCommand selectCmd = connection.CreateSelectCommand("SELECT * FROM UsersHistory");
                using (SpannerDataReader reader = await selectCmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        long id = reader.GetFieldValue<long>("Id");
                        string name = reader.GetFieldValue<string>("Name");
                        DateTime timestamp = reader.GetFieldValue<DateTime>("CommitTs");
                        Console.WriteLine($"{id}: {name} - {timestamp:HH:mm:ss.ffffff}");
                    }
                }
            }
            // End sample
        }

        [Fact]
        public async Task ReadUpdateDeleteAsync()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: ReadUpdateDeleteAsync
            // Additional: CreateUpdateCommand
            // Additional: CreateDeleteCommand
            // Additional: CreateSelectCommand
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.OpenAsync();

                // If the transaction is aborted, RunWithRetriableTransactionAsync will
                // retry the whole unit of work with a fresh transaction each time.
                // Please be aware that the whole unit of work needs to be prepared
                // to be called more than once.
                await connection.RunWithRetriableTransactionAsync(async transaction =>
                {
                    // Read the first two keys in the database.
                    List<string> keys = new List<string>();
                    SpannerCommand selectCmd = connection.CreateSelectCommand("SELECT * FROM TestTable");
                    selectCmd.Transaction = transaction;
                    using (SpannerDataReader reader = await selectCmd.ExecuteReaderAsync())
                    {
                        while (keys.Count < 3 && await reader.ReadAsync())
                        {
                            keys.Add(reader.GetFieldValue<string>("Key"));
                        }
                    }

                    // Update the Int64Value of keys[0]
                    // Include the primary key and update columns.
                    SpannerCommand updateCmd = connection.CreateUpdateCommand("TestTable");
                    updateCmd.Parameters.Add("Key", SpannerDbType.String, keys[0]);
                    updateCmd.Parameters.Add("Int64Value", SpannerDbType.Int64, 0L);
                    updateCmd.Transaction = transaction;
                    await updateCmd.ExecuteNonQueryAsync();

                    // Delete row for keys[1]
                    SpannerCommand deleteCmd = connection.CreateDeleteCommand("TestTable");
                    deleteCmd.Parameters.Add("Key", SpannerDbType.String, keys[1]);
                    deleteCmd.Transaction = transaction;
                    await deleteCmd.ExecuteNonQueryAsync();
                });
                // End sample
            }
        }

        [Fact]
        public void CustomSessionPoolManager()
        {
            string connectionString = _fixture.ConnectionString;
            string instanceId = Guid.NewGuid().ToString();

            // Sample: CustomSessionPoolManager
            SessionPoolOptions options = new SessionPoolOptions
            {
                MinimumPooledSessions = 100,
                MaximumActiveSessions = 250,
                SessionLabels =
                {
                    { "service", "sales-report-generator" },
                    { "service-instance", instanceId }
                }
            };
            SessionPoolManager manager = SessionPoolManager.Create(options);

            // Note: a single SpannerConnectionStringBuilder instance can be reused whenever you
            // need to build a connection
            SpannerConnectionStringBuilder builder = new SpannerConnectionStringBuilder(connectionString)
            {
                SessionPoolManager = manager
            };

            // (Elsewhere in your code...)
            using (SpannerConnection connection = new SpannerConnection(builder))
            {
                // Use the connection
            }
            // End sample
        }

        // Deliberately not a Fact! We don't want to run this, otherwise the default session pool will be
        // shut down after the test...
#pragma warning disable xUnit1013 // Public method should be marked as test
        public async Task ShutdownSessionPoolAsync()
#pragma warning restore xUnit1013 // Public method should be marked as test
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: ShutdownSessionPoolAsync
            // Additional: ShutdownSessionPoolAsync
            // When your application is shutting down. Note that any pending or future requests
            // for sessions will fail.
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.ShutdownSessionPoolAsync();
            }
            // End sample
        }

        [Fact]
        public async Task WhenSessionPoolReady()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: WhenSessionPoolReady
            // Additional: WhenSessionPoolReady
            // This would usually be executed during application start-up, before any Spanner
            // operations are performed. It can be used at any time, however. It is purely passive:
            // it doesn't modify the session pool or trigger any other actions.
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                await connection.WhenSessionPoolReady();
            }
            // End sample
        }

        [Fact]
        public void GetSessionPoolSegmentStatistics()
        {
            string connectionString = _fixture.ConnectionString;

            // Sample: GetSessionPoolSegmentStatistics
            // Additional: GetSessionPoolSegmentStatistics
            using (SpannerConnection connection = new SpannerConnection(connectionString))
            {
                SessionPool.SessionPoolSegmentStatistics stats = connection.GetSessionPoolSegmentStatistics();
                if (stats is null)
                {
                    Console.WriteLine("No session pool for this connection string yet");
                }
                else
                {
                    // Access individual properties...
                    Console.WriteLine($"Database name: {stats.DatabaseName}");
                    Console.WriteLine($"Active sessions: {stats.ActiveSessionCount}");
                    Console.WriteLine($"Pooled sessions: {stats.PoolCount}");
                    // ... or just use the overridden ToString method to log all the statistics in one go:
                    Console.WriteLine(stats);
                }
            }
            // End sample
        }

        [Fact]
        public void DataAdapter()
        {
            string connectionString = _fixture.ConnectionString;

            RetryHelpers.ExecuteWithRetry(() =>
            {
                // Sample: DataAdapter
                using (SpannerConnection connection = new SpannerConnection(connectionString))
                {
                    DataSet untypedDataSet = new DataSet();

                    // Provide the name of the Cloud Spanner table and primary key column names.
                    SpannerDataAdapter adapter = new SpannerDataAdapter(connection, "TestTable", "Key");
                    adapter.Fill(untypedDataSet);

                    // Insert a row
                    DataRow row = untypedDataSet.Tables[0].NewRow();
                    row["Key"] = Guid.NewGuid().ToString("N");
                    row["StringValue"] = "New String Value";
                    row["Int64Value"] = 0L;
                    untypedDataSet.Tables[0].Rows.Add(row);

                    adapter.Update(untypedDataSet.Tables[0]);
                }
                // End sample
            });
        }

        [Fact]
        public void DependencyInjection()
        {
            IServiceCollection services = new ServiceCollection();
            // Sample: DependencyInjection
            services.AddSpannerConnection("SpannerDb");
            // End sample
        }
    }
}
