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
    public class RowRangeTest
    {
        [Fact]
        public void Closed_Valid()
        {
            var range = RowRange.Closed("a", "z");
            Assert.Equal("a", range.StartKeyClosed.ToStringUtf8());
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.Equal("z", range.EndKeyClosed.ToStringUtf8());
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.Closed(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndKeyClosed.ToByteArray());
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.Closed(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartKeyClosed.ToByteArray());
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.Closed(null, null);
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);
        }

        [Fact]
        public void ClosedOpen_Valid()
        {
            var range = RowRange.ClosedOpen("a", "z");
            Assert.Equal("a", range.StartKeyClosed.ToStringUtf8());
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.Equal("z", range.EndKeyOpen.ToStringUtf8());

            range = RowRange.ClosedOpen(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndKeyOpen.ToByteArray());

            range = RowRange.ClosedOpen(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartKeyClosed.ToByteArray());
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.ClosedOpen(null, null);
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);
        }

        [Fact]
        public void Open_Valid()
        {
            var range = RowRange.Open("a", "z");
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.Equal("a", range.StartKeyOpen.ToStringUtf8());
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.Equal("z", range.EndKeyOpen.ToStringUtf8());

            range = RowRange.Open(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndKeyOpen.ToByteArray());

            range = RowRange.Open(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartKeyOpen.ToByteArray());
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.Open(null, null);
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);
        }

        [Fact]
        public void OpenClosed_Valid()
        {
            var range = RowRange.OpenClosed("a", "z");
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.Equal("a", range.StartKeyOpen.ToStringUtf8());
            Assert.Equal("z", range.EndKeyClosed.ToStringUtf8());
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.OpenClosed(null, new BigtableByteString(0x12, 0xFE));
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndKeyClosed.ToByteArray());
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.OpenClosed(ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartKeyOpen.ToByteArray());
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);

            range = RowRange.OpenClosed(null, null);
            Assert.True(range.StartKeyClosed.IsEmpty);
            Assert.True(range.StartKeyOpen.IsEmpty);
            Assert.True(range.EndKeyClosed.IsEmpty);
            Assert.True(range.EndKeyOpen.IsEmpty);
        }
    }
}
