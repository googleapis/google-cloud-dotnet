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
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A table within a BigQuery dataset.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler table-oriented operations.
    /// </remarks>
    public sealed class BigQueryTable : IFormattable
    {
        private readonly BigQueryClient _client;

        /// <summary>
        /// The underlying REST-ful resource for the table.
        /// </summary>
        /// <remarks>
        /// The data within the resource may be incomplete, depending on how it was obtained.
        /// (ListTables operations return less data than GetTable operations.)
        /// </remarks>
        public Table Resource { get; }

        /// <summary>
        /// The fully-qualified identifier for the table in a string form of <c>project.dataset.table</c>.
        /// </summary>
        public string FullyQualifiedId => $"{Reference.ProjectId}.{Reference.DatasetId}.{Reference.TableId}";

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

        /// <summary>
        /// Constructs a new table.
        /// </summary>
        /// <remarks>
        /// This is public to allow tests to construct instances for production code to consume;
        /// production code should not normally construct instances itself.
        /// </remarks>
        /// <param name="client">The client to use for operations on the table. Must not be null.</param>
        /// <param name="resource">The REST-ful resource representing the table. Must not be null.</param>
        public BigQueryTable(BigQueryClient client, Table resource)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            Resource = GaxPreconditions.CheckNotNull(resource, nameof(resource));
        }

        /// <summary>
        /// Uploads a stream of CSV data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadCsv(Stream input, UploadCsvOptions options = null) => _client.UploadCsv(Reference, Schema, input, options);

        /// <summary>
        /// Uploads a stream of Avro data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadAvro(TableReference, TableSchema, Stream, UploadAvroOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadAvro(Stream input, UploadAvroOptions options = null) => _client.UploadAvro(Reference, Schema, input, options);

        /// <summary>
        /// Uploads a stream of Parquet data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadParquet(TableReference, Stream, UploadParquetOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadParquet(Stream input, UploadParquetOptions options = null) => _client.UploadParquet(Reference, input, options);

        /// <summary>
        /// Uploads a stream of ORC data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadOrc(TableReference, Stream, UploadOrcOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadOrc(Stream input, UploadOrcOptions options = null) => _client.UploadOrc(Reference, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadJson(Stream input, UploadJsonOptions options = null) => _client.UploadJson(Reference, Schema, input, options);

        /// <summary>
        /// Uploads a sequence of JSON rows to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJson(TableReference, TableSchema, IEnumerable{String}, UploadJsonOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public BigQueryJob UploadJson(IEnumerable<string> rows, UploadJsonOptions options = null) => _client.UploadJson(Reference, Schema, rows, options);

        /// <summary>
        /// Lists the rows within this table, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.ListRows(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public PagedEnumerable<TableDataList, BigQueryRow> ListRows(ListRowsOptions options = null) => _client.ListRows(Reference, Schema, options);

        /// <summary>
        /// Inserts a single row of data into this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.InsertRow(TableReference, BigQueryInsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public BigQueryInsertResults InsertRow(BigQueryInsertRow row, InsertOptions options = null) =>
            _client.InsertRow(Reference, row, options);

        /// <summary>
        /// Inserts all the given rows of data into this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.InsertRows(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="rows">The rows to insert. Must not be null or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public BigQueryInsertResults InsertRows(IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null) =>
            _client.InsertRows(Reference, rows, options);

        /// <summary>
        /// Inserts all the given rows of data into this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.InsertRows(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <param name="rows">The rows to insert. Must not be null or contain null entries.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public BigQueryInsertResults InsertRows(params BigQueryInsertRow[] rows) =>
            _client.InsertRows(Reference, rows);

        /// <summary>
        /// Deletes this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.DeleteTable(TableReference, DeleteTableOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Delete(DeleteTableOptions options = null) => _client.DeleteTable(Reference, options);

        /// <summary>
        /// Creates a job to extract data from this table to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateExtractJob(TableReference, String, CreateExtractJobOptions)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public BigQueryJob CreateExtractJob(string destinationUri, CreateExtractJobOptions options = null) =>
            _client.CreateExtractJob(Reference, destinationUri, options);

        /// <summary>
        /// Creates a job to extract data from this table to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateExtractJob(TableReference, IEnumerable{String}, CreateExtractJobOptions)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public BigQueryJob CreateExtractJob(IEnumerable<string> destinationUris, CreateExtractJobOptions options = null) =>
            _client.CreateExtractJob(Reference, destinationUris, options);

        /// <summary>
        /// Creates a job to copy data from this table to another.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateCopyJob(TableReference, TableReference, CreateCopyJobOptions)"/>.
        /// </summary>
        /// <remarks>
        /// This method only allows one table (this one) to be used as the source table. To copy multiple tables to one destination table,
        /// use <see cref="BigQueryClient.CreateCopyJob(IEnumerable{TableReference}, TableReference, CreateCopyJobOptions)"/>.
        /// </remarks>
        /// <param name="destination">The destination table to copy to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the copy operation.</returns>
        public BigQueryJob CreateCopyJob(TableReference destination, CreateCopyJobOptions options = null) =>
            _client.CreateCopyJob(Reference, destination, options);

        /// <summary>
        /// Updates this table to match the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.UpdateTable(TableReference, Table, UpdateTableOptions)"/>.
        /// A simple way of updating the table is to modify <see cref="Resource"/> and then call this method with no arguments.
        /// This is convenient, but it's important to understand that modifying <see cref="Resource"/> in this way leaves this object
        /// in an unusual state - it represents "the table as it was when fetched, but then modified locally". For example, the etag
        /// will be the original etag, rather than the one associated with the updated table. To avoid this causing confusion,
        /// we recommend only taking this approach if the object will not be used afterwards. Use the value returned by this method
        /// as the new, self-consistent representation of the table.
        /// </remarks>
        /// <param name="resource">The resource to update with. If null, the <see cref="Resource"/> property is
        /// used.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public BigQueryTable Update(Table resource = null, UpdateTableOptions options = null) =>
            _client.UpdateTable(Reference, resource ?? Resource, options);

        /// <summary>
        /// Patches this table with fields in the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.PatchTable(TableReference, Table, PatchTableOptions)"/>.
        /// </remarks>
        /// <param name="resource">The resource to patch with. Must not be null.</param>
        /// <param name="matchETag">If true, the etag from <see cref="Resource"/> is propagated into <paramref name="resource"/> for
        /// optimistic concurrency. Otherwise, <paramref name="resource"/> is left unchanged.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public BigQueryTable Patch(Table resource, bool matchETag, PatchTableOptions options = null)
        {
            if (matchETag)
            {
                resource.ETag = Resource.ETag;
            }
            return _client.PatchTable(Reference, resource, options);
        }

        /// <summary>
        /// Gets the IAM policy applied to this table.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.GetTableIamPolicy(TableReference, GetTableIamPolicyOptions)"/>.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The IAM policy.</returns>
        public Policy GetIamPolicy(GetTableIamPolicyOptions options = null) => _client.GetTableIamPolicy(Reference, options);

        /// <summary>
        /// Applies the given IAM policy to this table. An update mask may be provided through <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.SetTableIamPolicy(TableReference, Policy, SetTableIamPolicyOptions)"/>.
        /// </remarks>
        /// <param name="policy">The policy to apply to this table.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The resulting IAM policy after appying <paramref name="policy"/> to this table.</returns>
        public Policy SetIamPolicy(Policy policy, SetTableIamPolicyOptions options = null) => _client.SetTableIamPolicy(Reference, policy, options);

        /// <summary>
        /// Tests whether the caller has the given permissions for this table.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.TestTableIamPermissions(TableReference, IList{string}, TestTableIamPermissionsOptions)"/>.
        /// </remarks>
        /// <param name="permissions">The table permissions to test for this caller.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A response object that contains a list of permissions which is the subset of <paramref name="permissions"/>
        /// that the caller has on this table.</returns>
        public TestIamPermissionsResponse TestIamPermissions(IList<string> permissions, TestTableIamPermissionsOptions options = null) => _client.TestTableIamPermissions(Reference, permissions, options);

        /// <summary>
        /// Asynchronously uploads a stream of CSV data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadCsvAsync(TableReference, TableSchema, Stream, UploadCsvOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadCsvAsync(Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UploadCsvAsync(Reference, Schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of Avro data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadAvroAsync(TableReference, TableSchema, Stream, UploadAvroOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadAvroAsync(Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UploadAvroAsync(Reference, Schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of Parquet data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadParquetAsync(TableReference, Stream, UploadParquetOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadParquetAsync(Stream input, UploadParquetOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UploadParquetAsync(Reference, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of ORC data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadOrcAsync(TableReference, Stream, UploadOrcOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadOrcAsync(Stream input, UploadOrcOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UploadOrcAsync(Reference, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of JSON data to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJsonAsync(TableReference, TableSchema, IEnumerable{String}, UploadJsonOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadJsonAsync(IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UploadJsonAsync(Reference, Schema, rows, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a sequence of JSON rows to this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.UploadJsonAsync(TableReference, TableSchema, Stream, UploadJsonOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public Task<BigQueryJob> UploadJsonAsync(Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UploadJsonAsync(Reference, Schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously lists the rows within this table, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.ListRowsAsync(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the rows within the table.</returns>
        public PagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(ListRowsOptions options = null) => _client.ListRowsAsync(Reference, Schema, options);

        /// <summary>
        /// Asynchronously inserts a single row of data into this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.InsertRowAsync(TableReference, BigQueryInsertRow, InsertOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public Task<BigQueryInsertResults> InsertRowAsync(BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default) =>
            _client.InsertRowAsync(Reference, row, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts all the given rows of data into this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.InsertRowsAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="rows">The rows to insert. Must not be null or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public Task<BigQueryInsertResults> InsertRowsAsync(IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default) =>
            _client.InsertRowsAsync(Reference, rows, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts all the given rows of data into this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.InsertRowsAsync(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <param name="rows">The rows to insert. Must not be null or contain null entries.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public Task<BigQueryInsertResults> InsertRowsAsync(params BigQueryInsertRow[] rows) =>
            _client.InsertRowsAsync(Reference, rows);

        /// <summary>
        /// Asynchronously deletes this table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.DeleteTableAsync(TableReference, DeleteTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteAsync(DeleteTableOptions options = null, CancellationToken cancellationToken = default) =>
            _client.DeleteTableAsync(Reference, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to extract data from this table to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateExtractJobAsync(TableReference, String, CreateExtractJobOptions, CancellationToken)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the extract operation.</returns>
        public Task<BigQueryJob> CreateExtractJobAsync(string destinationUri, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
            _client.CreateExtractJobAsync(Reference, destinationUri, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to extract data from this table to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateExtractJobAsync(TableReference, IEnumerable{String}, CreateExtractJobOptions, CancellationToken)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the extract operation.</returns>
        public Task<BigQueryJob> CreateExtractJobAsync(IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
            _client.CreateExtractJobAsync(Reference, destinationUris, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to copy data from this table to another.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="BigQueryClient.CreateCopyJobAsync(TableReference, TableReference, CreateCopyJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// This method only allows one table (this one) to be used as the source table. To copy multiple tables to one destination table,
        /// use <see cref="BigQueryClient.CreateCopyJobAsync(IEnumerable{TableReference}, TableReference, CreateCopyJobOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="destination">The destination table to copy to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the copy operation.</returns>
        public Task<BigQueryJob> CreateCopyJobAsync(TableReference destination, CreateCopyJobOptions options = null, CancellationToken cancellationToken = default) =>
            _client.CreateCopyJobAsync(Reference, destination, options, cancellationToken);

        /// <summary>
        /// Asynchronously updates this table to match the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.UpdateTableAsync(TableReference, Table, UpdateTableOptions, CancellationToken)"/>.
        /// A simple way of updating the table is to modify <see cref="Resource"/> and then call this method with no arguments.
        /// This is convenient, but it's important to understand that modifying <see cref="Resource"/> in this way leaves this object
        /// in an unusual state - it represents "the table as it was when fetched, but then modified locally". For example, the etag
        /// will be the original etag, rather than the one associated with the updated table. To avoid this causing confusion,
        /// we recommend only taking this approach if the object will not be used afterwards. Use the value returned by this method
        /// as the new, self-consistent representation of the table.
        /// </remarks>
        /// <param name="resource">The resource to update with. If null, the <see cref="Resource"/> property is
        /// used.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public Task<BigQueryTable> UpdateAsync(Table resource = null, UpdateTableOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UpdateTableAsync(Reference, resource ?? Resource, options, cancellationToken);

        /// <summary>
        /// Asynchronously patches this table with fields in the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.PatchTableAsync(TableReference, Table, PatchTableOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="resource">The resource to patch with. Must not be null.</param>
        /// <param name="matchETag">If true, the etag from <see cref="Resource"/> is propagated into <paramref name="resource"/> for
        /// optimistic concurrency. Otherwise, <paramref name="resource"/> is left unchanged.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public Task<BigQueryTable> PatchAsync(Table resource, bool matchETag, PatchTableOptions options = null, CancellationToken cancellationToken = default)
        {
            if (matchETag)
            {
                resource.ETag = Resource.ETag;
            }
            return _client.PatchTableAsync(Reference, resource, options, cancellationToken);
        }

        /// <summary>
        /// Asynchronously gets the IAM policy applied to this table.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.GetTableIamPolicyAsync(TableReference, GetTableIamPolicyOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the IAM policy obtained.</returns>
        public Task<Policy> GetIamPolicyAsync(GetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
            _client.GetTableIamPolicyAsync(Reference, options, cancellationToken);

        /// <summary>
        /// Asynchronously applies the given IAM policy to this table. An update mask may be provided through <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.SetTableIamPolicyAsync(TableReference, Policy, SetTableIamPolicyOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="policy">The policy to apply to this table.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the resulting IAM policy after appying <paramref name="policy"/> to this table.</returns>
        public Task<Policy> SetIamPolicyAsync(Policy policy, SetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
            _client.SetTableIamPolicyAsync(Reference, policy, options, cancellationToken);

        /// <summary>
        /// Asynchronously tests whether the caller has the given permissions for this table.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.TestTableIamPermissionsAsync(TableReference, IList{string}, TestTableIamPermissionsOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="permissions">The table permissions to test for this caller.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a response object that contains a list of permissions which is the subset of <paramref name="permissions"/>
        /// that the caller has on this table.</returns>
        public Task<TestIamPermissionsResponse> TestIamPermissionsAsync(IList<string> permissions, TestTableIamPermissionsOptions options = null, CancellationToken cancellationToken = default) =>
            _client.TestTableIamPermissionsAsync(Reference, permissions, options, cancellationToken);

        /// <summary>
        /// Returns the fully-qualified ID of the table in Legacy SQL format. The Legacy SQL
        /// format uses square brackets instead of backticks to surround the ID, and uses a colon
        /// instead of a period between the project ID and the dataset ID.
        /// </summary>
        /// <returns>The fully-qualified ID of the table in Legacy SQL format.</returns>
        public string ToLegacySqlFormat() => $"[{Reference.ProjectId}:{Reference.DatasetId}.{Reference.TableId}]";

        /// <summary>
        /// Returns the fully-qualified ID of the table in backticks.
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
        public override string ToString() => $"`{FullyQualifiedId}`";

        /// <summary>
        /// Returns the fully-qualified ID of the table, in either the Standard SQL
        /// or Legacy SQL format.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method allows the Legacy SQL format to be used simply within an
        /// interpolated string.
        /// </para>
        /// <example>
        /// <code>
        /// var table = client.GetTable(datasetId, tableId);
        /// var query = $"SELECT name, age from {table:legacy}";
        /// </code>
        /// </example>
        /// </remarks>
        /// <param name="format">If this has a value of <c>"legacy"</c>, the Legacy SQL format
        /// is used; otherwise, the Standard SQL format is used.</param>
        /// <param name="formatProvider">Ignored.</param>
        /// <returns>The formatted table name.</returns>
        public string ToString(string format, IFormatProvider formatProvider) =>
            format == "legacy" ? ToLegacySqlFormat() : ToString();
    }
}
