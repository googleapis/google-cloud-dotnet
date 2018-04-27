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
    public class MutationsTest
    {
        [Fact]
        public void CreateEntry()
        {
            var entry = Mutations.CreateEntry("abc", Mutations.DeleteFromRow());
            Assert.Equal("abc", entry.RowKey.ToStringUtf8());
            Assert.Equal(1, entry.Mutations.Count);
            Assert.NotNull(entry.Mutations[0].DeleteFromRow);
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidRowKeys), MemberType = typeof(TestData))]
        public void CreateEntryInvalidRowKey(BigtableByteString rowKey)
        {
            Assert.Throws<ArgumentException>(() => Mutations.CreateEntry(rowKey, Mutations.DeleteFromRow()));
        }

        [Fact]
        public void CreateEntryInvalidMutations()
        {
            Assert.Throws<ArgumentNullException>(() => Mutations.CreateEntry("abc", null));
            Assert.Throws<ArgumentException>(() => Mutations.CreateEntry("abc", new Mutation[0]));
            Assert.Throws<ArgumentException>(() => Mutations.CreateEntry("abc", new Mutation[] { null }));
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void DeleteFromColumn(string familyName)
        {
            var mutation =
                Mutations.DeleteFromColumn(familyName, "cq1", new BigtableVersionRange(1, 2));
            Assert.NotNull(mutation.DeleteFromColumn);
            Assert.Equal(familyName, mutation.DeleteFromColumn.FamilyName);
            Assert.Equal("cq1", mutation.DeleteFromColumn.ColumnQualifier.ToStringUtf8());
            Assert.Equal(1000, mutation.DeleteFromColumn.TimeRange.StartTimestampMicros);
            Assert.Equal(2000, mutation.DeleteFromColumn.TimeRange.EndTimestampMicros);
            Assert.True(mutation.IsIdempotent());
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void DeleteFromColumnInvalidFamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(
                () => Mutations.DeleteFromColumn(familyName, default(string), null));
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void DeleteFromFamily(string familyName)
        {
            var mutation = Mutations.DeleteFromFamily(familyName);
            Assert.NotNull(mutation.DeleteFromFamily);
            Assert.Equal(familyName, mutation.DeleteFromFamily.FamilyName);
            Assert.True(mutation.IsIdempotent());
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void DeleteFromFamilyInvalidFamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(() => Mutations.DeleteFromFamily(familyName));
        }

        [Fact]
        public void DeleteFromRow()
        {
            var mutation = Mutations.DeleteFromRow();
            Assert.NotNull(mutation.DeleteFromRow);
            Assert.True(mutation.IsIdempotent());
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
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
            Assert.True(mutation.IsIdempotent());
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
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
            Assert.True(mutation.IsIdempotent());
        }

        [Theory]
        [MemberData(nameof(TestData.ValidFamilyNames), MemberType = typeof(TestData))]
        public void SetCell_String(string familyName)
        {
            var mutation =
                Mutations.SetCell(familyName, "cq1", "value", new BigtableVersion(3));
            Assert.NotNull(mutation.SetCell);
            Assert.Equal(familyName, mutation.SetCell.FamilyName);
            Assert.Equal("cq1", mutation.SetCell.ColumnQualifier.ToStringUtf8());
            Assert.Equal("value", mutation.SetCell.Value.ToStringUtf8());
            Assert.Equal(3000, mutation.SetCell.TimestampMicros);
            Assert.True(mutation.IsIdempotent());
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidFamilyNames), MemberType = typeof(TestData))]
        public void SetCellInvalidFamilyName(string familyName)
        {
            Assert.Throws<ArgumentException>(
                () => Mutations.SetCell(familyName, default(string), default(string), null));
        }

        [Fact]
        public void SetCell_NonIdempotent()
        {
            var mutation = Mutations.SetCell("abc", "cq1", "value", new BigtableVersion(-1));
            Assert.True(mutation.IsIdempotent());

            mutation.SetCell.TimestampMicros = -1;
            Assert.False(mutation.IsIdempotent());
        }

        [Fact]
        public void IdempotentCheckOnMutateRowRequest()
        {
            var setCell =
                Mutations.SetCell("abc", "cq1", "value", new BigtableVersion(-1));
            var deleteFromColumn =
                Mutations.DeleteFromColumn("abc", "def", new BigtableVersionRange(-1, -1));
            var request = new MutateRowRequest
            {
                Mutations =
                {
                    Mutations.DeleteFromRow(),
                    setCell,
                    deleteFromColumn,
                    Mutations.DeleteFromFamily("abc")
                }
            };

            Assert.True(request.IsIdempotent());

            deleteFromColumn.DeleteFromColumn.TimeRange.StartTimestampMicros = -1;
            deleteFromColumn.DeleteFromColumn.TimeRange.EndTimestampMicros = -1;
            Assert.True(request.IsIdempotent());

            setCell.SetCell.TimestampMicros = -1;
            Assert.False(request.IsIdempotent());
        }
    }
}
