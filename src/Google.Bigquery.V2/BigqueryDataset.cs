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
    /// A dataset within Bigquery.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying HTTP API resource and retains a reference to the original
    /// client, allowing for simpler dataset-oriented operations.
    /// </remarks>
    public sealed class BigqueryDataset
    {
        private readonly BigqueryClient _client;

        // TODO: We may want to expose this publicly.
        private readonly Dataset _apiResource;

        /// <summary>
        /// The fully-qualified identifier for the dataset.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID
        /// and dataset ID components.
        /// </remarks>
        public DatasetReference Reference => _apiResource.DatasetReference;

        internal BigqueryDataset(BigqueryClient client, DatasetList.DatasetsData apiResource)
            : this(client, new Dataset {
                      Id = apiResource.Id,
                      DatasetReference = apiResource.DatasetReference,
                      Kind = apiResource.Kind,
                      FriendlyName = apiResource.FriendlyName
                   })
        {
        }

        internal BigqueryDataset(BigqueryClient client, Dataset apiResource)
        {
            _client = client;
            _apiResource = apiResource;
        }

        /// <summary>
        /// Uploads a stream of CSV data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.UploadCsv(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public Job UploadCsv(string tableId, TableSchema schema, Stream input) =>
            _client.UploadCsv(GetTableReference(tableId), schema, input);

        /// <summary>
        /// Uploads a stream of JSON data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.UploadJson(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public Job UploadJson(string tableId, TableSchema schema, Stream input) =>
            _client.UploadJson(GetTableReference(tableId), schema, input);

        /// <summary>
        /// Lists the tables within this dataset.
        /// </summary>
        /// <returns>The tables within this dataset.</returns>
        public IEnumerable<BigqueryTable> ListTables() => _client.ListTables(Reference);

        /// <summary>
        /// Creates a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.CreateTable(TableReference, TableSchema)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. Must not be null.</param>
        /// <returns>The newly created table.</returns>
        public BigqueryTable CreateTable(string tableId, TableSchema schema) =>
            _client.CreateTable(GetTableReference(tableId), schema);

        /// <summary>
        /// Retrieves a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.CreateTable(TableReference, TableSchema)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <returns>The requested table.</returns>
        public BigqueryTable GetTable(string tableId) =>
            _client.GetTable(GetTableReference(tableId));

        /// <summary>
        /// Attempts to fetch the specified table within this dataset, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigqueryClient.GetOrCreateTable(TableReference, TableSchema)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <returns>The existing or new table.</returns>
        public BigqueryTable GetOrCreateTable(string tableId, TableSchema schema) =>
            _client.GetOrCreateTable(GetTableReference(tableId), schema);

        /// <summary>
        /// Creates a <see cref="TableReference"/> for a table within this dataset.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <returns>A <see cref="TableReference"/> representing the requested table.</returns>
        public TableReference GetTableReference(string tableId) => _client.GetTableReference(Reference.ProjectId, Reference.DatasetId, tableId);

        /// <summary>
        /// Deletes this dataset.
        /// </summary>
        public void Delete() => _client.DeleteDataset(Reference);
    }
}
