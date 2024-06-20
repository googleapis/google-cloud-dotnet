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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;
using static Google.Cloud.Spanner.Data.SpannerConversionOptions;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerParameterTests
    {
        private static readonly Rectangle testRectangle = new Rectangle
        {
            TopRight = new Point { X = 1, Y = 1 },
            Width = 10,
            Height = 5,
        };

        public static IEnumerable<object[]> GetDbTypeConversions()
        {
            yield return new object[] { SpannerDbType.Bytes, DbType.Binary, true };
            yield return new object[] { SpannerDbType.Bool, DbType.Boolean, true };
            yield return new object[] { SpannerDbType.Date, DbType.Date, true };
            yield return new object[] { SpannerDbType.Timestamp, DbType.DateTime, true };
            yield return new object[] { SpannerDbType.Float32, DbType.Single, true };
            yield return new object[] { SpannerDbType.Float64, DbType.Double, true };
            yield return new object[] { SpannerDbType.Int64, DbType.Int64, true };
            yield return new object[] { SpannerDbType.Numeric, DbType.VarNumeric, true };
            yield return new object[] { SpannerDbType.Unspecified, DbType.Object, true };
            yield return new object[] { SpannerDbType.String, DbType.String, true };
            // There is no DbType that will map automatically to SpannerDbType.Json, SpannerDbType.PgJsonb,
            // SpannerDbType.PgOid, or SpannerDbType protobuf.
            yield return new object[] { SpannerDbType.Json, DbType.String, false };
            yield return new object[] { SpannerDbType.PgJsonb, DbType.String, false };
            yield return new object[] { SpannerDbType.PgOid, DbType.Int64, false };
            yield return new object[] { SpannerDbType.FromClrType(typeof(Duration)), DbType.Object, false };
            yield return new object[] { SpannerDbType.FromClrType(typeof(Rectangle)), DbType.Object, false };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeConversions))]
        public void DbTypeMappings(SpannerDbType spannerType, DbType adoType, bool hasUniqueDbType)
        {
            var parameter = new SpannerParameter { SpannerDbType = spannerType };
            Assert.Equal(adoType, parameter.DbType);

            if (hasUniqueDbType)
            {
                parameter.ResetDbType();

                parameter.DbType = adoType;
                Assert.Equal(spannerType, parameter.SpannerDbType);
            }
        }

        // TODO: There are no values that will default to Spanner type JSON.
        public static IEnumerable<object[]> GetValueConversions()
        {
            yield return new object[] { new byte[] { 1 }, SpannerDbType.Bytes, DbType.Binary, typeof(byte[]) };
            yield return new object[] { new List<byte> { 1 }, SpannerDbType.Bytes, DbType.Binary, typeof(byte[]) };
            yield return new object[] { true, SpannerDbType.Bool, DbType.Boolean, typeof(bool) };
            yield return new object[] { new DateTime(2021, 1, 13, 12, 3, 10), SpannerDbType.Timestamp, DbType.DateTime, typeof(DateTime) };
            yield return new object[] { new SpannerDate(2021, 1, 13), SpannerDbType.Date, DbType.Date, typeof(DateTime) };

            yield return new object[] { 2.718f, SpannerDbType.Float32, DbType.Single, typeof(float) };

            yield return new object[] { 3.14d, SpannerDbType.Float64, DbType.Double, typeof(double) };

            yield return new object[] { 3.14m, SpannerDbType.Numeric, DbType.VarNumeric, typeof(SpannerNumeric) };

            yield return new object[] { (short)1, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { (ushort)1, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1u, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1L, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1uL, SpannerDbType.Int64, DbType.Int64, typeof(long) };

            yield return new object[] { (SpannerNumeric)3.14m, SpannerDbType.Numeric, DbType.VarNumeric, typeof(SpannerNumeric) };
            yield return new object[] { (PgNumeric)3.14m, SpannerDbType.PgNumeric, DbType.VarNumeric, typeof(PgNumeric) };
            yield return new object[] { "test", SpannerDbType.String, DbType.String, typeof(string) };

            // Tests for protobuf
            // Note that the default CLR type here is always Value, because in general, we only know the the name of the protobuf type and from there
            // we can't get the CLR type.
            // We test with Value specifically being used as the data type.
            yield return new object[] { Value.ForBool(true), SpannerDbType.FromClrType(typeof(Value)), DbType.Object, typeof(Value) };
            // We also test with Duration and Rectangle as a general case.
            yield return new object[] { Duration.FromTimeSpan(TimeSpan.FromSeconds(10)), SpannerDbType.FromClrType(typeof(Duration)), DbType.Object, typeof(Value) };
            yield return new object[] { testRectangle, SpannerDbType.FromClrType(typeof(Rectangle)), DbType.Object, typeof(Value) };
        }

        [Theory]
        [MemberData(nameof(GetValueConversions))]
        public void ValueMappings(object value, SpannerDbType spannerType, DbType adoType, System.Type defaultClrType)
        {
            var parameter = new SpannerParameter { Value = value };

            Assert.Equal(defaultClrType, spannerType.DefaultClrType);
            Assert.Equal(spannerType, parameter.SpannerDbType);
            Assert.Equal(adoType, parameter.DbType);
        }

        [Fact]
        public void ValueMappings_SerializedValue()
        {
            // Testing with an already serialized value requires that we set the SpannerDbType explicitly.
            object value = Value.ForString(Convert.ToBase64String(testRectangle.ToByteArray()));
            SpannerDbType spannerDbType = SpannerDbType.FromClrType(typeof(Rectangle));

            var parameter = new SpannerParameter { Value = value, SpannerDbType = spannerDbType };

            Assert.Equal(typeof(Value), spannerDbType.DefaultClrType);
            Assert.Equal(spannerDbType, parameter.SpannerDbType);
            Assert.Equal(DbType.Object, parameter.DbType);
        }

        public static IEnumerable<object[]> GetDbTypeSizes()
        {
            yield return new object[] { SpannerDbType.Bytes, 0 };
            yield return new object[] { SpannerDbType.Bytes, 10 };
            yield return new object[] { SpannerDbType.Bytes, int.MaxValue };
            yield return new object[] { SpannerDbType.String, 0 };
            yield return new object[] { SpannerDbType.String, 10 };
            yield return new object[] { SpannerDbType.String, int.MaxValue };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeSizes))]
        public void SizeTest(SpannerDbType spannerType, int size)
        {
            var parameter = new SpannerParameter { SpannerDbType = spannerType.WithSize(size) };
            Assert.Equal(parameter.Size, size);
            Assert.Equal(parameter.SpannerDbType.TypeCode, spannerType.TypeCode);

            parameter = new SpannerParameter
            {
                SpannerDbType = spannerType,
                Size = size
            };
            Assert.Equal(parameter.Size, size);
            Assert.Equal(parameter.SpannerDbType.TypeCode, spannerType.TypeCode);
        }

        public static IEnumerable<object[]> GetDbTypeSizesFailures()
        {
            yield return new object[] { SpannerDbType.Bytes, -1 };
            yield return new object[] { SpannerDbType.String, -1 };
            yield return new object[] { SpannerDbType.Bool, 0 };
            yield return new object[] { SpannerDbType.Date, 0 };
            yield return new object[] { SpannerDbType.Float32, 0 };
            yield return new object[] { SpannerDbType.Float64, 0 };
            yield return new object[] { SpannerDbType.Int64, 0 };
            yield return new object[] { SpannerDbType.PgOid, 0 };
            yield return new object[] { SpannerDbType.Timestamp, 0 };
            yield return new object[] { SpannerDbType.Json, 0 };
            yield return new object[] { SpannerDbType.PgJsonb, 0 };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeSizesFailures))]
        public void InvalidSizeTest(SpannerDbType spannerType, int size)
        {
            if (size == -1)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => new SpannerParameter {SpannerDbType = spannerType.WithSize(size)});
            }
            else
            {
                Assert.Throws<InvalidOperationException>(
                    () => new SpannerParameter { SpannerDbType = spannerType.WithSize(size) });
            }
        }

        public static IEnumerable<object[]> AllSpannerTypes()
        {
            yield return new object[] { SpannerDbType.Bytes };
            yield return new object[] { SpannerDbType.String };
            yield return new object[] { SpannerDbType.Bool };
            yield return new object[] { SpannerDbType.Date };
            yield return new object[] { SpannerDbType.Float32 };
            yield return new object[] { SpannerDbType.Float64 };
            yield return new object[] { SpannerDbType.Int64 };
            yield return new object[] { SpannerDbType.PgOid };
            yield return new object[] { SpannerDbType.Numeric };
            yield return new object[] { SpannerDbType.PgNumeric };
            yield return new object[] { SpannerDbType.Timestamp };
            yield return new object[] { SpannerDbType.Json };
            yield return new object[] { SpannerDbType.PgJsonb };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Bytes) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.String) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Bool) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Date) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Float32) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Float64) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Int64) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.PgOid) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Numeric) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.PgNumeric) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Timestamp) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.Json) };
            yield return new object[] { SpannerDbType.ArrayOf(SpannerDbType.PgJsonb) };
        }

        [Theory]
        [MemberData(nameof(AllSpannerTypes))]
        public void SetDefaultSize(SpannerDbType spannerType)
        {
            var param = new SpannerParameter { SpannerDbType = spannerType };
            // The default size should be 0 for all types.
            Assert.Equal(0, param.Size);
            // Setting the size to the same (default) value should be allowed for all types.
            param.Size = 0;
            Assert.Equal(0, param.Size);
        }

        public static IEnumerable<object[]> ConfiguredSpannerDbTypes()
        {
            // Format : SpannerParameter, SpannerConversionOptions, SpannerDbType.

            // Cases where SpannerDbType or DbType is not explicitly provided for SpannerParameter.
            // SpannerDbType will be inferred based on options if applicable.
            yield return new object[] { new SpannerParameter { Value = 2.718f },
               GetSpannerConversionOptions(default), SpannerDbType.Float32 };
            yield return new object[] { new SpannerParameter { Value = 2.718f },
                GetSpannerConversionOptions(SingleToFloat32), SpannerDbType.Float32 };
            yield return new object[] { new SpannerParameter { Value = 2.718f },
                GetSpannerConversionOptions(SingleToFloat64), SpannerDbType.Float64 };
            yield return new object[] { new SpannerParameter { Value = 3.14M },
               GetSpannerConversionOptions(default), SpannerDbType.Numeric };
            yield return new object[] { new SpannerParameter { Value = 3.14M },
                GetSpannerConversionOptions(DecimalToFloat64), SpannerDbType.Float64 };
            yield return new object[] { new SpannerParameter { Value = 3.14M },
                GetSpannerConversionOptions(DecimalToNumeric), SpannerDbType.Numeric };
            yield return new object[] { new SpannerParameter { Value = 3.14M },
                GetSpannerConversionOptions(DecimalToPgNumeric), SpannerDbType.PgNumeric };
            yield return new object[] { new SpannerParameter { Value = new DateTime(2022,05,24) },
                GetSpannerConversionOptions(default), SpannerDbType.Timestamp };
            yield return new object[] { new SpannerParameter { Value = new DateTime(2022,05,24) },
                GetSpannerConversionOptions(DateTimeToDate), SpannerDbType.Date };
            yield return new object[] { new SpannerParameter { Value = new DateTime(2022,05,24) },
                GetSpannerConversionOptions(DateTimeToTimestamp), SpannerDbType.Timestamp };
            // SpannerDate will always map to Date.
            yield return new object[] { new SpannerParameter { Value = new SpannerDate(2022,05,24) },
                GetSpannerConversionOptions(DateTimeToTimestamp), SpannerDbType.Date };

            // Cases where SpannerDbType is explicitly provided for SpannerParameter.
            // Options will be ignored.
            yield return new object[] { new SpannerParameter { Value = 2.718f, SpannerDbType = SpannerDbType.Float64 },
               GetSpannerConversionOptions(default), SpannerDbType.Float64 };
            yield return new object[] { new SpannerParameter { Value = 2.718f, SpannerDbType = SpannerDbType.Float64 },
                GetSpannerConversionOptions(SingleToFloat32), SpannerDbType.Float64 };
            yield return new object[] { new SpannerParameter { Value = 2.718f, SpannerDbType = SpannerDbType.Float32 },
                GetSpannerConversionOptions(SingleToFloat64), SpannerDbType.Float32 };
            yield return new object[] { new SpannerParameter { Value = 3.14M, SpannerDbType = SpannerDbType.Float64 },
                GetSpannerConversionOptions(DecimalToNumeric), SpannerDbType.Float64 };
            yield return new object[] { new SpannerParameter { Value = 3.14M, SpannerDbType = SpannerDbType.Float64 },
                GetSpannerConversionOptions(DecimalToPgNumeric), SpannerDbType.Float64 };
            yield return new object[] { new SpannerParameter { Value = 3.14M, SpannerDbType = SpannerDbType.Numeric },
                GetSpannerConversionOptions(DecimalToFloat64), SpannerDbType.Numeric };
            yield return new object[] { new SpannerParameter { Value = 3.14M, SpannerDbType = SpannerDbType.PgNumeric },
                GetSpannerConversionOptions(DecimalToFloat64), SpannerDbType.PgNumeric };
            yield return new object[] { new SpannerParameter { Value = new DateTime(2022,05,24), SpannerDbType = SpannerDbType.Date },
                GetSpannerConversionOptions(DateTimeToTimestamp), SpannerDbType.Date };
            yield return new object[] { new SpannerParameter { Value = new DateTime(2022,05,24), SpannerDbType = SpannerDbType.Timestamp },
                GetSpannerConversionOptions(DateTimeToDate), SpannerDbType.Timestamp };
        }

        private static SpannerConversionOptions GetSpannerConversionOptions(string clrToSpannerTypeMappings)
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder
            {
                ClrToSpannerTypeDefaultMappings = clrToSpannerTypeMappings
            };

            return ForConnectionStringBuilder(connectionStringBuilder);
        }

        [Theory]
        [MemberData(nameof(ConfiguredSpannerDbTypes))]
        internal void GetConfiguredSpannerDbType(SpannerParameter parameter, SpannerConversionOptions options, SpannerDbType expectedType)
        {
            var actualType = parameter.GetConfiguredSpannerDbType(options);
            Assert.Equal(expectedType, actualType);
        }
    }
}
