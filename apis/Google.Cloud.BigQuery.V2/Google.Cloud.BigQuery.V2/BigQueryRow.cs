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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A row in a result set, which may be from a query or from listing the rows in a table.
    /// </summary>
    public sealed class BigQueryRow
    {
        /// <summary>
        /// The underlying REST-ful resource for the row.
        /// </summary>
        public TableRow RawRow { get; }

        /// <summary>
        /// The schema to use when interpreting the row results.
        /// </summary>
        public TableSchema Schema { get; }

        internal BigQueryRow(TableRow rawRow, TableSchema schema)
        {
            Schema = schema;
            RawRow = rawRow;
        }

        private static readonly Func<string, string> StringConverter = v => v;
        private static readonly Func<string, long> Int64Converter = v => long.Parse(v, CultureInfo.InvariantCulture);
        private static readonly Func<string, double> DoubleConverter = v => double.Parse(v, CultureInfo.InvariantCulture);
        // AddSeconds rounds to the nearest millisecond, for some reason.
        // Instead, we work out the number of ticks and add that.
        private static readonly Func<string, DateTime> TimestampConverter = v =>
        {
            double seconds = DoubleConverter(v);
            long microseconds = (long) (seconds * 1e6);
            long ticks = microseconds * 10;
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddTicks(ticks);
        };
        private static readonly Func<string, DateTime> DateConverter = v => DateTime.ParseExact(v, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        private static readonly Func<string, TimeSpan> TimeConverter = v => DateTime.ParseExact(v, "HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture).TimeOfDay;
        private static readonly Func<string, DateTime> DateTimeConverter = v => DateTime.ParseExact(v, "yyyy-MM-dd'T'HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture);
        private static readonly Func<string, byte[]> BytesConverter = v => Convert.FromBase64String(v);
        private static readonly Func<string, bool> BooleanConverter = v => v == "true";

        /// <summary>
        /// Retrieves a cell value by field name.
        /// </summary>
        public object this[string name] => this[Schema.GetFieldIndex(name)];

        /// <summary>
        /// Retrieves a cell value by index.
        /// </summary>
        public object this[int index]
        {
            get
            {
                object rawValue = RawRow.F[index].V;
                var field = Schema.Fields[index];

                return ConvertSingleValue(rawValue, field);
            }
        }

        private static object ConvertSingleValue(object rawValue, TableFieldSchema field)
        {
            if (rawValue == null || (rawValue as JToken)?.Type == JTokenType.Null)
            {
                return null;
            }
            var type = field.GetFieldType();

            if (field.GetFieldMode() == BigQueryFieldMode.Repeated)
            {
                JArray array = (JArray)rawValue;
                switch (type)
                {
                    case BigQueryDbType.String:
                        return ConvertArray(array, StringConverter);
                    case BigQueryDbType.Int64:
                        return ConvertArray(array, Int64Converter);
                    case BigQueryDbType.Float64:
                        return ConvertArray(array, DoubleConverter);
                    case BigQueryDbType.Bytes:
                        return ConvertArray(array, BytesConverter);
                    case BigQueryDbType.Bool:
                        return ConvertArray(array, BooleanConverter);
                    case BigQueryDbType.Timestamp:
                        return ConvertArray(array, TimestampConverter);
                    case BigQueryDbType.Date:
                        return ConvertArray(array, DateConverter);
                    case BigQueryDbType.Time:
                        return ConvertArray(array, TimeConverter);
                    case BigQueryDbType.DateTime:
                        return ConvertArray(array, DateTimeConverter);
                    case BigQueryDbType.Struct:
                        return ConvertRecordArray(array, field);
                    default:
                        throw new InvalidOperationException($"Unhandled field type {type} {rawValue.GetType()}");
                }
            }
            switch (type)
            {
                case BigQueryDbType.String:
                    return StringConverter((string)rawValue);
                case BigQueryDbType.Int64:
                    return Int64Converter((string)rawValue);
                case BigQueryDbType.Float64:
                    return DoubleConverter((string)rawValue);
                case BigQueryDbType.Bytes:
                    return BytesConverter((string)rawValue);
                case BigQueryDbType.Bool:
                    return BooleanConverter((string)rawValue);
                case BigQueryDbType.Timestamp:
                    return TimestampConverter((string)rawValue);
                case BigQueryDbType.Date:
                    return DateConverter((string) rawValue);
                case BigQueryDbType.Time:
                    return TimeConverter((string) rawValue);
                case BigQueryDbType.DateTime:
                    return DateTimeConverter((string) rawValue);
                case BigQueryDbType.Struct:
                    return ConvertRecord((JObject)rawValue, field);
                default:
                    throw new InvalidOperationException($"Unhandled field type {type} (Underlying type: {rawValue.GetType()})");
            }
        }

        // TODO: GetString etc, like IDataReader etc. (Should we actually implement IDataReader?)

        private static T[] ConvertArray<T>(JArray array, Func<string, T> converter)
            => ConvertArray(array, (object obj) => converter((string) obj));

        private static T[] ConvertArray<T>(JArray array, Func<object, T> converter)
        {
            T[] ret = new T[array.Count];
            for (int i = 0; i < ret.Length; i++)
            {
                JValue value = (JValue) ((JObject) array[i])["v"];
                ret[i] = converter(value.Value);
            }
            return ret;
        }

        private static Dictionary<string, object>[] ConvertRecordArray(JArray array, TableFieldSchema fieldSchema)
        {
            var ret = new Dictionary<string, object>[array.Count];
            for (int i = 0; i < ret.Length; i++)
            {
                JObject value = (JObject)array[i];
                ret[i] = ConvertRecord((JObject)value["v"], fieldSchema);
            }
            return ret;
        }

        private static Dictionary<string, object> ConvertRecord(JObject record, TableFieldSchema fieldSchema)
        {
            var fields = fieldSchema.Fields;
            JArray values = (JArray)record["f"];
            if (values.Count != fields.Count)
            {
                throw new InvalidOperationException($"Record had {values.Count} entries; expected {fields.Count}");
            }
            var ret = new Dictionary<string, object>(fields.Count);
            for (int i = 0; i < fields.Count; i++)
            {
                var field = fields[i];
                var token = values[i]["v"];
                ret[field.Name] = ConvertSingleValue(token.Type == JTokenType.String ? (string)token : (object)token, field);
            }
            return ret;
        }
    }
}
