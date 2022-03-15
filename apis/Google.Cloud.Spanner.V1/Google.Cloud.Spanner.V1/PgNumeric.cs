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
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Representation of PostgreSQL numeric type which has max precision of 147,455 and a max scale of 16383. 
    /// </summary>
    public struct PgNumeric : IEquatable<PgNumeric>, IComparable<PgNumeric>, IComparable
    {
        /// <summary>
        /// The maximum number of digits before decimal point.
        /// </summary>
        private const int MaxDigitsBeforeDecimalPoint = 131072;

        /// <summary>
        /// The maximum scale of numeric type.
        /// </summary>
        private const int MaxScale = 16383;

        /// <summary>
        /// The maximum precision of numeric type.
        /// </summary>
        private const int MaxPrecision = MaxDigitsBeforeDecimalPoint + MaxScale;

        /// <summary>
        /// The string constant for not a number (NaN).
        /// </summary>
        private const string NotANumber = "NaN";

        // For a numeric(precision, scale) maximum and minimum values are defined as +- ((10^precision)-1)/(10^scale), so maximum possible numeric would be numeric
        // with max precision and zero scale, i.e. numeric(147455, 0), and its max and min values would be ((BigInteger.Pow(10, 147455)-1)/(BigInteger.Pow(10, 0)))
        // Read here: https://stackoverflow.com/questions/26396856/determine-postgres-numeric-max-min-values       
        private static readonly BigInteger s_maxValueWithoutScale = BigInteger.Pow(10, MaxPrecision) - 1;

        private static readonly BigInteger s_maxValueWithScale = ((BigInteger.Pow(10, MaxDigitsBeforeDecimalPoint) - 1) / (BigInteger.Pow(10, MaxScale)));

        private static readonly BigInteger s_minValueWithScale = -s_maxValueWithScale;

        private static readonly BigInteger s_minValueWithoutScale = -s_maxValueWithoutScale;

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
        public static PgNumeric NaN { get; } = Parse(NotANumber);

        /// <summary>
        /// The maximum valid value for <see cref="PgNumeric"/>, equal to BigInteger.Pow(10, MaxPrecision) - 1
        /// </summary>
        public static PgNumeric MaxValue { get; } = new PgNumeric(s_maxValueWithoutScale, 0, false);

        /// <summary>
        /// The minimum valid value for <see cref="PgNumeric"/>, equal to -(BigInteger.Pow(10, MaxPrecision) - 1)
        /// </summary>
        public static PgNumeric MinValue { get; } = new PgNumeric(s_minValueWithoutScale, 0, false);

        // The scaled value of PgNumeric is stored in this variable.
        // If scaled value is 100 and scale is 1, then actual value is 10.1.
        // 100.000 is stored as 100 and scale of 0. 100 == 100.000 == 100.0.
        private readonly BigInteger _scaledValue;

        // This flag would be true if PgNumeric is not a number.
        private readonly bool _notANumber;

        // The scale of numeric value stored.
        private readonly int _scale;

        private PgNumeric(BigInteger integer, int scale, bool isNotANumber)
        {
            if (!IsRawValueInRange(integer, scale))
            {
                throw new OverflowException("PgNumeric value out of range");
            }

            if (isNotANumber && integer != default && scale != default)
            {
                throw new ArgumentException("Invalid value and scale provided to PgNumeric for NaN");
            }

            _scale = scale;
            _notANumber = isNotANumber;
            _scaledValue = integer;
        }

        // Its access modifier is internal only so that it can be tested.
        internal static bool IsRawValueInRange(BigInteger integer, int scale)
        {
            if (scale == 0)
            {
                return integer >= s_minValueWithoutScale && integer <= s_maxValueWithoutScale;
            }
            else
            {
                return integer >= s_minValueWithScale && integer <= s_maxValueWithScale && scale >= -MaxScale && scale <= MaxScale;
            }
        }

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

            // This PgNumeric is a number, other number is NaN.
            if (other._notANumber)
            {
                return -1;
            }

            // If scale is same, we can compare the integer value.
            if (_scale == other._scale)
            {
                return _scaledValue.CompareTo(other._scaledValue);
            }

            // Return comparison of normalized value.
            return GetNormalizedValue().CompareTo(other.GetNormalizedValue());
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

        /// <summary>
        /// Gets the normalized value of the PgNumeric instance.
        /// This is internal implementation of how PgNumeric normalizes its value and need not be exposed publicly.
        /// </summary>
        /// <returns>The normalized value as big integer.</returns>
        internal BigInteger GetNormalizedValue()
        {
            int differenceToMaxScale = MaxScale - _scale;
            var powerOf10 = s_powersOf10.GetOrAdd(differenceToMaxScale, (differenceToMaxScale) => BigInteger.Pow(10, differenceToMaxScale));
            return _scaledValue * powerOf10;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is PgNumeric other && Equals(other);

        /// <inheritdoc/>
        public override int GetHashCode() => _notANumber ? -486187739 : -16777619 + GetNormalizedValue().GetHashCode();

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
                value = new PgNumeric(default, 0, true);
                return null;
            }

            if (!s_validation.IsMatch(text))
            {
                value = default;
                return "Text representation must be digits, containing an optional decimal point, and an optional leading '-' sign.";
            }

            // Remove trailing Zeros after decimal, so that correct scale is calculated.
            // So, 1.000 will become 1, 1.001000 will become 1.001 and so on, while 100 will remain 100.
            text = RemoveTrailingZeros(text);
            int pointIndex = text.IndexOf('.');

            // The raw value which will end up in the result, on success.
            BigInteger rawValue;
            int scale = 0;
            // If we have '.', then we need to extract the value and scale.
            if (pointIndex != -1)
            {
                int decimalPlaces = text.Length - pointIndex - 1;
                text = text.Remove(pointIndex, 1);
                scale = decimalPlaces;
                rawValue = BigInteger.Parse(text, CultureInfo.InvariantCulture);
            }
            else
            {
                // We don't have '.'
                rawValue = BigInteger.Parse(text, CultureInfo.InvariantCulture);
            }
            if (!IsRawValueInRange(rawValue, scale))
            {
                value = default;
                return "Parsed value would overflow the range of the type.";
            }
            value = new PgNumeric(rawValue, scale, false);
            return null;
        }

        /// <summary>
        /// Removes trailing zeros from the text.
        /// Should be called only for text with '.'.
        /// 1.0000 will be returned as 1, 1.00100 will be returned as 1.001.
        /// </summary>
        /// <param name="text">The text from which trailing zeros need to be trimmed.</param>
        /// <returns>The text without trailing zeros.</returns>
        private static string RemoveTrailingZeros(string text)
        {
            if (text.IndexOf('.') != -1)
            {
                StringBuilder stringBuilder = new StringBuilder(text);
                while (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '0')
                {
                    stringBuilder.Length--;
                }

                // Handle the case that after trimming 0, number is ending with '.'.
                if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '.')
                {
                    stringBuilder.Length--;
                }

                return stringBuilder.ToString();
            }

            // We don't have '.', return original text.
            return text;
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
                return "0";
            }

            var integerText = _scaledValue.ToString(CultureInfo.InvariantCulture);
            int signLength = sign > 0 ? 0 : 1;

            // We can have a scaled value or a non-scaled value, check if its scaled. 
            if (_scale == 0)
            {
                return integerText;
            }

            // If the number has '.' and it is between 0 to +-1 with many leading 0s before the actual number, e.g 0.000009.
            // while parsing it, leading zeros will be lost and only value we will have is 9 with scale as 6.
            // In such cases, we will need to pad zeros, so check if padding of zeros is needed.
            var padLeadingZeros = _scale - integerText.Length > 0;
            if (padLeadingZeros)
            {
                // We need to pad the length with leading zeros as starting 0s are lost while parsing.
                // Number of zeros to be appended = _scale - integerText.Length - signLength;
                int numberOfZeros = _scale - integerText.Length + signLength;
                for (int i = 0; i < numberOfZeros; i++)
                {
                    // Check that number is negative. If it is, then we start from 1 (0th index will be taken by -), else we start from 0.
                    int insertIndex = signLength > 0 ? 1 : 0;
                    integerText = integerText.Insert(insertIndex, "0");
                }
            }

            int indexOfDot = integerText.Length - _scale;
            integerText = integerText.Insert(indexOfDot, ".");

            // We will have '.', only if scale is non-zero.
            // Check that number doesn't start with '.', If yes, then append a 0 before '.'
            // First check if its a -ve number.
            if (signLength > 0)
            {
                // Index 0 is -ve sign and index 1 is '.', lets insert 0 at indexOfDot
                if (indexOfDot == 1)
                {
                    integerText = integerText.Insert(indexOfDot, "0");
                }
            }
            else if (indexOfDot == 0) // non-negative number starting with '.'.
            {
                integerText = integerText.Insert(indexOfDot, "0");
            }

            return integerText;
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

            return new PgNumeric(rawInteger, exponent, false);
        }

        // Conversions from CLR types to PgNumeric.

        /// <summary>
        /// Explicit conversion from <see cref="Decimal"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator PgNumeric(decimal value) =>
            FromDecimal(value);

        /// <summary>
        /// Implicit conversion from <see cref="Int32"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <remarks>
        /// This conversion exists to avoid ambiguity between the 64-bit conversions when using an integer literal.
        /// </remarks>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(int value) =>
            new PgNumeric((long)value, 0, false);

        /// <summary>
        /// Implicit conversion from <see cref="Int64"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(long value) =>
            new PgNumeric(value, 0, false);

        /// <summary>
        /// Implicit conversion from <see cref="UInt64"/> to <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PgNumeric(ulong value) =>
            new PgNumeric(value, 0, false);

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
            if (lossOfPrecisionHandling == LossOfPrecisionHandling.Throw && this != (PgNumeric)dec)
            {
                // TODO: Is this the right exception to use?
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
        public static explicit operator decimal(PgNumeric value) =>
            value.ToDecimal(LossOfPrecisionHandling.Truncate);

        // Operators
        /// <summary>
        /// Compares two values for equality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>true</c> if the two arguments are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(PgNumeric lhs, PgNumeric rhs) =>
            lhs.Equals(rhs);

        /// <summary>
        /// Compares two values for inequality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>false</c> if the two arguments are equal; <c>true</c> otherwise.</returns>
        public static bool operator !=(PgNumeric lhs, PgNumeric rhs) =>
            !lhs.Equals(rhs);
    }
}