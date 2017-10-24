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
using System.Globalization;
using System.Text;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class MutationsTest
    {
        public static IEnumerable<object[]> ValidFamilyNames { get; } = new List<object[]>
        {
            new [] { "a" },
            new [] { "A" },
            new [] { "-_.aZ09" }
        };

        public static IEnumerable<object[]> InvalidFamilyNames { get; } = new List<object[]>
        {
            new [] { default(string) },
            new [] { "" },
            new [] { "abc*" },
            new [] { "abc " },
            new [] { "a=b" }
        };

        [Theory]
        [MemberData(nameof(ValidFamilyNames))]
        public void DeleteFromColumn(string familyName)
        {
            var mutation =
                Mutations.DeleteFromColumn(familyName, "cq1", new BigtableVersionRange(1, 2));
            Assert.NotNull(mutation.DeleteFromColumn);
            Assert.Equal(familyName, mutation.DeleteFromColumn.FamilyName);
            Assert.Equal("cq1", mutation.DeleteFromColumn.ColumnQualifier.ToStringUtf8());
            Assert.Equal(1000, mutation.DeleteFromColumn.TimeRange.StartTimestampMicros);
            Assert.Equal(2000, mutation.DeleteFromColumn.TimeRange.EndTimestampMicros);
        }

        [Theory]
        [MemberData(nameof(InvalidFamilyNames))]
        public void DeleteFromColumnInvalidFamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(
                () => Mutations.DeleteFromColumn(familyName, default(string), null));
        }

        [Theory]
        [MemberData(nameof(ValidFamilyNames))]
        public void DeleteFromFamily(string familyName)
        {
            var mutation = Mutations.DeleteFromFamily(familyName);
            Assert.NotNull(mutation.DeleteFromFamily);
            Assert.Equal(familyName, mutation.DeleteFromFamily.FamilyName);
        }

        [Theory]
        [MemberData(nameof(InvalidFamilyNames))]
        public void DeleteFromFamilyInvalidFamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(() => Mutations.DeleteFromFamily(familyName));
        }

        [Fact]
        public void DeleteFromRow()
        {
            var mutation = Mutations.DeleteFromRow();
            Assert.NotNull(mutation.DeleteFromRow);
        }

        [Theory]
        [MemberData(nameof(ValidFamilyNames))]
        public void SetCell_Bytes(string familyName)
        {
            var mutation =
                Mutations.SetCell(familyName, "cq1", new BigtableByteString(1, 2, 3, 4, 5), new BigtableVersion(3));
            Assert.NotNull(mutation.SetCell);
            Assert.Equal(familyName, mutation.SetCell.FamilyName);
            Assert.Equal("cq1", mutation.SetCell.ColumnQualifier.ToStringUtf8());
            var bytes = mutation.SetCell.Value.ToByteArray();
            Assert.Equal(new byte[] { 1, 2, 3, 4, 5 }, bytes);
            Assert.Equal(3000, mutation.SetCell.TimestampMicros);
        }

        [Theory]
        [MemberData(nameof(ValidFamilyNames))]
        public void SetCell_Long(string familyName)
        {
            var mutation =
                Mutations.SetCell(familyName, "cq1", 12345, new BigtableVersion(3));
            Assert.NotNull(mutation.SetCell);
            Assert.Equal(familyName, mutation.SetCell.FamilyName);
            Assert.Equal("cq1", mutation.SetCell.ColumnQualifier.ToStringUtf8());
            var bytes = mutation.SetCell.Value.ToByteArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            Assert.Equal(12345, BitConverter.ToInt64(bytes, 0));
            Assert.Equal(3000, mutation.SetCell.TimestampMicros);
        }

        [Theory]
        [MemberData(nameof(ValidFamilyNames))]
        public void SetCell_String(string familyName)
        {
            var mutation =
                Mutations.SetCell(familyName, "cq1", "value", new BigtableVersion(3));
            Assert.NotNull(mutation.SetCell);
            Assert.Equal(familyName, mutation.SetCell.FamilyName);
            Assert.Equal("cq1", mutation.SetCell.ColumnQualifier.ToStringUtf8());
            Assert.Equal("value", mutation.SetCell.Value.ToStringUtf8());
            Assert.Equal(3000, mutation.SetCell.TimestampMicros);
        }

        [Theory]
        [MemberData(nameof(InvalidFamilyNames))]
        public void SetCellInvalidFamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(
                () => Mutations.SetCell(familyName, default(string), default(string), null));
        }
    }
}
