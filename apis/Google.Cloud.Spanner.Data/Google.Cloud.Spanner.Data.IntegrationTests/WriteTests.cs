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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Xunit;
using Xunit.Abstractions;

#endregion

// ReSharper disable RedundantArgumentDefaultValue

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(TestDatabaseFixture))]
    public class WriteTests
    {
        // ReSharper disable once UnusedParameter.Local
        public WriteTests(TestDatabaseFixture testFixture, ITestOutputHelper outputHelper)
        {
            _testFixture = testFixture;
#if LoggingOn
            SpannerConnection.ConnectionPoolOptions.LogLevel = LogLevel.Debug;
            SpannerConnection.ConnectionPoolOptions.LogPerformanceTraces = true;
            SpannerConnection.ConnectionPoolOptions.PerformanceTraceLogInterval = 1000;
#endif
            TestLogger.TestOutputHelper = outputHelper;
        }

        private readonly TestDatabaseFixture _testFixture;
        private string _lastKey;

        private static string UniqueString() => Guid.NewGuid().ToString();

        private async Task<int> InsertAsync(SpannerParameterCollection values)
        {
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                values.Add("K", SpannerDbType.String, _lastKey = UniqueString());
                var cmd = connection.CreateInsertCommand("T", values);

                return await cmd.ExecuteNonQueryAsync();
            }
        }

        private async Task InsertAndRecordBytesAsync(
            byte[] bytes,
            IDictionary<string, byte[]> record)
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        new SpannerParameter("BytesValue", SpannerDbType.Bytes) {Value = bytes}
                    }));
            record[_lastKey] = bytes;
        }

        private async Task<SpannerDataReader> GetLastRowAsync()
        {
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM T WHERE K=@k",
                    new SpannerParameterCollection {{"K", SpannerDbType.String, _lastKey}});
                var reader = (SpannerDataReader) await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                return reader;
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
                        {"BoolValue", SpannerDbType.Bool, true},
                        {"Int64Value", SpannerDbType.Int64, 1},
                        {"Float64Value", SpannerDbType.Float64, 2.0},
                        {"StringValue", SpannerDbType.String, "abc"},
                        {"TimestampValue", SpannerDbType.Timestamp, testTimestamp},
                        {"DateValue", SpannerDbType.Date, testDate},
                        {
                            "BoolArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bool),
                            bArray
                        },
                        {
                            "Int64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Int64),
                            lArray
                        },
                        {
                            "Float64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Float64),
                            dArray
                        },
                        {
                            "StringArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.String),
                            sArray
                        },
                        {
                            "BytesArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
                            bArrayArray
                        },
                        {
                            "TimestampArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
                            tmArray
                        },
                        {
                            "DateArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Date),
                            dtArray
                        }
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

        [Fact]
        public async Task BadColumnName()
        {
            var rowsWritten = 0;
            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                    {
                        var cmd = connection.CreateInsertCommand(
                            "T", new SpannerParameterCollection
                            {
                                {"badjuju", SpannerDbType.String, UniqueString()}
                            });

                        rowsWritten = await cmd.ExecuteNonQueryAsync();
                    }
                }).ConfigureAwait(false);

            Logger.DefaultLogger.Debug(() => $"BadColumnName: Caught error code:{e.ErrorCode}");
            Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.Equal(0, rowsWritten);
        }

        [Fact]
        public async Task BadColumnType()
        {
            var rowsWritten = 0;
            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                    {
                        var cmd = connection.CreateInsertCommand(
                            "T", new SpannerParameterCollection
                            {
                                {"K", SpannerDbType.Float64, 0.1}
                            });

                        rowsWritten = await cmd.ExecuteNonQueryAsync();
                    }
                }).ConfigureAwait(false);

            Logger.DefaultLogger.Debug(() => $"BadColumnType: Caught error code:{e.ErrorCode}");
            Assert.Equal(ErrorCode.FailedPrecondition, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.Equal(0, rowsWritten);
        }

        [Fact]
        public async Task BadTableName()
        {
            var rowsWritten = 0;
            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                    {
                        var cmd = connection.CreateInsertCommand(
                            "badjuju", new SpannerParameterCollection
                            {
                                {"K", SpannerDbType.String, UniqueString()}
                            });

                        rowsWritten = await cmd.ExecuteNonQueryAsync();
                    }
                }).ConfigureAwait(false);

            Logger.DefaultLogger.Debug(() => $"BadTableName: Caught error code:{e.ErrorCode}");
            Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.Equal(0, rowsWritten);
        }

        [Fact]
        public async Task WriteEmpties()
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        {
                            "BoolArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bool),
                            new bool[0]
                        },
                        {
                            "Int64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Int64),
                            new long[0]
                        },
                        {
                            "Float64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Float64),
                            new double[0]
                        },
                        {
                            "StringArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.String),
                            new string[0]
                        },
                        {
                            "BytesArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
                            new byte[0][]
                        },
                        {
                            "TimestampArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
                            new DateTime[0]
                        },
                        {
                            "DateArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Date),
                            new DateTime[0]
                        }
                    }));
            using (var reader = await GetLastRowAsync())
            {
                Assert.Equal(new bool[] { }, reader.GetFieldValue<bool[]>(reader.GetOrdinal("BoolArrayValue")));
                Assert.Equal(new long[] { }, reader.GetFieldValue<long[]>(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Equal(new double[] { }, reader.GetFieldValue<double[]>(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Equal(new string[] { }, reader.GetFieldValue<string[]>(reader.GetOrdinal("StringArrayValue")));
                Assert.Equal(new byte[][] { }, reader.GetFieldValue<byte[][]>(reader.GetOrdinal("BytesArrayValue")));
                Assert.Equal(
                    new DateTime[] { }, reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Equal(new DateTime[] { }, reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("DateArrayValue")));
            }
        }

        [Fact]
        public async Task WriteInfinity()
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        {"Float64Value", SpannerDbType.Float64, double.PositiveInfinity}
                    }));
            using (var reader = await GetLastRowAsync())
            {
                Assert.True(double.IsPositiveInfinity(reader.GetFieldValue<double>("Float64Value")));
            }
        }

        [Fact]
        public async Task WriteNanValue()
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        {"Float64Value", SpannerDbType.Float64, double.NaN}
                    }));
            using (var reader = await GetLastRowAsync())
            {
                Assert.True(double.IsNaN(reader.GetFieldValue<double>("Float64Value")));
            }
        }

        [Fact]
        public async Task WriteNegativeInfinity()
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        {"Float64Value", SpannerDbType.Float64, double.NegativeInfinity}
                    }));
            using (var reader = await GetLastRowAsync())
            {
                Assert.True(double.IsNegativeInfinity(reader.GetFieldValue<double>("Float64Value")));
            }
        }

        [Fact]
        public async Task WriteNulls()
        {
            Assert.Equal(
                1, await InsertAsync(
                    new SpannerParameterCollection
                    {
                        {"BoolValue", SpannerDbType.Bool, null},
                        {"Int64Value", SpannerDbType.Int64, null},
                        {"Float64Value", SpannerDbType.Float64, null},
                        {"StringValue", SpannerDbType.String, null},
                        {"TimestampValue", SpannerDbType.Timestamp, null},
                        {"DateValue", SpannerDbType.Date, null},
                        {
                            "BoolArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bool),
                            null
                        },
                        {
                            "Int64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Int64),
                            null
                        },
                        {
                            "Float64ArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Float64),
                            null
                        },
                        {
                            "StringArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.String),
                            null
                        },
                        {
                            "BytesArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
                            null
                        },
                        {
                            "TimestampArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
                            null
                        },
                        {
                            "DateArrayValue",
                            SpannerDbType.ArrayOf(SpannerDbType.Date),
                            null
                        }
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
        public async Task WriteRandomBytes()
        {
            var seedByte = (byte) (Environment.TickCount % 256);
            var rnd = new Random(seedByte);

            //we write 1-50 rows where each row contains a bytearray of size 1-50
            //whose bytes are randomly generated with the given seed.
            //The seed itself is written as the first row in an array of size=1.
            var recordedValues = new Dictionary<string, byte[]>();

            await InsertAndRecordBytesAsync(new[] {seedByte}, recordedValues);

            var numRows = rnd.Next(50);
            for (var i = 0; i < numRows; i++)
            {
                var byteArray = new byte[rnd.Next(50)];
                rnd.NextBytes(byteArray);
                await InsertAndRecordBytesAsync(byteArray, recordedValues);
            }

            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                string sqlQuery = $@"SELECT K,BytesValue
                                FROM T
                                WHERE K IN ({string.Join(", ", recordedValues.Keys.Select(x => $"'{x}'"))})";

                var cmd = connection.CreateSelectCommand(sqlQuery);
                using (var reader = (SpannerDataReader) await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var key = reader.GetFieldValue<string>("K");
                        var value = reader.GetFieldValue<byte[]>("BytesValue");
                        Assert.Equal(recordedValues[key], value);
                        recordedValues.Remove(key);
                    }
                }
                Assert.Equal(0, recordedValues.Count);
            }
        }

        [Fact]
        public async Task CommandTimeout()
        {
            await _testFixture.EnsureTestDatabaseAsync();

            var values = new SpannerParameterCollection
            {
                {"StringValue", SpannerDbType.String, "abc"},
                {"K", SpannerDbType.String, _lastKey = UniqueString()}
            };

            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = new SpannerConnection($"{_testFixture.ConnectionString};{nameof(SpannerSettings.AllowImmediateTimeouts)}=true"))
                    {
                        var cmd = connection.CreateInsertCommand("T", values);
                        cmd.CommandTimeout = 0;
                        await cmd.ExecuteNonQueryAsync();
                    }
                }).ConfigureAwait(false);

            Assert.Equal(ErrorCode.DeadlineExceeded, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
        }
    }
}
