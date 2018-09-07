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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using static Google.Cloud.Firestore.SerializationHelpers;
using static Google.Cloud.Firestore.V1Beta1.Value.ValueTypeOneofCase;
using BclType = System.Type;

namespace Google.Cloud.Firestore
{
    // TODO: A lot of optimization of this and ValueSerializer, *after* writing comprehensive benchmarks.
    // We may be able to avoid a lot of boxing by a combination of making methods generic and building
    // delegates for serialization/deserialization of specific types using expression trees. The initial
    // aim is just to work out the functionality required, and optimize later.

    /// <summary>
    /// Provides conversions from Firestore Value protos to .NET types.
    /// </summary>
    internal sealed class ValueDeserializer
    {
        // The BCL type we create when deserializing map values and when our target type is
        // just IDictionary<string, object> or object.
        private readonly BclType _defaultMapType;

        /// <summary>
        /// A deserializer that uses ExpandoObject for maps when no type is specified.
        /// </summary>
        internal static ValueDeserializer Expando { get; } = new ValueDeserializer(typeof(ExpandoObject));

        /// <summary>
        /// A deserializer that uses Dictionary for maps when no type is specified.
        /// </summary>
        internal static ValueDeserializer Dictionary { get; } = new ValueDeserializer(typeof(Dictionary<string, object>));

        /// <summary>
        /// The default deserializer - currently <see cref="Dictionary"/>.
        /// </summary>
        internal static ValueDeserializer Default => Dictionary;

        private ValueDeserializer(BclType defaultMapType) => _defaultMapType = defaultMapType;

        /// <summary>
        /// Deserializes from a Firestore Value proto to a .NET type.
        /// </summary>
        /// <param name="db">The database to use when deserializing DocumentReferences. Must not be null.</param>
        /// <param name="value">The value to deserialize. Must not be null.</param>
        /// <param name="targetType">The target type. The method tries to convert to this type. If the type is
        /// object, it uses the default representation of the value.</param>
        /// <returns>The deserialized value</returns>
        internal object Deserialize(FirestoreDb db, Value value, BclType targetType)
        {
            GaxPreconditions.CheckNotNull(db, nameof(db));
            GaxPreconditions.CheckNotNull(value, nameof(value));

            // If we're asked for a Value, just provide it directly, even for null values.
            // FIXME: Should we clone?
            if (targetType == typeof(Value))
            {
                return value;
            }

            checked
            {
                switch (value.ValueTypeCase)
                {
                    case BooleanValue:
                        return ConvertDefault(v => v.BooleanValue)
                            ?? NoConversion();
                    case DoubleValue:
                        // TODO: Decimal?
                        return ConvertDefault(v => v.DoubleValue)
                            ?? ConvertSpecific(v => (float) v.DoubleValue)
                            ?? NoConversion();
                    case GeoPointValue:
                        return ConvertDefault(v => GeoPoint.FromProto(v.GeoPointValue))
                            ?? ConvertSpecific(v => v.GeoPointValue)
                            ?? NoConversion();
                    case IntegerValue:
                        return ConvertDefault(v => v.IntegerValue)
                            ?? ConvertSpecific(v => (ulong) v.IntegerValue)
                            ?? ConvertSpecific(v => (int) v.IntegerValue)
                            ?? ConvertSpecific(v => (uint) v.IntegerValue)
                            ?? ConvertSpecific(v => (short) v.IntegerValue)
                            ?? ConvertSpecific(v => (ushort) v.IntegerValue)
                            ?? ConvertSpecific(v => (byte) v.IntegerValue)
                            ?? ConvertSpecific(v => (sbyte) v.IntegerValue)
                            ?? NoConversion();
                    case NullValue:
                        return IsNonNullableValueType(targetType) ? NoConversion() : null;
                    case StringValue:
                        return ConvertDefault(v => v.StringValue)
                            ?? NoConversion();
                    case TimestampValue:
                        return ConvertDefault(v => Timestamp.FromProto(v.TimestampValue))
                            ?? ConvertSpecific(v => v.TimestampValue)
                            ?? ConvertSpecific(v => v.TimestampValue.ToDateTime())
                            ?? ConvertSpecific(v => v.TimestampValue.ToDateTimeOffset())
                            ?? NoConversion();
                    case Value.ValueTypeOneofCase.ArrayValue:
                        return DeserializeArray(db, value.ArrayValue.Values, targetType);
                    case BytesValue:
                        return ConvertDefault(v => Blob.FromByteString(v.BytesValue))
                            ?? ConvertSpecific(v => v.BytesValue.ToByteArray())
                            ?? ConvertSpecific(v => v.BytesValue)
                            ?? NoConversion();
                    case Value.ValueTypeOneofCase.MapValue:
                        return DeserializeMap(db, value.MapValue.Fields, targetType);
                    case ReferenceValue:
                        return ConvertDefault(v => db.GetDocumentReferenceFromResourceName(v.ReferenceValue))
                            ?? NoConversion();
                    default:
                        return NoConversion();
                }
            }

            // Converts the value using the converter if the target type is either object (so general)
            // or T, or T?.
            object ConvertDefault<T>(Func<Value, T> conversion) =>
                targetType == typeof(T) || Nullable.GetUnderlyingType(targetType) == typeof(T) || targetType == typeof(object)
                ? (object) conversion(value) : null;

            // Converts the value using the converter only if the target type is exactly T or T?.
            object ConvertSpecific<T>(Func<Value, T> conversion) =>
                targetType == typeof(T) || Nullable.GetUnderlyingType(targetType) == typeof(T)
                ? (object) conversion(value) : null;

            // Always throws - useful at the end of a chain of attempts.
            object NoConversion() =>
                throw new ArgumentException($"Unable to convert value type {value.ValueTypeCase} to {targetType}");
        }

        internal object DeserializeMap(FirestoreDb db, IDictionary<string, Value> values, BclType targetType)
        {
            // TODO: Support deserialization to IReadOnlyDictionary<,> as well? (It becomes somewhat awkward, for limited benefit.)
            if (targetType == typeof(object) || targetType == typeof(IDictionary<string, object>))
            {
                targetType = _defaultMapType;
            }

            // Shortcut to avoid reflection
            if (targetType == typeof(Dictionary<string, object>) || targetType == typeof(ExpandoObject))
            {
                return PopulateDictionary<object>(db, values, targetType);
            }
            if (TryGetStringDictionaryValueType(targetType, out var dictionaryElementType))
            {
                // If we've been asked to deserialize to an interface, let's just see if Dictionary<,>
                // would work, but otherwise give up.
                if (targetType.GetTypeInfo().IsInterface)
                {
                    var candidateType = typeof(Dictionary<,>).MakeGenericType(typeof(string), dictionaryElementType);
                    if (targetType.IsAssignableFrom(candidateType))
                    {
                        targetType = candidateType;
                    }
                    else
                    {
                        throw new ArgumentException($"Unable to deserialize map to {targetType}");
                    }
                }
                var method = typeof(ValueDeserializer).GetTypeInfo().GetMethod(nameof(PopulateDictionary), BindingFlags.Instance | BindingFlags.NonPublic);
                return method.MakeGenericMethod(dictionaryElementType).Invoke(this, new object[] { db, values, targetType });
            }
            if (IsFirestoreAttributedType(targetType))
            {
                var attributedType = FirestoreDataAttributedType.ForType(targetType);
                var ret = Activator.CreateInstance(targetType);

                foreach (var pair in values)
                {
                    if (attributedType.WritableProperties.TryGetValue(pair.Key, out var property))
                    {
                        var converted = Deserialize(db, pair.Value, property.PropertyType);
                        property.SetValue(ret, converted);
                    }
                    else
                    {
                        switch (attributedType.UnknownPropertyHandling)
                        {
                            case UnknownPropertyHandling.Ignore:
                                break;
                            case UnknownPropertyHandling.Warn:
                                db.LogWarning($"No writable property for Firestore field {pair.Key} in type {targetType.FullName}");
                                break;
                            case UnknownPropertyHandling.Throw:
                                throw new ArgumentException($"No writable property for Firestore field {pair.Key} in type {targetType.FullName}");
                        }
                    }                    
                }
                return ret;
            }
            throw new ArgumentException($"Unable to deserialize map to {targetType}");
        }

        // Helper method called directly and via reflection
        private IDictionary<string, TValue> PopulateDictionary<TValue>(FirestoreDb db, IDictionary<string, Value> values, BclType targetType)
        {
            var ret = (IDictionary<string, TValue>) Activator.CreateInstance(targetType);
            foreach (var pair in values)
            {
                ret.Add(pair.Key, (TValue) Deserialize(db, pair.Value, typeof(TValue)));
            }
            return ret;
        }

        private object DeserializeArray(FirestoreDb db, IList<Value> values, BclType targetType)
        {
            // TODO: Handle typeof(IEnumerable<int>) etc.
            if (targetType == typeof(object) || targetType == typeof(IEnumerable<object>) || targetType == typeof(IList<object>))
            {
                targetType = typeof(List<object>);
            }
            if (targetType.IsArray)
            {
                var elementType = targetType.GetElementType();
                Array array = Array.CreateInstance(elementType, values.Count);
                for (int i = 0; i < values.Count; i++)
                {
                    var converted = Deserialize(db, values[i], elementType);
                    array.SetValue(converted, i);
                }
                return array;
            }
            if (typeof(IList).IsAssignableFrom(targetType))
            {
                var elementType = typeof(object);

                var interfaces = targetType.GetTypeInfo().GetInterfaces();
                var genericEnumerable = interfaces.Select(t => t.GetTypeInfo()).FirstOrDefault(iface => iface.IsGenericType && iface.GetGenericTypeDefinition() == typeof(IList<>));
                if (genericEnumerable != null)
                {
                    elementType = genericEnumerable.GenericTypeArguments[0];
                }

                var list = (IList) Activator.CreateInstance(targetType);
                foreach (var value in values)
                {
                    var deserialized = Deserialize(db, value, elementType);
                    list.Add(deserialized);
                }
                return list;
            }
            throw new ArgumentException($"Unable to deserialize array to {targetType}");
        }
    }
}
