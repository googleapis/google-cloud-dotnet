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
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// Code shared between <see cref="ValueSerializer"/> and <see cref="ValueDeserializer"/> (and tests).
    /// </summary>
    internal static class SerializationHelpers
    {
        /// <summary>
        /// Checks whether <paramref name="type"/> refers to an anonymous type.
        /// </summary>
        internal static bool IsAnonymousType(BclType type) => type.GetTypeInfo().IsDefined(typeof(CompilerGeneratedAttribute));

        /// <summary>
        /// Checks whether <paramref name="type"/> refers to a type annotated with <see cref="FirestoreDataAttribute"/>.
        /// </summary>
        internal static bool IsFirestoreAttributedType(BclType type) => type.GetTypeInfo().IsDefined(typeof(FirestoreDataAttribute));

        /// <summary>
        /// Checks whether <paramref name="type"/> refers to a non-nullable type (so a null value is invalid).
        /// </summary>
        internal static bool IsNonNullableValueType(BclType type) => type.GetTypeInfo().IsValueType && Nullable.GetUnderlyingType(type) == null;

        /// <summary>
        /// If <paramref name="type"/> implements (or is) <see cref="IDictionary{TKey, TValue}"/> with TKey equal to string, returns true and sets
        /// <paramref name="elementType"/> to TValue. Otherwise, returns false and sets <paramref name="elementType"/> to null.
        /// </summary>
        internal static bool TryGetStringDictionaryValueType(BclType type, out BclType elementType)
        {
            elementType = type.GetTypeInfo()
                .GetInterfaces()
                .Concat(new[] { type }) // Make this method handle IDictionary<,> as an input; GetInterfaces doesn't return the type you call it on
                .Select(MapInterfaceToDictionaryValueTypeArgument).FirstOrDefault(t => t != null);
            return elementType != null;

            BclType MapInterfaceToDictionaryValueTypeArgument(BclType iface)
            {
                var ifaceInfo = iface.GetTypeInfo();
                if (!ifaceInfo.IsGenericType || ifaceInfo.IsGenericTypeDefinition)
                {
                    return null;
                }
                var generic = ifaceInfo.GetGenericTypeDefinition();
                if (generic != typeof(IDictionary<,>))
                {
                    return null;
                }
                var typeArguments = ifaceInfo.GenericTypeArguments;
                return typeArguments[0] == typeof(string) ? typeArguments[1] : null;
            }
        }

        /// <summary>
        /// Creates a map value from a BCL dictionary.
        /// </summary>
        internal static Value CreateMapValue(IDictionary<string, Value> values) => new Value { MapValue = new MapValue { Fields = { values } } };

        /// <summary>
        /// Creates an array value from a BCL sequence.
        /// </summary>
        internal static Value CreateArrayValue(IEnumerable<Value> values) =>
            new Value { ArrayValue = new ArrayValue { Values = { values.Select(value => ValidateNotArray(value)) } } };

        private static Value ValidateNotArray(Value input)
        {
            if (input.ArrayValue != null)
            {
                throw new ArgumentException("Array values cannot directly contain other array values");
            }
            return input;
        }
    }
}
