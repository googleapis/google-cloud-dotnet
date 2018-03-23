// Copyright 2018 Google LLC
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
using System.Globalization;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryNumericTest
    {
        [Theory, CombinatorialData]
        public void ConversionFromDecimal(
            [CombinatorialValues(
            "1",
            "10",
            "1.123456789",
            "79228162514264337593543950335", // decimal.MaxValue
            "1234567890123456789012345678"
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            decimal parsed = decimal.Parse(text, CultureInfo.InvariantCulture);
            BigQueryNumeric numeric = (BigQueryNumeric) parsed;
            Assert.Equal(text, numeric.ToString());
        }

        // TODO: Conversions from decimal that are lossy.

        [Theory, CombinatorialData]
        public void ToDecimal_Precise(
            [CombinatorialValues(
                "79228162514264337593543950335", // decimal.MaxValue
                "0.000000001", // Epsilon for numeric
                "12345678901234567890.123456789" // Maximum significant digits with 9dps
            )]
            string text, LossOfPrecisionHandling handling, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryNumeric numeric = BigQueryNumeric.Parse(text);
            decimal expected = decimal.Parse(text, CultureInfo.InvariantCulture);
            decimal actual = numeric.ToDecimal(handling);
            Assert.Equal(expected, actual);
        }

        [Theory, CombinatorialData]
        public void ToDecimal_Overflow(LossOfPrecisionHandling handling, bool negate)
        {
            string text = "79228162514264337593543950336"; // decimal.MaxValue + 1
            BigQueryNumeric numeric = BigQueryNumeric.Parse(text);
            if (negate)
            {
                numeric = -numeric;
            }
            Assert.Throws<OverflowException>(() => numeric.ToDecimal(handling));
        }

        [Theory, CombinatorialData]
        public void ToDecimal_LossOfPrecision_Truncate(
            [CombinatorialValues(
                "79228162514264337593543950335.0000000001", // decimal.MaxValue + epsilon; doesn't count as overflow
                "123456789012345678900.123456789" // Simpler example of more significant digits than decimal can handle
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }            
            BigQueryNumeric numeric = BigQueryNumeric.Parse(text);
            // Decimal.Parse will silently lose precision
            decimal expected = decimal.Parse(text, CultureInfo.InvariantCulture);
            decimal actual = numeric.ToDecimal(LossOfPrecisionHandling.Truncate);
            Assert.Equal(expected, actual);
        }

        [Theory, CombinatorialData]
        public void ToDecimal_LossOfPrecision_Throw(
            [CombinatorialValues(
                "79228162514264337593543950335.000000001", // decimal.MaxValue + epsilon; doesn't count as overflow
                "123456789012345678900.123456789" // Simpler example of more significant digits than decimal can handle
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryNumeric numeric = BigQueryNumeric.Parse(text);
            Assert.Throws<InvalidOperationException>(() => numeric.ToDecimal(LossOfPrecisionHandling.Throw));
        }

        [Theory, CombinatorialData]
        public void ParseToStringRoundTrip(
            [CombinatorialValues(
                "123456789012345678901234567.890123456",
                "79228162514264337593543950335.000000001",
                "99999999999999999999999999999.999999999",
                "5",
                "50",
                "0.1",
                "0.000000001"
            )]
            string text, bool negate)
        {
            if (negate)
            {
                text = "-" + text;
            }
            BigQueryNumeric numeric = BigQueryNumeric.Parse(text);
            Assert.Equal(text, numeric.ToString());
        }
    }
}
