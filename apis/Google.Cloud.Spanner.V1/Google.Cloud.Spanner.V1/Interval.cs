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
using System.Linq;
using System.Numerics;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Representation of a Time Interval
    /// </summary>
    public class Interval : IComparable<Interval>
    {
        /// <summary>
        /// Months contained in the interval
        /// </summary>
        public int Months { get; private set; } = 0;
        /// <summary>
        /// Days contained in the interval
        /// </summary>
        public int Days { get; private set; } = 0;
        /// <summary>
        /// Nanoseconds contained in the interval
        /// </summary>
        public BigInteger Nanoseconds { get; private set; } = 0;
        private const int Uninitialized = 0;
        private const int ParsingDate = 1;
        private const int ParsingTime = 2;
        /// <summary>
        /// Nanoseconds in one second
        /// </summary>
        public const long NanosecondsInASecond = 1000000000L;
        /// <summary>
        /// Nanoseconds in one minute
        /// </summary>
        public const long NanosecondsInAMinute = NanosecondsInASecond * 60;
        /// <summary>
        /// Nanoseconds in one in one hour
        /// </summary>
        public const long NanosecondsInAnHour = NanosecondsInAMinute * 60;
        /// <summary>
        /// Nanoseconds in one day
        /// </summary>
        public const long NanosecondsInADay = NanosecondsInAnHour * 24;
        /// <summary>
        /// Nanoseconds in one month
        /// </summary>
        public const long NanosecondsInAMonth = NanosecondsInADay * 30;
        /// <summary>
        /// Nanoseconds in one year
        /// </summary>
        public const long NanosecondsInAYear = NanosecondsInAMonth * 12;

        /// <summary>
        /// Representation of a Time Interval
        /// </summary>
        public Interval(string interval)
        {
            int state = 0;
            bool complete = false;
            string count = "";

            foreach (char c in interval) {
                if (state == Uninitialized) {
                    if (c != 'P') {
                        throw new FormatException("Invalid Format");
                    }

                    state = ParsingDate;
                    continue;
                }

                if (c == 'T') {
                    complete = false;
                    state = ParsingTime;
                    continue;
                }

                if (char.IsDigit(c) || c == '-' || c == '.' || c == ',') {
                    complete = false;
                    count += c == ',' ? '.' : c;
                    continue;
                }

                if (state == ParsingDate) {
                    if (!this.validateInt(count)) {
                        throw new FormatException("Invalid Format");
                    }

                    switch (c) {
                        case 'Y':
                            this.Months += this.YearsToMonths(count);
                            break;
                        case 'M':
                            this.Months += int.Parse(count);
                            break;
                        case 'D':
                            this.Days = int.Parse(count);
                            break;
                        default:
                            throw new FormatException("Invalid Format");
                    }

                    count = "";
                    complete = true;
                    continue;
                }

                if (state == ParsingTime) {
                    switch (c) {
                        case 'H':
                            this.Nanoseconds += this.HoursToNanoseconds(count);
                            break;
                        case 'M':
                            this.Nanoseconds += this.MinutesToNanoseconds(count);
                            break;
                        case 'S':
                            this.Nanoseconds += this.SecondsToNanoseconds(count);
                            break;
                        default:
                            throw new FormatException("Invalid Format");
                    }

                    count = "";
                    complete = true;
                    continue;
                }
            }

            if (!complete) {
                throw new FormatException("Invalid Format");
            }
        }

        /// <summary>
        /// Converts the current interval into an ISO8601 string
        /// </summary>
        public string ToIso8601()
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

            if (years != 0) {
                intervalString += $"{years}Y";
            }

            if (months != 0) {
                intervalString += $"{months}M";
            }

            if (days != 0) {
                intervalString += $"{days}D";
            }

            if (hours != 0 || minutes != 0 || seconds != 0) {
                intervalString += "T";

                if (hours != 0) {
                    intervalString += $"{hours}H";
                }

                if (minutes != 0) {
                    intervalString += $"{minutes}M";
                }

                if (seconds != 0) {
                    intervalString += $"{seconds}S";
                }
            }

            if (intervalString == "P") {
                return "P0Y";
            }

            return intervalString;
        }

        /// <summary>
        /// Compares one interval to another interval
        /// </summary>
        public int CompareTo(Interval other)
        {
            return this.ToNanoseconds().CompareTo(other.ToNanoseconds());
        }

        /// <summary>
        /// Converts the current interval to Nanoseconds
        /// </summary>
        public BigInteger ToNanoseconds()
        {
            BigInteger nanoseconds = 0;
            nanoseconds += (BigInteger) (this.Months * NanosecondsInAMonth);
            nanoseconds += this.Days * NanosecondsInADay;
            nanoseconds += this.Nanoseconds;

            return nanoseconds;
        }

        /// <summary>
        /// Creates an interval based on Months, Days and Nanoseconds
        /// </summary>
        public static Interval FromMonthsDaysNanos(int months, int days, BigInteger nanos)
        {
            Interval interval = new Interval("P0Y");
            interval.Months = months;
            interval.Days = days;
            interval.Nanoseconds = nanos;

            return interval;
        }

        /// <summary>
        /// Creates an interval based on the Months given
        /// </summary>
        public static Interval OfMonths(int months)
        {
            return new Interval($"P{months}M");
        }

        /// <summary>
        /// Creates an Interval based on the Days given
        /// </summary>
        public static Interval OfDays(int days)
        {
            return new Interval($"P{days}D");
        }

        /// <summary>
        /// Creates an Interval based on the seconds given
        /// </summary>
        public static Interval ofSeconds(int seconds)
        {
            return new Interval($"PT{seconds}S");
        }

        /// <summary>
        /// Creates an Interval based on the milliseconds given
        /// </summary>
        public static Interval ofMilliseconds(long milliseconds)
        {
            return new Interval($"PT{(decimal) milliseconds / 1000}S");
        }

        /// <summary>
        /// Creates an Interval based on the microseconds given
        /// </summary>
        public static Interval ofMicroseconds(long microseconds)
        {
            return new Interval($"PT{(decimal) microseconds / 1000000}S");
        }

        /// <summary>
        /// Creates an Interval based on the nanoseconds given
        /// </summary>
        public static Interval ofNanoseconds(ulong nanoseconds)
        {
            return new Interval($"PT{(decimal) nanoseconds / 1000000000}S");
        }


        private int YearsToMonths(string years)
        {
            return int.Parse(years) * 12;
        }

        private BigInteger HoursToNanoseconds(string hours)
        {
            return BigInteger.Parse(hours) * NanosecondsInAnHour;
        }

        private BigInteger MinutesToNanoseconds(string minutes)
        {
            return BigInteger.Parse(minutes) * NanosecondsInAMinute;
        }

        private BigInteger SecondsToNanoseconds(string seconds)
        {
            string[] splitNumber = seconds.Split('.');

            if (splitNumber.Length > 2) {
                throw new FormatException("Invalid Format");
            }

            decimal nanoseconds = decimal.Parse(seconds) * NanosecondsInASecond;

            return (BigInteger) nanoseconds;
        }

        private bool validateInt(string number)
        {
            if (number.Contains('.')) {
                return false;
            }

            return true;
        }
    }
}
