// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.Data.IntegrationTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;

namespace Google.Cloud.Spanner.V1.IntegrationTests;

[Collection(nameof(DmlTableFixture))]
[CommonTestDiagnostics]
public class ManagedSessionIntegrationTests
{
    private readonly DmlTableFixture _fixture;
    private readonly string _tableName;

    public ManagedSessionIntegrationTests(DmlTableFixture fixture)
    {
        _fixture = fixture;
        _tableName = fixture.TableName;
    }

    private async Task<ManagedSession> CreateManagedSessionAsync()
    {
        var client = await _fixture.SpannerClientCreationOptions.CreateSpannerClientAsync(new SpannerSettings());
        var databaseName = _fixture.DatabaseName;
        var options = ManagedSessionOptions.Create(databaseName, client);
        return new ManagedSession(options);
    }

    [Fact]
    public async Task BasicReadWriteCycle()
    {
        var managedSession = await CreateManagedSessionAsync();
        string key = Guid.NewGuid().ToString();

        // 1. Begin RW Transaction
        await using var transaction = await managedSession.BeginTransactionAsync(new TransactionOptions { ReadWrite = new() }, false, false, CancellationToken.None);

        // 2. Insert row
        var insertRequest = new ExecuteSqlRequest
        {
            Sql = $"INSERT INTO {_tableName} (Key, OriginalValue, Value) VALUES (@key, 1, 1)",
            Params = new Protobuf.WellKnownTypes.Struct
            {
                Fields = { { "key", Protobuf.WellKnownTypes.Value.ForString(key) } }
            }
        };
        await transaction.ExecuteSqlAsync(insertRequest, null);

        // 3. Commit
        await transaction.CommitAsync(new CommitRequest(), null);

        // 4. Verify data via standard SpannerConnection
        using var connection = _fixture.GetConnection();
        using var cmd = connection.CreateSelectCommand($"SELECT Value FROM {_tableName} WHERE Key=@key");
        cmd.Parameters.Add("key", SpannerDbType.String, key);
        var value = await cmd.ExecuteScalarAsync();
        Assert.Equal(1L, value);
    }

    [Fact]
    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    public async Task ConcurrentTransactions_Multiplexing()
    {
        var managedSession = await CreateManagedSessionAsync();
        int concurrency = 5;
        var tasks = Enumerable.Range(0, concurrency).Select(i => RunTransactionAsync(i)).ToList();

        await Task.WhenAll(tasks);

        async Task RunTransactionAsync(int index)
        {
            string key = $"mux-{Guid.NewGuid()}-{index}";
            
            // Start a new transaction on the SAME managed session
            await using var transaction = await managedSession.BeginTransactionAsync(new TransactionOptions { ReadWrite = new() }, false, false, CancellationToken.None);

            // Execute some SQL
            var insertRequest = new ExecuteSqlRequest
            {
                Sql = $"INSERT INTO {_tableName} (Key, OriginalValue, Value) VALUES (@key, 1, @val)",
                Params = new Protobuf.WellKnownTypes.Struct
                {
                    Fields = 
                    { 
                        { "key", Protobuf.WellKnownTypes.Value.ForString(key) },
                        { "val", Protobuf.WellKnownTypes.Value.ForString(index.ToString()) }
                    }
                }
            };
            await transaction.ExecuteSqlAsync(insertRequest, null);

            // Commit
            await transaction.CommitAsync(new CommitRequest(), null);

            // Verify
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateSelectCommand($"SELECT Value FROM {_tableName} WHERE Key=@key");
            cmd.Parameters.Add("key", SpannerDbType.String, key);
            var value = await cmd.ExecuteScalarAsync();
            Assert.Equal((long)index, value);
        }
    }

    [Fact]
    public async Task BatchDml()
    {
        var managedSession = await CreateManagedSessionAsync();
        string key1 = Guid.NewGuid().ToString();
        string key2 = Guid.NewGuid().ToString();

        await using var transaction = await managedSession.BeginTransactionAsync(new TransactionOptions { ReadWrite = new() }, false, false, CancellationToken.None);

        var batchRequest = new ExecuteBatchDmlRequest
        {
            Statements = 
            {
                new ExecuteBatchDmlRequest.Types.Statement 
                { 
                    Sql = $"INSERT INTO {_tableName} (Key, OriginalValue, Value) VALUES (@key, 1, 10)",
                    Params = new Protobuf.WellKnownTypes.Struct { Fields = { { "key", Protobuf.WellKnownTypes.Value.ForString(key1) } } }
                },
                new ExecuteBatchDmlRequest.Types.Statement 
                { 
                    Sql = $"INSERT INTO {_tableName} (Key, OriginalValue, Value) VALUES (@key, 1, 20)",
                    Params = new Protobuf.WellKnownTypes.Struct { Fields = { { "key", Protobuf.WellKnownTypes.Value.ForString(key2) } } }
                }
            }
        };

        var response = await transaction.ExecuteBatchDmlAsync(batchRequest, null);
        Assert.Equal(2, response.ResultSets.Count);

        await transaction.CommitAsync(new CommitRequest(), null);

        // Verify
        using var connection = _fixture.GetConnection();
        using var cmd = connection.CreateSelectCommand($"SELECT SUM(Value) FROM {_tableName} WHERE Key IN (@k1, @k2)");
        cmd.Parameters.Add("k1", SpannerDbType.String, key1);
        cmd.Parameters.Add("k2", SpannerDbType.String, key2);
        var sum = await cmd.ExecuteScalarAsync();
        Assert.Equal(30L, sum);
    }

    [Fact]
    public async Task StreamingRead()
    {
        var managedSession = await CreateManagedSessionAsync();
        string key = Guid.NewGuid().ToString();

        // 1. Setup data
        await using (var transaction = await managedSession.BeginTransactionAsync(new TransactionOptions { ReadWrite = new() }, false, false, CancellationToken.None))
        {
            await transaction.ExecuteSqlAsync(new ExecuteSqlRequest { Sql = $"INSERT INTO {_tableName} (Key, OriginalValue, Value) VALUES (@key, 1, 100)" , Params = new Protobuf.WellKnownTypes.Struct { Fields = { { "key", Protobuf.WellKnownTypes.Value.ForString(key) } } }}, null);
            await transaction.CommitAsync(new CommitRequest(), null);
        }

        // 2. Stream read back in a ReadOnly transaction
        await using (var transaction = await managedSession.BeginTransactionAsync(new TransactionOptions { ReadOnly = new() }, false, false, CancellationToken.None))
        {
            var reader = transaction.ExecuteSqlStreamReader(new ExecuteSqlRequest
            {
                Sql = $"SELECT Value FROM {_tableName} WHERE Key = @key",
                Params = new Protobuf.WellKnownTypes.Struct { Fields = { { "key", Protobuf.WellKnownTypes.Value.ForString(key) } } }
            }, null);

            var values = new List<long>();
            Protobuf.WellKnownTypes.Value value;
            while ((value = await reader.NextAsync(CancellationToken.None)) != null)
            {
                values.Add(long.Parse(value.StringValue));
            }

            Assert.Single(values);
            Assert.Equal(100L, values[0]);
        }
    }

    [Fact]
    public async Task BatchWrite()
    {
        var managedSession = await CreateManagedSessionAsync();
        string key1 = Guid.NewGuid().ToString();
        string key2 = Guid.NewGuid().ToString();

        var request = new BatchWriteRequest
        {
            MutationGroups = 
            {
                new BatchWriteRequest.Types.MutationGroup 
                { 
                    Mutations = { new Mutation { Insert = new Mutation.Types.Write { Table = _tableName, Columns = { "Key", "OriginalValue", "Value" }, Values = { new Protobuf.WellKnownTypes.ListValue { Values = { Protobuf.WellKnownTypes.Value.ForString(key1), Protobuf.WellKnownTypes.Value.ForString("1"), Protobuf.WellKnownTypes.Value.ForString("100") } } } } } }
                },
                new BatchWriteRequest.Types.MutationGroup 
                { 
                    Mutations = { new Mutation { Insert = new Mutation.Types.Write { Table = _tableName, Columns = { "Key", "OriginalValue", "Value" }, Values = { new Protobuf.WellKnownTypes.ListValue { Values = { Protobuf.WellKnownTypes.Value.ForString(key2), Protobuf.WellKnownTypes.Value.ForString("1"), Protobuf.WellKnownTypes.Value.ForString("200") } } } } } }
                }
            }
        };

        var responseStream = await managedSession.BatchWriteAsync(request, null);
        var responses = new List<BatchWriteResponse>();
        while (await responseStream.MoveNextAsync(CancellationToken.None))
        {
            responses.Add(responseStream.Current);
        }

        // Note: BatchWrite status check depends on backend, but we expect successes for these inserts.
        Assert.NotEmpty(responses);
        foreach (var resp in responses)
        {
            Assert.Equal(0, resp.Status.Code); // OK
        }

        // Verify data
        using var connection = _fixture.GetConnection();
        using var cmd = connection.CreateSelectCommand($"SELECT SUM(Value) FROM {_tableName} WHERE Key IN (@k1, @k2)");
        cmd.Parameters.Add("k1", SpannerDbType.String, key1);
        cmd.Parameters.Add("k2", SpannerDbType.String, key2);
        var sum = await cmd.ExecuteScalarAsync();
        Assert.Equal(300L, sum);
    }
}
