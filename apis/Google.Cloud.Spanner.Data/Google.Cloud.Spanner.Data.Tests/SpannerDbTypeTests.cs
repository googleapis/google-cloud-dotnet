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
using Xunit;
using static Google.Cloud.Spanner.Data.SpannerConversionOptions;

namespace Google.Cloud.Spanner.Data.Tests
{
    public partial class SpannerDbTypeTests
    {
        public static IEnumerable<object[]> GetSpannerDbTypes()
        {
            yield return new object[]
                {SpannerDbType.ArrayOf(SpannerDbType.String), SpannerDbType.ArrayOf(SpannerDbType.String)};
            yield return new object[]
                {SpannerDbType.ArrayOf(SpannerDbType.Bytes), SpannerDbType.ArrayOf(SpannerDbType.Bytes)};
            yield return new object[]
            {
                new SpannerStruct
                {
                    { "StringValue", SpannerDbType.String, null },
                    { "StringValue2", SpannerDbType.String, null },
                    { "JsonValue", SpannerDbType.Json, null },
                    { "PgJsonbValue", SpannerDbType.PgJsonb, null },
                    { "Float32Value", SpannerDbType.Float32, null },
                    { "Float64Value", SpannerDbType.Float64, null },
                    { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), null},
                }.GetSpannerDbType(),
                new SpannerStruct
                {
                    { "StringValue", SpannerDbType.String, null },
                    { "StringValue2", SpannerDbType.String, null },
                    { "JsonValue", SpannerDbType.Json, null },
                    { "PgJsonbValue", SpannerDbType.PgJsonb, null },
                    { "Float32Value", SpannerDbType.Float32, null },
                    { "Float64Value", SpannerDbType.Float64, null },
                    { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), null},
                }.GetSpannerDbType()
            };
            yield return new object[]
                {SpannerDbType.FromClrType(typeof(Duration)), SpannerDbType.ForProtobuf(Duration.Descriptor.FullName)};
            yield return new object[]
                {SpannerDbType.FromClrType(typeof(Rectangle)), SpannerDbType.ForProtobuf(Rectangle.Descriptor.FullName)};
        }

        [Theory]
        [MemberData(nameof(GetSpannerDbTypes))]
        public void EqualsTest(SpannerDbType spannerType1, SpannerDbType spannerType2)
        {
            Assert.Equal(spannerType1.GetHashCode(), spannerType2.GetHashCode());
            Assert.True(spannerType1.Equals(spannerType2));
        }

        public static IEnumerable<object[]> GetSpannerStringConversions()
        {
            yield return new object[] { "STRING", SpannerDbType.String };
            yield return new object[] { "STRING(MAX)", SpannerDbType.String };
            yield return new object[] { "BOOL", SpannerDbType.Bool };
            yield return new object[] { "BYTES", SpannerDbType.Bytes };
            yield return new object[] { "JSON", SpannerDbType.Json };
            yield return new object[] { "JSONB{PG}", SpannerDbType.PgJsonb };
            yield return new object[] { "DATE", SpannerDbType.Date };
            yield return new object[] { "FLOAT32", SpannerDbType.Float32 };
            yield return new object[] { "FLOAT64", SpannerDbType.Float64 };
            yield return new object[] { "INT64", SpannerDbType.Int64 };
            yield return new object[] { "OID{PG}", SpannerDbType.PgOid };
            yield return new object[] { "TIMESTAMP", SpannerDbType.Timestamp };
            yield return new object[] { "NUMERIC", SpannerDbType.Numeric };
            yield return new object[] { "NUMERIC{PG}", SpannerDbType.PgNumeric };

            yield return new object[] { " STRING  ", SpannerDbType.String };
            yield return new object[] { "  BOOL  ", SpannerDbType.Bool };
            yield return new object[] { "  BYTES  ", SpannerDbType.Bytes };
            yield return new object[] { "  JSON  ", SpannerDbType.Json };
            yield return new object[] { "  JSONB{PG}  ", SpannerDbType.PgJsonb };
            yield return new object[] { "  DATE  ", SpannerDbType.Date };
            yield return new object[] { "  FLOAT32  ", SpannerDbType.Float32 };
            yield return new object[] { "  FLOAT64  ", SpannerDbType.Float64 };
            yield return new object[] { "  INT64  ", SpannerDbType.Int64 };
            yield return new object[] { "  OID{PG}", SpannerDbType.PgOid };
            yield return new object[] { "  TIMESTAMP  ", SpannerDbType.Timestamp };
            yield return new object[] { "  NUMERIC  ", SpannerDbType.Numeric };
            yield return new object[] { "  NUMERIC{PG}  ", SpannerDbType.PgNumeric };
            yield return new object[] { " INTERVAL ", SpannerDbType.Interval };

            yield return new object[] { "STRING(2)", SpannerDbType.String.WithSize(2) };
            yield return new object[] { "STRING(100)", SpannerDbType.String.WithSize(100) };
            yield return new object[] { " STRING ( 100  )  ", SpannerDbType.String.WithSize(100) };
            yield return new object[] { "STRING (  MAX )", SpannerDbType.String };
            yield return new object[] { "STRING(100)", SpannerDbType.String, false };
            yield return new object[] { "BYTES(100)", SpannerDbType.Bytes.WithSize(100) };
            yield return new object[] { "BYTES(100)", SpannerDbType.Bytes, false };
            yield return new object[] { " BYTES ( 100  )  ", SpannerDbType.Bytes.WithSize(100) };

            //some common array types.
            yield return new object[] { "ARRAY<STRING>", SpannerDbType.ArrayOf(SpannerDbType.String) };
            yield return new object[] { "ARRAY<STRING(MAX)>", SpannerDbType.ArrayOf(SpannerDbType.String) };
            yield return new object[] { "ARRAY<STRING(5)>", SpannerDbType.ArrayOf(SpannerDbType.String.WithSize(5)) };
            yield return new object[] { "ARRAY<STRING>", SpannerDbType.ArrayOf(SpannerDbType.String) };
            yield return new object[] { "ARRAY<BOOL>", SpannerDbType.ArrayOf(SpannerDbType.Bool) };
            yield return new object[] { "ARRAY<BYTES>", SpannerDbType.ArrayOf(SpannerDbType.Bytes) };
            yield return new object[] { "ARRAY<BYTES(100)>", SpannerDbType.ArrayOf(SpannerDbType.Bytes.WithSize(100)) };
            yield return new object[] { "ARRAY<JSON>", SpannerDbType.ArrayOf(SpannerDbType.Json) };
            yield return new object[] { "ARRAY<JSONB{PG}>", SpannerDbType.ArrayOf(SpannerDbType.PgJsonb) };
            yield return new object[] { "ARRAY<DATE>", SpannerDbType.ArrayOf(SpannerDbType.Date) };
            yield return new object[] { "ARRAY<FLOAT32>", SpannerDbType.ArrayOf(SpannerDbType.Float32) };
            yield return new object[] { "ARRAY<FLOAT64>", SpannerDbType.ArrayOf(SpannerDbType.Float64) };
            yield return new object[] { "ARRAY<INT64>", SpannerDbType.ArrayOf(SpannerDbType.Int64) };
            yield return new object[] { "ARRAY<OID{PG}>", SpannerDbType.ArrayOf(SpannerDbType.PgOid) };
            yield return new object[] { "ARRAY<TIMESTAMP>", SpannerDbType.ArrayOf(SpannerDbType.Timestamp) };
            yield return new object[] { "ARRAY<INTERVAL>", SpannerDbType.ArrayOf(SpannerDbType.Interval) };

            yield return new object[] { "ARRAY<STRING(5)>", SpannerDbType.ArrayOf(SpannerDbType.String), false };
            yield return new object[] { "ARRAY<BYTES(5)>", SpannerDbType.ArrayOf(SpannerDbType.Bytes), false };

            yield return new object[] { $"PROTO<{Duration.Descriptor.FullName}>", SpannerDbType.FromClrType(typeof(Duration)) };
            yield return new object[] { $"ARRAY<PROTO<{Duration.Descriptor.FullName}>>", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Duration))) };

            yield return new object[] { $"PROTO<{Rectangle.Descriptor.FullName}>", SpannerDbType.FromClrType(typeof(Rectangle)) };
            yield return new object[] { $"ARRAY<PROTO<{Rectangle.Descriptor.FullName}>>", SpannerDbType.ArrayOf(SpannerDbType.FromClrType(typeof(Rectangle))) };

            yield return new object[] { "ARRAY <  STRING (   5 )>", SpannerDbType.ArrayOf(SpannerDbType.String.WithSize(5)) };
            yield return new object[] { "ARRAY<  STRING (   5 )  > ", SpannerDbType.ArrayOf(SpannerDbType.String.WithSize(5)) };


            // Structs

            // Empty struct
            yield return new object[] { "STRUCT<>", new SpannerStruct().GetSpannerDbType() };

            // Non-unique fields
            var sampleStruct = new SpannerStruct
            {
                { "F", SpannerDbType.String, null },
                { "F", SpannerDbType.Int64, null },
                { "G", SpannerDbType.String, null },
            };
            yield return new object[] { "STRUCT<F:STRING,F:INT64,G:STRING>", sampleStruct.GetSpannerDbType() };

            // Empty fields
            sampleStruct = new SpannerStruct
            {
                { "", SpannerDbType.String, null },
                { "F", SpannerDbType.Int64, null },
                { "", SpannerDbType.String, null },
            };
            yield return new object[] { "STRUCT<STRING,F:INT64,STRING>", sampleStruct.GetSpannerDbType() };

            sampleStruct = new SpannerStruct
            {
                { "F1", SpannerDbType.String, null },
                { "F2", SpannerDbType.Int64, null },
            };
            yield return new object[] { "STRUCT<F1:STRING,F2:INT64>", sampleStruct.GetSpannerDbType() };
            yield return new object[] { "STRUCT< F1 : STRING , F2  : INT64 >", sampleStruct.GetSpannerDbType() };

            sampleStruct = new SpannerStruct
            {
                { "F1", SpannerDbType.String, null },
                { "F2", SpannerDbType.Int64, null },
                { "F3", SpannerDbType.Bool, null },
                { "F4", SpannerDbType.Bytes, null },
                { "F5", SpannerDbType.Date, null },
                { "F6", SpannerDbType.Float32, null },
                { "F7", SpannerDbType.Float64, null },
                { "F8", SpannerDbType.Timestamp, null },
                { "F9", SpannerDbType.Numeric, null },
                { "F10", SpannerDbType.Json, null },
                { "F11", SpannerDbType.PgNumeric, null },
                { "F12", SpannerDbType.PgJsonb, null },
                { "F13", SpannerDbType.PgOid, null },
                { "F14", SpannerDbType.Interval, null}
            };
            yield return new object[] { "STRUCT<F1:STRING,F2:INT64,F3:BOOL,F4:BYTES,F5:DATE,F6:FLOAT32,F7:FLOAT64,F8:TIMESTAMP,F9:NUMERIC,F10:JSON,F11:NUMERIC{PG},F12:JSONB{PG},F13:OID{PG},F14:INTERVAL>", sampleStruct.GetSpannerDbType() };

            sampleStruct = new SpannerStruct
            {
                { "F1", SpannerDbType.String.WithSize(100), null },
                { "F2", SpannerDbType.Bytes.WithSize(200), null },
            };
            yield return new object[] { "STRUCT<F1: STRING(100), F2: BYTES(200)>", sampleStruct.GetSpannerDbType() };

            // Struct of struct
            var nestedStruct = new SpannerStruct { { "F2", SpannerDbType.Int64, null } };
            sampleStruct = new SpannerStruct
            {
                { "F1", nestedStruct.GetSpannerDbType(), null }
            };
            yield return new object[] { "STRUCT<F1:STRUCT<F2:INT64>>", sampleStruct.GetSpannerDbType() };

            // Struct of array
            sampleStruct = new SpannerStruct
            {
                { "F1", SpannerDbType.ArrayOf(SpannerDbType.Int64), null }
            };
            yield return new object[] { "STRUCT<F1:ARRAY<INT64>>", sampleStruct.GetSpannerDbType() };

            // Array of struct
            sampleStruct = new SpannerStruct
            {
                { "F1", SpannerDbType.Int64, null }
            };
            yield return new object[] { "ARRAY<STRUCT<F1:INT64>>", SpannerDbType.ArrayOf(sampleStruct.GetSpannerDbType()) };
        }

        [Theory]
        [MemberData(nameof(GetSpannerStringConversions))]
        public void StringConversions(string stringFormat, SpannerDbType spannerType, bool shouldEqual = true)
        {
            Assert.True(SpannerDbType.TryParse(stringFormat, out SpannerDbType result));
            if (shouldEqual)
            {
                Assert.Equal(spannerType, result);
            }
            else
            {
                Assert.NotEqual(spannerType, result);
            }

            //roundtrip test.
            Assert.True(SpannerDbType.TryParse(result.ToString(), out SpannerDbType result2));
            Assert.Equal(result, result2);
        }

        [Theory]
        [InlineData("RUBBISH")]
        [InlineData("STRUCT<F1:INT64")]
        [InlineData("STRUCT<F1:INT64,,F2:STRING>")] // Double comma
        [InlineData("STRUCT<F1:>")] // No type
        [InlineData("STRUCT<:INT64>")] // No name (but a colon)
        public void TryParse_Invalid(string text)
        {
            Assert.False(SpannerDbType.TryParse(text, out var result));
            Assert.Null(result);
        }

        [Fact]
        public void CommitTimestampConversion_Success()
        {
            var actual = SpannerDbType.Timestamp.ToProtobufValue(SpannerParameter.CommitTimestamp);
            var expected = new Value { StringValue = CommitTimestamp.ProtoStringValue };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CommitTimestampConversion_WrongType()
        {
            Assert.Throws<InvalidOperationException>(() => SpannerDbType.Date.ToProtobufValue(SpannerParameter.CommitTimestamp));
        }

        public static IEnumerable<object[]> ConfiguredClrTypes()
        {
            // Format : SpannerDbType, SpannerConversionOptions, expected ClrType.

            // Cases where type mapping will determine the CLR type.
            yield return new object[] { SpannerDbType.Date, GetSpannerConversionOptions(DateToDateTime), typeof(DateTime) };
            yield return new object[] { SpannerDbType.Date, GetSpannerConversionOptions(DateToSpannerDate), typeof(SpannerDate) };

            // Cases where type mapping is provided but will be ignored.
            // Mapping configuration is applicable only to Float64 and Date.
            // Type mappings will be ignored for all other SpannerDbType.
            yield return new object[] { SpannerDbType.Timestamp, GetSpannerConversionOptions(DateToDateTime), typeof(DateTime) };
            yield return new object[] { SpannerDbType.Timestamp, GetSpannerConversionOptions(DateToSpannerDate), typeof(DateTime) };

            // Cases where we should see default mapping as no type mapping is provided in the connection string.
            yield return new object[] { SpannerDbType.Float64, GetSpannerConversionOptions(default), typeof(double) };
            yield return new object[] { SpannerDbType.Timestamp, GetSpannerConversionOptions(default), typeof(DateTime) };
            yield return new object[] { SpannerDbType.Date, GetSpannerConversionOptions(default), typeof(DateTime) };

            // Cases where we should see default mapping as default SpannerConversionOptions are used.
            // Note: SpannerConversionOptions is never null for this method.
            yield return new object[] { SpannerDbType.Float64, Default, typeof(double) };
            yield return new object[] { SpannerDbType.Timestamp, Default, typeof(DateTime) };
            yield return new object[] { SpannerDbType.Date, Default, typeof(DateTime) };
        }

        private static SpannerConversionOptions GetSpannerConversionOptions(string spannerToClrTypeMappings)
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder
            {
                SpannerToClrTypeDefaultMappings = spannerToClrTypeMappings
            };

            return ForConnectionStringBuilder(connectionStringBuilder);
        }

        [Theory]
        [MemberData(nameof(ConfiguredClrTypes))]
        internal void GetConfiguredClrType(SpannerDbType dbType, SpannerConversionOptions options, System.Type expectedType)
        {
            var actualType = dbType.GetConfiguredClrType(options);
            Assert.Equal(expectedType, actualType);
        }
    }
}
