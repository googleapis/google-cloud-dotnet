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
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Google.Cloud.BigQuery.V2
{
    // Note: These types are internal and used for implementing BigQueryNumeric and
    // BigQueryBigNumeric only, which are thoroughly tested.
    // If we ever need to make these types public, then we need to test them on their own.
    internal sealed class NumericType
    {
        private sealed class Parameters
        {
            internal Parameters(BigInteger scaledMinValue, BigInteger scaledMaxValue, int scale) =>
                // Note that we don't validate here that these are on any sort of range.
                // We only use this to create BigQueryNumeric and BigQueryBigNumeric so we know
                // that those parameters are good.
                (Scale, ScaledMinValue, ScaledMaxValue) = (scale, scaledMinValue, scaledMaxValue);

            // These are scaled by the scaling factor.
            // A value of 1 is really 0.000000001 if the scale is 9.
            public BigInteger ScaledMinValue { get; }
            public BigInteger ScaledMaxValue { get; }

            public int Scale { get; }

            public override bool Equals(object obj) =>
                obj is Parameters def
                && def.ScaledMinValue.Equals(ScaledMinValue)
                && def.ScaledMaxValue.Equals(ScaledMaxValue)
                && def.Scale.Equals(Scale);

            public override int GetHashCode() =>
                GaxEqualityHelpers.CombineHashCodes(Scale.GetHashCode(), ScaledMinValue.GetHashCode(), ScaledMaxValue.GetHashCode());
        }

        internal const int MaxSupportedScale = 38;

        // This is a helper value. The length of the array depends on the supported precisions and scales.
        // The current length (39) is enough to support BigQueryNumeric and BigQueryBigNumeric.
        internal static readonly BigInteger[] PowersOf10 = Enumerable.Range(0, 39).Select(p => BigInteger.Pow(10, p)).ToArray();

        // TODO: Don't require a 0 before the decimal point.
        // TODO: Replace with manual validation if we find this is a performance bottleneck (as it was with field name validation).
        private static readonly Regex s_validation = new Regex(@"^-?[0-9]+\.?[0-9]*$");

        private readonly Parameters _parameters;
        private readonly Lazy<NumericValue> _lazyMaxValue;
        private readonly Lazy<NumericValue> _lazyMinValue;
        private readonly Lazy<NumericValue> _lazyEpsilon;
        private readonly Lazy<NumericValue> _lazyZero;

        private NumericType(Parameters parameters)
        {
            _parameters = parameters;
            _lazyMinValue = new Lazy<NumericValue>(() => ValueFromScaledInteger(_parameters.ScaledMinValue));
            _lazyMaxValue = new Lazy<NumericValue>(() => ValueFromScaledInteger(_parameters.ScaledMaxValue));
            _lazyEpsilon = new Lazy<NumericValue>(() => ValueFromScaledInteger(1));
            _lazyZero = new Lazy<NumericValue>(() => ValueFromScaledInteger(0));
        }

        internal static NumericType NumericTypeFor(BigInteger scaledMinValue, BigInteger scaledMaxValue, int scale) =>
            new NumericType(new Parameters(scaledMinValue, scaledMaxValue, scale));

        internal static NumericType NumericTypeFor(BigInteger scaledMaxValue, int scale) =>
            new NumericType(new Parameters(-scaledMaxValue, scaledMaxValue, scale));

        /// <summary>
        /// Scale of this type, i.e. max number of digits after the decimal point.
        /// </summary>
        public int Scale { get => _parameters.Scale; }

        /// <summary>
        /// Zero represented as a <see cref="NumericValue"/>. This is the default value for <see cref="NumericValue"/>.
        /// </summary>
        public NumericValue Zero { get => _lazyZero.Value; }

        /// <summary>
        /// The maximum valid value for a <see cref="NumericValue"/> of this <see cref="NumericType"/>.
        /// </summary>
        public NumericValue MaxValue { get => _lazyMaxValue.Value; }

        /// <summary>
        /// The minimum valid value for <see cref="NumericValue"/> of this <see cref="NumericType"/>.
        /// </summary>
        public NumericValue MinValue { get => _lazyMinValue.Value; }

        /// <summary>
        /// The smallest positive value for <see cref="NumericValue"/> of this <see cref="NumericType"/>.
        /// </summary>
        public NumericValue Epsilon { get => _lazyEpsilon.Value; }

        public override bool Equals(object obj) =>
            obj is NumericType type && _parameters.Equals(type._parameters);

        public override int GetHashCode() => _parameters.GetHashCode();

        // TODO:
        // - Allow leading +?
        // - Allow .5 as well as 0.5?
        // - Allow 5. as well as 5.0 and 5?

        /// <summary>
        /// Parses a textual representation as a <see cref="NumericValue"/> with this <see cref="NumericType"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <paramref name="text"/> must be a representation of a decimal value which can be represented by a <see cref="NumericValue"/>
        /// with this <see cref="NumericType"/>
        /// using "." as a decimal place where one is specified, and a leading "-" for negative values. Leading zeroes and insignificant
        /// trailing digits are permitted.
        /// </para>
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="FormatException">The value could not be parsed as a <see cref="NumericValue"/> with this <see cref="NumericType"/>.</exception>
        public NumericValue ParseNumericValue(string text) =>
            TryParseNumericValueImpl(text, out var value) is string error
                ? throw new FormatException(error)
                : value;

        /// <summary>
        /// Attempts to parse a textual representation as a <see cref="NumericValue"/> with this <see cref="NumericType"/>.
        /// </summary>
        /// <remarks>
        /// See <see cref="ParseNumericValue(string)"/> for format details. This method will return <c>true</c> if and only if
        /// <see cref="ParseNumericValue(string)"/> would return without an exception.
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <param name="value">The parsed value, or 0 on failure.</param>
        /// <returns><c>true</c> if <paramref name="text"/> was parsed successfully; <c>false</c> otherwise.</returns>
        internal bool TryParseNumericValue(string text, out NumericValue value) =>
            TryParseNumericValueImpl(text, out value) is null;

        /// <summary>
        /// Attempts to parse a textual representation as a <see cref="NumericValue"/> with this <see cref="NumericType"/>.
        /// </summary>
        /// <returns>The error message for a FormatException if parsing fails, or null for success.</returns>
        private string TryParseNumericValueImpl(string text, out NumericValue value)
        {
            GaxPreconditions.CheckNotNull(text, nameof(text));
            if (!s_validation.IsMatch(text))
            {
                value = default;
                return "Text representation must be digits, containing an optional decimal point, and an optional leading '-' sign.";
            }
            int pointIndex = text.IndexOf('.');

            // The raw value which will end up in the result, on success.
            BigInteger rawValue;
            if (pointIndex != -1)
            {
                int decimalPlaces = text.Length - pointIndex - 1;
                text = text.Remove(pointIndex, 1);
                if (decimalPlaces > _parameters.Scale)
                {
                    text = text.Substring(0, text.Length - (decimalPlaces - _parameters.Scale));
                    decimalPlaces = _parameters.Scale;
                }
                BigInteger integer = BigInteger.Parse(text, CultureInfo.InvariantCulture);

                if (decimalPlaces < _parameters.Scale)
                {
                    integer *= PowersOf10[_parameters.Scale - decimalPlaces];
                }
                rawValue = integer;
            }
            else
            {
                BigInteger integer = BigInteger.Parse(text, CultureInfo.InvariantCulture);
                rawValue = integer * PowersOf10[_parameters.Scale];
            }
            if (!IsUnscaledValueInRange(rawValue))
            {
                value = default;
                return "Parsed value would overflow the range of the type.";
            }
            value = ValueFromScaledInteger(rawValue);
            return null;
        }

        internal bool IsUnscaledValueInRange(BigInteger integer) => integer >= _parameters.ScaledMinValue && integer <= _parameters.ScaledMaxValue;

        internal NumericValue ValueFromScaledInteger(BigInteger scaledValue) => new NumericValue(scaledValue, this);

        /// <summary>
        /// Converts a <see cref="decimal"/> value to a <see cref="NumericValue"/> with this <see cref="NumericType"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, depending on <paramref name="lossOfPrecisionHandling"/>.
        /// </remarks>
        /// <param name="value">The value to convert</param>
        /// <param name="lossOfPrecisionHandling">How to handle values with signficant digits that would be lost by the conversion.</param>
        /// <returns>The converted value.</returns>
        public NumericValue ValueFromDecimal(decimal value, LossOfPrecisionHandling lossOfPrecisionHandling)
        {
            GaxPreconditions.CheckEnumValue(lossOfPrecisionHandling, nameof(lossOfPrecisionHandling));
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

            int scale = _parameters.Scale - exponent;
            if (scale < 0)
            {
                BigInteger scaledInteger;
                if (lossOfPrecisionHandling == LossOfPrecisionHandling.Throw)
                {
                    scaledInteger = BigInteger.DivRem(rawInteger, PowersOf10[-scale], out var remainder);
                    if (!remainder.IsZero)
                    {
                        throw new ArgumentException("Conversion would lose precision, and lossOfPrecisionHandling is set to LossOfPrecisionHandling.Throw.", nameof(value));
                    }
                }
                else
                {
                    scaledInteger = rawInteger / PowersOf10[-scale];
                }

                return ValueFromScaledInteger(scaledInteger);
            }
            else
            {
                // No possibility of loss of precision.
                return ValueFromScaledInteger(rawInteger * PowersOf10[scale]);
            }
        }

        // Conversions from CLR types to NumericValue (these are as helper for defining operators downstream)

        /// <summary>
        /// Converts a <see cref="long"/> value to a <see cref="NumericValue"/> with this <see cref="NumericType"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public NumericValue ValueFromInt64(long value) => ValueFromScaledInteger(value * PowersOf10[_parameters.Scale]);

        /// <summary>
        /// Converts a <see cref="ulong"/> value to a <see cref="NumericValue"/> with this <see cref="NumericType"/>.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public NumericValue ValueFromUInt64(ulong value) => ValueFromScaledInteger(value * PowersOf10[_parameters.Scale]);
    }

    internal struct NumericValue : IEquatable<NumericValue>, IComparable<NumericValue>, IComparable
    {
        private readonly BigInteger _scaledValue;
        // Note that this may be null on the case that the NumericValue is initialized to default.
        // That's fine, we'll check for it, and it's consistent as _scaledValue will be 0, which
        // is universal, i.e. non-dependent on the actual NumericType, given that the type only varies
        // in precision and scale.
        internal NumericType Type { get; }

        internal NumericValue(BigInteger scaledValue, NumericType type)
        {
            Type = GaxPreconditions.CheckNotNull(type, nameof(type));
            if (!Type.IsUnscaledValueInRange(scaledValue))
            {
                throw new OverflowException("Numeric value out of range");
            }
            _scaledValue = scaledValue;
        }

        /// <summary>
        /// Compares this value with <paramref name="other"/>.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="other">The value to compare with this one</param>
        /// <returns>A negative integer if this value is less than <paramref name="other"/>; a positive integer
        /// if it's greater than <paramref name="other"/>; zero if they're equal.</returns>
        public int CompareTo(NumericValue other) =>
            // Note that this only works because we make the assumption that both values either have the same
            // NumericType or at least one of them is default(NumericValue).
            // Do reevaluate this if we ever decide to support cross-type operations.
            _scaledValue.CompareTo(other._scaledValue);

        /// <summary>
        /// Implementation of <see cref="IComparable.CompareTo"/> to compare two <see cref="NumericValue"/> values.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <remarks>
        /// This uses explicit interface implementation to avoid it being called accidentally. The generic implementation should usually be preferred.
        /// </remarks>
        /// <exception cref="ArgumentException"><paramref name="obj"/> is non-null but does not refer to an instance of <see cref="NumericValue"/>.</exception>
        /// <param name="obj">The object to compare this value with.</param>
        /// <returns>The result of comparing this value with <paramref name="obj"/>. <paramref name="obj"/> is null, this method returns a value greater than 0.
        /// </returns>
        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return obj is NumericValue numeric
                ? CompareTo(numeric)
                : throw new ArgumentException("Object must be of type NumericValue.", nameof(obj));
        }

        /// <summary>
        /// Compares this value with <paramref name="other"/> for equality.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="other">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="other"/> is an equal <see cref="NumericValue"/> value; <c>false</c> otherwise.</returns>
        public bool Equals(NumericValue other) =>
            // Note that this only works because we make the assumption that both values either have the same
            // NumericType or at least one of them is default(NumericValue).
            // Do reevaluate this if we ever decide to support cross-type operations.
            _scaledValue.Equals(other._scaledValue);

        /// <summary>
        /// Compares this value with <paramref name="obj"/> for equality.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="obj">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="obj"/> is an equal <see cref="NumericValue"/> value; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj) => obj is NumericValue other && Equals(other);

        /// <summary>
        /// Returns a hash code for this value.
        /// </summary>
        /// <returns>A hash code for this value.</returns>
        public override int GetHashCode() =>
            // If we ever support cross type operations then the type is only relevant to be able
            // to bring the value to the max supported scale, as in that scale all values are comparable.
            // But the type shouldn't be part of the combined hashcode as values of different types could
            // still be equal.
            GaxEqualityHelpers.CombineHashCodes(Type?.GetHashCode() ?? 0, _scaledValue.GetHashCode());

        /// <summary>
        /// Returns a canonical string representation of this value. This always uses "." as a decimal point,
        /// and only includes as many decimal places as are required to completely represent the value. If
        /// the value is between -1 and 1 exclusive, a "0" character is included before the decimal point.
        /// </summary>
        /// <returns>A canonical string representation of this value.</returns>
        public override string ToString()
        {
            int sign = _scaledValue.Sign;
            if (sign == 0)
            {
                return "0";
            }
            var integerText = _scaledValue.ToString(CultureInfo.InvariantCulture);

            int decimalPlaces = Type.Scale; // We already checked for 0 so we know Type is not null.
            for (int place = integerText.Length - 1; place > 0 && decimalPlaces > 0; place--)
            {
                if (integerText[place] != '0')
                {
                    break;
                }
                decimalPlaces--;
            }

            int signLength = sign > 0 ? 0 : 1;

            // Always have something before the period, even if it's just a 0
            int originalIntegerPlaces = Math.Max(integerText.Length - signLength - Type.Scale, 0);
            int resultIntegerPlaces = Math.Max(originalIntegerPlaces, 1);

            // Sign, then integer part, then period (maybe), then significant decimals
            int resultLength = signLength + resultIntegerPlaces + (decimalPlaces > 0 ? 1 : 0) + decimalPlaces;
            var chars = new char[resultLength];
            int position = 0;

            // Copy some text from the original string representation, including the leading '-' if necessary
            int leadCharactersToCopy = originalIntegerPlaces + signLength;
            for (int i = 0; i < leadCharactersToCopy; i++)
            {
                chars[position] = integerText[position];
                position++;
            }

            if (originalIntegerPlaces == 0)
            {
                chars[position++] = '0';
            }
            if (decimalPlaces > 0)
            {
                chars[position++] = '.';
                int decimalsToCopy = decimalPlaces;

                // Fill zeroes if necessary
                if (originalIntegerPlaces == 0)
                {
                    int decimalsToFill = Type.Scale - (integerText.Length - signLength);
                    for (int i = 0; i < decimalsToFill; i++)
                    {
                        chars[position++] = '0';
                    }
                    decimalsToCopy -= decimalsToFill;
                }

                // Now the significant digits in the remaining text
                int sourcePosition = leadCharactersToCopy;
                for (int i = 0; i < decimalsToCopy; i++)
                {
                    chars[position++] = integerText[sourcePosition++];
                }
            }
            return new string(chars);
        }

        // Conversions from NumericValue to CLR types.

        /// <summary>
        /// Converts this value to <see cref="decimal"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, depending on <paramref name="lossOfPrecisionHandling"/>, but 
        /// will always throw <see cref="OverflowException"/> if value is out of the range of <see cref="decimal"/>.
        /// </remarks>
        /// <param name="lossOfPrecisionHandling">How to handle values with signficant digits that would be lost by the conversion.</param>
        /// <exception cref="OverflowException">This value is outside the range of <see cref="decimal"/>.</exception>
        /// <returns>The converted value.</returns>
        public decimal ToDecimal(LossOfPrecisionHandling lossOfPrecisionHandling)
        {
            if (_scaledValue == BigInteger.Zero)
            {
                return 0;
            } // We now know that Type is not null.

            // FIXME: Awful performance!
            string text = ToString();
            // Handles overflow
            decimal dec = decimal.Parse(text, CultureInfo.InvariantCulture);
            if (lossOfPrecisionHandling == LossOfPrecisionHandling.Throw && this != Type.ValueFromDecimal(dec, LossOfPrecisionHandling.Truncate))
            {
                // TODO: Is this the right exception to use?
                throw new InvalidOperationException("Conversion would lose information");
            }
            return dec;
        }

        /// <summary>
        /// Explicit conversion from <see cref="NumericValue"/> to <see cref="decimal"/>.
        /// </summary>
        /// <remarks>
        /// This conversion may silently lose precision, but will throw <see cref="OverflowException"/> if the value is out of
        /// range of <see cref="decimal"/>. Use <see cref="ToDecimal"/> passing in <see cref="LossOfPrecisionHandling.Throw"/>
        /// for the second argument to avoid any information loss.
        /// </remarks>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator decimal(NumericValue value) =>
            value.ToDecimal(LossOfPrecisionHandling.Truncate);

        // Operators
        /// <summary>
        /// Compares two values for equality.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>true</c> if the two arguments are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(NumericValue lhs, NumericValue rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Compares two values for inequality.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>false</c> if the two arguments are equal; <c>true</c> otherwise.</returns>
        public static bool operator !=(NumericValue lhs, NumericValue rhs) => !lhs.Equals(rhs);

        /// <summary>
        /// Returns the result of adding two <see cref="NumericValue"/> values together.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="lhs">The first value to add.</param>
        /// <param name="rhs">The second value to add.</param>
        /// <returns>
        /// The result of adding the two values.
        /// </returns>
        public static NumericValue operator +(NumericValue lhs, NumericValue rhs) =>
            new NumericValue(lhs._scaledValue + rhs._scaledValue, lhs.Type ?? rhs.Type);

        /// <summary>
        /// Returns the result of substracting two <see cref="NumericValue"/> values together.
        /// Note that an assumption is made that both values either have the same <see cref="NumericType"/>
        /// or at least one is <code>default(NumericValue)</code>.
        /// </summary>
        /// <param name="lhs">The value to substract from.</param>
        /// <param name="rhs">The value to substract.</param>
        /// <returns>
        /// The result of substracting the two values.
        /// </returns>
        public static NumericValue operator -(NumericValue lhs, NumericValue rhs) =>
            new NumericValue(lhs._scaledValue - rhs._scaledValue, lhs.Type ?? rhs.Type);

        /// <summary>
        /// The unary plus operator, provided mainly for consistency.
        /// </summary>
        /// <param name="value">The value to return.</param>
        /// <returns>The original value.</returns>
        public static NumericValue operator +(NumericValue value) => value;

        /// <summary>
        /// The unary negation operator.
        /// </summary>
        /// <param name="value">The value to negate.</param>
        /// <returns>The negation of <paramref name="value"/>.</returns>
        public static NumericValue operator -(NumericValue value) => new NumericValue(-value._scaledValue, value.Type);
    }
}
