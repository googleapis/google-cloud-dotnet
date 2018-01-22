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

using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class RowFiltersTest
    {
        [Fact]
        public void BlockAllFilter()
        {
            var filter = RowFilters.BlockAllFilter();
            Assert.True(filter.BlockAllFilter);
        }

        [Fact]
        public void CellsPerColumnLimit()
        {
            var filter = RowFilters.CellsPerColumnLimit(1);
            Assert.Equal(1, filter.CellsPerColumnLimitFilter);
        }

        [Fact]
        public void CellsPerRowLimit()
        {
            var filter = RowFilters.CellsPerRowLimit(2);
            Assert.Equal(2, filter.CellsPerRowLimitFilter);
        }

        [Fact]
        public void CellsPerRowOffset()
        {
            var filter = RowFilters.CellsPerRowOffset(3);
            Assert.Equal(3, filter.CellsPerRowOffsetFilter);
        }

        [Fact]
        public void Chain()
        {
            var filter = RowFilters.Chain(
                RowFilters.CellsPerRowLimit(1),
                RowFilters.ValueExact("abc"));
            Assert.NotNull(filter.Chain);
            Assert.Equal(2, filter.Chain.Filters.Count);
            Assert.Equal(RowFilters.CellsPerRowLimit(1), filter.Chain.Filters[0]);
            Assert.Equal(RowFilters.ValueExact("abc"), filter.Chain.Filters[1]);
        }

        [Fact]
        public void Chain_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.Chain(default(RowFilter[])));
            Assert.Throws<ArgumentException>(() => RowFilters.Chain(new RowFilter[] { null }));
        }

        [Fact]
        public void ColumnQualifierExact()
        {
            var filter = RowFilters.ColumnQualifierExact("a\\b\0c\t");
            Assert.Equal(ByteString.CopyFromUtf8(@"a\\b\x00c\	"), filter.ColumnQualifierRegexFilter);
        }

        [Fact]
        public void ColumnQualifierRegex()
        {
            var filter = RowFilters.ColumnQualifierRegex("123");
            Assert.Equal(ByteString.CopyFromUtf8("123"), filter.ColumnQualifierRegexFilter);
        }

        [Fact]
        public void ColumnRange()
        {
            var range = new ColumnRange
            {
                StartQualifierClosed = ByteString.CopyFromUtf8("a"),
                EndQualifierOpen = ByteString.CopyFromUtf8("z")
            };
            var filter = RowFilters.ColumnRange(range);
            Assert.Equal(range, filter.ColumnRangeFilter);
        }

        [Fact]
        public void ColumnRange_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.ColumnRange(null));
        }

        [Fact]
        public void Condition()
        {
            var filter = RowFilters.Condition(
                RowFilters.ColumnQualifierRegex("last_name"),
                RowFilters.RowSample(0.5),
                RowFilters.FamilyNameExact("address"));
            Assert.NotNull(filter.Condition);
            Assert.Equal(
                RowFilters.ColumnQualifierRegex("last_name"),
                filter.Condition.PredicateFilter);
            Assert.Equal(RowFilters.RowSample(0.5), filter.Condition.TrueFilter);
            Assert.Equal(RowFilters.FamilyNameExact("address"), filter.Condition.FalseFilter);
        }

        [Fact]
        public void Condition_Validations()
        {
            // The true/false mutations are allowed to be null.
            RowFilters.Condition(RowFilters.PassAllFilter(), null, null);
        }

        [Fact]
        public void FamilyNameExact()
        {
            var filter = RowFilters.FamilyNameExact("a\\b\0c\t");
            Assert.Equal(@"a\\b\x00c\	", filter.FamilyNameRegexFilter);
        }

        [Fact]
        public void FamilyNameExact_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.FamilyNameExact(null));
        }

        [Fact]
        public void FamilyNameRegex()
        {
            var filter = RowFilters.FamilyNameRegex("abc");
            Assert.Equal("abc", filter.FamilyNameRegexFilter);
        }

        [Fact]
        public void FamilyNameRegex_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.FamilyNameRegex(null));
        }

        [Fact]
        public void Interleave()
        {
            var filter = RowFilters.Interleave(
                RowFilters.CellsPerRowLimit(1),
                RowFilters.ValueExact("abc"));
            Assert.NotNull(filter.Interleave);
            Assert.Equal(2, filter.Interleave.Filters.Count);
            Assert.Equal(RowFilters.CellsPerRowLimit(1), filter.Interleave.Filters[0]);
            Assert.Equal(RowFilters.ValueExact("abc"), filter.Interleave.Filters[1]);
        }

        [Fact]
        public void Interleave_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.Interleave(default(RowFilter[])));
            Assert.Throws<ArgumentException>(() => RowFilters.Interleave(new RowFilter[] { null }));
        }

        [Fact]
        public void PassAllFilter()
        {
            var filter = RowFilters.PassAllFilter();
            Assert.True(filter.PassAllFilter);
        }

        [Fact]
        public void RowKeyExact()
        {
            var filter = RowFilters.RowKeyExact("a\\b\0c\t");
            Assert.Equal(ByteString.CopyFromUtf8(@"a\\b\x00c\	"), filter.RowKeyRegexFilter);
        }

        [Fact]
        public void RowKeyRegex()
        {
            var filter = RowFilters.RowKeyRegex("abc");
            Assert.Equal(ByteString.CopyFromUtf8("abc"), filter.RowKeyRegexFilter);
        }

        [Fact]
        public void RowSample()
        {
            var filter = RowFilters.RowSample(0.25);
            Assert.Equal(0.25, filter.RowSampleFilter);
        }

        [Fact]
        public void RowSample_Validations()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => RowFilters.RowSample(-0.01));
            Assert.Throws<ArgumentOutOfRangeException>(() => RowFilters.RowSample(1.01));
        }

        [Fact]
        public void StripValueTransformer()
        {
            var filter = RowFilters.StripValueTransformer();
            Assert.True(filter.StripValueTransformer);
        }

        [Fact]
        public void TimestampRange()
        {
            var start = DateTime.UtcNow;
            var end = start.AddDays(1);
            var filter = RowFilters.TimestampRange(start, end);
            Assert.NotNull(filter.TimestampRangeFilter);
            var startMicros = ((start.Ticks - BigtableVersion.UnixEpoch.Ticks) / 10000) * 1000;
            var endMicros = ((end.Ticks - BigtableVersion.UnixEpoch.Ticks) / 10000) * 1000;
            Assert.Equal(startMicros, filter.TimestampRangeFilter.StartTimestampMicros);
            Assert.Equal(endMicros, filter.TimestampRangeFilter.EndTimestampMicros);
        }

        [Fact]
        public void ValueExact()
        {
            var filter = RowFilters.ValueExact("a\\b\0c\t");
            Assert.Equal(ByteString.CopyFromUtf8(@"a\\b\x00c\	"), filter.ValueRegexFilter);
        }

        [Fact]
        public void ValueRange()
        {
            var range = new ValueRange
            {
                StartValueClosed = ByteString.CopyFromUtf8("a"),
                EndValueOpen = ByteString.CopyFromUtf8("z")
            };
            var filter = RowFilters.ValueRange(range);
            Assert.Equal(range, filter.ValueRangeFilter);
        }

        [Fact]
        public void ValueRange_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.ValueRange(null));
        }

        [Fact]
        public void ValueRegex()
        {
            var filter = RowFilters.ValueRegex("abc");
            Assert.Equal(ByteString.CopyFromUtf8("abc"), filter.ValueRegexFilter);
        }

        [Fact]
        public void VersionRange_Range()
        {
            var range = new BigtableVersionRange(1, 2);
            var filter = RowFilters.VersionRange(range);
            Assert.NotNull(filter.TimestampRangeFilter);
            Assert.Equal(1000, filter.TimestampRangeFilter.StartTimestampMicros);
            Assert.Equal(2000, filter.TimestampRangeFilter.EndTimestampMicros);
        }

        [Fact]
        public void VersionRange_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => RowFilters.VersionRange(null));
        }
    }
}
