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

using Google.Api.Gax;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Representation of PostgreSQL numeric type which has max precision of 147455 and a max scale of 16383. 
    /// </summary>
    public readonly struct PgNumeric : IEquatable<PgNumeric>, IComparable<PgNumeric>, IComparable
    {
        /// <summary>
        /// The maximum scale of numeric type.
        /// </summary>
        private const int MaxScale = 16383;

        /// <summary>
        /// The maximum precision of numeric type.
        /// </summary>
        private const int MaxPrecision = 147455;

        /// <summary>
        /// The string constant for not a number (NaN).
        /// </summary>
        private const string NotANumber = "NaN";

        // For a number of max precision P, the max value is 10^P - 1, i.e. all P digits are 9.
        // For instance for a number of max precision 4, the max value is 10^4 - 1 = 10_000 - 1 = 9_999.       
        private static readonly BigInteger s_maxValue = BigInteger.Pow(10, MaxPrecision) - 1;

        private static readonly BigInteger s_minValue = -s_maxValue;

        private static readonly ConcurrentDictionary<int, BigInteger> s_powersOf10 = new ConcurrentDictionary<int, BigInteger>();

        // TODO: Don't require a 0 before the decimal point.
        // TODO: Replace with manual validation if we find this is a performance bottleneck (as it was with BigQuery field name validations see #4976).
        private static readonly Regex s_validation = new Regex(@"^-?[0-9]+\.?[0-9]*$", RegexOptions.Compiled);

        // Note: the following properties must be declared *after* s_maxValue and s_minValue. Initialization order matters.

        /// <summary>
        /// Zero represented as a <see cref="PgNumeric"/>. This is the default value for the type.
        /// </summary>
        public static PgNumeric Zero { get; } = default;

        /// <summary>
        /// NaN (Not a number) represented as a <see cref="PgNumeric"/>. 
        /// </summary>
        public static PgNumeric NaN { get; } = new PgNumeric(0, 0, 0, true);

        /// <summary>
        /// The maximum valid value for <see cref="PgNumeric"/>, equal to BigInteger.Pow(10, 147455) - 1
        /// </summary>
        public static PgNumeric MaxValue { get; } = new PgNumeric(s_maxValue, 0, 0, false);

        /// <summary>
        /// The minimum valid value for <see cref="PgNumeric"/>, equal to -(BigInteger.Pow(10, 147455) - 1)
        /// </summary>
        public static PgNumeric MinValue { get; } = new PgNumeric(s_minValue, 0, 0, false);

        // The scaled value of PgNumeric without trailing zeros after the decimal point.
        // The values parsed from "100", "100.0", "100.0000" are all represented by _scaledValue = 100  and  _scale = 0.
        // The values parsed from "1234.567", "1234.5670",  "1234.5670000" are all represented by _scaledValue = 1234567 and _scale = 3.
        // The values parsed from "0.000012", "0.0000120", "0.0000120000" are all represented by _scaledValue = 12 and _scale = 6.
        private readonly BigInteger _scaledValue;

        // The scale of _scaledValue.
        private readonly int _scale;

        // Original trailing zeros after the decimal point which are not included in _scaledValue. 
        private readonly int _trailingZeros;

        // This flag would be true if PgNumeric is not a number.
        private readonly bool _notANumber;

        private PgNumeric(BigInteger scaledValue, int scale, int trailingZeros, bool notANumber)
        {
            if (notANumber && (scaledValue != default || scale != default || trailingZeros != default))
            {
                throw new ArgumentException($"PgNumeric can either be NaN or a number.If {nameof(notANumber)} is set to true, scaledValue, scale and trailingZeros must be set to default.", nameof(notANumber));
            }

            if (!IsRawValueInRange(scaledValue, scale))
            {
                throw new OverflowException("PgNumeric value out of range.");
            }

            _scale = scale;
            _notANumber = notANumber;
            // Maybe drop the decimal trailing zeros that would make the number have a bigger scale
            // than allowed. This is the same behaviour as .NET's decimal type.
            _trailingZeros = trailingZeros + scale > MaxScale ? MaxScale - scale : trailingZeros;
            _scaledValue = scaledValue;
        }

        // Internal for testing purposes only.
        internal static bool IsRawValueInRange(BigInteger scaledValue, int scale) => scaledValue >= s_minValue && scaledValue <= s_maxValue && scale >= 0 && scale <= MaxScale;

        ///<inheritdoc/>
        public int CompareTo(PgNumeric other)
        {
            // Check for NaN.
            // In order to allow numeric values to be sorted and used in tree-based indexes,
            // PostgreSQL treats NaN values as equal, and greater than all non-NaN values.
            if (_notANumber)
            {
                return other._notANumber ? 0 : 1;
            }

            // This PgNumeric is a number, the other number is NaN.
            if (other._notANumber)
            {
                return -1;
            }

            // If scale is the same, we can compare the scaled values.
            if (_scale == other._scale)
            {
                return _scaledValue.CompareTo(other._scaledValue);
            }

            // Return comparison of scaled values.
            if (_scale > other._scale)
            {
                return _scaledValue.CompareTo(ScaleTo(other, _scale));
            }

            return ScaleTo(this, other._scale).CompareTo(other._scaledValue);

            static BigInteger ScaleTo(PgNumeric number, int biggerScale)
            {
                int scaleDif = biggerScale - number._scale;
                return number._scaledValue * s_powersOf10.GetOrAdd(scaleDif, (scaleDif) => BigInteger.Pow(10, scaleDif));
            }
        }

        /// <summary>
        /// Implementation of <see cref="IComparable.CompareTo"/> to compare two <see cref="PgNumeric"/> values.
        /// </summary>
        /// <remarks>
        /// This uses explicit interface implementation to avoid it being called accidentally. The generic implementation should usually be preferred.
        /// </remarks>
        /// <exception cref="ArgumentException"><paramref name="obj"/> is non-null but does not refer to an instance of <see cref="PgNumeric"/>.</exception>
        /// <param name="obj">The object to compare this value with.</param>
        /// <returns>The result of comparing this value with <paramref name="obj"/>. <paramref name="obj"/> is null, this method returns a value greater than 0.
        /// </returns>
        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return obj is PgNumeric numeric
                ? CompareTo(numeric)
                : throw new ArgumentException($"Object must be of type {nameof(PgNumeric)}", nameof(obj));
        }

        /// <inheritdoc/>
        public bool Equals(PgNumeric other) => CompareTo(other) == 0;

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is PgNumeric other && Equals(other);

        /// <inheritdoc/>
        // Note that we don't include _trailingZeros in hash code calculation because decimal trailing zeros do not affect equality.
        public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(_notANumber ? -486187739 : -16777619, _scaledValue.GetHashCode(), _scale.GetHashCode());

        /// <summary>
        /// Parses a textual representation as a <see cref="PgNumeric"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <paramref name="text"/> must be a representation of a decimal value which can be represented by <see cref="PgNumeric"/>,
        /// using "." as a decimal place where one is specified, and a leading "-" for negative values. Leading zeroes and insignificant
        /// trailing digits are permitted.
        /// </para>
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="FormatException">The value could not be parsed as a <see cref="PgNumeric"/>.</exception>
        public static PgNumeric Parse(string text)
        {
            string message = TryParseImpl(text, out var value);
            return message == null ? value : throw new FormatException(message);
        }

        /// <summary>
        /// Attempts to parse a textual representation of a <see cref="PgNumeric"/> value.
        /// </summary>
        /// <remarks>
        /// See <see cref="Parse"/> for format details. This method will return <c>true</c> if and only if
        /// <see cref="Parse"/> would return without an exception.
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <param name="value">The parsed value, or 0 on failure.</param>
        /// <returns><c>true</c> if <paramref name="text"/> was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string text, out PgNumeric value)
        {
            string message = TryParseImpl(text, out value);
            return message == null;
        }

        /// <summary>
        /// Returns the error message for a FormatException if parsing fails, or null for success.
        /// </summary>
        private static string TryParseImpl(string text, out PgNumeric value)
        {
            GaxPreconditions.CheckNotNull(text, nameof(text));

            if (string.Equals(text, NotANumber, StringComparison.InvariantCultureIgnoreCase))
            {
                value = new PgNumeric(default, 0, 0, true);
                return null;
            }

            if (!s_validation.IsMatch(text))
            {
                value = default;
                return "Text representation must be digits, containing an optional decimal point, and an optional leading '-' sign or NaN.";
            }

            int pointIndex = text.IndexOf('.');

            // The raw value which will end up in the result, on success.
            BigInteger rawValue;
            int scale;
            int trailingZeros = 0;
            // If we have '.', then we need to extract the value and scale.
            if (pointIndex != -1)
            {
                int originalLength = text.Length;
                // Remove trailing Zeros after decimal, so that correct scale is calculated.
                // So, 1.000 will become 1., 1.001000 will become 1.001 and so on, while 100 will remain 100.
                text = text.TrimEnd('0');
                trailingZeros = originalLength - text.Length;
                int decimalPlaces = text.Length - pointIndex - 1;
                text = text.Remove(pointIndex, 1);
                scale = decimalPlaces;
                rawValue = BigInteger.Parse(text, CultureInfo.InvariantCulture);
            }
            else
            {
                // We don't have '.'
                rawValue = BigInteger.Parse(text, CultureInfo.InvariantCulture);
                scale = 0;
            }
            if (!IsRawValueInRange(rawValue, scale))
            {
                value = default;
                return "Parsed value would overflow the range of the type.";
            }
            value = new PgNumeric(rawValue, scale, trailingZeros, false);
            return null;
        }

        /// <summary>
        /// Returns a canonical string representation of this value. This always uses "." as a decimal point.
        /// If the value is between -1 and 1 exclusive, a "0" character is included before the decimal point.
        /// </summary>
        /// <returns>A canonical string representation of this value.</returns>
        public override string ToString()
        {
            if (_notANumber)
            {
                return NotANumber;
            }

            int sign = _scaledValue.Sign;
            if (sign == 0)
            {
                return _trailingZeros == 0 ? "0" : "0." + new string('0', _trailingZeros);
            }

            string integerText = _scaledValue.ToString(CultureInfo.InvariantCulture);

            // We can have a scaled value or a non-scaled value, check if its scaled. 
            if (_scale == 0)
            {
                return _trailingZeros == 0 ? integerText : integerText + '.' + new string('0', _trailingZeros);
            }

            int signLength = sign > 0 ? 0 : 1;

            // Always have something before the period, even if it's just a 0.
            int originalIntegerPlaces = Math.Max(integerText.Length - signLength - _scale, 0);
            int resultIntegerPlaces = Math.Max(originalIntegerPlaces, 1);

            // Sign, then integer part, then period (maybe), then significant decimals, then trailing zeros.
            int resultLength = signLength + resultIntegerPlaces + (_scale > 0 ? 1 : 0) + _scale + _trailingZeros;
            var chars = new char[resultLength];
            int targetPosition = 0;
            int sourcePosition = 0;

            // Copy some text from the original string representation, including the leading '-' if necessary.
            int leadCharactersToCopy = originalIntegerPlaces + signLength;
            for (; sourcePosition < leadCharactersToCopy; sourcePosition++)
            {
                chars[targetPosition++] = integerText[sourcePosition];
            }

            if (originalIntegerPlaces == 0)
            {
                chars[targetPosition++] = '0';
            }
            chars[targetPosition++] = '.';

            // Fill zeroes if necessary.
            if (originalIntegerPlaces == 0)
            {
                int decimalsToFill = _scale - (integerText.Length - signLength);
                for (int i = 0; i < decimalsToFill; i++)
                {
                    chars[targetPosition++] = '0';
                }
            }

            // Now the significant digits in the remaining text.
            for (; sourcePosition < integerText.Length; sourcePosition++)
            {
                chars[targetPosition++] = integerText[sourcePosition];
            }

            // Now the trailing zeros after the decimal point, if any.
            for (; targetPosition < chars.Length; targetPosition++)
            {
                chars[targetPosition] = '0';
            }

            return new string(chars);
        }

        /// <summary>
        /// Converts a <see cref="decimal"/> value to <see cref="PgNumeric"/>, 
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <returns>The converted value.</returns>
        public static PgNumeric FromDecimal(decimal value)
        {
            int[] bits = decimal.GetBits(value);

            BigInteger lowBits = new BigInteger((uint)bits[0]);
            BigInteger mediumBits = new BigInteger((uint)bits[1]) << 32;
            BigInteger highBits = new BigInteger((uint)bits[2]) << 64;
            BigInteger rawInteger = lowBits | mediumBits | highBits;

            int exponent = (bits[3] & 0x1f0000) >> 16;
            if (bits[3] < 0)
            {
                rawInteger = -rawInteger;
            }

            // Trim trailing zeros.
            int trailingZeros = 0;
            while (exponent > 0)
            {
                BigInteger divided = BigInteger.DivRem(rawInteger, 10, out BigInteger remainder);
                if (remainder != BigInteger.Zero)
                {
                    break;
                }

                exponent--;
                trailingZeros++;
                rawInteger = divided;
            }

            return new PgNumeric(rawInteger, exponent, trailingZeros, false);
        }

        // Conversions from CLR types to PgNumeric.

        /// <summary>
        /// Implicit conversion from <see cref="Decimal"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(decimal value) => FromDecimal(value);

        /// <summary>
        /// Implicit conversion from <see cref="Int32"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <remarks>
        /// This conversion exists to avoid ambiguity between the 64-bit conversions when using an integer literal.
        /// </remarks>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(int value) => new PgNumeric((long)value, 0, 0, false);

        /// <summary>
        /// Implicit conversion from <see cref="Int64"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(long value) => new PgNumeric(value, 0, 0, false);

        /// <summary>
        /// Implicit conversion from <see cref="UInt64"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(ulong value) => new PgNumeric(value, 0, 0, false);

        // Conversions from PgNumeric to CLR types.

        /// <summary>
        /// Converts this value to <see cref="PgNumeric"/>, 
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
            // Handles overflow.
            decimal dec = Decimal.Parse(text, CultureInfo.InvariantCulture);
            if (lossOfPrecisionHandling == LossOfPrecisionHandling.Throw && this != dec)
            {
                throw new InvalidOperationException("Conversion would lose information");
            }
            return dec;
        }

        /// <summary>
        /// Explicit conversion from <see cref="PgNumeric"/> to <see cref="Decimal"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, but will throw <see cref="OverflowException"/> if the value is out of
        /// range of <see cref="Decimal"/>. Use <see cref="ToDecimal"/> passing in <see cref="LossOfPrecisionHandling.Throw"/>
        /// for the second argument to avoid any information loss.
        /// </remarks>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator decimal(PgNumeric value) => value.ToDecimal(LossOfPrecisionHandling.Truncate);

        // Operators
        /// <summary>
        /// Compares two values for equality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>true</c> if the two arguments are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(PgNumeric lhs, PgNumeric rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Compares two values for inequality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>false</c> if the two arguments are equal; <c>true</c> otherwise.</returns>
        public static bool operator !=(PgNumeric lhs, PgNumeric rhs) => !lhs.Equals(rhs);
    }
}