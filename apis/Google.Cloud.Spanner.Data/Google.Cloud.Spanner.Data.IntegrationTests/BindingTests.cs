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
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    [CommonTestDiagnostics]
    public class BindingTests
    {
        private static readonly Rectangle testRectangle = new Rectangle
        {
            TopRight = new Point { X = 1, Y = 1 },
            Width = 10,
            Height = 5,
        };

        private static readonly Person testPerson = new Person
        {
            Name = "John",
            Siblings = { new Person { Name = "Jane" } }
        };

        private static readonly ValueWrapper testValueWrapper = new ValueWrapper { OneValue = Value.ForString("Hello") };

        private readonly SpannerDatabaseFixture _fixture;

        public BindingTests(SpannerDatabaseFixture fixture) =>
            _fixture = fixture;

        // These SpannerDbTypes are supported on emulator.
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
            SpannerDbType.Float32,
            SpannerDbType.Json,
            SpannerDbType.Interval,
            SpannerDbType.FromClrType(typeof(Duration)),
            SpannerDbType.FromClrType(typeof(Rectangle)),
            SpannerDbType.FromClrType(typeof(Person)),
            SpannerDbType.FromClrType(typeof(ValueWrapper)),
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            SpannerDbType.ArrayOf(SpannerDbType.String),
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            SpannerDbType.ArrayOf(SpannerDbType.Numeric),
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
            SpannerDbType.ArrayOf(SpannerDbType.Float32),
            SpannerDbType.ArrayOf(SpannerDbType.Json),
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))),
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))),
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Person))),
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(ValueWrapper))),
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Value))),
        };

        // These SpannerDbTypes are unsupported on production.
        public static TheoryData<SpannerDbType> BindProductionUnsupportedNullData { get; } = new TheoryData<SpannerDbType>
        {
            // b/348711708 Makes it unsupported in production
            SpannerDbType.FromClrType(typeof(Value)),
        };

        // TODO: xUnit v3 supports traits for DataAttributes. Use that instead of Skip when we migrate.
        [SkippableTheory]
        [MemberData(nameof(BindNullData))]
        [MemberData(nameof(BindProductionUnsupportedNullData))]
        public async Task BindNull(SpannerDbType parameterType)
        {
            MaybeSkipIfOnProduction(parameterType);
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateSelectCommand("SELECT @v");
            cmd.Parameters.Add("v", parameterType, null);
            using var reader = await cmd.ExecuteReaderAsync();
            await AssertNull(reader);
        }

        internal static async Task AssertNull(SpannerDataReader reader)
        {
            Assert.True(await reader.ReadAsync());
            Assert.True(reader.IsDBNull(0));
            Assert.Equal(DBNull.Value, reader.GetValue(0));
            Assert.False(await reader.ReadAsync());
        }

        internal static async Task AssertNotNull<T>(SpannerDataReader reader, T value, Func<SpannerDataReader, T> typeSpecificReader)
        {
            Assert.True(await reader.ReadAsync());
            var valueRead = reader.GetFieldValue<T>(0);
            // Optional extra test for certain built in types
            if (typeSpecificReader != null)
            {
                Assert.Equal(typeSpecificReader(reader), valueRead);
                Assert.False(reader.IsDBNull(0));
            }

            if (value is Array valueAsArray)
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

            Assert.False(await reader.ReadAsync());
        }

        private async Task TestBindNonNull<T>(SpannerDbType parameterType, T value, Func<SpannerDataReader, T> typeSpecificReader = null)
        {
            MaybeSkipIfOnProduction(parameterType);
            using var connection = _fixture.GetConnection();
            using var cmd = connection.CreateSelectCommand("SELECT @v");
            cmd.Parameters.Add("v", parameterType, value);
            using var reader = await cmd.ExecuteReaderAsync();
            await AssertNotNull<T>(reader, value, typeSpecificReader);
        }

        [Fact]
        public Task BindBoolean() => TestBindNonNull(SpannerDbType.Bool, true, r => r.GetBoolean(0));

        [Fact]
        public Task BindBooleanArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            new bool?[] { true, null, false });

        [Fact]
        public Task BindBooleanEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            new bool[] { });

        [Fact]
        public Task BindByteArray() => TestBindNonNull(
            SpannerDbType.Bytes,
            new byte[] { 1, 2, 3 });

        [Fact]
        public Task BindByteArrayList() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
            new List<byte[]> {
                new byte[] { 1, 2, 3 },
                new byte[] { 4, 5, 6 },
                null
            });

        [Fact]
        public Task BindEmptyByteArrayList() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Bytes),
            new List<byte[]>());

        [Fact]
        public Task BindDate() => TestBindNonNull(
            SpannerDbType.Date,
            new DateTime(2017, 5, 26));

        [Fact]
        public Task BindDateArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            new DateTime?[] { new DateTime(2017, 5, 26), null, new DateTime(2017, 5, 9) });

        [Fact]
        public Task BindDateEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            new DateTime?[] { });

        [Fact]
        public Task BindFloat32() => TestBindNonNull(SpannerDbType.Float32, 1.0f, r => r.GetFloat(0));

        [Fact]
        public Task BindFloat32Array() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Float32),
            new float?[] { 0.0f, null, 1.0f });

        [Fact]
        public Task BindFloat32EmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Float32),
            new float[] { });

        [Fact]
        public Task BindFloat64() => TestBindNonNull(SpannerDbType.Float64, 1.0, r => r.GetDouble(0));

        [Fact]
        public Task BindFloat64Array() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            new double?[] { 0.0, null, 1.0 });

        [Fact]
        public Task BindFloat64EmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            new double[] { });

        [Fact]
        public Task BindInt64() => TestBindNonNull(SpannerDbType.Int64, 1, r => r.GetInt64(0));

        [Fact]
        public Task BindInt64Array() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            new long?[] { 1, null, 0 });

        [Fact]
        public Task BindInt64EmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            new long[] { });

        [Fact]
        public async Task BindNumeric() => await TestBindNonNull(
            SpannerDbType.Numeric,
            SpannerNumeric.Parse("1.0"),
            r => r.GetNumeric(0));

        [Fact]
        public async Task BindNumericArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.Numeric),
                new SpannerNumeric?[] { SpannerNumeric.Parse("0.0"), null, SpannerNumeric.Parse("1.0") });

        [Fact]
        public async Task BindNumericEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Numeric),
            new SpannerNumeric[] { });

        [Fact]
        public Task BindString() => TestBindNonNull(
            SpannerDbType.String,
            "abc",
            r => r.GetString(0));

        [Fact]
        public Task BindStringArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            new[] { "abc", null, "123" });

        [Fact]
        public Task BindStringEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            new string[] { });

        [Fact]
        public Task BindTimestamp() => TestBindNonNull(
            SpannerDbType.Timestamp,
            new DateTime(2017, 5, 26, 15, 0, 0));

        [Fact]
        public Task BindTimestampArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            new DateTime?[]
                {new DateTime(2017, 5, 26, 3, 15, 0), null, new DateTime(2017, 5, 9, 12, 30, 0)});

        [Fact]
        public Task BindTimestampEmptyArray() => TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            new DateTime?[] { });

        [Fact]
        public async Task BindJson() => await TestBindNonNull(
            SpannerDbType.Json,
            "{\"key\":\"value\"}",
            r => r.GetString(0));

        [Fact]
        public async Task BindJsonArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.Json),
                new string[] { "{\"key\":\"value\"}", null, "{\"other-key\":\"other-value\"}" });

        [Fact]
        public async Task BindJsonEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Json),
            new string[] { });

        [Fact]
        public async Task BindInterval() =>  await TestBindNonNull(
            SpannerDbType.Interval,
            Interval.Parse("P1Y"));

        [Fact]
        public async Task BindIntervalArray() =>  await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Interval),
            new Interval[] {Interval.Parse("P1Y"), null, Interval.Parse("PT1H")});

        [Fact]
        public async Task BindIntervalEmptyArray() =>  await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.Interval),
            new Interval[] { });

        [SkippableFact] //"b/348711708
        public async Task BindProtobufValue() => await TestBindNonNull(
            SpannerDbType.FromClrType(typeof(Value)),
            Value.ForString("Hello"),
            r => r.GetFieldValue<Value>(0));

        [Fact]
        public async Task BindProtobufValueArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Value))),
                new Value[] { Value.ForNumber(10), null, Value.ForString("Hello world") });

        [Fact]
        public async Task BindProtobufValueEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Value))),
            new Value[] { });

        [Fact]
        public async Task BindProtobufDuration() => await TestBindNonNull(
            SpannerDbType.FromClrType(typeof(Duration)),
            Duration.FromTimeSpan(TimeSpan.FromHours(1)),
            r => r.GetFieldValue<Duration>(0));

        [Fact]
        public async Task BindProtobufDurationArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))),
                new Duration[] { Duration.FromTimeSpan(TimeSpan.FromHours(1)), null, Duration.FromTimeSpan(TimeSpan.FromSeconds(10)) });

        [Fact]
        public async Task BindProtobufDurationEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))),
            new Duration[] { });

        [Fact]
        public async Task BindProtobufRectangle() => await TestBindNonNull(
            SpannerDbType.FromClrType(typeof(Rectangle)), testRectangle, r => r.GetFieldValue<Rectangle>(0));

        [Fact]
        public async Task BindProtobufRectanlgeArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))),
                new Rectangle[] { testRectangle, null, new Rectangle() });

        [Fact]
        public async Task BindProtobufRectangleEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))),
            new Rectangle[] { });

        [Fact]
        public async Task BindProtobufPerson() => await TestBindNonNull(
            SpannerDbType.FromClrType(typeof(Person)), testPerson, r => r.GetFieldValue<Person>(0));

        [Fact]
        public async Task BindProtobufPersonArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Person))),
                new Person[] { testPerson, null, new Person() });

        [Fact]
        public async Task BindProtobufPersonEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Person))),
            new Person[] { });

        [Fact]
        public async Task BindProtobufValueWrapper() => await TestBindNonNull(
            SpannerDbType.FromClrType(typeof(ValueWrapper)), testValueWrapper, r => r.GetFieldValue<ValueWrapper>(0));

        [Fact]
        public async Task BindProtobufValueWrapperArray() => await TestBindNonNull(
                SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(ValueWrapper))),
                new ValueWrapper[] { testValueWrapper, null, new ValueWrapper() });

        [Fact]
        public async Task BindProtobufValueWrapperEmptyArray() => await TestBindNonNull(
            SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(ValueWrapper))),
            new ValueWrapper[] { });

        private void MaybeSkipIfOnProduction(SpannerDbType spannerDbType) =>
            Skip.If(!_fixture.RunningOnEmulator && BindProductionUnsupportedNullData.Any<SpannerDbType>(spannerDbType.Equals),
                $"Production does not support {spannerDbType}.");
    }
}
