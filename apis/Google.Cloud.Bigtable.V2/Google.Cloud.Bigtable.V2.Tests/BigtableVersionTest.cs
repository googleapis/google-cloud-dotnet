// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableVersionTest
    {
        [Fact]
        public void Comparisons()
        {
            var control = new BigtableVersion(5);
            var less = new[]
            {
                new BigtableVersion(0),
                new BigtableVersion(4)
            };
            var equal = new[]
            {
                new BigtableVersion(5)
            };
            var greater = new[]
            {
                new BigtableVersion(6),
                new BigtableVersion(-1),
                new BigtableVersion(long.MaxValue)
            };
            ComparisonTester.AssertCompare(control, less, equal, greater);
            ComparisonTester.AssertCompareOperators(control, less, equal, greater);
        }

        [Fact]
        public void MicrosScaleFromDateTime()
        {
            var utcNow = DateTime.UtcNow;
            var v1 = new BigtableVersion(utcNow);
            var v2 = new BigtableVersion(utcNow + TimeSpan.FromSeconds(1));
            var diff = v2.Value - v1.Value;
            Assert.Equal(1_000_000, diff);
        }

        [Fact]
        public void MicrosScaleToDateTime()
        {
            var utcNow = DateTime.UtcNow;
            var v1 = new BigtableVersion(12345);
            var v2 = new BigtableVersion(12345 + 1_000_000);
            var timespanDiff = v2.ToDateTime() - v1.ToDateTime();
            Assert.Equal(TimeSpan.FromSeconds(1), timespanDiff);
        }

        [Fact]
        public void NegativeOneIsUtcNow()
        {
            var negativeOne = new BigtableVersion(-1);
            var utcNow = new BigtableVersion(DateTime.UtcNow);

            // Verify they are not more than 1 second apart
            Assert.True(utcNow.Value - negativeOne.Value < 1_000_000);
        }

        [Fact]
        public void RoundTripDateTime()
        {
            var dateTime = DateTime.UtcNow;
            var version = new BigtableVersion(dateTime);

            // BigtableVersion stores micros, which is 10s of ticks, so truncate the ticks.
            var expected = new DateTime(dateTime.Ticks - (dateTime.Ticks % 10), DateTimeKind.Utc);
            Assert.Equal(expected, version.ToDateTime());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(long.MaxValue - 1)]
        [InlineData(long.MaxValue)]
        public void RoundTripLong(long value)
        {
            var version = new BigtableVersion(value);
            Assert.Equal(value, version.Value);
        }

        [Theory]
        [InlineData("BigtableVersion: 1507852800000000", "2017-10-13")]
        public void FormattingDateTime(string expectedText, string dateTimeText)
        {
            var dateTime = DateTime.ParseExact(
                dateTimeText,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            var version = new BigtableVersion(dateTime);
            Assert.Equal(expectedText, version.ToString());
        }

        [Theory]
        [InlineData("BigtableVersion: 0", 0)]
        [InlineData("BigtableVersion: 1", 1)]
        [InlineData("BigtableVersion: 9223372036854775807", long.MaxValue)]
        public void FormattingLong(string expectedText, long versionValue)
        {
            var version = new BigtableVersion(versionValue);
            Assert.Equal(expectedText, version.ToString());
        }
    }
}
