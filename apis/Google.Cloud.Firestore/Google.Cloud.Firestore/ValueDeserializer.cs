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
using System;
using System.Collections.Generic;
using System.Reflection;
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
    internal static class ValueDeserializer
    {
        /// <summary>
        /// Deserializes from a Firestore Value proto to a .NET type.
        /// </summary>
        /// <param name="context">The context for the deserialization operation. Never null.</param>
        /// <param name="value">The value to deserialize. Must not be null.</param>
        /// <param name="targetType">The target type. The method tries to convert to this type. If the type is
        /// object, it uses the default representation of the value.</param>
        /// <returns>The deserialized value</returns>
        internal static object Deserialize(IDeserializationContext context, Value value, BclType targetType)
        {
            GaxPreconditions.CheckNotNull(context, nameof(context));
            GaxPreconditions.CheckNotNull(value, nameof(value));

            // If we're asked for a Value, just clone it, even for null values.
            // (We need to clone to avoid aliasing: modifying the result of serialization
            // should not affect the original data.)
            if (targetType == typeof(Value))
            {
                return value.Clone();
            }
            if (targetType == typeof(object))
            {
                targetType = GetTargetType(value);
            }

            BclType underlyingType = Nullable.GetUnderlyingType(targetType);
            if (value.ValueTypeCase == Value.ValueTypeOneofCase.NullValue)
            {
                return !targetType.GetTypeInfo().IsValueType || underlyingType != null
                    ? (object) null
                    : throw new ArgumentException($"Unable to convert null value to {targetType.GetTypeInfo().FullName}");
            }

            // We deserialize to T and Nullable<T> the same way for all non-null values. Use the converter
            // associated with the non-nullable version of the target type.
            BclType nonNullableTargetType = underlyingType ?? targetType;
            return context.Database.SerializationContext.GetConverter(nonNullableTargetType).DeserializeValue(context, value);
        }

        internal static object DeserializeMap(IDeserializationContext context, IDictionary<string, Value> values, BclType targetType)
        {
            if (targetType == typeof(object))
            {
                targetType = typeof(Dictionary<string, object>);
            }
            return context.Database.SerializationContext.GetConverter(targetType).DeserializeMap(context, values);
        }

        private static BclType GetTargetType(Value value)
        {
            // TODO: Use an array instead?
            switch (value.ValueTypeCase)
            {
                case Value.ValueTypeOneofCase.NullValue:
                    // Any nullable type is fine here; we'll return null anyway.
                    return typeof(string);
                case Value.ValueTypeOneofCase.ArrayValue:
                    return typeof(List<object>);
                case Value.ValueTypeOneofCase.BooleanValue:
                    return typeof(bool);
                case Value.ValueTypeOneofCase.BytesValue:
                    return typeof(Blob);
                case Value.ValueTypeOneofCase.DoubleValue:
                    return typeof(double);
                case Value.ValueTypeOneofCase.GeoPointValue:
                    return typeof(GeoPoint);
                case Value.ValueTypeOneofCase.IntegerValue:
                    return typeof(long);
                case Value.ValueTypeOneofCase.MapValue:
                    return typeof(Dictionary<string, object>);
                case Value.ValueTypeOneofCase.ReferenceValue:
                    return typeof(DocumentReference);
                case Value.ValueTypeOneofCase.StringValue:
                    return typeof(string);
                case Value.ValueTypeOneofCase.TimestampValue:
                    return typeof(Timestamp);
                default:
                    throw new ArgumentException($"Unable to convert value type {value.ValueTypeCase} to System.Object");
            }
        }
    }
}
