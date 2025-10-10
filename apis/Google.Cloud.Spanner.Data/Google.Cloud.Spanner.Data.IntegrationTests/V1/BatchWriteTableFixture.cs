// Copyright 2025 Google LLC
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

using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.V1;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[CollectionDefinition(nameof(BatchWriteTableFixture))]
public class BatchWriteTableFixture : CommonDataTableFixture, ICollectionFixture<BatchWriteTableFixture>, IAsyncLifetime
{
    private const int TimeoutSeconds = 60;
    private SessionPoolManager _poolManager;
    private SessionPool _pool;

    /// <summary>
    /// The name of the key column in the table.
    /// </summary>
    public readonly string KeyName = "Key";

    public BatchWriteTableFixture() : base("BatchWrite")
    {
    }

    /// <inheritdoc/>
    protected override void CreateTable()
    {
        ExecuteDdl($@"CREATE TABLE {this.TableName} (
                     {this.KeyName} STRING(256),
                   ) PRIMARY KEY ({this.KeyName})");
    }

    /// <inheritdoc/>
    protected override void PopulateTable(bool fresh)
    {
        // Do nothing. The BatchWriteTests don't need pre-populated data.
    }

    /// <summary>
    /// Initializes the session pool for the fixture.
    /// </summary>
    public async Task InitializeAsync()
    {
        _poolManager = SessionPoolManager.Create(new SessionPoolOptions());
        _pool = await _poolManager.AcquireSessionPoolAsync(SpannerClientCreationOptions);
    }

    public Task<PooledSession> GetPooledSessionAsync(TransactionOptions transactionOptions = default) =>
        _pool.AcquireSessionAsync(DatabaseName, transactionOptions ?? new TransactionOptions(), CancellationToken.None);

    /// <summary>
    /// Gets the call settings used to interact with the database.
    /// </summary>
    public CallSettings GetCallSettings()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(TimeoutSeconds));
        using SpannerConnection connection = GetConnection();
        return connection.CreateCallSettings(settings => settings.BatchWriteSettings, TimeoutSeconds, cts.Token);
    }

    /// <inheritdoc/>
    public Task DisposeAsync()
    {
        _poolManager.Release(_pool);
        return Task.CompletedTask;
    }
}
