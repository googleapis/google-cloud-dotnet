using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.Admin.Database.V1;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class TestDatabaseFixture : IDisposable {

        private readonly string _databaseName = "t_" + Guid.NewGuid().ToString("N").Substring(0, 28);
        private Task _creationTask;
        private readonly string _testTable = "TestTable";
        private DatabaseAdminClient _databaseAdminClient;

        public void Dispose() {
            if (_databaseAdminClient != null) {
                _databaseAdminClient.DropDatabase(new DatabaseName(TestProjectName, TestInstanceName, DatabaseName));
            }
        }

        public string TestInstanceName => "myspanner";

        public string TestProjectName => "spanneref";

        public string ConnectionString => "Data Source=" + TestProjectName+ "/" + TestInstanceName+ "/"
                                          + DatabaseName;

        public string DatabaseName => _databaseName;

        public string TestTable => _testTable;

        public async Task<SpannerConnection> GetTestDatabaseConnectionAsync() {
            TaskCompletionSource<int> creationTaskCompletionSource;
            if (_creationTask == null) {
                creationTaskCompletionSource = new TaskCompletionSource<int>();
                if (Interlocked.CompareExchange(ref _creationTask,
                        creationTaskCompletionSource.Task,
                        null) != null) {
                    await _creationTask;
                    return new SpannerConnection(ConnectionString);
                }
            } else {
                await _creationTask;
                return new SpannerConnection(ConnectionString);
            }

            await CreateDatabaseAsync();
            await CreateTableAsync();
            await FillSampleData();
            creationTaskCompletionSource.SetResult(0);
            return new SpannerConnection(ConnectionString);
        }

        private async Task<Database> CreateDatabaseAsync()
        {
            // Create client
            _databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName(TestProjectName, TestInstanceName);

            string createStatement = "CREATE DATABASE " + DatabaseName;

            // Make the request
            var response =
                await _databaseAdminClient.CreateDatabaseAsync(parent, createStatement);

            // Poll until the returned long-running operation is complete
            var completedResponse =
                await response.PollUntilCompletedAsync();

            // Retrieve the operation result
            return completedResponse.Result;
        }
        private async Task CreateTableAsync()
        {
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();

            string createTableStatement = @"CREATE TABLE " + _testTable +" ("
                                          + "  Key                STRING(MAX) NOT NULL,"
                                          + "  StringValue        STRING(MAX),"
                                          + ") PRIMARY KEY (Key)";
            string index1 = "CREATE INDEX TestTableByValue ON TestTable(StringValue)";
            string index2 = "CREATE INDEX TestTableByValueDesc ON TestTable(StringValue DESC)";

            // Make the request
            var response =
                await databaseAdminClient.UpdateDatabaseDdlAsync(new DatabaseName(TestProjectName, TestInstanceName, DatabaseName),
                new[] { createTableStatement });

            // Poll until the returned long-running operation is complete
            await response.PollUntilCompletedAsync();

            response =
                await databaseAdminClient.UpdateDatabaseDdlAsync(new DatabaseName(TestProjectName, TestInstanceName, DatabaseName),
                new[] { index1 });
            await response.PollUntilCompletedAsync();

            response =
                await databaseAdminClient.UpdateDatabaseDdlAsync(new DatabaseName(TestProjectName, TestInstanceName, DatabaseName),
                new[] { index2 });
            await response.PollUntilCompletedAsync();
        }

        public async Task FillSampleData() {
            using (var connection = new SpannerConnection(ConnectionString)) {
                await connection.OpenAsync();
                using (var tx = await connection.BeginTransactionAsync()) {

                    var cmd = connection.CreateInsertCommand(TestTable,
                        new SpannerParameterCollection {
                            {"Key", SpannerDbType.String},
                            {"StringValue", SpannerDbType.String}
                        });
                    cmd.Transaction = tx;

                    for (var i = 0; i < 15; ++i) {
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
