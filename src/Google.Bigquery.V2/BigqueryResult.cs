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
                    switch (field.Type)
                    {
                        case "STRING":
                            return (string)rawValue;
                        case "INTEGER":
                            return long.Parse((string)rawValue, CultureInfo.InvariantCulture);
                        case "FLOAT":
                            return double.Parse((string)rawValue, CultureInfo.InvariantCulture);
                        case "BYTES":
                            return Convert.FromBase64String((string)rawValue);
                        case "BOOL":
                            return (string)rawValue == "true";
                        case "TIMESTAMP":
                            double epochSeconds = double.Parse((string)rawValue, CultureInfo.InvariantCulture);
                            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epochSeconds);
                        // TODO: Handle record types and repeated fields.
                        default:
                            throw new InvalidOperationException($"Unknown field type {field.Type}");
                    }
                }
            }

            // TODO: GetString etc, like IDataReader etc. (Should we actually implement IDataReader?)
        }
    }
}
