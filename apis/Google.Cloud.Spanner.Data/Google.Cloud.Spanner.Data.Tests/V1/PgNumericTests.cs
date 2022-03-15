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
using System.Numerics;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class PgNumericTests
    {
        public static IEnumerable<object[]> GetRawValueAndScales()
        {
            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 0, true };
            yield return new object[] { BigInteger.Pow(10, 147455), 0, false };
            yield return new object[] { -BigInteger.Pow(10, 147455), 0, false };
            yield return new object[] { -BigInteger.Pow(10, 147455) + 1, 0, true };

            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 110, false };
            yield return new object[] { BigInteger.Pow(10, 147455) + 1, 110, false };

            yield return new object[] { ((BigInteger.Pow(10, 131072) - 1)/BigInteger.Pow(10, 16383)), 16383, true };
            yield return new object[] { -((BigInteger.Pow(10, 131072) - 1)/BigInteger.Pow(10, 16383)), 16383, true };

            yield return new object[] { ((BigInteger.Pow(10, 131072) - 1) / BigInteger.Pow(10, 16383)), 16384, false };
            yield return new object[] { -((BigInteger.Pow(10, 131072) - 1) / BigInteger.Pow(10, 16383)), 16384, false };

            yield return new object[] { BigInteger.Pow(10, 147455) - 1, 16383, false };
            yield return new object[] { -BigInteger.Pow(10, 147455) + 1, 16383, false };
        }

        public static IEnumerable<object[]> GetStringInputs()
        {
            yield return new object[] { PgNumeric.MaxValue.ToString(), true };
            yield return new object[] { PgNumeric.MinValue.ToString(), true };
            yield return new object[] { (BigInteger.Pow(10, 147455) - 1).ToString(), true };
            yield return new object[] { (-(BigInteger.Pow(10, 147455) - 1)).ToString(), true };
            yield return new object[] { (BigInteger.Pow(10, 147455)).ToString(), false };
            yield return new object[] { (-(BigInteger.Pow(10, 147455) + 1)).ToString(), false };
            yield return new object[] { PgNumeric.NaN.ToString(), true };
        }

        [Theory]
        [InlineData("NaN", "NaN")]
        [InlineData("Nan", "nan")]
        [InlineData("0.00", "000")]
        [InlineData("-1.0", "-1.000")]
        [InlineData("-1", "-1.0")]
        [InlineData("1", "1.0")]
        [InlineData("0.00000009", "0.00000009")]
        [InlineData("-0.00", "0.0")]
        public void CompareToEqualValueTest(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var result = number1.CompareTo(number2);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("9999999999999", "NaN")]
        [InlineData("0.00", "001")]
        [InlineData("-1.0", "1.000")]
        [InlineData("-10.0", "0.00000009000000000")]
        [InlineData("0", "1.00000000")]
        [InlineData("1", "1.01")]
        [InlineData("0.00000009", "0.0000008")]
        public void CompareToGreaterValueTest(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var result = number1.CompareTo(number2);
            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData("NaN", "99999999999999999999999999999")]
        [InlineData("99.99", "99.90")]
        [InlineData("1.0", "-1.000")]
        [InlineData("-1", "-55.0")]
        [InlineData("0", "-0.0009")]
        [InlineData("0.00009", "0.00000009")]
        public void CompareToSmallerValueTest(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var result = number1.CompareTo(number2);
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData("1.00", "1")]
        [InlineData("1", "1.00")]
        [InlineData("NaN", "NaN")]
        [InlineData("NAN", "Nan")]
        [InlineData("1.0000", "1.000")]
        [InlineData("1.00", "1.0")]
        [InlineData("-1.00", "-1.0")]
        [InlineData("-0.00", "0.0")]
        public void EqualsTest(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var result = number1.Equals(number2);
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData("1.00", "1")]
        [InlineData("1", "1.00")]
        [InlineData("NaN", "NaN")]
        [InlineData("1.0000", "1.000")]
        [InlineData("999999999999999999999999999999999999999999999999.999999999999999999999999999999999999999", "999999999999999999999999999999999999999999999999.999999999999999999999999999999999999999")]
        [InlineData("-999999999999999999999999999999999999999999999999.999999999999999999999999999999999999999", "-999999999999999999999999999999999999999999999999.999999999999999999999999999999999999999")]
        [InlineData("1.00", "1.0")]
        [InlineData("-1.00", "-1.0")]
        [InlineData("-0.00", "0.0")]
        public void GetHashCodeTest(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var hashCode1 = number1.GetHashCode();
            var hashCode2 = number2.GetHashCode();
            Assert.Equal(hashCode1, hashCode2);
        }

        [Theory]
        [InlineData("1.00", "1")]
        [InlineData("1", "1.00")]
        [InlineData("NaN", "NaN")]
        [InlineData("1.0000", "1.000")]
        [InlineData("1.00", "1.0")]
        [InlineData("-1.00", "-1.0")]
        [InlineData("-0.00", "0.0")]
        public void GetNormalizedValueTest(string input1, string input2)
        {
            var number1 = PgNumeric.Parse(input1);
            var number2 = PgNumeric.Parse(input2);
            var normalizedValue1 = number1.GetNormalizedValue();
            var normalizedValue2 = number2.GetNormalizedValue();
            Assert.Equal(normalizedValue1, normalizedValue2);
        }

        [Theory]
        [InlineData("1.00")]
        [InlineData("1.0")]
        [InlineData("NaN")]
        [InlineData("1.0000")]
        [InlineData("-1.00")]
        [InlineData("-0.00")]
        [InlineData("0.0000000000000009")]
        [InlineData("-0.0000000000000009")]
        [InlineData("9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999990.99999999999999999999999999999999999999999999")]
        [InlineData("-9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999990.99999999999999999999999999999999999999999999")]
        public void ParseValidTest(string input)
        {
            var number = PgNumeric.Parse(input);
            Assert.IsType<PgNumeric>(number);
            Assert.NotNull(number.ToString());
        }

        [Theory]
        [MemberData(nameof(GetStringInputs))]
        public void ParseTest(string input, bool expectedParsingResult)
        {
            try
            {
                var result = PgNumeric.Parse(input);
                Assert.Equal(true, expectedParsingResult);
            }
            catch (FormatException)
            {
                Assert.Equal(false, expectedParsingResult);
            }
        }

        [Theory]
        [InlineData(null)]
        public void ParseNullTest(string input)
        {
            Assert.Throws<ArgumentNullException>(() => PgNumeric.Parse(input));
        }

        [Theory]
        [InlineData("")]
        [InlineData("       ")]
        [InlineData("abcdefg")]
        [InlineData("Infinity")]
        [InlineData("inf")]
        [InlineData("-Infinity")]
        [InlineData("-inf")]
        [InlineData("ABCDEFGH")]
        [InlineData("1.@#$%^&*")]
        [InlineData("1.0!")]
        [InlineData("1.00D")]
        [InlineData("1.00M")]
        [InlineData("1.00F")]
        // Space before and/or after valid number. We can call .Trim() on input, but should we? Its an invalid input.
        // Also, SpannerNumeric doesn't do that, so its consistent. We should call Trim() on both or on neither.
        [InlineData(" 1.00  ")]
        public void ParseInValidTest(string input)
        {
            Assert.Throws<FormatException>(() => PgNumeric.Parse(input));
        }

        [Theory]
        [InlineData("1.00")]
        [InlineData("1.0")]
        [InlineData("NaN")]
        [InlineData("1.0000")]
        [InlineData("-1.00")]
        [InlineData("-0.00")]
        [InlineData("0.0000000000000009")]
        [InlineData("-0.0000000000000009")]
        [InlineData("9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999990.99999999999999999999999999999999999999999999")]
        [InlineData("-9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999990.99999999999999999999999999999999999999999999")]
        public void TryParseValidTest(string input)
        {
            var success = PgNumeric.TryParse(input, out PgNumeric number);
            Assert.IsType<PgNumeric>(number);
            Assert.NotNull(number.ToString());
            Assert.True(success);
        }

        [Theory]
        [InlineData(null)]
        public void TryParseNullTest(string input)
        {
            // It's a strange case in which TryParse throws exception. Is it fine?
            Assert.Throws<ArgumentNullException>(() => PgNumeric.TryParse(input, out PgNumeric number));
        }

        [Theory]
        [InlineData("")]
        [InlineData("       ")]
        [InlineData("abcdefg")]
        [InlineData("Infinity")]
        [InlineData("inf")]
        [InlineData("-Infinity")]
        [InlineData("-inf")]
        [InlineData("ABCDEFGH")]
        [InlineData("1.@#$%^&*")]
        [InlineData("1.0!")]
        [InlineData("1.00D")]
        [InlineData("1.00M")]
        [InlineData("1.00F")]
        [InlineData(" 1.00  ")]
        public void TryParseInValidTest(string input)
        {
            bool success = PgNumeric.TryParse(input, out PgNumeric number);
            Assert.Equal(PgNumeric.Zero, number);
            Assert.False(success);
        }

        [Theory]
        [InlineData("NaN", "NaN")]
        [InlineData("1.00", "1")]
        [InlineData("1.000000", "1")]
        [InlineData("99999.999999000", "99999.999999")]
        [InlineData("-0.000001", "-0.000001")]
        [InlineData("100", "100")]
        [InlineData("1.33333333333333333", "1.33333333333333333")]
        public void ToStringTest(string input, string expected)
        {
            PgNumeric pgNumeric = PgNumeric.Parse(input);
            Assert.Equal(expected, pgNumeric.ToString());
        }

        [Theory]
        [InlineData("0.00", "0")]
        [InlineData("1.00", "1.00")]
        [InlineData("1.01", "1.01")]
        [InlineData("99999.999999000", "99999.999999000")]
        [InlineData("-0.000001", "-0.000001")]
        [InlineData("99999999999.999999999999", "99999999999.999999999999")]
        [InlineData("-99999999999.99999999999", "-99999999999.99999999999")]
        [InlineData("100", "100")]
        [InlineData("1.33333333333333333", "1.33333333333333333")]
        public void FromDecimalTest(string input, string expectedValue)
        {
            var decimalValue = decimal.Parse(input);
            var numeric = PgNumeric.FromDecimal(decimalValue);
            Assert.Equal(expectedValue, numeric.ToString());
        }

        [Theory]
        [InlineData("0.00", "0")]
        [InlineData("1.00", "1.00")]
        [InlineData("1.01", "1.01")]
        [InlineData("99999.999999000", "99999.999999000")]
        [InlineData("-0.000001", "-0.000001")]
        [InlineData("99999999999.999999999999", "99999999999.999999999999")]
        [InlineData("-99999999999.99999999999", "-99999999999.99999999999")]
        [InlineData("999999999999999999.99999999999", "999999999999999999.99999999999")]
        [InlineData("99999999999999999999999999.9999999999999999999999", "99999999999999999999999999.9999999999999999999999")]
        [InlineData("9999999999999999999999999999.999999999999999999999999", "9999999999999999999999999999.999999999999999999999999")]
        [InlineData("100", "100")]
        [InlineData("1.33333333333333333", "1.33333333333333333")]
        public void ToDecimalTest(string input, string expectedValue)
        {
            var numeric = PgNumeric.Parse(input);
            var decimalValue = numeric.ToDecimal(LossOfPrecisionHandling.Truncate);
            Assert.Equal(decimal.Parse(expectedValue), decimalValue);
        }

        [Theory]
        [InlineData("99999999999999999999999999999999.9999999999999999999999999999")]
        public void ToDecimalOverflowTest(string input)
        {
            var numeric = PgNumeric.Parse(input);
            Assert.Throws<OverflowException>(() => numeric.ToDecimal(LossOfPrecisionHandling.Truncate));
        }

        [Theory]
        [InlineData("99999999.9999999999999999999999999999")]
        public void ToDecimalLossOfPrecisionTest(string input)
        {
            var numeric = PgNumeric.Parse(input);
            Assert.Throws<InvalidOperationException>(() => numeric.ToDecimal(LossOfPrecisionHandling.Throw));
        }

        [Theory]
        [MemberData(nameof(GetRawValueAndScales))]
        public void IsRawValueInRangeTest(BigInteger scaledValue, int scale, bool isInRange)
        {
            var result = PgNumeric.IsRawValueInRange(scaledValue, scale);
            Assert.Equal(isInRange, result);
        }
    }
}