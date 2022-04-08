// Copyright 2021 Google Inc. All Rights Reserved.
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

using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class KeysTests
    {
        [Fact]
        public void CreateKeyFromParameterCollection()
        {
            var key = new Key(
                new SpannerParameterCollection
                {
                    { "", SpannerDbType.Bool, true },
                    { "", SpannerDbType.Bytes, new byte[] {1, 2, 3} },
                    { "", SpannerDbType.Date, new SpannerDate(2021, 9, 10) },
                    { "", SpannerDbType.Float64, 3.14 },
                    { "", SpannerDbType.Int64, 1 },
                    { "", SpannerDbType.Json, "{\"key\": \"value\"}" },
                    { "", SpannerDbType.Numeric, SpannerNumeric.Parse("10.1") },
                    { "", SpannerDbType.PgNumeric, PgNumeric.Parse("20.1") },
                    { "", SpannerDbType.String, "test" },
                    { "", SpannerDbType.Timestamp, new DateTime(2021, 9, 10, 9, 37, 10, DateTimeKind.Utc) }
                });
            var index = 0;
            Assert.True(key.KeyParts.Values[index++].BoolValue);
            Assert.Equal(Convert.ToBase64String(new byte[] {1,2,3}), key.KeyParts.Values[index++].StringValue);
            Assert.Equal("2021-09-10", key.KeyParts.Values[index++].StringValue);
            Assert.Equal(3.14, key.KeyParts.Values[index++].NumberValue);
            Assert.Equal("1", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("{\"key\": \"value\"}", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("10.1", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("20.1", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("test", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("2021-09-10T09:37:10Z", key.KeyParts.Values[index++].StringValue);
        }

        [Fact]
        public void CreateKeyFromEmptyParameters()
        {
            var key = new Key(new SpannerParameterCollection());
            Assert.Empty(key.KeyParts.Values);
        }

        [Fact]
        public void CreateKeyFromValues()
        {
            var key = new Key(
                true,
                new byte[] { 1, 2, 3 },
                new SpannerDate(2022, 4, 7),
                3.14,
                1L,
                // JSON cannot be created directly from a Clr type.
                SpannerNumeric.Parse("10.1"),
                PgNumeric.Parse("20.1"),
                "test",
                new DateTime(2021, 9, 10, 9, 37, 10, DateTimeKind.Utc)
            );
            var index = 0;
            Assert.True(key.KeyParts.Values[index++].BoolValue);
            Assert.Equal(Convert.ToBase64String(new byte[] {1,2,3}), key.KeyParts.Values[index++].StringValue);
            Assert.Equal("2022-04-07", key.KeyParts.Values[index++].StringValue);
            Assert.Equal(3.14, key.KeyParts.Values[index++].NumberValue);
            Assert.Equal("1", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("10.1", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("20.1", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("test", key.KeyParts.Values[index++].StringValue);
            Assert.Equal("2021-09-10T09:37:10Z", key.KeyParts.Values[index++].StringValue);
        }

        [Fact]
        public void CreateEmptyKey()
        {
            var key = new Key();
            Assert.Empty(key.KeyParts.Values);
        }

        [Fact]
        public void CreateKeyWithNullParts()
        {
            var key = new Key(null, 1L, null);
            Assert.Collection(key.KeyParts.Values,
                v => Assert.Equal(NullValue.NullValue, v.NullValue),
                v => Assert.Equal("1", v.StringValue),
                v => Assert.Equal(NullValue.NullValue, v.NullValue));
        }

        [Fact]
        public void CreateKeyRangeClosedClosed()
        {
            var closedClosed = KeyRange.ClosedClosed(new Key("begin"), new Key("end"));
            Assert.True(closedClosed.BeginInclusive);
            Assert.True(closedClosed.EndInclusive);
            Assert.Equal(new Key("begin"), closedClosed.BeginAt);
            Assert.Equal(new Key("end"), closedClosed.End);
            Assert.Equal(
                new V1.KeyRange
                {
                    StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "begin" } } } },
                    EndClosed = new ListValue { Values = { new[] { new Value { StringValue = "end" } } } }
                }, closedClosed.Protobuf);
        }

        [Fact]
        public void CreateKeyRangeClosedOpen()
        {
            var closedOpen = KeyRange.ClosedOpen(new Key(1L), new Key(100L));
            Assert.True(closedOpen.BeginInclusive);
            Assert.False(closedOpen.EndInclusive);
            Assert.Equal(new Key(1L), closedOpen.BeginAt);
            Assert.Equal(new Key(100L), closedOpen.End);
            Assert.Equal(
                new V1.KeyRange
                {
                    StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "1" } } } },
                    EndOpen = new ListValue { Values = { new[] { new Value { StringValue = "100" } } } }
                }, closedOpen.Protobuf);
        }

        [Fact]
        public void CreateKeyRangeOpenClosed()
        {
            var openClosed = KeyRange.OpenClosed(new Key(1L, 3.14), new Key(100L, 100.0));
            Assert.False(openClosed.BeginInclusive);
            Assert.True(openClosed.EndInclusive);
            Assert.Equal(new Key(1L, 3.14), openClosed.BeginAt);
            Assert.Equal(new Key(100L, 100.0), openClosed.End);
            Assert.Equal(
                new V1.KeyRange
                {
                    StartOpen = new ListValue
                        { Values = { new[] { new Value { StringValue = "1" }, new Value { NumberValue = 3.14 } } } },
                    EndClosed = new ListValue
                        { Values = { new[] { new Value { StringValue = "100" }, new Value { NumberValue = 100.0 } } } }
                }, openClosed.Protobuf);
        }

        [Fact]
        public void CreateKeyRangeOpenOpen()
        {
            var openOpen = KeyRange.OpenOpen(new Key(SpannerNumeric.Parse("0.1")), new Key(SpannerNumeric.Parse("100.1")));
            Assert.False(openOpen.BeginInclusive);
            Assert.False(openOpen.EndInclusive);
            Assert.Equal(new Key(SpannerNumeric.Parse("0.1")), openOpen.BeginAt);
            Assert.Equal(new Key(SpannerNumeric.Parse("100.1")), openOpen.End);
            Assert.Equal(new V1.KeyRange
            {
                StartOpen = new ListValue{ Values = { new [] { new Value { StringValue = "0.1" } } } },
                EndOpen = new ListValue{ Values = { new [] { new Value { StringValue = "100.1" } } } }
            }, openOpen.Protobuf);
        }

        [Fact]
        public void CreateEmptyKeyRange()
        {
            var empty = KeyRange.ClosedOpen(new Key(), new Key());
            Assert.Empty(empty.BeginAt.KeyParts.Values);
            Assert.Empty(empty.End.KeyParts.Values);
        }

        [Fact]
        public void CreateKeySetAll()
        {
            var all = KeySet.All;
            Assert.True(all.AllKeys);
        }

        [Fact]
        public void CreateKeySetFromKeys()
        {
            var keys = KeySet.FromKeys(new Key("k1"), new Key("k2"), new Key("k3"));
            Assert.Collection(
                keys.Keys,
                k => Assert.Equal("k1", k.KeyParts.Values[0].StringValue),
                k => Assert.Equal("k2", k.KeyParts.Values[0].StringValue),
                k => Assert.Equal("k3", k.KeyParts.Values[0].StringValue)
            );
        }

        [Fact]
        public void CreateKeySetFromRanges()
        {
            var ranges = KeySet.FromRanges(
                KeyRange.ClosedOpen(new Key("begin"), new Key("end")), KeyRange.ClosedClosed(new Key(1L), new Key(2L)));
            Assert.Collection(ranges.Ranges,
                range => Assert.Equal(KeyRange.ClosedOpen(new Key("begin"), new Key("end")), range),
                range => Assert.Equal(KeyRange.ClosedClosed(new Key(1L), new Key(2L)), range)
            );
        }

        [Fact]
        public void ToStringKeySetAll()
        {
            Assert.Equal("KeySet {AllKeys = true}", KeySet.All.ToString());
        }

        [Fact]
        public void ToStringKeySetFromKeys()
        {
            var keys = KeySet.FromKeys(new Key("k1.1", "k1.2"), new Key("k2.1", "k2.2"), new Key("k3.1", "k3.2"));
            Assert.Equal("KeySet {Keys = [[ \"k1.1\", \"k1.2\" ], [ \"k2.1\", \"k2.2\" ], [ \"k3.1\", \"k3.2\" ]]}", keys.ToString());
        }

        [Fact]
        public void ToStringKeySetFromRanges()
        {
            var ranges = KeySet.FromRanges(
                KeyRange.ClosedOpen(new Key("beginKeyPart1", "beginKeyPart2"), new Key("endKeyPart1", "endKeyPart2")), KeyRange.ClosedClosed(new Key(1L), new Key(2L)));
            Assert.Equal("KeySet {Ranges = [[[ \"beginKeyPart1\", \"beginKeyPart2\" ], [ \"endKeyPart1\", \"endKeyPart2\" ]), [[ \"1\" ], [ \"2\" ]]]}", ranges.ToString());
        }
    }
}
