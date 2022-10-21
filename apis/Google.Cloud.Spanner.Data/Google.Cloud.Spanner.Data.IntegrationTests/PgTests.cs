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
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[Collection(nameof(AllTypesTableFixturePostgreSql))]
[CommonTestDiagnostics]
[Trait(Constants.SupportedOnEmulator, Constants.No)]
public class PgTests
{
    private readonly AllTypesTableFixturePostgreSql _fixture;
    private string _lastKey;

    public PgTests(AllTypesTableFixturePostgreSql fixture) =>
        _fixture = fixture;

    private SpannerConnection GetConnection() => _fixture.GetConnection();

    // Binding tests for PostgreSQL specific types. GSQL and common types are tested in the BindingTests.cs.

    [Fact]
    public async Task BindPgNumeric() =>
        await TestBindNonNull(SpannerDbType.PgNumeric, PgNumeric.Parse("1.0"), r => r.GetPgNumeric(0));

    [Fact]
    public async Task BindPgNumericArray() =>
        await TestBindNonNull(SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), new PgNumeric?[] { PgNumeric.Parse("0.0"), null, PgNumeric.Parse("1.0") });

    [Fact]
    public async Task BindPgNumericEmptyArray() =>
        await TestBindNonNull(SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), new PgNumeric[] { });
    
    [Fact]
    public async Task BindPgJson() => await TestBindNonNull(
            SpannerDbType.PgJsonb,
            "{\"key\": \"value\"}",
            r => r.GetString(0));

    private async Task TestBindNonNull<T>(SpannerDbType parameterType, T value, Func<SpannerDataReader, T> typeSpecificReader = null)
    {
        using var connection = GetConnection();
        using var cmd = connection.CreateSelectCommand("SELECT $1");
        cmd.Parameters.Add("p1", parameterType, value);
        using var reader = await cmd.ExecuteReaderAsync();
        await BindingTests.AssertNotNull<T>(reader, value, typeSpecificReader);
    }

    public static TheoryData<SpannerDbType> BindNullData { get; } = new TheoryData<SpannerDbType>
    {
        SpannerDbType.PgNumeric,
        SpannerDbType.PgJsonb,
        SpannerDbType.ArrayOf(SpannerDbType.PgNumeric)
    };

    [Theory]
    [MemberData(nameof(BindNullData))]
    public async Task BindNull(SpannerDbType parameterType)
    {
        using var connection = GetConnection();
        using var cmd = connection.CreateSelectCommand("SELECT $1");
        cmd.Parameters.Add("p1", parameterType, null);
        using var reader = await cmd.ExecuteReaderAsync();
        await BindingTests.AssertNull(reader);
    }

    // Schema Table Tests for PostgreSQL specific types. GSQL and common types are tested in the GetSchemaTableTests.cs

    [MemberData(nameof(SchemaTestData))]
    [Theory]
    public async Task GetSchemaTable_WithFlagEnabled_ReturnsSchema(string columnName, System.Type type, SpannerDbType spannerDbType)
    {
        string selectQuery = $"SELECT \"{columnName}\" FROM {_fixture.TableName}";
        await GetSchemaTableTests.GetSchemaTable_WithFlagEnabled_ReturnsSchema_Impl(columnName, type, spannerDbType, _fixture.ConnectionString, selectQuery);
    }

    public static TheoryData<string, System.Type, SpannerDbType> SchemaTestData { get; } =
        new TheoryData<string, System.Type, SpannerDbType>
        {
            // Base types.
            { "PgNumericValue", typeof(PgNumeric), SpannerDbType.PgNumeric },
            { "PgJsonbValue", typeof(string), SpannerDbType.PgJsonb },
            // Array types.
            { "PgNumericArrayValue", typeof(List<PgNumeric>), SpannerDbType.ArrayOf(SpannerDbType.PgNumeric) }
        };

    // Write Tests for PostgreSQL specific types. GSQL and common types are tested in WriteTests.cs

    [Fact]
    public async Task WriteNulls() =>
        await ExecuteWriteNullsTest(InsertAsync);

    [Fact]
    public async Task WriteValues() =>
        await ExecuteWriteValuesTest(InsertAsync);

    [Fact]
    public async Task WriteEmpties()
    {
        var parameters = new SpannerParameterCollection
            {
                { "PgNumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), new PgNumeric[0] }
            };

        Assert.Equal(1, await InsertAsync(parameters));
        await WriteTests.WithLastRowAsync(reader =>
        {
            Assert.Equal(new PgNumeric[] { }, reader.GetFieldValue<PgNumeric[]>(reader.GetOrdinal("PgNumericArrayValue")));
        }, GetConnection(), GetWriteTestReader);
    }

    private async Task ExecuteWriteNullsTest(Func<SpannerParameterCollection, Task<int>> insertCommand)
    {
        var parameters = new SpannerParameterCollection
            {
                { "PgNumericValue", SpannerDbType.PgNumeric, null },
                { "PgJsonbValue", SpannerDbType.PgJsonb, null },
                { "PgNumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), null }
            };

        Assert.Equal(1, await insertCommand(parameters));
        await WriteTests.WithLastRowAsync(reader =>
        {
            Assert.True(reader.IsDBNull(reader.GetOrdinal("PgNumericValue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("PgJsonbValue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("PgNumericArrayValue")));
        }, GetConnection(), GetWriteTestReader);
    }

    private async Task ExecuteWriteValuesTest(Func<SpannerParameterCollection, Task<int>> insertCommand)
    {
        PgNumeric?[] numericArray = { PgNumeric.Parse("0.0"), null, PgNumeric.Parse("2.0") };
        string jsonbValue = "{\"f1\": \"v1\"}";

        var parameters = new SpannerParameterCollection
        {
            { "PgNumericValue", SpannerDbType.PgNumeric, PgNumeric.Parse("2.0") },
            { "PgJsonbValue", SpannerDbType.PgJsonb, jsonbValue },
            { "PgNumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), numericArray }
        };

        Assert.Equal(1, await insertCommand(parameters));
        await WriteTests.WithLastRowAsync(reader =>
        {
            Assert.Equal(PgNumeric.Parse("2.0"), reader.GetFieldValue<PgNumeric>(reader.GetOrdinal("PgNumericValue")));
            Assert.Equal(jsonbValue, reader.GetFieldValue<string>(reader.GetOrdinal("PgJsonbValue")));
            Assert.Equal(numericArray, reader.GetFieldValue<PgNumeric?[]>(reader.GetOrdinal("PgNumericArrayValue")));
        }, GetConnection(), GetWriteTestReader);
    }

    private async Task<SpannerDataReader> GetWriteTestReader(SpannerConnection connection)
    {
        var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE K=$1");
        command.Parameters.Add("p1", SpannerDbType.String, _lastKey);
        return await command.ExecuteReaderAsync();
    }

    private async Task<int> InsertAsync(SpannerParameterCollection values)
    {
        using var connection = GetConnection();
        values.Add("K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid());
        using var cmd = connection.CreateInsertCommand(_fixture.TableName, values);
        return await cmd.ExecuteNonQueryAsync();
    }
}
