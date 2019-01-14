// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class FieldMaskTest
    {
        [Fact]
        public void Equality()
        {
            EqualityTester.AssertEqual(new FieldMask("a", "b"),
                new[] { new FieldMask("a", "b", "b"), new FieldMask(new FieldPath("a"), new FieldPath("b")) },
                new[] { new FieldMask("a"), new FieldMask("a", "c"), new FieldMask("a", "b", "c") });
        }

        [Fact]
        public void InvalidConstruction()
        {
            Assert.Throws<ArgumentNullException>(() => new FieldMask((FieldPath[]) null));
            Assert.Throws<ArgumentNullException>(() => new FieldMask((string[]) null));
            Assert.Throws<ArgumentException>(() => new FieldMask((string) null));
            Assert.Throws<ArgumentException>(() => new FieldMask(""));
            Assert.Throws<ArgumentException>(() => new FieldMask("a~b"));
            Assert.Throws<ArgumentException>(() => new FieldMask((FieldPath) null));
        }

        [Fact]
        public void ToProto()
        {
            var mask = new FieldMask("b", @"a.c\d", "a");
            Assert.Equal(new DocumentMask { FieldPaths = { "a", @"a.`c\\d`", "b" } }, mask.ToProto());
        }
    }
}
