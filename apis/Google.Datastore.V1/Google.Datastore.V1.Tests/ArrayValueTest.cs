// Copyright 2016 Google Inc. All Rights Reserved.
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
using Xunit;

namespace Google.Datastore.V1.Tests
{
    public class ArrayValueTest
    {
        // We don't test for every single type, as it would be a waste of time - the implementation is the same for everything,
        // so we just have tests for one reference type, one non-nullable value type, and one nullable value type.

        [Fact]
        public void ConversionToArrayValue_Simple()
        {
            Assert.Equal(new ArrayValue { Values = { "a", "b" } }, new[] { "a", "b" });
            Assert.Equal(new ArrayValue { Values = { 1, 2 } }, new long[] { 1, 2 });
            Assert.Equal(new ArrayValue { Values = { 1, 2 } }, new long?[] { 1, 2 });
        }

        [Fact]
        public void ConversionToArrayValue_NullInputArray()
        {
            Assert.Null((ArrayValue) (string[]) null);
            Assert.Null((ArrayValue) (long[])null);
            Assert.Null((ArrayValue) (long?[])null);
        }

        [Fact]
        public void ConversionToArrayValue_NullElements()
        {
            Assert.Equal(new ArrayValue { Values = { Value.ForNull(), "b" } }, new[] { null, "b" });
            Assert.Equal(new ArrayValue { Values = { Value.ForNull(), 2 } }, new long?[] { null, 2 });
        }
    }
}
