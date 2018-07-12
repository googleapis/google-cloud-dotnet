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
using Google.Protobuf;
using System.Linq;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class BlobTest
    {
        [Fact]
        public void Equality()
        {
            var control = Blob.CopyFrom(new byte[] { 1, 2, 3, 4, 5 });
            var equal = new[] { Blob.CopyFrom(new byte[] { 1, 2, 3, 4, 5 }) };
            var unequal = new[] { Blob.CopyFrom(new byte[] { 1, 2, 3, 4, 5, 6 }) };
            EqualityTester.AssertEqual(control, equal, unequal);
            EqualityTester.AssertEqualityOperators(control, equal, unequal);
        }

        [Fact]
        public void DefaultValueIsEmpty()
        {
            Blob blob = default;
            Assert.Equal(ByteString.Empty, blob.ByteString);
            Assert.Equal(0, blob.Length);
        }

        [Fact]
        public void Properties()
        {
            Blob blob = Blob.CopyFrom(new byte[] { 1, 2, 3, 4, 5 });
            Assert.Equal(ByteString.CopyFrom(1, 2, 3, 4, 5), blob.ByteString);
            Assert.Equal(5, blob.Length);
            Assert.Equal(2, blob[1]);
        }

        [Fact]
        public void FromByteString()
        {
            var byteString = ByteString.CopyFrom(1, 2, 3, 4, 5);
            var blob = Blob.FromByteString(byteString);
            Assert.Same(byteString, blob.ByteString);
        }

        [Theory]
        [InlineData("Blob: Length=0; Hex=")]
        [InlineData("Blob: Length=6; Hex=00 01 02 03 0A 10", 0, 1, 2, 3, 10, 16)]
        [InlineData("Blob: Length=32; Hex=00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F",
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31)]
        [InlineData("Blob: Length=33; Hex (first 32 bytes only)=00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F",
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32)]
        public void Formatting(string expectedText, params int[] data)
        {
            // xUnit isn't happy if the parameter type is actually byte[].
            Blob blob = Blob.CopyFrom(data.Select(x => (byte) x).ToArray());
            Assert.Equal(expectedText, blob.ToString());
        }
    }
}
