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
using System.IO;
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
            var deserialized = DeserializeDefault(value, typeof(Value));
            // We should get a clone back.
            Assert.NotSame(value, deserialized);
            Assert.Equal(value, deserialized);
        }

        [Fact]
        public void DeserializeToValue()
        {
            var value = new Value { DoubleValue = 1.234 };
            var deserialized = DeserializeDefault(value, typeof(Value));
            // We should get a clone back.
            Assert.NotSame(value, deserialized);
            Assert.Equal(value, deserialized);
        }

        // These three classes exist for testing unknown property handling
        [FirestoreData(UnknownPropertyHandling.Ignore)]
        internal class IgnoreUnknownResult { }

        [FirestoreData(UnknownPropertyHandling.Warn)]
        internal class WarnUnknownResult { }

        [FirestoreData(UnknownPropertyHandling.Throw)]
        internal class ThrowUnknownResult { }

        [FirestoreData]
        internal class DefaultUnknownResult { }

        [FirestoreData(UnknownPropertyHandling.Warn)]
        internal class NonPublicProperties
        {
            [FirestoreProperty]
            internal string InternalProperty { get; set; }

            [FirestoreProperty]
            internal string PrivateProperty { get; set; }

            // Note: not a FirestoreProperty
            public string PublicAccessToPrivateProperty
            {
                get => PrivateProperty;
                set => PrivateProperty = value;
            }
        }

        [Fact]
        public void Deserialize_UnknownProperty_Ignore()
        {
            var value = new { Missing = "xyz" };
            string log = DeserializeAndReturnWarnings<IgnoreUnknownResult>(value);
            Assert.Null(log);
        }

        [Fact]
        public void Deserialize_UnknownProperty_Warn()
        {
            var value = new { Missing = "xyz" };
            string log = DeserializeAndReturnWarnings<WarnUnknownResult>(value);
            Assert.Contains(nameof(value.Missing), log);
            Assert.Contains(nameof(WarnUnknownResult), log);
        }

        [Fact]
        public void Deserialize_UnknownProperty_Default()
        {
            var value = new { Missing = "xyz" };
            string log = DeserializeAndReturnWarnings<DefaultUnknownResult>(value);
            Assert.Contains(nameof(value.Missing), log);
            Assert.Contains(nameof(DefaultUnknownResult), log);
        }

        [Fact]
        public void Deserialize_UnknownProperty_Throw()
        {
            Assert.Throws<ArgumentException>(() => DeserializeAndReturnWarnings<ThrowUnknownResult>(new { Missing = "xyz" }));
        }

        [Fact]
        public void RoundTrip_NonPublicProperties()
        {
            var poco = new NonPublicProperties
            {
                InternalProperty = "x",
                PublicAccessToPrivateProperty = "y"
            };
            var value = ValueSerializer.Serialize(poco);
            // Just verify that we're not using the public property directly...
            Assert.True(value.MapValue.Fields.ContainsKey("PrivateProperty"));
            Assert.False(value.MapValue.Fields.ContainsKey("PublicAccessToPrivateProperty"));
            var deserialized = (NonPublicProperties) DeserializeDefault(value, typeof(NonPublicProperties));
            Assert.Equal("x", deserialized.InternalProperty);
            Assert.Equal("y", deserialized.PublicAccessToPrivateProperty);
        }

        [Fact]
        public void DeserializePrivateConstructor()
        {
            var original = PrivateConstructor.Create("test", 15);
            var value = ValueSerializer.Serialize(original);
            Assert.Equal("test", value.MapValue.Fields["Name"].StringValue);
            Assert.Equal(15L, value.MapValue.Fields["Value"].IntegerValue);

            var deserialized = (PrivateConstructor) DeserializeDefault(value, typeof(PrivateConstructor));
            Assert.Equal("test", deserialized.Name);
            Assert.Equal(15, deserialized.Value);
        }
        
        private string DeserializeAndReturnWarnings<T>(object valueToSerialize)
        {
            var value = ValueSerializer.Serialize(valueToSerialize);
            string warning = null;
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient()).WithWarningLogger(Log);
            ValueDeserializer.Default.Deserialize(db, value, typeof(T));
            return warning;

            void Log(string message)
            {
                if (warning != null)
                {
                    throw new InvalidOperationException("Multiple warnings logged unexpectedly");
                }
                Assert.NotNull(message);
                warning = message;
            }
        }

        // Just a convenience method to avoid having to specify all of this on each call.
        private static object DeserializeDefault(Value value, BclType targetType) =>
            ValueDeserializer.Default.Deserialize(SerializationTestData.Database, value, targetType);

        /// <summary>
        /// An interface that we can't deserialize to, because Dictionary{,} doesn't implement it.
        /// </summary>
        public interface IUnsupportedDictionary : IDictionary<string, string> { }

        [FirestoreData]
        private class PrivateConstructor
        {
            [FirestoreProperty]
            public string Name { get; private set; }

            [FirestoreProperty]
            public int Value { get; private set; }

            private PrivateConstructor()
            {
            }

            public static PrivateConstructor Create(string name, int value) =>
                new PrivateConstructor { Name = name, Value = value };
        }
    }
}
