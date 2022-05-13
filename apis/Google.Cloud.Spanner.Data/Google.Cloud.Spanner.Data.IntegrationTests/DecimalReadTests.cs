// Copyright 2022 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Spanner.V1;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DecimalTableFixture))]
    public class DecimalReadTests
    {
        private readonly DecimalTableFixture _fixture;

        public DecimalReadTests(DecimalTableFixture fixture) =>
            _fixture = fixture;

        public static IEnumerable<object[]> TestDecimals =>
            new List<object[]>
            {
                new object[] { 1.23456789m },
                new object[] { decimal.MinusOne },
                new object[] { decimal.Zero },
                new object[] { 123456789.01234m },
            };

        // decimal.MaxValue and decimal.MinValue will work only with numeric column and not with Float64.
        public static IEnumerable<object[]> MaxMinDecimals => 
            new List<object[]>
            {
                new object[] { decimal.MaxValue },
                new object[] { decimal.MinValue },             
            };

        // Test case: Simple case of using decimal value with Float64 column in database.
        // SpannerDbType is explicitly set for the parameter.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual(decimal expectedValue)
        {
            using var connection = _fixture.GetConnection();
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter("DecimalValue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
        }

        // Test Case: Using decimal with Float64 column in database. SpannerConversionOptions set to use Numeric for decimal.
        // SpannerDbType is explicitly set for the parameter.
        // The configuration should be ignored in .NET to Spanner path, as SpannerDbType of parameter is specified.
        // The configuration should be honored in Spanner to .NET path if ClrType isn't specified while reading.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_UseOptions(decimal expectedValue)
        {
            // Set the SpannerConversionOptions in the connection string.
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UseSpannerNumericForDecimal=true");
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter("DecimalValue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
            var numericValue = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerNumeric>();
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is SpannerNumeric);
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), (SpannerNumeric)value);
        }

        // Test Case: Using decimal with Float64 column in database without explicitly specifying SpannerDbType of parameter.
        // SpannerConversionOptions is not explicitly set, so Default option would be used.
        // Default type for decimal is Float64, so it will work with Float64 type column in database.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_WithoutSpannerDbType(decimal expectedValue)
        {
            using var connection = _fixture.GetConnection();
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    // Without options, SpannerDbType of parameter will default to Float64.
                    new SpannerParameter { ParameterName = "DecimalValue", Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();

            var decimalValue = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is double);
            Assert.Equal((double)expectedValue, value);
        }

        // Test Case: Using decimal with Float64 column in database without passing SpannerDbType of the parameter.
        // SpannerConversionOptions is set to use Numeric for decimal.
        // This should throw SpannerException as Float64 column expects Float64 value but Numeric value is passed.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteWithoutSpannerDbType_UseOptions(decimal expectedValue)
        {
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UseSpannerNumericForDecimal=true");
            // Writing the decimal value as numeric to Float64 column should throw SpannerException.
            await Assert.ThrowsAsync<SpannerException>(async () => 
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "DecimalValue", Value = expectedValue },
                }
            ).ExecuteNonQueryAsync());
        }

        // Normal case of using decimal with Numeric column in database.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        [MemberData(nameof(MaxMinDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_WithNumericColumn(decimal expectedValue)
        {
            using var connection = _fixture.GetConnection();
            // Write the decimal value as Numeric and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "NumericValue", SpannerDbType = SpannerDbType.Numeric, Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerNumeric>();
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), decimalValue);
        }

        // Case of using decimal with Numeric column in database.
        // SpannerConversionOptions is set to use Numeric for decimal.
        // The configuration should be ignored in .NET to Spanner path, as SpannerDbType of parameter is specified.
        // The configuration should be honored in Spanner to .NET path if ClrType isn't specified while reading.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        [MemberData(nameof(MaxMinDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_WithNumericColumn_UseOptions(decimal expectedValue)
        {
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UseSpannerNumericForDecimal=true");
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "NumericValue", SpannerDbType = SpannerDbType.Numeric, Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var numericValue = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerNumeric>();
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is SpannerNumeric);
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), (SpannerNumeric)value);
        }

        // Case of using decimal with Numeric column in database without specifying SpannerDbType of parameter. 
        // SpannerConversionOptions is not explicitly set, so Default of Float64 for decimal would be used.
        // This should throw SpannerException as Float64 type value would be provided to a Numeric column.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        [MemberData(nameof(MaxMinDecimals))]
        public async Task WriteWithoutSpannerDbType_WithNumericColumn(decimal expectedValue)
        {
            using var connection = _fixture.GetConnection();
            await Assert.ThrowsAsync<SpannerException>(async () =>
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "NumericValue", Value = expectedValue },
                }).ExecuteNonQueryAsync());
        }

        // Case of using decimal with Numeric column in database.
        // SpannerConversionOptions is set to use Numeric for decimal.
        // The configuration should be honored in .NET to Spanner path, as SpannerDbType of parameter isn't specified.
        // The configuration should be honored in Spanner to .NET path if ClrType isn't specified while reading.
        [Theory]
        [MemberData(nameof(TestDecimals))]
        [MemberData(nameof(MaxMinDecimals))]
        public async Task WriteThenReadWithoutSpannerDbType_ShouldBeEqual_WithNumericColumn_UseOptions(decimal expectedValue)
        {
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UseSpannerNumericForDecimal=true");
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    // SpannerDbType of Numeric will be used based on option.
                    new SpannerParameter { ParameterName = "NumericValue", Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var numericValue = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerNumeric>();
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is SpannerNumeric);
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), (SpannerNumeric)value);
        }
    }
}
