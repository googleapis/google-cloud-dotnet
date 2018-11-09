// Copyright 2018 Google LLC
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
using System.Collections;
using System.Collections.Generic;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A struct parameter or returned value.
    /// </summary>
    /// <remarks>
    /// A Spanner struct isn't exactly the same as a Google Protobuf struct:
    /// <list type="bullet">
    ///   <item><description>Field names are optional</description></item>
    ///   <item><description>Field names do not have to be unique</description></item>
    /// </list>
    /// </remarks>
    public sealed class SpannerStruct : IReadOnlyList<SpannerStruct.Field>
    {
        private readonly IList<Field> _fields = new List<Field>();

        /// <summary>
        /// Returns the number of fields currently in the struct.
        /// </summary>
        public int Count => _fields.Count;

        /// <summary>
        /// Returns the field at the given index.
        /// </summary>
        /// <param name="index">The index of the field to return</param>
        /// <returns>The field at the given index</returns>
        public Field this[int index] => _fields[index];

        /// <inheritdoc />
        public IEnumerator<Field> GetEnumerator() => _fields.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Adds a new field to the struct with the given name, type and value.
        /// </summary>
        /// <param name="name">The name of the field. May be null, and does not need to be unique within the struct.
        /// If the value is null, the <see cref="Field"/> value added will have an empty string for the name.</param>
        /// <param name="type">The type of the field. Must not be null.</param>
        /// <param name="value">The value of the field. May be null.</param>
        /// <returns>The newly-added field.</returns>
        public Field Add(string name, SpannerDbType type, object value) => Add(new Field(name, type, value));

        /// <summary>
        /// Adds a new field to the struct.
        /// </summary>
        /// <param name="field">The field to add. Must not be null.</param>
        /// <returns><paramref name="field"/> for convenience</returns>
        public Field Add(Field field)
        {
            _fields.Add(GaxPreconditions.CheckNotNull(field, nameof(field)));
            return field;
        }

        /// <summary>
        /// Returns the full schema of this struct as a <see cref="SpannerDbType"/>.
        /// </summary>
        /// <remarks>The returned object reflects the current fields in the struct. If more
        /// fields are added later, those changes will not be visible via the returned value.
        /// Instead, this method should be called again obtain the up-to-date schema.</remarks>
        /// <returns>The <see cref="SpannerDbType"/> representing the schema of this struct.</returns>
        public SpannerDbType GetSpannerDbType() => SpannerDbType.ForStruct(this);

        /// <summary>
        /// A field within a struct.
        /// </summary>
        public sealed class Field
        {
            /// <summary>
            /// Name of the field in the struct; will never be null, but may be empty.
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Type of the field. Never null.
            /// </summary>
            public SpannerDbType Type { get; }

            /// <summary>
            /// Value of the field. May be null.
            /// </summary>
            public object Value { get; }

            /// <summary>
            /// Constructs a struct field with the given name, type and value.
            /// </summary>
            /// <param name="name">Name of the field. May be null, which will be converted into an empty string.</param>
            /// <param name="type">Type of the field. Must not be null.</param>
            /// <param name="value">Value of the field. May be null.</param>
            public Field(string name, SpannerDbType type, object value)
            {
                Name = name ?? "";
                Type = GaxPreconditions.CheckNotNull(type, nameof(type));
                Value = value;
            }
        }
    }
}
