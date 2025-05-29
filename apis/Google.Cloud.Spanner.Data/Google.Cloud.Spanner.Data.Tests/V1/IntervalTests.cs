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
using System.Numerics;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class IntervalTests
    {
        private static readonly BigInteger NanonosecondsInASecond = (BigInteger)1_000_000_000;
        private static readonly BigInteger NanonosecondsInAMillisecond = (BigInteger)1_000_000;
        private static readonly BigInteger NanonosecondsInAMicrosecond = (BigInteger)1_000;

        [Theory]
        [InlineData(5)]
        [InlineData(-5)]
        [InlineData(13)]
        [InlineData(-13)]
        [InlineData(24)]
        [InlineData(-24)]
        [InlineData(120_000)]
        [InlineData(-120_000)]
        public void FromMonths(int months)
        {
            Interval interval = Interval.FromMonths(months);
            Assert.Equal(months, interval.Months);
            Assert.Equal(0, interval.Days);
            Assert.Equal(0, interval.Nanoseconds);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-5)]
        [InlineData(30)]
        [InlineData(-30)]
        [InlineData(31)]
        [InlineData(-31)]
        [InlineData(3_660_000)]
        [InlineData(-3_660_000)]
        public void FromDays(int days)
        {
            Interval interval = Interval.FromDays(days);
            Assert.Equal(days, interval.Days);
            Assert.Equal(0, interval.Months);
            Assert.Equal(0, interval.Nanoseconds);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(60)]
        [InlineData (-60)]
        [InlineData(90)]
        [InlineData(-90)]
        [InlineData(316_224_000_000)]
        public void FromSeconds(long seconds)
        {
            Interval interval = Interval.FromSeconds(seconds);
            Assert.Equal(seconds * NanonosecondsInASecond, interval.Nanoseconds);
            Assert.Equal(0, interval.Months);
            Assert.Equal(0, interval.Days);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(1000)]
        [InlineData(-1000)]
        [InlineData(999)]
        [InlineData(-999)]
        [InlineData(316_224_000_000_000)]
        public void FromMilliseconds(long milliseconds)
        {
            Interval interval = Interval.FromMilliseconds(milliseconds);
            Assert.Equal(milliseconds * NanonosecondsInAMillisecond, interval.Nanoseconds);
            Assert.Equal(0, interval.Months);
            Assert.Equal(0, interval.Days);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(1_000_000)]
        [InlineData(-1_000_000)]
        [InlineData(999_999)]
        [InlineData(-999_999)]
        [InlineData(316_224_000_000_000_000)]
        public void FromMicroseconds(long microseconds)
        {
            Interval interval = Interval.FromMicroseconds(microseconds);
            Assert.Equal(microseconds * NanonosecondsInAMicrosecond, interval.Nanoseconds);
            Assert.Equal(0, interval.Months);
            Assert.Equal(0, interval.Days);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(1_000_000_000)]
        [InlineData(-1_000_000_000)]
        [InlineData(999_999_999)]
        [InlineData(-999_999_999)]
        public void FromNanoseconds(BigInteger nanoseconds)
        {
            Interval interval = Interval.FromNanoseconds(nanoseconds);
            Assert.Equal(nanoseconds, interval.Nanoseconds);
            Assert.Equal(0, interval.Months);
            Assert.Equal(0, interval.Days);
        }

        [Theory]
        [InlineData("316224000000000000000")]
        [InlineData("-316224000000000000000")]
        public void FromBigIntegerNanoseconds(string nanosecondsText)
        {
            BigInteger nanoseconds = BigInteger.Parse(nanosecondsText);
            Interval interval = Interval.FromNanoseconds(nanoseconds);
            Assert.Equal(nanoseconds, interval.Nanoseconds);
            Assert.Equal(0, interval.Months);
            Assert.Equal(0, interval.Days);
        }


        [Theory]
        [InlineData(5, -30, 0)]
        [InlineData(-5, 30, 1)]
        [InlineData(13, 31, -1_000_000_000)]
        [InlineData(-13, -31, 1_000_000_000)]
        [InlineData(24, 0, 999_999_999)]
        [InlineData(-24, 3_660_000, -1)]
        [InlineData(120000, -3_660_000, -999_999_999)]
        [InlineData(-120000, 0, 0)]
        [InlineData(0, 31, 1_000_000_000)]
        [InlineData(0, 0, 0)]
        public void FromMonthsDaysAndNanoseconds(int months, int days, BigInteger nanoseconds)
        {
            Interval interval = Interval.FromMonthsDaysNanos(months, days, nanoseconds);
        }

        [Theory]
        [InlineData("P-0Y", "P0Y")]
        [InlineData("P0Y0M0DT0H0M0S", "P0Y")]
        [InlineData("P16M", "P1Y4M")]
        [InlineData("P2Y-2M", "P1Y10M")]
        [InlineData("P-1Y2M", "P-10M")]
        [InlineData("P372D", "P372D")]
        [InlineData("P-372D", "P-372D")]
        [InlineData("PT7200H", "PT7200H")]
        [InlineData("PT1H69M72S", "PT2H10M12S")]
        [InlineData("PT1H-5M-2S", "PT54M58S")]
        [InlineData("PT0.5S", "PT0.5S")]
        [InlineData("PT0.500S", "PT0.5S")]
        [InlineData("PT.5S", "PT0.5S")]
        [InlineData("P10000Y", "P10000Y")]
        [InlineData("P-10000Y", "P-10000Y")]
        [InlineData("P120000M", "P10000Y")]
        [InlineData("P-120000M", "P-10000Y")]
        [InlineData("P3660000D", "P3660000D")]
        [InlineData("P-3660000D", "P-3660000D")]
        [InlineData("PT316224000000S", "PT87840000H")]
        [InlineData("PT-316224000000S", "PT-87840000H")]
        [InlineData("PT0.999999999S", "PT0.999999999S")]
        [InlineData("PT0.000000009S", "PT0.000000009S")]
        public void ParseRoundTrip(string intervalString, string expectedString)
        {
            Interval interval = Interval.Parse(intervalString);
            Assert.Equal(expectedString, interval.ToString());
        }

        [Theory]
        [InlineData("P0.5Y")]
        [InlineData("PT0.5.5S")]
        [InlineData("P0.5M")]
        [InlineData("P0.5D")]
        [InlineData("PT0.5H")]
        [InlineData("PT0.5M")]
        [InlineData("P5S")]
        [InlineData("P1Y3S")]
        [InlineData("P1YT3M1")]
        [InlineData("P1YT3M1.1.4S")]
        [InlineData("")]
        [InlineData("P")]
        [InlineData("PT")]
        [InlineData("PTS")]
        [InlineData("PY")]
        [InlineData("PM")]
        [InlineData("PD")]
        [InlineData("PTH")]
        [InlineData("PTM")]
        [InlineData("P1Y2Y")]
        [InlineData("P1YT")]
        [InlineData("1Y")]
        public void InvalidString(string intervalString)
        {
            Assert.Throws<FormatException>(() => Interval.Parse(intervalString));
        }

        [Theory]
        [InlineData("P10001Y")]
        [InlineData("P-10001Y")]
        [InlineData("P120001M")]
        [InlineData("P-120001M")]
        [InlineData("P3660001D")]
        [InlineData("P-3660001D")]
        [InlineData("PT316224000001S")]
        [InlineData("PT-316224000001S")]
        [InlineData("PT5270400001M")]
        [InlineData("PT-5270400001M")]
        [InlineData("PT87840001H")]
        [InlineData("PT-87840001H")]
        public void OutOfRangeValues(string intervalString)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Interval.Parse(intervalString));
        }
    }
}
