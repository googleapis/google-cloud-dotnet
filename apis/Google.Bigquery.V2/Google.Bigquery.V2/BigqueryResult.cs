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

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// The result of a Bigquery query operation.
    /// </summary>
    public sealed class BigqueryResult
    {
        // TODO: Consider using PageStreamEnumerable here instead of PageStreamer. It's a hidden
        // implementation detail, but it may be cleaner.

        // TODO: Expose a REST resource? Slightly tricky as we have different paths to create a result (ListRows, ExecuteSql, GetQueryJobResults).

        private static readonly PageStreamer<TableRow, GetQueryResultsRequest, GetQueryResultsResponse, string> s_queryResultPageStreamer =
            new PageStreamer<TableRow, GetQueryResultsRequest, GetQueryResultsResponse, string>(
                (request, token) => request.PageToken = token,
                response => response.PageToken,
                response => response.Rows);

        private static readonly PageStreamer<TableRow, TabledataResource.ListRequest, TableDataList, string> s_tabledataListResultPageStreamer =
            new PageStreamer<TableRow, TabledataResource.ListRequest, TableDataList, string>(
                (request, token) => request.PageToken = token,
                response => response.PageToken,
                response => response.Rows);

        /// <summary>
        /// The schema of the results. This may be the schema of the original table, or it may be the effective schema of a query.
        /// </summary>
        public TableSchema Schema { get; }

        private readonly BigqueryClient _client;

        /// <summary>
        /// The rows of the query. If there are more rows than were returned in the first page of results,
        /// iterating over this will lazily evaluate the results each time, making further requests as necessary.
        /// </summary>
        public IEnumerable<Row> Rows { get; }

        internal BigqueryResult(BigqueryClient client, GetQueryResultsResponse firstResult, Func<GetQueryResultsRequest> requestProvider)
        {
            _client = client;
            Schema = firstResult.Schema;
            var firstRows = firstResult.Rows ?? new TableRow[0];
            Rows = firstRows.Concat(GetRemainingRows(requestProvider, firstResult.PageToken)).Select(row => new Row(this, row));
        }

        internal BigqueryResult(BigqueryClient client, TableDataList firstResult, TableSchema schema, Func<TabledataResource.ListRequest> requestProvider)
        {
            _client = client;
            Schema = schema;
            var firstRows = firstResult.Rows ?? new TableRow[0];
            Rows = firstRows.Concat(GetRemainingRows(requestProvider, firstResult.PageToken)).Select(row => new Row(this, row));
        }

        internal BigqueryResult(BigqueryClient client, QueryResponse syncResponse)
        {
            _client = client;
            Schema = syncResponse.Schema;
            var reference = syncResponse.JobReference;
            Func<GetQueryResultsRequest> requestProvider = () => client.Service.Jobs.GetQueryResults(reference.ProjectId, reference.JobId);
            var firstRows = syncResponse.Rows ?? new TableRow[0];
            Rows = firstRows.Concat(GetRemainingRows(requestProvider, syncResponse.PageToken)).Select(row => new Row(this, row));
        }

        private IEnumerable<TableRow> GetRemainingRows(Func<GetQueryResultsRequest> requestProvider, string pageToken)
        {
            // This is slightly odd as an iterator, but we want to create a new "base" request each time we iterate.
            // TODO: Validate that PageStreamer actually handles this properly. (What if we iterate over it multiple times?)
            if (string.IsNullOrEmpty(pageToken))
            {
                yield break;
            }
            var request = requestProvider();
            request.PageToken = pageToken;
            var results = s_queryResultPageStreamer.Fetch(request);
            foreach (var result in results)
            {
                yield return result;
            }
        }

        private IEnumerable<TableRow> GetRemainingRows(Func<TabledataResource.ListRequest> requestProvider, string pageToken)
        {
            // This is slightly odd as an iterator, but we want to create a new "base" request each time we iterate.
            // TODO: Validate that PageStreamer actually handles this properly. (What if we iterate over it multiple times?)
            if (string.IsNullOrEmpty(pageToken))
            {
                yield break;
            }
            var request = requestProvider();
            request.PageToken = pageToken;
            var results = s_tabledataListResultPageStreamer.Fetch(request);
            foreach (var result in results)
            {
                yield return result;
            }
        }

        private int GetFieldIndex(string fieldName)
        {
            for (int i = 0; i < Schema.Fields.Count; i++)
            {
                if (Schema.Fields[i].Name == fieldName)
                {
                    return i;
                }
            }
            throw new KeyNotFoundException($"No such field: '{fieldName}'");
        }

        /// <summary>
        /// A row within the result.
        /// </summary>
        public sealed class Row
        {
            private readonly BigqueryResult _parent;
            public TableRow RawRow { get; }

            internal Row(BigqueryResult parent, TableRow rawRow)
            {
                _parent = parent;
                RawRow = rawRow;
            }

            private static readonly Func<string, string> StringConverter = v => v;
            private static readonly Func<string, long> Int64Converter = v => long.Parse(v, CultureInfo.InvariantCulture);
            private static readonly Func<string, double> DoubleConverter = v => double.Parse(v, CultureInfo.InvariantCulture);
            private static readonly Func<string, DateTime> DateTimeConverter = v => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(DoubleConverter(v));
            private static readonly Func<string, byte[]> BytesConverter = v => Convert.FromBase64String(v);
            private static readonly Func<string, bool> BooleanConverter = v => v == "true";


            /// <summary>
            /// Retrieves a cell value by field name.
            /// </summary>
            public object this[string name] => this[_parent.GetFieldIndex(name)];

            /// <summary>
            /// Retrieves a cell value by index.
            /// </summary>
            public object this[int index]
            {
                get
                {
                    object rawValue = RawRow.F[index].V;
                    var field = _parent.Schema.Fields[index];

                    return ConvertSingleValue(rawValue, field);
                }
            }

            private static object ConvertSingleValue(object rawValue, TableFieldSchema field)
            {
                if (rawValue == null)
                {
                    return null;
                }
                var type = field.GetFieldType();

                if (field.GetFieldMode() == FieldMode.Repeated)
                {
                    JArray array = (JArray)rawValue;
                    switch (type)
                    {
                        case BigqueryDbType.String:
                            return ConvertArray(array, StringConverter);
                        case BigqueryDbType.Integer:
                            return ConvertArray(array, Int64Converter);
                        case BigqueryDbType.Float:
                            return ConvertArray(array, DoubleConverter);
                        case BigqueryDbType.Bytes:
                            return ConvertArray(array, BytesConverter);
                        case BigqueryDbType.Boolean:
                            return ConvertArray(array, BooleanConverter);
                        case BigqueryDbType.Timestamp:
                            return ConvertArray(array, DateTimeConverter);
                        case BigqueryDbType.Record:
                            return ConvertRecordArray(array, field);
                        default:
                            throw new InvalidOperationException($"Unhandled field type {type} {rawValue.GetType()}");
                    }
                }
                switch (type)
                {
                    case BigqueryDbType.String:
                        return StringConverter((string)rawValue);
                    case BigqueryDbType.Integer:
                        return Int64Converter((string)rawValue);
                    case BigqueryDbType.Float:
                        return DoubleConverter((string)rawValue);
                    case BigqueryDbType.Bytes:
                        return BytesConverter((string)rawValue);
                    case BigqueryDbType.Boolean:
                        return BooleanConverter((string)rawValue);
                    case BigqueryDbType.Timestamp:
                        return DateTimeConverter((string)rawValue);
                    case BigqueryDbType.Record:
                        return ConvertRecord((JObject)rawValue, field);
                    default:
                        throw new InvalidOperationException($"Unhandled field type {type} {rawValue.GetType()}");
                }
            }

            // TODO: GetString etc, like IDataReader etc. (Should we actually implement IDataReader?)

            private static T[] ConvertArray<T>(JArray array, Func<string, T> converter)
            {
                T[] ret = new T[array.Count];
                for (int i = 0; i < ret.Length; i++)
                {
                    JObject value = (JObject)array[i];
                    ret[i] = converter((string) value["v"]);
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
                JArray values = (JArray) record["f"];
                if (values.Count != fields.Count)
                {
                    throw new InvalidOperationException($"Record had {values.Count} entries; expected {fields.Count}");
                }
                var ret = new Dictionary<string, object>(fields.Count);
                for (int i = 0; i < fields.Count; i++)
                {
                    var field = fields[i];                    
                    var token = values[i]["v"];
                    Console.WriteLine($"Converting field {field.Name} from token type {token.Type} - token {token}");
                    ret[field.Name] = ConvertSingleValue(token.Type == JTokenType.String ? (string)token : (object)token, field);
                }
                return ret;
            }
        }
    }
}
