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

using Grpc.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[Collection(nameof(DmlTableFixture))]
public class MutationsTests
{
    private readonly DmlTableFixture _fixture;

    public MutationsTests(DmlTableFixture fixture) => _fixture = fixture;

    [Fact]
    public async Task InsertWithNoParametersAsync()
    {
        using var connection = _fixture.GetConnection();

        using var command = connection.CreateInsertCommand(_fixture.TableName);

        await AssertEmptyMutationsFailAsync(command);
    }

    [Fact]
    public async Task UpdateWithNoParametersAsync()
    {
        using var connection = _fixture.GetConnection();
        using var command = connection.CreateUpdateCommand(_fixture.TableName);

        await AssertEmptyMutationsFailAsync(command);
    }

    [Fact]
    public async Task UpsertWithNoParametersAsync()
    {
        using var connection = _fixture.GetConnection();
        using var command = connection.CreateInsertOrUpdateCommand(_fixture.TableName);

        await AssertEmptyMutationsFailAsync(command);
    }

    private async Task AssertEmptyMutationsFailAsync(SpannerCommand emptyMutation)
    {
        var exception = await Assert.ThrowsAsync<SpannerException>(emptyMutation.ExecuteNonQueryAsync);

        Assert.Equal(StatusCode.InvalidArgument, exception.RpcException.StatusCode);
        // Regression test, before we were sending a list where the first element was an empty ValueList.
        // The command failed as well but with a confusing error message like
        // "the amount of values does not match the number of columns in the key".
        if (!_fixture.RunningOnEmulator) // The message is different on the emulator.
        {
            Assert.Contains("does not specify any value", exception.RpcException.Message);
        }
    }

    [Fact]
    public async Task DeleteWithNoParametersAsync()
    {
        // We need to create our own table here because we are "deleting" with no filters.
        string tableName = $"MutationsTestsDeleteAll{Guid.NewGuid():N}";
        int rowCount = 3;

        using var connection = _fixture.GetConnection();
        await CreateAndPopulateTableAsync();

        using var command = connection.CreateDeleteCommand(tableName);
        await command.ExecuteNonQueryAsync();

        using var read = connection.CreateReadCommand(tableName, ReadOptions.FromColumns("Key"), KeySet.All);
        var reader = await read.ExecuteReaderAsync();
        int actualRowCount = reader.OfType<object>().Count();

        // Deleting with an empty KeySet has no effect.
        Assert.Equal(rowCount, actualRowCount);

        await DeleteTableAsync();

        async Task CreateAndPopulateTableAsync()
        {
            using var createTableCmd = connection.CreateDdlCommand($@"CREATE TABLE {tableName} (
                                            Key                STRING(MAX) NOT NULL,
                                            StringValue        STRING(MAX),
                                          ) PRIMARY KEY (Key)");
            await createTableCmd.ExecuteNonQueryAsync();

            await connection.RunWithRetriableTransactionAsync(async transaction =>
            {
                var cmd = connection.CreateInsertCommand(tableName);
                var keyParameter = cmd.Parameters.Add("Key", SpannerDbType.String);
                var valueParameter = cmd.Parameters.Add("StringValue", SpannerDbType.String);
                cmd.Transaction = transaction;

                for (var i = 0; i < rowCount; ++i)
                {
                    keyParameter.Value = "k" + i;
                    valueParameter.Value = "v" + i;
                    await cmd.ExecuteNonQueryAsync();
                }
            });
        }

        async Task DeleteTableAsync()
        {
            using var deleteTableCmd = connection.CreateDdlCommand($"DROP TABLE {tableName}");
            await deleteTableCmd.ExecuteNonQueryAsync();
        }
    }
}
