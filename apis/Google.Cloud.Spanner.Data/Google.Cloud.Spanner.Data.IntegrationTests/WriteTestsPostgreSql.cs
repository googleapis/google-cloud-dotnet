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
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[Collection(nameof(AllTypesTableFixturePostgreSql))]
[CommonTestDiagnostics]
public class WriteTestsPostgreSql
{
    private readonly AllTypesTableFixturePostgreSql _fixture;
    private string _lastKey;

    public WriteTestsPostgreSql(AllTypesTableFixturePostgreSql fixture) =>
        _fixture = fixture;

    private Task<int> InsertAsync(string name, SpannerDbType type, object value) =>
        InsertAsync(new SpannerParameterCollection { { name, type, value } });

    private async Task<int> InsertAsync(SpannerParameterCollection values)
    {
        using var connection = _fixture.GetConnection();
        _ = values.Add("K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid());
        var cmd = connection.CreateInsertCommand(_fixture.TableName, values);
        return await cmd.ExecuteNonQueryAsyncWithRetry();
    }

    private async Task InsertAndRecordBytesAsync(byte[] bytes, IDictionary<string, byte[]> record)
    {
        Assert.Equal(1, await InsertAsync("BytesValue", SpannerDbType.Bytes, bytes));
        record[_lastKey] = bytes;
    }

    private async Task WithLastRowAsync(Action<SpannerDataReader> readerAction)
    {
        using var connection = _fixture.GetConnection();
        var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE K=$1");
        _ = cmd.Parameters.Add("p1", SpannerDbType.String, _lastKey);
        using var reader = await cmd.ExecuteReaderAsync();
        Assert.True(await reader.ReadAsync());
        readerAction(reader);
    }

    private async Task ExecuteWriteNullsTest(Func<SpannerParameterCollection, Task<int>> insertCommand, bool isDml)
    {
        var parameters = new SpannerParameterCollection
            {
                { isDml ? "p2" : "BigIntValue", SpannerDbType.Int64, null },
                { isDml ? "p3" : "BoolValue", SpannerDbType.Bool, null },
                { isDml ? "p4" : "FloatValue", SpannerDbType.Float64, null },
                { isDml ? "p5" : "StringValue", SpannerDbType.String, null },
                { isDml ? "p6" : "PgNumericValue", SpannerDbType.PgNumeric, null },
                { isDml ? "p7" : "BytesValue", SpannerDbType.Bytes, null },
                { isDml ? "p8" : "TimestampValue", SpannerDbType.Timestamp, null },
                { isDml ? "p9" : "DateValue", SpannerDbType.Date, null },
                { isDml ? "p10" : "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), null },
                { isDml ? "p11" : "BigIntArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), null },
                { isDml ? "p12" : "FloatArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), null },
                { isDml ? "p13" : "PgNumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), null },
                { isDml ? "p14" : "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), null },
                { isDml ? "p15" : "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), null },
                { isDml ? "p16" : "Base64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), null },
                { isDml ? "p17" : "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), null },
                { isDml ? "p18" : "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), null }
                //{ isDml ? "p19" : "JsonbValue", SpannerDbType.PgJsonb, null },
                //{ isDml ? "p20" : "JsonbArrayValue", SpannerDbType.ArrayOf(SpannerDbType.PgJsonb), null }
            };

        Assert.Equal(1, await insertCommand(parameters));
        await WithLastRowAsync(reader =>
        {
            Assert.True(reader.IsDBNull(reader.GetOrdinal("bigintvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("boolvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("floatvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("stringvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("pgnumericvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("bytesvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("timestampvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("datevalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("boolarrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("bigintarrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("floatarrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("pgnumericarrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("stringarrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("base64arrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("bytesarrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("timestamparrayvalue")));
            Assert.True(reader.IsDBNull(reader.GetOrdinal("datearrayvalue")));
            //Assert.True(reader.IsDBNull(reader.GetOrdinal("jsonbvalue")));
            //Assert.True(reader.IsDBNull(reader.GetOrdinal("jsonbarrayvalue")));
        });
    }

    private async Task ExecuteWriteValuesTest(Func<SpannerParameterCollection, Task<int>> insertCommand, bool isDml)
    {
        var testTimestamp = new DateTime(2022, 3, 17, 15, 30, 0);
        var testDate = new DateTime(2022, 5, 9);
        bool?[] boolArray = { true, null, false };
        long?[] longArray = { 0, null, 1 };
        double?[] doubleArray = { 0.0, null, 2.0 };
        PgNumeric?[] numericArray = { PgNumeric.Parse("0.0"), null, PgNumeric.Parse("2.0") };
        string[] jsonArray = { "{\"f1\":\"v1\"}", "{}", "[]", null };
        string[] stringArray = { "abs", null, "123" };
        string[] base64Array =
        {
            Convert.ToBase64String(new byte[] {0, 1, 2}),
            null,
            Convert.ToBase64String(new byte[] {1, 2, 3})
        };
        byte[][] byteArray =
        {
             new byte[] {0, 1, 2},
             null,
             new byte[] {1, 2, 3}
        };

        DateTime?[] dateArray = { new DateTime(2022, 3, 17), null, new DateTime(2022, 5, 9) };
        DateTime?[] dateTimeArray = { new DateTime(2022, 3, 17, 5, 30, 0), null, new DateTime(2022, 5, 9, 12, 45, 0) };

        var parameters = new SpannerParameterCollection
            {
                { isDml ? "p2" : "BigIntValue", SpannerDbType.Int64, 1 },
                { isDml ? "p3" : "BoolValue", SpannerDbType.Bool, true },
                { isDml ? "p4" : "FloatValue", SpannerDbType.Float64, 2.0 },
                { isDml ? "p5" : "StringValue", SpannerDbType.String, "abc" },
                { isDml ? "p6" : "PgNumericValue", SpannerDbType.PgNumeric, PgNumeric.Parse("2.0") },
                { isDml ? "p7" : "BytesValue", SpannerDbType.Bytes, new byte[] { 4, 5, 6 } },
                { isDml ? "p8" : "TimestampValue", SpannerDbType.Timestamp, testTimestamp },
                { isDml ? "p9" : "DateValue", SpannerDbType.Date, testDate },
                { isDml ? "p10" : "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), boolArray },
                { isDml ? "p11" : "BigIntArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), longArray },
                { isDml ? "p12" : "FloatArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), doubleArray },
                { isDml ? "p13" : "PgNumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.PgNumeric), numericArray },
                { isDml ? "p14" : "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), stringArray },
                { isDml ? "p15" : "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), byteArray },
                { isDml ? "p16" : "Base64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), base64Array },
                { isDml ? "p17" : "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), dateTimeArray },
                { isDml ? "p18" : "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), dateArray }
                //{ isDml ? "p19" : "JsonbValue", SpannerDbType.PgJsonb, "{\"f1\":\"v1\"}" },
                //{ isDml ? "p20" : "JsonbArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), jsonArray }
            };

        Assert.Equal(1, await insertCommand(parameters));
        await WithLastRowAsync(reader =>
        {
            Assert.Equal(1, reader.GetFieldValue<long>(reader.GetOrdinal("bigintvalue")));
            Assert.True(reader.GetFieldValue<bool>(reader.GetOrdinal("boolvalue")));
            Assert.Equal(2.0, reader.GetFieldValue<double>(reader.GetOrdinal("floatvalue")), 1);
            Assert.Equal("abc", reader.GetFieldValue<string>(reader.GetOrdinal("stringvalue")));
            Assert.Equal(PgNumeric.Parse("2.0"), reader.GetFieldValue<PgNumeric>(reader.GetOrdinal("pgnumericvalue")));
            Assert.Equal(new byte[] { 4, 5, 6 }, reader.GetFieldValue<byte[]>(reader.GetOrdinal("bytesvalue")));
            long length = reader.GetBytes(reader.GetOrdinal("bytesvalue"), 0L, null, 0, int.MaxValue);
            Assert.Equal(3L, length);
            var buffer = new byte[length];
            Assert.Equal(3, reader.GetBytes(reader.GetOrdinal("bytesvalue"), 0L, buffer, 0, (int) length));
            Assert.Equal(testTimestamp, reader.GetFieldValue<DateTime>(reader.GetOrdinal("timestampvalue")));
            Assert.Equal(testDate, reader.GetFieldValue<DateTime>(reader.GetOrdinal("datevalue")));
            Assert.Equal(boolArray, reader.GetFieldValue<bool?[]>(reader.GetOrdinal("boolarrayvalue")));
            Assert.Equal(longArray, reader.GetFieldValue<long?[]>(reader.GetOrdinal("bigintarrayvalue")));
            Assert.Equal(doubleArray, reader.GetFieldValue<double?[]>(reader.GetOrdinal("floatarrayvalue")));
            Assert.Equal(numericArray, reader.GetFieldValue<PgNumeric?[]>(reader.GetOrdinal("pgnumericarrayvalue")));
            Assert.Equal(stringArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("stringarrayvalue")));
            Assert.Equal(byteArray, reader.GetFieldValue<byte[][]>(reader.GetOrdinal("bytesarrayvalue")));
            Assert.Equal(base64Array, reader.GetFieldValue<string[]>(reader.GetOrdinal("base64arrayvalue")));
            Assert.Equal(dateTimeArray, reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("timestamparrayvalue")));
            Assert.Equal(dateArray, reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("datearrayvalue")));
            //Assert.Equal("{\"f1\":\"v1\"}", reader.GetFieldValue<string>(reader.GetOrdinal("jsonbvalue")));
            //Assert.Equal(jsonArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("jsonbarrayvalue")));
        });
    }
    
    [Fact]
    public async Task WriteValues() =>
        await ExecuteWriteValuesTest(InsertAsync, false);

    [Fact]
    public async Task WriteValuesDml() =>
        await ExecuteWriteValuesTest(InsertDmlAsync, true);

    private async Task<int> InsertDmlAsync(SpannerParameterCollection values)
    {
        using var connection = _fixture.GetConnection();
        values.Insert(0, new SpannerParameter("p1", SpannerDbType.String, _lastKey = IdGenerator.FromGuid()));
        SpannerCommand cmd = connection.CreateDmlCommand(_fixture.CreateInsertCommand(), values);
        return await cmd.ExecuteNonQueryAsync();
    }

    [Fact]
    public async Task BadColumnName()
    {
        using var connection = _fixture.GetConnection();
        var cmd = connection.CreateInsertCommand(_fixture.TableName);
        cmd.Parameters.Add("badjuju", SpannerDbType.String, IdGenerator.FromGuid());
        var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
        Logger.DefaultLogger.Debug($"BadColumnName: Caught error code: {e.ErrorCode}");
        Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
        Assert.False(e.IsTransientSpannerFault());
    }

    [Fact]
    public async Task BadColumnType()
    {
        using var connection = _fixture.GetConnection();
        var cmd = connection.CreateInsertCommand(_fixture.TableName);
        cmd.Parameters.Add("K", SpannerDbType.Float64, 0.1);
        var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
        Logger.DefaultLogger.Debug($"BadColumnType: Caught error code: {e.ErrorCode}");
        Assert.Equal(ErrorCode.FailedPrecondition, e.ErrorCode);
        Assert.False(e.IsTransientSpannerFault());
    }

    [Fact]
    public async Task BadTableName()
    {
        using var connection = _fixture.GetConnection();
        var cmd = connection.CreateInsertCommand("badjuju");
        cmd.Parameters.Add("K", SpannerDbType.String, IdGenerator.FromGuid());
        var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
        Logger.DefaultLogger.Debug($"BadTableName: Caught error code: {e.ErrorCode}");
        Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
        Assert.False(e.IsTransientSpannerFault());
    }

    [Fact]
    public async Task WriteEmpties()
    {
        var parameters = new SpannerParameterCollection
            {
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), new bool[0] },
                { "BigIntArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), new long[0] },
                { "FloatArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), new double[0] },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), new string[0] },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), new byte[0][] },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), new DateTime[0] },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), new DateTime[0] },
                { "PgNumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), new SpannerNumeric[0] }
                //{ "JsonbArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), new string[0] }
            };

        Assert.Equal(1, await InsertAsync(parameters));
        await WithLastRowAsync(reader =>
        {
            Assert.Equal(new bool[] { }, reader.GetFieldValue<bool[]>(reader.GetOrdinal("boolarrayvalue")));
            Assert.Equal(new long[] { }, reader.GetFieldValue<long[]>(reader.GetOrdinal("bigintarrayvalue")));
            Assert.Equal(new double[] { }, reader.GetFieldValue<double[]>(reader.GetOrdinal("floatarrayvalue")));
            Assert.Equal(new string[] { }, reader.GetFieldValue<string[]>(reader.GetOrdinal("stringarrayvalue")));
            Assert.Equal(new byte[][] { }, reader.GetFieldValue<byte[][]>(reader.GetOrdinal("bytesarrayvalue")));
            Assert.Equal(new DateTime[] { }, reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("timestamparrayvalue")));
            Assert.Equal(new DateTime[] { }, reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("datearrayvalue")));
            Assert.Equal(new PgNumeric[] { }, reader.GetFieldValue<PgNumeric[]>(reader.GetOrdinal("pgnumericarrayvalue")));
            //Assert.Equal(new string[] { }, reader.GetFieldValue<string[]>(reader.GetOrdinal("jsonbarrayvalue")));
        });
    }

    [Fact]
    public async Task WriteInfinity()
    {
        Assert.Equal(1, await InsertAsync("FloatValue", SpannerDbType.Float64, double.PositiveInfinity));
        await WithLastRowAsync(reader => Assert.True(double.IsPositiveInfinity(reader.GetFieldValue<double>("floatvalue"))));
    }

    [Fact]
    public async Task WriteNanValue()
    {
        Assert.Equal(1, await InsertAsync("FloatValue", SpannerDbType.Float64, double.NaN));
        await WithLastRowAsync(reader => Assert.True(double.IsNaN(reader.GetFieldValue<double>("floatvalue"))));
    }

    [Fact]
    public async Task WriteNegativeInfinity()
    {
        Assert.Equal(1, await InsertAsync("FloatValue", SpannerDbType.Float64, double.NegativeInfinity));
        await WithLastRowAsync(reader => Assert.True(double.IsNegativeInfinity(reader.GetFieldValue<double>("floatvalue"))));
    }

    [Fact]
    public async Task WriteNulls() =>
        await ExecuteWriteNullsTest(InsertAsync, false);

    [Fact]
    public async Task WriteNullsDml() =>
        await ExecuteWriteNullsTest(InsertDmlAsync, true);

    [Fact]
    public async Task WriteRandomBytes()
    {
        var seedByte = (byte) (Environment.TickCount % 256);
        var rnd = new Random(seedByte);

        // We write 1-50 rows where each row contains a bytearray of size 1-50
        // whose bytes are randomly generated with the given seed.
        // The seed itself is written as the first row in an array of size=1.
        var recordedValues = new Dictionary<string, byte[]>();

        await InsertAndRecordBytesAsync(new[] { seedByte }, recordedValues);

        var numRows = rnd.Next(50);
        for (var i = 0; i < numRows; i++)
        {
            var byteArray = new byte[rnd.Next(50)];
            rnd.NextBytes(byteArray);
            await InsertAndRecordBytesAsync(byteArray, recordedValues);
        }

        using var connection = _fixture.GetConnection();
        string sqlQuery = $@"SELECT K,BytesValue
                                FROM {_fixture.TableName}
                                WHERE K IN ({string.Join(", ", recordedValues.Keys.Select(x => $"'{x}'"))})";

        var cmd = connection.CreateSelectCommand(sqlQuery);
        using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            var key = reader.GetFieldValue<string>("k");
            var value = reader.GetFieldValue<byte[]>("bytesvalue");
            Assert.Equal(recordedValues[key], value);
            recordedValues.Remove(key);
        }
        Assert.Equal(0, recordedValues.Count);
    }

    [Fact]
    public async Task CommandTimeout()
    {
        var values = new SpannerParameterCollection
            {
                {"StringValue", SpannerDbType.String, "abc"},
                {"K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid()}
            };

        using var connection = new SpannerConnection($"{_fixture.ConnectionString};{nameof(SpannerConnectionStringBuilder.AllowImmediateTimeouts)}=true");
        var cmd = connection.CreateInsertCommand(_fixture.TableName, values);
        cmd.CommandTimeout = 0;
        var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsync());
        SpannerAssert.IsTimeout(e);
    }
}
