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

using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DecimalTableFixturePostgre))]
    public class DecimalReadTestsPostgre
    {
        private readonly DecimalTableFixturePostgre _fixture;

        public DecimalReadTestsPostgre(DecimalTableFixturePostgre fixture) =>
            _fixture = fixture;

        public static IEnumerable<object[]> TestDecimals =>
            new List<object[]>
            {
                new object[] { new decimal(1.23456789) },
                new object[] { decimal.MinusOne },
                new object[] { decimal.Zero },
                new object[] { new decimal(123456789.0123456789012345678) },
            };

        public static IEnumerable<object[]> TestDecimalsWithPgNumeric =>
            new List<object[]>
            {
                new object[] { new decimal(1.23456789) },
                new object[] { decimal.MaxValue },
                new object[] { decimal.MinValue },
                new object[] { decimal.MinusOne },
                new object[] { decimal.Zero },
                new object[] { new decimal(123456789.0123456789012345678) },
            };

        // Test case: Simple case of using decimal value with Float8 column in database.
        // SpannerDbType is explicitly set for the parameter.
        [SkippableTheory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = _fixture.GetConnection();
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter ("id", SpannerDbType.Int64, 1),
                    // SpannerDbType Float64 maps to Float8 in Spanner PostgreSQL dialect.
                    // Henceforth, both are used interchangeably.
                    new SpannerParameter("decimalvalue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT decimalvalue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
        }

        // Test Case: Using decimal with Float8 column in database. SpannerConversionOptions set to use PgNumeric for decimal.
        // SpannerDbType is explicitly set for the parameter.
        // The configuration should be ignored in .NET to Spanner path, as SpannerDbType of parameter is specified.
        // The configuration should be honored in Spanner to .NET path if ClrType isn't specified while reading.
        [SkippableTheory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_UseOptions(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            // Set the SpannerConversionOptions in the connection string.
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UsePgNumericForDecimal=true");
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter ("id", SpannerDbType.Int64, 1),
                    new SpannerParameter("decimalvalue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT decimalvalue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
            var numericValue = await connection.CreateSelectCommand($"SELECT decimalvalue FROM {_fixture.TableName}").ExecuteScalarAsync<PgNumeric>();
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT decimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is PgNumeric);
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), (PgNumeric)value);
        }

        // Test Case: Using decimal with Float8 column in database without explicitly specifying SpannerDbType of parameter.
        // SpannerConversionOptions is not explicitly set, so Default option would be used.
        // Default SpannerDbType for decimal is Float64, so it will work with Float8 type column in database.
        [SkippableTheory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_WithoutSpannerDbType(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = _fixture.GetConnection();
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    // Without options, SpannerDbType of parameter will default to Float64.                    
                    new SpannerParameter ("id", SpannerDbType.Int64, 1),
                    new SpannerParameter { ParameterName = "decimalvalue", Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT decimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
        }

        // Test Case: Using decimal with Float8 column in database without passing SpannerDbType of the parameter.
        // SpannerConversionOptions is set to use PgNumeric for decimal.
        // This should throw SpannerException as Float8 column expects Float8 value but PgNumeric value is passed.
        [SkippableTheory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteWithoutSpannerDbType_UseOptions(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UsePgNumericForDecimal=true");
            await Assert.ThrowsAsync<SpannerException>(async () =>
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "id", SpannerDbType = SpannerDbType.Int64, Value = 1 },
                    new SpannerParameter { ParameterName = "decimalvalue", Value = expectedValue },
                }
            ).ExecuteNonQueryAsync());
        }

        // Normal case of using decimal with PgNumeric column in database.
        [SkippableTheory]
        [MemberData(nameof(TestDecimalsWithPgNumeric))]
        public async Task WriteThenRead_ShouldBeEqual_WithPgNumericColumn(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = _fixture.GetConnection();
            // Write the decimal value as PgNumeric and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "id", SpannerDbType = SpannerDbType.Int64, Value = 1 },
                    new SpannerParameter { ParameterName = "numericvalue", SpannerDbType = SpannerDbType.PgNumeric, Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT numericvalue FROM {_fixture.TableName}").ExecuteScalarAsync<PgNumeric>();
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), decimalValue);
        }

        // Case of using decimal with PgNumeric column in database.
        // SpannerConversionOptions is set to use PgNumeric for decimal.
        // The configuration should be ignored in .NET to Spanner path, as SpannerDbType of parameter is specified.
        // The configuration should be honored in Spanner to .NET path if ClrType isn't specified while reading.
        [SkippableTheory]
        [MemberData(nameof(TestDecimalsWithPgNumeric))]
        public async Task WriteThenRead_ShouldBeEqual_WithPgNumericColumn_UseOptions(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UsePgNumericForDecimal=true");
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "id", SpannerDbType = SpannerDbType.Int64, Value = 1 },
                    new SpannerParameter { ParameterName = "numericvalue", SpannerDbType = SpannerDbType.PgNumeric, Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var numericValue = await connection.CreateSelectCommand($"SELECT numericvalue FROM {_fixture.TableName}").ExecuteScalarAsync<PgNumeric>();
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT numericvalue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is PgNumeric);
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), (PgNumeric)value);
        }

        // Case of using decimal with PgNumeric column in database without specifying SpannerDbType of parameter. 
        // SpannerConversionOptions is not explicitly set, so Default of Float64 for decimal would be used.
        // This should throw SpannerException as Float64 type value would be provided to a PgNumeric column.
        [SkippableTheory]
        [MemberData(nameof(TestDecimalsWithPgNumeric))]
        public async Task WriteWithoutSpannerDbType_WithPgNumericColumn(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = _fixture.GetConnection();
            await Assert.ThrowsAsync<SpannerException>(async () =>
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "id", SpannerDbType = SpannerDbType.Int64, Value = 1 },
                    new SpannerParameter { ParameterName = "numericvalue", Value = expectedValue },
                }).ExecuteNonQueryAsync());
        }

        // Case of using decimal with PgNumeric column in database.
        // SpannerConversionOptions is set to use PgNumeric for decimal.
        // The configuration should be honored in .NET to Spanner path, as SpannerDbType of parameter isn't specified.
        // The configuration should be honored in Spanner to .NET path if ClrType isn't specified while reading.
        [SkippableTheory]
        [MemberData(nameof(TestDecimalsWithPgNumeric))]
        public async Task WriteThenReadWithoutSpannerDbType_ShouldBeEqual_WithPgNumericColumn_UseOptions(decimal expectedValue)
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator does not support PostgreSQL dialect.");
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UsePgNumericForDecimal=true");
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                    new SpannerParameter { ParameterName = "id", SpannerDbType = SpannerDbType.Int64, Value = 1 },
                    // SpannerDbType of PgNumeric will be used.
                    new SpannerParameter { ParameterName = "numericvalue", Value = expectedValue },
                }
            ).ExecuteNonQueryAsync();
            var numericValue = await connection.CreateSelectCommand($"SELECT numericvalue FROM {_fixture.TableName}").ExecuteScalarAsync<PgNumeric>();
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT numericvalue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is PgNumeric);
            Assert.Equal(PgNumeric.FromDecimal(expectedValue), (PgNumeric)value);
        }
    }
}
