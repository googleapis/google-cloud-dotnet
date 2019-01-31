// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.ClientTesting;
using System;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class TimestampTest
    {
        [Fact]
        public void Equality()
        {
            var control = new Timestamp(1, 2);
            var equal = new[] { new Timestamp(1, 2) };
            var unequal = new[] { new Timestamp(2, 2), new Timestamp(1, 3) };
            EqualityTester.AssertEqual(control, equal, unequal);
            EqualityTester.AssertEqualityOperators(control, equal, unequal);
        }

        [Fact]
        public void DefaultValueIsUnixEpoch()
        {
            Timestamp timestamp = default;
            Assert.Equal(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), timestamp.ToDateTime());
        }

        [Fact]
        public void Comparisons()
        {
            Timestamp t1 = new Timestamp(1, 2);
            Timestamp t2 = new Timestamp(1, 2); 
            Timestamp t3 = new Timestamp(2, 2);
            Timestamp t4 = new Timestamp(2, 3);

            AssertComparisonAndReverse(t1, t2, 0);
            AssertComparisonAndReverse(t1, t3, -1);
            AssertComparisonAndReverse(t1, t4, -1);
            AssertComparisonAndReverse(t3, t4, -1);

            void AssertComparisonAndReverse(Timestamp x, Timestamp y, int expectedSign)
            {
                AssertComparison(x, y, expectedSign);
                AssertComparison(y, x, -expectedSign);
            }

            void AssertComparison(Timestamp x, Timestamp y, int expectedSign)
            {
                Assert.Equal(expectedSign, Math.Sign(x.CompareTo(y)));
                Assert.Equal(expectedSign, Math.Sign(x.CompareTo((object) y)));

                Assert.True((x == y) == (expectedSign == 0));
                Assert.True((x != y) == (expectedSign != 0));
                Assert.True((x <= y) == (expectedSign <= 0));
                Assert.True((x < y) == (expectedSign < 0));
                Assert.True((x >= y) == (expectedSign >= 0));
                Assert.True((x > y) == (expectedSign > 0));
            }
        }

        [Fact]
        public void FromProto()
        {
            var direct = new Timestamp(1, 100);
            var fromProto = Timestamp.FromProto(CreateProtoTimestamp(1, 100));
            Assert.Equal(direct, fromProto);
        }

        [Fact]
        public void ToProto()
        {
            var timestamp = new Timestamp(1, 100);
            var proto = CreateProtoTimestamp(1, 100);
            Assert.Equal(proto, timestamp.ToProto());
        }

        [Fact]
        public void ToDateTimeAndDateTimeOffset()
        {
            var timestamp = new Timestamp(1, 100);
            var expected = new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc).AddTicks(1);
            Assert.Equal(expected, timestamp.ToDateTime());
            Assert.Equal((DateTimeOffset) expected, timestamp.ToDateTimeOffset());
        }

        [Fact]
        public void FromDateTime()
        {
            // 1 tick = 100ns
            var timestamp = Timestamp.FromDateTime(new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc).AddTicks(1));
            var expected = new Timestamp(1, 100);
            Assert.Equal(expected, timestamp);
        }

        [Fact]
        public void FromDateTimeOffset()
        {
            var timestamp = Timestamp.FromDateTimeOffset(new DateTimeOffset(1970, 1, 1, 0, 0, 1, TimeSpan.Zero).AddTicks(1));
            var expected = new Timestamp(1, 100);
            Assert.Equal(expected, timestamp);
        }

        [Theory]
        [InlineData(Timestamp.MinSeconds - 1, 0)]
        [InlineData(Timestamp.MaxSeconds + 1, 0)]
        [InlineData(0, -1)]
        [InlineData(0, 1_000_000_000)]
        public void Construction_Invalid(long seconds, int nanoseconds)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Timestamp(seconds, nanoseconds));
        }

        [Theory]
        [InlineData(Timestamp.MinSeconds, 0, "Timestamp: 0001-01-01T00:00:00Z")]
        [InlineData(Timestamp.MaxSeconds, 999_999_999, "Timestamp: 9999-12-31T23:59:59.999999999Z")]
        [InlineData(0, 0, "Timestamp: 1970-01-01T00:00:00Z")]
        // We truncate trailing zeroes at seconds, milliseconds, and microseconds
        [InlineData(0, 100_000_000, "Timestamp: 1970-01-01T00:00:00.100Z")]
        [InlineData(0, 120_000_000, "Timestamp: 1970-01-01T00:00:00.120Z")]
        [InlineData(0, 123_000_000, "Timestamp: 1970-01-01T00:00:00.123Z")]
        [InlineData(0, 123_400_000, "Timestamp: 1970-01-01T00:00:00.123400Z")]
        [InlineData(0, 123_450_000, "Timestamp: 1970-01-01T00:00:00.123450Z")]
        [InlineData(0, 123_456_000, "Timestamp: 1970-01-01T00:00:00.123456Z")]
        [InlineData(0, 123_456_700, "Timestamp: 1970-01-01T00:00:00.123456700Z")]
        [InlineData(0, 123_456_780, "Timestamp: 1970-01-01T00:00:00.123456780Z")]
        [InlineData(0, 123_456_789, "Timestamp: 1970-01-01T00:00:00.123456789Z")]
        [InlineData(-1, 0, "Timestamp: 1969-12-31T23:59:59Z")]
        public void Formatting(long seconds, int nanoseconds, string expected)
        {
            var timestamp = new Timestamp(seconds, nanoseconds);
            Assert.Equal(expected, timestamp.ToString());
        }

        [Fact]
        public void FromProtoOrNull_Null()
        {
            Assert.Null(Timestamp.FromProtoOrNull(null));
        }

        [Fact]
        public void FromProtoOrNull_NonNull()
        {
            var proto = CreateProtoTimestamp(1, 100);
            var timestamp = Timestamp.FromProtoOrNull(proto).Value;
            var expected = new Timestamp(1, 100);
            Assert.Equal(expected, timestamp);
        }

        [Fact]
        public void GetCurrentTimestamp()
        {
            var now = DateTime.UtcNow;
            // Assume the system clock doesn't change by more than 5 seconds in the course of the test.
            var timestamp = Timestamp.GetCurrentTimestamp();
            var absDifferenceSeconds = Math.Abs((timestamp.ToDateTime() - now).TotalSeconds);
            Assert.True(absDifferenceSeconds < 5);
        }
    }
}
