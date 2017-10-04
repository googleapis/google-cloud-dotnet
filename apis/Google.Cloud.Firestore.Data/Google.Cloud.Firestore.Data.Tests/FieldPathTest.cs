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
using Xunit;

namespace Google.Cloud.Firestore.Data.Tests
{
    public class FieldPathTest
    {
        [Theory]
        [InlineData("h", "h")]
        [InlineData("h.g", "h.g")]
        public void FromDotSeparatedString(string expectedEncodedPath, string input)
        {
            FieldPath path = FieldPath.FromDotSeparatedString(input);
            Assert.Equal(expectedEncodedPath, path.EncodedPath);
        }

        [Theory]
        [InlineData("")]
        [InlineData(".")]
        [InlineData("x..y")]
        [InlineData(".x")]
        [InlineData("x.")]
        [InlineData("a~b")]
        [InlineData("a*b")]
        [InlineData("a/b")]
        [InlineData("a[b")]
        [InlineData("a]b")]
        public void FromDotSeparatedString_Invalid(string value)
        {
            Assert.Throws<ArgumentException>(() => FieldPath.FromDotSeparatedString(value));
        }

        [Theory]
        [InlineData("h.g", "h", "g")]
        [InlineData("`h.g`", "h.g")]
        [InlineData("`-x`", "-x")]
        [InlineData(@"`a\\b`", @"a\b")]
        [InlineData(@"`a\`b`", @"a`b")]
        public void EncodedPath(string expectedEncodedPath, params string[] fieldNames)
        {
            var path = new FieldPath(fieldNames);
            Assert.Equal(expectedEncodedPath, path.EncodedPath);
            Assert.Equal(expectedEncodedPath, path.ToString());
        }

        [Fact]
        public void Append()
        {
            FieldPath path1 = new FieldPath("a", "b.c");
            FieldPath path2 = new FieldPath("d.e", "f");
            Assert.Equal(new FieldPath("a", "b.c", "d.e", "f"), path1.Append(path2));
        }

        [Theory]
        [InlineData("h", "")]
        [InlineData("h", null)]
        [InlineData()]
        public void Constructor_Invalid(params string[] segments)
        {
            Assert.Throws<ArgumentException>(() => new FieldPath(segments));
        }

        [Fact]
        public void ArrayIsCopied()
        {
            string[] segments = { "a", "b" };
            var path = new FieldPath(segments);
            segments[0] = "changed";
            Assert.Equal("a", path.Segments[0]);
            Assert.Equal("a.b", path.EncodedPath);
        }

        [Fact]
        public void Equality()
        {
            var path1 = new FieldPath("a", "b");
            var path2 = new FieldPath("a", "b");
            var path3 = FieldPath.FromDotSeparatedString("a.b");
            var path4 = new FieldPath("a", "c");
            // Equals(FieldPath)
            Assert.True(path1.Equals(path2));
            Assert.True(path1.Equals(path3));
            Assert.False(path1.Equals(path4));

            // Equals(object)
            Assert.True(path1.Equals((object) path2));
            Assert.True(path1.Equals((object) path3));
            Assert.False(path1.Equals((object) path4));

            Assert.Equal(path1.GetHashCode(), path2.GetHashCode());
            Assert.Equal(path1.GetHashCode(), path3.GetHashCode());
            Assert.NotEqual(path1.GetHashCode(), path4.GetHashCode());
        }
    }
}
