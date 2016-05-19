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
using System.Globalization;
using System.Linq;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// A row used for streaming data insertion.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This is effectively a dictionary where each key is the field name (a string)
    /// and the value is the corresponding value for that field.
    /// Supported value types:
    /// </para>
    /// <list type="bullet">
    ///   <item><c>System.Boolean</c></item>
    ///   <item><c>System.Int16</c></item>
    ///   <item><c>System.UInt16</c></item>
    ///   <item><c>System.Int32</c></item>
    ///   <item><c>System.UInt32</c></item>
    ///   <item><c>System.Int64</c></c></item>
    ///   <item><c>System.Float</c></item>
    ///   <item><c>System.Double</c></item>
    ///   <item><c>System.String</c></item>
    ///   <item><c>System.DateTime</c></item>
    ///   <item><c>System.DateTimeOffset</c></item>
    /// </list>
    /// <para>
    /// Note that all integer types are stored as <c>System.Int64</c>, and all floating point
    /// types are stored as <c>System.Double.</c> Date/time values are converted to UTC and stored
    /// as timestamps with precision of a microsecond.
    /// </para>
    /// </remarks>
    public sealed class InsertRow : IEnumerable
    {
        private static HashSet<Type> ValidTypes = new HashSet<Type>
        {
            typeof(int), typeof(long), typeof(uint),
            typeof(short), typeof(ushort),
            typeof(float), typeof(double),
            typeof(string), typeof(byte[]),
            typeof(bool),
            typeof(DateTime), typeof(DateTimeOffset)
        };

        private readonly IDictionary<string, object> _fields = new Dictionary<string, object>();

        /// <summary>
        /// To help ensure data consistency, you can supply an <see cref="InsertId" /> for each inserted row.
        /// BigQuery remembers this ID for at least one minute. If you try to stream the same set of rows within
        /// that time period and the insertId property is set, BigQuery uses the property to de-duplicate
        /// your data on a best effort basis.
        /// </summary>
        public string InsertId { get; set; }

        /// <summary>
        /// Constructs an empty row with the specified insert ID.
        /// </summary>
        /// <param name="insertId">Insert ID used for deduplication. May be null.</param>
        public InsertRow(string insertId)
        {
            InsertId = insertId;
        }

        /// <summary>
        /// Constructs an empty row with no insert ID.
        /// </summary>
        public InsertRow()
        {
        }

        /// <summary>
        /// Adds all the values in the specified dictionary to the row.
        /// </summary>
        /// <remarks>
        /// This being named <c>Add</c> rather than <c>AddRange</c> allows
        /// it to be specified in a collection initializer, which can be useful
        /// to provide a set of common fields and then some extra values.
        /// </remarks>
        /// <param name="fields">The fields to add to the row. Must not be null.</param>
        public void Add(IDictionary<string, object> fields)
        {
            Preconditions.CheckNotNull(fields, nameof(fields));
            foreach (var entry in fields)
            {
                Add(entry.Key, entry.Value);
            }
        }

        /// <summary>
        /// Adds a single field value to the row.
        /// </summary>
        /// <param name="key">The name of the field. Must be a valid BigQuery field name.</param>
        /// <param name="value">The value for the field, which must be <c>null</c> or one of the supported types.</param>
        public void Add(string key, object value)
        {
            TableSchemaBuilder.ValidateFieldName(key, nameof(key));
            ValidateValue(value, nameof(value));
            _fields.Add(key, value);
        }

        /// <summary>
        /// Returns an enumerator over the fields in this insert row. This
        /// method is only provided in order to implement <see cref="IEnumerable"/>,
        /// to permit collection initializers.
        /// </summary>
        /// <returns>An enumerator over the fields in this insert row.</returns>
        IEnumerator IEnumerable.GetEnumerator() => _fields.GetEnumerator();

        /// <summary>
        /// Accesses a field in the row by name.
        /// </summary>
        /// <param name="name">The name of the field to access. Must be a valid BigQuery field name.</param>
        /// <exception cref="KeyNotFoundException">The row does not have a key with the given name.</exception>
        /// <returns>The value associated with <paramref name="name"/>.</returns>
        public object this[string name]
        {
            get
            {
                TableSchemaBuilder.ValidateFieldName(name, nameof(name));
                return _fields[name];
            }
            set
            {
                TableSchemaBuilder.ValidateFieldName(name, nameof(name));
                ValidateValue(value, nameof(value));
                _fields[name] = value;
            }
        }

        /// <summary>
        /// Converts an insert row into the API representation.
        /// </summary>
        internal TableDataInsertAllRequest.RowsData ToRowsData()
            => new TableDataInsertAllRequest.RowsData
            {
                InsertId = InsertId,
                Json = _fields.ToDictionary(pair => pair.Key, pair => ConvertRowValue(pair.Value))
            };

        private static object ConvertRowValue(object value)
        {
            if (value is DateTime)
            {
                DateTime dt = (DateTime)value;
                // TODO: Maybe enforce universal only?
                return dt.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture);
            }
            if (value is DateTimeOffset)
            {
                DateTimeOffset dto = (DateTimeOffset)value;
                return dto.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture);
            }
            // Anything else should be fine as it is. We've already validated that it's a known type.
            return value;
        }

        private void ValidateValue(object value, string paramName)
        {
            if (value != null && !ValidTypes.Contains(value.GetType()))
            {
                throw new ArgumentException($"Unable to use value of type {value.GetType()} in {nameof(InsertRow)}", paramName);
            }
        }
    }
}
