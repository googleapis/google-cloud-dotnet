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
using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using Google.Type;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static Google.Cloud.Firestore.SerializationHelpers;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    // TODO: Serialize some other types, e.g. Guid?
    // TODO: Protect against stack overflows?
    // TODO: Deliberate pass through of Value to Value (and maps/collections) to make it easier to plug in other mappers?

    /// <summary>
    /// Provides conversions from .NET types to Firestore Value protos.
    /// </summary>
    internal static class ValueSerializer
    {
        private static readonly MethodInfo s_serializeDictionaryMethod =
            typeof(ValueSerializer).GetTypeInfo().GetMethod(nameof(SerializeDictionary), BindingFlags.Static | BindingFlags.NonPublic);

        // Extension method to make the collection initializer below work
        private static void Add<T>(this Dictionary<System.Type, Func<object, Value>> dictionary, Func<T, Value> converter) =>
            dictionary.Add(typeof(T), obj => converter((T) obj));

        private static readonly Dictionary<System.Type, Func<object, Value>> s_fromBclConverters =
            new Dictionary<System.Type, Func<object, Value>>
        {
            (byte x) => new Value { IntegerValue = x },
            (sbyte x) => new Value { IntegerValue = x },
            (short x) => new Value { IntegerValue = x },
            (ushort x) => new Value { IntegerValue = x },
            (int x) => new Value { IntegerValue = x },
            (uint x) => new Value { IntegerValue = x },
            (long x) => new Value { IntegerValue = x },
            (ulong x) => new Value { IntegerValue = checked ((long) x) },
            (string x) => new Value { StringValue = x },
            (float x) => new Value { DoubleValue = x },
            (double x) => new Value { DoubleValue = x },
            (bool x) => new Value { BooleanValue = x },
            (Timestamp x) => new Value { TimestampValue = x.ToProto() },
            (DateTime x) => new Value { TimestampValue = wkt::Timestamp.FromDateTime(x) },
            (DateTimeOffset x) => new Value { TimestampValue = wkt::Timestamp.FromDateTimeOffset(x) },
            (byte[] x) => new Value { BytesValue = ByteString.CopyFrom(x) },
            (ByteString x) => new Value { BytesValue = x },
            (Blob x) => new Value { BytesValue = x.ByteString },
            (GeoPoint x) => new Value { GeoPointValue = x.ToProto() },
            (DocumentReference x) => new Value { ReferenceValue = x.Path },
            // Proto inputs that need cloning
            (LatLng x) => new Value { GeoPointValue = x.Clone() },
            (wkt::Timestamp x) => new Value { TimestampValue = x.Clone() },
            (Value x) => x.Clone()
        };

        /// <summary>
        /// Serializes a single input to a Value.
        /// </summary>
        /// <remarks>
        /// It's important that this always clones any mutable values - which is really only
        /// relevant when the input is already a proto. That allows the caller to then mutate the result
        /// where appropriate.
        /// </remarks>
        /// <param name="value">The value to serialize.</param>
        /// <returns>A Firestore Value proto.</returns>
        internal static Value Serialize(object value)
        {
            if (value == null)
            {
                return new Value { NullValue = wkt::NullValue.NullValue };
            }
            if (s_fromBclConverters.TryGetValue(value.GetType(), out var converter))
            {
                return converter(value);
            }
            switch (value)
            {
                case SentinelValue sentinel:
                    return sentinel.ToProtoValue();
                // Shortcut to avoid reflection for a common case
                case IDictionary<string, object> map:
                    return CreateMapValue(SerializeDictionary(map));
                // Now all other IDictionary<string,*> types, invoking our helper with reflection.
                case object dict when TryGetStringDictionaryValueType(value.GetType(), out var dictionaryElementType):
                    var method = s_serializeDictionaryMethod.MakeGenericMethod(dictionaryElementType);
                    var result = (Dictionary<string, Value>) method.Invoke(null, new object[] { value });
                    return CreateMapValue(result);
                case object anon when IsAnonymousType(anon.GetType()):
                    return CreateMapValue(ConvertAnonymousType(anon));
                case object attributed when IsFirestoreAttributedType(attributed.GetType()):
                    var attributedType = FirestoreDataAttributedType.ForType(value.GetType());
                    return attributedType.Serialize(value);
                case IEnumerable sequence:
                    return CreateArrayValue(sequence.Cast<object>().Select(Serialize));
                default:
                    throw new ArgumentException($"Unable to convert value of type {value.GetType()}");
            }
        }

        // Helper method called directly and via reflection
        private static Dictionary<string, Value> SerializeDictionary<TValue>(IDictionary<string, TValue> map) =>
            map.ToDictionary(pair => pair.Key, pair => Serialize(pair.Value));

        /// <summary>
        /// Serializes a map-based input to a dictionary of fields to values.
        /// This is effectively the map-only part of <see cref="Serialize"/>, but without wrapping the
        /// result in a Value.
        /// </summary>
        internal static IDictionary<string, Value> SerializeMap(object value)
        {
            GaxPreconditions.CheckNotNull(value, nameof(value));
            switch (value)
            {
                // Shortcut to avoid reflection for a common case
                case IDictionary<string, object> map:
                    return SerializeDictionary(map);
                // Now all other IDictionary<string,*> types, invoking our helper with reflection.
                case object dict when TryGetStringDictionaryValueType(value.GetType(), out var dictionaryElementType):
                    var method = s_serializeDictionaryMethod.MakeGenericMethod(dictionaryElementType);
                    return (Dictionary<string, Value>) method.Invoke(null, new object[] { value });
                case object anon when IsAnonymousType(anon.GetType()):
                    return ConvertAnonymousType(anon);
                case object attributed when IsFirestoreAttributedType(attributed.GetType()):
                    var converted = ConvertFirestoreAttributedType(attributed);
                    if (converted.ValueTypeCase != Value.ValueTypeOneofCase.MapValue)
                    {
                        throw new ArgumentException($"Unable to convert value of type {value.GetType()} to a map");
                    }
                    return converted.MapValue.Fields;
                default:
                    throw new ArgumentException($"Unable to convert value of type {value.GetType()} to a map");
            }
        }

        private static Dictionary<string, Value> ConvertAnonymousType(object value)
        {
            var typeInfo = value.GetType().GetTypeInfo();
            var ret = new Dictionary<string, Value>();
            foreach (var property in typeInfo.DeclaredProperties)
            {
                ret[property.Name] = Serialize(property.GetValue(value));
            }
            return ret;
        }

        private static Value ConvertFirestoreAttributedType(object value)
        {
            var attributedType = FirestoreDataAttributedType.ForType(value.GetType());
            return attributedType.Serialize(value);
        }
    }
}
