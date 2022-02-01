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
using System.Numerics;

namespace Google.Cloud.BigQuery.V2
{
    // TODO: Implement IFormattable?

    /// <summary>
    /// Representation of the BigQuery BIGNUMERIC type, which has 76 digits of precision (plus a leftmost partial digit),
    /// and a fixed scale of 38 decimal places to the right of the decimal point. This is the same as to say that the type
    /// supports 38 full digits and a partial 39th digit before the decimal point and 38 digits after the decimal point.
    /// The supported value range is exactly -2^255e-38 to (2^255 - 1)e-38.
    /// </summary>
    public struct BigQueryBigNumeric : IEquatable<BigQueryBigNumeric>, IComparable<BigQueryBigNumeric>, IComparable
    {
        private static readonly NumericType s_numericType = NumericType.NumericTypeFor(-BigInteger.Pow(2, 255), BigInteger.Pow(2, 255) - 1, 38);

        // Note: the following properties must be declared *after* s_Type. Initialization order matters.

        // Note that we could also return here new BigQueryNumeric(s_numericType.Zero), but
        // that wouldn't make a difference.
        /// <summary>
        /// Zero represented as a <see cref="BigQueryBigNumeric"/>. This is the default value for the type.
        /// </summary>
        public static BigQueryBigNumeric Zero { get; } = default;

        /// <summary>
        /// The maximum valid value for <see cref="BigQueryBigNumeric"/>, equal to (2^255 - 1)e-38.
        /// </summary>
        public static BigQueryBigNumeric MaxValue { get; } = new BigQueryBigNumeric(s_numericType.MaxValue);

        /// <summary>
        /// The minimum valid value for <see cref="BigQueryBigNumeric"/>, equal to -2^255e-38.
        /// </summary>
        public static BigQueryBigNumeric MinValue { get; } = new BigQueryBigNumeric(s_numericType.MinValue);

        /// <summary>
        /// The smallest positive value for <see cref="BigQueryBigNumeric"/>, equal to 1e-38.
        /// </summary>
        public static BigQueryBigNumeric Epsilon { get; } = new BigQueryBigNumeric(s_numericType.Epsilon);

        // General purpose numeric representation. Should always be of type s_numericType unless
        // this is default(BigQueryBigNumeric), in which case _numericValue will be default(BigQueryNumeric)
        // whis has 0 as a value and null as type.
        private readonly NumericValue _numericValue;

        private BigQueryBigNumeric(NumericValue value)
        {
            // This should never throw, it means there's an error on our code.
            // At some point we maint want to accept NumericValues with a different NumericType
            // as long as they are in range. But there's no need for that right now.
            GaxPreconditions.CheckState(value == default || value.Type.Equals(s_numericType), "Incorrect NumericType used to build a BigQueryBigNumeric.");
            _numericValue = value;
        }

        /// <summary>
        /// Compares this value with <paramref name="other"/>.
        /// </summary>
        /// <param name="other">The value to compare with this one</param>
        /// <returns>A negative integer if this value is less than <paramref name="other"/>; a positive integer
        /// if it's greater than <paramref name="other"/>; zero if they're equal.</returns>
        public int CompareTo(BigQueryBigNumeric other) => _numericValue.CompareTo(other._numericValue);

        /// <summary>
        /// Implementation of <see cref="IComparable.CompareTo"/> to compare two <see cref="BigQueryBigNumeric"/> values.
        /// </summary>
        /// <remarks>
        /// This uses explicit interface implementation to avoid it being called accidentally. The generic implementation should usually be preferred.
        /// </remarks>
        /// <exception cref="ArgumentException"><paramref name="obj"/> is non-null but does not refer to an instance of <see cref="BigQueryBigNumeric"/>.</exception>
        /// <param name="obj">The object to compare this value with.</param>
        /// <returns>The result of comparing this value with <paramref name="obj"/>. <paramref name="obj"/> is null, this method returns a value greater than 0.
        /// </returns>
        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return obj is BigQueryBigNumeric bigNumeric
                ? CompareTo(bigNumeric)
                : throw new ArgumentException("Object must be of type BigQueryBigNumeric.", nameof(obj));
        }

        /// <summary>
        /// Compares this value with <paramref name="other"/> for equality.
        /// </summary>
        /// <param name="other">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="other"/> is an equal <see cref="BigQueryBigNumeric"/> value; <c>false</c> otherwise.</returns>
        public bool Equals(BigQueryBigNumeric other) => _numericValue == other._numericValue;

        /// <summary>
        /// Compares this value with <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="obj"/> is an equal <see cref="BigQueryBigNumeric"/> value; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj) => obj is BigQueryBigNumeric other && Equals(other);

        /// <summary>
        /// Returns a hash code for this value.
        /// </summary>
        /// <returns>A hash code for this value.</returns>
        public override int GetHashCode() => _numericValue.GetHashCode();

        /// <summary>
        /// Parses a textual representation as a <see cref="BigQueryBigNumeric"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <paramref name="text"/> must be a representation of a decimal value which can be represented by <see cref="BigQueryBigNumeric"/>,
        /// using "." as a decimal place where one is specified, and a leading "-" for negative values. Leading zeroes and insignificant
        /// trailing digits are permitted.
        /// </para>
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="FormatException">The value could not be parsed as a <see cref="BigQueryBigNumeric"/>.</exception>
        public static BigQueryBigNumeric Parse(string text) => new BigQueryBigNumeric(s_numericType.ParseNumericValue(text));

        /// <summary>
        /// Attempts to parse a textual representation of a <see cref="BigQueryBigNumeric"/> value.
        /// </summary>
        /// <remarks>
        /// See <see cref="Parse"/> for format details. This method will return <c>true</c> if and only if
        /// <see cref="Parse"/> would return without an exception.
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <param name="value">The parsed value, or 0 on failure.</param>
        /// <returns><c>true</c> if <paramref name="text"/> was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string text, out BigQueryBigNumeric value)
        {
            if (s_numericType.TryParseNumericValue(text, out NumericValue numericValue))
            {
                value = new BigQueryBigNumeric(numericValue);
                return true;
            }
            value = default;
            return false;
        }

        /// <summary>
        /// Returns a canonical string representation of this value. This always uses "." as a decimal point,
        /// and only includes as many decimal places as are required to completely represent the value. If
        /// the value is between -1 and 1 exclusive, a "0" character is included before the decimal point.
        /// </summary>
        /// <returns>A canonical string representation of this value.</returns>
        public override string ToString() => _numericValue.ToString();

        // Conversions from CLR types to BigQueryBigNumeric

        /// <summary>
        /// Explicit conversion from <see cref="decimal"/> to <see cref="BigQueryBigNumeric"/>.
        /// This conversion never loses precision.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BigQueryBigNumeric(decimal value) =>
            // We can always use truncate here because BigQueryBigNumeric is bigger than decimal.
            new BigQueryBigNumeric(s_numericType.ValueFromDecimal(value, LossOfPrecisionHandling.Truncate));

        /// <summary>
        /// Implicit conversion from <see cref="int"/> to <see cref="BigQueryBigNumeric"/>.
        /// </summary>
        /// <remarks>
        /// This conversion exists to avoid ambiguity between the 64-bit conversions when using an integer literal.
        /// </remarks>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BigQueryBigNumeric(int value) => (long) value;

        /// <summary>
        /// Implicit conversion from <see cref="long"/> to <see cref="BigQueryBigNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BigQueryBigNumeric(long value) =>
            new BigQueryBigNumeric(s_numericType.ValueFromInt64(value));

        /// <summary>
        /// Implicit conversion from <see cref="ulong"/> to <see cref="BigQueryBigNumeric"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BigQueryBigNumeric(ulong value) =>
            new BigQueryBigNumeric(s_numericType.ValueFromUInt64(value));

        // Conversions from BigQueryBigNumeric to CLR types.

        /// <summary>
        /// Converts this value to <see cref="BigQueryBigNumeric"/>, 
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, depending on <paramref name="lossOfPrecisionHandling"/>, but 
        /// will always throw <see cref="OverflowException"/> if value is out of the range of <see cref="decimal"/>.
        /// </remarks>
        /// <param name="lossOfPrecisionHandling">How to handle values with signficant digits that would be lost by the conversion.</param>
        /// <exception cref="OverflowException">This value is outside the range of <see cref="decimal"/>.</exception>
        /// <returns>The converted value.</returns>
        public decimal ToDecimal(LossOfPrecisionHandling lossOfPrecisionHandling) => _numericValue.ToDecimal(lossOfPrecisionHandling);

        /// <summary>
        /// Explicit conversion from <see cref="BigQueryBigNumeric"/> to <see cref="decimal"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, but will throw <see cref="OverflowException"/> if the value is out of
        /// range of <see cref="decimal"/>. Use <see cref="ToDecimal"/> passing in <see cref="LossOfPrecisionHandling.Throw"/>
        /// for the second argument to avoid any information loss.
        /// </remarks>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator decimal(BigQueryBigNumeric value) =>
            value.ToDecimal(LossOfPrecisionHandling.Truncate);

        // Operators
        /// <summary>
        /// Compares two values for equality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>true</c> if the two arguments are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(BigQueryBigNumeric lhs, BigQueryBigNumeric rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Compares two values for inequality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>false</c> if the two arguments are equal; <c>true</c> otherwise.</returns>
        public static bool operator !=(BigQueryBigNumeric lhs, BigQueryBigNumeric rhs) => !lhs.Equals(rhs);

        /// <summary>
        /// Returns the result of adding two <see cref="BigQueryBigNumeric"/> values together.
        /// </summary>
        /// <param name="lhs">The first value to add.</param>
        /// <param name="rhs">The second value to add.</param>
        /// <returns>The result of adding the two values.</returns>
        public static BigQueryBigNumeric operator +(BigQueryBigNumeric lhs, BigQueryBigNumeric rhs) =>
            new BigQueryBigNumeric(lhs._numericValue + rhs._numericValue);

        /// <summary>
        /// Returns the result of subtracting one <see cref="BigQueryBigNumeric"/> value from another.
        /// </summary>
        /// <param name="lhs">The value to subtract from.</param>
        /// <param name="rhs">The value to subtract.</param>
        /// <returns>The result of subtracting <paramref name="rhs"/> from <paramref name="lhs"/>.</returns>
        public static BigQueryBigNumeric operator -(BigQueryBigNumeric lhs, BigQueryBigNumeric rhs) =>
            new BigQueryBigNumeric(lhs._numericValue - rhs._numericValue);

        /// <summary>
        /// The unary plus operator, provided mainly for consistency.
        /// </summary>
        /// <param name="value">The value to return.</param>
        /// <returns>The original value.</returns>
        public static BigQueryBigNumeric operator +(BigQueryBigNumeric value) => value;

        /// <summary>
        /// The unary negation operator.
        /// </summary>
        /// <param name="value">The value to negate.</param>
        /// <returns>The negation of <paramref name="value"/>.</returns>
        public static BigQueryBigNumeric operator -(BigQueryBigNumeric value) => new BigQueryBigNumeric(-value._numericValue);
    }
}
