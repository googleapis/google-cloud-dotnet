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
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    // Just tests for WriteBatch.ExtractDocumentMask
    public partial class WriteBatchTest
    {
        [Fact]
        public void ExtractDocumentMask_Simple()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateValue(10) },
                { "b", CreateValue("text") },
                { "c", CreateNullValue() }
            };
            var mask = WriteBatch.ExtractDocumentMask(fields);

            AssertFieldMask(mask, "a", "b", "c");
        }

        [Fact]
        public void ExtractDocumentMask_DottedFields()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a.b", CreateValue(10) },
                { "c.d", CreateValue("text") },
            };
            var mask = WriteBatch.ExtractDocumentMask(fields);

            AssertFieldMask(mask, "`a.b`", "`c.d`");
        }

        [Fact]
        public void ExtractDocumentMask_Map()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateMap(("b", CreateValue(10)), ("c", CreateValue("text"))) },
                { "d", CreateValue(10) },
            };
            var mask = WriteBatch.ExtractDocumentMask(fields);

            AssertFieldMask(mask, "a.b", "a.c", "d");
        }

        [Fact]
        public void ExtractDocumentMask_NestedMap()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateMap(("b", CreateValue(10)), ("c", CreateMap("d", CreateValue(10)))) },
                { "e", CreateValue(10) },
            };
            var mask = WriteBatch.ExtractDocumentMask(fields);

            AssertFieldMask(mask, "a.b", "a.c.d", "e");
        }

        [Fact]
        public void ExtractDocumentMask_EmptyMap()
        {
            var fields = new Dictionary<string, Value>
            {
                { "a", CreateMap(("b", CreateValue(10)), ("c", CreateMap())) },
                { "d", CreateMap() },
                { "e", CreateValue(10) },
            };
            var mask = WriteBatch.ExtractDocumentMask(fields);

            AssertFieldMask(mask, "a.b", "e");
        }

        private static void AssertFieldMask(IReadOnlyList<FieldPath> mask, params string[] expectedEncodedPaths)
        {
            var actualEncodedPaths = mask.Select(fp => fp.EncodedPath).OrderBy(x => x, StringComparer.Ordinal).ToList();
            Assert.Equal(expectedEncodedPaths.OrderBy(x => x, StringComparer.Ordinal), actualEncodedPaths);
        }
    }
}