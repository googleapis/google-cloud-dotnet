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
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A dataset within BigQuery.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler dataset-oriented operations.
    /// </remarks>
    public sealed class BigQueryDataset
    {
        private readonly BigQueryClient _client;

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

        internal BigQueryDataset(BigQueryClient client, DatasetList.DatasetsData resource)
            : this(client, new Dataset {
                      Id = resource.Id,
                      DatasetReference = resource.DatasetReference,
                      Kind = resource.Kind,
                      FriendlyName = resource.FriendlyName
                   })
        {
        }

        internal BigQueryDataset(BigQueryClient client, Dataset resource)
        {
            _client = client;
            Resource = resource;
        }

        /// <summary>
        /// Uploads a stream of CSV data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadCsv(string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null) =>
            _client.UploadCsv(GetTableReference(tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of Avro data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadAvro(TableReference, TableSchema, Stream, UploadAvroOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadAvro(string tableId, TableSchema schema, Stream input, UploadAvroOptions options = null) =>
            _client.UploadAvro(GetTableReference(tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadJson(string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null) =>
            _client.UploadJson(GetTableReference(tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJson(TableReference, TableSchema, IEnumerable{string}, UploadJsonOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadJson(string tableId, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null) =>
            _client.UploadJson(GetTableReference(tableId), schema, rows, options);

        /// <summary>
        /// Lists the tables within this dataset.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="BigQueryClient.ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of tables within this dataset.</returns>
        public PagedEnumerable<TableList, BigQueryTable> ListTables(ListTablesOptions options = null) => _client.ListTables(Reference, options);

        /// <summary>
        /// Creates a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public BigQueryTable CreateTable(string tableId, TableSchema schema, CreateTableOptions options = null) =>
            _client.CreateTable(GetTableReference(tableId), schema, options);

        /// <summary>
        /// Retrieves a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.GetTable(TableReference, GetTableOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested table.</returns>
        public BigQueryTable GetTable(string tableId, GetTableOptions options = null) =>
            _client.GetTable(GetTableReference(tableId), options);

        /// <summary>
        /// Attempts to fetch the specified table within this dataset, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The existing or new table.</returns>
        public BigQueryTable GetOrCreateTable(string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            _client.GetOrCreateTable(GetTableReference(tableId), schema, getOptions, createOptions);

        /// <summary>
        /// Creates a <see cref="TableReference"/> for a table within this dataset.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <returns>A <see cref="TableReference"/> representing the requested table.</returns>
        public TableReference GetTableReference(string tableId) => _client.GetTableReference(Reference.ProjectId, Reference.DatasetId, tableId);

        /// <summary>
        /// Deletes this dataset.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="BigQueryClient.DeleteDataset(DatasetReference, DeleteDatasetOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Delete(DeleteDatasetOptions options = null) => _client.DeleteDataset(Reference, options);

        /// <summary>
        /// Updates this dataset to match the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.UpdateDataset(DatasetReference, Dataset, UpdateDatasetOptions)"/>.
        /// A simple way of updating the dataset is to modify <see cref="Resource"/> and then call this method with no arguments.
        /// This is convenient, but it's important to understand that modifying <see cref="Resource"/> in this way leaves this object
        /// in an unusual state - it represents "the dataset as it was when fetched, but then modified locally". For example, the etag
        /// will be the original etag, rather than the one associated with the updated dataset. To avoid this causing confusion,
        /// we recommend only taking this approach if the object will not be used afterwards. Use the value returned by this method
        /// as the new, self-consistent representation of the dataset.
        /// </remarks>
        /// <param name="resource">The resource to update with. If null, the <see cref="Resource"/> property is
        /// used.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated dataset.</returns>
        public BigQueryDataset Update(Dataset resource = null, UpdateDatasetOptions options = null) =>
            _client.UpdateDataset(Reference, resource ?? Resource, options);

        /// <summary>
        /// Patches this dataset with fields in the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.PatchDataset(DatasetReference, Dataset, PatchDatasetOptions)"/>.
        /// </remarks>
        /// <param name="resource">The resource to patch with. Must not be null.</param>
        /// <param name="matchETag">If true, the etag from <see cref="Resource"/> is propagated into <paramref name="resource"/> for
        /// optimistic concurrency. Otherwise, <paramref name="resource"/> is left unchanged.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated dataset.</returns>
        public BigQueryDataset Patch(Dataset resource, bool matchETag, PatchDatasetOptions options = null)
        {
            if (matchETag)
            {
                resource.ETag = Resource.ETag;
            }
            return _client.PatchDataset(Reference, resource, options);
        }

        /// <summary>
        /// Asynchronously uploads a stream of CSV data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadCsvAsync(TableReference, TableSchema, Stream, UploadCsvOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadCsvAsync(string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.UploadCsvAsync(GetTableReference(tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of Avro data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadAvroAsync(TableReference, TableSchema, Stream, UploadAvroOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadAvroAsync(string tableId, TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.UploadAvroAsync(GetTableReference(tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of JSON data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJsonAsync(TableReference, TableSchema, IEnumerable{string}, UploadJsonOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadJsonAsync(string tableId, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.UploadJsonAsync(GetTableReference(tableId), schema, rows, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of JSON data to a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJsonAsync(TableReference, TableSchema, Stream, UploadJsonOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadJsonAsync(string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.UploadJsonAsync(GetTableReference(tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously lists the tables within this dataset.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="BigQueryClient.ListTablesAsync(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of tables within this dataset.</returns>
        public PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(ListTablesOptions options = null) => _client.ListTablesAsync(Reference, options);

        /// <summary>
        /// Asynchronously creates a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateTableAsync(TableReference, TableSchema, CreateTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the newly created table.</returns>
        public Task<BigQueryTable> CreateTableAsync(string tableId, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.CreateTableAsync(GetTableReference(tableId), schema, options, cancellationToken);

        /// <summary>
        /// Asynchronously retrieves a table within this dataset.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.GetTableAsync(TableReference, GetTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the requested table.</returns>
        public Task<BigQueryTable> GetTableAsync(string tableId, GetTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.GetTableAsync(GetTableReference(tableId), options, cancellationToken);

        /// <summary>
        /// Attempts to fetch the specified table within this dataset, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.GetOrCreateTableAsync(TableReference, TableSchema, GetTableOptions, CreateTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the existing or new table.</returns>
        public Task<BigQueryTable> GetOrCreateTableAsync(string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.GetOrCreateTableAsync(GetTableReference(tableId), schema, getOptions, createOptions, cancellationToken);

        /// <summary>
        /// Deletes this dataset.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="BigQueryClient.DeleteDatasetAsync(DatasetReference, DeleteDatasetOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteAsync(DeleteDatasetOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.DeleteDatasetAsync(Reference, options, cancellationToken);

        /// <summary>
        /// Asynchronously updates this dataset to match the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.UpdateDatasetAsync(DatasetReference, Dataset, UpdateDatasetOptions, CancellationToken)"/>.
        /// A simple way of updating the dataset is to modify <see cref="Resource"/> and then call this method with no arguments.
        /// This is convenient, but it's important to understand that modifying <see cref="Resource"/> in this way leaves this object
        /// in an unusual state - it represents "the dataset as it was when fetched, but then modified locally". For example, the etag
        /// will be the original etag, rather than the one associated with the updated dataset. To avoid this causing confusion,
        /// we recommend only taking this approach if the object will not be used afterwards. Use the value returned by this method
        /// as the new, self-consistent representation of the dataset.
        /// </remarks>
        /// <param name="resource">The resource to update with. If null, the <see cref="Resource"/> property is
        /// used.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated dataset.</returns>
        public Task<BigQueryDataset> UpdateAsync(Dataset resource = null, UpdateDatasetOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            _client.UpdateDatasetAsync(Reference, resource ?? Resource, options, cancellationToken);

        /// <summary>
        /// Asynchronously patches this dataset with fields in the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.PatchDatasetAsync(DatasetReference, Dataset, PatchDatasetOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="resource">The resource to patch with. Must not be null.</param>
        /// <param name="matchETag">If true, the etag from <see cref="Resource"/> is propagated into <paramref name="resource"/> for
        /// optimistic concurrency. Otherwise, <paramref name="resource"/> is left unchanged.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated dataset.</returns>
        public Task<BigQueryDataset> PatchAsync(Dataset resource, bool matchETag, PatchDatasetOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (matchETag)
            {
                resource.ETag = Resource.ETag;
            }
            return _client.PatchDatasetAsync(Reference, resource, options, cancellationToken);
        }
    }
}
