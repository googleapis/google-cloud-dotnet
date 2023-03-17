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

using Google.Cloud.Firestore.V1;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class SentinelValueTest
    {
        [Fact]
        public void ArrayRemove()
        {
            var sentinel = FieldValue.ArrayRemove("a", 1);
            var value = ValueSerializer.Serialize(SerializationContext.Default, sentinel);
            Assert.Equal(SentinelKind.ArrayRemove, SentinelValue.GetKind(value));
            var array = SentinelValue.GetArrayValue(value);
            var expected = CreateArray(CreateValue("a"), CreateValue(1)).ArrayValue;
            Assert.Equal(expected, array);
        }

        [Fact]
        public void ArrayUnion()
        {
            var sentinel = FieldValue.ArrayUnion("a", "b");
            var value = ValueSerializer.Serialize(SerializationContext.Default, sentinel);
            Assert.Equal(SentinelKind.ArrayUnion, SentinelValue.GetKind(value));
            var array = SentinelValue.GetArrayValue(value);
            var expected = CreateArray(CreateValue("a"), CreateValue("b")).ArrayValue;
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Increment_Int64()
        {
            var sentinel = FieldValue.Increment(100L);
            var value = ValueSerializer.Serialize(SerializationContext.Default, sentinel);
            Assert.Equal(SentinelKind.NumericIncrement, SentinelValue.GetKind(value));
            var increment = SentinelValue.GetIncrement(value);
            var expected = new Value { IntegerValue = 100L };
            Assert.Equal(expected, increment);
        }

        [Fact]
        public void Increment_Double()
        {
            var sentinel = FieldValue.Increment(12.5);
            var value = ValueSerializer.Serialize(SerializationContext.Default, sentinel);
            Assert.Equal(SentinelKind.NumericIncrement, SentinelValue.GetKind(value));
            var increment = SentinelValue.GetIncrement(value);
            var expected = new Value { DoubleValue = 12.5 };
            Assert.Equal(expected, increment);
        }
    }
}
