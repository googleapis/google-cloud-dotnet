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

namespace Google.Cloud.Spanner.Data.AbortedTransactionInvestigation
{
    /// <summary>
    /// This is a very crude test harness used to investigate how often transactions are aborted, and what affects it.
    /// </summary>
    class Program
    {
        // Configuration: change these before running the test
        private static bool CreateDatabase { get; } = true;
        private static TimeSpan Delay { get; } = TimeSpan.Zero;
        private static string Database { get; } = CreateDatabase ? $"testdb_{DateTime.UtcNow:yyyyMMdd't'HHmmss}" : "CONFIGURE_THIS";
        private static string ProjectId { get; } = Environment.GetEnvironmentVariable("TEST_PROJECT");
        private static string InstanceId { get; } = "spannerintegration";

        private static Stopwatch Stopwatch { get; } = Stopwatch.StartNew();
        private static string NoDbConnectionString => $"Data source=projects/{ProjectId}/instances/{InstanceId}";
        private static string ConnectionString => $"{NoDbConnectionString}/databases/{Database}";

        static void Main()
        {
            LogConfig();
            MaybeCreateDatabase();
            Thread.Sleep(Delay);
            string table = $"TestTable{DateTime.UtcNow:HHmmss}";

            CreateTable(table);
            InsertRepeatedly(table);
        }

        static void LogConfig()
        {
            Log($"Starting test at {DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss}Z");
            Log($"Database: {Database}");
            Log($"New database? {CreateDatabase}");
            Log($"Delay: {Delay}");
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

        static void CreateTable(string table)
        {
            Log($"Creating table {table}");
            using (var connection = new SpannerConnection(ConnectionString))
            {
                string ddl = $@"CREATE TABLE {table} (K STRING(MAX) NOT NULL) PRIMARY KEY(K)";
                connection.CreateDdlCommand(ddl).ExecuteNonQuery();
            }
        }

        static void InsertRepeatedly(string table)
        {
            // Execute 10001 tests so that we log the end as well.
            for (int i = 0; i < 10001; i++)
            {
                if (i % 1000 == 0)
                {
                    Log($"Test {i}");
                }
                try
                {
                    using (var connection = new SpannerConnection(ConnectionString))
                    {
                        var cmd = connection.CreateInsertCommand(table);
                        cmd.Parameters.Add("K", SpannerDbType.String, Guid.NewGuid().ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    Log($"Aborted transaction at test {i}");
                }
            }
        }

        static void Log(string message) =>
            Console.WriteLine($"{Stopwatch.Elapsed:mm':'ss'.'fff}: {message}");
    }
}
