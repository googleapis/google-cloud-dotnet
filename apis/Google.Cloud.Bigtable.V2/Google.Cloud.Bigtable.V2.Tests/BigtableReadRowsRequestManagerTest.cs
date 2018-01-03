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

using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    /// <summary>
    /// Test for <see cref="BigtableReadRowsRequestManager"/>.
    /// </summary>
    public class BigtableReadRowsRequestManagerTest
    {
        private static ReadRowsRequest CreateRowRangeRequest(RowRange rowRange) =>
            new ReadRowsRequest {Rows = RowSet.FromRowRanges(rowRange)};

        private static ReadRowsRequest CreateRowKeysRequest(params BigtableByteString[] keys) =>
            new ReadRowsRequest {Rows = RowSet.FromRowKeys(keys)};

        private static ReadRowsRequest CreateRowFilterRequest(RowFilter rowFilter) =>
            new ReadRowsRequest {Filter = rowFilter};

        /// <summary>
        /// Test rowfilter appears in the <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// </summary>
        [Fact]
        public void TestRowFilter()
        {
            var rowFilter = RowFilters.Chain(
                RowFilters.CellsPerColumnLimit(1),
                RowFilters.CellsPerRowOffset(2),
                RowFilters.CellsPerRowLimit(10));

            ReadRowsRequest originalRequest = CreateRowFilterRequest(rowFilter);

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test a single, full table scan scenario for updating <see cref="BigtableReadRowsRequestManager.LastFoundKey"/>.
        /// </summary>
        [Fact]
        public void TestFilterRowsTestAllRange()
        {
            BigtableByteString key1 = "row1";

            ReadRowsRequest originalRequest = CreateRowRangeRequest(RowRange.ClosedOpen(null, null));

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            underTest.LastFoundKey = key1;
            Assert.Equal(CreateRowRangeRequest(RowRange.Open(key1, null)), underTest.BuildUpdatedRequest());

        }

        /// <summary>
        ///  Test rowKeys scenario for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>.
        /// </summary>
        [Fact]
        public void TestFilterRowsRowKeys()
        {
            BigtableByteString key1 = "row1";
            BigtableByteString key2 = "row2";
            BigtableByteString key3 = "row3";

            ReadRowsRequest originalRequest = CreateRowKeysRequest(key1, key2, key3);

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = key1;

            Assert.Equal(CreateRowKeysRequest(key2, key3), underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test multiple rowset filter scenarios for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>.
        /// </summary>
        [Fact]
        public void TestFilterRowsMultiRowSetFilters()
        {
            BigtableByteString key1 = "row1";
            BigtableByteString key2 = "row2";
            BigtableByteString key3 = "row3";

            RowSet fullRowSet = RowSet.FromRowKeys(key1, key2, key3);
            fullRowSet.RowRanges.Add(new []
            {
                RowRange.OpenClosed(null, key1), // should be filtered out
                RowRange.Open(null, key1), // should be filtered out
                RowRange.Open(key1, key2), // should stay
                RowRange.ClosedOpen(key1, key2), // should be converted (key1 -> key2)
                RowRange.Closed(key1, key2), // should be converted (key1 -> key2]
                RowRange.Open(key2, key3), // should stay
                RowRange.ClosedOpen(key2, key3) // should stay
            });

            RowSet filteredRowSet = RowSet.FromRowKeys(key2, key3);
            filteredRowSet.RowRanges.Add(new[]
            {
                RowRange.Open(key1, key2), // should stay
                RowRange.Open(key1, key2), // should be converted (key1 -> key2)
                RowRange.OpenClosed(key1, key2), // should be converted (key1 -> key2]
                RowRange.Open(key2, key3), // should stay
                RowRange.ClosedOpen(key2, key3)// should stay
            });

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
        public void TestFilterRowsUnsignedRange()
        {
            BigtableByteString key1 = 0x7f;
            BigtableByteString key2 = 0x80;

            ReadRowsRequest originalRequest =
                CreateRowRangeRequest(RowRange.ClosedOpen(key1, null));

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            underTest.LastFoundKey = key2;

            Assert.Equal(CreateRowRangeRequest(RowRange.Open(key2, null)),
                underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test that resume handles row ranges as unsigned bytes
        /// </summary>
        [Fact]
        public void TestFilterRowsUnsignedRows()    
        {
            BigtableByteString key1 = 0x7f;
            BigtableByteString key2 = 0x80;

            ReadRowsRequest originalRequest = CreateRowKeysRequest(key1, key2);

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            underTest.LastFoundKey = key1;

            Assert.Equal(CreateRowKeysRequest(key2), underTest.BuildUpdatedRequest());
        }
    }
}
