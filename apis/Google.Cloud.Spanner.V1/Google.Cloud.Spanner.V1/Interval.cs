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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Google.Cloud.Spanner.V1
{
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

        /// <summary>
        /// Months contained in the interval.
        /// </summary>
        public int Months { get; set; } = 0;

        /// <summary>
        /// Days contained in the interval.
        /// </summary>
        public int Days { get; set; } = 0;

        /// <summary>
        /// Nanoseconds contained in the interval.
        /// </summary>
        public BigInteger Nanoseconds { get; set; } = 0;

        /// <summary>
        /// Representation of a Time Interval.
        /// </summary>
        private Interval(int months, int days, BigInteger nanoseconds)
        {
            this.Months = months;
            this.Days = days;
            this.Nanoseconds = nanoseconds;
        }

        /// <summary>
        /// Constructs an interval based on an Iso8601 duration string.
        /// </summary>
        public static Interval FromIso8601String(string intervalString)
        {
            const int Years = 1, Months = 2, Days = 3, Hours = 5, Minutes = 6, Seconds = 7;
            HashSet<int> groupNames = new HashSet<int> { Years, Months, Days, Hours, Minutes, Seconds };
            string isoPattern = @"^P(?!$)(-?\d+Y)?(-?\d+M)?(-?\d+D)?(T(?=-?.?\d)(-?\d+H)?(-?\d+M)?(-?(((\d*)((\.|,)\d{1,9})?)|(\.\d{1,9}))S)?)?$";

            int calculatedMonths = 0;
            int calculatedDays = 0;
            BigInteger calculatedNanoseconds = 0;

            MatchCollection matches = Regex.Matches(intervalString, isoPattern);
            if (matches.Count != 1)
            {
                throw new FormatException("Invalid Format");
            }

            int index = 0;
            foreach (Group group in matches[0].Groups)
            {
                if (!groupNames.Contains(index))
                {
                    index++;
                    continue;
                }

                if (group.Value == "")
                {
                    index++;
                    continue;
                }

                // Stripping the letters out of the match group
                string numericString = Regex.Replace(group.Value, "[^0-9.,-]", "");
                switch (index)
                {
                    case Years:
                        calculatedMonths += Interval.YearsToMonths(numericString);
                        break;
                    case Months:
                        calculatedMonths += int.Parse(numericString);
                        break;
                    case Days:
                        calculatedDays = int.Parse(numericString);
                        break;
                    case Hours:
                        calculatedNanoseconds += Interval.HoursToNanoseconds(numericString);
                        break;
                    case Minutes:
                        calculatedNanoseconds += Interval.MinutesToNanoseconds(numericString);
                        break;
                    case Seconds:
                        calculatedNanoseconds += Interval.SecondsToNanoseconds(numericString);
                        break;
                }
                index++;
            }

            return new Interval(calculatedMonths, calculatedDays, calculatedNanoseconds);
        }

        /// <summary>
        /// Converts the current interval into an ISO8601 string
        /// </summary>
        public override string ToString()
        {
            int years;
            int months;
            int days = this.Days;
            int hours;
            int minutes;
            float seconds;
            BigInteger remainingNanoseconds = this.Nanoseconds;

            years = this.Months / 12;
            months = this.Months % 12;
            hours = (int) (remainingNanoseconds / 3600000000000);
            remainingNanoseconds %= 3600000000000;
            minutes = (int) (remainingNanoseconds / 60000000000);
            remainingNanoseconds %= 60000000000;
            seconds = (float) remainingNanoseconds / 1000000000;

            string intervalString = "P";

            if (years != 0)
            {
                intervalString += $"{years}Y";
            }

            if (months != 0)
            {
                intervalString += $"{months}M";
            }

            if (days != 0)
            {
                intervalString += $"{days}D";
            }

            if (hours != 0 || minutes != 0 || seconds != 0)
            {
                intervalString += "T";

                if (hours != 0)
                {
                    intervalString += $"{hours}H";
                }

                if (minutes != 0)
                {
                    intervalString += $"{minutes}M";
                }

                if (seconds != 0)
                {
                    intervalString += $"{seconds}S";
                }
            }

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
            if (obj == null || !(obj is Interval))
            {
                return false;
            }

            Interval other = obj as Interval;

            if (this.Months != other.Months)
            {
                return false;
            }

            if (this.Days != other.Days)
            {
                return false;
            }

            if (this.Nanoseconds != other.Nanoseconds)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the object hashcode
        /// </summary>
        public override int GetHashCode() => this.Days.GetHashCode() + this.Months.GetHashCode() + this.Nanoseconds.GetHashCode();

        /// <summary>
        /// Creates an interval based on Months, Days and Nanoseconds.
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

            return (BigInteger) nanoseconds;
        }

        private bool validateInt(string number)
        {
            if (number.Contains('.'))
            {
                return false;
            }

            return true;
        }
    }
}
