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

using Google.Api.Gax;
using System;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Google.Cloud.BigQuery.V2
{
    // TODO: Just call this Numeric? Probably too broad.
    // TODO: Implement IFormattable?

    /// <summary>
    /// Representation of the BigQuery NUMERIC type, which has 38 digits of precision,
    /// and a fixed scale of 9 decimal places to the right of the decimal point
    /// </summary>
    public struct BigQueryNumeric : IEquatable<BigQueryNumeric>, IComparable<BigQueryNumeric>
    {
        private static readonly BigInteger s_maxValue = BigInteger.Parse("99999999999999999999999999999999999999");
        private static readonly BigInteger s_minValue = -s_maxValue;

        private static readonly BigInteger[] s_powersOf10 = Enumerable.Range(0, 28).Select(p => BigInteger.Pow(10, p)).ToArray();

        private static readonly BigInteger s_integerScalingFactor = new BigInteger(1_000_000_000L);
        // TODO: Don't require a 0 before the decimal point.
        private static readonly Regex s_validation = new Regex(@"^-?[0-9]+\.?[0-9]*$");

        // Integer representation, always scaled by 9 decimal places - so a value of 1 here represents
        // a numeric value of 0.000000001 for example.
        private readonly BigInteger _integer;

        private BigQueryNumeric(BigInteger integer)
        {
            // TODO: Is OverflowException always appropriate?
            if (integer < s_minValue || integer > s_maxValue)
            {
                throw new OverflowException("Numeric value out of range");
            }
            _integer = integer;
        }

        /// <summary>
        /// Compares this value with <paramref name="other"/>.
        /// </summary>
        /// <param name="other">The value to compare with this one</param>
        /// <returns>A negative integer if this value is less than <paramref name="other"/>; a positive integer
        /// if it's greater than <paramref name="other"/>; zero if they're equal.</returns>
        public int CompareTo(BigQueryNumeric other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compares this value with <paramref name="other"/> for equality.
        /// </summary>
        /// <param name="other">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="other"/> is an equal <see cref="BigQueryNumeric"/> value; <c>false</c> otherwise.</returns>
        public bool Equals(BigQueryNumeric other) => _integer == other._integer;

        /// <summary>
        /// Compares this value with <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="obj"/> is an equal <see cref="BigQueryNumeric"/> value; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj) => obj is BigQueryNumeric other && Equals(other);

        /// <summary>
        /// Returns a hash code for this value.
        /// </summary>
        /// <returns>A hash code for this value.</returns>
        public override int GetHashCode() => _integer.GetHashCode();

        // TODO:
        // - Allow leading +?
        // - Allow .5 as well as 0.5?
        // - Allow 5. as well as 5.0 and 5?

        /// <summary>
        /// Parses a textual representation as a <see cref="BigQueryNumeric"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <paramref name="text"/> must be a representation of a decimal value which can be represented by <see cref="BigQueryNumeric"/>,
        /// using "." as a decimal place where one is specified, and a leading "-" for negative values. Leading zeroes and insignificant
        /// trailing digits are permitted.
        /// </para>
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="FormatException">The value could not be parsed as a <see cref="BigQueryNumeric"/>.</exception>
        public static BigQueryNumeric Parse(string text)
        {
            string message = TryParseImpl(text, out var value);
            return message == null ? value : throw new FormatException(message);
        }

        /// <summary>
        /// Attempts to parse a textual representation of a <see cref="BigQueryNumeric"/> value.
        /// </summary>
        /// <remarks>
        /// See <see cref="Parse"/> for format details. This method will return <c>true</c> if and only if
        /// <see cref="Parse"/> would return without an exception.
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <param name="value">The parsed value, or 0 on failure.</param>
        /// <returns><c>true</c> if <paramref name="text"/> was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string text, out BigQueryNumeric value)
        {
            string message = TryParseImpl(text, out value);
            return message == null;
        }

        /// <summary>
        /// Returns the error message for a FormatException if parsing fails, or null for success.
        /// </summary>
        private static string TryParseImpl(string text, out BigQueryNumeric value)
        {
            GaxPreconditions.CheckNotNull(text, nameof(text));
            if (!s_validation.IsMatch(text))
            {
                value = default;
                return "Text representation must be digits, containing an optional decimal point, and an optional leading '-' sign.";
            }
            int pointIndex = text.IndexOf('.');
            if (pointIndex != -1)
            {
                int decimalPlaces = text.Length - pointIndex - 1;
                text = text.Remove(pointIndex, 1);
                if (decimalPlaces > 9)
                {
                    text = text.Substring(0, text.Length - (decimalPlaces - 9));
                    decimalPlaces = 9;
                }
                BigInteger integer = BigInteger.Parse(text, CultureInfo.InvariantCulture);

                if (decimalPlaces < 9)
                {
                    integer = integer * s_powersOf10[9 - decimalPlaces];
                }
                value = new BigQueryNumeric(integer);
                return null;
            }
            else
            {
                BigInteger integer = BigInteger.Parse(text, CultureInfo.InvariantCulture);
                value = new BigQueryNumeric(integer * s_integerScalingFactor);
                return null;
            }
        }

        /// <summary>
        /// Returns a canonical string representation of this value. This always uses "." as a decimal point,
        /// and only includes as many decimal places as are required to completely represent the value. If
        /// the value is between -1 and 1 exclusive, a "0" character is included before the decimal point.
        /// </summary>
        /// <returns>A canonical string representation of this value.</returns>
        public override string ToString()
        {
            if (_integer.IsZero)
            {
                return "0";
            }
            var absInteger = BigInteger.Abs(_integer).ToString();
            // First get a string which will always have exactly 9 DPs
            string absResult;
            if (absInteger.Length <= 9)
            {
                absResult = "0." + absInteger.PadLeft(9, '0');
            }
            else
            {
                absResult = absInteger.Insert(absInteger.Length - 9, ".");
            }
            // Remove trailing 0s and .
            int finalLength = absResult.Length;
            while (absResult[finalLength - 1] == '0')
            {
                finalLength--;
            }
            if (absResult[finalLength - 1] == '.')
            {
                finalLength--;
            }
            if (absResult.Length != finalLength)
            {
                absResult = absResult.Substring(0, finalLength);
            }
            return _integer < 0 ? "-" + absResult : absResult;
        }

        /// <summary>
        /// Converts a <see cref="decimal"/> value to <see cref="BigQueryNumeric"/>, 
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, depending on <paramref name="lossOfPrecisionHandling"/>.
        /// </remarks>
        /// <param name="value">The value to convert</param>
        /// <param name="lossOfPrecisionHandling">How to handle values with signficant digits that would be lost by the conversion.</param>
        /// <returns>The converted value.</returns>
        public static BigQueryNumeric FromDecimal(decimal value, LossOfPrecisionHandling lossOfPrecisionHandling)
        {
            int[] bits = decimal.GetBits(value);

            BigInteger lowBits = new BigInteger((uint) bits[0]);
            BigInteger mediumBits = new BigInteger((uint) bits[1]) << 32;
            BigInteger highBits = new BigInteger((uint) bits[2]) << 64;
            BigInteger rawInteger = lowBits | mediumBits | highBits;
            
            int exponent = (bits[3] & 0x1f0000) >> 16;
            if (bits[3] < 0)
            {
                rawInteger = -rawInteger;
            }

            // TODO: All kinds of validation

            int scale = 9 - exponent;
            return scale < 0 ? new BigQueryNumeric(rawInteger / s_powersOf10[-scale])
                : new BigQueryNumeric(rawInteger * s_powersOf10[scale]);
        }

        // Conversions from CLR types to BigQueryNumeric

        /// <summary>
        /// Implicit conversion from <see cref="Decimal"/> to <see cref="BigQueryNumeric"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision. Use <see cref="FromDecimal"/> passing in <see cref="LossOfPrecisionHandling.Throw"/>
        /// for the second argument to avoid any information loss.
        /// </remarks>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator BigQueryNumeric(decimal value) =>
            FromDecimal(value, LossOfPrecisionHandling.Truncate);

        /// <summary>
        /// Implicit conversion from <see cref="Int64"/> to <see cref="BigQueryNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BigQueryNumeric(long value) =>
            new BigQueryNumeric(s_integerScalingFactor * value);

        /// <summary>
        /// Implicit conversion from <see cref="UInt64"/> to <see cref="BigQueryNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BigQueryNumeric(ulong value) =>
            new BigQueryNumeric(s_integerScalingFactor * value);

        // Conversions from BigQueryNumeric to CLR types.

        /// <summary>
        /// Converts this value to <see cref="BigQueryNumeric"/>, 
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, depending on <paramref name="lossOfPrecisionHandling"/>, but 
        /// will always throw <see cref="OverflowException"/> if value is out of the range of <see cref="Decimal"/>.
        /// </remarks>
        /// <param name="lossOfPrecisionHandling">How to handle values with signficant digits that would be lost by the conversion.</param>
        /// <exception cref="OverflowException">This value is outside the range of <see cref="Decimal"/>.</exception>
        /// <returns>The converted value.</returns>
        public decimal ToDecimal(LossOfPrecisionHandling lossOfPrecisionHandling)
        {
            // FIXME: Awful performance!
            string text = ToString();
            // Handles overflow
            decimal dec = Decimal.Parse(text, CultureInfo.InvariantCulture);
            if (lossOfPrecisionHandling == LossOfPrecisionHandling.Throw && this != (BigQueryNumeric) dec)
            {
                // TODO: Is this the right exception to use?
                throw new InvalidOperationException("Conversion would lose information");
            }
            return dec;
        }

        /// <summary>
        /// Implicit conversion from <see cref="BigQueryNumeric"/> to <see cref="Decimal"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, but will throw <see cref="OverflowException"/> if the value is out of
        /// range of <see cref="Decimal"/>. Use <see cref="ToDecimal"/> passing in <see cref="LossOfPrecisionHandling.Throw"/>
        /// for the second argument to avoid any information loss.
        /// </remarks>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator decimal(BigQueryNumeric value) =>
            value.ToDecimal(LossOfPrecisionHandling.Truncate);

        // Operators
        /// <summary>
        /// Compares two values for equality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>true</c> if the two arguments are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(BigQueryNumeric lhs, BigQueryNumeric rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Compares two values for inequality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>false</c> if the two arguments are equal; <c>true</c> otherwise.</returns>
        public static bool operator !=(BigQueryNumeric lhs, BigQueryNumeric rhs) => !lhs.Equals(rhs);

        /// <summary>
        /// Returns the result of adding two <see cref="BigQueryNumeric"/> values together.
        /// </summary>
        /// <param name="lhs">The first value to add.</param>
        /// <param name="rhs">The second value to add.</param>
        /// <returns>The result of adding the two values.</returns>
        public static BigQueryNumeric operator +(BigQueryNumeric lhs, BigQueryNumeric rhs) =>
            new BigQueryNumeric(lhs._integer + rhs._integer);

        /// <summary>
        /// Returns the result of subtracting one <see cref="BigQueryNumeric"/> value from another.
        /// </summary>
        /// <param name="lhs">The value to subtract from.</param>
        /// <param name="rhs">The value to subtract.</param>
        /// <returns>The result of subtracting <paramref name="rhs"/> from <paramref name="lhs"/>.</returns>
        public static BigQueryNumeric operator -(BigQueryNumeric lhs, BigQueryNumeric rhs) =>
            new BigQueryNumeric(lhs._integer - rhs._integer);

        /// <summary>
        /// The unary plus operator, provided mainly for consistency.
        /// </summary>
        /// <param name="value">The value to return.</param>
        /// <returns>The original value.</returns>
        public static BigQueryNumeric operator +(BigQueryNumeric value) => value;

        /// <summary>
        /// The unary negation operator.
        /// </summary>
        /// <param name="value">The value to negate.</param>
        /// <returns>The negation of <paramref name="value"/>.</returns>
        public static BigQueryNumeric operator -(BigQueryNumeric value) => new BigQueryNumeric(-value._integer);
    }

    /// <summary>
    /// Handling for a conversion that would lose precision.
    /// </summary>
    public enum LossOfPrecisionHandling
    {
        /// <summary>
        /// Truncate the loss of precision, truncating the result towards zero.
        /// </summary>
        Truncate,
        /// <summary>
        /// Throw an exception.
        /// </summary>
        Throw
    }
}
