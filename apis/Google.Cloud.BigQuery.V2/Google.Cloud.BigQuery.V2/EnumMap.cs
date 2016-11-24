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
    }

    /// <summary>
    /// Conversion between enum values and their API representations.
    /// (Could make this a regular class, but we basically need an instance per type...)
    /// </summary>
    internal static class EnumMap<T> where T : struct
    {
        private static readonly Dictionary<string, T> s_stringToValue = new Dictionary<string, T>();
        private static readonly Dictionary<T, string> s_valueToString = new Dictionary<T, string>();

        static EnumMap()
        {
            foreach (var field in typeof(T).GetTypeInfo().DeclaredFields.Where(f => f.IsStatic))
            {
                var value = (T) field.GetValue(null);
                var nameAttribute = (ApiValueAttribute) field.GetCustomAttribute(typeof(ApiValueAttribute));
                var name = nameAttribute?.Value ?? value.ToString().ToUpperInvariant();
                s_stringToValue[name] = value;
                s_valueToString[value] = name;
            }
        }

        internal static string ToApiValue(T value, string paramName = "value")
        {
            string name;
            if (s_valueToString.TryGetValue(value, out name))
            {
                return name;
            }
            throw new ArgumentException($"Value {value} is undefined in {typeof(T).Name}", paramName);
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
