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
    public class ColumnRangeTest
    {
        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void Closed_Valid(string familyName)
        {
            var range = ColumnRange.Closed(familyName, "a", "z");
            Assert.Equal(familyName, range.FamilyName);
            Assert.Equal("a", range.StartQualifierClosed.ToStringUtf8());
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.Equal("z", range.EndQualifierClosed.ToStringUtf8());
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.Closed(familyName, null, new BigtableByteString(0x12, 0xFE));
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndQualifierClosed.ToByteArray());
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.Closed(familyName, ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartQualifierClosed.ToByteArray());
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.Closed(familyName, null, null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void Closed_Invalid_FamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(() => ColumnRange.Closed(familyName, "a", "z"));
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void ClosedOpen_Valid(string familyName)
        {
            var range = ColumnRange.ClosedOpen(familyName, "a", "z");
            Assert.Equal(familyName, range.FamilyName);
            Assert.Equal("a", range.StartQualifierClosed.ToStringUtf8());
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.Equal("z", range.EndQualifierOpen.ToStringUtf8());

            range = ColumnRange.ClosedOpen(familyName, null, new BigtableByteString(0x12, 0xFE));
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndQualifierOpen.ToByteArray());

            range = ColumnRange.ClosedOpen(familyName, ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartQualifierClosed.ToByteArray());
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.ClosedOpen(familyName, null, null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void ClosedOpen_Invalid_FamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(() => ColumnRange.ClosedOpen(familyName, "a", "z"));
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void Open_Valid(string familyName)
        {
            var range = ColumnRange.Open(familyName, "a", "z");
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.Equal("a", range.StartQualifierOpen.ToStringUtf8());
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.Equal("z", range.EndQualifierOpen.ToStringUtf8());

            range = ColumnRange.Open(familyName, null, new BigtableByteString(0x12, 0xFE));
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndQualifierOpen.ToByteArray());

            range = ColumnRange.Open(familyName, ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartQualifierOpen.ToByteArray());
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.Open(familyName, null, null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void Open_Invalid_FamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(() => ColumnRange.Open(familyName, "a", "z"));
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void OpenClosed_Valid(string familyName)
        {
            var range = ColumnRange.OpenClosed(familyName, "a", "z");
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.Equal("a", range.StartQualifierOpen.ToStringUtf8());
            Assert.Equal("z", range.EndQualifierClosed.ToStringUtf8());
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.OpenClosed(familyName, null, new BigtableByteString(0x12, 0xFE));
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.Equal(new byte[] { 0x12, 0xFE }, range.EndQualifierClosed.ToByteArray());
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.OpenClosed(familyName, ByteString.CopyFrom(0x00, 0x01, 0xFF), null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.Equal(new byte[] { 0x00, 0x01, 0xFF }, range.StartQualifierOpen.ToByteArray());
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);

            range = ColumnRange.OpenClosed(familyName, null, null);
            Assert.Equal(familyName, range.FamilyName);
            Assert.True(range.StartQualifierClosed.IsEmpty);
            Assert.True(range.StartQualifierOpen.IsEmpty);
            Assert.True(range.EndQualifierClosed.IsEmpty);
            Assert.True(range.EndQualifierOpen.IsEmpty);
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void OpenClosed_Invalid_FamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(() => ColumnRange.OpenClosed(familyName, "a", "z"));
        }
    }
}
