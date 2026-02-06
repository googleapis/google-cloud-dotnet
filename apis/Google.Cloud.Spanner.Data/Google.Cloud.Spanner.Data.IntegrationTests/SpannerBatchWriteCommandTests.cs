// Copyright 2026 Google LLC
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
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

/// <summary>
/// Integration tests for <see cref="SpannerBatchWriteCommand"/>.
/// These tests validate the public ADO.NET-like surface for the Spanner BatchWrite RPC.
/// </summary>
[Collection(nameof(SpannerBatchWriteCommandTableFixture))]
[CommonTestDiagnostics]
public class SpannerBatchWriteCommandTests
{
    private readonly SpannerBatchWriteCommandTableFixture _fixture;

    public SpannerBatchWriteCommandTests(SpannerBatchWriteCommandTableFixture fixture) =>
        _fixture = fixture;

    [Fact]
    public async Task BatchWrite()
    {
        using var connection = _fixture.GetConnection();
        await connection.OpenAsync();

        var command = connection.CreateBatchWriteCommand();

        // BatchWrite executes mutation groups independently.
        // Group 0: Two non-conflicting inserts. If both are valid, the group succeeds.
        command.Add(CreateInsertCommand(connection, "v1"), CreateInsertCommand(connection, "v2"));
        // Group 1: A single insert.
        command.Add(CreateInsertCommand(connection, "v3"));

        var (successes, failures) = await GetResults(command.ExecuteNonQueryAsync());

        // We expect both groups to succeed.
        Assert.Empty(failures);
        Assert.Equivalent(new[] { 0, 1 }, successes);
    }

    [Fact]
    public async Task BatchWrite_VariousTypes()
    {
        var key1 = IdGenerator.FromGuid();
        var key2 = IdGenerator.FromGuid();
        var key3 = IdGenerator.FromGuid();

        using var connection = _fixture.GetConnection();
        await connection.OpenAsync();

        // Preparation: Insert rows that will be target for Update and Delete later in the batch.
        await CreateInsertCommand(connection, key: key2).ExecuteNonQueryAsync();
        await CreateInsertCommand(connection, key: key3).ExecuteNonQueryAsync();

        var command = connection.CreateBatchWriteCommand();

        // Testing that BatchWrite correctly handles different types of write operations.
        // Group 0: A standard Insert of a new row.
        command.Add(CreateInsertCommand(connection, key: key1));

        // Group 1: An Update of an existing row (key2).
        command.Add(connection.CreateUpdateCommand(_fixture.TableName, new SpannerParameterCollection
        {
            { _fixture.KeyName, SpannerDbType.String, key2 },
            { _fixture.ValueName, SpannerDbType.String, "updated" }
        }));

        // Group 2: A Delete of an existing row (key3).
        command.Add(connection.CreateDeleteCommand(_fixture.TableName, new SpannerParameterCollection
        {
            { _fixture.KeyName, SpannerDbType.String, key3 }
        }));

        var (successes, failures) = await GetResults(command.ExecuteNonQueryAsync());

        // We expect 3 successes as we have 3 independent mutation groups (Insert, Update, Delete).
        Assert.Empty(failures);
        Assert.Equivalent(new[] { 0, 1, 2 }, successes);
    }

    [Fact]
    public async Task BatchWrite_Conflict()
    {
        using var connection = _fixture.GetConnection();
        await connection.OpenAsync();

        var command = connection.CreateBatchWriteCommand();
        var cmd = CreateInsertCommand(connection, key: IdGenerator.FromGuid());

        // Testing the independent nature of mutation groups.
        // Group 0: Two identical inserts. This group will fail atomically because
        // you cannot have multiple mutations for the same key in a single group.
        command.Add(cmd, cmd);

        // Group 1: A single valid insert. This should succeed even though Group 0 fails.
        command.Add(CreateInsertCommand(connection));

        var (successes, failures) = await GetResults(command.ExecuteNonQueryAsync());

        // We expect Group 0 to fail and Group 1 to succeed.
        Assert.Equivalent(new[] { 0 }, failures);
        Assert.Equivalent(new[] { 1 }, successes);
    }

    [Fact]
    public async Task BatchWrite_AddEnumerable()
    {
        using var connection = _fixture.GetConnection();
        await connection.OpenAsync();

        var command = connection.CreateBatchWriteCommand();

        var commands = new List<SpannerCommand>
        {
            CreateInsertCommand(connection),
            CreateInsertCommand(connection)
        };

        // Validates the overload that adds a collection of commands as a single atomic group.
        // Group 0: Two commands added as a collection.
        command.Add(commands);

        var (successes, failures) = await GetResults(command.ExecuteNonQueryAsync());

        // One group was added, so we expect index 0 to succeed.
        Assert.Empty(failures);
        Assert.Equivalent(new[] { 0 }, successes);
    }

    [Fact]
    public void BatchWrite_UnsupportedCommandType_Throws()
    {
        using var connection = _fixture.GetConnection();
        var command = connection.CreateBatchWriteCommand();

        // SELECT is not a write operation and is not supported by the BatchWrite RPC.
        var selectCommand = connection.CreateSelectCommand("SELECT 1");

        var exception = Assert.Throws<InvalidOperationException>(() => command.Add(selectCommand));
        Assert.Contains("not supported in BatchWrite", exception.Message);
    }

    /// <summary>
    /// Helper to create an insert command with a unique key.
    /// </summary>
    private SpannerCommand CreateInsertCommand(SpannerConnection connection, string key = null, string value = null) =>
        connection.CreateInsertCommand(_fixture.TableName, new SpannerParameterCollection
        {
            { _fixture.KeyName, SpannerDbType.String, key ?? IdGenerator.FromGuid() },
            { _fixture.ValueName, SpannerDbType.String, value ?? "v" }
        });

    /// <summary>
    /// Helper to aggregate the indexes of successes and failures from the BatchWrite response stream.
    /// Each index corresponds to the 0-based position of the mutation group in the request.
    /// </summary>
    private static async Task<(List<int> successes, List<int> failures)> GetResults(IAsyncEnumerable<SpannerBatchWriteCommand.BatchWriteResult> responseStream)
    {
        var successes = new List<int>();
        var failures = new List<int>();
        await foreach (var response in responseStream)
        {
            if (response.Status.Code == 0)
            {
                successes.AddRange(response.Indexes);
            }
            else
            {
                failures.AddRange(response.Indexes);
            }
        }
        successes.Sort();
        failures.Sort();
        return (successes, failures);
    }
}

/// <summary>
/// Fixture used to create and maintain the table used for BatchWrite integration tests.
/// </summary>
[CollectionDefinition(nameof(SpannerBatchWriteCommandTableFixture))]
public class SpannerBatchWriteCommandTableFixture : SpannerTableFixture, ICollectionFixture<SpannerBatchWriteCommandTableFixture>
{
    public readonly string KeyName = "Key";
    public readonly string ValueName = "Value";

    public SpannerBatchWriteCommandTableFixture() : base("SpannerBatchWrite")
    {
    }

    protected override void CreateTable()
    {
        ExecuteDdl($@"CREATE TABLE {TableName} (
                     {KeyName} STRING(256),
                     {ValueName} STRING(256),
                   ) PRIMARY KEY ({KeyName})");
    }

    protected override void PopulateTable(bool fresh)
    {
        // The BatchWrite tests manage their own data to ensures isolation and predictable results
        // for atomicity and conflict scenarios.
    }
}