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
        [InlineData("PT0.5S", "PT0.5S")]
        [InlineData("PT0.500S", "PT0.5S")]
        [InlineData("PT.5S", "PT0.5S")]
        public void ParseString(string intervalString, string expectedString)
        {
            Interval interval = Interval.FromIso8601String(intervalString);
            Assert.Equal(interval.ToString(), expectedString);
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
            Assert.Throws<FormatException>(() => Interval.FromIso8601String(intervalString));
        }
    }
}
