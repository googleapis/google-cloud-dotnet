// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(ReadTableFixture))]
    [CommonTestDiagnostics]
    public class ReadTests
    {
        private readonly ReadTableFixture _fixture;

        public ReadTests(ReadTableFixture fixture) =>
            _fixture = fixture;

        private async Task<T> ExecuteAsync<T>(string sql)
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand(sql);
                var result = await cmd.ExecuteScalarAsync<T>();
                return result;
            }
        }

        [Fact]
        public async Task BadColumnName()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT badjuju FROM {_fixture.TableName}");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var e = await Assert.ThrowsAsync<SpannerException>(() => reader.ReadAsync());
                    Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                    Assert.False(e.IsTransientSpannerFault());
                }
            }
        }

        [Fact]
        public async Task BadDbName()
        {
            string connectionString = new SpannerConnectionStringBuilder(_fixture.ConnectionString)
                .WithDatabase("badjuju")
                .ConnectionString;

            using (var connection = new SpannerConnection(connectionString))
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteReaderAsync());
                Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }

            // Shut the pool associated with the bad database down, to avoid seeing spurious connection failures
            // later in the log.
            await SessionPoolHelpers.ShutdownPoolAsync(connectionString);
        }

        [Fact]
        public async Task BadTableName()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand("SELECT * FROM badjuju WHERE Key = 'k99'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var e = await Assert.ThrowsAsync<SpannerException>(() => reader.ReadAsync());
                    Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                    Assert.False(e.IsTransientSpannerFault());
                }
            }
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task CancelRead()
        {
            // The emulator can return before query is cancelled.
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var cancellationTokenSource = new CancellationTokenSource();
                    var task = reader.ReadAsync(cancellationTokenSource.Token);
                    cancellationTokenSource.Cancel();
                    var e = await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
                    Assert.False(e.IsTransientSpannerFault());
                }
            }
        }

        [Fact]
        public async Task EmptyStructArray()
        {
            var sqlQuery = "SELECT ARRAY(SELECT AS STRUCT * FROM (SELECT 'a', 1) WHERE 0 = 1)";
            var result = await ExecuteAsync<IList>(sqlQuery);
            Assert.Equal(0, result.Count);
        }

        [Fact]
        public async Task NaN()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(0, 0)");
            Assert.True(double.IsNaN(result));
        }

        [Fact]
        public async Task NaNArray()
        {
            var result =
                await ExecuteAsync<double[]>(
                    "SELECT [IEEE_DIVIDE(1, 0), IEEE_DIVIDE(-1, 0), IEEE_DIVIDE(0, 0)]");
            Assert.Equal(3, result.Length);
            Assert.True(double.IsPositiveInfinity(result[0]));
            Assert.True(double.IsNegativeInfinity(result[1]));
            Assert.True(double.IsNaN(result[2]));
        }

        [Fact]
        public async Task NegativeInf()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(-1, 0)");
            Assert.True(double.IsNegativeInfinity(result));
        }

        [CombinatorialData]
        [Theory]
        public async Task PointRead(bool query)
        {
            using var connection = _fixture.GetConnection();
            using var cmd = query
                ? connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'")
                : connection.CreateReadCommand(
                    _fixture.TableName, ReadOptions.FromColumns("Key", "StringValue"), KeySet.FromKeys(new Key("k1")));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.True(await reader.ReadAsync());
            Assert.Equal("k1", reader.GetString(0));
            Assert.Equal("v1", reader.GetString(1));

            Assert.False(await reader.ReadAsync());
        }

        [CombinatorialData]
        [Theory]
        public async Task QueryAllowsNewApis(bool query)
        {
            using var connection = _fixture.GetConnection();
            using var cmd = query
                ? connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'")
                : connection.CreateReadCommand(
                    _fixture.TableName, ReadOptions.FromColumns("Key", "StringValue"), KeySet.FromKeys(new Key("k1")));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.True(await reader.ReadAsync());
            Assert.Equal("k1", reader.GetFieldValue<string>("Key"));
            Assert.Equal("v1", reader.GetFieldValue<string>("StringValue"));

            Assert.False(await reader.ReadAsync());
        }

        [CombinatorialData]
        [Theory]
        public async Task PointReadEmpty(bool query)
        {
            using var connection = _fixture.GetConnection();
            using var cmd = query
                ? connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k99'")
                : connection.CreateReadCommand(
                    _fixture.TableName, ReadOptions.FromColumns("Key", "StringValue"), KeySet.FromKeys(new Key("k99")));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.False(await reader.ReadAsync());
        }

        [Fact]
        public async Task PositiveInf()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(1, 0)");
            Assert.True(double.IsPositiveInfinity(result));
        }

        [Fact]
        public async Task QueryTypo()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SLECT * FROM {_fixture.TableName}");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var e = await Assert.ThrowsAsync<SpannerException>(() => reader.ReadAsync());
                    Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                    Assert.False(e.IsTransientSpannerFault());
                }
            }
        }

        [CombinatorialData]
        [Theory]
        public async Task ReadEmpty(bool query)
        {
            using var connection = _fixture.GetConnection();
            // All our keys start with "k" so there shouldn't be anything starting with "l"
            using var cmd = query
                ? connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key >= 'l'")
                : connection.CreateReadCommand(
                    _fixture.TableName, ReadOptions.FromColumns("Key", "StringValue"), KeySet.FromRanges(KeyRange.ClosedOpen(new Key("l"), new Key())));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.False(await reader.ReadAsync());
        }

        [CombinatorialData]
        [Theory]
        public async Task GetFieldValue_NoReadCall(bool query)
        {
            using var connection = _fixture.GetConnection();
            using var cmd = query
                ? connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}")
                : connection.CreateReadCommand(_fixture.TableName, ReadOptions.FromColumns("Key"), KeySet.All);
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.Throws<InvalidOperationException>(() => reader.GetFieldValue<string>("Key"));
            // Validate GetJsonValue at the same time...
            Assert.Throws<InvalidOperationException>(() => reader.GetJsonValue(0));
        }

        [Fact]
        public async Task GetFieldValue_AfterFinalRead()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.False(await reader.ReadAsync());
                    Assert.Throws<InvalidOperationException>(() => reader.GetFieldValue<string>("Key"));
                    // Validate GetJsonValue at the same time...
                    Assert.Throws<InvalidOperationException>(() => reader.GetJsonValue(0));
                }
            }
        }

        [Fact]
        public async Task GetFieldValue_AfterMoveNext()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.False(await reader.NextResultAsync());
                    Assert.Throws<InvalidOperationException>(() => reader.GetFieldValue<string>("Key"));
                    // Validate GetJsonValue at the same time...
                    Assert.Throws<InvalidOperationException>(() => reader.GetJsonValue(0));
                }
            }
        }

        [Fact]
        public async Task SelectOne()
        {
            long result = await ExecuteAsync<long>("SELECT 1");
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task StructArray_AsDictionaryArray()
        {
            string sqlQuery = "SELECT ARRAY(SELECT AS STRUCT C1, C2 "
                + "FROM (SELECT 'a' AS C1, 1 AS C2 UNION ALL SELECT 'b' AS C1, 2 AS C2) "
                + "ORDER BY C1 ASC)";
            var result = await ExecuteAsync<List<Dictionary<string, object>>>(sqlQuery);
            Assert.Equal(2, result.Count);

            Assert.Equal("a", result[0]["C1"]);
            Assert.Equal(1L, result[0]["C2"]);

            Assert.Equal("b", result[1]["C1"]);
            Assert.Equal(2L, result[1]["C2"]);
        }

        [Fact]
        public async Task StructArray_AsSpannerStructArray()
        {
            string sqlQuery = "SELECT ARRAY(SELECT AS STRUCT C1, C2 "
                + "FROM (SELECT 'a' AS C1, 1 AS C2 UNION ALL SELECT 'b' AS C1, 2 AS C2) "
                + "ORDER BY C1 ASC)";
            var result = await ExecuteAsync<List<SpannerStruct>>(sqlQuery);
            Assert.Equal(2, result.Count);

            var struct1 = result[0];
            AssertStructField("C1", SpannerDbType.String, "a", struct1[0]);
            AssertStructField("C2", SpannerDbType.Int64, 1L, struct1[1]);

            var struct2 = result[1];
            AssertStructField("C1", SpannerDbType.String, "b", struct2[0]);
            AssertStructField("C2", SpannerDbType.Int64, 2L, struct2[1]);
        }

        [Fact]
        public async Task StructArray_DuplicateAndEmptyFieldNames()
        {
            var result = await ExecuteAsync<SpannerStruct[]>("SELECT ARRAY(SELECT STRUCT(1, 2 as f, 3 as f))");
            Assert.Equal(1, result.Length);
            var structValue = result[0];
            Assert.Equal(3, structValue.Count);

            AssertStructField("", SpannerDbType.Int64, 1L, structValue[0]);
            AssertStructField("f", SpannerDbType.Int64, 2L, structValue[1]);
            AssertStructField("f", SpannerDbType.Int64, 3L, structValue[2]);
        }

        private static void AssertStructField(string expectedName, SpannerDbType expectedType, object expectedValue, SpannerStruct.Field actualField)
        {
            Assert.Equal(expectedName, actualField.Name);
            Assert.Equal(expectedType, actualField.Type);
            Assert.Equal(expectedValue, actualField.Value);
        }

        [Fact]
        public async Task ReadNullValue_Legacy()
        {
            using (var connection = new SpannerConnection($"{_fixture.ConnectionString};UseClrDefaultForNull=true"))
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT Key, StringValue FROM {_fixture.TableName} WHERE Key = 'kNull'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.Equal("kNull", reader.GetString(0));
                    Assert.Null(reader.GetString(1));
                    Assert.Null(reader[1]);
                    Assert.Null(reader["StringValue"]);
                    Assert.True(reader.IsDBNull(1));

                    // No more rows
                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [Fact]
        public async Task ReadNullValue_DBNull()
        {
            using (var connection = new SpannerConnection(_fixture.ConnectionString))
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT Key, StringValue FROM {_fixture.TableName} WHERE Key = 'kNull'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.Equal("kNull", reader.GetString(0));
                    Assert.Throws<InvalidCastException>(() => reader.GetString(1));
                    Assert.Equal(DBNull.Value, reader[1]);
                    Assert.Equal(DBNull.Value, reader["StringValue"]);
                    Assert.True(reader.IsDBNull(1));

                    // No more rows
                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task CommandTimeout()
        {
            // The emulator returns too quickly to trigger timeout.
            using (var connection =
                new SpannerConnection($"{_fixture.ConnectionString};{nameof(SpannerConnectionStringBuilder.AllowImmediateTimeouts)}=true"))
            {
                var cmd = connection.CreateSelectCommand("SELECT 1");
                cmd.CommandTimeout = 0;
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteScalarAsync<long>());
                SpannerAssert.IsTimeout(e);
            }
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task TimeoutFromOptions()
        {
            // The emulator returns too quickly to trigger timeout.
            var connectionStringBuilder = new SpannerConnectionStringBuilder(_fixture.ConnectionString)
            {
                Timeout = 0,
                AllowImmediateTimeouts = true,
            };

            using (var connection = new SpannerConnection(connectionStringBuilder))
            {
                var cmd = connection.CreateSelectCommand("SELECT 1");
                Assert.Equal(0, cmd.CommandTimeout);
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteScalarAsync<long>());
                SpannerAssert.IsTimeout(e);
            }
        }

        [Fact]
        public async Task LargeRegexFailure()
        {
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT REGEXP_CONTAINS(@value, @regexp)"))
                {
                    cmd.Parameters.Add("regexp", SpannerDbType.String, "(" + new string('x', 8000));
                    cmd.Parameters.Add("value", SpannerDbType.String, "");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var exception = await Assert.ThrowsAsync<SpannerException>(reader.ReadAsync);
                        Assert.Equal(ErrorCode.OutOfRange, exception.ErrorCode);
                        Assert.Contains("Cannot parse regular expression", exception.InnerException.Message);
                    }
                }
            }
        }

        [Fact]
        public async Task UnboundParameter()
        {
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @p"))
                {
                    cmd.Parameters.Add("other", SpannerDbType.String, "hello");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var exception = await Assert.ThrowsAsync<SpannerException>(reader.ReadAsync);
                        Assert.Equal(ErrorCode.InvalidArgument, exception.ErrorCode);

                    }
                }
            }
        }

        [Fact]
        public void HasRows_NoRows_HasRowsFirst()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = @Key");
                cmd.Parameters.Add("Key", SpannerDbType.String).Value = "not found";
                using (var reader = cmd.ExecuteReader())
                {
                    Assert.False(reader.HasRows);
                    Assert.False(reader.Read());
                }
            }
        }

        [Fact]
        public void HasRows_NoRows_ReadFirst()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = @Key");
                cmd.Parameters.Add("Key", SpannerDbType.String).Value = "not found";
                using (var reader = cmd.ExecuteReader())
                {
                    Assert.False(reader.Read());
                    Assert.False(reader.HasRows);
                }
            }
        }

        [Fact]
        public void HasRows_WithRows_HasRowsFirst()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = @Key");
                cmd.Parameters.Add("Key", SpannerDbType.String).Value = "k0";
                using (var reader = cmd.ExecuteReader())
                {
                    Assert.True(reader.Read());
                    Assert.True(reader.HasRows);
                    Assert.False(reader.Read());
                    // Even after we've exhausted the reader, we "know" it has rows
                    Assert.True(reader.HasRows);

                    // But after a call to NextResult, there are no more rows.
                    Assert.False(reader.NextResult());
                    Assert.False(reader.HasRows);
                }
            }

        }

        [Fact]
        public void HasRows_WithRows_ReadFirst()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = @Key");
                cmd.Parameters.Add("Key", SpannerDbType.String).Value = "k0";
                using (var reader = cmd.ExecuteReader())
                {
                    Assert.True(reader.HasRows);
                    Assert.True(reader.Read());
                    Assert.False(reader.Read());
                    // Even after we've exhausted the reader, we "know" it has rows
                    Assert.True(reader.HasRows);

                    // But after a call to NextResult, there are no more rows.
                    Assert.False(reader.NextResult());
                    Assert.False(reader.HasRows);
                }
            }
        }

        [Fact]
        public void GetOrdinal()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT StringValue, Key FROM {_fixture.TableName} LIMIT 1");
                using (var reader = cmd.ExecuteReader())
                {
                    Assert.Equal(0, reader.GetOrdinal("StringValue"));
                    Assert.Equal(1, reader.GetOrdinal("Key"));
                }
            }
        }

        [Fact]
        public async Task GetOrdinalAsync()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT StringValue, Key FROM {_fixture.TableName} LIMIT 1");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.Equal(0, await reader.GetOrdinalAsync("StringValue"));
                    Assert.Equal(1, await reader.GetOrdinalAsync("Key"));
                }
            }
        }

        [Fact]
        public async Task WithCommand()
        {
            using (var connection = _fixture.GetConnection())
            {
                // Create a generic command and let the type be determined based on the command text.
                // A statement that starts with a WITH clause should be treated as a query.
                var cmd = connection.CreateCommand();
                cmd.CommandText =
                    $@"WITH LastValue AS (
                      SELECT Key, StringValue
                      FROM {_fixture.TableName}
                      ORDER BY StringValue
                      LIMIT {int.MaxValue} OFFSET {_fixture.RowCount - 1})
                    SELECT * FROM LastValue";
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [Fact]
        public async Task ReadAll()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key", "StringValue"), KeySet.All);
            using var reader = await cmd.ExecuteReaderAsync();
            var count = 0;
            while (await reader.ReadAsync())
            {
                count++;
            }
            Assert.Equal(_fixture.RowCount, count);
        }

        [Fact]
        public async Task ReadMultipleKeys()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key"), KeySet.FromKeys(new Key("k1"), new Key("k2")));
            using var reader = await cmd.ExecuteReaderAsync();
            var count = 0;
            while (await reader.ReadAsync())
            {
                count++;
                Assert.Equal($"k{count}", reader[0]);
            }
            Assert.Equal(2, count);
        }

        [Fact]
        public async Task ReadKeyRange_Closed_Closed()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key"),
                KeySet.FromRanges(KeyRange.ClosedClosed(new Key("k10"), new Key("k11"))));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.True(await reader.ReadAsync());
            Assert.Equal($"k10", reader[0]);
            Assert.True(await reader.ReadAsync());
            Assert.Equal($"k11", reader[0]);
            Assert.False(await reader.ReadAsync());
        }

        [Fact]
        public async Task ReadKeyRange_Closed_Open()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key"),
                KeySet.FromRanges(KeyRange.ClosedOpen(new Key("k10"), new Key("k11"))));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.True(await reader.ReadAsync());
            Assert.Equal($"k10", reader[0]);
            Assert.False(await reader.ReadAsync());
        }

        [Fact]
        public async Task ReadKeyRange_Open_Closed()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key"),
                KeySet.FromRanges(KeyRange.OpenClosed(new Key("k10"), new Key("k11"))));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.True(await reader.ReadAsync());
            Assert.Equal($"k11", reader[0]);
            Assert.False(await reader.ReadAsync());
        }

        [Fact]
        public async Task ReadKeyRange_Open_Open()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key"),
                KeySet.FromRanges(KeyRange.OpenOpen(new Key("k10"), new Key("k11"))));
            using var reader = await cmd.ExecuteReaderAsync();
            Assert.False(await reader.ReadAsync());
        }

        [Fact]
        public async Task ReadWithIndex()
        {
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key").WithIndexName("TestTableByValueDesc"), KeySet.FromKeys(new Key("v1"), new Key("v2")));
            using var reader = await cmd.ExecuteReaderAsync();
            // The read operation will order the results using the index that is set on the command, and this index has
            // descending order.
            Assert.True(await reader.ReadAsync());
            Assert.Equal($"k2", reader[0]);
            Assert.True(await reader.ReadAsync());
            Assert.Equal($"k1", reader[0]);
            Assert.False(await reader.ReadAsync());
        }

        [Fact]
        public async Task ReadWithLimit()
        {
            int limit = _fixture.RowCount - 1;
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateReadCommand(
                _fixture.TableName, ReadOptions.FromColumns("Key", "StringValue").WithLimit(limit), KeySet.All);
            using var reader = await cmd.ExecuteReaderAsync();
            var count = 0;
            while (await reader.ReadAsync())
            {
                count++;
            }
            Assert.Equal(limit, count);
        }

        [Fact]
        public async Task ReadInterval()
        {
            var expected = Interval.Parse("P1Y2M3DT4H5M6.789123456S");
            var interval = await ExecuteAsync<Interval>("SELECT INTERVAL '1-2 3 4:5:6.789123456' YEAR TO SECOND");
            Assert.Equal(expected, interval);
        }

        [Fact]
        public async Task ReadInterval_Null()
        {
            var interval = await ExecuteAsync<object>("SELECT CAST(NULL AS INTERVAL)");
            Assert.Equal(DBNull.Value, interval);
        }

        [Fact]
        public async Task ReadInterval_Array()
        {
            var expected = Interval.Parse("P1Y2M3DT4H5M6.789123456S");
            var intervalList = await ExecuteAsync<List<Interval>>("SELECT ARRAY<INTERVAL>[INTERVAL '1-2 3 4:5:6.789123456' YEAR TO SECOND]");
            var interval = Assert.Single(intervalList);
            Assert.Equal(expected, interval);
        }
    }
}
