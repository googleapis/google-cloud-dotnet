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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.CommonTesting;

/// <summary>
///  Base class for the test fixtures for Cloud Spanner.
/// </summary>
/// <typeparam name="TDatabase">The type of test database that derives from the <see cref="SpannerTestDatabaseBase"/> based on the dialect.</typeparam>
public abstract class CloudSpannerFixtureBase<TDatabase> : CloudProjectFixtureBase where TDatabase : SpannerTestDatabaseBase
{
    // The type of test database derived from the SpannerTestDatabaseBase based on the dialect.
    public TDatabase Database { get; }

    public DatabaseName DatabaseName => Database.DatabaseName;

    public string ConnectionString => Database.ConnectionString;

    public bool RunningOnEmulator => SpannerClientCreationOptions.UsesEmulator;

    internal SpannerClientCreationOptions SpannerClientCreationOptions => Database.SpannerClientCreationOptions;

    protected CloudSpannerFixtureBase(Func<string, TDatabase> databaseFactory) => Database = databaseFactory(ProjectId);

    public SpannerConnection GetConnection(Logger logger = null, bool logCommitStats = false) => Database.GetConnection(logger, logCommitStats);

    public async Task<ManagedSession> GetManagedSession() => await Database.GetManagedSession().ConfigureAwait(false);
}
