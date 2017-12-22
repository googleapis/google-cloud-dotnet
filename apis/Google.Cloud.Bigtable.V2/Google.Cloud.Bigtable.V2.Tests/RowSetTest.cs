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
    public class RowSetTest
    {
        [Fact]
        public void FromRowKey()
        {
            var set = RowSet.FromRowKey("a");
            Assert.Equal(new[] { ByteString.CopyFromUtf8("a") }, set.RowKeys);
            Assert.Equal(0, set.RowRanges.Count);
        }

        [Fact]
        public void FromRowKeys_Valid()
        {
            var set = RowSet.FromRowKeys("a", "z");
            Assert.Equal(new[] { ByteString.CopyFromUtf8("a"), ByteString.CopyFromUtf8("z") }, set.RowKeys);
            Assert.Equal(0, set.RowRanges.Count);
        }

        [Fact]
        public void FromRowKeys_Invalid()
        {
            Assert.Throws<ArgumentNullException>(() => RowSet.FromRowKeys(null));
        }

        [Fact]
        public void FromRowRanges_Valid()
        {
            var set = RowSet.FromRowRanges(RowRange.Closed("a", "d"), RowRange.Open("x", "z"));
            Assert.Equal(0, set.RowKeys.Count);
            Assert.Equal(new[] { RowRange.Closed("a", "d"), RowRange.Open("x", "z") }, set.RowRanges);
        }

        [Fact]
        public void FromRowRanges_Invalid()
        {
            Assert.Throws<ArgumentNullException>(() => RowSet.FromRowRanges(null));
            Assert.Throws<ArgumentException>(() => RowSet.FromRowRanges(RowRange.Closed("a", "z"), null));
        }
    }
}
