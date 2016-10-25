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
using System.IO;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// A dataset within Bigquery.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler dataset-oriented operations.
    /// </remarks>
    public sealed class BigqueryDataset
    {
        private readonly BigqueryClient _client;

        /// <summary>
        /// The underlying REST-ful resource for the dataset.
        /// </summary>
        /// <remarks>
        /// The data within the resource may be incomplete, depending on how it was obtained.
        /// </remarks>
        public Dataset Resource { get; }

        /// <summary>
        /// The fully-qualified identifier for the dataset as a <see cref="DatasetReference"/>.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID
        /// and dataset ID components.
        /// </remarks>
        public DatasetReference Reference => Resource.DatasetReference;

        /// <summary>
        /// The fully-qualified identifier for the dataset in a string form of <c>project:dataset</c>.
        /// </summary>
        public string FullyQualifiedId => $"{Reference.ProjectId}:{Reference.DatasetId}";

        internal BigqueryDataset(BigqueryClient client, DatasetList.DatasetsData resource)
            : this(client, new Dataset {
                      Id = resource.Id,
                      DatasetReference = resource.DatasetReference,
                      Kind = resource.Kind,
                      FriendlyName = resource.FriendlyName
                   })
        {
        }

        internal BigqueryDataset(BigqueryClient client, Dataset resource)
        {
            _client = client;
            Resource = resource;
        }

        /// <summary>
        /// Uploads a stream of CSV data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigqueryJob UploadCsv(string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null) =>
            _client.UploadCsv(GetTableReference(tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigqueryJob UploadJson(string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null) =>
            _client.UploadJson(GetTableReference(tableId), schema, input, options);

        /// <summary>
        /// Lists the tables within this dataset.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="BigqueryClient.ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of pages of tables within this dataset.</returns>
        public IPagedEnumerable<TableList, BigqueryTable> ListTables(ListTablesOptions options = null) => _client.ListTables(Reference, options);

        /// <summary>
        /// Creates a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public BigqueryTable CreateTable(string tableId, TableSchema schema, CreateTableOptions options = null) =>
            _client.CreateTable(GetTableReference(tableId), schema, options);

        /// <summary>
        /// Retrieves a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.GetTable(TableReference, GetTableOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested table.</returns>
        public BigqueryTable GetTable(string tableId, GetTableOptions options = null) =>
            _client.GetTable(GetTableReference(tableId), options);

        /// <summary>
        /// Attempts to fetch the specified table within this dataset, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The existing or new table.</returns>
        public BigqueryTable GetOrCreateTable(string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            _client.GetOrCreateTable(GetTableReference(tableId), schema, getOptions, createOptions);

        /// <summary>
        /// Creates a <see cref="TableReference"/> for a table within this dataset.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <returns>A <see cref="TableReference"/> representing the requested table.</returns>
        public TableReference GetTableReference(string tableId) => _client.GetTableReference(Reference.ProjectId, Reference.DatasetId, tableId);

        /// <summary>
        /// Deletes this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.DeleteTable(TableReference, DeleteTableOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Delete(DeleteDatasetOptions options = null) => _client.DeleteDataset(Reference, options);
    }
}
