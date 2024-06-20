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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(AllTypesTableFixture))]
    [CommonTestDiagnostics]
    public class WriteTests
    {
        private readonly AllTypesTableFixture _fixture;
        private string _lastKey;

        public WriteTests(AllTypesTableFixture fixture) =>
            _fixture = fixture;

        private Task<int> InsertAsync(string name, SpannerDbType type, object value) =>
            InsertAsync(new SpannerParameterCollection { { name, type, value } });

        private async Task<int> InsertAsync(SpannerParameterCollection values)
        {
            using (var connection = GetConnection())
            {
                values.Add("K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid());
                var cmd = connection.CreateInsertCommand(_fixture.TableName, values);

                return await cmd.ExecuteNonQueryAsyncWithRetry();
            }
        }

        private SpannerConnection GetConnection() => _fixture.GetConnection();

        private async Task<SpannerDataReader> GetWriteTestReader(SpannerConnection connection)
        {
            var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE K=@k");
            command.Parameters.Add("K", SpannerDbType.String, _lastKey);
            return await command.ExecuteReaderAsync();
        }

        private async Task InsertAndRecordBytesAsync(
            byte[] bytes,
            IDictionary<string, byte[]> record)
        {
            Assert.Equal(1, await InsertAsync("BytesValue", SpannerDbType.Bytes, bytes));
            record[_lastKey] = bytes;
        }

        internal static async Task WithLastRowAsync(Action<SpannerDataReader> lastRowAction, SpannerConnection connection, Func<SpannerConnection, Task<SpannerDataReader>> getReader)
        {
            using var reader = await getReader(connection);
            Assert.True(await reader.ReadAsync());
            lastRowAction(reader);
        }

        private async Task ExecuteWriteNullsTest(Func<SpannerParameterCollection, Task<int>> insertCommand)
        {
            // b/348711708 google.protobuf.Value is not supported for DML
            bool isDml = insertCommand.Method.Name == nameof(InsertDmlAsync);
            var parameters = new SpannerParameterCollection
            {
                { "BoolValue", SpannerDbType.Bool, null },
                { "Int64Value", SpannerDbType.Int64, null },
                { "Float64Value", SpannerDbType.Float64, null },
                { "StringValue", SpannerDbType.String, null },
                { "BytesValue", SpannerDbType.Bytes, null },
                { "TimestampValue", SpannerDbType.Timestamp, null },
                { "DateValue", SpannerDbType.Date, null },
                { "NumericValue", SpannerDbType.Numeric, null },
                { "ProtobufDurationValue", SpannerDbType.FromClrType(typeof(Duration)), null },
                { "ProtobufRectangleValue", SpannerDbType.FromClrType(typeof(Rectangle)), null },
                
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), null },
                { "Int64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), null },
                { "Float64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), null },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), null },
                { "Base64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), null },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), null },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), null },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), null },
                { "NumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), null },
                { "ProtobufDurationArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))), null },
                { "ProtobufRectangleArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))), null },
            };

            // The emulator doesn't yet support the JSON type.
            if (!_fixture.RunningOnEmulator)
            {
                parameters.Add("Float32Value", SpannerDbType.Float32, null);
                parameters.Add("Float32ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float32), null);
                parameters.Add("JsonValue", SpannerDbType.Json, null);
                parameters.Add("JsonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), null);
                // b/348716298
                parameters.Add("ProtobufValueArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Value))), null);
                parameters.Add("ProtobufPersonValue", SpannerDbType.FromClrType(typeof(Person)), null);
                parameters.Add("ProtobufPersonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Person))), null);
                parameters.Add("ProtobufValueWrapperValue", SpannerDbType.FromClrType(typeof(ValueWrapper)), null);
                parameters.Add("ProtobufValueWrapperArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(ValueWrapper))), null);
                // b/348716298 makes it not supported on the emulator
                // b/348711708 makes it not supported in DML
                if (!isDml)
                {
                    parameters.Add("ProtobufValueValue", SpannerDbType.FromClrType(typeof(Value)), null);
                }
            }

            Assert.Equal(1, await insertCommand(parameters));
            await WithLastRowAsync(reader =>
            {
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BoolValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Int64Value")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Float64Value")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("StringValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BytesValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("TimestampValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("DateValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("NumericValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufDurationValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufRectangleValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BoolArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Int64ArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Float64ArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("StringArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Base64ArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BytesArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("TimestampArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("DateArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("NumericArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufDurationArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufRectangleArrayValue")));
                if (!_fixture.RunningOnEmulator)
                {
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("Float32Value")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("Float32ArrayValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("JsonValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("JsonArrayValue")));
                    // b/348716298
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufValueArrayValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufPersonValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufPersonArrayValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufValueWrapperValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufValueWrapperArrayValue")));
                    // b/348716298 makes it not supported on the emulator
                    // b/348711708 makes it not supported in DML
                    if (!isDml)
                    {
                        Assert.True(reader.IsDBNull(reader.GetOrdinal("ProtobufValueValue")));
                    }
                }
            }, GetConnection(), GetWriteTestReader);
        }

        private async Task ExecuteWriteValuesTest(Func<SpannerParameterCollection, Task<int>> insertCommand)
        {
            // b/348711708 google.protobuf.Value is not supported for DML
            bool isDml = insertCommand.Method.Name == nameof(InsertDmlAsync);
            var testTimestamp = new DateTime(2017, 3, 17, 15, 30, 0);
            var testDate = new DateTime(2017, 5, 9);
            bool?[] bArray = { true, null, false };
            long?[] lArray = { 0, null, 1 };
            float?[] fArray = { 0f, null, 1f };
            double?[] dArray = { 0.0, null, 2.0 };
            SpannerNumeric?[] nArray = { SpannerNumeric.Parse("0.0"), null, SpannerNumeric.Parse("2.0") };
            string[] jsonArray = { "{\"f1\":\"v1\"}", "{}", "[]", null };
            string[] sArray = { "abc", null, "123" };
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
            DateTime?[] dtArray = { new DateTime(2017, 3, 17), null, new DateTime(2017, 5, 9) };
            DateTime?[] tmArray = { new DateTime(2017, 3, 17, 5, 30, 0), null, new DateTime(2017, 5, 9, 12, 45, 0) };

            Value[] pvArray = { Value.ForNumber(10), null, Value.ForString("Hello") };
            Duration[] pdArray = { Duration.FromTimeSpan(TimeSpan.FromHours(1)), null, Duration.FromTimeSpan(TimeSpan.FromSeconds(10)) };

            Rectangle testRectangle = new Rectangle
            {
                TopRight = new Point { X = 1, Y = 1 },
                Width = 10,
                Height = 5,
            };
            Rectangle[] rArray = { testRectangle, null, new Rectangle() };

            Person testPerson = new Person
            {
                Name = "John",
                Siblings = { new Person { Name = "Jane" } }
            };
            Person[] pArray = { testPerson, null, new Person() };

            ValueWrapper testValueWrapper = new ValueWrapper { OneValue = Value.ForString("Hello") };
            ValueWrapper[] vwArray = { testValueWrapper, null, new ValueWrapper() };

            var parameters = new SpannerParameterCollection
            {
                { "BoolValue", SpannerDbType.Bool, true },
                { "Int64Value", SpannerDbType.Int64, 1 },
                { "Float64Value", SpannerDbType.Float64, 3.14 },
                { "StringValue", SpannerDbType.String, "abc" },
                { "BytesValue", SpannerDbType.Bytes, new byte[] { 4, 5, 6 } },
                { "TimestampValue", SpannerDbType.Timestamp, testTimestamp },
                { "DateValue", SpannerDbType.Date, testDate },
                { "NumericValue", SpannerDbType.Numeric, SpannerNumeric.Parse("2.0") },
                { "ProtobufDurationValue", SpannerDbType.FromClrType(typeof(Duration)), Duration.FromTimeSpan(TimeSpan.FromHours(1)) },
                { "ProtobufRectangleValue", SpannerDbType.FromClrType(typeof(Rectangle)), testRectangle },
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), bArray },
                { "Int64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), lArray },
                { "Float64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), dArray },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), sArray },
                { "Base64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), base64Array },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), byteArray },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), tmArray },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), dtArray },
                { "NumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), nArray },
                { "ProtobufDurationArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))), pdArray },
                { "ProtobufRectangleArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))), rArray },
            };

            // The emulator doesn't yet support the JSON type.
            if (!_fixture.RunningOnEmulator)
            {
                parameters.Add("Float32Value", SpannerDbType.Float32, 2.718f);
                parameters.Add("Float32ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float32), fArray);
                parameters.Add("JsonValue", SpannerDbType.Json, "{\"f1\":\"v1\"}");
                parameters.Add("JsonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), jsonArray);
                // b/348716298
                parameters.Add("ProtobufValueArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Value))), pvArray);
                parameters.Add("ProtobufPersonValue", SpannerDbType.FromClrType(typeof(Person)), testPerson);
                parameters.Add("ProtobufPersonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Person))), pArray);
                parameters.Add("ProtobufValueWrapperValue", SpannerDbType.FromClrType(typeof(ValueWrapper)), testValueWrapper);
                parameters.Add("ProtobufValueWrapperArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(ValueWrapper))), vwArray);
                // b/348716298 makes it not supported on the emulator
                // b/348711708 makes it not supported in DML
                if (!isDml)
                {
                    parameters.Add("ProtobufValueValue", SpannerDbType.FromClrType(typeof(Value)), Value.ForString("Hello"));
                }
            }

            Assert.Equal(1, await insertCommand(parameters));
            await WithLastRowAsync(reader =>
            {
                Assert.True(reader.GetFieldValue<bool>(reader.GetOrdinal("BoolValue")));
                Assert.Equal(1, reader.GetFieldValue<long>(reader.GetOrdinal("Int64Value")));
                Assert.Equal(3.14, reader.GetFieldValue<double>(reader.GetOrdinal("Float64Value")), 2);
                Assert.Equal("abc", reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                Assert.Equal(new byte[] { 4, 5, 6 }, reader.GetFieldValue<byte[]>(reader.GetOrdinal("BytesValue")));
                long length = reader.GetBytes(reader.GetOrdinal("BytesValue"), 0L, null, 0, int.MaxValue);
                Assert.Equal(3L, length);
                var buffer = new byte[length];
                Assert.Equal(3, reader.GetBytes(reader.GetOrdinal("BytesValue"), 0L, buffer, 0, (int) length));
                Assert.Equal(testTimestamp, reader.GetFieldValue<DateTime>(reader.GetOrdinal("TimestampValue")));
                Assert.Equal(testDate, reader.GetFieldValue<DateTime>(reader.GetOrdinal("DateValue")));
                Assert.Equal(SpannerNumeric.Parse("2.0"), reader.GetFieldValue<SpannerNumeric>(reader.GetOrdinal("NumericValue")));
                Assert.Equal(Duration.FromTimeSpan(TimeSpan.FromHours(1)), reader.GetFieldValue<Duration>(reader.GetOrdinal("ProtobufDurationValue")));
                Assert.Equal(testRectangle, reader.GetFieldValue<Rectangle>(reader.GetOrdinal("ProtobufRectangleValue")));
                Assert.Equal(bArray, reader.GetFieldValue<bool?[]>(reader.GetOrdinal("BoolArrayValue")));
                Assert.Equal(lArray, reader.GetFieldValue<long?[]>(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Equal(dArray, reader.GetFieldValue<double?[]>(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Equal(sArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("StringArrayValue")));
                Assert.Equal(base64Array, reader.GetFieldValue<string[]>(reader.GetOrdinal("Base64ArrayValue")));
                Assert.Equal(byteArray, reader.GetFieldValue<byte[][]>(reader.GetOrdinal("BytesArrayValue")));
                Assert.Equal(tmArray, reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Equal(dtArray, reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("DateArrayValue")));
                Assert.Equal(nArray, reader.GetFieldValue<SpannerNumeric?[]>(reader.GetOrdinal("NumericArrayValue")));
                Assert.Equal(pdArray, reader.GetFieldValue<Duration[]>(reader.GetOrdinal("ProtobufDurationArrayValue")));
                Assert.Equal(rArray, reader.GetFieldValue<Rectangle[]>(reader.GetOrdinal("ProtobufRectangleArrayValue")));
                if (!_fixture.RunningOnEmulator)
                {
                    Assert.Equal(2.718f, reader.GetFieldValue<float>(reader.GetOrdinal("Float32Value")), 3);
                    Assert.Equal(fArray, reader.GetFieldValue<float?[]>(reader.GetOrdinal("Float32ArrayValue")));
                    Assert.Equal("{\"f1\":\"v1\"}", reader.GetFieldValue<string>(reader.GetOrdinal("JsonValue")));
                    Assert.Equal(jsonArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("JsonArrayValue")));
                    // b/348716298
                    Assert.Equal(pvArray, reader.GetFieldValue<Value[]>(reader.GetOrdinal("ProtobufValueArrayValue")));
                    Assert.Equal(testPerson, reader.GetFieldValue<Person>(reader.GetOrdinal("ProtobufPersonValue")));
                    Assert.Equal(pArray, reader.GetFieldValue<Person[]>(reader.GetOrdinal("ProtobufPersonArrayValue")));
                    Assert.Equal(testValueWrapper, reader.GetFieldValue<ValueWrapper>(reader.GetOrdinal("ProtobufValueWrapperValue")));
                    Assert.Equal(vwArray, reader.GetFieldValue<ValueWrapper[]>(reader.GetOrdinal("ProtobufValueWrapperArrayValue")));
                    // b/348716298 makes it not supported on the emulator
                    // b/348711708 makes it not supported in DML
                    if (!isDml)
                    {
                        Assert.Equal(Value.ForString("Hello"), reader.GetFieldValue<Value>(reader.GetOrdinal("ProtobufValueValue")));
                    }
                }
            }, GetConnection(), GetWriteTestReader);
        }

        [Fact]
        public async Task WriteValues() => await ExecuteWriteValuesTest(InsertAsync);

        [Fact]
        public async Task WriteValuesDml() => await ExecuteWriteValuesTest(InsertDmlAsync);

        private async Task<int> InsertDmlAsync(SpannerParameterCollection values)
        {
            using (var connection = GetConnection())
            {
                values.Add("K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid());
                // b/348711708 means that DML inserts do not work for google.protobuf.Value
                SpannerCommand cmd = connection.CreateDmlCommand(_fixture.CreateInsertCommand(skipProtobufValue: true), values);
                return await cmd.ExecuteNonQueryAsync();
            }
        }

        [Fact]
        public async Task BadColumnName()
        {
            using (var connection = GetConnection())
            {
                var cmd = connection.CreateInsertCommand(_fixture.TableName);
                cmd.Parameters.Add("badjuju", SpannerDbType.String, IdGenerator.FromGuid());
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
                Logger.DefaultLogger.Debug($"BadColumnName: Caught error code: {e.ErrorCode}");
                Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }
        }

        [Fact]
        public async Task BadColumnType()
        {
            using (var connection = GetConnection())
            {
                var cmd = connection.CreateInsertCommand(_fixture.TableName);
                cmd.Parameters.Add("K", SpannerDbType.Float64, 0.1);
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
                Logger.DefaultLogger.Debug($"BadColumnType: Caught error code: {e.ErrorCode}");
                Assert.Equal(ErrorCode.FailedPrecondition, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }
        }

        [Fact]
        public async Task BadTableName()
        {
            using (var connection = GetConnection())
            {
                var cmd = connection.CreateInsertCommand("badjuju");
                cmd.Parameters.Add("K", SpannerDbType.String, IdGenerator.FromGuid());
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
                Logger.DefaultLogger.Debug($"BadTableName: Caught error code: {e.ErrorCode}");
                Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }
        }

        [Fact]
        public async Task WriteEmpties()
        {
            var parameters = new SpannerParameterCollection
            {
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), new bool[0] },
                { "Int64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), new long[0] },
                { "Float64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), new double[0] },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), new string[0] },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), new byte[0][] },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), new DateTime[0] },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), new DateTime[0] },
                { "NumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), new SpannerNumeric[0] },
                { "ProtobufDurationArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))), new Duration[0] },
                { "ProtobufRectangleArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))), new Rectangle[0] },
            };

            // The emulator doesn't yet support the JSON type.
            if (!_fixture.RunningOnEmulator)
            {
                parameters.Add("Float32ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float32), new float[0]);
                parameters.Add("JsonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), new string[0]);
                // b/348716298
                parameters.Add("ProtobufValueArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Value))), new Value[0]);
                parameters.Add("ProtobufPersonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Person))), new Person[0]);
                parameters.Add("ProtobufValueWrapperArrayValue", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(ValueWrapper))), new ValueWrapper[0]);
            }

            Assert.Equal(1, await InsertAsync(parameters));
            await WithLastRowAsync(reader =>
            {
                Assert.Equal(new bool[0], reader.GetFieldValue<bool[]>(reader.GetOrdinal("BoolArrayValue")));
                Assert.Equal(new long[0], reader.GetFieldValue<long[]>(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Equal(new double[0], reader.GetFieldValue<double[]>(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Equal(new string[0], reader.GetFieldValue<string[]>(reader.GetOrdinal("StringArrayValue")));
                Assert.Equal(new byte[0][], reader.GetFieldValue<byte[][]>(reader.GetOrdinal("BytesArrayValue")));
                Assert.Equal(new DateTime[0], reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Equal(new DateTime[0], reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("DateArrayValue")));
                Assert.Equal(new SpannerNumeric[0], reader.GetFieldValue<SpannerNumeric[]>(reader.GetOrdinal("NumericArrayValue")));
                Assert.Equal(new Duration[0], reader.GetFieldValue<Duration[]>(reader.GetOrdinal("ProtobufDurationArrayValue")));
                Assert.Equal(new Rectangle[0], reader.GetFieldValue<Rectangle[]>(reader.GetOrdinal("ProtobufRectangleArrayValue")));
                if (!_fixture.RunningOnEmulator)
                {
                    Assert.Equal(new float[0], reader.GetFieldValue<float[]>(reader.GetOrdinal("Float32ArrayValue")));
                    Assert.Equal(new string[0], reader.GetFieldValue<string[]>(reader.GetOrdinal("JsonArrayValue")));
                    // b/348716298
                    Assert.Equal(new Value[0], reader.GetFieldValue<Value[]>(reader.GetOrdinal("ProtobufValueArrayValue")));
                    Assert.Equal(new Person[0], reader.GetFieldValue<Person[]>(reader.GetOrdinal("ProtobufPersonArrayValue")));
                    Assert.Equal(new ValueWrapper[0], reader.GetFieldValue<ValueWrapper[]>(reader.GetOrdinal("ProtobufValueWrapperArrayValue")));
                }
            }, GetConnection(), GetWriteTestReader);
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task WriteInfinity_Float32()
        {
            Assert.Equal(1, await InsertAsync("Float32Value", SpannerDbType.Float32, float.PositiveInfinity));
            await WithLastRowAsync(reader => Assert.True(float.IsPositiveInfinity(reader.GetFieldValue<float>("Float32Value"))), GetConnection(), GetWriteTestReader);
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task WriteNanValue_Float32()
        {
            Assert.Equal(1, await InsertAsync("Float32Value", SpannerDbType.Float32, float.NaN));
            await WithLastRowAsync(reader => Assert.True(float.IsNaN(reader.GetFieldValue<float>("Float32Value"))), GetConnection(), GetWriteTestReader);
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task WriteNegativeInfinity_Float32()
        {
            Assert.Equal(1, await InsertAsync("Float32Value", SpannerDbType.Float32, float.NegativeInfinity));
            await WithLastRowAsync(reader => Assert.True(float.IsNegativeInfinity(reader.GetFieldValue<float>("Float32Value"))), GetConnection(), GetWriteTestReader);
        }

        [Fact]
        public async Task WriteInfinity_Float64()
        {
            Assert.Equal(1, await InsertAsync("Float64Value", SpannerDbType.Float64, double.PositiveInfinity));
            await WithLastRowAsync(reader => Assert.True(double.IsPositiveInfinity(reader.GetFieldValue<double>("Float64Value"))), GetConnection(), GetWriteTestReader);
        }

        [Fact]
        public async Task WriteNanValue_Float64()
        {
            Assert.Equal(1, await InsertAsync("Float64Value", SpannerDbType.Float64, double.NaN));
            await WithLastRowAsync(reader => Assert.True(double.IsNaN(reader.GetFieldValue<double>("Float64Value"))), GetConnection(), GetWriteTestReader);
        }

        [Fact]
        public async Task WriteNegativeInfinity_Float64()
        {
            Assert.Equal(1, await InsertAsync("Float64Value", SpannerDbType.Float64, double.NegativeInfinity));
            await WithLastRowAsync(reader => Assert.True(double.IsNegativeInfinity(reader.GetFieldValue<double>("Float64Value"))), GetConnection(), GetWriteTestReader);
        }

        [Fact]
        public async Task WriteNulls() => await ExecuteWriteNullsTest(InsertAsync);

        [Fact]
        public async Task WriteNullsDml() => await ExecuteWriteNullsTest(InsertDmlAsync);

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

            using (var connection = GetConnection())
            {
                string sqlQuery = $@"SELECT K,BytesValue
                                FROM {_fixture.TableName}
                                WHERE K IN ({string.Join(", ", recordedValues.Keys.Select(x => $"'{x}'"))})";

                var cmd = connection.CreateSelectCommand(sqlQuery);
                using (var reader = await cmd.ExecuteReaderAsync())
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
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task CommandTimeout()
        {
            // The emulator returns too quickly to trigger timeout.
            var values = new SpannerParameterCollection
            {
                {"StringValue", SpannerDbType.String, "abc"},
                {"K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid()}
            };

            using (var connection = new SpannerConnection($"{_fixture.ConnectionString};{nameof(SpannerConnectionStringBuilder.AllowImmediateTimeouts)}=true"))
            {
                var cmd = connection.CreateInsertCommand(_fixture.TableName, values);
                cmd.CommandTimeout = 0;
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsync());
                SpannerAssert.IsTimeout(e);
            }
        }
    }
}
