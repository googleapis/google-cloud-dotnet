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

using System.Diagnostics;
using System.Linq;
using System;
using Google.Cloud.Bigtable.Common.V2;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Keeps track of Rows returned from a readRows RPC for information relevant to resuming the RPC
    /// after temporary problems.
    /// </summary>
    internal class BigtableReadRowsRequestManager
    {
        internal ReadRowsRequest OriginalRequest { get; }
        private long _rowsReadSoFar;

        /// <summary>
        /// Constructor for <see cref="BigtableReadRowsRequestManager"/>.
        /// </summary>
        /// <param name="originalRequest">
        /// Original ReadRowsRequest containing all of the parameters of the API call.
        /// </param>
        internal BigtableReadRowsRequestManager(ReadRowsRequest originalRequest) => OriginalRequest = originalRequest;

        /// <summary>
        /// Update last found Rowkey
        /// </summary>
        internal BigtableByteString LastFoundKey { get; set; }

        internal void IncrementRowsReadSoFar(int count = 1) => _rowsReadSoFar += count;

        internal long RowsReadSoFar() => _rowsReadSoFar;

        /// <summary>
        /// Builds and returns updated subrequest that excludes all rowKeys that have already been found,
        /// or null if all rows have already been found.
        /// </summary>
        internal ReadRowsRequest BuildUpdatedRequest()
        {
            // Remove received rowKeys form Rows.
            var rows = FilterRows();

            // If we removed all row keys/ranges, we don't want to retry anything: all rows have
            // actually been received.
            if (rows != OriginalRequest.Rows &&
                rows.RowKeys.Count == 0 &&
                rows.RowRanges.Count == 0)
            {
                return null;
            }

            var newReadRowsRequest = new ReadRowsRequest
            {
                TableName = OriginalRequest.TableName,
                Filter = OriginalRequest.Filter,
                AppProfileId = OriginalRequest.AppProfileId,
                Rows = rows
            };

            // If the row limit is set, update it.
            if (OriginalRequest.RowsLimit != 0)
            {
                long rowsRemaining = OriginalRequest.RowsLimit - _rowsReadSoFar;
                Debug.Assert(rowsRemaining > 0, "The remaining number of rows must be greater than 0.");
                newReadRowsRequest.RowsLimit = Math.Max(1, rowsRemaining);
            }

            return newReadRowsRequest;
        }

        /// <summary>
        /// Removes received rows from the RowSet.
        /// </summary>
        /// <returns>
        /// New RowSet with not received rows.</returns>
        private RowSet FilterRows()
        {
            RowSet originalRows = OriginalRequest.Rows;

            if (LastFoundKey.Value.IsEmpty)
            {
                return originalRows;
            }

            // If the original request didn't specify a row set at all, create an open range from the last key
            // to specify "all rows after this key".
            if (originalRows == null)
            {
                return RowSet.FromRowRanges(RowRange.Open(LastFoundKey, null));
            }

            RowSet newRowSet = new RowSet
            {
                RowKeys = { originalRows.RowKeys.Where(key => !StartKeyIsAlreadyRead(key)) }
            };

            foreach (RowRange rowRange in originalRows.RowRanges)
            {
                RowRange.EndKeyOneofCase endKeyOneofCase = rowRange.EndKeyCase;
                if (endKeyOneofCase == RowRange.EndKeyOneofCase.EndKeyClosed &&
                    EndKeyIsAlreadyRead(rowRange.EndKeyClosed)
                    || endKeyOneofCase == RowRange.EndKeyOneofCase.EndKeyOpen &&
                    EndKeyIsAlreadyRead(rowRange.EndKeyOpen))
                {
                    continue;
                }

                RowRange.StartKeyOneofCase startKeyOneofCase = rowRange.StartKeyCase;
                RowRange newRange = rowRange;
                if (startKeyOneofCase == RowRange.StartKeyOneofCase.StartKeyClosed &&
                    StartKeyIsAlreadyRead(rowRange.StartKeyClosed)
                    || (startKeyOneofCase == RowRange.StartKeyOneofCase.StartKeyOpen &&
                        StartKeyIsAlreadyRead(rowRange.StartKeyOpen))
                    || startKeyOneofCase == RowRange.StartKeyOneofCase.None)
                {
                    newRange = newRange.Clone();
                    newRange.StartKeyOpen = LastFoundKey.Value;
                }
                newRowSet.RowRanges.Add(newRange);
            }

            return newRowSet;
        }

        private bool StartKeyIsAlreadyRead(BigtableByteString startKey) =>
            !LastFoundKey.Value.IsEmpty && (startKey.Value.IsEmpty || startKey <= LastFoundKey);

        private bool EndKeyIsAlreadyRead(BigtableByteString endKey) =>
            !LastFoundKey.Value.IsEmpty && (!endKey.Value.IsEmpty && endKey <= LastFoundKey);
    }
}
