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
using System;

namespace Google.Cloud.Spanner.Data.CommonTesting;

/// <summary>
/// A database with PostgreSQL dialect created on-demand for testing. This is never dropped, partly as it's hard to know when to do so.
/// (This may be used by multiple fixtures, each created and then disposed, within the same test run.)
/// </summary>
public sealed class SpannerTestDatabasePostgreSql : SpannerTestDatabaseBase
{
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

    public override string SpannerDatabase { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_POSTGRESQL_DATABASE", s_generatedDatabaseName);

    // This is the simplest way of checking whether the environment variable was specified or not.
    // It's a little ugly, but simpler than the alternatives.
    /// <inheritdoc/>
    public override bool Fresh => SpannerDatabase == s_generatedDatabaseName;

    private SpannerTestDatabasePostgreSql(string projectId) : base(projectId, DatabaseDialect.Postgresql)
    {
    }
}
