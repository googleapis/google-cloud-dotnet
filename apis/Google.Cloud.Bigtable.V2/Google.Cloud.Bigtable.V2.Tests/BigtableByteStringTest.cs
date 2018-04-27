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

using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using System.Linq;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableByteStringTest
    {
        [Fact]
        public void EmptyString()
        {
            BigtableByteString control = default;
            var equal = new[]
            {
                new BigtableByteString((string)null),
                new BigtableByteString((byte[])null),
                new BigtableByteString((ByteString)null),
                new BigtableByteString(""),
                new BigtableByteString(new byte[0]),
                new BigtableByteString(ByteString.Empty)
            };
            var unequal = new[]
            {
                new BigtableByteString(0),
                new BigtableByteString(0L),
                new BigtableByteString("a"),
                new BigtableByteString(ByteString.CopyFrom(1, 2, 3))
            };
            ComparisonTester.AssertEqual(control, equal, unequal);
            ComparisonTester.AssertEqualityOperators(control, equal, unequal);
        }

        [Fact]
        public void Comparisons()
        {
            var control = new BigtableByteString(128);
            var less = new[]
            {
                new BigtableByteString(),
                new BigtableByteString(0),
                new BigtableByteString(127),
                new BigtableByteString(127, 1)
            };
            var equal = new[]
            {
                new BigtableByteString(128)
            };
            var greater = new[]
            {
                new BigtableByteString(128, 1),
                new BigtableByteString(129)
            };
            ComparisonTester.AssertCompare(control, less, equal, greater);
            ComparisonTester.AssertCompareOperators(control, less, equal, greater);
        }

        [Fact]
        public void Properties()
        {
            var byteString = new BigtableByteString(1, 2, 3, 4, 5);
            Assert.Equal(ByteString.CopyFrom(1, 2, 3, 4, 5), byteString.Value);
            Assert.Equal(5, byteString.Length);
            Assert.Equal(2, byteString[1]);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new byte[0])]
        [InlineData(new byte[] { 1, 2, 3 }, 1, 2, 3)]
        public void ConversionsBytes(byte[] value, params int[] data)
        {
            BigtableByteString byteString = value;

            var expected = new BigtableByteString(data.Select(x => (byte)x).ToArray());
            Assert.Equal(expected, byteString);

            var roundTrip = (byte[])byteString;
            Assert.Equal(value ?? new byte[0], roundTrip);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new byte[0])]
        [InlineData(new byte[] { 1, 2, 3 }, 1, 2, 3)]
        public void ConversionsByteString(byte[] bytes, params int[] data)
        {
            var value = bytes == null ? null : ByteString.CopyFrom(bytes);
            BigtableByteString byteString = value;

            var expected = new BigtableByteString(data.Select(x => (byte)x).ToArray());
            Assert.Equal(expected, byteString);

            ByteString roundTrip = (ByteString)byteString;
            Assert.Equal(value ?? ByteString.Empty, roundTrip);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("abc", 97, 98, 99)]
        [InlineData("\t\0\n", 9, 0, 10)]
        public void ConversionsString(string value, params int[] data)
        {
            BigtableByteString byteString = value;

            var expected = new BigtableByteString(data.Select(x => (byte)x).ToArray());
            Assert.Equal(expected, byteString);

            var roundTrip = (string)byteString;
            Assert.Equal(value ?? "", roundTrip);
        }

        [Theory]
        [InlineData(0,
            0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(1,
            0, 0, 0, 0, 0, 0, 0, 1)]
        [InlineData(0x01_23_45_67_89_AB_CD_EF,
            0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF)]
        public void ConversionsLong(long value, params int[] data)
        {
            BigtableByteString byteString = value;

            var expected = new BigtableByteString(data.Select(x => (byte)x).ToArray());
            Assert.Equal(expected, byteString);

            var roundTrip = (long)byteString;
            Assert.Equal(value, roundTrip);
        }

        [Theory]
        [InlineData("BigtableByteString: Length=0; Hex=")]
        [InlineData("BigtableByteString: Length=6; Hex=00 01 02 03 0A 10", 0, 1, 2, 3, 10, 16)]
        [InlineData("BigtableByteString: Length=32; Hex=00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F",
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31)]
        [InlineData("BigtableByteString: Length=33; Hex (first 32 bytes only)=00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F",
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32)]
        [InlineData("BigtableByteString: Length=8; Hex=42 69 67 74 61 62 6C 65", 66, 105, 103, 116, 97, 98, 108, 101)]
        public void Formatting(string expectedText, params int[] data)
        {
            // xUnit isn't happy if the parameter type is actually byte[].
            var byteString = new BigtableByteString(data.Select(x => (byte)x).ToArray());
            Assert.Equal(expectedText, byteString.ToString());
        }
    }
}
