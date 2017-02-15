// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Apis.Bigquery.v2.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryParameterTest
    {
        // Please excuse the very long lines... it's more readable than 
        public static IEnumerable<object[]> ToQueryParameterData() => new[]
        {
            // Bool
            ScalarTest("Bool parameter, true", BigQueryDbType.Bool, true, "TRUE"),
            ScalarTest("Bool parameter, false", BigQueryDbType.Bool, false, "FALSE"),
            ScalarTest("Bool parameter, string value", BigQueryDbType.Bool, "maybe", "maybe"),
            ScalarTest("Bool parameter, null value", BigQueryDbType.Bool, null, null),

            // Float64
            ScalarTest("Float64 parameter, Int16 value", BigQueryDbType.Float64, (short)10, "10"),
            ScalarTest("Float64 parameter, Int32 value", BigQueryDbType.Float64, (int)10, "10"),
            ScalarTest("Float64 parameter, Int64 value", BigQueryDbType.Float64, (long)10, "10"),
            ScalarTest("Float64 parameter, UInt16 value", BigQueryDbType.Float64, (ushort)10, "10"),
            ScalarTest("Float64 parameter, UInt32 value", BigQueryDbType.Float64, (uint)10, "10"),
            ScalarTest("Float64 parameter, UInt64 value", BigQueryDbType.Float64, (ulong)10, "10"),
            ScalarTest("Float64 parameter, Single value", BigQueryDbType.Float64, 10.5f, "10.5"),
            ScalarTest("Float64 parameter, Double value", BigQueryDbType.Float64, 10.5, "10.5"),
            ScalarTest("Float64 parameter, Single value (+inf)", BigQueryDbType.Float64, float.PositiveInfinity, "+inf"),
            ScalarTest("Float64 parameter, Double value (+inf)", BigQueryDbType.Float64, double.PositiveInfinity, "+inf"),
            ScalarTest("Float64 parameter, Single value (-inf)", BigQueryDbType.Float64, float.NegativeInfinity, "-inf"),
            ScalarTest("Float64 parameter, Double value (-inf)", BigQueryDbType.Float64, double.NegativeInfinity, "-inf"),
            ScalarTest("Float64 parameter, Single value (NaN)", BigQueryDbType.Float64, float.NaN, "NaN"),
            ScalarTest("Float64 parameter, Double value (NaN)", BigQueryDbType.Float64, double.NaN, "NaN"),
            ScalarTest("Float64 parameter, string value", BigQueryDbType.Float64, "string value", "string value"),
            ScalarTest("Float64 parameter, null value", BigQueryDbType.Float64, null, null),

            // Int64...
            ScalarTest("Int64 parameter, Int16 value", BigQueryDbType.Int64, (short)10, "10"),
            ScalarTest("Int64 parameter, Int32 value", BigQueryDbType.Int64, (int)10, "10"),
            ScalarTest("Int64 parameter, Int64 value", BigQueryDbType.Int64, (long)10, "10"),
            ScalarTest("Int64 parameter, UInt16 value", BigQueryDbType.Int64, (ushort)10, "10"),
            ScalarTest("Int64 parameter, UInt32 value", BigQueryDbType.Int64, (uint)10, "10"),
            ScalarTest("Int64 parameter, UInt64 value", BigQueryDbType.Int64, (ulong)10, "10"),
            ScalarTest("Int64 parameter, string value", BigQueryDbType.Int64, "string value", "string value"),
            ScalarTest("Int64 parameter, null value", BigQueryDbType.Int64, null, null),

            // String...
            ScalarTest("String parameter, string value", BigQueryDbType.String, "some value", "some value"),
            ScalarTest("String parameter, null value", BigQueryDbType.String, null, null),

            // Bytes...
            ScalarTest("Bytes parameter, byte[] value", BigQueryDbType.Bytes, new byte[] { 1, 2 }, "AQI="),
            ScalarTest("Bytes parameter, string value", BigQueryDbType.Bytes, "some value", "some value"),
            ScalarTest("Bytes parameter, null value", BigQueryDbType.Bytes, null, null),

            // Date
            ScalarTest("Date parameter, DateTime value", BigQueryDbType.Date, new DateTime(2016, 10, 31), "2016-10-31"),
            // This is midnight local time on the 31st, which means its UTC value is actually 2016-10-30T22:00:00
            // - but we only care about the local value for Date parameters
            ScalarTest("Date parameter, DateTimeOffset value", BigQueryDbType.Date, new DateTimeOffset(2016, 10, 31, 0, 0, 0, TimeSpan.FromHours(2)), "2016-10-31"),
            ScalarTest("Date parameter, string value", BigQueryDbType.Date, "some value", "some value"),
            ScalarTest("Date parameter, null value", BigQueryDbType.Date, null, null),

            // DateTime
            // Value with ticks is truncated (not rounded). The Kind is irrelevant
            ScalarTest("DateTime parameter, DateTime value (local)", BigQueryDbType.DateTime,
                new DateTime(2016, 10, 31, 1, 2, 3, 123,DateTimeKind.Local).AddTicks(4567),
                "2016-10-31 01:02:03.123456"),
            ScalarTest("DateTime parameter, DateTime value (unspecified)", BigQueryDbType.DateTime,
                new DateTime(2016, 10, 31, 1, 2, 3, 123, DateTimeKind.Unspecified).AddTicks(4567),
                "2016-10-31 01:02:03.123456"),
            ScalarTest("DateTime parameter, DateTime value (UTC)", BigQueryDbType.DateTime,
                new DateTime(2016, 10, 31, 1, 2, 3, 123, DateTimeKind.Utc).AddTicks(4567),
                "2016-10-31 01:02:03.123456"),
            // This is midnight local time on the 31st, which means its UTC value is actually 2016-10-30T22:00:00
            // - but we only care about the local value for DateTime parameters
            ScalarTest("DateTime parameter, DateTimeOffset value", BigQueryDbType.DateTime,
                new DateTimeOffset(2016, 10, 31, 0, 0, 0, TimeSpan.FromHours(2)), "2016-10-31 00:00:00"),
            ScalarTest("DateTime parameter, string value", BigQueryDbType.Date, "some value", "some value"),
            ScalarTest("DateTime parameter, null value", BigQueryDbType.Date, null, null),

            // Time
            // Truncated to microseconds
            ScalarTest("Time parameter, TimeSpan value", BigQueryDbType.Time,
                TimeSpan.ParseExact("01:23:45.1234567", "hh':'mm':'ss'.'FFFFFFF", CultureInfo.InvariantCulture),
                "01:23:45.123456"),
            // Truncated to a single day
            ScalarTest("Time parameter, TimeSpan value bigger than 24h", BigQueryDbType.Time,
                TimeSpan.FromHours(25), "01:00:00.000000"),
            ScalarTest("Time parameter, TimeSpan value negative", BigQueryDbType.Time,
                TimeSpan.FromHours(-1), "23:00:00.000000"),
            ScalarTest("Time parameter, TimeSpan value large negative", BigQueryDbType.Time,
                TimeSpan.FromHours(-25), "23:00:00.000000"),
            ScalarTest("Time parameter, DateTime value", BigQueryDbType.Time,
                new DateTime(2016, 10, 31, 1, 2, 3, 123).AddTicks(4567),
                "01:02:03.123456"),
            ScalarTest("Time parameter, DateTimeOffset value", BigQueryDbType.Time,
                new DateTimeOffset(2016, 10, 31, 1, 2, 3, 123, TimeSpan.FromHours(2)).AddTicks(4567),
                "01:02:03.123456"),
            ScalarTest("Time parameter, string value", BigQueryDbType.Time, "some value", "some value"),
            ScalarTest("Time parameter, null value", BigQueryDbType.Time, null, null),

            // Timestamp
            ScalarTest("Timestamp parameter, DateTime value (UTC)", BigQueryDbType.Timestamp,
                new DateTime(2016, 10, 31, 1, 2, 3, 123, DateTimeKind.Utc).AddTicks(4567),
                "2016-10-31 01:02:03.123456+00"),
            ScalarTest("Timestamp parameter, DateTimeOffset value positive offset", BigQueryDbType.Timestamp,
                new DateTimeOffset(2016, 10, 31, 0, 0, 0, TimeSpan.FromHours(2)), "2016-10-31 00:00:00+02:00"),
            ScalarTest("Timestamp parameter, DateTimeOffset value negative offset", BigQueryDbType.Timestamp,
                new DateTimeOffset(2016, 10, 31, 0, 0, 0, TimeSpan.FromHours(-2)), "2016-10-31 00:00:00-02:00"),
            ScalarTest("Timestamp parameter, string value", BigQueryDbType.Timestamp, "some value", "some value"),
            ScalarTest("Timestamp parameter, null value", BigQueryDbType.Timestamp, null, null),
        };

        public static IEnumerable<object[]> InvalidParameterData => new[]
        {
            new object[] { "Local DateTime for Timestamp", BigQueryDbType.Timestamp, new DateTime(2016, 10, 31, 0, 0, 0, DateTimeKind.Local) },
            new object[] { "Unspecified DateTime for Timestamp", BigQueryDbType.Timestamp, new DateTime(2016, 10, 31, 0, 0, 0, DateTimeKind.Unspecified) },
            new object[] { "Array with null element value", BigQueryDbType.Array, new[] { "foo", null, "bar" } },
            new object[] { "Array with null value", BigQueryDbType.Array, null },
            new object[] { "Array with non-array value", BigQueryDbType.Array, 10 },
            new object[] { "Null value and null type", null, null },
            new object[] { "DateTime value for Int64 type", BigQueryDbType.Int64, default(DateTime) },
        };

        public static IEnumerable<object[]> TypeInferenceData => new[]
        {
            new object[] { "Int16", (short) 10, BigQueryDbType.Int64 },
            new object[] { "Int32", 10, BigQueryDbType.Int64 },
            new object[] { "Int64", (long) 10, BigQueryDbType.Int64 },
            new object[] { "UInt16", (ushort) 10, BigQueryDbType.Int64 },
            new object[] { "UInt32", (uint) 10, BigQueryDbType.Int64 },
            new object[] { "UInt64", (ulong) 10, BigQueryDbType.Int64 },
            new object[] { "Single", 1.0f, BigQueryDbType.Float64 },
            new object[] { "Double", 1.0d, BigQueryDbType.Float64 },
            new object[] { "TimeSpan", TimeSpan.FromHours(1), BigQueryDbType.Time },
            new object[] { "DateTime (local)", new DateTime(2016, 10, 31, 0, 0, 0, DateTimeKind.Local), BigQueryDbType.DateTime },
            new object[] { "DateTime (unspecified)", new DateTime(2016, 10, 31, 0, 0, 0, DateTimeKind.Unspecified), BigQueryDbType.DateTime },
            new object[] { "DateTime (UTC)", new DateTime(2016, 10, 31, 0, 0, 0, DateTimeKind.Utc), BigQueryDbType.DateTime },
            new object[] { "DateTimeOffset", new DateTimeOffset(2016, 10, 31, 0, 0, 0, TimeSpan.FromHours(2)), BigQueryDbType.Timestamp },
            new object[] { "Byte[]", new byte[] { 1, 2 }, BigQueryDbType.Bytes },
        };

        public static IEnumerable<object[]> ArrayTypeInferenceData => new[]
        {
            new object[] { "Int16[]", new short[0], BigQueryDbType.Int64 },
            new object[] { "Int32[]", new int[0], BigQueryDbType.Int64 },
            new object[] { "Int64[]", new long[0], BigQueryDbType.Int64 },
            new object[] { "UInt16[]", new ushort[0], BigQueryDbType.Int64 },
            new object[] { "UInt32[]", new uint[0], BigQueryDbType.Int64 },
            new object[] { "UInt64[]", new ulong[0], BigQueryDbType.Int64 },
            new object[] { "Single[]", new float[0], BigQueryDbType.Float64 },
            new object[] { "Double[]", new double[0], BigQueryDbType.Float64 },
            new object[] { "TimeSpan[]", new TimeSpan[0], BigQueryDbType.Time },
            new object[] { "DateTime[]", new DateTime[0], BigQueryDbType.DateTime },
            new object[] { "DateTimeOffset[]", new DateTimeOffset[0], BigQueryDbType.Timestamp },
            new object[] { "Byte[][]", new byte[0][], BigQueryDbType.Bytes },
        };

        [Theory]
        [MemberData(nameof(ToQueryParameterData))]
        public void ToQueryParameter_Valid(string name, BigQueryParameter parameter, QueryParameter expectedResult)
        {
            // Positional vs named mode difference is only in validation, tested elsewhere.
            string actualJson = JsonConvert.SerializeObject(parameter.ToQueryParameter(BigQueryParameterMode.Positional));
            string expectedJson = JsonConvert.SerializeObject(expectedResult);
            Assert.Equal(actualJson, expectedJson);
        }

        [Theory]
        [MemberData(nameof(InvalidParameterData))]
        public void ToQueryParameter_Invalid(string name, BigQueryDbType? type, object value)
        {
            var parameter = new BigQueryParameter(type, value);
            Assert.Throws<InvalidOperationException>(() => parameter.ToQueryParameter(BigQueryParameterMode.Positional));
        }

        [Theory]
        [MemberData(nameof(TypeInferenceData))]
        public void TypeInference(string name, object value, BigQueryDbType expectedType)
        {
            var parameter = new BigQueryParameter();
            parameter.Value = value;
            var queryParameter = parameter.ToQueryParameter(BigQueryParameterMode.Positional);
            var actualType = EnumMap<BigQueryDbType>.ToValue(queryParameter.ParameterType.Type);
            Assert.Equal(expectedType, actualType);
        }

        [Theory]
        [MemberData(nameof(ArrayTypeInferenceData))]
        public void ArrayTypeInference(string name, object value, BigQueryDbType expectedArrayType)
        {
            var parameter = new BigQueryParameter();
            parameter.Value = value;
            var queryParameter = parameter.ToQueryParameter(BigQueryParameterMode.Positional);
            Assert.Equal(BigQueryDbType.Array.ToParameterApiType(), queryParameter.ParameterType.Type);
            var actualArrayType = EnumMap<BigQueryDbType>.ToValue(queryParameter.ParameterType.ArrayType.Type);
            Assert.Equal(expectedArrayType, actualArrayType);
        }

        [Fact]
        public void InvalidTypeIsRejected()
        {
            var parameter = new BigQueryParameter();
            Assert.Throws<ArgumentException>(() => parameter.Type = (BigQueryDbType)(-1));
        }

        [Fact]
        public void NeverValidValueIsRejected()
        {
            var parameter = new BigQueryParameter();
            Assert.Throws<ArgumentException>(() => parameter.Value = Guid.NewGuid());
        }

        [Fact]
        public void UnnamedParameterCannotBeConvertedWithNamedMode()
        {
            var parameter = new BigQueryParameter(BigQueryDbType.String, "foo");
            // Prove that it's fine for a positional parameter
            parameter.ToQueryParameter(BigQueryParameterMode.Positional);
            Assert.Throws<InvalidOperationException>(() => parameter.ToQueryParameter(BigQueryParameterMode.Named));
        }

        [Fact]
        public void StructParametersNotImplemented()
        {
            var parameter = new BigQueryParameter(BigQueryDbType.Struct, null);
            Assert.Throws<NotImplementedException>(() => parameter.ToQueryParameter(BigQueryParameterMode.Positional));
        }

        [Fact]
        public void ExplicitlyTypedArrayType()
        {
            var parameter = new BigQueryParameter(BigQueryDbType.Array, new[] { new DateTimeOffset(new DateTime(2016, 10, 31), new TimeSpan(8, 30, 0)) });
            parameter.ArrayType = BigQueryDbType.DateTime;
            string actualJson = JsonConvert.SerializeObject(parameter.ToQueryParameter(BigQueryParameterMode.Positional));

            var expectedResult = new QueryParameter
            {
                ParameterType = new QueryParameterType
                {
                    Type = BigQueryDbType.Array.ToParameterApiType(),
                    ArrayType = new QueryParameterType { Type = BigQueryDbType.DateTime.ToParameterApiType() }
                },
                ParameterValue = new QueryParameterValue
                {
                    ArrayValues = new[] { new QueryParameterValue { Value = "2016-10-31 00:00:00" } }
                }
            };
            string expectedJson = JsonConvert.SerializeObject(expectedResult);
            Assert.Equal(actualJson, expectedJson);
        }

        [Fact]
        public void Constructor_NameOnly()
        {
            var parameter = new BigQueryParameter("name");
            Assert.Equal("name", parameter.Name);
            Assert.Null(parameter.Type);
            Assert.Null(parameter.Value);
        }

        [Fact]
        public void Constructor_TypeOnly()
        {
            var parameter = new BigQueryParameter(BigQueryDbType.String);
            Assert.Null(parameter.Name);
            Assert.Equal(BigQueryDbType.String, parameter.Type);
            Assert.Null(parameter.Value);
        }

        private static object[] ScalarTest(string name, BigQueryDbType type, object parameterValue, string expectedValue) =>
            new object[]
            {
                name,
                new BigQueryParameter(type, parameterValue),
                ScalarParameter(type, expectedValue)
            };

        private static QueryParameter ScalarParameter(BigQueryDbType type, string value) =>
            new QueryParameter
            {
                ParameterType = new QueryParameterType { Type = type.ToParameterApiType() },
                ParameterValue = new QueryParameterValue { Value = value }
            };
    }
}
