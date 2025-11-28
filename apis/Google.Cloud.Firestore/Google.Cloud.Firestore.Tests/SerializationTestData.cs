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

using Google.Api.Gax;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using WKT = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests
{
    // Note: deliberately not using the CreateValue helper to make the protos absolutely clear.
    // (CreateProtoTimestamp is more reasonable though.)

    internal static class SerializationTestData
    {
        internal static FirestoreDb Database { get; } = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
        internal static IDeserializationContext Context => GetSampleSnapshot(Database, "doc1");

        public static IEnumerable<object[]> BclAndValues { get; } = new List<object[]>
        {
            { (object) null, new Value { NullValue = WKT::NullValue.NullValue } },
            // Simple types
            { true, new Value { BooleanValue = true } },
            { false, new Value { BooleanValue = false } },
            { "test", new Value { StringValue = "test" } },
            { (byte) 1, new Value { IntegerValue = 1L } },
            { (sbyte) 1, new Value { IntegerValue = 1L } },
            { (short) 1, new Value { IntegerValue = 1L } },
            { (ushort) 1, new Value { IntegerValue = 1L } },
            { 1, new Value { IntegerValue = 1L } },
            { 1U, new Value { IntegerValue = 1L } },
            { 1L, new Value { IntegerValue = 1L } },
            { 1UL, new Value { IntegerValue = 1L } },
            { 1.5F, new Value { DoubleValue = 1.5D } },
            { float.PositiveInfinity, new Value { DoubleValue = double.PositiveInfinity } },
            { float.NegativeInfinity, new Value { DoubleValue = double.NegativeInfinity } },
            { float.NaN, new Value { DoubleValue = double.NaN } },
            { 1.5D, new Value { DoubleValue = 1.5D } },
            { double.PositiveInfinity, new Value { DoubleValue = double.PositiveInfinity } },
            { double.NegativeInfinity, new Value { DoubleValue = double.NegativeInfinity } },
            { double.NaN, new Value { DoubleValue = double.NaN } },

            // Min/max values of each integer type
            { byte.MinValue, new Value { IntegerValue = byte.MinValue } },
            { byte.MaxValue, new Value { IntegerValue = byte.MaxValue } },
            { sbyte.MinValue, new Value { IntegerValue = sbyte.MinValue } },
            { sbyte.MaxValue, new Value { IntegerValue = sbyte.MaxValue } },
            { short.MinValue, new Value { IntegerValue = short.MinValue } },
            { short.MaxValue, new Value { IntegerValue = short.MaxValue } },
            { ushort.MinValue, new Value { IntegerValue = ushort.MinValue } },
            { ushort.MaxValue, new Value { IntegerValue = ushort.MaxValue } },
            { int.MinValue, new Value { IntegerValue = int.MinValue } },
            { int.MaxValue, new Value { IntegerValue = int.MaxValue } },
            { uint.MinValue, new Value { IntegerValue = uint.MinValue } },
            { uint.MaxValue, new Value { IntegerValue = uint.MaxValue } },
            { long.MinValue, new Value { IntegerValue = long.MinValue } },
            { long.MaxValue, new Value { IntegerValue = long.MaxValue } },
            // We don't cover the whole range of ulong
            { (ulong) 0, new Value { IntegerValue = 0 } },
            { (ulong) long.MaxValue, new Value { IntegerValue = long.MaxValue } },

            // Enum types
            { ByteEnum.MinValue, new Value { IntegerValue = byte.MinValue } },
            { ByteEnum.MaxValue, new Value { IntegerValue = byte.MaxValue } },
            { SByteEnum.MinValue, new Value { IntegerValue = sbyte.MinValue } },
            { SByteEnum.MaxValue, new Value { IntegerValue = sbyte.MaxValue } },
            { Int16Enum.MinValue, new Value { IntegerValue = short.MinValue } },
            { Int16Enum.MaxValue, new Value { IntegerValue = short.MaxValue } },
            { UInt16Enum.MinValue, new Value { IntegerValue = ushort.MinValue } },
            { UInt16Enum.MaxValue, new Value { IntegerValue = ushort.MaxValue } },
            { Int32Enum.MinValue, new Value { IntegerValue = int.MinValue } },
            { Int32Enum.MaxValue, new Value { IntegerValue = int.MaxValue } },
            { UInt32Enum.MinValue, new Value { IntegerValue = uint.MinValue } },
            { UInt32Enum.MaxValue, new Value { IntegerValue = uint.MaxValue } },
            { Int64Enum.MinValue, new Value { IntegerValue = long.MinValue } },
            { Int64Enum.MaxValue, new Value { IntegerValue = long.MaxValue } },
            // We don't cover the whole range of ulong
            { UInt64Enum.MinValue, new Value { IntegerValue = 0 } },
            { UInt64Enum.MaxRepresentableValue, new Value { IntegerValue = long.MaxValue } },
            { CustomConversionEnum.Foo, new Value { StringValue = "Foo" } },
            { CustomConversionEnum.Bar, new Value { StringValue = "Bar" } },

            // Timestamps
            { new Timestamp(1, 500),
                new Value { TimestampValue = CreateProtoTimestamp(1, 500) } },
            { new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc).AddTicks(5),
                new Value { TimestampValue = CreateProtoTimestamp(1, 500) } },
            // If the local time is 1 hour ahead of UTC, the timestamp is an hour before the Unix epoch
            { new DateTimeOffset(1970, 1, 1, 0, 0, 1, TimeSpan.FromHours(1)).AddTicks(5),
                new Value { TimestampValue = CreateProtoTimestamp(1 - 3600, 500) } },
            { CreateProtoTimestamp(1, 500),
                new Value { TimestampValue = CreateProtoTimestamp(1, 500) } },

            // Blobs
            { new byte[] { 1, 2, 3, 4 },
                new Value { BytesValue = ByteString.CopyFrom(1, 2, 3, 4) } },
            { Blob.CopyFrom(new byte[] { 1, 2, 3, 4 }),
                new Value { BytesValue = ByteString.CopyFrom(1, 2, 3, 4) } },
            { ByteString.CopyFrom(1, 2, 3, 4),
                new Value { BytesValue = ByteString.CopyFrom(1, 2, 3, 4) } },

            // GeoPoints
            { new GeoPoint(1.5, 2.5),
                new Value { GeoPointValue = new Type.LatLng { Latitude = 1.5, Longitude = 2.5 } } },
            { new Type.LatLng { Latitude = 1.5, Longitude = 2.5 },
                new Value { GeoPointValue = new Type.LatLng { Latitude = 1.5, Longitude = 2.5 } } },

            // Array values
            { new string[] { "x", "y" },
                new Value { ArrayValue = new ArrayValue { Values = { new Value { StringValue = "x" }, new Value { StringValue = "y" } } } } },
            { new List<string> { "x", "y" },
                new Value { ArrayValue = new ArrayValue { Values = { new Value { StringValue = "x" }, new Value { StringValue = "y" } } } } },
            // Deliberately ByteString rather than Blob here - we need to be able to detect the element type to perform the
            // per-element deserialization correctly
            { new List<ByteString> { ByteString.CopyFromUtf8("abc"), ByteString.CopyFromUtf8("def") },
                new Value { ArrayValue = new ArrayValue { Values = { new Value { BytesValue = ByteString.CopyFromUtf8("abc") }, new Value { BytesValue = ByteString.CopyFromUtf8("def") } } } } },

            // Map values (that can be deserialized again): dictionaries, attributed types, expandos (which are just dictionaries), custom serialized map-like values

            // Dictionaries
            { new Dictionary<string, object> { { "name", "Jon" }, { "score", 10L } },
                new Value { MapValue = new MapValue { Fields = { { "name", new Value { StringValue = "Jon" } }, { "score", new Value { IntegerValue = 10L } } } } } },
            { new Dictionary<string, int> { { "A", 10 }, { "B", 20 } },
                new Value { MapValue = new MapValue { Fields = { { "A", new Value { IntegerValue = 10L } }, { "B", new Value { IntegerValue = 20L } } } } } },
            // Attributed type (each property has an attribute)
            { new GameResult { Name = "Jon", Score = 10 },
                new Value { MapValue = new MapValue { Fields = { { "name", new Value { StringValue = "Jon" } }, { "Score", new Value { IntegerValue = 10L } } } } } },
            // ExpandoObject (a dictionary)
            { () => { dynamic d = new ExpandoObject(); d.name = "Jon"; d.score = 10L; return d; },
                new Value { MapValue = new MapValue { Fields = { { "name", new Value { StringValue = "Jon" } }, { "score", new Value { IntegerValue = 10L } } } } } },
            // Attributed type containing a dictionary
            { new DictionaryInterfaceContainer { Integers = new Dictionary<string, int> { { "A", 10 }, { "B", 20 } } },
                new Value { MapValue = new MapValue { Fields =
                    { { "Integers", new Value { MapValue = new MapValue { Fields = { { "A", new Value { IntegerValue = 10L } }, { "B", new Value { IntegerValue = 20L } } } } } } }
                } } },
            // Attributed type serialized and deserialized by CustomPlayerConverter
            { new CustomPlayer { Name = "Amanda", Score = 15 },
                new Value { MapValue = new MapValue { Fields = { { "PlayerName", new Value { StringValue = "Amanda" } }, { "PlayerScore", new Value { IntegerValue = 15L } } } } } },

            // Attributed value type serialized and deserialized by CustomValueTypeConverter
            { new CustomValueType("xyz", 10),
                new Value { MapValue = new MapValue { Fields = { { "Name", new Value { StringValue = "xyz" } }, { "Value", new Value { IntegerValue = 10L } } } } } },

            // Attributed type with enums (name and number)
            { new ModelWithEnums { EnumDefaultByName = CustomConversionEnum.Foo, EnumAttributedByName = Int32Enum.MinValue, EnumByNumber = Int32Enum.MaxValue },
                new Value { MapValue = new MapValue {
                    Fields = {
                        { "EnumDefaultByName", new Value { StringValue = "Foo" } },
                        { "EnumAttributedByName", new Value { StringValue = "MinValue" } },
                        { "EnumByNumber", new Value { IntegerValue = int.MaxValue } }
                    } } } },

            // Attributed struct
            { new StructModel { Name = "xyz", Value = 10 },
                new Value { MapValue = new MapValue { Fields = { { "Name", new Value { StringValue = "xyz" } }, { "Value", new Value { IntegerValue = 10L } } } } } },

            // Nullable type handling
            { new NullableContainer { NullableValue = null },
                new Value { MapValue = new MapValue { Fields = { { "NullableValue", new Value { NullValue = WKT::NullValue.NullValue } } } } } },
            { new NullableContainer { NullableValue = 10 },
                new Value { MapValue = new MapValue { Fields = { { "NullableValue", new Value { IntegerValue = 10L } } } } } },
            { new NullableEnumContainer { NullableValue = null },
                new Value { MapValue = new MapValue { Fields = { { "NullableValue", new Value { NullValue = WKT::NullValue.NullValue } } } } } },
            { new NullableEnumContainer { NullableValue = (Int32Enum) 10 },
                new Value { MapValue = new MapValue { Fields = { { "NullableValue", new Value { IntegerValue = 10L } } } } } },

            // Document references
            { Database.Document("a/b"),
                new Value { ReferenceValue = "projects/proj/databases/db/documents/a/b" } },

            // Tuple support
            { new TupleModel { PlayerName = ("F", "M", "L"), HighScore = (500, 10) },
                new Value { MapValue = new MapValue { Fields = {
                        { "PlayerName", new Value { MapValue = new MapValue { Fields = { { "first", new Value { StringValue = "F" } }, { "middle", new Value { StringValue = "M" } }, { "last", new Value { StringValue = "L" } } } } } },
                        { "HighScore", new Value { MapValue = new MapValue { Fields = { { "score", new Value { IntegerValue = 500 } }, { "level", new Value { IntegerValue = 10 } } } } } }
            } } } },

            // Interface support
            { new InterfaceProperties { List = new List<string> { "A", "B" }, Map = new Dictionary<string, string> { { "x", "x-value" }, { "y", "y-value" } } },
                new Value { MapValue = new MapValue { Fields = {
                        { "List", new Value { ArrayValue = new ArrayValue { Values = { new Value { StringValue = "A" }, new Value { StringValue = "B" } } } } },
                        { "Map", new Value { MapValue = new MapValue { Fields = { { "x", new Value { StringValue = "x-value"} }, { "y", new Value { StringValue = "y-value" } } } } } }
            } } } }
        };

        public static TheoryData<IMessage, Func<Value, IMessage>> ProtoValues { get; } = new TheoryData<IMessage, Func<Value, IMessage>>
        {
            { new Value { DoubleValue = 1.2345 }, v => v },
            { CreateProtoTimestamp(1, 2345), v => v.TimestampValue },
            { new Type.LatLng { Latitude = 1.5, Longitude = 1.5 }, v => v.GeoPointValue }
        };

        // Only equatable for the sake of testing; that's not a requirement of the serialization code.
        [FirestoreData]
        internal class GameResult : IEquatable<GameResult>
        {
            [FirestoreProperty("name")]
            public string Name { get; set; }
            [FirestoreProperty] // No property name specified, so field will be Score
            public int Score { get; set; }

            public override int GetHashCode() => Name.GetHashCode() ^ Score;

            public override bool Equals(object obj) => Equals(obj as GameResult);

            public bool Equals(GameResult other) => other != null && other.Name == Name && other.Score == Score;
        }

        [FirestoreData]
        internal class NullableContainer : IEquatable<NullableContainer>
        {
            [FirestoreProperty]
            public int? NullableValue { get; set; }

            public override int GetHashCode() => NullableValue.GetValueOrDefault();

            public override bool Equals(object obj) => Equals(obj as NullableContainer);

            public bool Equals(NullableContainer other) => other != null && other.NullableValue == NullableValue;
        }

        [FirestoreData]
        internal class NullableEnumContainer : IEquatable<NullableEnumContainer>
        {
            [FirestoreProperty]
            public Int32Enum? NullableValue { get; set; }

            public override int GetHashCode() => (int) NullableValue.GetValueOrDefault();

            public override bool Equals(object obj) => Equals(obj as NullableEnumContainer);

            public bool Equals(NullableEnumContainer other) => other != null && other.NullableValue == NullableValue;
        }

        [FirestoreData]
        internal class DictionaryInterfaceContainer : IEquatable<DictionaryInterfaceContainer>
        {
            [FirestoreProperty]
            public IDictionary<string, int> Integers { get; set; }

            public override int GetHashCode() => Integers.Sum(pair => pair.Key.GetHashCode() + pair.Value);

            public override bool Equals(object obj) => Equals(obj as DictionaryInterfaceContainer);

            public bool Equals(DictionaryInterfaceContainer other)
            {
                if (other == null)
                {
                    return false;
                }
                if (Integers == other.Integers)
                {
                    return true;
                }
                if (Integers == null || other.Integers == null)
                {
                    return false;
                }
                if (Integers.Count != other.Integers.Count)
                {
                    return false;
                }
                return Integers.All(pair => other.Integers.TryGetValue(pair.Key, out var otherValue) && pair.Value == otherValue);
            }
        }

        internal enum SByteEnum : sbyte
        {
            MinValue = sbyte.MinValue,
            MaxValue = sbyte.MaxValue
        }

        internal enum Int16Enum : short
        {
            MinValue = short.MinValue,
            MaxValue = short.MaxValue
        }

        internal enum Int32Enum : int
        {
            MinValue = int.MinValue,
            MaxValue = int.MaxValue
        }

        internal enum Int64Enum : long
        {
            MinValue = long.MinValue,
            MaxValue = long.MaxValue
        }

        internal enum ByteEnum : byte
        {
            MinValue = byte.MinValue,
            MaxValue = byte.MaxValue
        }

        internal enum UInt16Enum : ushort
        {
            MinValue = ushort.MinValue,
            MaxValue = ushort.MaxValue
        }

        internal enum UInt32Enum : uint
        {
            MinValue = uint.MinValue,
            MaxValue = uint.MaxValue
        }

        internal enum UInt64Enum : ulong
        {
            MinValue = ulong.MinValue,
            MaxRepresentableValue = long.MaxValue
        }

        [FirestoreData(ConverterType = typeof(FirestoreEnumNameConverter<CustomConversionEnum>))]
        internal enum CustomConversionEnum
        {
            Foo = 1,
            Bar = 2
        }

        [FirestoreData]
        public sealed class ModelWithEnums
        {
            [FirestoreProperty]
            public CustomConversionEnum EnumDefaultByName { get; set; }

            [FirestoreProperty(ConverterType = typeof(FirestoreEnumNameConverter<Int32Enum>))]
            public Int32Enum EnumAttributedByName { get; set; }

            [FirestoreProperty]
            public Int32Enum EnumByNumber { get; set; }

            public override bool Equals(object obj) => obj is ModelWithEnums other &&
                EnumDefaultByName == other.EnumDefaultByName &&
                EnumAttributedByName == other.EnumAttributedByName &&
                EnumByNumber == other.EnumByNumber;

            public override int GetHashCode() => 0;
        }

        [FirestoreData]
        public sealed class CustomUser
        {
            [FirestoreProperty]
            public int HighScore { get; set; }
            [FirestoreProperty]
            public string Name { get; set; }
            [FirestoreProperty]
            public Email Email { get; set; }
        }

        [FirestoreData(ConverterType = typeof(EmailConverter))]
        public sealed class Email
        {
            public string Address { get; }
            public Email(string address) => Address = address;
        }

        public class EmailConverter : IFirestoreConverter<Email>
        {
            public Email FromFirestore(object value)
            {
                switch (value)
                {
                    case null: throw new ArgumentNullException(nameof(value)); // Shouldn't happen
                    case string address: return new Email(address);
                    default: throw new ArgumentException($"Unexpected data: {value.GetType()}");
                }
            }
            public object ToFirestore(Email value) => value?.Address;
        }

        [FirestoreData]
        public class GuidPair
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty(ConverterType = typeof(GuidConverter))]
            public Guid Guid { get; set; }

            [FirestoreProperty(ConverterType = typeof(GuidConverter))]
            public Guid? GuidOrNull { get; set; }
        }

        // Like GuidPair, but without the converter specified - it has to come
        // from a converter registry instead.
        [FirestoreData]
        public class GuidPair2
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public Guid Guid { get; set; }

            [FirestoreProperty]
            public Guid? GuidOrNull { get; set; }
        }

        public class GuidConverter : IFirestoreConverter<Guid>
        {
            public Guid FromFirestore(object value)
            {
                switch (value)
                {
                    case null: throw new ArgumentNullException(nameof(value)); // Shouldn't happen
                    case string guid: return Guid.ParseExact(guid, "N");
                    default: throw new ArgumentException($"Unexpected data: {value.GetType()}");
                }
            }
            public object ToFirestore(Guid value) => value.ToString("N");
        }

        // Only equatable for the sake of testing; that's not a requirement of the serialization code.
        [FirestoreData(ConverterType = typeof(CustomPlayerConverter))]
        public class CustomPlayer : IEquatable<CustomPlayer>
        {
            public string Name { get; set; }
            public int Score { get; set; }

            public override int GetHashCode() => Name.GetHashCode() ^ Score;
            public override bool Equals(object obj) => Equals(obj as CustomPlayer);
            public bool Equals(CustomPlayer other) => other != null && other.Name == Name && other.Score == Score;
        }

        public class CustomPlayerConverter : IFirestoreConverter<CustomPlayer>
        {
            public CustomPlayer FromFirestore(object value)
            {
                var map = (IDictionary<string, object>) value;
                return new CustomPlayer
                {
                    Name = (string) map["PlayerName"],
                    // Unbox to long, then convert to int.
                    Score = (int) (long) map["PlayerScore"]
                };
            }

            public object ToFirestore(CustomPlayer value) =>
                new Dictionary<string, object>
                {
                    ["PlayerName"] = value.Name,
                    ["PlayerScore"] = value.Score
                };
        }

        [FirestoreData(ConverterType = typeof(CustomValueTypeConverter))]
        internal struct CustomValueType : IEquatable<CustomValueType>
        {
            public string Name { get; }
            public int Value { get; }

            public CustomValueType(string name, int value)
            {
                Name = name;
                Value = value;
            }

            public override int GetHashCode() => Name.GetHashCode() + Value;
            public override bool Equals(object obj) => obj is CustomValueType other && Equals(other);
            public bool Equals(CustomValueType other) => Name == other.Name && Value == other.Value;
            public override string ToString() => $"{nameof(CustomValueType)}: { new { Name, Value } }";
        }

        internal class CustomValueTypeConverter : IFirestoreConverter<CustomValueType>
        {
            public CustomValueType FromFirestore(object value)
            {
                var dictionary = (IDictionary<string, object>)value;
                return new CustomValueType(
                    (string)dictionary["Name"],
                    (int)(long)dictionary["Value"]
                );
            }

            public object ToFirestore(CustomValueType value) =>
                new Dictionary<string, object>
                {
                    ["Name"] = value.Name,
                    ["Value"] = value.Value
                };
        }

        [FirestoreData]
        internal struct StructModel : IEquatable<StructModel>
        {
            [FirestoreProperty]
            public string Name { get; set; }
            [FirestoreProperty]
            public int Value { get; set; }

            public override int GetHashCode() => Name.GetHashCode() + Value;
            public override bool Equals(object obj) => obj is StructModel other && Equals(other);
            public bool Equals(StructModel other) => Name == other.Name && Value == other.Value;

            public override string ToString() => $"{nameof(StructModel)}: { new { Name, Value } }";
        }

        [FirestoreData]
        private class TupleModel : IEquatable<TupleModel>
        {
            [FirestoreProperty]
            public (int score, int level) HighScore { get; set; }

            [FirestoreProperty]
            public (string first, string middle, string last) PlayerName { get; set; }

            public override bool Equals(object obj) => Equals(obj as TupleModel);

            public override int GetHashCode() => HighScore.GetHashCode() ^ PlayerName.GetHashCode();

            public bool Equals(TupleModel other) =>
                HighScore == other.HighScore && PlayerName == other.PlayerName;
        }

        [FirestoreData]
        private class InterfaceProperties : IEquatable<InterfaceProperties>
        {
            [FirestoreProperty]
            public IDictionary<string, string> Map { get; set; }

            [FirestoreProperty]
            public IList<string> List { get; set; }

            private List<string> MapKeysInOrder => Map.Keys.OrderBy(k => k).ToList();
            private List<string> MapValuesInKeyOrder => Map.OrderBy(pair => pair.Key).Select(pair => pair.Value).ToList();

            public override bool Equals(object obj) => Equals(obj as InterfaceProperties);

            public override int GetHashCode() => GaxEqualityHelpers.GetListHashCode(List.ToList())
                ^ GaxEqualityHelpers.GetListHashCode(MapKeysInOrder)
                ^ GaxEqualityHelpers.GetListHashCode(MapValuesInKeyOrder);

            public bool Equals(InterfaceProperties other) =>
                GaxEqualityHelpers.ListsEqual(List.ToList(), other.List.ToList()) &&
                GaxEqualityHelpers.ListsEqual(MapKeysInOrder, other.MapKeysInOrder) &&
                GaxEqualityHelpers.ListsEqual(MapValuesInKeyOrder, other.MapValuesInKeyOrder);
        }
    }
}
