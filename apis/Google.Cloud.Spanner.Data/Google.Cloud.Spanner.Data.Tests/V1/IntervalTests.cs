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

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Threading;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class IntervalTests
    {
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
        [InlineData(5, "P5M")]
        [InlineData(-5, "P-5M")]
        [InlineData(13, "P1Y1M")]
        [InlineData(-13, "P-1Y-1M")]
        [InlineData(24, "P2Y")]
        [InlineData(-24, "P-2Y")]
        [InlineData(120000, "P10000Y")]
        [InlineData(-120000, "P-10000Y")]
        public void FromMonths(int totalMonths, string expectedString)
        {
            Interval interval = Interval.FromMonths(totalMonths);
            Assert.Equal(expectedString, interval.ToString());
        }

        [Theory]
        [InlineData(5, "P5D")]
        [InlineData(-5, "P-5D")]
        [InlineData(30, "P30D")]
        [InlineData(-30, "P-30D")]
        [InlineData(31, "P31D")]
        [InlineData(-31, "P-31D")]
        [InlineData(3660000, "P3660000D")]
        [InlineData(-3660000, "P-3660000D")]
        public void FromDays(int totalDays, string expectedString)
        {
            Interval interval = Interval.FromDays(totalDays);
            Assert.Equal(expectedString, interval.ToString());
        }

        [Theory]
        [InlineData(1, "PT1S")]
        [InlineData(-1, "PT-1S")]
        [InlineData(60, "PT1M")]
        [InlineData(-60, "PT-1M")]
        [InlineData(90, "PT1M30S")]
        [InlineData(-90, "PT-1M-30S")]
        [InlineData(316224000000, "PT87840000H")]
        public void FromSeconds(long totalSeconds, string expectedString)
        {
            Interval interval = Interval.FromSeconds(totalSeconds);
            Assert.Equal(expectedString, interval.ToString());
        }

        [Theory]
        [InlineData(1, "PT0.001S")]
        [InlineData(-1, "PT-0.001S")]
        [InlineData(1000, "PT1S")]
        [InlineData(-1000, "PT-1S")]
        [InlineData(999, "PT0.999S")]
        [InlineData(-999, "PT-0.999S")]
        [InlineData(316224000000000, "PT87840000H")]
        public void FromMilliseconds(long totalMilliseconds, string expectedString)
        {
            Interval interval = Interval.FromMilliseconds(totalMilliseconds);
            Assert.Equal(expectedString, interval.ToString());
        }

        [Theory]
        [InlineData(1, "PT0.000001S")]
        [InlineData(-1, "PT-0.000001S")]
        [InlineData(1000000, "PT1S")]
        [InlineData(-1000000, "PT-1S")]
        [InlineData(999999, "PT0.999999S")]
        [InlineData(-999999, "PT-0.999999S")]
        [InlineData(316224000000000000, "PT87840000H")]
        public void FromMicroseconds(long totalMicroseconds, string expectedString)
        {
            Interval interval = Interval.FromMicroseconds(totalMicroseconds);
            Assert.Equal(expectedString, interval.ToString());
        }

        [Theory]
        [InlineData(1, "PT0.000000001S")]
        [InlineData(-1, "PT-0.000000001S")]
        [InlineData(1000000000, "PT1S")]
        [InlineData(-1000000000, "PT-1S")]
        [InlineData(999999999, "PT0.999999999S")]
        [InlineData(-999999999, "PT-0.999999999S")]
        public void FromNanoseconds(BigInteger totalNanoseconds, string expectedString)
        {
            Interval interval = Interval.FromNanoseconds(totalNanoseconds);
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
