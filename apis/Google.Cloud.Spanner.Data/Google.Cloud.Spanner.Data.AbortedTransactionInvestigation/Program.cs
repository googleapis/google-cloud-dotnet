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

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.AbortedTransactionInvestigation
{
    /// <summary>
    /// This is a very crude test harness used to investigate how often transactions are aborted, and what affects it.
    /// </summary>
    class Program
    {
        // Configuration: change these before running the test
        private static bool CreateDatabase { get; } = true;
        private static bool AsyncCreateDatabase { get; } = false;
        private static bool AsyncCreateTable { get; } = false;
        private static bool AsyncInsert { get; } = false;
        private static TimeSpan Delay { get; } = TimeSpan.Zero;
        private static string Database { get; } = CreateDatabase ? $"testdb_{DateTime.UtcNow:yyyyMMdd't'HHmmss}" : "CONFIGURE_THIS";
        private static string ProjectId { get; } = Environment.GetEnvironmentVariable("TEST_PROJECT");
        private static string Table { get; } = $"TestTable{DateTime.UtcNow:HHmmss}";
        private static string InstanceId { get; } = "spannerintegration";
        private static int InsertCount { get; } = 10000;
        private static int LogInsertFrequency { get; } = 1000; // Not a frequency really, but we log every "this many "inserts...

        private static Stopwatch Stopwatch { get; } = Stopwatch.StartNew();
        private static string NoDbConnectionString => $"Data source=projects/{ProjectId}/instances/{InstanceId}";
        private static string ConnectionString => $"{NoDbConnectionString}/databases/{Database}";

        static async Task Main()
        {
            LogConfig();
            await MaybeRunAsync(AsyncCreateDatabase, MaybeCreateDatabaseAsync, MaybeCreateDatabase);
            await MaybeRunAsync(AsyncCreateTable, CreateTableAsync, CreateTable);
            await Task.Delay(Delay);
            await MaybeRunAsync(AsyncInsert, InsertRepeatedlyAsync, InsertRepeatedly);
        }

        static async Task MaybeRunAsync(bool runAsync, Func<Task> asyncAction, Action syncAction)
        {
            if (runAsync)
            {
                await asyncAction();
            }
            else
            {
                syncAction();
            }
        }

        static void LogConfig()
        {
            Log($"Starting test at {DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss}Z");
            Log($"Database: {Database}");
            Log($"New database? {CreateDatabase}");
            Log($"Database creation: {(AsyncCreateDatabase ? "Async" : "Sync")}");
            Log($"Table creation: {(AsyncCreateTable ? "Async" : "Sync")}");
            Log($"Insert: {(AsyncInsert ? "Async" : "Sync")}");
            Log($"Delay: {Delay}");
            Log($"Insert count: {InsertCount}");
            Console.WriteLine();
        }

        static void MaybeCreateDatabase()
        {
            if (CreateDatabase)
            {
                Log($"Creating database {Database}");
                using (var connection = new SpannerConnection(NoDbConnectionString))
                {
                    connection.CreateDdlCommand($"CREATE DATABASE {Database}").ExecuteNonQuery();
                }
            }
        }

        static async Task MaybeCreateDatabaseAsync()
        {
            if (CreateDatabase)
            {
                Log($"Creating database {Database}");
                using (var connection = new SpannerConnection(NoDbConnectionString))
                {
                    await connection.CreateDdlCommand($"CREATE DATABASE {Database}").ExecuteNonQueryAsync();
                }
            }
        }

        static void CreateTable()
        {
            Log($"Creating table {Table}");
            using (var connection = new SpannerConnection(ConnectionString))
            {
                string ddl = $@"CREATE TABLE {Table} (K STRING(MAX) NOT NULL) PRIMARY KEY(K)";
                connection.CreateDdlCommand(ddl).ExecuteNonQuery();
            }
        }

        static async Task CreateTableAsync()
        {
            Log($"Creating table {Table}");
            using (var connection = new SpannerConnection(ConnectionString))
            {
                string ddl = $@"CREATE TABLE {Table} (K STRING(MAX) NOT NULL) PRIMARY KEY(K)";
                await connection.CreateDdlCommand(ddl).ExecuteNonQueryAsync();
            }
        }

        static void InsertRepeatedly()
        {
            int errors = 0;
            for (int i = 0; i < InsertCount; i++)
            {
                if (i % LogInsertFrequency == 0)
                {
                    Log($"Test {i}");
                }
                try
                {
                    using (var connection = new SpannerConnection(ConnectionString))
                    {
                        var cmd = connection.CreateInsertCommand(Table);
                        cmd.Parameters.Add("K", SpannerDbType.String, Guid.NewGuid().ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    Log($"Aborted transaction at test {i}");
                    errors++;
                }
            }
            Log($"Total errors over {InsertCount} insertions: {errors}");
        }

        static async Task InsertRepeatedlyAsync()
        {
            int errors = 0;
            for (int i = 0; i < InsertCount; i++)
            {
                if (i % LogInsertFrequency == 0)
                {
                    Log($"Test {i}");
                }
                try
                {
                    using (var connection = new SpannerConnection(ConnectionString))
                    {
                        var cmd = connection.CreateInsertCommand(Table);
                        cmd.Parameters.Add("K", SpannerDbType.String, Guid.NewGuid().ToString());
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    Log($"Aborted transaction at test {i}");
                    errors++;
                }
            }
            Log($"Total errors over {InsertCount} insertions: {errors}");
        }

        static void Log(string message) =>
            Console.WriteLine($"{Stopwatch.Elapsed:mm':'ss'.'fff}: {message}");
    }
}
