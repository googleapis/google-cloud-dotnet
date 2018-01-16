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

using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Collections.Generic;
using System.Dynamic;
using Xunit;
using BclType = System.Type;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests
{
    // Note: deliberately not using the CreateValue helper to make the protos absolutely clear.

    public class ValueDeserializerTest
    {
        [Theory]
        [MemberData(nameof(SerializationTestData.BclAndValues), MemberType = typeof(SerializationTestData))]
        public void Deserialize(object bclValue, Value serializedValue)
        {
            BclType targetType = bclValue?.GetType() ?? typeof(object);
            var deserialized = DeserializeDefault(serializedValue, targetType);
            Assert.Equal(bclValue, deserialized);
        }

        [Fact]
        public void DeserializeToExpando()
        {
            var value = new Value { MapValue = new MapValue { Fields = { { "name", new Value { StringValue = "Jon" } }, { "score", new Value { IntegerValue = 10L } } } } };
            var result = ValueDeserializer.Expando.Deserialize(SerializationTestData.Database, value, typeof(object));
            Assert.IsType<ExpandoObject>(result);
            dynamic expected = new ExpandoObject();
            expected.name = "Jon";
            expected.score = 10L;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DeserializeToObjectDictionary()
        {
            var value = new Value { MapValue = new MapValue { Fields = { { "name", new Value { StringValue = "Jon" } }, { "score", new Value { IntegerValue = 10L } } } } };
            var result = ValueDeserializer.Dictionary.Deserialize(SerializationTestData.Database, value, typeof(object));
            Assert.IsType<Dictionary<string, object>>(result);
            var expected = new Dictionary<string, object>
            {
                ["name"] = "Jon",
                ["score"] = 10L
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DeserializeToSpecificDictionary()
        {
            var value = new Value { MapValue = new MapValue { Fields = { { "x", new Value { IntegerValue = 10L } }, { "y", new Value { IntegerValue = 20L } } } } };
            var result = ValueDeserializer.Dictionary.Deserialize(SerializationTestData.Database, value, typeof(Dictionary<string, int>));
            Assert.IsType<Dictionary<string, int>>(result);
            var expected = new Dictionary<string, int>
            {
                ["x"] = 10,
                ["y"] = 20
            };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(typeof(byte))]
        [InlineData(typeof(sbyte))]
        [InlineData(typeof(short))]
        [InlineData(typeof(ushort))]
        [InlineData(typeof(int))]
        [InlineData(typeof(uint))]
        [InlineData(typeof(ulong))]
        public void IntegerOverflow(BclType targetType)
        {
            var minLong = new Value { IntegerValue = long.MinValue };
            Assert.Throws<OverflowException>(() => DeserializeDefault(minLong, targetType));
        }

        public static IEnumerable<object[]> InvalidDeserializationCalls = new List<object[]>
        {
            // Inappropriate target types
            { new Value { IntegerValue = 10L }, typeof(string) },
            { new Value { ArrayValue = new ArrayValue() }, typeof(string) },
            { new Value { MapValue = new MapValue() }, typeof(string) },
            { new Value { MapValue = new MapValue() }, typeof(IUnsupportedDictionary) }, // See below
            // Invalid original value
            { new Value(), typeof(object) },
            { ValueSerializer.Serialize(new { Missing = "Surprise!" }), typeof(SerializationTestData.GameResult) },
            { new Value { NullValue = wkt::NullValue.NullValue }, typeof(int) },
            { new Value { NullValue = wkt::NullValue.NullValue }, typeof(Guid) },
            { new Value { NullValue = wkt::NullValue.NullValue }, typeof(Blob) }
        };

        [Theory]
        [MemberData(nameof(InvalidDeserializationCalls))]
        public void Deserialize_Invalid(Value value, BclType targetType)
        {
            Assert.Throws<ArgumentException>(() => DeserializeDefault(value, targetType));
        }

        [Fact]
        public void DeserializeArrayToObjectUsesList()
        {
            var value = ValueSerializer.Serialize(new[] { 1, 2 });
            var deserialized = DeserializeDefault(value, typeof(object));
            Assert.IsType<List<object>>(deserialized);
            Assert.Equal(new List<object> { 1L, 2L }, deserialized);
        }

        [Theory]
        [InlineData(typeof(int?))]
        [InlineData(typeof(string))]
        [InlineData(typeof(SerializationTestData.GameResult))]
        public void DeserializeNull(BclType targetType)
        {
            var value = new Value { NullValue = wkt::NullValue.NullValue };
            Assert.Null(DeserializeDefault(value, targetType));
        }

        [Fact]
        public void DeserializeNullToValue()
        {
            var value = new Value { NullValue = wkt::NullValue.NullValue };
            Assert.Same(value, DeserializeDefault(value, typeof(Value)));
        }

        [Fact]
        public void DeserializeToValue()
        {
            var value = new Value { DoubleValue = 1.234 };
            Assert.Same(value, DeserializeDefault(value, typeof(Value)));
        }

        // Just a convenience method to avoid having to specify all of this on each call.
        private static object DeserializeDefault(Value value, BclType targetType) =>
            ValueDeserializer.Default.Deserialize(SerializationTestData.Database, value, targetType);

        /// <summary>
        /// An interface that we can't deserialize to, because Dictionary{,} doesn't implement it.
        /// </summary>
        public interface IUnsupportedDictionary : IDictionary<string, string> { }
    }
}
