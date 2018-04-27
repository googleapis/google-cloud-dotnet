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

using Google.Api.Gax;
using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Static class with convenience methods for creating various kinds of <see cref="RowFilter"/> instances.
    /// </summary>
    public static class RowFilters
    {
        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which does not match any
        /// cells, regardless of input. Useful for temporarily disabling just part of
        /// a filter.
        /// </summary>
        /// <returns>The created row filter.</returns>
        public static RowFilter BlockAllFilter() =>
            new RowFilter { BlockAllFilter = true };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only the most
        /// recent N cells within each column.
        /// </summary>
        /// <remarks>
        /// <para>
        /// For example, if N=2, this filter would match column `foo:bar` at timestamps
        /// 10 and 9, skip all earlier cells in `foo:bar`, and then begin matching again
        /// in column `foo:bar2`.
        /// </para>
        /// <para>
        /// If duplicate cells are present, as is possible when using an Interleave,
        /// each copy of the cell is counted separately.
        /// </para>
        /// </remarks>
        /// <param name="limit">
        /// The maximum number of cells allowed per column.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter CellsPerColumnLimit(int limit) =>
            new RowFilter { CellsPerColumnLimitFilter = limit };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only the first
        /// N cells of each row.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If duplicate cells are present, as is possible when using an Interleave,
        /// each copy of the cell is counted separately.
        /// </para>
        /// </remarks>
        /// <param name="limit">
        /// The maximum number of cells allowed per row.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter CellsPerRowLimit(int limit) =>
            new RowFilter { CellsPerRowLimitFilter = limit };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which skips the first N cells
        /// of each row, matching all subsequent cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If duplicate cells are present, as is possible when using an Interleave,
        /// each copy of the cell is counted separately.
        /// </para>
        /// </remarks>
        /// <param name="offset">
        /// The number of cells to skip per row.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter CellsPerRowOffset(int offset) =>
            new RowFilter { CellsPerRowOffsetFilter = offset };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which sends rows through
        /// several RowFilters in sequence.
        /// </summary>
        /// <param name="filters">
        /// The elements of "filters" are chained together to process the input row:
        /// in row -> f(0) -> intermediate row -> f(1) -> ... -> f(N) -> out row
        /// The full chain is executed atomically.  Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter Chain(params RowFilter[] filters) =>
            new RowFilter
            {
                Chain = new RowFilter.Types.Chain
                {
                    Filters = { Utilities.ValidateCollection(filters, nameof(filters)) }
                }
            };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// from columns whose qualifiers match the exact byte string specified.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="value"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="value">
        /// The exact value used to match column qualifiers.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter ColumnQualifierExact(BigtableByteString value) =>
            new RowFilter { ColumnQualifierRegexFilter = Utilities.RegexEscape(value.Value) };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells from
        /// columns whose qualifiers satisfy the given RE2 regex.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The format of RE2 is documented at https://github.com/google/re2/wiki/Syntax.
        /// </para>
        /// <para>
        /// Note that, since column qualifiers can contain arbitrary bytes, the `\C`
        /// escape sequence must be used if a true wildcard is desired. The `.`
        /// character will not match the new line character `\n`, which may be
        /// present in a binary qualifier.
        /// </para>
        /// </remarks>
        /// <param name="regex">
        /// The RE2 regex used to match column qualifiers.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter ColumnQualifierRegex(string regex) =>
            new RowFilter { ColumnQualifierRegexFilter = ByteString.CopyFromUtf8(regex) };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells from
        /// columns within the given range.
        /// </summary>
        /// <param name="range">
        /// The range of columns from which cells should be matched. Must not be null.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter ColumnRange(ColumnRange range) =>
            new RowFilter { ColumnRangeFilter = GaxPreconditions.CheckNotNull(range, nameof(range)) };

        // TODO: Add additional ColumnRange... methods to take start/end values?

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which applies one of two
        /// possible RowFilters to the data based on the output of a predicate
        /// RowFilter.
        /// </summary>
        /// <param name="predicateFilter">
        /// If <paramref name="predicateFilter"/> outputs any cells, then
        /// <paramref name="trueFilter"/> will be evaluated on the input row.
        /// Otherwise, <paramref name="falseFilter"/> will be evaluated.
        /// </param>
        /// <param name="trueFilter">
        /// The filter to apply to the input row if <paramref name="predicateFilter"/>
        /// returns any results. If null, no results will be returned in the true case.
        /// </param>
        /// <param name="falseFilter">
        /// The filter to apply to the input row if <paramref name="predicateFilter"/>
        /// does not return any results. If null, no results will be returned in the
        /// false case.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter Condition(
            RowFilter predicateFilter, RowFilter trueFilter, RowFilter falseFilter) =>
            new RowFilter
            {
                Condition = new RowFilter.Types.Condition
                {
                    PredicateFilter = predicateFilter,
                    TrueFilter = trueFilter,
                    FalseFilter = falseFilter
                }
            };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// from column families whose names match the exact string specified.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="value"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="value">
        /// The exact value used to match column families. Must not be null
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter FamilyNameExact(string value) =>
            new RowFilter
            {
                FamilyNameRegexFilter = Utilities.RegexEscape(
                    ByteString.CopyFromUtf8(GaxPreconditions.CheckNotNull(value, nameof(value)))
                    ).ToStringUtf8()
            };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// from columns whose families satisfy the given RE2 regex.
        /// </summary>
        /// <remarks>
        /// <para>
        /// For technical reasons, the regex must not contain the `:` character, even
        /// if it is not being used as a literal. Note that, since column families
        /// cannot contain the new line character `\n`, it is sufficient to use `.`
        /// as a full wildcard when matching column family names.
        /// </para>
        /// </remarks>
        /// <param name="regex">
        /// The RE2 regex used to match column families. Must not be null.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter FamilyNameRegex(string regex) =>
            new RowFilter { FamilyNameRegexFilter = GaxPreconditions.CheckNotNull(regex, nameof(regex)) };

        // TODO: Re-sync with Interleave.Filters proto docs when ASCII-art removed.
        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which applies several
        /// RowFilters to the data in parallel and combines the results.
        /// </summary>
        /// <param name="filters">
        /// The filters to apply in parallel. Must not be null, or contain null elements.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter Interleave(params RowFilter[] filters) =>
            new RowFilter
            {
                Interleave = new RowFilter.Types.Interleave
                {
                    Filters = { Utilities.ValidateCollection(filters, nameof(filters)) }
                }
            };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches all cells,
        /// regardless of input. Functionally equivalent to leaving `filter` unset,
        /// but included for completeness.
        /// </summary>
        /// <returns>The created row filter.</returns>
        public static RowFilter PassAllFilter() =>
            new RowFilter { PassAllFilter = true };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// from rows whose keys match the exact byte string specified.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="value"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="value">
        /// The exact value used to match row keys.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter RowKeyExact(BigtableByteString value) =>
            new RowFilter { RowKeyRegexFilter = Utilities.RegexEscape(value.Value) };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// from rows whose keys satisfy the given RE2 regex. In other words, passes
        /// through the entire row when the key matches, and otherwise produces an
        /// empty row.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The format of RE2 is documented at https://github.com/google/re2/wiki/Syntax.
        /// </para>
        /// <para>
        /// Note that, since row keys can contain arbitrary bytes, the `\C` escape
        /// sequence must be used if a true wildcard is desired. The `.` character
        /// will not match the new line character `\n`, which may be present in a
        /// binary key.
        /// </para>
        /// </remarks>
        /// <param name="regex">
        /// The RE2 regex used to match row keys.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter RowKeyRegex(string regex) =>
            new RowFilter { RowKeyRegexFilter = ByteString.CopyFromUtf8(regex) };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches all cells
        /// from a row with probability p, and matches no cells from the row with
        /// probability 1-p.
        /// </summary>
        /// <param name="probability">
        /// The probability with which rows should be matched. Must be between 0 and 1, inclusive.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter RowSample(double probability) =>
            new RowFilter
            {
                RowSampleFilter = GaxPreconditions.CheckArgumentRange(probability, nameof(probability), 0.0, 1.0)
            };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which replaces each cell's
        /// value with the empty string. This is useful for increasing performance when
        /// only getting cell counts rather than cell values.
        /// </summary>
        /// <returns>The created row filter.</returns>
        public static RowFilter StripValueTransformer() =>
            new RowFilter { StripValueTransformer = true };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// with versions within the given range.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note: version values are stored on the server as if they are microseconds since the Unix epoch.
        /// However, the server only supports millisecond granularity, so the server only allows microseconds
        /// in multiples of 1,000. <see cref="BigtableVersion"/> attempts to hide this complexity by exposing
        /// its underlying <see cref="BigtableVersion.Value"/> in terms of milliseconds, so if desired, a
        /// custom versioning scheme of 1, 2, ... can be used rather than 1000, 2000, ... However, access to
        /// the underlying microsecond value is still provided via <see cref="BigtableVersion.Micros"/>.
        /// </para>
        /// <para>
        /// Note: when using ReadModifyWriteRow, modified columns automatically use a server version, which
        /// is based on the current timestamp since the Unix epoch. For those columns, other reads and writes
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed to
        /// using a custom versioning scheme with 64-bit values.
        /// </para>
        /// </remarks>
        /// <param name="startTimestamp">
        /// Of the range of versions from which cells should be matched, inclusive lower bound timestamp
        /// whose milliseconds since the Unix epoch should be used as the version value. If null, interpreted
        /// as 0.  It must be specified in UTC.
        /// </param>
        /// <param name="endTimestamp">
        /// Of the range of versions from which cells should be matched, exclusive upper bound timestamp
        /// whose milliseconds since the Unix epoch should be used as the version value. If null, interpreted
        /// as infinity.  It must be specified in UTC.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter TimestampRange(DateTime? startTimestamp, DateTime? endTimestamp) =>
            VersionRange(new BigtableVersionRange(startTimestamp, endTimestamp));

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// with values that match the exact byte string specified.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="value"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="value">
        /// The exact value used to match cell values.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter ValueExact(BigtableByteString value) =>
            new RowFilter { ValueRegexFilter = Utilities.RegexEscape(value.Value) };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// with values that fall within the given range.
        /// </summary>
        /// <param name="range">
        /// The range of values to match. Must not be null.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter ValueRange(ValueRange range) =>
            new RowFilter { ValueRangeFilter = GaxPreconditions.CheckNotNull(range, nameof(range)) };

        // TODO: Add additional ValueRange... methods to take start/end values?

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// with values that satisfy the given regular expression.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The format of RE2 is documented at https://github.com/google/re2/wiki/Syntax.
        /// </para>
        /// <para>
        /// Note that, since cell values can contain arbitrary bytes, the `\C` escape
        /// sequence must be used if a true wildcard is desired. The `.` character
        /// will not match the new line character `\n`, which may be present in a
        /// binary value.
        /// </para>
        /// </remarks>
        /// <param name="regex">
        /// The RE2 regex used to match cell values.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter ValueRegex(string regex) =>
            new RowFilter { ValueRegexFilter = ByteString.CopyFromUtf8(regex) };

        /// <summary>
        /// Creates a new <see cref="RowFilter"/> instance which matches only cells
        /// with versions within the given range.
        /// </summary>
        /// <param name="range">
        /// The range of versions from which cells should be matched. Must not be null.
        /// </param>
        /// <returns>The created row filter.</returns>
        public static RowFilter VersionRange(BigtableVersionRange range) =>
            new RowFilter { TimestampRangeFilter = GaxPreconditions.CheckNotNull(range, nameof(range)).ToTimestampRange() };

        // TODO: Add additional VersionRange... methods to take start/end values?
    }
}
