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
                    BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100_000))
            };
            var unequal = new[]
            {
                new BigtableVersionRange(null, 10),
                new BigtableVersionRange(null, new BigtableVersion(10)),
                new BigtableVersionRange(null, BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100_000)),
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
                new BigtableVersionRange(null, BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100_000))
            };
            var unequal = new[]
            {
                new BigtableVersionRange(0, 10),
                new BigtableVersionRange(new BigtableVersion(0), new BigtableVersion(10)),
                new BigtableVersionRange(
                    BigtableVersion.UnixEpoch,
                    BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100_000)),
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
                    BigtableVersion.UnixEpoch + TimeSpan.FromTicks(100_000)),
                new BigtableVersionRange(1, null)
            };
            ComparisonTester.AssertEqual(control, equal, unequal);
        }

        [Fact]
        public void Validate_Long()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new BigtableVersionRange(-2, null));
            Assert.Throws<ArgumentOutOfRangeException>(() => new BigtableVersionRange(null, -2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new BigtableVersionRange((long.MaxValue / 1000) + 1, null));
            Assert.Throws<ArgumentOutOfRangeException>(() => new BigtableVersionRange(null, (long.MaxValue / 1000) + 1));
        }

        [Fact]
        public void Validate_DateTime()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new BigtableVersionRange(BigtableVersion.UnixEpoch.AddMilliseconds(-1), null));
            Assert.Throws<ArgumentOutOfRangeException>(() => new BigtableVersionRange(null, BigtableVersion.UnixEpoch.AddMilliseconds(-1)));
        }

        [Theory]
        [InlineData("BigtableVersionRange: Start=0; End=1", 0L, 1L)]
        [InlineData("BigtableVersionRange: Start=1; End=10", 1L, 10L)]
        [InlineData("BigtableVersionRange: Start=(none); End=10", null, 10L)]
        [InlineData("BigtableVersionRange: Start=12345; End=(none)", 12345L, null)]
        public void Formatting(string expectedText, long? start, long? end)
        {
            var version = new BigtableVersionRange(start, end);
            Assert.Equal(expectedText, version.ToString());
        }

        [Theory]
        [InlineData(0L, 1L)]
        [InlineData(1L, 10L)]
        [InlineData(null, 10L)]
        [InlineData(12345L, null)]
        public void ToTimestampRange(long? start, long? end)
        {
            var range = new BigtableVersionRange(start, end);
            var expected = new TimestampRange
            {
                StartTimestampMicros = start * 1000 ?? 0,
                EndTimestampMicros = end * 1000 ?? 0
            };
            Assert.Equal(expected, range.ToTimestampRange());
        }
    }
}
