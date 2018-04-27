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
using System;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class ValueRangeTest
    {
        [Fact]
        public void Closed_Valid()
        {
            var range = ValueRange.Closed("a", "z");
            Assert.Equal("a", range.StartValueClosed.ToStringUtf8());
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.Equal("z", range.EndValueClosed.ToStringUtf8());
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.Closed(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndValueClosed.ToByteArray());
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.Closed(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartValueClosed.ToByteArray());
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.Closed(null, null);
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);
        }

        [Fact]
        public void ClosedOpen_Valid()
        {
            var range = ValueRange.ClosedOpen("a", "z");
            Assert.Equal("a", range.StartValueClosed.ToStringUtf8());
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.Equal("z", range.EndValueOpen.ToStringUtf8());

            range = ValueRange.ClosedOpen(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndValueOpen.ToByteArray());

            range = ValueRange.ClosedOpen(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartValueClosed.ToByteArray());
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.ClosedOpen(null, null);
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);
        }

        [Fact]
        public void Open_Valid()
        {
            var range = ValueRange.Open("a", "z");
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.Equal("a", range.StartValueOpen.ToStringUtf8());
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.Equal("z", range.EndValueOpen.ToStringUtf8());

            range = ValueRange.Open(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndValueOpen.ToByteArray());

            range = ValueRange.Open(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartValueOpen.ToByteArray());
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.Open(null, null);
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);
        }

        [Fact]
        public void OpenClosed_Valid()
        {
            var range = ValueRange.OpenClosed("a", "z");
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.Equal("a", range.StartValueOpen.ToStringUtf8());
            Assert.Equal("z", range.EndValueClosed.ToStringUtf8());
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.OpenClosed(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndValueClosed.ToByteArray());
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.OpenClosed(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartValueOpen.ToByteArray());
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);

            range = ValueRange.OpenClosed(null, null);
            Assert.True(range.StartValueClosed.IsEmpty);
            Assert.True(range.StartValueOpen.IsEmpty);
            Assert.True(range.EndValueClosed.IsEmpty);
            Assert.True(range.EndValueOpen.IsEmpty);
        }
    }
}
