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
using System.Dynamic;
using System.IO;
using Xunit;
using BclType = System.Type;
using WKT = Google.Protobuf.WellKnownTypes;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;
using System.Collections;
using System.Linq;

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
            dynamic result = ValueDeserializer.Deserialize(SerializationTestData.Context, value, typeof(ExpandoObject));
            Assert.Equal("Jon", result.name);
            Assert.Equal(10L, result.score);
        }

        [Fact]
        public void DeserializeToObjectDictionary()
        {
            var value = new Value { MapValue = new MapValue { Fields = { { "name", new Value { StringValue = "Jon" } }, { "score", new Value { IntegerValue = 10L } } } } };
            var result = ValueDeserializer.Deserialize(SerializationTestData.Context, value, typeof(object));
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
            var result = ValueDeserializer.Deserialize(SerializationTestData.Context, value, typeof(Dictionary<string, int>));
            Assert.IsType<Dictionary<string, int>>(result);
            var expected = new Dictionary<string, int>
            {
                ["x"] = 10,
                ["y"] = 20
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DeserializeCustomTypeConversion()
        {
            var value = new Value
            {
                MapValue = new MapValue
                {
                    Fields =
                    {
                        { "Name", new Value { StringValue = "test" } },
                        { "HighScore", new Value { IntegerValue = 10L } },
                        { "Email", new Value { StringValue = "test@example.com" } },
                    }
                }
            };
            var user = (SerializationTestData.CustomUser) DeserializeDefault(value, typeof(SerializationTestData.CustomUser));
            Assert.Equal("test", user.Name);
            Assert.Equal(10, user.HighScore);
            Assert.Equal("test@example.com", user.Email.Address);
        }

        [Fact]
        public void DeserializeCustomPropertyConversion_NoNulls()
        {
            Guid guid1 = Guid.NewGuid();
            Guid guid2 = Guid.NewGuid();
            var value = new Value
            {
                MapValue = new MapValue
                {
                    Fields =
                    {
                        { "Name", new Value { StringValue = "test" } },
                        { "Guid", new Value { StringValue = guid1.ToString("N") } },
                        { "GuidOrNull", new Value { StringValue = guid2.ToString("N") } },
                    }
                }
            };
            var pair = (SerializationTestData.GuidPair) DeserializeDefault(value, typeof(SerializationTestData.GuidPair));
            Assert.Equal("test", pair.Name);
            Assert.Equal(guid1, pair.Guid);
            Assert.Equal(guid2, pair.GuidOrNull);
        }

        [Fact]
        public void DeserializeCustomPropertyConversion_ConverterRegistry()
        {
            Guid guid1 = Guid.NewGuid();
            Guid guid2 = Guid.NewGuid();
            var value = new Value
            {
                MapValue = new MapValue
                {
                    Fields =
                    {
                        { "Name", new Value { StringValue = "test" } },
                        { "Guid", new Value { StringValue = guid1.ToString("N") } },
                        { "GuidOrNull", new Value { StringValue = guid2.ToString("N") } },
                    }
                }
            };
            var registry = new ConverterRegistry() { new SerializationTestData.GuidConverter() };
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient(), converterRegistry: registry);
            var snapshot = GetSampleSnapshot(db, "doc1");
            var pair = (SerializationTestData.GuidPair2) ValueDeserializer.Deserialize(context: snapshot, value, typeof(SerializationTestData.GuidPair2));
            Assert.Equal("test", pair.Name);
            Assert.Equal(guid1, pair.Guid);
            Assert.Equal(guid2, pair.GuidOrNull);
        }

        [Fact]
        public void DeserializeCustomPropertyConversion_WithNull()
        {
            Guid guid = Guid.NewGuid();
            var value = new Value
            {
                MapValue = new MapValue
                {
                    Fields =
                    {
                        { "Name", new Value { StringValue = "test" } },
                        { "Guid", new Value { StringValue = guid.ToString("N") } },
                        { "GuidOrNull", new Value { NullValue = WKT::NullValue.NullValue } },
                    }
                }
            };
            var pair = (SerializationTestData.GuidPair) DeserializeDefault(value, typeof(SerializationTestData.GuidPair));
            Assert.Equal("test", pair.Name);
            Assert.Equal(guid, pair.Guid);
            Assert.Null(pair.GuidOrNull);
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

        [Theory]
        [InlineData(typeof(SerializationTestData.ByteEnum))]
        [InlineData(typeof(SerializationTestData.SByteEnum))]
        [InlineData(typeof(SerializationTestData.Int16Enum))]
        [InlineData(typeof(SerializationTestData.UInt16Enum))]
        [InlineData(typeof(SerializationTestData.Int32Enum))]
        [InlineData(typeof(SerializationTestData.UInt32Enum))]
        [InlineData(typeof(SerializationTestData.UInt64Enum))]
        public void EnumOverflow(BclType targetType)
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
            { new Value { NullValue = WKT::NullValue.NullValue }, typeof(int) },
            { new Value { NullValue = WKT::NullValue.NullValue }, typeof(Guid) },
            { new Value { NullValue = WKT::NullValue.NullValue }, typeof(Blob) }
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
            var value = ValueSerializer.Serialize(SerializationContext.Default, new[] { 1, 2 });
            var deserialized = DeserializeDefault(value, typeof(object));
            Assert.IsType<List<object>>(deserialized);
            Assert.Equal(new List<object> { 1L, 2L }, deserialized);
        }

#pragma warning disable DE0006 // ArrayList deprecation
        [Fact]
        public void DeserializeArrayToArrayListUsesArrayList()
        {
            var value = ValueSerializer.Serialize(SerializationContext.Default, new[] { 1, 2 });
            var deserialized = DeserializeDefault(value, typeof(ArrayList));
            Assert.IsType<ArrayList>(deserialized);
            Assert.Equal(new ArrayList { 1L, 2L }, deserialized);
        }
#pragma warning restore DE0006

        [Fact]
        public void DeserializeArrayToGenericIEnumerableUsesList()
        {
            var value = ValueSerializer.Serialize(SerializationContext.Default, new[] { 1, 2 });
            var deserialized = DeserializeDefault(value, typeof(IEnumerable<int>));
            Assert.IsType<List<int>>(deserialized);
            Assert.Equal(new List<int> { 1, 2 }, deserialized);
        }

        [Theory]
        [InlineData(typeof(int?))]
        [InlineData(typeof(string))]
        [InlineData(typeof(SerializationTestData.GameResult))]
        public void DeserializeNull(BclType targetType)
        {
            var value = new Value { NullValue = WKT::NullValue.NullValue };
            Assert.Null(DeserializeDefault(value, targetType));
        }

        [Fact]
        public void DeserializeNullToValue()
        {
            var value = new Value { NullValue = WKT::NullValue.NullValue };
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

        [Fact]
        public void DeserializeToLinqResult_Fails()
        {
            var sequence = Enumerable.Range(1, 3);
            var value = ValueSerializer.Serialize(SerializationContext.Default, sequence);
            Assert.Throws<NotSupportedException>(() => ValueDeserializer.Deserialize(SerializationTestData.Context, value, sequence.GetType()));
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
            var value = ValueSerializer.Serialize(SerializationContext.Default, poco);
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
            var value = ValueSerializer.Serialize(SerializationContext.Default, original);
            Assert.Equal("test", value.MapValue.Fields["Name"].StringValue);
            Assert.Equal(15L, value.MapValue.Fields["Value"].IntegerValue);

            var deserialized = (PrivateConstructor) DeserializeDefault(value, typeof(PrivateConstructor));
            Assert.Equal("test", deserialized.Name);
            Assert.Equal(15, deserialized.Value);
        }

        [Fact]
        public void DeserializeInt64AndDoubleToEachOther()
        {
            var value = ValueSerializer.Serialize(SerializationContext.Default, new { Name = "Test", DoubleValue = 100L, LongValue = 10.9 });
            Assert.Equal(Value.ValueTypeOneofCase.IntegerValue, value.MapValue.Fields["DoubleValue"].ValueTypeCase);
            Assert.Equal(Value.ValueTypeOneofCase.DoubleValue, value.MapValue.Fields["LongValue"].ValueTypeCase);
            var deserialized = (ModelWithDoubleAndLong) DeserializeDefault(value, typeof(ModelWithDoubleAndLong));
            Assert.Equal("Test", deserialized.Name);
            Assert.Equal(100.0, deserialized.DoubleValue);
            Assert.Equal(10.9, deserialized.LongValue);
        }

        [Theory]
        [InlineData(typeof(float), 10.0f)]
        [InlineData(typeof(double), 10.0)]
        public void DeserializeIntegerToDouble(BclType type, object expectedValue)
        {
            var value = new Value { IntegerValue = 10 };
            var deserialized = DeserializeDefault(value, type);
            Assert.Equal(expectedValue, deserialized);
        }

        [Theory]
        [InlineData(typeof(byte), (byte) 10)]
        [InlineData(typeof(sbyte), (sbyte) 10)]
        [InlineData(typeof(short), (short) 10)]
        [InlineData(typeof(ushort), (ushort) 10)]
        [InlineData(typeof(int), 10)]
        [InlineData(typeof(uint), (uint) 10)]
        [InlineData(typeof(long), (long) 10)]
        [InlineData(typeof(ulong), (ulong) 10)]
        public void DeserializeDoubleToInteger(BclType type, object expectedValue)
        {
            var value = new Value { DoubleValue = 10.9 };
            var deserialized = DeserializeDefault(value, type);
            Assert.Equal(expectedValue, deserialized);
        }

        [Theory]
        [InlineData(typeof(byte), byte.MaxValue + 1.0)]
        [InlineData(typeof(sbyte), sbyte.MaxValue + 1.0)]
        [InlineData(typeof(short), short.MaxValue + 1.0)]
        [InlineData(typeof(ushort), ushort.MaxValue + 1.0)]
        [InlineData(typeof(int), int.MaxValue + 1.0)]
        [InlineData(typeof(uint), uint.MaxValue + 1.0)]
        // We can't just add 1.0 to long.MaxValue and ulong.MaxValue as the precision at that stage is too low.
        // Doubling should easily get a value that's out of range though...
        [InlineData(typeof(long), long.MaxValue * 2.0)]
        [InlineData(typeof(ulong), ulong.MaxValue * 2.0)]
        public void DeserializeDoubleToInteger_OutOfRange(BclType type, double doubleValue)
        {
            var value = new Value { DoubleValue = doubleValue };
            Assert.Throws<OverflowException>(() => DeserializeDefault(value, type));
        }

        private string DeserializeAndReturnWarnings<T>(object valueToSerialize)
        {
            var value = ValueSerializer.Serialize(SerializationContext.Default, valueToSerialize);
            string warning = null;
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient()).WithWarningLogger(Log);
            var snapshot = GetSampleSnapshot(db, "doc1");
            ValueDeserializer.Deserialize(context: snapshot, value, typeof(T));
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
            ValueDeserializer.Deserialize(SerializationTestData.Context, value, targetType);

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

        [FirestoreData]
        private class ModelWithDoubleAndLong
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public double DoubleValue { get; set; }

            [FirestoreProperty]
            public double LongValue { get; set; }
        }
    }
}
