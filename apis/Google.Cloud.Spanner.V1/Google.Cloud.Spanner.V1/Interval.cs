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
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Representation of a Time Interval.
/// </summary>
public class Interval
{
    internal const long NanosecondsInASecond = 1000000000L;
    internal const long NanosecondsInAMinute = NanosecondsInASecond * 60;
    internal const long NanosecondsInAnHour = NanosecondsInAMinute * 60;
    internal const long NanosecondsInAMillisecond = 1000000L;
    internal const long NanosecondsInAMicrosecond = 1000L;
    internal const int MonthsInAYear = 12;
    internal const int MaxMonths = 120000;
    internal const int MinMonths = -MaxMonths;
    internal const int MaxDays = 3660000;
    internal const int MinDays = -MaxDays;
    internal static readonly BigInteger MaxNanoseconds = BigInteger.Parse("316224000000000000000");

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
        GaxPreconditions.CheckArgumentRange(months, nameof(months), MinMonths, MaxMonths);
        Months = months;

        GaxPreconditions.CheckArgumentRange(days, nameof(days), MinDays, MaxDays);
        Days = days;

        GaxPreconditions.CheckArgumentRange(nanoseconds, nameof(nanoseconds), -MaxNanoseconds, MaxNanoseconds);
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
        GaxPreconditions.CheckNotNull(text, nameof(text));

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
                    state.NextAllowed = IntervalParsingState.AfterP;
                    break;
                case 'Y':
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.Years = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterY;
                    break;
                case 'M' when !state.IsTime:
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.Months = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterMonth;
                    break;
                case 'D':
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.Days = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterD;
                    break;
                case 'T':
                    state.MayBeTerminal = false;
                    state.IsTerminal = false;
                    state.IsTime = true;
                    state.NextAllowed = IntervalParsingState.AfterT;
                    break;
                case 'H':
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.Hours = ParseInt();
                    state.NextAllowed = IntervalParsingState.AfterH;
                    break;
                case 'M' when state.IsTime:
                    state.MayBeTerminal = true;
                    state.IsTerminal = false;
                    state.Minutes = ParseLong();
                    state.NextAllowed = IntervalParsingState.AfterMins;
                    break;
                case 'S':
                    state.MayBeTerminal = true;
                    state.IsTerminal = true;
                    state.Seconds = ParseSeconds();
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

        int ParseInt() => int.Parse(text.Substring(state.Start, end - state.Start), CultureInfo.InvariantCulture.NumberFormat);
        long ParseLong() => long.Parse(text.Substring(state.Start, end - state.Start), CultureInfo.InvariantCulture.NumberFormat);
        decimal ParseSeconds()
        {
            string textDecimal = text.Substring(state.Start, end - state.Start).Replace(',', '.');
            string[] splitDecimal = textDecimal.Split('.');

            // If we have more than 9 digits after the decimal, it is not valid
            if (splitDecimal.Length > 1 && splitDecimal[1].Length > 9)
            {
                throw new ArgumentOutOfRangeException("The Interval type only accepts a resolution of 9 digits after a decimal point (nanoseconds).");
            }


            return decimal.Parse(textDecimal, CultureInfo.InvariantCulture.NumberFormat);
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
        try
        {
            interval = Interval.Parse(text);
            return true;
        }
        catch (Exception)
        {
            interval = null;
            return false;
        }
    }

    /// <summary>
    /// Converts the current interval into an ISO8601 string
    /// </summary>
    public override string ToString()
    {
        BigInteger remainingNanoseconds = Nanoseconds;

        int years = Interval.MonthsToYears(Months);
        int months = Months % MonthsInAYear;
        int hours = Interval.NanosecondsToHours(remainingNanoseconds);
        remainingNanoseconds %= NanosecondsInAnHour;
        long minutes = Interval.NanosecondsToMinutes(remainingNanoseconds);
        remainingNanoseconds %= NanosecondsInAMinute;
        decimal seconds = Interval.NanosecondsToSeconds(remainingNanoseconds);

        StringBuilder intervalBuilder = new StringBuilder("P");

        if (years != 0)
        {
            intervalBuilder.Append($"{years}Y");
        }

        if (months != 0)
        {
            intervalBuilder.Append($"{months}M");
        }

        if (Days != 0)
        {
            intervalBuilder.Append($"{Days}D");
        }

        if (hours != 0 || minutes != 0 || seconds != 0)
        {
            intervalBuilder.Append("T");

            if (hours != 0)
            {
                intervalBuilder.Append($"{hours}H");
            }

            if (minutes != 0)
            {
                intervalBuilder.Append($"{minutes}M");
            }

            if (seconds != 0)
            {
                intervalBuilder.Append($"{seconds.ToString("0.#########", CultureInfo.InvariantCulture)}S");
            }
        }

        if (intervalBuilder.Length == 1)
        {
            return "P0Y";
        }

        return intervalBuilder.ToString(); ;
    }

    /// <inheritdocs/>
    public override bool Equals(object obj) =>
        obj is Interval other && other.Months == Months && other.Days == Days && other.Nanoseconds == Nanoseconds;

    /// <inheritdocs/>
    public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(Days.GetHashCode(), Months.GetHashCode(), Nanoseconds.GetHashCode());

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
    public static Interval FromSeconds(decimal seconds) => new Interval(0, 0, Interval.SecondsToNanoseconds(seconds));

    /// <summary>
    /// Creates an Interval based on the milliseconds given.
    /// </summary>
    public static Interval FromMilliseconds(BigInteger milliseconds) => new Interval(0, 0, Interval.MillisecondsToNanoseconds(milliseconds));

    /// <summary>
    /// Creates an Interval based on the microseconds given.
    /// </summary>
    public static Interval FromMicroseconds(BigInteger microseconds) => new Interval(0, 0, Interval.MicroseondsToNanoseconds(microseconds));

    /// <summary>
    /// Creates an Interval based on the nanoseconds given.
    /// </summary>
    public static Interval FromNanoseconds(BigInteger nanoseconds) => new Interval(0, 0, nanoseconds);


    private static int YearsToMonths(int years) => years * 12;

    private static BigInteger HoursToNanoseconds(int hours) => new BigInteger(hours) * NanosecondsInAnHour;

    private static BigInteger MinutesToNanoseconds(long minutes) => new BigInteger(minutes) * NanosecondsInAMinute;

    private static BigInteger SecondsToNanoseconds(decimal seconds) => new BigInteger(seconds * NanosecondsInASecond);

    private static int MonthsToYears(int months) => months / MonthsInAYear;

    private static int NanosecondsToHours(BigInteger nanoseconds) => (int) (nanoseconds / NanosecondsInAnHour);

    private static long NanosecondsToMinutes(BigInteger nanoseconds) => (long) (nanoseconds / NanosecondsInAMinute);

    private static decimal NanosecondsToSeconds(BigInteger nanoseconds) => (decimal) nanoseconds / NanosecondsInASecond;

    private static BigInteger MillisecondsToNanoseconds(BigInteger milliseconds) => milliseconds * NanosecondsInAMillisecond;

    private static BigInteger MicroseondsToNanoseconds(BigInteger microseconds) => microseconds * NanosecondsInAMicrosecond;

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
    }
}
