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
        [InlineData("PT0,5S", "PT0.5S")]
        [InlineData("PT0.500S", "PT0.5S")]
        [InlineData("PT.5S", "PT0.5S")]
        public void ParseString(string intervalString, string expectedString)
        {
            Interval interval = new Interval(intervalString);
            Assert.Equal(interval.ToIso8601(), expectedString);
        }

        [Theory]
        [InlineData("P1Y", Interval.NanosecondsInAYear)]
        [InlineData("P12M", Interval.NanosecondsInAYear)]
        [InlineData("P1M", Interval.NanosecondsInAMonth)]
        [InlineData("PT1H", Interval.NanosecondsInAnHour)]
        [InlineData("PT60M", Interval.NanosecondsInAnHour)]
        [InlineData("PT1M", Interval.NanosecondsInAMinute)]
        [InlineData("PT1S", Interval.NanosecondsInASecond)]
        [InlineData("PT0.000000001S", 1L)]
        public void GetNanoseconds(string intervalString, long expectedNanoseconds)
        {
            Interval interval = new Interval(intervalString);
            Assert.Equal(interval.ToNanoseconds(), expectedNanoseconds);
        }

        [Theory]
        [InlineData("P10Y", "P1Y", 1)]
        [InlineData("P10Y", "P10Y", 0)]
        [InlineData("P1Y", "P10Y", -1)]
        [InlineData("P1Y", "P1Y1M", -1)]
        [InlineData("P10M", "P1M", 1)]
        [InlineData("P10M", "P100M", -1)]
        [InlineData("P10M", "P10M", 0)]
        [InlineData("P10M1D", "P10M", 1)]
        [InlineData("P10MT1H", "P10M", 1)]
        [InlineData("P10D", "P10D", 0)]
        [InlineData("P1D", "P10D", -1)]
        [InlineData("P10D", "P1D", 1)]
        [InlineData("P1DT1S", "P1D", 1)]
        [InlineData("PT1H", "PT2H", -1)]
        [InlineData("PT2H1M", "PT2H", 1)]
        [InlineData("PT1S", "PT2S", -1)]
        [InlineData("PT0.000000001S", "PT0.000000002S", -1)]
        [InlineData("PT1S", "PT-1S", 1)]
        public void CompareTest(string intervalString1, string intervalString2, int expectedResult)
        {
            Interval interval1 = new Interval(intervalString1);
            Interval interval2 = new Interval(intervalString2);
            Assert.Equal(interval1.CompareTo(interval2), expectedResult);
        }

        [Theory]
        [InlineData("P0.5Y")]
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
        public void InvalidString(string intervalString)
        {
            Assert.Throws<FormatException>(() => new Interval(intervalString));
        }
    }
}
