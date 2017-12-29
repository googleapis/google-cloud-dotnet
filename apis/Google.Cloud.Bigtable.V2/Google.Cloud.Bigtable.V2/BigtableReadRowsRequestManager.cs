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

using System.Collections.Generic;
using Google.Protobuf;
using System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Keeps track of Rows returned from a readRows RPC for information relevant to resuming the RPC
    /// after temporary problems.
    /// </summary>
    internal class BigtableReadRowsRequestManager
    {
        /// <summary>
        /// Compares two <see cref="ByteString"/>s
        /// </summary>
        /// <returns>integer that indicates their relative position in the lexicographical order.</returns>
        private int ByteStringCompare(ByteString key1, ByteString key2)
        {
            int size1 = key1.Length;
            int size2 = key2.Length;
            int size = Math.Min(size1, size2);

            for (int i = 0; i < size; i++)
            {
                int comparison = key1[i].CompareTo(key2[i]);
                if (comparison != 0)
                {
                    return comparison;
                }
            }
            return size1.CompareTo(size2);
        }

        // Member variables from the constructor.
        private readonly ReadRowsRequest _originalRequest;

        // The number of rows read so far.
        private long _rowCount;

        /// <summary>
        /// Constructor for <see cref="BigtableReadRowsRequestManager"/>.
        /// </summary>
        /// <param name="originalRequest">
        /// Original ReadRowsRequest containing all of the parameters of the API call.
        /// </param>
        public BigtableReadRowsRequestManager(ReadRowsRequest originalRequest)
        {
            _originalRequest = originalRequest;
        }

        /// <summary>
        /// Update last found Rowkey
        /// </summary>
        public ByteString LastFoundKey { get; set; }

        /// <summary>
        /// Update amount of rows read so far
        /// </summary>
        public long RowCount
        {
            get => _rowCount;
            set => _rowCount += value;
        }

        /// <summary>
        /// Builds and returns updated subrequest that excludes all rowKeys that have already been found.
        /// </summary>
        public ReadRowsRequest BuildUpdatedRequest()
        {
            ReadRowsRequest newReadRowsRequest = new ReadRowsRequest
            {
                TableNameAsTableName = _originalRequest.TableNameAsTableName,
            };

            #region Set up RowFilter

            if (_originalRequest.Filter != null)
            {
                newReadRowsRequest.Filter = new RowFilter();
                newReadRowsRequest.Filter = _originalRequest.Filter;
            }

            #endregion

            #region Set up RowsLimit

            // If the row limit is set, update it.
            long numRowsLimit = _originalRequest.RowsLimit;

            // Update <see cref="numRowsLimit"/> by removing the number of rows already read.
            if ((numRowsLimit -= RowCount) > 0)
            // The remaining number of rows must be greater than 0.
            {
                newReadRowsRequest.RowsLimit = numRowsLimit;
            }

            #endregion

            #region Set up RowSet

            newReadRowsRequest.Rows = new RowSet();
            newReadRowsRequest.Rows = FilterRows();

            #endregion

            return newReadRowsRequest;
        }

        private RowSet FilterRows()
        {
            RowSet originalRows = _originalRequest.Rows;

            if (LastFoundKey == null)
            {
                return originalRows;
            }

            RowSet newRowSet = new RowSet();

            foreach (ByteString key in originalRows.RowKeys)
            {
                if (!StartKeyIsAlreadyRead(key))
                {
                    newRowSet.RowKeys.Add(key);
                }
            }

            foreach (RowRange rowRange in originalRows.RowRanges)
            {
                RowRange.EndKeyOneofCase endKeyOneofCase = rowRange.EndKeyCase;

                if (endKeyOneofCase == RowRange.EndKeyOneofCase.EndKeyClosed
                    && EndKeyIsAlreadyRead(rowRange.EndKeyClosed)
                    || endKeyOneofCase == RowRange.EndKeyOneofCase.EndKeyOpen
                    && EndKeyIsAlreadyRead(rowRange.EndKeyOpen))
                {
                    continue;
                }

                RowRange newRange = rowRange;
                RowRange.StartKeyOneofCase startKeyOneofCase = rowRange.StartKeyCase;

                if (startKeyOneofCase == RowRange.StartKeyOneofCase.StartKeyClosed
                    && StartKeyIsAlreadyRead(rowRange.StartKeyClosed)
                    || (startKeyOneofCase == RowRange.StartKeyOneofCase.StartKeyOpen
                        && StartKeyIsAlreadyRead(rowRange.StartKeyOpen))
                    || startKeyOneofCase == RowRange.StartKeyOneofCase.None)
                {
                    newRange.StartKeyOpen = LastFoundKey;
                }
                newRowSet.RowRanges.Add(newRange);
            }

            return newRowSet;
        }

        private bool StartKeyIsAlreadyRead(ByteString startKey)
        {
            // empty start key emplies the smallest key.
            return LastFoundKey != null && (startKey.IsEmpty
                                            || ByteStringCompare(startKey, LastFoundKey) <= 0);
        }

        private bool EndKeyIsAlreadyRead(ByteString endKey)
        {
            // empty string implies the largest key.
            return LastFoundKey != null && !endKey.IsEmpty
                   && ByteStringCompare(endKey, LastFoundKey) <= 0;
        }
    }
}
