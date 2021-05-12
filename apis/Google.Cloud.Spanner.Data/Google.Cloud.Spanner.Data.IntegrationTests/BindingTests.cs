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

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    [CommonTestDiagnostics]
    public class BindingTests
    {
        private readonly SpannerDatabaseFixture _fixture;

        public BindingTests(SpannerDatabaseFixture fixture) =>
            _fixture = fixture;

        public static TheoryData<SpannerDbType> BindNullData { get; } = new TheoryData<SpannerDbType>
        {
            SpannerDbType.Bool,
            SpannerDbType.String,
            SpannerDbType.Int64,
            SpannerDbType.Timestamp,
            SpannerDbType.Float64,
            SpannerDbType.Numeric,
            SpannerDbType.Date,
            SpannerDbType.Bytes,
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            SpannerDbType.ArrayOf(SpannerDbType.String),
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            SpannerDbType.ArrayOf(SpannerDbType.Numeric),
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
        };

        // [START spanner_test_query_bind_bool_null]
        // [END spanner_test_query_bind_bool_null]
        // [START spanner_test_query_bind_int64_null]
        // [END spanner_test_query_bind_int64_null]
        // [START spanner_test_query_bind_float64_null]
        // [END spanner_test_query_bind_float64_null]
        // [START spanner_test_query_bind_numeric_null]
        // [END spanner_test_query_bind_numeric_null]
        // [START spanner_test_query_bind_string_null]
        // [END spanner_test_query_bind_string_null]
        // [START spanner_test_query_bind_bytes_null]
        // [END spanner_test_query_bind_bytes_null]
        // [START spanner_test_query_bind_timestamp_null]
        // [END spanner_test_query_bind_timestamp_null]
        // [START spanner_test_query_bind_date_null]
        // [END spanner_test_query_bind_date_null]
        // [START spanner_test_query_bind_bool_array_null]
        // [END spanner_test_query_bind_bool_array_null]
        // [START spanner_test_query_bind_int64_array_null]
        // [END spanner_test_query_bind_int64_array_null]
        // [START spanner_test_query_bind_float64_array_null]
        // [END spanner_test_query_bind_float64_array_null]
        // [START spanner_test_query_bind_numeric_array_null]
        // [END spanner_test_query_bind_numeric_array_null]
        // [START spanner_test_query_bind_string_array_null]
        // [END spanner_test_query_bind_string_array_null]
        // [START spanner_test_query_bind_bytes_array_null]
        // [END spanner_test_query_bind_bytes_array_null]
        // [START spanner_test_query_bind_timestamp_array_null]
        // [END spanner_test_query_bind_timestamp_array_null]
        // [START spanner_test_query_bind_date_array_null]
        // [END spanner_test_query_bind_date_array_null]
        [Theory]
        [MemberData(nameof(BindNullData))]
        public async Task BindNull(SpannerDbType parameterType)
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand("SELECT @v");
                cmd.Parameters.Add("v", parameterType, null);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());

                    Assert.True(reader.IsDBNull(0));
                    Assert.Equal(DBNull.Value, reader.GetValue(0));

                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        private async Task TestBindNonNull<T>(SpannerDbType parameterType, T value, Func<SpannerDataReader, T> typeSpecificReader = null)
        {
            int rowsRead;
            var valueRead = default(T);

            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand("SELECT @v");
                cmd.Parameters.Add("v", parameterType, value);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        valueRead = reader.GetFieldValue<T>(0);

                        // Optional extra test for certain built in types
                        if (typeSpecificReader != null)
                        {
                            Assert.Equal(typeSpecificReader(reader), valueRead);
                            Assert.False(reader.IsDBNull(0));
                        }

                        rowsRead++;
                    }
                }
            }
            Assert.Equal(1, rowsRead);
            var valueAsArray = value as Array;
            if (valueAsArray != null)
            {
                var valueReadAsArray = valueRead as Array;
                Assert.NotNull(valueReadAsArray);
                Assert.Equal(valueAsArray.Length, valueReadAsArray.Length);
                for (int i = 0; i < valueAsArray.Length; i++)
                {
                    Assert.Equal(valueAsArray.GetValue(i), valueReadAsArray.GetValue(i));
                }
            }
            else
            {
                Assert.Equal(value, valueRead);
            }
        }

        // [START spanner_test_query_bind_bool]
        [Fact]
        public Task BindBoolean() => TestBindNonNull(SpannerDbType.Bool, true, r => r.GetBoolean(0));
        // [END spanner_test_query_bind_bool]

        // [START spanner_test_query_bind_bool_array]
        [Fact]
        public Task BindBooleanArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            new bool?[] {true, null, false});
        // [END spanner_test_query_bind_bool_array]

        // [START spanner_test_query_bind_bool_array_empty]
        [Fact]
        public Task BindBooleanEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            new bool[] { });
        // [END spanner_test_query_bind_bool_array_empty]

        // [START spanner_test_query_bind_bytes]
        [Fact]
        public Task BindByteArray() => TestBindNonNull(
            SpannerDbType.Bytes,
            new byte[] {1, 2, 3});
        // [END spanner_test_query_bind_bytes]

        // [START spanner_test_query_bind_bytes_array]
        [Fact]
        public Task BindByteArrayList() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
            new List<byte[]> {
                new byte[] { 1, 2, 3 },
                new byte[] { 4, 5, 6 },
                null
            });
        // [END spanner_test_query_bind_bytes_array]

        // [START spanner_test_query_bind_bytes_array_empty]
        [Fact]
        public Task BindEmptyByteArrayList() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
            new List<byte[]>());
        // [END spanner_test_query_bind_bytes_array_empty]

        // [START spanner_test_query_bind_date]
        [Fact]
        public Task BindDate() => TestBindNonNull(
            SpannerDbType.Date,
            new DateTime(2017, 5, 26));
        // [END spanner_test_query_bind_date]

        // [START spanner_test_query_bind_date_array]
        [Fact]
        public Task BindDateArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            new DateTime?[] {new DateTime(2017, 5, 26), null, new DateTime(2017, 5, 9)});
        // [END spanner_test_query_bind_date_array]

        // [START spanner_test_query_bind_date_array_empty]
        [Fact]
        public Task BindDateEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            new DateTime?[] { });
        // [END spanner_test_query_bind_date_array_empty]

        // [START spanner_test_query_bind_float64]
        [Fact]
        public Task BindFloat64() => TestBindNonNull(SpannerDbType.Float64, 1.0, r => r.GetDouble(0));
        // [END spanner_test_query_bind_float64]

        // [START spanner_test_query_bind_float64_array]
        [Fact]
        public Task BindFloat64Array() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            new double?[] {0.0, null, 1.0});
        // [END spanner_test_query_bind_float64_array]

        // [START spanner_test_query_bind_float64_array_empty]
        [Fact]
        public Task BindFloat64EmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            new double[] { });
        // [END spanner_test_query_bind_float64_array_empty]

        // [START spanner_test_query_bind_int64]
        [Fact]
        public Task BindInt64() => TestBindNonNull(SpannerDbType.Int64, 1, r => r.GetInt64(0));
        // [END spanner_test_query_bind_int64]

        // [START spanner_test_query_bind_int64_array]
        [Fact]
        public Task BindInt64Array() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            new long?[] {1, null, 0});
        // [END spanner_test_query_bind_int64_array]

        // [START spanner_test_query_bind_int64_array_empty]
        [Fact]
        public Task BindInt64EmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            new long[] { });
        // [END spanner_test_query_bind_int64_array_empty]

        // [START spanner_test_query_bind_numeric]
        [Fact]
        public async Task BindNumeric()
        {
            await TestBindNonNull(SpannerDbType.Numeric, SpannerNumeric.Parse("1.0"), r => r.GetNumeric(0));
        }
        // [END spanner_test_query_bind_numeric]

        // [START spanner_test_query_bind_numeric_array]
        [Fact]
        public async Task BindNumericArray()
        {
            await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.Numeric),
                new SpannerNumeric?[] {SpannerNumeric.Parse("0.0"), null, SpannerNumeric.Parse("1.0")});
        }
        // [END spanner_test_query_bind_numeric_array]

        // [START spanner_test_query_bind_numeric_array_empty]
        [Fact]
        public async Task BindNumericEmptyArray()
        {
            await TestBindNonNull(SpannerDbType.ArrayOf(SpannerDbType.Numeric), new SpannerNumeric[] { });
        }
        // [END spanner_test_query_bind_numeric_array_empty]

        // [START spanner_test_query_bind_string]
        [Fact]
        public Task BindString() => TestBindNonNull(SpannerDbType.String, "abc", r => r.GetString(0));
        // [END spanner_test_query_bind_string]

        // [START spanner_test_query_bind_string_array]
        [Fact]
        public Task BindStringArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            new[] {"abc", null, "123"});
        // [END spanner_test_query_bind_string_array]

        // [START spanner_test_query_bind_string_array_empty]
        [Fact]
        public Task BindStringEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            new string[] { });
        // [END spanner_test_query_bind_string_array_empty]

        // [START spanner_test_query_bind_timestamp]
        [Fact]
        public Task BindTimestamp() => TestBindNonNull(
            SpannerDbType.Timestamp,
            new DateTime(2017, 5, 26, 15, 0, 0));
        // [END spanner_test_query_bind_timestamp]

        // [START spanner_test_query_bind_timestamp_array]
        [Fact]
        public Task BindTimestampArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            new DateTime?[]
                {new DateTime(2017, 5, 26, 3, 15, 0), null, new DateTime(2017, 5, 9, 12, 30, 0)});
        // [END spanner_test_query_bind_timestamp_array]

        // [START spanner_test_query_bind_timestamp_array_empty]
        [Fact]
        public Task BindTimestampEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            new DateTime?[] { });
        // [END spanner_test_query_bind_timestamp_array_empty]
    }
}
