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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Experimental class to build a <see cref="TableSchema"/> from an example, typically an anonymous
    /// type.
    /// </summary>
    public static class SchemaHelper
    {
        private static readonly Dictionary<Type, SchemaFieldType> s_knownTypes = new Dictionary<Type, SchemaFieldType>
        {
            { typeof(float), SchemaFieldType.Float },
            { typeof(double), SchemaFieldType.Float },
            { typeof(string), SchemaFieldType.String },
            { typeof(byte[]), SchemaFieldType.Bytes },
            { typeof(int), SchemaFieldType.Integer },
            { typeof(long), SchemaFieldType.Integer },
            { typeof(bool), SchemaFieldType.Boolean },
            { typeof(DateTime), SchemaFieldType.Timestamp },
            { typeof(DateTimeOffset), SchemaFieldType.Timestamp }
        };

        /// <summary>
        /// Creates a schema from the properties of a sample object.
        /// </summary>
        public static TableSchema FromExample(object example) =>
            new TableSchema { Fields = GetFields(example.GetType()) };

        private static IList<TableFieldSchema> GetFields(Type type) =>
            type.GetProperties()
                .Where(p => p.CanRead && p.GetGetMethod().IsPublic && !p.GetGetMethod().IsStatic)
                .Select(p => GetTableField(p))
                .ToList();

        private static TableFieldSchema GetTableField(PropertyInfo p)
        {
            SchemaFieldType type;
            if (!s_knownTypes.TryGetValue(p.PropertyType, out type))
            {
                throw new ArgumentException($"Untranslatable type: {p.PropertyType.Name}");
            }
            return new TableFieldSchema { Name = p.Name, Type = type.ToString().ToUpperInvariant() };
        }

        // TODO: Support repeated fields, nested fields, nullable
    }
}
