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
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for converting KeyValuePair Enumerables to several types,
    /// including Protobuf well known types.
    /// </summary>
    internal static class KeyValuePairEnumerableExtensions
    {
        /// <summary>
        /// Returns a <see cref="Value"/> for a <see cref="Struct"/> that will contain
        /// a field for each key present in <paramref name="fields"/>. The value of each
        /// field in the Struct will the the one associated to the corresponding key in
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="fields">The fields to convert to a Strcut. May be null or empty in
        /// which case this method will return null.</param>
        internal static Value ToStructValue(this IEnumerable<KeyValuePair<string, object>> fields)
        {
            if (fields is null)
            {
                return null;
            }

            bool hasValues = false;
            Struct fieldsStruct = new Struct();
            foreach (var pair in fields)
            {
                string key = pair.Key;
                if (string.IsNullOrEmpty(key))
                {
                    continue;
                }
                hasValues = true;
                if (char.IsDigit(key[0]))
                {
                    key = "_" + key;
                }
                fieldsStruct.Fields[key] = Value.ForString(pair.Value?.ToString() ?? "");
            }
            return hasValues ? Value.ForStruct(fieldsStruct) : null;
        }

        /// <summary>
        /// Returns a string representing the given fields with the format:
        /// ['key1'='value1']['key2'='value2']...
        /// </summary>
        internal static string ToDefaultStringRepresentation<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> fields)
        {
            GaxPreconditions.CheckNotNull(fields, nameof(fields));
            StringBuilder builder = new StringBuilder();
            foreach (var pair in fields)
            {
                builder.Append($"['{pair.Key}'='{pair.Value}']");
            }
            return builder.ToString();
        }
    }
}
