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

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// The SpannerDate type represents a logical calendar date, independent of time zone.
    /// Represents dates with values ranging from January 1, 0001 A.D through December 31, 9999 A.D. in the Gregorian calendar.
    /// </summary>
    public readonly struct SpannerDate : IEquatable<SpannerDate>, IComparable<SpannerDate>, IComparable
    {
        // TODO : Once upgraded to .NET 6, have an operator for converting DateOnly to SpannerDate and vice versa.

        // The latest possible date is 9999/12/31 (DateTime.MaxValue) and earliest possible date is 0001/01/01 (DateTime.MinValue).
        // The days between maximum and minimum date is MaxNumberOfDays.
        private const int MaxNumberOfDays = 3652058;

        /// <summary>
        /// Gets the latest possible date that can be created.
        /// </summary>
        /// <value>
        /// The maximum date as SpannerDate.
        /// </value>
        public static SpannerDate MaxDate => new SpannerDate(DateTime.MaxValue);

        /// <summary>
        /// Gets the earliest possible date that can be created.
        /// </summary>
        /// <value>
        /// The minimum date as SpannerDate.
        /// </value>
        public static SpannerDate MinDate => new SpannerDate(DateTime.MinValue);

        // The value of SpannerDate stored as the number of days since the DateTime.MinValue day i.e., 0001/01/01.
        private readonly int _days;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannerDate"/> structure to the specified DateTime.
        /// </summary>
        /// <param name="dateTime">The dateTime as <see cref="DateTime"/>.</param>
        public SpannerDate(DateTime dateTime) : this(dateTime.Subtract(DateTime.MinValue).Days)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannerDate"/> structure to the specified year, month, and day in the Gregorian calendar.
        /// </summary>
        /// <param name="year">The year (1 through the number of years in calendar).</param>
        /// <param name="month">The month (1 through the number of months in calendar).</param>
        /// <param name="day">The day (1 through the number of days in <paramref name="month"/>).</param>
        public SpannerDate(int year, int month, int day) : this(new DateTime(year, month, day))
        {
        }

        private SpannerDate(int days)
        {
            GaxPreconditions.CheckArgumentRange(days, nameof(days), 0, MaxNumberOfDays);
            _days = days;
        }

        ///<inheritdoc/>
        public int CompareTo(SpannerDate other) => _days.CompareTo(other._days);

        /// <summary>
        /// Implementation of <see cref="IComparable.CompareTo"/> to compare two <see cref="SpannerDate"/> values.
        /// </summary>
        /// <remarks>
        /// This uses explicit interface implementation to avoid it being called accidentally. The generic implementation should usually be preferred.
        /// </remarks>
        /// <exception cref="ArgumentException"><paramref name="obj"/> is non-null but does not refer to an instance of <see cref="SpannerDate"/>.</exception>
        /// <param name="obj">The object to compare this value with.</param>
        /// <returns>The result of comparing this value with <paramref name="obj"/>. <paramref name="obj"/> is null, this method returns a value greater than 0.
        /// </returns>
        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return obj is SpannerDate date
                ? CompareTo(date)
                : throw new ArgumentException($"Object must be of type {nameof(SpannerDate)}", nameof(obj));
        }

        /// <inheritdoc/>
        public bool Equals(SpannerDate other) => CompareTo(other) == 0;

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is SpannerDate other && Equals(other);

        /// <inheritdoc/>
        public override int GetHashCode() => _days.GetHashCode();

        /// <summary>
        /// Parses a textual representation as a <see cref="SpannerDate"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <paramref name="text"/> must be a representation of a date value which can be represented by <see cref="SpannerDate"/>.
        /// </para>
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="FormatException">The value could not be parsed as a <see cref="SpannerDate"/>.</exception>
        public static SpannerDate Parse(string text)
        {
            string message = TryParseImpl(text, out var value);
            return message == null ? value : throw new FormatException(message);
        }

        /// <summary>
        /// Attempts to parse a textual representation of a <see cref="SpannerDate"/> value.
        /// </summary>
        /// <remarks>
        /// See <see cref="Parse(string)"/> for format details. This method will return <c>true</c> if and only if
        /// <see cref="Parse(string)"/> would return without an exception.
        /// </remarks>
        /// <param name="text">The text to parse. Must not be null.</param>
        /// <param name="value">The parsed value, or 0 on failure.</param>
        /// <returns><c>true</c> if <paramref name="text"/> was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string text, out SpannerDate value)
        {
            string message = TryParseImpl(text, out value);
            return message == null;
        }

        /// <summary>
        /// Returns the error message for a FormatException if parsing fails, or null for success.
        /// </summary>
        private static string TryParseImpl(string text, out SpannerDate value)
        {
            GaxPreconditions.CheckNotNull(text, nameof(text));

            if (DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                value = new SpannerDate(dateTime);
                return null;
            }
            else
            {
                value = default;
                return "Text representation must be a valid date.";
            }
        }

        /// <summary>
        /// Returns the ISO 8601 representation (yyyy-MM-dd) of the date represented by this instance.
        /// </summary>
        /// <returns>The ISO 8601 string representation of this date.</returns>
        public override string ToString() => ToDateTime().ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

        /// <summary>
        /// Returns a SpannerDate instance that is set to the date part of the specified DateTime.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns>The SpannerDate instance</returns>
        public static SpannerDate FromDateTime(DateTime dateTime) => new SpannerDate(dateTime);

        /// <summary>
        /// Converts the value of this SpannerDate instance to the <see cref="DateTime"/> of kind <see cref="DateTimeKind.Unspecified"/>.
        /// </summary>
        /// <returns>The DateTime value.</returns>
        public DateTime ToDateTime() => DateTime.MinValue.AddDays(_days);

        /// <summary>
        /// Returns a new <see cref="SpannerDate"/> that adds the specified number of days to the value of this instance.
        /// </summary>
        /// <param name="days">The number of days to be added.</param>
        /// <returns>The SpannerDate value that is the sum of the date represented by this instance and the number of 
        /// days represented by <paramref name="days"/>.</returns>
        public SpannerDate AddDays(int days) => new SpannerDate(_days + days);

        // DateTime Properties.

        /// <summary>
        /// Gets the day of the month of the date represented by this instance.
        /// </summary>
        public int Day => ToDateTime().Day;

        /// <summary>
        /// Gets the month component of the date represented by this instance.
        /// </summary>
        public int Month => ToDateTime().Month;

        /// <summary>
        /// Gets the year component of the date represented by this instance.
        /// </summary>
        public int Year => ToDateTime().Year;

        /// <summary>
        /// Gets the day of year represented by this instance.
        /// </summary>
        public int DayOfYear => ToDateTime().DayOfYear;

        /// <summary>
        /// Gets the number of days since January 1, 0001 represented by this instance.
        /// </summary>
        public int DayNumber => _days;

        // Operators.

        /// <summary>
        /// Compares two values for equality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>true</c> if the two arguments are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(SpannerDate lhs, SpannerDate rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Compares two values for inequality.
        /// </summary>
        /// <param name="lhs">The first value to compare.</param>
        /// <param name="rhs">The second value to compare.</param>
        /// <returns><c>false</c> if the two arguments are equal; <c>true</c> otherwise.</returns>
        public static bool operator !=(SpannerDate lhs, SpannerDate rhs) => !lhs.Equals(rhs);

        /// <summary>Compares two values to determine which is less.</summary>
        /// <param name="lhs">The value to compare with <paramref name="rhs" />.</param>
        /// <param name="rhs">The value to compare with <paramref name="lhs" />.</param>
        /// <returns><c>true</c> if <paramref name="lhs" /> is less than <paramref name="rhs" />; otherwise, <c>false</c>.</returns>
        public static bool operator <(SpannerDate lhs, SpannerDate rhs) => lhs.CompareTo(rhs) < 0;

        /// <summary>Compares two values to determine which is less or equal.</summary>
        /// <param name="lhs">The value to compare with <paramref name="rhs" />.</param>
        /// <param name="rhs">The value to compare with <paramref name="lhs" />.</param>
        /// <returns><c>true</c> if <paramref name="lhs" /> is less than or equal to <paramref name="rhs" />; otherwise, <c>false</c>.</returns>
        public static bool operator <=(SpannerDate lhs, SpannerDate rhs) => lhs.CompareTo(rhs) <= 0;

        /// <summary>Compares two values to determine which is greater.</summary>
        /// <param name="lhs">The value to compare with <paramref name="rhs" />.</param>
        /// <param name="rhs">The value to compare with <paramref name="lhs" />.</param>
        /// <returns><c>true</c> if <paramref name="lhs" /> is greater than <paramref name="rhs" />; otherwise, <c>false</c>.</returns>
        public static bool operator >(SpannerDate lhs, SpannerDate rhs) => lhs.CompareTo(rhs) > 0;

        /// <summary>Compares two values to determine which is greater or equal.</summary>
        /// <param name="lhs">The value to compare with <paramref name="rhs" />.</param>
        /// <param name="rhs">The value to compare with <paramref name="lhs" />.</param>
        /// <returns><c>true</c> if <paramref name="lhs" /> is greater than or equal to <paramref name="rhs" />; otherwise, <c>false</c>.</returns>
        public static bool operator >=(SpannerDate lhs, SpannerDate rhs) => lhs.CompareTo(rhs) >= 0;

        /// <summary>
        /// Performs an explicit conversion from <see cref="DateTime"/> to <see cref="SpannerDate"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator SpannerDate(DateTime value) => new SpannerDate(value);

        /// <summary>
        /// Performs an explicit conversion from <see cref="SpannerDate"/> to <see cref="DateTime"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator DateTime(SpannerDate value) => value.ToDateTime();

#if NET6_0_OR_GREATER
        // Operators for conversion to DateOnly and Vice versa.

#endif
    }
}
