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
    public class SetOptionsTest
    {
        [Fact]
        public void MergeAll()
        {
            var options = SetOptions.MergeAll;
            Assert.Empty(options.FieldMask);
            Assert.True(options.Merge);
        }

        [Fact]
        public void Overwrite()
        {
            var options = SetOptions.Overwrite;
            Assert.Empty(options.FieldMask);
            Assert.False(options.Merge);
        }



        [Fact]
        public void MergeFields_Strings_Valid()
        {
            var options = SetOptions.MergeFields("a.b", "c");
            Assert.Equal(new[] { new FieldPath("a", "b"), new FieldPath("c") }, options.FieldMask);
            Assert.True(options.Merge);
        }

        [Fact]
        public void MergeFields_Strings_Empty()
        {
            var options = SetOptions.MergeFields(new string[0]);
            Assert.Empty(options.FieldMask);
            Assert.True(options.Merge);
        }

        [Theory]
        [InlineData("")]
        [InlineData("x", null)]
        [InlineData("x", "")]
        public void MergeFields_Strings_Invalid(params string[] fieldPaths)
        {
            Assert.Throws<ArgumentException>(() => SetOptions.MergeFields(fieldPaths));
        }

        [Fact]
        public void MergeFields_FieldPaths_Valid()
        {
            var path1 = new FieldPath("a", "b");
            var path2 = new FieldPath("c");
            var options = SetOptions.MergeFields(path1, path2);
            Assert.Equal(new[] { path1, path2 }, options.FieldMask);
            Assert.True(options.Merge);
        }

        [Fact]
        public void MergeFields_FieldPaths_Empty()
        {
            var options = SetOptions.MergeFields(new FieldPath[0]);
            Assert.Empty(options.FieldMask);
            Assert.True(options.Merge);
        }

        [Fact]
        public void MergeFields_FieldPaths_Invalid()
        {
            Assert.Throws<ArgumentNullException>(() => SetOptions.MergeFields((FieldPath[]) null));
            Assert.Throws<ArgumentException>(() => SetOptions.MergeFields((FieldPath) null));
            Assert.Throws<ArgumentException>(() => SetOptions.MergeFields(null, new FieldPath("a")));
        }

        [Fact]
        public void MergeFields_Immutable()
        {
            var path1 = new FieldPath("a", "b");
            var path2 = new FieldPath("c");
            var pathArray = new[] { path1, path2 };
            var options = SetOptions.MergeFields(pathArray);
            pathArray[0] = new FieldPath("d");
            // Modifying the array doesn't modify the options
            Assert.Equal(new[] { path1, path2 }, options.FieldMask);
        }
    }
}
