// Copyright 2016 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class Crc32cTest
    {
        private static readonly byte[] ScsiReadCommand =
        {
            0x01, 0xc0, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x14, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x04, 0x00,
            0x00, 0x00, 0x00, 0x14,
            0x00, 0x00, 0x00, 0x18,
            0x28, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        };

        // Samples as per https://github.com/google/guava/blob/master/guava-tests/test/com/google/common/hash/Crc32cHashFunctionTest.java
        public static IEnumerable<object[]> SampleData => new object[][]
        {
            new object[] { Enumerable.Repeat((byte) 0, 32), new byte[] { 0x8a, 0x91, 0x36, 0xaa } },
            new object[] { Enumerable.Repeat((byte) 0xff, 32), new byte[] { 0x62, 0xa8, 0xab, 0x43 } },
            new object[] { Enumerable.Range(0, 32).Select(i => (byte) i), new byte[] { 0x46, 0xdd, 0x79, 0x4e } },
            new object[] { Enumerable.Range(0, 32).Select(i => (byte) (31 - i)), new byte[] { 0x11, 0x3f, 0xdb, 0x5c } },
            new object[] { ScsiReadCommand, new byte[] { 0xd9, 0x96, 0x3a, 0x56 } },
            new object[] { Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog"), new byte[] { 0x22, 0x62, 0x04, 0x04 } },
            new object[] { Encoding.UTF8.GetBytes("123456789"), new byte[] { 0xe3, 0x06, 0x92, 0x83 } },
            new object[] { Encoding.UTF8.GetBytes("1234567890"), new byte[] { 0xf3, 0xdb, 0xd4, 0xfe } },
            new object[] { Encoding.UTF8.GetBytes("23456789"), new byte[] { 0xbf, 0xe9, 0x2a, 0x83 } }
        };

        [Theory]
        [MemberData(nameof(SampleData))]
        public void Hash(IEnumerable<byte> source, byte[] expectedHash)
        {
            var hasher = new Crc32c();
            hasher.UpdateHash(source.ToArray(), 0, source.Count());
            byte[] actualHash = hasher.GetHash();
            Assert.Equal(expectedHash, actualHash);
        }
    }
}
