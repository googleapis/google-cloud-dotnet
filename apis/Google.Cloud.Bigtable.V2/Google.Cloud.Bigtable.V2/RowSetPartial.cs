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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Bigtable.V2
{
    // TODO: You can combine keys and ranges in a set. Make a helper for that as well?
    public partial class RowSet
    {
        /// <summary>
        /// Creates a <see cref="RowSet"/> instance from a single row key.
        /// </summary>
        /// <param name="rowKey">
        /// The key of row included in the set.
        /// </param>
        /// <returns>The created set.</returns>
        public static RowSet FromRowKey(BigtableByteString rowKey) =>
            new RowSet
            {
                RowKeys = { rowKey.Value }
            };

        /// <summary>
        /// Creates a <see cref="RowSet"/> instance from individual row keys.
        /// </summary>
        /// <param name="rowKeys">
        /// The keys of single rows included in the set. Must not be null.
        /// </param>
        /// <returns>The created set.</returns>
        public static RowSet FromRowKeys(params BigtableByteString[] rowKeys) =>
            FromRowKeys((IEnumerable<BigtableByteString>)rowKeys);

        /// <summary>
        /// Creates a <see cref="RowSet"/> instance from individual row keys.
        /// </summary>
        /// <param name="rowKeys">
        /// The keys of single rows included in the set. Must not be null.
        /// </param>
        /// <returns>The created set.</returns>
        public static RowSet FromRowKeys(IEnumerable<BigtableByteString> rowKeys) =>
            new RowSet
            {
                RowKeys = { Utilities.ValidateCollection(rowKeys, nameof(rowKeys)).Select(k => k.Value) }
            };

        /// <summary>
        /// Creates a <see cref="RowSet"/> instance from contiguous row ranges.
        /// </summary>
        /// <param name="rowRanges">
        /// Contiguous row ranges included in the set. Must not be null or contain null entries.
        /// </param>
        /// <returns>The created set.</returns>
        public static RowSet FromRowRanges(params RowRange[] rowRanges) =>
            FromRowRanges((IEnumerable<RowRange>)rowRanges);

        /// <summary>
        /// Creates a <see cref="RowSet"/> instance from contiguous row ranges.
        /// </summary>
        /// <param name="rowRanges">
        /// Contiguous row ranges included in the set. Must not be null or contain null entries.
        /// </param>
        /// <returns>The created set.</returns>
        public static RowSet FromRowRanges(IEnumerable<RowRange> rowRanges) =>
            new RowSet
            {
                RowRanges = { Utilities.ValidateCollection(rowRanges, nameof(rowRanges)) }
            };

        // TODO: Also include helpers for closed/open range if it is a set of a single range only?
    }
}
