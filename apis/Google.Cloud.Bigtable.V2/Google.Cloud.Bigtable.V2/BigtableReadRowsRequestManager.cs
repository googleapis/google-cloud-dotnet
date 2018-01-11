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
using Google.Protobuf;
using System.Linq;
using System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Keeps track of Rows returned from a readRows RPC for information relevant to resuming the RPC
    /// after temporary problems.
    /// </summary>
    internal class BigtableReadRowsRequestManager
    {
        // Member variables from the constructor.
        private readonly ReadRowsRequest _originalRequest;

        // The number of rows read so far.
        internal long RowCount { get; private set; }

        /// <summary>
        /// Constructor for <see cref="BigtableReadRowsRequestManager"/>.
        /// </summary>
        /// <param name="originalRequest">
        /// Original ReadRowsRequest containing all of the parameters of the API call.
        /// </param>
        internal BigtableReadRowsRequestManager(ReadRowsRequest originalRequest) => _originalRequest = originalRequest;

        /// <summary>
        /// Update last found Rowkey
        /// </summary>
        internal BigtableByteString LastFoundKey { get; set; }

        /// <summary>
        /// Update amount of rows read so far
        /// </summary>
        internal void IncrementRowCount(int count) => RowCount += count;

        /// <summary>
        /// Builds and returns updated subrequest that excludes all rowKeys that have already been found.
        /// </summary>
        internal ReadRowsRequest BuildUpdatedRequest()
        {
            ReadRowsRequest newReadRowsRequest = new ReadRowsRequest
            {
                // Transfer TableName
                TableNameAsTableName = _originalRequest.TableNameAsTableName,
                // Transfer RowFilter.
                Filter = _originalRequest.Filter,
                // Remove received rowKeys form Rows.
                Rows = FilterRows()
            };

            // If the row limit is set, update it.
            if (_originalRequest.RowsLimit != 0)
            {
                long rowsRemaining = _originalRequest.RowsLimit - RowCount;
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
            RowSet originalRows = _originalRequest.Rows;
            
            if (LastFoundKey.Value.IsEmpty)
            {
                return originalRows;
            }

            RowSet newRowSet = new RowSet
            {
                RowKeys = {originalRows.RowKeys.Where(key => !StartKeyIsAlreadyRead(key))}
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

                if (startKeyOneofCase == RowRange.StartKeyOneofCase.StartKeyClosed &&
                    StartKeyIsAlreadyRead(rowRange.StartKeyClosed)
                    || (startKeyOneofCase == RowRange.StartKeyOneofCase.StartKeyOpen &&
                        StartKeyIsAlreadyRead(rowRange.StartKeyOpen))
                    || startKeyOneofCase == RowRange.StartKeyOneofCase.None)
                {
                    RowRange newRange = rowRange.Clone();
                    newRange.StartKeyOpen = LastFoundKey.Value;
                    newRowSet.RowRanges.Add(newRange);
                }
                else
                {
                    newRowSet.RowRanges.Add(rowRange);
                }
            }

            return newRowSet;
        }
        
        private bool StartKeyIsAlreadyRead(BigtableByteString startKey) =>
            !LastFoundKey.Value.IsEmpty && (startKey.Value.IsEmpty || startKey <= LastFoundKey);

        private bool EndKeyIsAlreadyRead(BigtableByteString endKey) => 
            !LastFoundKey.Value.IsEmpty && (!endKey.Value.IsEmpty && endKey <= LastFoundKey);
    }
}
