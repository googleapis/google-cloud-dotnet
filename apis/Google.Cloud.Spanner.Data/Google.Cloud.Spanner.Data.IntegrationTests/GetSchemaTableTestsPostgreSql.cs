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

using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[Collection(nameof(AllTypesTableFixturePostgreSql))]
[CommonTestDiagnostics]
[Trait(Constants.Category, Constants.GSQL)]
[Trait(Constants.SkipOnEmulator, Constants.Yes)]
public class GetSchemaTableTestsPostgreSql
{
    private readonly AllTypesTableFixturePostgreSql _fixture;

    public GetSchemaTableTestsPostgreSql(AllTypesTableFixturePostgreSql fixture) =>
        _fixture = fixture;

    [Fact]
    public async Task GetSchemaTable_Default_ReturnsNull()
    {
        using var connection = _fixture.GetConnection();
        var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");
        using var reader = await command.ExecuteReaderAsync();
        Assert.Null(reader.GetSchemaTable());
    }

    [MemberData(nameof(SchemaTestData))]
    [Theory]
    public async Task GetSchemaTable_WithFlagEnabled_ReturnsSchema(string columnName, System.Type type, SpannerDbType spannerDbType)
    {
        using var connection = new SpannerConnection($"{_fixture.ConnectionString};EnableGetSchemaTable=true");
        var command = connection.CreateSelectCommand($"SELECT {columnName} FROM {_fixture.TableName}");
        using var reader = await command.ExecuteReaderAsync();
        var table = reader.GetSchemaTable();
        Assert.Equal(1, table.Rows.Count);

        var row = table.Rows[0];
        Assert.Equal(columnName, (string) row["ColumnName"]);
        Assert.Equal(0, (int) row["ColumnOrdinal"]);
        Assert.Equal(type, row["DataType"]);
        Assert.Equal(spannerDbType, (SpannerDbType) row["ProviderType"]);
        // These fields are (currently) not filled as Spanner does not provided enough
        // information to fill them.
        Assert.True(row.IsNull("ColumnSize"));
        Assert.True(row.IsNull("NumericPrecision"));
        Assert.True(row.IsNull("NumericScale"));
    }

    public static TheoryData<string, System.Type, SpannerDbType> SchemaTestData { get; } =
        new TheoryData<string, System.Type, SpannerDbType>
        {
            // Base types.
            { "bigintvalue", typeof(long), SpannerDbType.Int64 },
            { "boolvalue", typeof(bool), SpannerDbType.Bool },
            { "floatvalue", typeof(double), SpannerDbType.Float64 },
            { "stringvalue", typeof(string), SpannerDbType.String },
            { "pgnumericvalue", typeof(PgNumeric), SpannerDbType.PgNumeric },
            { "bytesvalue", typeof(byte[]), SpannerDbType.Bytes },
            { "timestampvalue", typeof(DateTime), SpannerDbType.Timestamp },
            { "datevalue", typeof(DateTime), SpannerDbType.Date },            
            // Array types.
            { "boolarrayvalue", typeof(List<bool>), SpannerDbType.ArrayOf(SpannerDbType.Bool) },
            { "bigintarrayvalue", typeof(List<long>), SpannerDbType.ArrayOf(SpannerDbType.Int64) },
            { "floatarrayvalue", typeof(List<double>), SpannerDbType.ArrayOf(SpannerDbType.Float64) },
            { "pgnumericarrayvalue", typeof(List<PgNumeric>), SpannerDbType.ArrayOf(SpannerDbType.PgNumeric) },
            { "stringarrayvalue", typeof(List<string>), SpannerDbType.ArrayOf(SpannerDbType.String) },
            { "bytesarrayvalue", typeof(List<byte[]>), SpannerDbType.ArrayOf(SpannerDbType.Bytes) },
            { "base64arrayvalue", typeof(List<byte[]>), SpannerDbType.ArrayOf(SpannerDbType.Bytes) },
            { "timestamparrayvalue", typeof(List<DateTime>), SpannerDbType.ArrayOf(SpannerDbType.Timestamp) },
            { "datearrayvalue", typeof(List<DateTime>), SpannerDbType.ArrayOf(SpannerDbType.Date) },
            //{ "JsonbValue", typeof(string), SpannerDbType.PgJsonb },
            //{ "JsonbArrayValue", typeof(List<string>), SpannerDbType.ArrayOf(SpannerDbType.PgJsonb) },
        };

    [Fact]
    public async Task GetSchemaTable_WithFlagEnabled_ReturnsColumnOrdinals()
    {
        using var connection = new SpannerConnection($"{_fixture.ConnectionString};EnableGetSchemaTable=true");
        var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");
        using var reader = await command.ExecuteReaderAsync();
        var table = reader.GetSchemaTable();
        // The table also contains the `K` column that is the primary key.
        var expectedRowCount = SchemaTestData.Count() + 1;
        Assert.Equal(expectedRowCount, table.Rows.Count);
        for (var ordinal = 1; ordinal < expectedRowCount; ordinal++)
        {
            var row = table.Rows[ordinal];
            Assert.Equal(ordinal, (int) row["ColumnOrdinal"]);
        }
    }
}
