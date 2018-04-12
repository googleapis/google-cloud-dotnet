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
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class PathUtilitiesTest
    {
        [Fact]
        public void GenerateId()
        {
            var generatedIds = new HashSet<string>();
            for (int i = 0; i < 1000; i++)
            {
                string id = PathUtilities.GenerateId();
                // It should be incredibly rare that we'd generate duplicates
                Assert.False(!generatedIds.Add(id));
                Assert.Matches("[A-Za-z0-9]{20}", id);
            }
            // TODO: Check the frequency of each character is reasonable?
        }

        [Theory]
        [InlineData("/")]
        [InlineData("")]
        [InlineData("a/b")]
        public void ValidateId_Invalid(string id)
        {
            Assert.Throws<ArgumentException>(() => PathUtilities.ValidateId(id, nameof(id)));
        }

        [Theory]
        [InlineData("foo")]
        [InlineData("a.b")]
        [InlineData("a-b")]
        public void ValidateId_Valid(string id)
        {
            PathUtilities.ValidateId(id, nameof(id));
        }

        [Theory]
        [InlineData("foo/bar/baz", "foo", "bar", "baz")]
        [InlineData("foo", "foo")]
        public void SplitPath_Valid(string path, params string[] expectedSegments)
        {
            var actual = PathUtilities.SplitPath(path);
            Assert.Equal(expectedSegments, actual);
        }

        [Theory]
        [InlineData("")]
        [InlineData("/")]
        [InlineData("/foo")]
        [InlineData("foo/")]
        [InlineData("foo//bar")]
        public void SplitPath_Invalid(string path)
        {
            Assert.Throws<ArgumentException>(() => PathUtilities.SplitPath(path));
        }
    }
}
