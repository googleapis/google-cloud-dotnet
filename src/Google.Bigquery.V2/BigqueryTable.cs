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
using System.Collections.Generic;
using System.IO;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// A table within a Bigquery dataset.
    /// </summary>
    public sealed class BigqueryTable
    {
        private readonly BigqueryClient _client;
        // TODO: We may want to expose this publicly.
        private readonly Table _apiResource;

        /// <summary>
        /// The fully-qualified identifier for the table in a string form of <c>project:dataset.table</c>.
        /// </summary>
        public string FullyQualifiedId => $"{Reference.ProjectId}:{Reference.DatasetId}.{Reference.TableId}";

        /// <summary>
        /// The schema of this table, if known. Schemas are not retrieved when listing the tables within a dataset,
        /// so the value of this property can be <c>null</c>.
        /// </summary>
        public TableSchema Schema => _apiResource.Schema;

        /// <summary>
        /// The fully-qualified identifier for the table, as an object which can be used for other operations
        /// within this API.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID,
        /// dataset ID and table ID components.
        /// </remarks>
        public TableReference Reference => _apiResource.TableReference;

        internal BigqueryTable(BigqueryClient client, TableList.TablesData apiResource)
            : this(client, new Table {
                TableReference = apiResource.TableReference,
                FriendlyName = apiResource.FriendlyName,
                Id = apiResource.Id, Kind = apiResource.Kind
            })
        {
        }

        internal BigqueryTable(BigqueryClient client, Table apiResource)
        {
            _client = client;
            _apiResource = apiResource;
        }

        /// <summary>
        /// Uploads a stream of CSV data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public Job UploadCsv(Stream input) => _client.UploadCsv(Reference, Schema, input);

        /// <summary>
        /// Uploads a stream of JSON data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public Job UploadJson(Stream input) => _client.UploadJson(Reference, Schema, input);

        /// <summary>
        /// Lists the rows within this table, similar to a <code>SELECT * FROM ...</code> query.
        /// </summary>
        /// <returns>The results of listing the rows within the table.</returns>
        public BigqueryResult ListRows() => _client.ListRows(Reference, Schema);

        /// <summary>
        /// Inserts a single row of data into this table.
        /// </summary>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        /// <param name="insertId">The ID for the insertion, used to avoid data duplication. May be null.</param>
        public void InsertRow(IDictionary<string, object> data, string insertId = null) =>
            _client.InsertRow(Reference, data, insertId);

        /// <summary>
        /// Inserts all the given rows of data into this table.
        /// </summary>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        public void InsertRows(IEnumerable<IDictionary<string, object>> rowData) =>
            _client.InsertRows(Reference, rowData);

        /// <summary>
        /// Deletes this table.
        /// </summary>
        public void Delete() => _client.DeleteTable(Reference);

        /// <summary>
        /// Returns the fully qualified ID of the table in square brackets.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This is designed to facilitate constructing queries by simply
        /// including the table in the string.
        /// </para>
        /// <example>
        /// <code>
        /// var table = client.GetTable(datasetId, tableId);
        /// var query = $"SELECT name, age from {table}";
        /// </code>
        /// </example>
        /// </remarks>
        public override string ToString() => $"[{FullyQualifiedId}]";
    }
}
