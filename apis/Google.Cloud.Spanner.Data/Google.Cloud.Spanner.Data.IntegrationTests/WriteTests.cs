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

#region

using System;
using System.Data.Common;
using System.Threading.Tasks;
using Xunit;

#endregion

// ReSharper disable RedundantArgumentDefaultValue

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public class WriteTests : IClassFixture<TestDatabaseFixture>
    {
        public WriteTests(TestDatabaseFixture testFixture) => _testFixture = testFixture;

        private readonly TestDatabaseFixture _testFixture;
        private string _lastKey;

        private static string UniqueString() => Guid.NewGuid().ToString();

        private async Task<int> InsertAsync(SpannerParameterCollection values)
        {
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                values.Add("K", _lastKey = UniqueString(), SpannerDbType.String);
                var cmd = connection.CreateInsertCommand("T", values);

                return await cmd.ExecuteNonQueryAsync();
            }
        }

        private async Task<DbDataReader> GetLastRowAsync()
        {
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM T WHERE K=@k",
                    new SpannerParameterCollection {{"K", _lastKey, SpannerDbType.String}});
                var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                return reader;
            }
        }

        [Fact]
        public async Task WriteNulls()
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        new SpannerParameter("BoolValue", SpannerDbType.Bool, null),
                        new SpannerParameter("Int64Value", SpannerDbType.Int64, null),
                        new SpannerParameter("Float64Value", SpannerDbType.Float64, null),
                        new SpannerParameter("StringValue", SpannerDbType.String, null),
                        new SpannerParameter("TimestampValue", SpannerDbType.Timestamp, null),
                        new SpannerParameter("DateValue", SpannerDbType.Date, null),
                        new SpannerParameter(
                            "BoolArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bool),
                            null),
                        new SpannerParameter(
                            "Int64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Int64),
                            null),
                        new SpannerParameter(
                            "Float64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Float64),
                            null),
                        new SpannerParameter(
                            "StringArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.String),
                            null),
                        new SpannerParameter(
                            "BytesArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
                            null),
                        new SpannerParameter(
                            "TimestampArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
                            null),
                        new SpannerParameter(
                            "DateArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Date),
                            null)
                    }));
            using (var reader = await GetLastRowAsync())
            {
                Assert.Null(reader.GetValue(reader.GetOrdinal("BoolValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("Int64Value")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("Float64Value")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("StringValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("TimestampValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("DateValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("BoolArrayValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("StringArrayValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("BytesArrayValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Null(reader.GetValue(reader.GetOrdinal("DateArrayValue")));
            }
        }

        [Fact]
        public async Task WriteValues()
        {
            var testTimestamp = new DateTime(2017, 3, 17, 15, 30, 0);
            var testDate = new DateTime(2017, 5, 9);
            bool?[] bArray = {true, null, false};
            long?[] lArray = {0, null, 1};
            double?[] dArray = {0.0, null, 2.0};
            string[] sArray = {"abc", null, "123"};
            string[] bArrayArray =
            {
                Convert.ToBase64String(new byte[] {0, 1, 2}), null,
                Convert.ToBase64String(new byte[] {1, 2, 3})
            };
            DateTime?[] dtArray = {new DateTime(2017, 3, 17), null, new DateTime(2017, 5, 9)};
            DateTime?[] tmArray = {new DateTime(2017, 3, 17, 5, 30, 0), null, new DateTime(2017, 5, 9, 12, 45, 0)};

            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        new SpannerParameter("BoolValue", SpannerDbType.Bool, true),
                        new SpannerParameter("Int64Value", SpannerDbType.Int64, 1),
                        new SpannerParameter("Float64Value", SpannerDbType.Float64, 2.0),
                        new SpannerParameter("StringValue", SpannerDbType.String, "abc"),
                        new SpannerParameter("TimestampValue", SpannerDbType.Timestamp, testTimestamp),
                        new SpannerParameter("DateValue", SpannerDbType.Date, testDate),
                        new SpannerParameter(
                            "BoolArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bool),
                            bArray),
                        new SpannerParameter(
                            "Int64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Int64),
                            lArray),
                        new SpannerParameter(
                            "Float64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Float64),
                            dArray),
                        new SpannerParameter(
                            "StringArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.String),
                            sArray),
                        new SpannerParameter(
                            "BytesArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
                            bArrayArray),
                        new SpannerParameter(
                            "TimestampArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
                            tmArray),
                        new SpannerParameter(
                            "DateArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Date),
                            dtArray)
                    }));
            using (var reader = await GetLastRowAsync())
            {
                Assert.True(reader.GetFieldValue<bool>(reader.GetOrdinal("BoolValue")));
                Assert.Equal(1, reader.GetFieldValue<long>(reader.GetOrdinal("Int64Value")));
                Assert.True(
                    Math.Abs(2.0 - reader.GetFieldValue<double>(reader.GetOrdinal("Float64Value")))
                    < double.Epsilon);
                Assert.Equal("abc", reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                Assert.Equal(testTimestamp, reader.GetFieldValue<DateTime>(reader.GetOrdinal("TimestampValue")));
                Assert.Equal(testDate, reader.GetFieldValue<DateTime>(reader.GetOrdinal("DateValue")));
                Assert.Equal(
                    bArray,
                    reader.GetFieldValue<bool?[]>(reader.GetOrdinal("BoolArrayValue")));
                Assert.Equal(
                    lArray,
                    reader.GetFieldValue<long?[]>(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Equal(
                    dArray,
                    reader.GetFieldValue<double?[]>(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Equal(
                    sArray,
                    reader.GetFieldValue<string[]>(reader.GetOrdinal("StringArrayValue")));
                Assert.Equal(
                    bArrayArray,
                    reader.GetFieldValue<string[]>(reader.GetOrdinal("BytesArrayValue")));
                Assert.Equal(
                    tmArray,
                    reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Equal(
                    dtArray,
                    reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("DateArrayValue")));
            }
        }
    }
}
