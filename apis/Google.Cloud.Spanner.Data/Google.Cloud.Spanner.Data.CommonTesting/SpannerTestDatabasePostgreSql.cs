// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using System;

namespace Google.Cloud.Spanner.Data.CommonTesting;

/// <summary>
/// A database with PostgreSQL dialect created on-demand for testing. This is never dropped, partly as it's hard to know when to do so.
/// (This may be used by multiple fixtures, each created and then disposed, within the same test run.)
/// </summary>
public sealed class SpannerTestDatabasePostgreSql : SpannerTestDatabaseBase
{
    private static readonly object s_lock = new object();

    private static SpannerTestDatabasePostgreSql s_instance = null;

    /// <summary>
    /// Fetches the PostgreSQL database, creating it if necessary.
    /// </summary>
    /// <param name="projectId">The project ID to use, typically from a fixture.</param>
    public static SpannerTestDatabasePostgreSql Create(string projectId)
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

    /// <inheritdoc/>
    public override string GeneratedDatabaseName => s_generatedDatabaseName;

    /// <inheritdoc/>
    public override string SpannerDatabaseEnvVariable => "TEST_SPANNER_POSTGRESQL_DATABASE";

    /// <summary>
    /// Initializes a new instance of the <see cref="SpannerTestDatabasePostgreSql"/> class.
    /// </summary>
    /// <param name="projectId">The project ID to be used for test database.</param>
    private SpannerTestDatabasePostgreSql(string projectId) : base(projectId, EmulatorDetection.None)
    {
    }

    protected override bool TryCreateDatabase()
    {
        const DatabaseDialect dialect = DatabaseDialect.Postgresql;
        DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
        CreateDatabaseRequest createDatabaseRequest = new CreateDatabaseRequest
        {
            CreateStatement = $"CREATE DATABASE {SpannerDatabase}",
            DatabaseDialect = dialect,
            ParentAsInstanceName = InstanceName.FromProjectInstance(ProjectId, SpannerInstance)
        };

        try
        {
            var operation = databaseAdminClient.CreateDatabase(createDatabaseRequest);
            var completedResponse = operation.PollUntilCompleted();
            if (completedResponse.IsFaulted)
            {
                Logger.DefaultLogger.Debug($"Error while creating database with dialect {dialect}: {completedResponse.Exception}");
                throw completedResponse.Exception;
            }

            Logger.DefaultLogger.Debug($"The database {SpannerDatabase} with dialect {dialect} created successfully.");
            return true;
        }
        catch (RpcException e) when (e.StatusCode == StatusCode.AlreadyExists)
        {
            return false;
        }
    }
}
