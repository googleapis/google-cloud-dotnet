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
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        /// <summary>
        /// Uploads a stream of CSV data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadCsv(string projectId, string datasetId, string tableId,
            TableSchema schema, Stream input, UploadCsvOptions options = null) =>
            UploadCsv(GetTableReference(projectId, datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of CSV data to a table in this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadCsv(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadCsvOptions options = null) =>
            UploadCsv(GetTableReference(datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of CSV data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadCsv(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads a stream of JSON data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadJson(string projectId, string datasetId, string tableId,
            TableSchema schema, Stream input, UploadJsonOptions options = null) =>
            UploadJson(GetTableReference(projectId, datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadJson(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadJsonOptions options = null) =>
            UploadJson(GetTableReference(datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of JSON data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadJson(TableReference tableReference,
            TableSchema schema, Stream input, UploadJsonOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads a sequence of JSON rows to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, IEnumerable{String}, UploadJsonOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadJson(string projectId, string datasetId, string tableId,
            TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null) =>
            UploadJson(GetTableReference(projectId, datasetId, tableId), schema, rows, options);

        /// <summary>
        /// Uploads a sequence of JSON rows to a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, IEnumerable{String}, UploadJsonOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadJson(string datasetId, string tableId,
            TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null) =>
            UploadJson(GetTableReference(datasetId, tableId), schema, rows, options);

        /// <summary>
        /// Uploads a sequence of JSON rows to a table.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadJson(TableReference tableReference,
            TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads a stream of Avro data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvro(TableReference, TableSchema, Stream, UploadAvroOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadAvro(string projectId, string datasetId, string tableId,
            TableSchema schema, Stream input, UploadAvroOptions options = null) =>
            UploadAvro(GetTableReference(projectId, datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of Avro data to a table in this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvro(TableReference, TableSchema, Stream, UploadAvroOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadAvro(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadAvroOptions options = null) =>
            UploadAvro(GetTableReference(datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of Avro data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigQueryJob UploadAvro(TableReference tableReference, TableSchema schema, Stream input, UploadAvroOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inserts a single row of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, BigQueryInsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string projectId, string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null) =>
            Insert(GetTableReference(projectId, datasetId, tableId), row, options);

        /// <summary>
        /// Inserts a single row of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, BigQueryInsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null) =>
            Insert(GetTableReference(datasetId, tableId), row, options);

        /// <summary>
        /// Inserts a single row of data into a table.
        /// This method just creates an array with the single element and delegates to <see cref="Insert(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(TableReference tableReference, BigQueryInsertRow row, InsertOptions options = null) =>
            Insert(tableReference, new[] { GaxPreconditions.CheckNotNull(row, nameof(row)) }, options);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(string, string, string, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        public virtual void Insert(string projectId, string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            Insert(GetTableReference(projectId, datasetId, tableId), rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table in this client's project.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(string, string, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        public virtual void Insert(string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            Insert(GetTableReference(datasetId, tableId), rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just delegates to <see cref="Insert(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        public virtual void Insert(TableReference tableReference, params BigQueryInsertRow[] rows) =>
            Insert(tableReference, rows, null);

        /// <summary>
        /// Inserts all the given rows of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string projectId, string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null) =>
            Insert(GetTableReference(projectId, datasetId, tableId), rows, options);

        /// <summary>
        /// Inserts all the given rows of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null) =>
            Insert(GetTableReference(datasetId, tableId), rows, options);

        /// <summary>
        /// Inserts all the given rows of data into a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously uploads a stream of CSV data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsvAsync(TableReference, TableSchema, Stream, UploadCsvOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadCsvAsync(string projectId, string datasetId, string tableId,
            TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadCsvAsync(GetTableReference(projectId, datasetId, tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of CSV data to a table in this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsvAsync(TableReference, TableSchema, Stream, UploadCsvOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadCsvAsync(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadCsvAsync(GetTableReference(datasetId, tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of CSV data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadCsvAsync(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously uploads a stream of Avro data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvroAsync(TableReference, TableSchema, Stream, UploadAvroOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadAvroAsync(string projectId, string datasetId, string tableId,
            TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadAvroAsync(GetTableReference(projectId, datasetId, tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of Avro data to a table in this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvroAsync(TableReference, TableSchema, Stream, UploadAvroOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadAvroAsync(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadAvroAsync(GetTableReference(datasetId, tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of Avro data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadAvroAsync(TableReference tableReference, TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously uploads a stream of JSON data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, Stream, UploadJsonOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadJsonAsync(string projectId, string datasetId, string tableId,
            TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadJsonAsync(GetTableReference(projectId, datasetId, tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of JSON data to a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, Stream, UploadJsonOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadJsonAsync(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadJsonAsync(GetTableReference(datasetId, tableId), schema, input, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a stream of JSON data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadJsonAsync(TableReference tableReference,
            TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously uploads a sequence of JSON rows to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, IEnumerable{String}, UploadJsonOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadJsonAsync(string projectId, string datasetId, string tableId,
            TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadJsonAsync(GetTableReference(projectId, datasetId, tableId), schema, rows, options, cancellationToken);

        /// <summary>
        /// Asynchronously uploads a sequence of JSON rows to a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, IEnumerable{String}, UploadJsonOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadJsonAsync(string datasetId, string tableId,
            TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UploadJsonAsync(GetTableReference(datasetId, tableId), schema, rows, options, cancellationToken);

        /// <summary>
        /// Uploads a sequence of JSON rows to a table.
        /// </summary>
        /// <remarks>
        /// Each element of <paramref name="rows"/> is converted into a single line of text by replacing carriage returns and line
        /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
        /// original JSON can be formatted however you choose.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a data upload job.</returns>
        public virtual Task<BigQueryJob> UploadJsonAsync(TableReference tableReference,
            TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously inserts a single row of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertAsync(TableReference, BigQueryInsertRow, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(string projectId, string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            InsertAsync(GetTableReference(projectId, datasetId, tableId), row, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts a single row of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertAsync(TableReference, BigQueryInsertRow, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            InsertAsync(GetTableReference(datasetId, tableId), row, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts a single row of data into a table.
        /// This method just creates an array with the single element and delegates to <see cref="InsertAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(TableReference tableReference, BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            InsertAsync(tableReference, new[] { GaxPreconditions.CheckNotNull(row, nameof(row)) }, options, cancellationToken);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertAsync(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options and cancellation tokens are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertAsync(string, string, string, IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(string projectId, string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            InsertAsync(GetTableReference(projectId, datasetId, tableId), rows, null);

        /// <summary>
        /// Asynchronously inserts all the specified rows into a table in this client's project.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertAsync(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options and cancellation tokens are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertAsync(string, string,IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            InsertAsync(GetTableReference(datasetId, tableId), rows, null, CancellationToken.None);

        /// <summary>
        /// Asynchronously inserts all the specified rows into a table.
        /// This method just delegates to <see cref="InsertAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// Options and cancellation tokens are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertAsync(TableReference, IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(TableReference tableReference, params BigQueryInsertRow[] rows) =>
            InsertAsync(tableReference, rows, null, CancellationToken.None);

        /// <summary>
        /// Asynchronously inserts all the given rows of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertAsync(TableReference, IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(string projectId, string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            InsertAsync(GetTableReference(projectId, datasetId, tableId), rows, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts all the given rows of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            InsertAsync(GetTableReference(datasetId, tableId), rows, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts all the given rows of data into a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task InsertAsync(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
