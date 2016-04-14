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
using System.Collections;
using System.Collections.Generic;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Class making it simple to create a <see cref="TableSchema"/>.
    /// </summary>
    /// <remarks>
    /// This class only implements <see cref="IEnumerable"/> in order to allow it to be used in
    /// collection initializers.
    /// </remarks>
    public sealed class SchemaBuilder : IEnumerable
    {
        private readonly List<TableFieldSchema> fields = new List<TableFieldSchema>();

        /// <summary>
        /// Adds the given field to the schema being built.
        /// </summary>
        /// <param name="field">The field to add. Must not be null.</param>
        public void Add(TableFieldSchema field)
        {
            Preconditions.CheckNotNull(field, nameof(field));

            fields.Add(field);
        }

        /// <summary>
        /// Creates a field with the specified details, and adds it to the schema being built.
        /// </summary>
        /// <param name="name">The name of the field. Must not be null.</param>
        /// <param name="type">The type of the field. Must be a defined member within <see cref="SchemaFieldType"/>.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="SchemaFieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, SchemaFieldType type, SchemaFieldMode mode = SchemaFieldMode.Nullable, string description = null)
        {
            Preconditions.CheckNotNull(name, nameof(name));
            Preconditions.CheckArgument(Enum.IsDefined(typeof(SchemaFieldType), type), nameof(type), "Specified value is not a member of SchemaFieldType");
            Preconditions.CheckArgument(Enum.IsDefined(typeof(SchemaFieldMode), mode), nameof(mode), "Specified value is not a member of SchemaFieldMode");

            Add(new TableFieldSchema
            {
                Name = name,
                Type = type.ToString().ToUpperInvariant(),
                Mode = mode.ToString().ToUpperInvariant(),
                Description = description,
            });
        }

        /// <summary>
        /// Creates a nested field with the specified schema, and adds it to the schema being built.
        /// </summary>
        /// <param name="name">The name of the field. Must not be null.</param>
        /// <param name="nestedSchema">The schema for the nested field. Must not be null.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="SchemaFieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, TableSchema nestedSchema, SchemaFieldMode mode = SchemaFieldMode.Nullable, string description = null)
        {
            Preconditions.CheckNotNull(name, nameof(name));
            Preconditions.CheckNotNull(nestedSchema, nameof(nestedSchema));
            Preconditions.CheckArgument(Enum.IsDefined(typeof(SchemaFieldMode), mode), nameof(mode), "Specified value is not a member of SchemaFieldMode");

            Add(new TableFieldSchema
            {
                Name = name,
                Type = "RECORD",
                Fields = nestedSchema.Fields,
                Mode = mode.ToString().ToUpperInvariant(),
                Description = description,
            });
        }

        /// <summary>
        /// Creates a nested field with the specified schema, and adds it to the schema being built.
        /// This method simply delegates to <see cref="Add(string, TableSchema, SchemaFieldMode, string)"/> after calling <see cref="Build"/>
        /// on <paramref name="nestedSchema"/>.
        /// </summary>
        /// <param name="name">The name of the field. Must not be null.</param>
        /// <param name="nestedSchema">The schema for the nested field, in the form of a <see cref="SchemaBuilder"/>. Must not be null.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="SchemaFieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, SchemaBuilder nestedSchema, SchemaFieldMode mode = SchemaFieldMode.Nullable, string description = null) =>
            Add(Preconditions.CheckNotNull(name, nameof(name)),
                Preconditions.CheckNotNull(nestedSchema, nameof(nestedSchema)).Build(),
                mode,
                description);

        /// <summary>
        /// Constructs a <see cref="TableSchema"/> from this builder.
        /// </summary>
        /// <returns>A <see cref="TableSchema"/> from the fields added to this builder.</returns>
        public TableSchema Build() => new TableSchema { Fields = fields };


        /// <summary>
        /// Returns an iterator over the fields in this builder.
        /// </summary>
        /// <remarks>This method only exists to satisfy the C# language rules on collection initializers.</remarks>
        /// <returns>An iterator over the fields in this builder.</returns>
        IEnumerator IEnumerable.GetEnumerator() => fields.GetEnumerator();
    }

    /// <summary>
    /// The type of a field within a schema.
    /// </summary>
    public enum SchemaFieldType
    {
        // Note: Record isn't here, because it's implicit in adding a nested schema.

        /// <summary>
        /// An 64-bit signed integer value.
        /// </summary>
        Integer,
        /// <summary>
        /// Binary data.
        /// </summary>
        Bytes,
        /// <summary>
        /// A text value, up to 2MB when encoded in UTF-8.
        /// </summary>
        String,
        /// <summary>
        /// A timestamp with up to microsecond precision.
        /// </summary>
        Timestamp,
        /// <summary>
        /// A 64-bit IEEE binary floating-point value.
        /// </summary>
        Float,
        /// <summary>
        /// A Boolean value.
        /// </summary>
        Boolean
    }

    /// <summary>
    /// The mode of a field within a schema.
    /// </summary>
    public enum SchemaFieldMode
    {
        /// <summary>
        /// The field is optional.
        /// </summary>
        Nullable,
        /// <summary>
        /// The field is required.
        /// </summary>
        Required,
        /// <summary>
        /// The field is repeated.
        /// </summary>
        Repeated
    }
}
