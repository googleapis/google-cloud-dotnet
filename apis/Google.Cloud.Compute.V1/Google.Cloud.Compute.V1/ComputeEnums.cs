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

using Google.Protobuf.Reflection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

// Note: this entire file would be generated.

namespace Google.Cloud.Compute.V1
{
    /// <summary>
    /// Helper methods and constants for conversion between the enums within the Compute
    /// API and the string representations used on the wire.
    /// </summary>
    public static class ComputeEnums
    {
        /// <summary>
        /// FIXME
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct, Enum =>
            OriginalEnumValueHelper<TEnum>.TryParse(value, out result);

        /// <summary>
        /// FIXME
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TEnum Parse<TEnum>(string value) where TEnum : struct, Enum =>
            OriginalEnumValueHelper<TEnum>.Parse(value);

        /// <summary>
        /// FIXME
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Format<TEnum>(TEnum value) where TEnum : struct, Enum =>
            OriginalEnumValueHelper<TEnum>.Format(value);

        /// <summary>
        /// Container class for enums within the AccessConfig message.
        /// </summary>
        public static class AccessConfig
        {
            /// <summary>
            /// Constant wire values for the <see cref="V1.AccessConfig.Types.NetworkTier"/> enum.
            /// </summary>
            public static class NetworkTier
            {
                /// <summary>
                /// Wire value for <see cref="V1.AccessConfig.Types.NetworkTier.UndefinedNetworkTier"/>
                /// </summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>
                /// Wire value for <see cref="V1.AccessConfig.Types.NetworkTier.Premium"/>
                /// </summary>
                public const string Premium = "PREMIUM";


                /// <summary>
                /// Wire value for <see cref="V1.AccessConfig.Types.NetworkTier.Premium"/>
                /// </summary>
                public const string Standard = "STANDARD";
            }
        }

        private static class OriginalEnumValueHelper<T> where T : struct, Enum
        {
            private static Dictionary<string, T> s_nameToValueMap;
            private static Dictionary<T, string> s_valueToNameMap;

            static OriginalEnumValueHelper()
            {
                s_nameToValueMap = CreateNameToValueMap();
                s_valueToNameMap = CreateValueToNameMap();
            }

            internal static bool TryParse(string value, out T result) =>
                s_nameToValueMap.TryGetValue(value, out result);

            // TODO: Check that the behavior here is what we want.
            internal static T Parse(string value) =>
                s_nameToValueMap[value];

            internal static string Format(T value)
            {
                s_valueToNameMap.TryGetValue(value, out var text);
                // TODO: Is this what we want? Or throw an exception? Or return value.ToString()?
                return text;
            }

            private static Dictionary<string, T> CreateNameToValueMap() =>
                typeof(T).GetTypeInfo().DeclaredFields
                    .Where(f => f.IsStatic && f.FieldType == typeof(T))
                    .ToDictionary(f => f.GetCustomAttributes<OriginalNameAttribute>()
                                        .FirstOrDefault()
                                        // If the attribute hasn't been applied, fall back to the name of the field.
                                        ?.Name ?? f.Name,
                                  f => (T)f.GetValue(null));

            private static Dictionary<T, string> CreateValueToNameMap() =>
                typeof(T).GetTypeInfo().DeclaredFields
                    .Where(f => f.IsStatic && f.FieldType == typeof(T))
                    .Where(f => f.GetCustomAttributes<OriginalNameAttribute>()
                                 .FirstOrDefault()?.PreferredAlias ?? true)
                    .ToDictionary(f => (T) f.GetValue(null),
                                  f => f.GetCustomAttributes<OriginalNameAttribute>()
                                        .FirstOrDefault()
                                        // If the attribute hasn't been applied, fall back to the name of the field.
                                        ?.Name ?? f.Name);
        }
    }
}
