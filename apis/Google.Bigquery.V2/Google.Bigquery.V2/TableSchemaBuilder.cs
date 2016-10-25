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
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using Google.Api.Gax.Rest;
using Google.Api.Gax;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Class making it simple to create a <see cref="TableSchema"/>.
    /// </summary>
    /// <remarks>
    /// This class only implements <see cref="IEnumerable"/> in order to allow it to be used in
    /// collection initializers.
    /// </remarks>
    public sealed class TableSchemaBuilder : IEnumerable
    {
        // From Bigquery documentation:
        // The name must contain only letters (a-z, A-Z), numbers (0-9),
        // or underscores (_), and must start with a letter or underscore.
        // The maximum length is 128 characters.
        private static readonly Regex s_fieldNamePattern = new Regex("^[a-zA-Z_][a-zA-Z0-9_]{0,127}$");
        private readonly List<TableFieldSchema> _fields = new List<TableFieldSchema>();

        /// <summary>
        /// Adds the given field to the schema being built.
        /// </summary>
        /// <param name="field">The field to add. Must not be null.</param>
        public void Add(TableFieldSchema field)
        {
            GaxPreconditions.CheckNotNull(field, nameof(field));

            _fields.Add(field);
        }

        /// <summary>
        /// Creates a field with the specified details, and adds it to the schema being built.
        /// </summary>
        /// <param name="name">The name of the field. Must be a valid field name.</param>
        /// <param name="type">The type of the field. Must be a defined member within <see cref="BigqueryDbType"/>, other than <c>Record</c>.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="FieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, BigqueryDbType type, FieldMode mode = FieldMode.Nullable, string description = null)
        {
            ValidateFieldName(name, nameof(name));
            GaxPreconditions.CheckArgument(type != BigqueryDbType.Record, nameof(type), "Record fields must be specified with their schema");

            Add(new TableFieldSchema
            {
                Name = name,
                Type = EnumMap<BigqueryDbType>.ToApiValue(type, nameof(type)),
                Mode = EnumMap<FieldMode>.ToApiValue(mode, nameof(mode)),
                Description = description,
            });
        }

        internal static void ValidateFieldName(string name, string paramName)
        {
            GaxPreconditions.CheckNotNull(name, paramName);
            GaxPreconditions.CheckArgument(s_fieldNamePattern.IsMatch(name), paramName, "Invalid field name '{0}'", name);
        }

        /// <summary>
        /// Creates a nested field with the specified schema, and adds it to the schema being built.
        /// </summary>
        /// <param name="name">The name of the field. Must be a valid field name.</param>
        /// <param name="nestedSchema">The schema for the nested field. Must not be null.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="FieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, TableSchema nestedSchema, FieldMode mode = FieldMode.Nullable, string description = null)
        {
            ValidateFieldName(name, nameof(name));
            GaxPreconditions.CheckNotNull(nestedSchema, nameof(nestedSchema));

            Add(new TableFieldSchema
            {
                Name = name,
                Fields = nestedSchema.Fields,
                Type = EnumMap<BigqueryDbType>.ToApiValue(BigqueryDbType.Record),
                Mode = EnumMap<FieldMode>.ToApiValue(mode, nameof(mode)),
                Description = description,
            });
        }

        /// <summary>
        /// Creates a nested field with the specified schema, and adds it to the schema being built.
        /// This method simply delegates to <see cref="Add(string, TableSchema, FieldMode, string)"/> after calling <see cref="Build"/>
        /// on <paramref name="nestedSchema"/>.
        /// </summary>
        /// <param name="name">The name of the field. Must be a valid field name.</param>
        /// <param name="nestedSchema">The schema for the nested field, in the form of a <see cref="TableSchemaBuilder"/>. Must not be null.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="FieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, TableSchemaBuilder nestedSchema, FieldMode mode = FieldMode.Nullable, string description = null)
        {
            var builtSchema = GaxPreconditions.CheckNotNull(nestedSchema, nameof(nestedSchema)).Build();
            Add(name, builtSchema, mode, description);
        }

        /// <summary>
        /// Constructs a <see cref="TableSchema"/> from this builder.
        /// </summary>
        /// <returns>A <see cref="TableSchema"/> from the fields added to this builder.</returns>
        public TableSchema Build() => new TableSchema { Fields = _fields };


        /// <summary>
        /// Returns an iterator over the fields in this builder.
        /// </summary>
        /// <remarks>This method only exists to satisfy the C# language rules on collection initializers.</remarks>
        /// <returns>An iterator over the fields in this builder.</returns>
        IEnumerator IEnumerable.GetEnumerator() => _fields.GetEnumerator();
    }
}
