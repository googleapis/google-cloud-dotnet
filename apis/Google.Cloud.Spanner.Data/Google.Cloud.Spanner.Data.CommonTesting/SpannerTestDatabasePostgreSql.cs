// Copyright 2022 Google LLC
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using System;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// A database with PostgreSQL dialect created on-demand for testing. This is never dropped, partly as it's hard to know when to do so.
    /// (This may be used by multiple fixtures, each created and then disposed, within the same test run.) 
    /// </summary>
    public class SpannerTestDatabasePostgreSql
    {
        private static readonly object s_lock = new object();
        private static SpannerTestDatabasePostgreSql s_instance = null;

        /// <summary>
        /// Fetches the PostgreSQL database, creating it if necessary.
        /// </summary>
        /// <param name="projectId">The project ID to use, typically from a fixture.</param>
        public static SpannerTestDatabasePostgreSql GetInstance(string projectId)
        {
            lock (s_lock)
            {
                if (s_instance == null)
                {
                    s_instance = new SpannerTestDatabasePostgreSql(projectId);
                }
                else if (s_instance.ProjectId != projectId)
                {
                    throw new ArgumentException($"A PostgreSQL database for project ID {s_instance.ProjectId} has already been created; this test requested {projectId}");
                }
                return s_instance;
            }
        }

        private static readonly string s_generatedDatabaseName = IdGenerator.FromDateTime(prefix: "testdb_pg_", pattern: "yyyyMMdd't'HHmmss");

        public string SpannerHost { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_HOST", null);
        public string SpannerPort { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_PORT", null);
        public string SpannerInstance { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_INSTANCE", "spannerintegration");
        public string SpannerDatabase { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_POSTGRESQL_DATABASE", s_generatedDatabaseName);

        // This is the simplest way of checking whether the environment variable was specified or not.
        // It's a little ugly, but simpler than the alternatives.

        /// <summary>
        /// Returns true if the database was created just for this test, or false if the database was an existing one
        /// specified through an environment variable.
        /// </summary>
        public bool Fresh => SpannerDatabase == s_generatedDatabaseName;

        // Connection string including database, generated from the above properties
        public string ConnectionString { get; }
        // Connection string without the database, generated from the above properties
        public string NoDbConnectionString { get; }
        public string ProjectId { get; }
        public DatabaseName DatabaseName { get; }
        internal SpannerClientCreationOptions SpannerClientCreationOptions { get; }

        private SpannerTestDatabasePostgreSql(string projectId)
        {
            TestLogger.Install();

            ProjectId = projectId;
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
            SpannerClientCreationOptions = new SpannerClientCreationOptions(builder);
            var databaseBuilder = builder.WithDatabase(SpannerDatabase);
            ConnectionString = databaseBuilder.ConnectionString;
            DatabaseName = databaseBuilder.DatabaseName;

            // Assuming that instance already exists.
            if (Fresh)
            {
                CreatePostgreSqlDatabase();
                Logger.DefaultLogger.Debug($"Created database {SpannerDatabase} with PostgreSql dialect.");
            }
            else
            {
                Logger.DefaultLogger.Debug($"Using existing PostgreSql database {SpannerDatabase}");
            }
        }

        private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
        {
            string value = Environment.GetEnvironmentVariable(name);
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }

        private void CreatePostgreSqlDatabase()
        {
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            CreateDatabaseRequest createDatabaseRequest = new CreateDatabaseRequest
            {
                CreateStatement = $"CREATE DATABASE {SpannerDatabase}",
                DatabaseDialect = DatabaseDialect.Postgresql,
                ParentAsInstanceName = InstanceName.FromProjectInstance(ProjectId, SpannerInstance)
            };

            try
            {
                var operation = databaseAdminClient.CreateDatabase(createDatabaseRequest);
                var completedResponse = operation.PollUntilCompleted();
                if (completedResponse.IsFaulted)
                {
                    Console.WriteLine($"Error while creating PostgreSQL database: {completedResponse.Exception}");
                    throw completedResponse.Exception;
                }
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.AlreadyExists)
            {
                // Ignore.
            }
        }

        public SpannerConnection GetConnection() => new SpannerConnection(ConnectionString);

        // Creates a SpannerConnection with a specific logger.
        public SpannerConnection GetConnection(Logger logger, bool logCommitStats = false) =>
            new SpannerConnection(new SpannerConnectionStringBuilder(ConnectionString)
            {
                SessionPoolManager = SessionPoolManager.Create(new V1.SessionPoolOptions(), logger),
                LogCommitStats = logCommitStats
            });
    }
}
