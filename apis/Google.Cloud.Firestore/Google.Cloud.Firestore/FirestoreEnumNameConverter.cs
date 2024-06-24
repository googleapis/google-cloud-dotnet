// Copyright 2019, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Custom converter which uses enum value names instead of integer values as the Firestore representation.
    /// This converter is not used by default; it must be configured in the same way as any other custom converter.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Currently this is always case-sensitive, with no customization of the names used. In future releases
    /// we may introduce further ways to configure this converter, but the default behavior will remain the same.
    /// </para>
    /// <para>
    /// When the same enum value has multiple names, no guarantee is made about which one is returned, although both
    /// are accepted for conversion back to enum values. You are strongly encouraged not to use multiple names for the
    /// same value.
    /// </para>
    /// </remarks>
    /// <typeparam name="T">The enum type to convert</typeparam>
    public sealed class FirestoreEnumNameConverter<T> : IFirestoreConverter<T>
        where T : struct, Enum
    {
        // These dictionaries are static as they only depend on the type of T.
        // There's no point in doing the reflection again each time a converter is constructed.
        // If we introduce features like case-insensitivity or custom names, we may want to introduce instance
        // dictionary fields as well.
        private static readonly Dictionary<string, T> s_nameToValueMap;
        private static readonly Dictionary<T, string> s_valueToNameMap;

        static FirestoreEnumNameConverter()
        {
            s_nameToValueMap = new Dictionary<string, T>();
            s_valueToNameMap = new Dictionary<T, string>();

            foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var name = field.Name;
                var value = (T) field.GetValue(null);
                s_nameToValueMap[name] = value;
                // This may overwrite an existing value, but that's okay. We explicitly don't
                // make any guarantees as to which name is returned for a value with multiple names.
                s_valueToNameMap[value] = name;
            }
        }

        /// <inheritdoc />
        public T FromFirestore(object value) =>
            s_nameToValueMap.TryGetValue((string) value, out var result) ?
            result : throw new ArgumentException($"Unknown name '{value}' for enum {typeof(T).FullName}");

        /// <summary>
        /// Converts an enum value to its name.
        /// </summary>
        /// <remarks>
        /// If multiple values in the enum map to the same integer, it is undefined which will be returned.
        /// If the value is not a named enum element, an exception is thrown, even if the enum is
        /// decorated with <see cref="FlagsAttribute"/>.
        /// </remarks>
        /// <param name="value">The value to convert.</param>
        /// <returns>The name of the value.</returns>
        /// <exception cref="ArgumentException">The given value is not a named value within the enum.</exception>
        public object ToFirestore(T value) =>
            s_valueToNameMap.TryGetValue(value, out var result) ?
            result : throw new ArgumentException($"Unknown value '{value}' for enum {typeof(T).FullName}");
    }
}
