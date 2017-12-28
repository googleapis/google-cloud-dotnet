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
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    /// <summary>
    /// Test for <see cref="BigtableReadRowsRequestManager"/>.
    /// </summary>
    public class BigtableReadRowsRequestManagerTest
    {
        private readonly ByteString BLANC = ByteString.Empty;

        private static ReadRowsRequest CreateRowRangeRequest(RowRange rowRange)
        {
            return new ReadRowsRequest { Rows = new RowSet { RowRanges = { rowRange } } };
        }

        private ReadRowsRequest CreateRowKeysRequest(IEnumerable<ByteString> keys)
        {
            return new ReadRowsRequest { Rows = CreateRowSet(keys) };
        }

        private static ReadRowsRequest CreateRowFilterRequest(RowFilter rowFilter)
        {
            return new ReadRowsRequest { Filter = rowFilter };
        }

        private static RowRange CreateRowRangeClosedStart(ByteString startClosed, ByteString endOpen)
        {
            return new RowRange { StartKeyClosed = startClosed, EndKeyOpen = endOpen };
        }

        private static RowRange CreateRowRangeOpenedStart(ByteString startOpen, ByteString endOpen)
        {
            return new RowRange { StartKeyOpen = startOpen, EndKeyOpen = endOpen };
        }

        private RowSet CreateRowSet(IEnumerable<ByteString> keys)
        {
            return new RowSet { RowKeys = { keys } };
        }

        /// <summary>
        /// Test rowfilter appearse in the <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// </summary>
        [Fact]
        public void Test_rowFilter()
        {
            RowFilter[] rowFiltersRange = { RowFilters.CellsPerColumnLimit(1), RowFilters.CellsPerRowOffset(2), RowFilters.CellsPerRowLimit(10) };

            RowFilter rowFilter = new RowFilter();
            rowFilter.Chain = new RowFilter.Types.Chain();
            rowFilter.Chain.Filters.AddRange(rowFiltersRange);

            ReadRowsRequest originalRequest = CreateRowFilterRequest(rowFilter);

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test a single, full table scan scenario for updating <see cref="BigtableReadRowsRequestManager.LastFoundKey"/>.
        /// </summary>
        [Fact]
        public void Test_filterRows_testAllRange()
        {
            ByteString key1 = ByteString.CopyFromUtf8("row1");
            ReadRowsRequest originalRequest =
                CreateRowRangeRequest(CreateRowRangeClosedStart(BLANC, BLANC));

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            underTest.LastFoundKey = key1;
            Assert.Equal(CreateRowRangeRequest(CreateRowRangeOpenedStart(key1, BLANC)), underTest.BuildUpdatedRequest());
        }

        /// <summary>
        ///  Test rowKeys scenario for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>.
        /// </summary>
        [Fact]
        public void Test_filterRows_rowKeys()
        {
            ByteString key1 = ByteString.CopyFromUtf8("row1");
            ByteString key2 = ByteString.CopyFromUtf8("row2");
            ByteString key3 = ByteString.CopyFromUtf8("row3");

            ReadRowsRequest originalRequest = CreateRowKeysRequest(new[] { key1, key2, key3 });

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = key1;

            Assert.Equal(CreateRowKeysRequest(new[] { key2, key3 }), underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test multiple rowset filter scenarios for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>.
        /// </summary>
        [Fact]
        public void Test_filterRows_multiRowSetFilters()
        {
            ByteString key1 = ByteString.CopyFromUtf8("row1");
            ByteString key2 = ByteString.CopyFromUtf8("row2");
            ByteString key3 = ByteString.CopyFromUtf8("row3");

            RowSet fullRowSet = new RowSet
            {
                RowKeys = { new[] { key1, key2, key3 } }, // row1 should be filtered out
                RowRanges =
                {
                    new RowRange {StartKeyOpen = BLANC, EndKeyClosed = key1}, // should be filtered out
                    new RowRange {StartKeyOpen = BLANC, EndKeyOpen = key1}, // should be filtered out
                    new RowRange {StartKeyOpen = key1, EndKeyOpen = key2}, // should stay
                    new RowRange {StartKeyClosed = key1, EndKeyOpen = key2}, // should be converted (key1 -> key2)
                    new RowRange {StartKeyClosed = key1, EndKeyClosed = key2}, // should be converted (key1 -> key2]
                    new RowRange {StartKeyOpen = key2, EndKeyOpen = key3}, // should stay
                    new RowRange {StartKeyClosed = key2, EndKeyOpen = key3} // should stay
                }
            };


            RowSet filteredRowSet = new RowSet
            {
                RowKeys = { new[] { key2, key3 } }, // row1 should be filtered out
                RowRanges =
                {
                    new RowRange {StartKeyOpen = key1, EndKeyOpen = key2}, // should stay
                    new RowRange {StartKeyOpen = key1, EndKeyOpen = key2}, // should be converted (key1 -> key2)
                    new RowRange {StartKeyOpen = key1, EndKeyClosed = key2}, // should be converted (key1 -> key2]
                    new RowRange {StartKeyOpen = key2, EndKeyOpen = key3}, // should stay
                    new RowRange {StartKeyClosed = key2, EndKeyOpen = key3} // should stay
                }
            };

            ReadRowsRequest originalRequest = new ReadRowsRequest { Rows = fullRowSet };
            ReadRowsRequest filteredRequest = new ReadRowsRequest { Rows = filteredRowSet };

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = key1;
            Assert.Equal(filteredRequest, underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test that resume handles key requests as unsigned bytes
        /// </summary>
        [Fact]
        public void Test_filterRows_unsignedRange()
        {
            ByteString key1 = ByteString.CopyFrom(0x7f);
            ByteString key2 = ByteString.CopyFrom((byte)0x80);

            ReadRowsRequest originalRequest =
                CreateRowRangeRequest(CreateRowRangeClosedStart(key1, BLANC));

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            underTest.LastFoundKey = key2;

            Assert.Equal(CreateRowRangeRequest(CreateRowRangeOpenedStart(key2, BLANC)),
                underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test that resume handles row ranges as unsigned bytes
        /// </summary>
        [Fact]
        public void Test_filterRows_unsignedRows()
        {
            ByteString key1 = ByteString.CopyFrom(0x7f);
            ByteString key2 = ByteString.CopyFrom((byte)0x80);

            ReadRowsRequest originalRequest = CreateRowKeysRequest(new[] { key1, key2 });

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            underTest.LastFoundKey = key1;

            Assert.Equal(CreateRowKeysRequest(new[] { key2 }), underTest.BuildUpdatedRequest());
        }
    }
}
