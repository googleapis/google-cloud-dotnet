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
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

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
    public static Interval Parse(string intervalString)
    {
        const int years = 2, months = 4, days = 6, hours = 9, minutes = 11, seconds = 14;
        string isoPattern = @"^P(?!$)((-?\d+)Y)?((-?\d+)M)?((-?\d+)D)?(T(?=-?.?\d)((-?\d+)H)?((-?\d+)M)?(((-?(((\d+)((\.|\,)\d{1,9})?)|((\.|\,)\d{1,9})))S))?)?$";

        int calculatedMonths = 0;
        int calculatedDays = 0;
        BigInteger calculatedNanoseconds = 0;

        MatchCollection matches = Regex.Matches(intervalString, isoPattern);
        if (matches.Count != 1)
        {
            throw new FormatException("Invalid Format");
        }

        GroupCollection groups = matches[0].Groups;

        if (groups[years].Value != "")
        {
            calculatedMonths += Interval.YearsToMonths(groups[years].Value);
        }

        if (groups[months].Value != "")
        {
            // This is for the case that (years to months) + (months) overflow the integer and avoid
            // bugs for the user.
            checked {
                calculatedMonths += int.Parse(groups[months].Value);
            }
        }

        if (groups[days].Value != "")
        {
            calculatedDays = int.Parse(groups[days].Value);
        }

        if (groups[hours].Value != "")
        {
            calculatedNanoseconds += Interval.HoursToNanoseconds(groups[hours].Value);
        }

        if (groups[minutes].Value != "")
        {
            calculatedNanoseconds += Interval.MinutesToNanoseconds(groups[minutes].Value);
        }

        if (groups[seconds].Value != "")
        {
            calculatedNanoseconds += Interval.SecondsToNanoseconds(groups[seconds].Value);
        }

        return new Interval(calculatedMonths, calculatedDays, calculatedNanoseconds);
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


    private static int YearsToMonths(string years) => int.Parse(years) * 12;

    private static BigInteger HoursToNanoseconds(string hours) => BigInteger.Parse(hours) * NanosecondsInAnHour;

    private static BigInteger MinutesToNanoseconds(string minutes) => BigInteger.Parse(minutes) * NanosecondsInAMinute;

    private static BigInteger SecondsToNanoseconds(string seconds)
    {
        string[] splitNumber = seconds.Split('.');

        if (splitNumber.Length > 2)
        {
            throw new FormatException("Invalid Format");
        }

        decimal nanoseconds = decimal.Parse(seconds) * NanosecondsInASecond;

        return new BigInteger(nanoseconds);
    }
}
