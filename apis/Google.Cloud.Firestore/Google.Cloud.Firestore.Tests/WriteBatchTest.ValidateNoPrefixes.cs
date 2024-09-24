// Copyright 2017, Google Inc. All rights reserved.
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


using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    // Just tests for WriteBatch.ValidateNoPrefixes
    public partial class WriteBatchTest
    {
        public static TheoryData<IEnumerable<FieldPath>> ValidPathSets = new TheoryData<IEnumerable<FieldPath>>
        {
            SplitPaths("a", "b"),
            SplitPaths("a.b", "b"),
            SplitPaths("a.b", "a.c"),
            SplitPaths("a.b.c", "a.b.d", "a.c"),
            SplitPaths("a.b", "b.c"),
            SplitPaths("ab.b", "b"),
        };

        public static TheoryData<IEnumerable<FieldPath>> InvalidPathSets = new TheoryData<IEnumerable<FieldPath>>
        {
            SplitPaths("a", "a.b"),
            SplitPaths("a", "a.b.c"),
            SplitPaths("a.b", "a.b.c")
        };

        private static FieldPath[] SplitPaths(params string[] paths) =>
            paths.Select(p => FieldPath.FromDotSeparatedString(p)).ToArray();

        [Theory]
        [MemberData(nameof(ValidPathSets))]
        public void ValidateNoPrefixes_Valid(IEnumerable<FieldPath> paths)
        {
            WriteBatch.ValidateNoPrefixes(paths);
            WriteBatch.ValidateNoPrefixes(paths.Reverse());
        }

        [Theory]
        [MemberData(nameof(InvalidPathSets))]
        public void ValidateNoPrefixes_Invalid(IEnumerable<FieldPath> paths)
        {
            Assert.Throws<ArgumentException>(() => WriteBatch.ValidateNoPrefixes(paths));
            Assert.Throws<ArgumentException>(() => WriteBatch.ValidateNoPrefixes(paths.Reverse()));
        }
    }
}
