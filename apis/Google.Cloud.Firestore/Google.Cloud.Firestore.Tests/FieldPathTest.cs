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

using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.Firestore.Tests
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
            FieldPath original = new FieldPath("a", "b.c");
            FieldPath expected = new FieldPath("a", "b.c", "d.e");
            FieldPath actual = original.Append("d.e");
            Assert.Equal(expected, actual);
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
            var control = new FieldPath("a", "b");
            var equal = new[] { new FieldPath("a", "b"), FieldPath.FromDotSeparatedString("a.b") };
            var unequal = new[] { new FieldPath("a", "c") };
            EqualityTester.AssertEqual(control, equal, unequal);
        }

        [Theory]
        [InlineData("a", "a.b", true)]
        [InlineData("a", "a.b.c", true)]
        [InlineData("a", "a", true)]
        [InlineData("a.b", "a", false)]
        [InlineData("a", "b", false)]
        [InlineData("a", "b.c", false)]
        public void IsPrefix(string path1, string path2, bool expected)
        {
            var fp1 = FieldPath.FromDotSeparatedString(path1);
            var fp2 = FieldPath.FromDotSeparatedString(path2);
            Assert.Equal(expected, fp1.IsPrefixOf(fp2));
        }

        [Fact]
        public void Ordering()
        {
            var paths = new[]
            {
                FieldPath.Empty,
                new FieldPath("a"),
                new FieldPath("a", "b"),
                new FieldPath("a", "b", "b"),
                new FieldPath("a", "b", "ba"),
                new FieldPath("a", "b", "c"),
                new FieldPath("b", "a"),
            };

            for (int i = 0; i < paths.Length; i++)
            {
                for (int j = i + 1; j < paths.Length; j++)
                {
                    // This will also compare field paths with themselves
                    ComparisonTester.AssertComparison(paths[i], paths[j]);
                }
            }
        }
    }
}
