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
public sealed class Interval
{
    /// <summary>
    /// Represents the zero Interval value.
    /// </summary>
    public static Interval Zero { get; } = new Interval(0, 0, 0);

    /// <summary>
    /// Represents the maximum possible value of an Interval.
    /// </summary>
    public static Interval MaxValue { get; } = new Interval(MaxMonths, MaxDays, MaxNanoseconds);

    /// <summary>
    /// Represents the minimum possible value of an Interval.
    /// </summary>
    public static Interval MinValue { get; } = new Interval(MinMonths, MinDays, MinNanoseconds);

    internal const int MaxMonths = 120_000;
    internal const int MinMonths = -MaxMonths;
    internal const int MaxDays = 3_660_000;
    internal const int MinDays = -MaxDays;
    internal static BigInteger MaxNanoseconds { get; } = BigInteger.Parse("316224000000000000000"); 
    internal static BigInteger MinNanoseconds { get; } = -MaxNanoseconds;

    internal const long NanosecondsPerSecond = 1_000_000_000;
    internal const long NanosecondsPerMinute = NanosecondsPerSecond * 60;
    internal const long NanosecondsPerHour = NanosecondsPerMinute * 60;
    internal const long NanosecondsPerMillisecond = 1_000_000;
    internal const long NanosecondsPerMicrosecond = 1_000;
    internal const int MonthsPerYear = 12;

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
    public static Interval FromSeconds(decimal seconds)
    {
        // We only accept 9 decimal places.
        decimal rounded = Math.Round(seconds, 9);
        if (seconds != rounded)
        {
            throw new ArgumentOutOfRangeException($"Interval has a nanosecond precision, a maximum 9 decimal places are allowed for seconds.");
        }
        return new Interval(0, 0, new BigInteger(seconds * NanosecondsPerSecond));
    }

    /// <summary>
    /// Creates an interval from the given milliseconds.
    /// </summary>
    public static Interval FromMilliseconds(BigInteger milliseconds) => new Interval(0, 0, milliseconds * NanosecondsPerMillisecond);

    /// <summary>
    /// Creates an interval from the given microseconds.
    /// </summary>
    public static Interval FromMicroseconds(BigInteger microseconds) => new Interval(0, 0, microseconds * NanosecondsPerMicrosecond);

    /// <summary>
    /// Creates an interval from the given nanoseconds.
    /// </summary>
    public static Interval FromNanoseconds(BigInteger nanoseconds) => new Interval(0, 0, nanoseconds);

    private static char[] P { get; } = ['P'];

    private static char[] AfterP { get; } = ['Y', 'M', 'D', 'T'];
    private static char[] AfterY { get; } = ['M', 'D', 'T'];
    private static char[] AfterMonths { get; } = ['D', 'T'];
    private static char[] AfterD { get; } = ['T'];

    private static char[] AfterT { get; } = ['H', 'M', 'S'];
    private static char[] AfterH { get; } = ['M', 'S'];
    private static char[] AfterMinutess { get; } = ['S'];

    /// <summary>
    /// Parses the string represantion in ISO 8601 format of a duration returning its Interval equivalent.
    /// </summary>
    /// <param name="text">
    /// The string representation of a duration in ISO 8601 format: P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S.
    /// <list type="bullet">
    /// <item>
    /// Each field has an individual sign.
    /// </item>
    /// <item>
    /// Only seconds can be fractional with a maximum of 9 decimal positions for up to nanosecond precision.
    /// </item>
    /// <item>
    /// Each part does not need to be normalized. For instance <c>P1Y21M45DT47H250M3.245D</c> is valid.
    /// </item>
    /// <item>
    /// Not all parts need to be specified. For instance <c>P3M</c>, <c>PT4H5M</c>, <c>P3YT5M</c> are all valid.
    /// </item>
    /// </list>
    /// </param>
    public static Interval Parse(string text)
    {
        GaxPreconditions.CheckNotNull(text, nameof(text));

        // The values we have parsed so far.
        int years = 0;
        int months = 0;
        int days = 0;
        int hours = 0;
        long minutes = 0;
        decimal seconds = 0;

        // The parsing status.
        int start = 0;
        bool isTime = false;
        bool mayBeTerminal;
        bool isTerminal;
        char[] nextAllowed  = P;
        int end;

        do
        {
            end = text.IndexOfAny(nextAllowed, start);

            // We couldn't find any of the allowed characters of which we needed to find one.
            if (end == -1)
            {
                throw new FormatException($"Expected one of '{string.Join(", ", nextAllowed)}' in '{text.Substring(start)}'.");
            }
            // P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S
            switch (text[end])
            {
                case 'P':
                    mayBeTerminal = false;
                    isTerminal = false;
                    isTime = false;
                    nextAllowed = AfterP;
                    break;
                case 'Y':
                    mayBeTerminal = true;
                    isTerminal = false;
                    isTime = false;
                    years = ParseInt();
                    nextAllowed = AfterY;
                    break;
                case 'M' when !isTime:
                    mayBeTerminal = true;
                    isTerminal = false;
                    isTime = false;
                    months = ParseInt();
                    nextAllowed = AfterMonths;
                    break;
                case 'D':
                    mayBeTerminal = true;
                    isTerminal = false;
                    isTime = false;
                    days = ParseInt();
                    nextAllowed = AfterD;
                    break;
                case 'T':
                    mayBeTerminal = false;
                    isTerminal = false;
                    isTime = true;
                    nextAllowed = AfterT;
                    break;
                case 'H':
                    mayBeTerminal = true;
                    isTerminal = false;
                    isTime = true;
                    hours = ParseInt();
                    nextAllowed = AfterH;
                    break;
                case 'M' when isTime:
                    mayBeTerminal = true;
                    isTerminal = false;
                    isTime = true;
                    minutes = ParseLong();
                    nextAllowed = AfterMinutess;
                    break;
                case 'S':
                    mayBeTerminal = true;
                    isTerminal = true;
                    isTime = true;
                    seconds = ParseSeconds();
                    nextAllowed = null;
                    break;
                default:
                    throw new InvalidOperationException($"There's a bug in Interval.Parse. " +
                        $"Expected one of the allowed characters but found '{text[end]}' when looking from position {start}.");
            }

            start = end + 1;

        } while (start < text.Length && !isTerminal);

        // We are at a terminal state but we haven't parsed the whole string yet.
        if (isTerminal && start < text.Length)
        {
            throw new FormatException($"Can't parse '{text.Substring(start)}' after reaching the end of a valid interval.");
        }

        // We parsed the whole string but we ended up at a state that's not terminal.
        if (!mayBeTerminal)
        {
            throw new FormatException($"'{text}' ending is not correctly formatted.");
        }

        int totalMonths =
            years * MonthsPerYear
            + months;

        BigInteger totalNanoseconds =
            hours * (BigInteger)NanosecondsPerHour
            + minutes * (BigInteger)NanosecondsPerMinute
            + new BigInteger(seconds * NanosecondsPerSecond);

        return new Interval(totalMonths, days, totalNanoseconds);

        int ParseInt() => int.Parse(text.Substring(start, end - start), CultureInfo.InvariantCulture);
        long ParseLong() => long.Parse(text.Substring(start, end - start), CultureInfo.InvariantCulture);
        decimal ParseSeconds()
        {
            var secondsText = text.Substring(start, end - start).Replace(',', '.');
            var decimalSeparatorIndex = secondsText.IndexOf('.');
            var original = decimal.Parse(secondsText, CultureInfo.InvariantCulture);

            // If we have more than 9 decimal places, let's figure out the right exception type to throw.
            if (decimalSeparatorIndex > 0 && secondsText.Length - decimalSeparatorIndex > 10 )
            {
                var rounded = Math.Round(original, 9);
                if (original == rounded) // The extra places are zeroes. We still fail.
                {
                    throw new FormatException($"A maximum of 9 decimal places are allowed for seconds, including zeroes.");
                }
                else // The extra places are non zeroes.
                {
                    throw new ArgumentOutOfRangeException($"Interval has a nanosecond precision, a maximum of 9 decimal places are allowed for seconds.");
                }
            }

            return original;
        }
    }

    /// <summary>
    /// Parses the string represantion in ISO 8601 format of a duration returning its Interval equivalent, if possible.
    /// </summary>
    /// <param name="text">
    /// The string representation of a duration in ISO 8601 format: P[n]Y[n]M[n]DT[n]H[n]M[n[.fraction]]S.
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
        catch
        {
            interval = null;
            return false;
        }
    }

    /// <summary>
    /// Returns the ISO 8601 string representation of this Interval.
    /// </summary>
    public override string ToString()
    {
        if (Equals(Zero))
        {
            return "P0Y";
        }

        int years = Months / MonthsPerYear;
        int months = Months % MonthsPerYear;

        int hours = (int)(Nanoseconds / NanosecondsPerHour);
        long remainingNanoseconds = (long)(Nanoseconds % NanosecondsPerHour);

        long minutes = remainingNanoseconds / NanosecondsPerMinute;
        remainingNanoseconds %= NanosecondsPerMinute;

        decimal seconds = (decimal)remainingNanoseconds / NanosecondsPerSecond;

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
}
