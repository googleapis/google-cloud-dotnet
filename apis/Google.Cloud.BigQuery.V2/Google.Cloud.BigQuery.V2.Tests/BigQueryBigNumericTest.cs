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

using Google.Cloud.ClientTesting;
using System;
using System.Globalization;
using System.Linq;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryBigNumericTest
    {
        private const string MaxText = "578960446186580977117854925043439539266.34992332820282019728792003956564819967";
        private const string MinText = "-578960446186580977117854925043439539266.34992332820282019728792003956564819968";
        private const string EpsilonText = "0.00000000000000000000000000000000000001";
        private const string NegativeEpsilonText = "-0.00000000000000000000000000000000000001";

        [Theory, CombinatorialData]
        public void ConversionFromDecimal(
            [CombinatorialValues(
            "1",
            "10",
            "1.123456789",
            "79228162514264337593543950335", // decimal.MaxValue
            "1234567890123456789012345678",
            "0.0000000000000000000000000001", // decimal epsilon
            "1.1234567891234567891234567891"
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryBigNumeric numeric = decimal.Parse(text, CultureInfo.InvariantCulture);
            Assert.Equal(text, numeric.ToString());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void ConversionFromInt32(int input)
        {
            BigQueryBigNumeric value = input;
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
            BigQueryBigNumeric value = input;
            Assert.Equal(input.ToString(CultureInfo.InvariantCulture), value.ToString());
        }

        [Theory]
        [InlineData(0UL)]
        [InlineData(1UL)]
        [InlineData(ulong.MaxValue)]
        public void ConversionFromUInt64(ulong input)
        {
            BigQueryBigNumeric value = input;
            Assert.Equal(input.ToString(CultureInfo.InvariantCulture), value.ToString());
        }

        [Theory, CombinatorialData]
        public void ToDecimal_Precise(
            [CombinatorialValues(
                "79228162514264337593543950335", // decimal.MaxValue
                "0.0000000000000000000000000001", // Epsilon for decimal
                "7.9228162514264337593543950335", // Maximum significant digits with 28 dps which is the max dps for decimal
                "7.2345678901234567890123456789",
                "8.234567890123456789012345678",
                "0.8234567890123456789012345678",
                "0.1234",
                "12300000000"
            )]
            string text, LossOfPrecisionHandling handling, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryBigNumeric numeric = BigQueryBigNumeric.Parse(text);
            decimal expected = decimal.Parse(text, CultureInfo.InvariantCulture);
            decimal actual = numeric.ToDecimal(handling);
            Assert.Equal(expected, actual);
        }

        [Theory, CombinatorialData]
        public void ToDecimal_Overflow([CombinatorialValues(
            "79228162514264337593543950336", // decimal.MaxValue + 1
            "123456789012345678901234567890" // 30 integer places
            )] string text, LossOfPrecisionHandling handling)
        {
            PerformTest(text, handling);
            PerformTest("-" + text, handling);

            static void PerformTest(string text, LossOfPrecisionHandling handling)
            {
                BigQueryBigNumeric numeric = BigQueryBigNumeric.Parse(text);
                Assert.Throws<OverflowException>(() => numeric.ToDecimal(handling));
            }
        }

        [Theory]
        [InlineData("79228162514264337593543950335.0000000001", "79228162514264337593543950335")]
        [InlineData("0.1234567891234567891234567899999", "0.1234567891234567891234567899")]
        [InlineData("1.1234567891234567891234567899999", "1.1234567891234567891234567899")]
        [InlineData("123456789012345678900.123456780", "123456789012345678900.12345678")]
        [InlineData("123456789012345678900.123456785", "123456789012345678900.12345678")]
        [InlineData("123456789012345678900.123456789", "123456789012345678900.12345678")]
        [InlineData("123456789012345678900.123456770", "123456789012345678900.12345677")]
        [InlineData("123456789012345678900.123456775", "123456789012345678900.12345677")]
        [InlineData("123456789012345678900.123456779", "123456789012345678900.12345677")]
        [InlineData("7.2345678901234567890123456789", "7.2345678901234567890123456789")]
        [InlineData("8.2345678901234567890123456789", "8.234567890123456789012345678")]
        [InlineData("0.82345678901234567890123456789", "0.8234567890123456789012345678")]
        public void ToDecimal_LossOfPrecision_Truncate(string text, string expectedDecimalText)
        {
            // It's easier to do this than to vary negation in other ways.
            PerformTest(text, expectedDecimalText);
            PerformTest("-" + text, "-" + expectedDecimalText);

            static void PerformTest(string text, string expectedDecimalText)
            {
                BigQueryBigNumeric numeric = BigQueryBigNumeric.Parse(text);
                decimal actual = numeric.ToDecimal(LossOfPrecisionHandling.Truncate);
                Assert.Equal(expectedDecimalText, actual.ToString(CultureInfo.InvariantCulture));
                // Conversion via the explicit conversion should do the same thing
                decimal actual2 = (decimal)numeric;
                Assert.Equal(actual, actual2);
            }
        }

        [Theory, CombinatorialData]
        public void ToDecimal_LossOfPrecision_Throw(
            [CombinatorialValues(
                "79228162514264337593543950335.00000000000000000000000000000000000001", // decimal.MaxValue + epsilon; doesn't count as overflow
                "123456789012345678900.123456789" // Simpler example of more significant digits than decimal can handle
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryBigNumeric numeric = BigQueryBigNumeric.Parse(text);
            Assert.Throws<InvalidOperationException>(() => numeric.ToDecimal(LossOfPrecisionHandling.Throw));
        }

        [Theory, CombinatorialData]
        public void ParseToStringRoundTrip(
            [CombinatorialValues(
                "123456789012345678901234567890123456789.89012345612345678901234567890123456789",
                "79228162514264337593543950335.00000000000000000000000000000000000001",
                MaxText,
                EpsilonText,
                "5",
                "50",
                "50.01",
                "0.1",
                "0.123",
                "0.00123"
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryBigNumeric numeric = BigQueryBigNumeric.Parse(text);
            Assert.Equal(text, numeric.ToString());

            // Check that TryParse works too
            Assert.True(BigQueryBigNumeric.TryParse(text, out var numeric2));
            Assert.Equal(numeric, numeric2);
        }

        [Theory]
        [InlineData("")]
        [InlineData("-")]
        [InlineData("+")]
        [InlineData("non-digits")]
        [InlineData("   ")]
        [InlineData(" 0")]
        [InlineData("0 ")]
        [InlineData(" 0 ")]
        // Overflow
        [InlineData("1000000000000000000000000000000000000000")]
        [InlineData("-1000000000000000000000000000000000000000")]
        [InlineData("578960446186580977117854925043439539266.34992332820282019728792003956564819968")]
        [InlineData("-578960446186580977117854925043439539266.34992332820282019728792003956564819969")]
        // Different parsing path but leading to overflow
        [InlineData("1000000000000000000000000000000000000000.0")]
        [InlineData("-1000000000000000000000000000000000000000.0")]
        // Things we may wish to make valid later
        [InlineData("+5")]
        [InlineData(".5")]
        [InlineData("-.5")]
        [InlineData("+.5")]
        [InlineData("1e6")]
        [InlineData("1e-6")]
        public void TryParse_Invalid(string text)
        {
            Assert.False(BigQueryBigNumeric.TryParse(text, out var value));
            Assert.Equal(BigQueryBigNumeric.Zero, value);
        }

        [Theory]
        [InlineData("1234,567", "es-ES")]
        [InlineData("1.234,567", "es-ES")]
        [InlineData("1234,567", "fr-FR")]
        public void TryParse_UnsupportedCultures(string text, string culture)
        {
            CultureInfo oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);

                // Just to demonstrate that these numbers are properly parsed with the given culture.
                // We don't parse them because we don't support the culture.
                Assert.True(decimal.TryParse(text, out decimal decimalValue));

                Assert.False(BigQueryBigNumeric.TryParse(text, out var value));
                Assert.Equal(BigQueryBigNumeric.Zero, value);
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ZeroIsDefaultValue()
        {
            Assert.Equal("0", default(BigQueryBigNumeric).ToString());
        }

        [Fact]
        public void Constants()
        {
            Assert.Equal(MaxText, BigQueryBigNumeric.MaxValue.ToString());
            Assert.Equal(MinText, BigQueryBigNumeric.MinValue.ToString());
            Assert.Equal(EpsilonText, BigQueryBigNumeric.Epsilon.ToString());
            Assert.Equal("0", BigQueryBigNumeric.Zero.ToString());
        }

        [Theory]
        [InlineData(MaxText, new[] { MaxText }, new[] { "578960446186580977117854925043439539266.34992332820282019728792003956564819966" })]
        [InlineData("1", new[] { "1.0", "1.00", "01" }, new[] { "-1", "0.99999999999999999999999999999999999999", "1.00000000000000000000000000000000000001" })]
        [InlineData("0", new[] { "0.0", "-0", "-0.0" }, new[] { "0.00000000000000000000000000000000000001", "-0.00000000000000000000000000000000000001" })]
        public void Equality(string controlText, string[] equalText, string[] unequalText)
        {
            BigQueryBigNumeric control = BigQueryBigNumeric.Parse(controlText);
            BigQueryBigNumeric[] equal = equalText.Select(BigQueryBigNumeric.Parse).ToArray();
            BigQueryBigNumeric[] unequal = unequalText.Select(BigQueryBigNumeric.Parse).ToArray();
            EqualityTester.AssertEqual(control, equal, unequal);
            EqualityTester.AssertEqualityOperators(control, equal, unequal);
        }

        [Theory]
        [InlineData("0", EpsilonText)]
        [InlineData(NegativeEpsilonText, "0")]
        [InlineData("-5", "2")]
        [InlineData("1.0", "1.1")]
        [InlineData("578960446186580977117854925043439539266.34992332820282019728792003956564819966", MaxText)]
        [InlineData(MinText, "-578960446186580977117854925043439539266.34992332820282019728792003956564819967")]
        public void CompareTo_Unequal(string smallerText, string biggerText)
        {
            var smaller = BigQueryBigNumeric.Parse(smallerText);
            var bigger = BigQueryBigNumeric.Parse(biggerText);
            Assert.InRange(smaller.CompareTo(bigger), int.MinValue, -1);
            Assert.InRange(bigger.CompareTo(smaller), 1, int.MaxValue);
            Assert.InRange(((IComparable)smaller).CompareTo(bigger), int.MinValue, -1);
            Assert.InRange(((IComparable)bigger).CompareTo(smaller), 1, int.MaxValue);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData(MaxText)]
        [InlineData(MinText)]
        [InlineData(EpsilonText)]
        public void CompareTo_Equal(string text)
        {
            var value = BigQueryBigNumeric.Parse(text);
            // To compare with a different instance.
            var value1 = BigQueryBigNumeric.Parse(text);
            Assert.Equal(0, value.CompareTo(value));
            Assert.Equal(0, (IComparable) value.CompareTo(value));
            Assert.Equal(0, value1.CompareTo(value));
            Assert.Equal(0, (IComparable) value1.CompareTo(value));
        }

        [Fact]
        public void CompareTo_NegativeZero()
        {
            // These really are the same value... we don't differentiate.
            var regularZero = BigQueryBigNumeric.Zero;
            var negativeZero = BigQueryBigNumeric.Parse("-0");
            Assert.Equal(0, regularZero.CompareTo(negativeZero));
            Assert.Equal(0, (IComparable) regularZero.CompareTo(negativeZero));
            Assert.Equal(0, negativeZero.CompareTo(regularZero));
            Assert.Equal(0, (IComparable) negativeZero.CompareTo(regularZero));
        }

        [Fact]
        public void CompareTo_Null()
        {
            IComparable minValue = BigQueryBigNumeric.MinValue;
            Assert.InRange(minValue.CompareTo(null), 1, int.MaxValue);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("1.1")]
        [InlineData(MaxText)]
        public void UnaryNegation(string text)
        {
            var positive = BigQueryBigNumeric.Parse(text);
            var negative = BigQueryBigNumeric.Parse("-" + text);
            Assert.Equal(negative, -positive);
            Assert.Equal(positive, -negative);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("1.1")]
        [InlineData("-1.1")]
        [InlineData(MaxText)]
        public void UnaryPlus(string text)
        {
            var value = BigQueryBigNumeric.Parse(text);
            Assert.Equal(value, +value);
        }

        [Theory]
        [InlineData("2", "3", "5")]
        [InlineData("1", "0.1", "1.1")]
        [InlineData("1", "-0.1", "0.9")]
        [InlineData("-1", "0.1", "-0.9")]
        public void Addition_Valid(string leftText, string rightText, string expectedText)
        {
            var left = BigQueryBigNumeric.Parse(leftText);
            var right = BigQueryBigNumeric.Parse(rightText);
            var expected = BigQueryBigNumeric.Parse(expectedText);
            Assert.Equal(expected, left + right);
        }

        [Theory]
        [InlineData("2", "3", "-1")]
        [InlineData("1", "0.1", "0.9")]
        [InlineData("1", "-0.1", "1.1")]
        [InlineData("-1", "0.1", "-1.1")]
        public void Subtraction_Valid(string leftText, string rightText, string expectedText)
        {
            var left = BigQueryBigNumeric.Parse(leftText);
            var right = BigQueryBigNumeric.Parse(rightText);
            var expected = BigQueryBigNumeric.Parse(expectedText);
            Assert.Equal(expected, left - right);
        }

        [Theory]
        [InlineData("289480223093290488558927462521719769633", "289480223093290488558927462521719769634")]
        [InlineData("-289480223093290488558927462521719769633", "-289480223093290488558927462521719769634")]
        [InlineData(MaxText, EpsilonText)]
        [InlineData(MinText, NegativeEpsilonText)]
        public void Addition_Overflow(string leftText, string rightText)
        {
            var left = BigQueryBigNumeric.Parse(leftText);
            var right = BigQueryBigNumeric.Parse(rightText);
            Assert.Throws<OverflowException>(() => left + right);
        }

        [Theory]
        [InlineData("289480223093290488558927462521719769633", "-289480223093290488558927462521719769634")]
        [InlineData("-289480223093290488558927462521719769633", "289480223093290488558927462521719769634")]
        [InlineData(MaxText, NegativeEpsilonText)]
        [InlineData(MinText, EpsilonText)]
        public void Subtraction_Overflow(string leftText, string rightText)
        {
            var left = BigQueryBigNumeric.Parse(leftText);
            var right = BigQueryBigNumeric.Parse(rightText);
            Assert.Throws<OverflowException>(() => left - right);
        }
    }
}
