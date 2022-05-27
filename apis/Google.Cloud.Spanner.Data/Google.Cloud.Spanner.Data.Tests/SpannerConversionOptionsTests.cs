// Copyright 2022 Google Inc. All Rights Reserved.
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
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerConversionOptionsTests
    {
        [Fact]
        public void WithClrDefaultForNullSetting()
        {
            var options = SpannerConversionOptions.Default;
            options = options.WithClrDefaultForNullSetting(true);
            Assert.Equal(false, options.UseDBNull);
            options = options.WithClrDefaultForNullSetting(false);
            Assert.Equal(true, options.UseDBNull);
            
            // Test with builder as well.
            var builder = new SpannerConnectionStringBuilder();
            builder.UseClrDefaultForNull = true;
            Assert.Equal(false, builder.ConversionOptions.UseDBNull);

            // Explicitly set valid type mapping.
            builder = new SpannerConnectionStringBuilder("UseClrDefaultForNull=false");
            Assert.Equal(true, builder.ConversionOptions.UseDBNull);
        }

        [Fact]
        public void WithSpannerToClrMappings()
        {
            var options = SpannerConversionOptions.Default;
            options = options.WithSpannerToClrMappings("Float64ToPgNumeric,DateToDateTime");
            Assert.Equal(typeof(PgNumeric), options.Float64ToConfiguredClrType);
            Assert.Equal(typeof(DateTime), options.DateToConfiguredClrType);

            options = options.WithSpannerToClrMappings("Float64ToSingle,DateToSpannerDate");
            Assert.Equal(typeof(float), options.Float64ToConfiguredClrType);
            Assert.Equal(typeof(SpannerDate), options.DateToConfiguredClrType);
            
            // Test with builder as well.
            var builder = new SpannerConnectionStringBuilder();
            builder.SpannerToClrTypeDefaultMappings = "Float64ToDouble,DateToDateTime";
            Assert.Equal(typeof(double), builder.ConversionOptions.Float64ToConfiguredClrType);
            Assert.Equal(typeof(DateTime), builder.ConversionOptions.DateToConfiguredClrType);

            // Explicitly set valid type mapping.
            builder = new SpannerConnectionStringBuilder("SpannerToClrTypeDefaultMappings=Float64ToDecimal,DateToSpannerDate");
            Assert.Equal(typeof(decimal), builder.ConversionOptions.Float64ToConfiguredClrType);
            Assert.Equal(typeof(SpannerDate), builder.ConversionOptions.DateToConfiguredClrType);

            // Check that properties are case insensitive.
            builder = new SpannerConnectionStringBuilder();
            builder.SpannerToClrTypeDefaultMappings = "float64Todouble,datetodatetime";
            Assert.Equal(typeof(double), builder.ConversionOptions.Float64ToConfiguredClrType);
            Assert.Equal(typeof(DateTime), builder.ConversionOptions.DateToConfiguredClrType);
        }

        [Fact]
        public void WithClrToSpannerMappings()
        {
            var options = SpannerConversionOptions.Default;
            options = options.WithClrToSpannerMappings("DecimalToNumeric,DateTimeToDate");
            Assert.Equal(SpannerDbType.Numeric, options.DecimalToConfiguredSpannerType);
            Assert.Equal(SpannerDbType.Date, options.DateTimeToConfiguredSpannerType);

            options = options.WithClrToSpannerMappings("DecimalToPgNumeric,DateTimeToTimestamp");
            Assert.Equal(SpannerDbType.PgNumeric, options.DecimalToConfiguredSpannerType);
            Assert.Equal(SpannerDbType.Timestamp, options.DateTimeToConfiguredSpannerType);

            // Test with builder as well.
            var builder = new SpannerConnectionStringBuilder();
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal(SpannerDbType.Float64, builder.ConversionOptions.DecimalToConfiguredSpannerType);
            Assert.Equal(SpannerDbType.Date, builder.ConversionOptions.DateTimeToConfiguredSpannerType);

            // Explicitly set valid type mapping.
            builder = new SpannerConnectionStringBuilder("ClrToSpannerTypeDefaultMappings=DecimalToNumeric,DateTimeToTimestamp");
            Assert.Equal(SpannerDbType.Numeric, builder.ConversionOptions.DecimalToConfiguredSpannerType);
            Assert.Equal(SpannerDbType.Timestamp, builder.ConversionOptions.DateTimeToConfiguredSpannerType);

            // Check that properties are case-insensitive.
            builder = new SpannerConnectionStringBuilder();
            builder.ClrToSpannerTypeDefaultMappings = "decimaltofloat64,datetimeTodate";
            Assert.Equal(SpannerDbType.Float64, builder.ConversionOptions.DecimalToConfiguredSpannerType);
            Assert.Equal(SpannerDbType.Date, builder.ConversionOptions.DateTimeToConfiguredSpannerType);
        }

        [Theory]
        [InlineData("DecimalToFloat64,DecimalToNumeric,DateTimeToDate")] // Multiple mappings for a type.
        [InlineData("DecimalToFloat64,DecimalToPgNumeric,DateTimeToDate,DateTimeToTimestamp")] // Multiple mappings for a type.
        [InlineData("DecimalToFloat64   ,DecimalToNumeric,DateTimeToDate")] // Multiple mappings and whitespace.       
        [InlineData("DecimalToFloat64   ,  DateTimeToDate")] // Valid mapping with whitespace.
        [InlineData("UseFloat64ForDecimal,DecimalToNumeric,DateTimeToDate")] // Invalid values.
        public void BadClrToSpannerTypeDefaultMappingsThrows(string clrToSpannerTypeMappings)
        {
            var options = SpannerConversionOptions.Default;
            Assert.Throws<ArgumentException>(() => options.WithClrToSpannerMappings(clrToSpannerTypeMappings));
        }

        [Theory]
        [InlineData("Float64ToDouble,Float64ToDecimal,DateToDateTime")] // Multiple mappings for a type.
        [InlineData("Float64ToDecimal,Float64ToPgNumeric,DateToSpannerDate")] // Multiple mappings for a type.        
        [InlineData("Float64ToDecimal   ,DateToDateTime")] // Whitespace.
        [InlineData("Float64ToDecimal   ,  DateToDateTime")] // Whitespace.        
        [InlineData("UseDecimalForFloat,DateToSpannerDate")] // Invalid value.
        public void BadSpannerToClrTypeDefaultMappingsThrows(string spannerToClrTypeMappings)
        {
            var options = SpannerConversionOptions.Default;
            Assert.Throws<ArgumentException>(() => options.WithSpannerToClrMappings(spannerToClrTypeMappings));
        }
    }
}
