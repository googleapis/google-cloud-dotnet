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

using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.IO;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// A table within a Bigquery dataset.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler table-oriented operations.
    /// </remarks>
    public sealed class BigqueryTable
    {
        private readonly BigqueryClient _client;

        /// <summary>
        /// The underlying REST-ful resource for the table.
        /// </summary>
        /// <remarks>
        /// The data within the resource may be incomplete, depending on how it was obtained.
        /// </remarks>
        public Table Resource { get; }

        /// <summary>
        /// The fully-qualified identifier for the table in a string form of <c>project:dataset.table</c>.
        /// </summary>
        public string FullyQualifiedId => $"{Reference.ProjectId}:{Reference.DatasetId}.{Reference.TableId}";

        /// <summary>
        /// The schema of this table, if known. Schemas are not retrieved when listing the tables within a dataset,
        /// so the value of this property can be <c>null</c>.
        /// </summary>
        public TableSchema Schema => Resource.Schema;

        /// <summary>
        /// The fully-qualified identifier for the table, as an object which can be used for other operations
        /// within this API.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID,
        /// dataset ID and table ID components.
        /// </remarks>
        public TableReference Reference => Resource.TableReference;

        internal BigqueryTable(BigqueryClient client, TableList.TablesData resource)
            : this(client, new Table {
                TableReference = resource.TableReference,
                FriendlyName = resource.FriendlyName,
                Id = resource.Id, Kind = resource.Kind
            })
        {
        }

        internal BigqueryTable(BigqueryClient client, Table resource)
        {
            _client = client;
            Resource = resource;
        }

        /// <summary>
        /// Uploads a stream of CSV data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigqueryJob UploadCsv(Stream input, UploadCsvOptions options = null) => _client.UploadCsv(Reference, Schema, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigqueryJob UploadJson(Stream input, UploadJsonOptions options = null) => _client.UploadJson(Reference, Schema, input, options);

        /// <summary>
        /// Lists the rows within this table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public IPagedEnumerable<TableDataList, BigqueryRow> ListRows(ListRowsOptions options = null) => _client.ListRows(Reference, Schema, options);

        /// <summary>
        /// Inserts a single row of data into this table.
        /// </summary>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Insert(InsertRow row, InsertOptions options = null) =>
            _client.Insert(Reference, row, options);

        /// <summary>
        /// Inserts all the given rows of data into this table.
        /// </summary>
        /// <param name="rows">The rows to insert. Must not be null or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Insert(IEnumerable<InsertRow> rows, InsertOptions options = null) =>
            _client.Insert(Reference, rows, options);

        /// <summary>
        /// Inserts all the given rows of data into this table.
        /// </summary>
        /// <param name="rows">The rows to insert. Must not be null or contain null entries.</param>
        public void Insert(params InsertRow[] rows) =>
            _client.Insert(Reference, rows);

        /// <summary>
        /// Deletes this table.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Delete(DeleteTableOptions options = null) => _client.DeleteTable(Reference, options);

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
