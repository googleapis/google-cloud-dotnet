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

using Google.Cloud.Firestore.V1;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    // Just tests for WriteBatch.ApplyFieldMask
    public partial class WriteBatchTest
    {
        [Fact]
        public void ApplyFieldMask_Simple()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateValue(10) },
                { "b", CreateValue("kept") },
                { "c", CreateValue("removed") }
            };
            var mask = CreateMask("a", "b");
            var expected = new Dictionary<FieldPath, Value>
            {
                { new FieldPath("a"), CreateValue(10) },
                { new FieldPath("b"), CreateValue("kept") },
            };
            var actual = WriteBatch.ApplyFieldMask(fields, mask);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ApplyFieldMask_WholeMapIncluded()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateMap(("b", CreateValue(10)), ("c", CreateValue("kept"))) },
                { "d", CreateValue("removed") }
            };
            var mask = CreateMask("a");
            var expected = new Dictionary<FieldPath, Value>
            {
                { new FieldPath("a"), CreateMap(("b", CreateValue(10)), ("c", CreateValue("kept"))) },
            };
            var actual = WriteBatch.ApplyFieldMask(fields, mask);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ApplyFieldMask_WholeMapAndMapField()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateMap(("b", CreateValue(10)), ("c", CreateValue("kept"))) },
                { "d", CreateValue("removed") }
            };
            // The a.b value is effectively redundant here, because we've already got "a".
            var mask = CreateMask("a", "a.b");
            var expected = new Dictionary<FieldPath, Value>
            {
                { new FieldPath("a"), CreateMap(("b", CreateValue(10)), ("c", CreateValue("kept"))) },
            };
            var actual = WriteBatch.ApplyFieldMask(fields, mask);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ApplyFieldMask_MapFieldsIncluded()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateMap(("b", CreateValue(10)), ("c", CreateValue("kept")), ("d", CreateValue("removed"))) },
                { "e", CreateValue("removed") }
            };
            var mask = CreateMask("a.b", "a.c");
            var expected = new Dictionary<FieldPath, Value>
            {
                { new FieldPath("a", "b"), CreateValue(10) },
                { new FieldPath("a", "c"), CreateValue("kept") },
            };
            var actual = WriteBatch.ApplyFieldMask(fields, mask);
            Assert.Equal(expected, actual);
        }

        private static IEnumerable<FieldPath> CreateMask(params string[] paths) =>
            paths.Select(FieldPath.FromDotSeparatedString);
    }
}
