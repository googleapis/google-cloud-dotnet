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
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.BigQuery.V2
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
    ///   <item><description><c>System.Boolean</c></description></item>
    ///   <item><description><c>System.Int16</c></description></item>
    ///   <item><description><c>System.UInt16</c></description></item>
    ///   <item><description><c>System.Int32</c></description></item>
    ///   <item><description><c>System.UInt32</c></description></item>
    ///   <item><description><c>System.Int64</c></description></item>
    ///   <item><description><c>System.Float</c></description></item>
    ///   <item><description><c>System.Double</c></description></item>
    ///   <item><description><c>System.String</c></description></item>
    ///   <item><description><c>System.DateTime</c></description></item>
    ///   <item><description><c>System.DateTimeOffset</c></description></item>
    ///   <item><description><c>System.TimeSpan</c></description></item>
    ///   <item><description>A <c>Google.Cloud.BigQuery.V2.InsertRow</c> (for record/struct fields)</description></item>
    ///   <item><description>Any <c>IReadOnlyList&lt;T&gt;</c> of one of the above types (for repeated fields). This
    ///   includes arrays and <c>List&lt;T&gt;</c> values.</description></item>
    /// </list>
    /// <para>
    /// Note that all integer types are stored as <c>System.Int64</c>, and all floating point
    /// types are stored as <c>System.Double.</c></para>
    /// <para><c>DateTimeOffset</c> values are converted to UTC and treated as timestamp. The handling
    /// of <c>DateTime</c> values depends on the <c>Kind</c>: values with a <c>Kind</c> of <c>Local</c> are rejected;
    /// values with a <c>Kind</c> of <c>UTC</c> are treated as timestamps; values with a <c>Kind</c> of <c>Unspecified</c>
    /// are treated as civil datetime values. All values are stored with a precision of a microsecond.
    /// </para>
    /// <para>
    /// <c>TimeSpan</c> values must be non-negative and less than 24 hours, used to represent a time-of-day.
    /// </para>
    /// <para>
    /// Although date values are retrieved as <c>System.DateTime</c>, they must be inserted as string values, in the format
    /// "yyyy-MM-dd".
    /// </para>
    /// <para>
    /// <see cref="BigQueryInsertRow"/> is used for record/struct fields for convenience, but only the <see cref="InsertId"/>
    /// of the top-level row is relevant.
    /// </para>
    /// <para>
    /// Null elements within repeated fields are prohibited. This is validated client-side when the row is inserted; validating
    /// when a value is added to the row would be ineffective as the values could change before insertion.
    /// </para>
    /// </remarks>
    public sealed class BigQueryInsertRow : IEnumerable
    {
        private static HashSet<Type> ValidSingleTypes = new HashSet<Type>
        {
            typeof(int), typeof(long), typeof(uint),
            typeof(short), typeof(ushort),
            typeof(float), typeof(double),
            typeof(string), typeof(byte[]),
            typeof(bool),
            typeof(DateTime), typeof(DateTimeOffset),
            typeof(TimeSpan),
            typeof(BigQueryInsertRow)
        };

        private static List<TypeInfo> ValidRepeatedTypes = ValidSingleTypes
            .Select(t => typeof(IReadOnlyList<>).MakeGenericType(t).GetTypeInfo())
            .ToList();

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
        public BigQueryInsertRow(string insertId)
        {
            InsertId = insertId;
        }

        /// <summary>
        /// Constructs an empty row with no insert ID.
        /// </summary>
        public BigQueryInsertRow()
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
            GaxPreconditions.CheckNotNull(fields, nameof(fields));
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
                Json = GetJsonValues()
            };

        internal Dictionary<string, object> GetJsonValues() => _fields.ToDictionary(pair => pair.Key, pair => ConvertRowValue(pair.Value));

        private static object ConvertRowValue(object value)
        {
            if (value == null)
            {
                return null;
            }
            if (value is DateTime)
            {
                DateTime dt = (DateTime)value;
                switch (dt.Kind)
                {
                    // Civil datetime
                    case DateTimeKind.Unspecified:
                        return dt.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture);
                    // Timestamp
                    case DateTimeKind.Utc:
                        return dt.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture);
                    // We can get into this situation if we accept a list of DateTime values. We can't
                    // validate when we're given the list, as it can change.
                    default:
                        throw new InvalidOperationException("Local DateTime values are not supported");
                }
            }
            else if (value is DateTimeOffset)
            {
                DateTimeOffset dto = (DateTimeOffset)value;
                // Timestamp
                return dto.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture);
            }
            else if (value is TimeSpan)
            {
                TimeSpan ts = (TimeSpan) value;
                if (ts < TimeSpan.Zero || ts >= TimeSpan.FromHours(24))
                {
                    throw new InvalidOperationException("TimeSpan values must be non-negative and less than 24 hours");
                }
                // This is ugly, but it avoids a trailing . when there are no fractional seconds.
                return (new DateTime(1970, 1, 1) + ts).ToString("HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture);
            }
            else if (value is BigQueryInsertRow)
            {
                return ((BigQueryInsertRow)value).GetJsonValues();
            }
            else if (ValidSingleTypes.Contains(value.GetType()))
            {
                // Anything single value should be fine as it is. We've already validated that it's a known type.
                return value;
            }
            // Note: not IEnumerable<object> as we need to box value types.
            IEnumerable values = (IEnumerable)value;
            return values.Cast<object>().Select(ValidateRepeatedElementNotNull).Select(ConvertRowValue).ToArray();
        }

        private static object ValidateRepeatedElementNotNull(object value)
        {
            if (value == null)
            {
                throw new InvalidOperationException("Elements of repeated fields must not be null");
            }
            return value;
        }

        private void ValidateValue(object value, string paramName)
        {
            if (value == null)
            {
                return;
            }
            Type type = value.GetType();
            if (value is DateTime)
            {
                DateTime dt = (DateTime) value;
                if (dt.Kind == DateTimeKind.Local)
                {
                    throw new ArgumentException("Local DateTime values are not supported", paramName);
                }
            }
            if (value is TimeSpan)
            {
                TimeSpan ts = (TimeSpan) value;
                if (ts < TimeSpan.Zero || ts >= TimeSpan.FromHours(24))
                {
                    throw new ArgumentException("TimeSpan values must be non-negative and less than 24 hours", paramName);
                }
            }
            if (ValidSingleTypes.Contains(type))
            {
                return;
            }
            TypeInfo typeInfo = type.GetTypeInfo();
            if (ValidRepeatedTypes.Any(ti => ti.IsAssignableFrom(typeInfo)))
            {
                return;
            }
            throw new ArgumentException($"Unable to use value of type {value.GetType()} in {nameof(BigQueryInsertRow)}", paramName);
        }
    }
}
