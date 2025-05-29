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
using System.Numerics;
using System.Text;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Represents the Spanner Interval type.
/// </summary>
public class Interval
{
    /// <summary>
    /// Represents the zero Interval value.
    /// </summary>
    public static readonly Interval Zero = new Interval(0, 0, 0);

    /// <summary>
    /// Represents the maximum possible value of an Interval.
    /// </summary>
    public static readonly Interval MaxValue = new Interval(MaxMonths, MaxDays, MaxNanoseconds);

    /// <summary>
    /// Represents the minimum possible value of an Interval.
    /// </summary>
    public static readonly Interval MinValue = new Interval(MinMonths, MinDays, MinNanoseconds);

    internal const int MaxMonths = 120_000;
    internal const int MinMonths = -MaxMonths;
    internal const int MaxDays = 3_660_000;
    internal const int MinDays = -MaxDays;
    internal static readonly BigInteger MaxNanoseconds = BigInteger.Parse("316224000000000000000");
    internal static readonly BigInteger MinNanoseconds = -MaxNanoseconds;

    internal const long NanosecondsInASecond = 1_000_000_000;
    internal const long NanosecondsInAMinute = NanosecondsInASecond * 60;
    internal const long NanosecondsInAnHour = NanosecondsInAMinute * 60;
    internal const long NanosecondsInAMillisecond = 1_000_000;
    internal const long NanosecondsInAMicrosecond = 1_000;
    internal const int MonthsInAYear = 12;

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

    private Interval(int months, int days, BigInteger nanoseconds)
    {
        Months = GaxPreconditions.CheckArgumentRange(months, nameof(months), MinMonths, MaxMonths);
        Days = GaxPreconditions.CheckArgumentRange(days, nameof(days), MinDays, MaxDays);
        Nanoseconds = GaxPreconditions.CheckArgumentRange(nanoseconds, nameof(nanoseconds), MinNanoseconds, MaxNanoseconds);
    }

    /// <summary>
    /// Creates an interval from the given months, days and nanoseconds.
    /// </summary>
    public static Interval FromMonthsDaysNanos(int months, int days, BigInteger nanos) => new Interval(months, days, nanos);

    /// <summary>
    /// Creates an interval from the given months.
    /// </summary>
    public static Interval FromMonths(int months) => new Interval(months, 0, 0);

    /// <summary>
    /// Creates an interval from the given days.
    /// </summary>
    public static Interval FromDays(int days) => new Interval(0, days, 0);

    /// <summary>
    /// Creates an interval from the given seconds.
    /// </summary>
    public static Interval FromSeconds(decimal seconds) => new Interval(0, 0, SecondsToNanoseconds(seconds));

    /// <summary>
    /// Creates an interval from the given milliseconds.
    /// </summary>
    public static Interval FromMilliseconds(BigInteger milliseconds) => new Interval(0, 0, milliseconds * NanosecondsInAMillisecond);

    /// <summary>
    /// Creates an interval from the given microseconds.
    /// </summary>
    public static Interval FromMicroseconds(BigInteger microseconds) => new Interval(0, 0, microseconds * NanosecondsInAMicrosecond);

    /// <summary>
    /// Creates an interval from the given nanoseconds.
    /// </summary>
    public static Interval FromNanoseconds(BigInteger nanoseconds) => new Interval(0, 0, nanoseconds);

    /// <summary>
    /// Parses the string represantion in ISO8601 format of a duration returning its Interval equivalent.
    /// </summary>
    /// <param name="text">
    /// The string representation of a duration in ISO8601 format: P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S.
    /// </param>
    public static Interval Parse(string text)
    {
        GaxPreconditions.CheckNotNull(text, nameof(text));

        var state = new IntervalParsingState();
        int end;
        do
        {
            end = text.IndexOfAny(state.NextAllowed, state.Start);

            // We couldn't find any of the allowed characters of which we needed to find one.
            if (end == -1)
            {
                throw new FormatException($"Expected one of {string.Join(", ", state.NextAllowed)} in {text.Substring(state.Start)}.");
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
                    throw new InvalidOperationException("There's a bug in Interval.Parse.");
            }

            state.Start = end + 1;

        } while (state.Start < text.Length && !state.IsTerminal);

        // We are at a terminal state but we haven't parsed the whole string yet.
        if (state.IsTerminal && state.Start < text.Length)
        {
            throw new FormatException($"Can't parse {text.Substring(state.Start)} after reaching the end of a valid duration.");
        }

        // We parsed the whole string but we ended up at a state that's not terminal.
        if (!state.MayBeTerminal)
        {
            throw new FormatException($"{text} ending is not correctly formatted.");
        }

        int totalMonths =
            state.Years * MonthsInAYear
            + state.Months;

        BigInteger totalNanoseconds =
            state.Hours * (BigInteger)NanosecondsInAnHour
            + state.Minutes * (BigInteger)NanosecondsInAMinute
            + SecondsToNanoseconds(state.Seconds);

        return new Interval(totalMonths, state.Days, totalNanoseconds);

        int ParseInt() => int.Parse(text.Substring(state.Start, end - state.Start), CultureInfo.InvariantCulture);
        long ParseLong() => long.Parse(text.Substring(state.Start, end - state.Start), CultureInfo.InvariantCulture);
        decimal ParseSeconds() => decimal.Parse(text.Substring(state.Start, end - state.Start).Replace(',', '.'), CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Parses the string represantion in ISO8601 format of a duration returning its Interval equivalent, if possible.
    /// </summary>
    /// <param name="text">
    /// The string representation of a duration in ISO8601 format: P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S.
    /// </param>
    /// <param name="interval">
    /// The resulting Interval value, if parsing was succesful. null otherwise.
    /// </param>
    public static bool TryParse(string text, out Interval interval)
    {
        try
        {
            interval = Parse(text);
            return true;
        }
        catch (Exception)
        {
            interval = null;
            return false;
        }
    }

    /// <summary>
    /// Returns the ISO8601 string representation of this Interval.
    /// </summary>
    public override string ToString()
    {
        if (Equals(Zero))
        {
            return "P0Y";
        }

        int years = Months / MonthsInAYear ;
        int months = Months % MonthsInAYear;

        int hours = (int)(Nanoseconds / NanosecondsInAnHour);
        long remainingNanoseconds = (long)(Nanoseconds % NanosecondsInAnHour);

        long minutes = remainingNanoseconds / NanosecondsInAMinute;
        remainingNanoseconds %= NanosecondsInAMinute;

        decimal seconds = (decimal)remainingNanoseconds / NanosecondsInASecond;

        StringBuilder intervalBuilder = new StringBuilder("P");

        if (years != 0)
        {
            intervalBuilder.Append(years.ToString(CultureInfo.InvariantCulture));
            intervalBuilder.Append("Y");
        }

        if (months != 0)
        {
            intervalBuilder.Append(months.ToString(CultureInfo.InvariantCulture));
            intervalBuilder.Append("M");
        }

        if (Days != 0)
        {
            intervalBuilder.Append(Days.ToString(CultureInfo.InvariantCulture));
            intervalBuilder.Append("D");
        }

        if (Nanoseconds != 0) // Has a time component
        {
            intervalBuilder.Append("T");

            if (hours != 0)
            {
                intervalBuilder.Append(hours.ToString(CultureInfo.InvariantCulture));
                intervalBuilder.Append("H");
            }

            if (minutes != 0)
            {
                intervalBuilder.Append(minutes.ToString(CultureInfo.InvariantCulture));
                intervalBuilder.Append("M");
            }

            if (seconds != 0)
            {
                intervalBuilder.Append(seconds.ToString(CultureInfo.InvariantCulture));
                intervalBuilder.Append("S");
            }
        }

        return intervalBuilder.ToString();
    }

    /// <inheritdocs/>
    public override bool Equals(object obj) =>
        obj is Interval other
        && other.Months == Months
        && other.Days == Days
        && other.Nanoseconds == Nanoseconds;

    /// <inheritdocs/>
    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(Days.GetHashCode(), Months.GetHashCode(), Nanoseconds.GetHashCode());

    private static BigInteger SecondsToNanoseconds(decimal seconds)
    {
        // We only accept 9 decimal places.
        decimal rounded = Math.Round(seconds, 9);
        if (seconds != rounded)
        {
            throw new ArgumentOutOfRangeException($"Interval has a nanosecond precision, only 9 decimal places are allowed for seconds.");
        }

        return new BigInteger(seconds * NanosecondsInASecond);
    }

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
