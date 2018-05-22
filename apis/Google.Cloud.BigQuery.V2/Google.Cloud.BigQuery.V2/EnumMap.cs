// Copyright 2016 Google Inc. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.BigQuery.V2
{
    [AttributeUsage(AttributeTargets.Field)]
    internal sealed class ApiValueAttribute : Attribute
    {
        public string Value { get; set; }

        public ApiValueAttribute(string value)
        {
            Value = value;
        }
    }

    /// <summary>
    /// Helpers for EnumMap{T} to take advantage of type inference.
    /// </summary>
    internal static class EnumMap
    {
        internal static string ToApiValue<T>(T value, string paramName = "value") where T : struct =>
            EnumMap<T>.ToApiValue(value, paramName);

        internal static ISet<string> ToApiValues<T>(T value) where T : struct =>
            EnumMap<T>.ToApiValues(value);
    }

    /// <summary>
    /// Conversion between enum values and their API representations.
    /// (Could make this a regular class, but we basically need an instance per type...)
    /// </summary>
    internal static class EnumMap<T> where T : struct
    {
        private static readonly Dictionary<string, T> s_stringToValue = new Dictionary<string, T>();
        private static readonly Dictionary<T, string> s_valueToString = new Dictionary<T, string>();
        private static readonly Dictionary<int, string> s_intValueToString =
            typeof(T).GetTypeInfo().IsDefined(typeof(FlagsAttribute))
            ? new Dictionary<int, string>() : null;

        static EnumMap()
        {
            foreach (var field in typeof(T).GetTypeInfo().DeclaredFields.Where(f => f.IsStatic))
            {
                var value = (T)field.GetValue(null);
                var nameAttribute = (ApiValueAttribute)field.GetCustomAttribute(typeof(ApiValueAttribute));
                var name = nameAttribute?.Value ?? value.ToString().ToUpperInvariant();
                s_stringToValue[name] = value;
                s_valueToString[value] = name;
                s_intValueToString?.Add((int)(object)value, name);
            }
        }

        internal static string ToApiValue(T value, string paramName = "value")
        {
            if (s_intValueToString != null)
            {
                throw new InvalidOperationException($"{typeof(T).Name} is marked with the {typeof(FlagsAttribute).Name} attribute. Use the {nameof(EnumMap.ToApiValues)} method instead.");
            }

            string name;
            if (s_valueToString.TryGetValue(value, out name))
            {
                return name;
            }
            throw new ArgumentException($"Value {value} is undefined in {typeof(T).Name}", paramName);
        }

        /// <summary>
        /// Similar to <see cref="ToApiValue(T, string)"/> but for used with Flags enum.
        /// </summary>
        /// <param name="value">An enum value, possibly flagged.</param>
        /// <returns>A set of string that contains the api value corresponding to each
        /// of the flags set in <paramref name="value"/>.</returns>
        internal static ISet<string> ToApiValues(T value)
        {
            if(s_intValueToString == null)
            {
                throw new InvalidOperationException($"{typeof(T).Name} is not marked with the {typeof(FlagsAttribute).Name} attribute. Use the {nameof(EnumMap.ToApiValue)} method instead.");
            }

            int intValue = (int)(object) value;
            ISet<string> apiValues = new HashSet<string>();
            foreach (var oneValue in s_intValueToString)
            {
                if((intValue & oneValue.Key) == oneValue.Key)
                {
                    apiValues.Add(oneValue.Value);
                    intValue = intValue ^ oneValue.Key;
                }
            }

            // We've removed all the valid flags from intValue.
            // If something remains is not valid.
            if (intValue != 0)
            {
                throw new ArgumentException($"At least one of the flags set in Value {value} is undefined in {typeof(T).Name}", nameof(value));
            }

            return apiValues;
        }

        internal static T ToValue(string apiValue, string paramName = "name")
        {
            GaxPreconditions.CheckNotNull(apiValue, paramName);
            T value;
            if (s_stringToValue.TryGetValue(apiValue, out value))
            {
                return value;
            }
            throw new ArgumentException($"Value {apiValue} is undefined in {typeof(T).Name}", paramName);
        }
    }
}
