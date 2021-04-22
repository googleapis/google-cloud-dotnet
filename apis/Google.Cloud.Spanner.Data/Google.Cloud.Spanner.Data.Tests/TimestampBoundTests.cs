// Copyright 2018 Google LLC
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions.Types;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class TimestampBoundTests
    {
        public static TheoryData<TimestampBound> SampleBounds = new TheoryData<TimestampBound>
        {
            TimestampBound.OfMaxStaleness(TimeSpan.FromHours(1)),
            TimestampBound.OfExactStaleness(TimeSpan.FromHours(1)),
            TimestampBound.OfMinReadTimestamp(new DateTime(1999, 12, 31, 3, 33, 33, DateTimeKind.Utc)),
            TimestampBound.OfReadTimestamp(new DateTime(1999, 12, 31, 3, 33, 33, DateTimeKind.Utc)),
            TimestampBound.Strong,
            TimestampBound.Strong.WithReturnReadTimestamp(true)
        };

        [Theory]
        [MemberData(nameof(SampleBounds))]
        public void Base64RoundTrip(TimestampBound bound)
        {
            Assert.Equal(bound, TimestampBound.FromBase64String(bound.ToBase64String()));
        }

        [Fact]
        public void ToTransactionOptions_Strong()
        {
            AssertProtoConversion(new ReadOnly { Strong = true }, TimestampBound.Strong);
        }

        [Fact]
        public void ToTransactionOptions_OfMaxStaleness()
        {
            var bound = TimestampBound.OfMaxStaleness(TimeSpan.FromSeconds(5));
            AssertProtoConversion(new ReadOnly { MaxStaleness = new Duration { Seconds = 5 } }, bound);
        }

        [Fact]
        public void ToTransactionOptions_OfExactStaleness()
        {
            var bound = TimestampBound.OfExactStaleness(TimeSpan.FromSeconds(5));
            AssertProtoConversion(new ReadOnly { ExactStaleness = new Duration { Seconds = 5 } }, bound);
        }

        [Fact]
        public void ToTransactionOptions_OfMinReadTimestamp()
        {
            var bound = TimestampBound.OfMinReadTimestamp(new DateTime(1970, 1, 1, 0, 0, 10, DateTimeKind.Utc));
            AssertProtoConversion(new ReadOnly { MinReadTimestamp = new Timestamp { Seconds = 10 } }, bound);
        }

        [Fact]
        public void ToTransactionOptions_OfExactTimestamp()
        {
            var bound = TimestampBound.OfReadTimestamp(new DateTime(1970, 1, 1, 0, 0, 10, DateTimeKind.Utc));
            AssertProtoConversion(new ReadOnly { ReadTimestamp = new Timestamp { Seconds = 10 } }, bound);
        }

        [Fact]
        public void ToTransactionOptions_WithReturnReadTimestamp()
        {
            var bound = TimestampBound.OfReadTimestamp(new DateTime(1970, 1, 1, 0, 0, 10, DateTimeKind.Utc)).WithReturnReadTimestamp(true);
            AssertProtoConversion(new ReadOnly { ReadTimestamp = new Timestamp { Seconds = 10 }, ReturnReadTimestamp = true }, bound);
        }

        [Fact]
        public void ToTransactionOptions_WithoutReturnReadTimestamp()
        {
            var bound = TimestampBound.OfReadTimestamp(new DateTime(1970, 1, 1, 0, 0, 10, DateTimeKind.Utc));
            AssertProtoConversion(new ReadOnly { ReadTimestamp = new Timestamp { Seconds = 10 }, ReturnReadTimestamp = false }, bound);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        public void Timestamp_NonUtcIsInvalid(DateTimeKind kind)
        {
            var timestamp = new DateTime(2000, 1, 1, 0, 0, 0, kind);
            Assert.Throws<ArgumentException>(() => TimestampBound.OfMinReadTimestamp(timestamp));
            Assert.Throws<ArgumentException>(() => TimestampBound.OfReadTimestamp(timestamp));
        }

        [Fact]
        public void Timestamp_UtcIsValid()
        {
            var timestamp = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimestampBound.OfMinReadTimestamp(timestamp);
            TimestampBound.OfReadTimestamp(timestamp);
        }

        [Fact]
        public void TimeSpan_NegativeIsInvalid()
        {
            var timeSpan = new TimeSpan(-1);
            Assert.Throws<ArgumentOutOfRangeException>(() => TimestampBound.OfExactStaleness(timeSpan));
            Assert.Throws<ArgumentOutOfRangeException>(() => TimestampBound.OfMaxStaleness(timeSpan));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10000000L)]
        public void TimeSpan_Valid(long ticks)
        {
            var timeSpan = new TimeSpan(ticks);
            TimestampBound.OfExactStaleness(timeSpan);
            TimestampBound.OfMaxStaleness(timeSpan);
        }

        [Fact]
        public void Equality()
        {
            DateTime timestamp1 = new DateTime(2000, 6, 1, 23, 1, 5, DateTimeKind.Utc);
            TimeSpan staleness1 = TimeSpan.FromSeconds(10);

            DateTime timestamp2 = new DateTime(2005, 1, 1, 1, 1, 1, DateTimeKind.Utc);
            TimeSpan staleness2 = TimeSpan.FromSeconds(30);

            var strong = TimestampBound.Strong;
            var minRead = TimestampBound.OfMinReadTimestamp(timestamp1);
            var read = TimestampBound.OfReadTimestamp(timestamp1);
            var exactStaleness = TimestampBound.OfExactStaleness(staleness1);
            var maxStaleness = TimestampBound.OfMaxStaleness(staleness1);
            var returnReadTimestamp = TimestampBound.Strong.WithReturnReadTimestamp(true);

            EqualityTester.AssertEqual(strong,
                new[] { strong },
                new[] { minRead, read, exactStaleness, maxStaleness });

            EqualityTester.AssertEqual(minRead,
                new[] { TimestampBound.OfMinReadTimestamp(timestamp1) },
                new[] { strong, read, exactStaleness, maxStaleness, TimestampBound.OfMinReadTimestamp(timestamp2) });

            EqualityTester.AssertEqual(read,
                new[] { TimestampBound.OfReadTimestamp(timestamp1) },
                new[] { strong, minRead, exactStaleness, maxStaleness, TimestampBound.OfReadTimestamp(timestamp2) });

            EqualityTester.AssertEqual(exactStaleness,
                new[] { TimestampBound.OfExactStaleness(staleness1) },
                new[] { strong, minRead, read, maxStaleness, TimestampBound.OfExactStaleness(staleness2) });

            EqualityTester.AssertEqual(maxStaleness,
                new[] { TimestampBound.OfMaxStaleness(staleness1) },
                new[] { strong, minRead, read, exactStaleness, TimestampBound.OfMaxStaleness(staleness2) });

            EqualityTester.AssertEqual(returnReadTimestamp,
                new[] { returnReadTimestamp },
                new[] { strong, minRead, read, exactStaleness, TimestampBound.OfMaxStaleness(staleness2) });
        }

        private static void AssertProtoConversion(ReadOnly expectedReadOnly, TimestampBound bound)
        {
            var expected = new TransactionOptions
            {
                ReadOnly = expectedReadOnly
            };
            Assert.Equal(expected, bound.ToTransactionOptions());
        }
    }
}
