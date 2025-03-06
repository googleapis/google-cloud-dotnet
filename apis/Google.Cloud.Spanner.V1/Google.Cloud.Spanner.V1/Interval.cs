// Copyright 2025 Google LLC
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
using System.Text;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Representation of a Time Interval.
/// </summary>
public class Interval
{
    private const int Uninitialized = 0;
    private const int ParsingDate = 1;
    private const int ParsingTime = 2;
    internal const long NanosecondsInASecond = 1000000000L;
    internal const long NanosecondsInAMinute = NanosecondsInASecond * 60;
    internal const long NanosecondsInAnHour = NanosecondsInAMinute * 60;
    internal const long NanosecondsInADay = NanosecondsInAnHour * 24;
    internal const long NanosecondsInAMonth = NanosecondsInADay * 30;
    internal const long NanosecondsInAYear = NanosecondsInAMonth * 12;
    internal const long NanosecondsInAMillisecond = 1000000L;
    internal const long NanosecondsInAMicrosecond = 1000L;
    internal const int MaxMonths = 120000;
    internal const int MinMonths = -MaxMonths;
    internal const int MaxDays = 3660000;
    internal const int MinDays = -MaxDays;

    /// <summary>
    /// Month portion of this interval.
    /// </summary>
    public int Months { get; }

    /// <summary>
    /// Day portion of this interval.
    /// </summary>
    public int Days { get; }

    /// <summary>
    /// Nanosecond portion of this interval.
    /// </summary>
    public BigInteger Nanoseconds { get; }

    /// <summary>
    /// Representation of a Time Interval.
    /// </summary>
    private Interval(int months, int days, BigInteger nanoseconds)
    {
        if (months > MaxMonths || months < MinMonths)
        {
            throw new ArgumentException($"The interval type supports a range from {MinMonths} to {MaxMonths} months");
        }
        Months = months;

        if (days > MaxDays || days < MinDays)
        {
            throw new ArgumentException($"The interval type supports a range from {MinDays} to {MaxDays} days");
        }
        Days = days;

        BigInteger MaxNanoseconds = BigInteger.Parse("316224000000000000000");

        if (nanoseconds > MaxNanoseconds || nanoseconds < -MaxNanoseconds)
        {
            throw new ArgumentException($"The interval type supports a range from -{MaxNanoseconds} to {MaxNanoseconds} nanoseonds");
        }
        Nanoseconds = nanoseconds;
    }

    /// <summary>
    /// Constructs an interval based on an ISO8601 duration string.
    /// This should be formatted in the following manner:
    /// P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S
    /// where [n] is an int.
    /// </summary>
    public static Interval Parse(string text)
    {
        if (text is null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        var state = new IntervalParsingState();
        var end = -1;
        do
        {
            end = text.IndexOfAny(state.NextAllowed, state.Start);

            // We couldn't find any of the allowed characters of which we needed to find one.
            if (end == -1)
            {
                throw new FormatException(text);
            }
            // P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S
            switch (text[end])
            {
                case 'P':
                    state.MayBeTerminal = false;
                    state.IsTerminal = false;
                    state.IsTime = false;
                    state.IsValidResolution = true;
                    state.NextAllowed = IntervalParsingState.AfterP;
                    break;
                case 'Y':
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.IsValidResolution = true;
                    state.Years = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterY;
                    break;
                case 'M' when !state.IsTime:
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.IsValidResolution = true;
                    state.Months = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterMonth;
                    break;
                case 'D':
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.IsValidResolution = true;
                    state.Days = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterD;
                    break;
                case 'T':
                    state.MayBeTerminal = false;
                    state.IsTerminal = false;
                    state.IsTime = true;
                    state.IsValidResolution = true;
                    state.NextAllowed = IntervalParsingState.AfterT;
                    break;
                case 'H':
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.IsValidResolution = true;
                    state.Hours = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterH;
                    break;
                case 'M' when state.IsTime:
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.IsValidResolution = true;
                    state.Minutes = ParseLong();
                    state.NextAllowed = IntervalParsingState.AfterMins;
                    break;
                case 'S':
                    state.MayBeTerminal = true;
                    state.IsTerminal = true;
                    state.IsValidResolution = IsValidResolution();
                    state.Seconds = ParseDecimal();
                    state.NextAllowed = null;
                    break;
                default:
                    throw new FormatException(text);
            }

            state.Start = end + 1;

        } while (state.Start < text.Length && !state.IsTerminal);

        // We are at a terminal state but we haven't parsed the whole string yet.
        if (state.IsTerminal && state.Start < text.Length)
        {
            throw new FormatException(text);
        }

        // We parsed the whole string but we ended up at a state that's not terminal.
        if (!state.MayBeTerminal)
        {
            throw new FormatException(text);
        }

        // We do not have a valid precision for the fractional seconds
        if (!state.IsValidResolution)
        {
            throw new ArgumentException(text);
        }

        int ParseInt() => int.Parse(text.Substring(state.Start, end - state.Start), CultureInfo.InvariantCulture.NumberFormat);
        long ParseLong() => long.Parse(text.Substring(state.Start, end - state.Start), CultureInfo.InvariantCulture.NumberFormat);
        decimal ParseDecimal() => decimal.Parse(text.Substring(state.Start, end - state.Start).Replace(',', '.'), CultureInfo.InvariantCulture.NumberFormat);

        bool IsValidResolution() {
            string[] splitText = text.Substring(state.Start, end - state.Start).Replace(',', '.').Split('.');

            // If we have an int number, it is valid
            if (splitText.Length < 2)
            {
                return true;
            }

            // If we have more than 9 digits after the decimal, it is not valid
            if (splitText[1].Length > 9)
            {
                return false;
            }

            return true;
        }

        int totalMonths = Interval.YearsToMonths(state.Years) + state.Months;
        BigInteger totalNanoseconds = Interval.HoursToNanoseconds(state.Hours) + Interval.MinutesToNanoseconds(state.Minutes) + Interval.SecondsToNanoseconds(state.Seconds);

        return new Interval(totalMonths, state.Days, totalNanoseconds);
    }

    /// <summary>
    /// Attempts to parse a textual representation of a <see cref="Interval"/> value.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="interval"></param>
    /// <returns><c>true</c> if <paramref name="text"/> was parsed successfully; <c>false</c> otherwise.</returns>
    public static bool TryParse(string text, out Interval interval)
    {
        try {
            interval = Interval.Parse(text);
            return true;
        } catch(Exception) {
            interval = null;
            return false;
        }
    }

    /// <summary>
    /// Converts the current interval into an ISO8601 string
    /// </summary>
    public override string ToString()
    {
        int years;
        int months;
        int days = Days;
        int hours;
        int minutes;
        float seconds;
        BigInteger remainingNanoseconds = this.Nanoseconds;

        years = this.Months / 12;
        months = this.Months % 12;
        hours = (int) (remainingNanoseconds / NanosecondsInAnHour);
        remainingNanoseconds %= NanosecondsInAnHour;
        minutes = (int) (remainingNanoseconds / NanosecondsInAMinute);
        remainingNanoseconds %= NanosecondsInAMinute;
        seconds = (float) remainingNanoseconds / NanosecondsInASecond;

        StringBuilder intervalSB = new StringBuilder("P", 15);

        if (years != 0)
        {
            intervalSB.Append($"{years}Y");
        }

        if (months != 0)
        {
            intervalSB.Append($"{months}M");
        }

        if (days != 0)
        {
            intervalSB.Append($"{days}D");
        }

        if (hours != 0 || minutes != 0 || seconds != 0)
        {
            intervalSB.Append("T");

            if (hours != 0)
            {
                intervalSB.Append($"{hours}H");
            }

            if (minutes != 0)
            {
                intervalSB.Append($"{minutes}M");
            }

            if (seconds != 0)
            {
                intervalSB.Append($"{seconds}S");
            }
        }

        string intervalString = intervalSB.ToString();

        if (intervalString == "P")
        {
            return "P0Y";
        }

        return intervalString;
    }

    /// <summary>
    /// Compares this instance of Interval with another object.
    /// The equality is based upon type, number of days, number of months and number of nanoseconds.
    /// </summary>
    public override bool Equals(object obj)
    {
        Interval other = obj as Interval;

        if (other == null)
        {
            return false;
        }

        if (this.Months != other.Months && this.Days != other.Days && this.Nanoseconds != other.Nanoseconds)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Gets the object hashcode
    /// </summary>
    public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(this.Days.GetHashCode(), this.Months.GetHashCode(), this.Nanoseconds.GetHashCode());

    /// <summary>
    /// Creates an interval from the given months, days and nanoseconds.
    /// </summary>
    public static Interval FromMonthsDaysNanos(int months, int days, BigInteger nanos) => new Interval(months, days, nanos);

    /// <summary>
    /// Creates an interval based on the Months given.
    /// </summary>
    public static Interval FromMonths(int months) => new Interval(months, 0, 0);

    /// <summary>
    /// Creates an Interval based on the Days given.
    /// </summary>
    public static Interval FromDays(int days) => new Interval(0, days, 0);

    /// <summary>
    /// Creates an Interval based on the seconds given.
    /// </summary>
    public static Interval FromSeconds(BigInteger seconds) => new Interval(0, 0, NanosecondsInASecond * seconds);

    /// <summary>
    /// Creates an Interval based on the milliseconds given.
    /// </summary>
    public static Interval FromMilliseconds(BigInteger milliseconds) => new Interval(0, 0, NanosecondsInAMillisecond * milliseconds);

    /// <summary>
    /// Creates an Interval based on the microseconds given.
    /// </summary>
    public static Interval FromMicroseconds(BigInteger microseconds) => new Interval(0, 0, NanosecondsInAMicrosecond * microseconds);

    /// <summary>
    /// Creates an Interval based on the nanoseconds given.
    /// </summary>
    public static Interval FromNanoseconds(BigInteger nanoseconds) => new Interval(0, 0, nanoseconds);


    private static int YearsToMonths(int years) => years * 12;

    private static BigInteger HoursToNanoseconds(int hours) => hours * NanosecondsInAnHour;

    private static BigInteger MinutesToNanoseconds(long minutes) => minutes * NanosecondsInAMinute;

    private static BigInteger SecondsToNanoseconds(decimal seconds) => new BigInteger(seconds * NanosecondsInASecond);

    private class IntervalParsingState
    {
        internal static char[] P = new char[] { 'P' };

        internal static char[] AfterP = new char[] { 'Y', 'M', 'D', 'T' };
        internal static char[] AfterY = new char[] { 'M', 'D', 'T' };
        internal static char[] AfterMonth = new char[] { 'D', 'T' };
        internal static char[] AfterD = new char[] { 'T' };

        internal static char[] AfterT = new char[] { 'H', 'M', 'S' };
        internal static char[] AfterH = new char[] { 'M', 'S' };
        internal static char[] AfterMins = new char[] { 'S' };

        /// <summary>
        /// The index where we'll start to parse next.
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// True if we are parsing the time part.
        /// </summary>
        public bool IsTime { get; set; }

        /// <summary>
        /// True if we are at a possible terminal state.
        /// </summary>
        public bool MayBeTerminal { get; set; }

        /// <summary>
        /// True if we are a state that must be terminal.
        /// </summary>
        public bool IsTerminal { get; set; }

        /// <summary>
        /// True if the provided fractional digits is less or equal to 9.
        /// </summary>
        public bool IsValidResolution { get; set; } = false;

        /// <summary>
        /// The delimeters that are allowed next.
        /// </summary>
        public char[] NextAllowed { get; set; } = P;

        // The values we have parsed so far.
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public long Minutes { get; set; }
        public decimal Seconds { get; set; }

        public override string ToString() =>
            $"Years: {Years}, Months: {Months}, Days: {Days}, Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    }
}
