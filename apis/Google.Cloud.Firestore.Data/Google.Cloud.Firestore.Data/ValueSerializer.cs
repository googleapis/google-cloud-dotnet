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
using static Google.Cloud.Firestore.Data.SerializationHelpers;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Data
{
    // TODO: Serialize some other types, e.g. Guid?
    // TODO: Protect against stack overflows?
    // TODO: Deliberate pass through of Value to Value (and maps/collections) to make it easier to plug in other mappers?

    /// <summary>
    /// Provides conversions from .NET types to Firestore Value protos.
    /// </summary>
    internal static class ValueSerializer
    {
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
            // TODO: Clone?
            (wkt::Timestamp x) => new Value { TimestampValue = x },
            (Timestamp x) => new Value { TimestampValue = x.ToProto() },
            (DateTime x) => new Value { TimestampValue = wkt::Timestamp.FromDateTime(x) },
            (DateTimeOffset x) => new Value { TimestampValue = wkt::Timestamp.FromDateTimeOffset(x) },
            (byte[] x) => new Value { BytesValue = ByteString.CopyFrom(x) },
            (ByteString x) => new Value { BytesValue = x },
            (Blob x) => new Value { BytesValue = x.ByteString },
            // TODO: Clone?
            (LatLng x) => new Value { GeoPointValue = x },
            (GeoPoint x) => new Value { GeoPointValue = x.ToProto() },
            (DocumentReference x) => new Value { ReferenceValue = x.Path }
        };

        /// <summary>
        /// Serializes a single input to a Value.
        /// </summary>
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
                // TODO: What about other dictionary types (e.g Dictionary<string, string>)?
                case IDictionary<string, object> map:
                    return CreateMapValue(map.ToDictionary(pair => pair.Key, pair => Serialize(pair.Value)));
                case object anon when IsAnonymousType(anon.GetType()):
                    return CreateMapValue(ConvertAnonymousType(anon));
                case object attributed when IsFirestoreAttributedType(attributed.GetType()):
                    return CreateMapValue(ConvertFirestoreAttributedType(attributed));
                case IEnumerable sequence:
                    return CreateArrayValue(sequence.Cast<object>().Select(Serialize));
                default:
                    throw new ArgumentException($"Unable to convert value of type {value.GetType()}");
            }
        }

        /// <summary>
        /// Serializes a map-based input to a dictionary of fields to values.
        /// This is effectively the map-only part of <see cref="Serialize"/>, but without wrapping the
        /// result in a Value.
        /// </summary>
        internal static Dictionary<string, Value> SerializeMap(object value)
        {
            GaxPreconditions.CheckNotNull(value, nameof(value));
            switch (value)
            {
                case IDictionary<string, object> map:
                    return map.ToDictionary(pair => pair.Key, pair => Serialize(pair.Value));
                case object anon when IsAnonymousType(anon.GetType()):
                    return ConvertAnonymousType(anon);
                case object attributed when IsFirestoreAttributedType(attributed.GetType()):
                    return ConvertFirestoreAttributedType(attributed);
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

        private static Dictionary<string, Value> ConvertFirestoreAttributedType(object value)
        {
            var typeInfo = value.GetType().GetTypeInfo();
            var ret = new Dictionary<string, Value>();
            // TODO(optimization): We almost certainly want to cache this.
            foreach (var property in typeInfo.DeclaredProperties.Where(p => p.CanRead && p.GetGetMethod().IsPublic && !p.GetGetMethod().IsStatic))
            {
                var attribute = property.GetCustomAttribute<FirestorePropertyAttribute>();
                if (attribute != null)
                {
                    ret[attribute.Name ?? property.Name] = Serialize(property.GetValue(value));
                }
            }
            return ret;
        }
    }
}
