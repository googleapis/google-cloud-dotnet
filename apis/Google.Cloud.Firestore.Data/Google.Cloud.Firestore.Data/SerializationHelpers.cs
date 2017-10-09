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
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

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
        internal static bool IsAnonymousType(System.Type type) => type.GetTypeInfo().IsDefined(typeof(CompilerGeneratedAttribute));

        /// <summary>
        /// Checks whether <paramref name="type"/> refers to a type annotated with <see cref="FirestoreDataAttribute"/>.
        /// </summary>
        internal static bool IsFirestoreAttributedType(System.Type type) => type.GetTypeInfo().IsDefined(typeof(FirestoreDataAttribute));

        /// <summary>
        /// Creates a map value from a BCL dictionary.
        /// </summary>
        internal static Value CreateMapValue(IDictionary<string, Value> values) => new Value { MapValue = new MapValue { Fields = { values } } };

        /// <summary>
        /// Creates an array value from a BCL sequence.
        /// </summary>
        internal static Value CreateArrayValue(IEnumerable<Value> values) => new Value { ArrayValue = new ArrayValue { Values = { values } } };
    }
}
