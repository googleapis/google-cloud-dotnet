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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class PgNumericTests
    {
        private static readonly string MaxText = new string('9', 147455);

        private static readonly string MinText = "-" + MaxText;

        public static IEnumerable<object[]> RawValueInRangeData()
        {
            // The values are: scaled value, scale.
            // +-(BigInteger.Pow(10, 147455) - 1) is the max value for PgNumeric.
            // 16383 is the maximum scale for PgNumeric.
            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 0 };
            yield return new object[] { -BigInteger.Pow(10, 147455) + 1, 0 };

            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 123 };

            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 16383 };
            yield return new object[] { -BigInteger.Pow(10, 147455) + 1, 16383 };

            yield return new object[] { 1, 16383 };
            yield return new object[] { -1, 16383 };
            yield return new object[] { 123456789, 0 };
            yield return new object[] { -123456789, 0 };
            yield return new object[] { 123456789, 12345 };
            yield return new object[] { -123456789, 12345 };
        }

        public static IEnumerable<object[]> RawValueOutOfRangeData()
        {
            // The values are: scaled value, scale.
            // +-(BigInteger.Pow(10, 147455) - 1) is the max possible scaled value for PgNumeric.
            // 16383 is the maximum possible scale for PgNumeric.
            yield return new object[] { BigInteger.Pow(10, 147455), 0 };
            yield return new object[] { -BigInteger.Pow(10, 147455), 0 };
            yield return new object[] { BigInteger.Pow(10, 147455) + 1, 123 };
            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 16384 };
            yield return new object[] { -BigInteger.Pow(10, 147455) + 1, 16384 };
            yield return new object[] { 1, 16384 };
            yield return new object[] { -1, 16384 };
            yield return new object[] { 123456789, 123456 };
            yield return new object[] { -123456789, 123456 };
        }

        public static IEnumerable<object[]> ValidStringInputData()
        {
            // The values are: string input.
            yield return new object[] { "1.00" };
            yield return new object[] { "1.0" };
            yield return new object[] { "1.0000" };
            yield return new object[] { "-1.00" };
            yield return new object[] { "-0.00" };
            yield return new object[] { "0.0000000000000009" };
            yield return new object[] { "-0.0000000000000009" };
            yield return new object[] { "1234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891230.12345678912345678912345678912345678912345678" };
            yield return new object[] { "-1234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891230.12345678912345678912345678912345678912345678" };
            yield return new object[] { PgNumeric.MaxValue.ToString() };
            yield return new object[] { PgNumeric.MinValue.ToString() };
            yield return new object[] { (BigInteger.Pow(10, 147455) - 1).ToString() };
            yield return new object[] { (-(BigInteger.Pow(10, 147455) - 1)).ToString() };
            yield return new object[] { MaxText };
            yield return new object[] { MinText };
            yield return new object[] { PgNumeric.NaN.ToString() };
            yield return new object[] { "NaN" };
            yield return new object[] { "NAN" };
            yield return new object[] { "nan" };
        }

        public static IEnumerable<object[]> InvalidStringInputData()
        {
            // The values are: string input.
            yield return new object[] { "" };
            yield return new object[] { "       " };
            yield return new object[] { "abcdefg" };
            yield return new object[] { "Infinity" };
            yield return new object[] { "inf" };
            yield return new object[] { "-Infinity" };
            yield return new object[] { "-inf" };
            yield return new object[] { "ABCDEFGH" };
            yield return new object[] { "1.@#$%^&*" };
            yield return new object[] { "1.0!" };
            yield return new object[] { "1.00D" };
            yield return new object[] { "1.00M" };
            yield return new object[] { "1.00F" };
            yield return new object[] { ".0" };
            yield return new object[] { ".123456" };
            yield return new object[] { "-.123456" };
            yield return new object[] { " 1.00  " };
            yield return new object[] { " 0" };
            yield return new object[] { "0 " };
            yield return new object[] { " 0 " };
            yield return new object[] { "+5" };
            yield return new object[] { ".5" };
            yield return new object[] { "-.5" };
            yield return new object[] { "+.5" };
            yield return new object[] { "1e6" };
            yield return new object[] { "1e-6" };
            yield return new object[] { "1234,567" };
            yield return new object[] { "1.234,567" };
            yield return new object[] { (BigInteger.Pow(10, 147455)).ToString() };
            yield return new object[] { new string('9', 147456) };
            yield return new object[] { "-" + new string('9', 147456) };
            yield return new object[] { " NaN" };
            yield return new object[] { "NaN " };
        }

        public static IEnumerable<object[]> NaNComparisonData()
        {
            // The values are: string input1, string input2, and expected sign of comparision result.
            yield return new object[] { MaxText, "NaN", -1 };
            yield return new object[] { PgNumeric.MaxValue.ToString(), "NaN", -1 };
            yield return new object[] { (BigInteger.Pow(10, 147455) - 1).ToString(), "NaN", -1 };
            yield return new object[] { (-(BigInteger.Pow(10, 147455) - 1)).ToString(), "NaN", -1 };
            yield return new object[] { PgNumeric.MinValue.ToString(), "NaN", -1 };
            yield return new object[] { MinText, "NaN", -1 };
            yield return new object[] { "0", "NaN", -1 };
            yield return new object[] { "NaN", MaxText, 1 };
            yield return new object[] { "NaN", MinText, 1 };
            yield return new object[] { "NaN", "0", 1 };
        }

        public static IEnumerable<object[]> FromDecimalData()
        {
            // The values are: decimal input, expected string value.
            yield return new object[] { 0.00M, "0.00" };
            yield return new object[] { 1.00M, "1.00" };
            yield return new object[] { 1.01M, "1.01" };
            yield return new object[] { 99999.999999000M, "99999.999999000" };
            yield return new object[] { -0.000001M, "-0.000001" };
            yield return new object[] { 99999999999.999999999999M, "99999999999.999999999999" };
            yield return new object[] { -99999999999.99999999999M, "-99999999999.99999999999" };
            yield return new object[] { 100M, "100" };
            yield return new object[] { 1.33333333333333333M, "1.33333333333333333" };
        }

        [Theory]
        [InlineData("1.00", "1")]
        [InlineData("1", "1.00")]
        [InlineData("1", "1")]
        [InlineData("NaN", "NaN")]
        [InlineData("NAN", "Nan")]
        [InlineData("0.00", "000")]
        [InlineData("0.00", "0")]
        [InlineData("1.0000", "1.000")]
        [InlineData("-1.00", "-1.0")]
        [InlineData("0.00000009", "0.00000009")]
        [InlineData("0.00000009", "0.00000009000000")]
        [InlineData("0.00000009000000", "0.00000009")]
        [InlineData("123456789.123456789", "123456789.123456789")]
        [InlineData("-0.00", "0.0")]
        public void Equality(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var hashCode1 = number1.GetHashCode();
            var hashCode2 = number2.GetHashCode();
            Assert.True(number1.Equals(number2));
            Assert.True(number2.Equals(number1));
            Assert.True(number1.CompareTo(number2) == 0);
            Assert.True(number2.CompareTo(number1) == 0);
            Assert.Equal(hashCode1, hashCode2);
        }

        [Theory]
        [MemberData(nameof(NaNComparisonData))]
        public void CompareTo_NaN(string input1, string input2, int expectedResult)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            Assert.Equal(expectedResult, (IComparable)number1.CompareTo(number2));
            Assert.Equal(expectedResult, number1.CompareTo(number2));
            Assert.Equal(-expectedResult, (IComparable)number2.CompareTo(number1));
            Assert.Equal(-expectedResult, number2.CompareTo(number1));
        }

        [Fact]
        public void CompareTo_NegativeZero()
        {
            var regularZero = PgNumeric.Zero;
            var negativeZero = PgNumeric.Parse("-0");
            Assert.Equal(0, regularZero.CompareTo(negativeZero));
            Assert.Equal(0, (IComparable)regularZero.CompareTo(negativeZero));
            Assert.Equal(0, negativeZero.CompareTo(regularZero));
            Assert.Equal(0, (IComparable)negativeZero.CompareTo(regularZero));
        }

        [Fact]
        public void CompareTo_Null()
        {
            IComparable minValue = PgNumeric.MinValue;
            Assert.Equal(1, minValue.CompareTo(null));
        }

        [Theory]
        [InlineData("0.00", "001")]
        [InlineData("0.00", "1")]
        [InlineData("0.00", "0.01")]
        [InlineData("-1.0", "1.000")]
        [InlineData("-1.0", "0")]
        [InlineData("-10.0", "0.00000009000000000")]
        [InlineData("0", "1.00000000")]
        [InlineData("1", "1.01")]
        [InlineData("0.00000009", "0.0000008")]
        [InlineData("1.999999999999999999999999", "2")]
        [InlineData("99.90", "99.99")]
        [InlineData("-1.000", "1.0")]
        [InlineData("-123.0", "-1")]
        [InlineData("-0.0009", "0")]
        [InlineData("0.00000009", "0.00009")]
        public void CompareTo_LessThan(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var result = number1.CompareTo(number2);
            Assert.True(result < 0);
        }

        [Theory]
        [InlineData("001", "0.00")]
        [InlineData("1", "0.00")]
        [InlineData("0.01", "0.00")]
        [InlineData("1.000", "-1.0")]
        [InlineData("0", "-1.0")]
        [InlineData("0.00000009000000000", "-10.0")]
        [InlineData("1.00000000", "0")]
        [InlineData("1.01", "1")]
        [InlineData("0.0000008", "0.00000009")]
        [InlineData("2", "1.999999999999999999999999")]
        [InlineData("99.99", "99.90")]
        [InlineData("1.0", "-1.000")]
        [InlineData("-1", "-123.0")]
        [InlineData("0", "-0.0009")]
        [InlineData("0.00009", "0.00000009")]
        public void CompareTo_GreaterThan(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var result = number1.CompareTo(number2);
            Assert.True(result > 0);
        }

        [Theory]
        [MemberData(nameof(ValidStringInputData))]
        public void Parse_Valid(string input)
        {
            var numeric1 = PgNumeric.Parse(input);
            var success = PgNumeric.TryParse(input, out PgNumeric numeric2);
            Assert.True(success);
            Assert.Equal(numeric1, numeric2);
        }

        [Theory, CombinatorialData]
        public void ParseToStringRoundTrip(
           [CombinatorialValues(
                "123456789012345678901234567890123456789.89012345612345678901234567890123456789",
                "79228162514264337593543950335.00000000000000000000000000000000000001",
                "5",
                "50",
                "50.01",
                "0.1",
                "0.123",
                "0.00123"
            )] string text,
           bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }

            PgNumeric numeric = PgNumeric.Parse(text);
            Assert.Equal(text, numeric.ToString());

            // Check that TryParse works too
            Assert.True(PgNumeric.TryParse(text, out var numeric2));
            Assert.Equal(numeric, numeric2);
        }

        [Theory]
        [MemberData(nameof(InvalidStringInputData))]
        public void Parse_Invalid(string input)
        {
            Assert.Throws<FormatException>(() => PgNumeric.Parse(input));
            bool success = PgNumeric.TryParse(input, out PgNumeric number);
            Assert.Equal(PgNumeric.Zero, number);
            Assert.False(success);
        }

        [Theory]
        [InlineData("NaN", "NaN")]
        [InlineData("1.00", "1.00")]
        [InlineData("1.000000", "1.000000")]
        [InlineData("99999.999999000", "99999.999999000")]
        [InlineData("-0.000001", "-0.000001")]
        [InlineData("100", "100")]
        [InlineData("1.33333333333333333", "1.33333333333333333")]
        public void ToString_(string input, string expected)
        {
            PgNumeric pgNumeric = PgNumeric.Parse(input);
            Assert.Equal(expected, pgNumeric.ToString());
        }

        [Theory]
        [MemberData(nameof(FromDecimalData))]
        public void FromDecimal(decimal input, string expectedValue)
        {
            var numeric = PgNumeric.FromDecimal(input);
            Assert.Equal(expectedValue, numeric.ToString());
        }

        [Theory]
        [InlineData("0.00")]
        [InlineData("1.00")]
        [InlineData("1.01")]
        [InlineData("12345.123456000")]
        [InlineData("-0.000001")]
        [InlineData("1234567891.123456789123")]
        [InlineData("-12345678912.12345678912")]
        [InlineData("123456789123456789.12345678912")]
        [InlineData("12345678912345678912345678.1234567891234567891234")]
        [InlineData("9999999999999999999999999999.999999999999999999999999")]
        [InlineData("100")]
        [InlineData("1.33333333333333333")]
        public void ToDecimal(string input)
        {
            var numeric = PgNumeric.Parse(input);
            // decimal.Parse will silently lose precision if input has more significant digits than decimal can handle.
            decimal expected = decimal.Parse(input, CultureInfo.InvariantCulture);
            decimal actual = numeric.ToDecimal(LossOfPrecisionHandling.Truncate);
            Assert.Equal(expected, actual);
            // Conversion via the explicit conversion should do the same thing.
            decimal actual2 = (decimal)numeric;
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData("123456789012345678900.123456789", "123456789012345678900.12345679")]
        [InlineData("79228162514264337593543950335.0000000001", "79228162514264337593543950335")]
        public void ToDecimal_LossOfPrecision_Truncate(string input, string expectedValue)
        {
            // Decimal can take upto 29 digits. If input has more significant digits than decimal can handle, it will be truncated and
            // there will be loss of precision.
            var numeric = PgNumeric.Parse(input);
            var convertedDecimalString = numeric.ToDecimal(LossOfPrecisionHandling.Truncate).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(expectedValue, convertedDecimalString);
        }

        [Fact]
        public void ToDecimal_Overflow()
        {
            var numeric = PgNumeric.Parse("99999999999999999999999999999999.9999999999999999999999999999");
            Assert.Throws<OverflowException>(() => numeric.ToDecimal(LossOfPrecisionHandling.Truncate));
        }

        [Theory]
        [InlineData("12345678.1234567891234567891234567891")]
        [InlineData("123456789012345678900.123456789")]
        public void ToDecimal_LossOfPrecision_Throw(string input)
        {
            var numeric = PgNumeric.Parse(input);
            Assert.Throws<InvalidOperationException>(() => numeric.ToDecimal(LossOfPrecisionHandling.Throw));
        }

        [Theory]
        [MemberData(nameof(RawValueInRangeData))]
        public void IsRawValueInRange(BigInteger scaledValue, int scale)
        {
            var result = PgNumeric.IsRawValueInRange(scaledValue, scale);
            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(RawValueOutOfRangeData))]
        public void IsRawValueOutOfRange(BigInteger scaledValue, int scale)
        {
            var result = PgNumeric.IsRawValueInRange(scaledValue, scale);
            Assert.False(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void ConversionFromInt32(int input)
        {
            PgNumeric value = input;
            Assert.Equal(input.ToString(CultureInfo.InvariantCulture), value.ToString());
        }

        [Theory]
        [InlineData(0L)]
        [InlineData(1L)]
        [InlineData(-1L)]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        public void ConversionFromInt64(long input)
        {
            PgNumeric value = input;
            Assert.Equal(input.ToString(CultureInfo.InvariantCulture), value.ToString());
        }

        [Theory]
        [InlineData(0UL)]
        [InlineData(1UL)]
        [InlineData(ulong.MaxValue)]
        public void ConversionFromUInt64(ulong input)
        {
            PgNumeric value = input;
            Assert.Equal(input.ToString(CultureInfo.InvariantCulture), value.ToString());
        }

        [Fact]
        public void Constants()
        {
            Assert.Equal(MaxText, PgNumeric.MaxValue.ToString());
            Assert.Equal(MinText, PgNumeric.MinValue.ToString());
            Assert.Equal("0", PgNumeric.Zero.ToString());
            Assert.True(PgNumeric.Zero == default(PgNumeric));
            Assert.True(PgNumeric.Zero == new PgNumeric());
        }
    }
}