// Copyright 2021 Google LLC
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

using Google.Api.Gax;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.Compute.V1
{
    /// <summary>
    /// Helper methods for conversion between the enums within the Compute
    /// API and the string representations used on the wire.
    /// </summary>
    public static class ComputeEnumHelpers
    {
        /// <summary>
        /// Attempts to parse the given string value as the wire representation of
        /// a <typeparamref name="TEnum"/> value.
        /// </summary>
        /// <typeparam name="TEnum">The enum type to convert <paramref name="value"/> to.</typeparam>
        /// <param name="value">The text value to parse.</param>
        /// <param name="result">The output parameter to store the result in. This will be the
        /// parsed value of <typeparamref name="TEnum"/> if the return value is true, or the
        /// default value otherwise.</param>
        /// <returns>true if the value was successfully parsed; false otherwise</returns>
        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct, Enum =>
            OriginalEnumValueHelper<TEnum>.TryParse(value, out result);

        /// <summary>
        /// Parses the given string value as the wire representation of a
        /// <typeparamref name="TEnum"/> value, throwing an exception if the value cannot be parsed.
        /// </summary>
        /// <typeparam name="TEnum">The enum type to convert <paramref name="value"/> to.</typeparam>
        /// <param name="value">The text value to parse.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="ArgumentException"><paramref name="value"/> is not a valid wire value for
        /// <typeparamref name="TEnum"/>.</exception>
        public static TEnum Parse<TEnum>(string value) where TEnum : struct, Enum =>
            OriginalEnumValueHelper<TEnum>.Parse(value);

        /// <summary>
        /// Converts the given enum value into the wire representation as a string.
        /// </summary>
        /// <typeparam name="TEnum">The enum type to convert to a string.</typeparam>
        /// <param name="value">The value to convert.</param>
        /// <returns>The string representation of the enum value.</returns>
        /// <exception cref="ArgumentException">The enum value is not defined, so it has no known
        /// wire representation.</exception>
        public static string Format<TEnum>(TEnum value) where TEnum : struct, Enum =>
            OriginalEnumValueHelper<TEnum>.Format(value);

        private static class OriginalEnumValueHelper<T> where T : struct, Enum
        {
            private static Dictionary<string, T> s_nameToValueMap;
            private static Dictionary<T, string> s_valueToNameMap;

            static OriginalEnumValueHelper()
            {
                s_nameToValueMap = CreateNameToValueMap();
                s_valueToNameMap = CreateValueToNameMap();
            }

            internal static bool TryParse(string value, out T result)
            {
                if (value is null)
                {
                    result = default;
                    return false;
                }
                return s_nameToValueMap.TryGetValue(value, out result);
            }

            internal static T Parse(string value)
            {
                GaxPreconditions.CheckNotNull(value, nameof(value));
                return s_nameToValueMap.TryGetValue(value, out var result)
                    ? result
                    : throw new ArgumentException($"Value '{value}' is not the wire representation of any known value in the '{typeof(T).FullName}' enum");
            }

            internal static string Format(T value) =>
                s_valueToNameMap.TryGetValue(value, out var text)
                ? text
                : throw new ArgumentException($"Specified value is not a known member of the '{typeof(T).FullName}' enum");

            private static Dictionary<string, T> CreateNameToValueMap() =>
                typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Where(f => f.IsStatic && f.FieldType == typeof(T))
                    .ToDictionary(f => f.GetCustomAttributes<OriginalNameAttribute>().Single().Name,
                                  f => (T) f.GetValue(null),
                                  StringComparer.Ordinal);

            private static Dictionary<T, string> CreateValueToNameMap() =>
                typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Where(f => f.IsStatic && f.FieldType == typeof(T))
                    .Where(f => f.GetCustomAttributes<OriginalNameAttribute>()
                                 .FirstOrDefault()?.PreferredAlias ?? true)
                    .ToDictionary(f => (T) f.GetValue(null),
                                  f => f.GetCustomAttributes<OriginalNameAttribute>().Single().Name);
        }
    }
}
