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
using System.Text;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableVersionRangeTest
    {
        [Fact]
        public void Equality()
        {
            var control = new BigtableVersionRange(0, 10);
            var equal = new[]
            {
                new BigtableVersionRange(0, 10),
                new BigtableVersionRange(new BigtableVersion(0), new BigtableVersion(10)),
                new BigtableVersionRange(
                    BigtableVersion.UnixEpoch,
                    BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100))
            };
            var unequal = new[]
            {
                new BigtableVersionRange(null, 10),
                new BigtableVersionRange(null, new BigtableVersion(10)),
                new BigtableVersionRange(null, BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100)),
                new BigtableVersionRange(0, null),
                new BigtableVersionRange(new BigtableVersion(0), null),
                new BigtableVersionRange(BigtableVersion.UnixEpoch, null),
                new BigtableVersionRange(1, 10),
                new BigtableVersionRange(0, 11)
            };
            ComparisonTester.AssertEqual(control, equal, unequal);
        }

        [Fact]
        public void EqualityNullStart()
        {
            var control = new BigtableVersionRange(null, 10);
            var equal = new[]
            {
                new BigtableVersionRange(null, 10),
                new BigtableVersionRange(null, new BigtableVersion(10)),
                new BigtableVersionRange(null, BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100))
            };
            var unequal = new[]
            {
                new BigtableVersionRange(0, 10),
                new BigtableVersionRange(new BigtableVersion(0), new BigtableVersion(10)),
                new BigtableVersionRange(
                    BigtableVersion.UnixEpoch,
                    BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100)),
                new BigtableVersionRange(null, 11)
            };
            ComparisonTester.AssertEqual(control, equal, unequal);
        }

        [Fact]
        public void EqualityNullEnd()
        {
            var control = new BigtableVersionRange(0, null);
            var equal = new[]
            {
                new BigtableVersionRange(0, null),
                new BigtableVersionRange(new BigtableVersion(0), null),
                new BigtableVersionRange(BigtableVersion.UnixEpoch, null)
            };
            var unequal = new[]
            {
                new BigtableVersionRange(0, 10),
                new BigtableVersionRange(new BigtableVersion(0), new BigtableVersion(10)),
                new BigtableVersionRange(
                    BigtableVersion.UnixEpoch,
                    BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100)),
                new BigtableVersionRange(1, null)
            };
            ComparisonTester.AssertEqual(control, equal, unequal);
        }

        [Theory]
        [InlineData("BigtableVersionRange: Start=0; End=1", 0, 1)]
        [InlineData("BigtableVersionRange: Start=1; End=10", 1, 10)]
        [InlineData("BigtableVersionRange: Start=(none); End=10", null, 10)]
        [InlineData("BigtableVersionRange: Start=12345; End=(none)", 12345, null)]
        public void Formatting(string expectedText, long? start, long? end)
        {
            var version = new BigtableVersionRange(start, end);
            Assert.Equal(expectedText, version.ToString());
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 10)]
        [InlineData(null, 10)]
        [InlineData(12345, null)]
        public void ToTimestampRange(long? start, long? end)
        {
            var range = new BigtableVersionRange(start, end);
            var expected = new TimestampRange
            {
                StartTimestampMicros = start ?? 0,
                EndTimestampMicros = end ?? 0
            };
            Assert.Equal(expected, range.ToTimestampRange());
        }
    }
}
