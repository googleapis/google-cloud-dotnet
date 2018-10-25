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
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    /// <summary>
    /// Test for <see cref="BigtableReadRowsRequestManager"/>.
    /// </summary>
    public class BigtableReadRowsRequestManagerTest
    {
        private static ReadRowsRequest CreateRowRangeRequest(RowRange rowRange) =>
            new ReadRowsRequest { Rows = RowSet.FromRowRanges(rowRange) };

        private static ReadRowsRequest CreateRowKeysRequest(params BigtableByteString[] keys) =>
            new ReadRowsRequest { Rows = RowSet.FromRowKeys(keys) };

        /// <summary>
        /// Test AppProfileId appears in the <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// </summary>
        [Fact]
        public void TestAppProfileId()
        {
            var originalRequest = new ReadRowsRequest
            {
                Rows = RowSet.FromRowKey("a"),
                AppProfileId = "xyz"
            };

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
        }

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

            var originalRequest = new ReadRowsRequest
            {
                Rows = RowSet.FromRowKey("a"),
                Filter = rowFilter
            };

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
        /// Test rowKeys scenario for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>.
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
        /// Test rowKeys scenario for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// with <see cref="BigtableReadRowsRequestManager.LastFoundKey"/> in between key1 and key2.
        /// </summary>
        [Fact]
        public void TestFilterRowsRowKeysLastFoundKeyInBetween()
        {
            BigtableByteString key1 = "row1";
            BigtableByteString key2 = "row2";
            BigtableByteString key3 = "row3";
            BigtableByteString lastScannedKey = "row1a";

            ReadRowsRequest originalRequest = CreateRowKeysRequest(key1, key2, key3);

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);

            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = lastScannedKey;

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
            fullRowSet.RowRanges.Add(new[]
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

            ReadRowsRequest originalRequestClone = originalRequest.Clone();

            // Assert that originalRequest and originalRequestClone are different objects.
            Assert.False(ReferenceEquals(originalRequest, originalRequestClone));
            // Assert that originalRequest and originalRequestClone have same value before calling BuildUpdatedRequest.
            Assert.Equal(originalRequest, originalRequestClone);

            Assert.Equal(filteredRequest, underTest.BuildUpdatedRequest());

            // Assert that BuildUpdatedRequest did not modify the original RowSet.
            Assert.Equal(originalRequest, originalRequestClone);
        }

        /// <summary>
        /// Test multiple rowset filter scenarios for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// with with <see cref="BigtableReadRowsRequestManager.LastFoundKey"/> in between key1 and key2.
        /// </summary>
        [Fact]
        public void TestFilterRowsRowRangesKeyInMiddle()
        {
            BigtableByteString key1 = "row1";
            BigtableByteString key2 = "row2";
            BigtableByteString key3 = "row3";
            BigtableByteString lastFoundKey = "row1a";

            RowSet fullRowSet = RowSet.FromRowKeys(key1, key2, key3);
            fullRowSet.RowRanges.Add(new[]
            {
                RowRange.OpenClosed(null, key1), // should be filtered out
                RowRange.Open(null, key1), // should be filtered out
                RowRange.Open(key1, key2), // should be converted (lastFoundKey, key2)
                RowRange.ClosedOpen(key1, key2), // should be converted (lastFoundKey, key2)
                RowRange.Closed(key1, key2), // should be converted (lastFoundKey, key2]
                RowRange.Open(key2, key3), // should stay
                RowRange.ClosedOpen(key2, key3) // should stay
            });

            RowSet filteredRowSet = RowSet.FromRowKeys(key2, key3);
            filteredRowSet.RowRanges.Add(new[]
            {
                RowRange.Open(lastFoundKey, key2), // should be converted (lastFoundKey, key2)
                RowRange.Open(lastFoundKey, key2), // should be converted (lastFoundKey, key2)
                RowRange.OpenClosed(lastFoundKey, key2), // should be converted (lastFoundKey, key2]
                RowRange.Open(key2, key3), // should stay
                RowRange.ClosedOpen(key2, key3)// should stay
            });

            ReadRowsRequest originalRequest = new ReadRowsRequest { Rows = fullRowSet };
            ReadRowsRequest filteredRequest = new ReadRowsRequest { Rows = filteredRowSet };
            
            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = lastFoundKey;

            ReadRowsRequest originalRequestClone = originalRequest.Clone();

            // Assert that originalRequest and originalRequestClone are different objects.
            Assert.False(ReferenceEquals(originalRequest, originalRequestClone));
            // Assert that originalRequest and originalRequestClone have same value before calling BuildUpdatedRequest.
            Assert.Equal(originalRequest, originalRequestClone);

            Assert.Equal(filteredRequest, underTest.BuildUpdatedRequest());

            // Assert that BuildUpdatedRequest did not modify the original RowSet.
            Assert.Equal(originalRequest, originalRequestClone);
        }

        /// <summary>
        /// Test rows limit only request scenario for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// </summary>
        [Fact]
        public void TestRowsLimitOnlyRequest()
        {
            BigtableByteString lastFoundKey = "row015";

            ReadRowsRequest originalRequest = new ReadRowsRequest { RowsLimit = 1000 };

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = lastFoundKey;
            underTest.IncrementRowsReadSoFar(10);

            ReadRowsRequest updatedRequest = CreateRowRangeRequest(RowRange.Open(lastFoundKey, null));
            updatedRequest.RowsLimit = 990;
            Assert.Equal(updatedRequest, underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test request with no parameters scenario for <see cref="BigtableReadRowsRequestManager.BuildUpdatedRequest()"/>
        /// </summary>
        [Fact]
        public void TestDefaultRequest()
        {
            BigtableByteString lastFoundKey = "row015";

            ReadRowsRequest originalRequest = new ReadRowsRequest ();

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());
            underTest.LastFoundKey = lastFoundKey;

            Assert.Equal(CreateRowRangeRequest(RowRange.Open(lastFoundKey, null)), underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// For this test we will assume that the table contains sequentially numbered rowkeys from "row000" to "row999"
        /// </summary>
        [Fact]
        public void TestRowsLimit()
        {
            BigtableByteString startKeyOpenOriginal = "row050";
            BigtableByteString lastFoundKey = "row125";
            ReadRowsRequest originalRequest = CreateRowRangeRequest(RowRange.OpenClosed(startKeyOpenOriginal, null));
            originalRequest.RowsLimit = 100;

            ReadRowsRequest updatedRequest = CreateRowRangeRequest(RowRange.OpenClosed(lastFoundKey, null));
            updatedRequest.RowsLimit = 25;

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            Assert.Equal(originalRequest, underTest.BuildUpdatedRequest());

            underTest.LastFoundKey = lastFoundKey;
            underTest.IncrementRowsReadSoFar(75);
            Assert.Equal(updatedRequest, underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test that resume handles row ranges as unsigned bytes.
        /// </summary>
        [Fact]
        public void TestFilterRowsUnsignedRange()
        {
            BigtableByteString key1 = new byte[] { 0x7f };
            BigtableByteString key2 = new byte[] { 0x80 };

            ReadRowsRequest originalRequest = CreateRowRangeRequest(RowRange.ClosedOpen(key1, null));

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            underTest.LastFoundKey = key2;

            Assert.Equal(CreateRowRangeRequest(RowRange.Open(key2, null)),
                underTest.BuildUpdatedRequest());
        }

        /// <summary>
        /// Test that resume handles key requests as unsigned bytes.
        /// </summary>
        [Fact]
        public void TestFilterRowsUnsignedRows()
        {
            BigtableByteString key1 = new byte[] { 0x7f };
            BigtableByteString key2 = new byte[] { 0x80 };

            ReadRowsRequest originalRequest = CreateRowKeysRequest(key1, key2);

            BigtableReadRowsRequestManager underTest = new BigtableReadRowsRequestManager(originalRequest);
            underTest.LastFoundKey = key1;

            Assert.Equal(CreateRowKeysRequest(key2), underTest.BuildUpdatedRequest());
        }
    }
}
