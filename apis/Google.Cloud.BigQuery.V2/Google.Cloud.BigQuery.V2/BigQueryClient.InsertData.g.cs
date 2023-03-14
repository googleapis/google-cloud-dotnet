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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2;

public abstract partial class BigQueryClient
{
    #region UploadCsv
    /// <summary>
    /// Uploads a stream of CSV data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadCsvOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadCsv(string datasetId, string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null) =>
        UploadCsv(GetTableReference(datasetId, tableId), schema, input, options);
    
    /// <summary>
    /// Uploads a stream of CSV data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream, UploadCsvOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadCsvOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadCsv(string projectId, string datasetId, string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null) =>
        UploadCsv(GetTableReference(projectId, datasetId, tableId), schema, input, options);
    
    /// <summary>
    /// Uploads a stream of CSV data to the specified table.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadCsvOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadCsv(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously uploads a stream of CSV data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsvAsync(TableReference, TableSchema, Stream, UploadCsvOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadCsvOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadCsvAsync(string datasetId, string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default) =>
        UploadCsvAsync(GetTableReference(datasetId, tableId), schema, input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of CSV data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsvAsync(TableReference, TableSchema, Stream, UploadCsvOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadCsvOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadCsvAsync(string projectId, string datasetId, string tableId, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default) =>
        UploadCsvAsync(GetTableReference(projectId, datasetId, tableId), schema, input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of CSV data to the specified table.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadCsvOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadCsvAsync(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UploadJson(Stream)
    /// <summary>
    /// Uploads a stream of JSON data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadJson(string datasetId, string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null) =>
        UploadJson(GetTableReference(datasetId, tableId), schema, input, options);
    
    /// <summary>
    /// Uploads a stream of JSON data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream, UploadJsonOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadJson(string projectId, string datasetId, string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null) =>
        UploadJson(GetTableReference(projectId, datasetId, tableId), schema, input, options);
    
    /// <summary>
    /// Uploads a stream of JSON data to the specified table.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadJson(TableReference tableReference, TableSchema schema, Stream input, UploadJsonOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously uploads a stream of JSON data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, Stream, UploadJsonOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadJsonAsync(string datasetId, string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
        UploadJsonAsync(GetTableReference(datasetId, tableId), schema, input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of JSON data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, Stream, UploadJsonOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadJsonAsync(string projectId, string datasetId, string tableId, TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
        UploadJsonAsync(GetTableReference(projectId, datasetId, tableId), schema, input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of JSON data to the specified table.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadJsonAsync(TableReference tableReference, TableSchema schema, Stream input, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UploadJson(strings)
    /// <summary>
    /// Uploads a sequence of JSON rows to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, IEnumerable{string}, UploadJsonOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each element of <paramref name="rows" /> is converted into a single line of text by replacing carriage returns and line
    /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
    /// original JSON can be formatted however you choose.
    /// </para>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadJson(string datasetId, string tableId, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null) =>
        UploadJson(GetTableReference(datasetId, tableId), schema, rows, options);
    
    /// <summary>
    /// Uploads a sequence of JSON rows to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, IEnumerable{string}, UploadJsonOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each element of <paramref name="rows" /> is converted into a single line of text by replacing carriage returns and line
    /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
    /// original JSON can be formatted however you choose.
    /// </para>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadJson(string projectId, string datasetId, string tableId, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null) =>
        UploadJson(GetTableReference(projectId, datasetId, tableId), schema, rows, options);
    
    /// <summary>
    /// Uploads a sequence of JSON rows to the specified table.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each element of <paramref name="rows" /> is converted into a single line of text by replacing carriage returns and line
    /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
    /// original JSON can be formatted however you choose.
    /// </para>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadJson(TableReference tableReference, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously uploads a sequence of JSON rows to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, IEnumerable{string}, UploadJsonOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each element of <paramref name="rows" /> is converted into a single line of text by replacing carriage returns and line
    /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
    /// original JSON can be formatted however you choose.
    /// </para>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadJsonAsync(string datasetId, string tableId, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
        UploadJsonAsync(GetTableReference(datasetId, tableId), schema, rows, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a sequence of JSON rows to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJsonAsync(TableReference, TableSchema, IEnumerable{string}, UploadJsonOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each element of <paramref name="rows" /> is converted into a single line of text by replacing carriage returns and line
    /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
    /// original JSON can be formatted however you choose.
    /// </para>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadJsonAsync(string projectId, string datasetId, string tableId, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
        UploadJsonAsync(GetTableReference(projectId, datasetId, tableId), schema, rows, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a sequence of JSON rows to the specified table.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each element of <paramref name="rows" /> is converted into a single line of text by replacing carriage returns and line
    /// feeds with spaces. This is safe as they cannot exist within well-formed JSON keys or values, and simply means that the
    /// original JSON can be formatted however you choose.
    /// </para>
    /// <para>
    /// The schema can come from three places: it can be specified by <paramref name="schema" />,
    /// it can be retrieved from the destination table if that already exists, or it can be inferred by the server.
    /// If <paramref name="schema" /> is null and the <see cref="UploadJsonOptions.Autodetect" /> of <paramref name="options" /> is not set to true,
    /// it is expected that the table already exists, and its schema is loaded automatically.
    /// </para>
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema of the data, or null for the schema to be loaded from the destination table or inferred (based on <paramref name="options"/>).</param>
    /// <param name="rows">The sequence of JSON strings to upload. Must not be null, and must not contain null elements.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadJsonAsync(TableReference tableReference, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UploadAvro
    /// <summary>
    /// Uploads a stream of Avro data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvro(TableReference, TableSchema, Stream, UploadAvroOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">Unused. In earlier versions this specified the schema of the data, but it is now ignored as the schema is always inferred from the data. The parameter is only present for backward compatibility.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadAvro(string datasetId, string tableId, TableSchema schema, Stream input, UploadAvroOptions options = null) =>
        UploadAvro(GetTableReference(datasetId, tableId), schema, input, options);
    
    /// <summary>
    /// Uploads a stream of Avro data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvro(TableReference, TableSchema, Stream, UploadAvroOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">Unused. In earlier versions this specified the schema of the data, but it is now ignored as the schema is always inferred from the data. The parameter is only present for backward compatibility.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadAvro(string projectId, string datasetId, string tableId, TableSchema schema, Stream input, UploadAvroOptions options = null) =>
        UploadAvro(GetTableReference(projectId, datasetId, tableId), schema, input, options);
    
    /// <summary>
    /// Uploads a stream of Avro data to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">Unused. In earlier versions this specified the schema of the data, but it is now ignored as the schema is always inferred from the data. The parameter is only present for backward compatibility.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadAvro(TableReference tableReference, TableSchema schema, Stream input, UploadAvroOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously uploads a stream of Avro data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvroAsync(TableReference, TableSchema, Stream, UploadAvroOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">Unused. In earlier versions this specified the schema of the data, but it is now ignored as the schema is always inferred from the data. The parameter is only present for backward compatibility.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadAvroAsync(string datasetId, string tableId, TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default) =>
        UploadAvroAsync(GetTableReference(datasetId, tableId), schema, input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of Avro data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadAvroAsync(TableReference, TableSchema, Stream, UploadAvroOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">Unused. In earlier versions this specified the schema of the data, but it is now ignored as the schema is always inferred from the data. The parameter is only present for backward compatibility.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadAvroAsync(string projectId, string datasetId, string tableId, TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default) =>
        UploadAvroAsync(GetTableReference(projectId, datasetId, tableId), schema, input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of Avro data to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">Unused. In earlier versions this specified the schema of the data, but it is now ignored as the schema is always inferred from the data. The parameter is only present for backward compatibility.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadAvroAsync(TableReference tableReference, TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UploadParquet
    /// <summary>
    /// Uploads a stream of Parquet data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadParquet(TableReference, Stream, UploadParquetOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadParquet(string datasetId, string tableId, Stream input, UploadParquetOptions options = null) =>
        UploadParquet(GetTableReference(datasetId, tableId), input, options);
    
    /// <summary>
    /// Uploads a stream of Parquet data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadParquet(TableReference, Stream, UploadParquetOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadParquet(string projectId, string datasetId, string tableId, Stream input, UploadParquetOptions options = null) =>
        UploadParquet(GetTableReference(projectId, datasetId, tableId), input, options);
    
    /// <summary>
    /// Uploads a stream of Parquet data to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadParquet(TableReference tableReference, Stream input, UploadParquetOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously uploads a stream of Parquet data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadParquetAsync(TableReference, Stream, UploadParquetOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadParquetAsync(string datasetId, string tableId, Stream input, UploadParquetOptions options = null, CancellationToken cancellationToken = default) =>
        UploadParquetAsync(GetTableReference(datasetId, tableId), input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of Parquet data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadParquetAsync(TableReference, Stream, UploadParquetOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadParquetAsync(string projectId, string datasetId, string tableId, Stream input, UploadParquetOptions options = null, CancellationToken cancellationToken = default) =>
        UploadParquetAsync(GetTableReference(projectId, datasetId, tableId), input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of Parquet data to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadParquetAsync(TableReference tableReference, Stream input, UploadParquetOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UploadOrc
    /// <summary>
    /// Uploads a stream of ORC data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadOrc(TableReference, Stream, UploadOrcOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadOrc(string datasetId, string tableId, Stream input, UploadOrcOptions options = null) =>
        UploadOrc(GetTableReference(datasetId, tableId), input, options);
    
    /// <summary>
    /// Uploads a stream of ORC data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadOrc(TableReference, Stream, UploadOrcOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadOrc(string projectId, string datasetId, string tableId, Stream input, UploadOrcOptions options = null) =>
        UploadOrc(GetTableReference(projectId, datasetId, tableId), input, options);
    
    /// <summary>
    /// Uploads a stream of ORC data to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A data upload job.</returns>
    public virtual BigQueryJob UploadOrc(TableReference tableReference, Stream input, UploadOrcOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously uploads a stream of ORC data to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadOrcAsync(TableReference, Stream, UploadOrcOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadOrcAsync(string datasetId, string tableId, Stream input, UploadOrcOptions options = null, CancellationToken cancellationToken = default) =>
        UploadOrcAsync(GetTableReference(datasetId, tableId), input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of ORC data to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadOrcAsync(TableReference, Stream, UploadOrcOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadOrcAsync(string projectId, string datasetId, string tableId, Stream input, UploadOrcOptions options = null, CancellationToken cancellationToken = default) =>
        UploadOrcAsync(GetTableReference(projectId, datasetId, tableId), input, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously uploads a stream of ORC data to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="input">The stream of input data. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a data upload job.</returns>
    public virtual Task<BigQueryJob> UploadOrcAsync(TableReference tableReference, Stream input, UploadOrcOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region InsertRows(sequence)
    /// <summary>
    /// Inserts all the given rows of data into the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRows(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>An insert result object which contains information on insert errors if any.</returns>
    public virtual BigQueryInsertResults InsertRows(string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null) =>
        InsertRows(GetTableReference(datasetId, tableId), rows, options);
    
    /// <summary>
    /// Inserts all the given rows of data into the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRows(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>An insert result object which contains information on insert errors if any.</returns>
    public virtual BigQueryInsertResults InsertRows(string projectId, string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null) =>
        InsertRows(GetTableReference(projectId, datasetId, tableId), rows, options);
    
    /// <summary>
    /// Inserts all the given rows of data into the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>An insert result object which contains information on insert errors if any.</returns>
    public virtual BigQueryInsertResults InsertRows(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously inserts all the given rows of data into the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRowsAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// an insert result object which contains information on insert errors if any.</returns>
    public virtual Task<BigQueryInsertResults> InsertRowsAsync(string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default) =>
        InsertRowsAsync(GetTableReference(datasetId, tableId), rows, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously inserts all the given rows of data into the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRowsAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// an insert result object which contains information on insert errors if any.</returns>
    public virtual Task<BigQueryInsertResults> InsertRowsAsync(string projectId, string datasetId, string tableId, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default) =>
        InsertRowsAsync(GetTableReference(projectId, datasetId, tableId), rows, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously inserts all the given rows of data into the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// an insert result object which contains information on insert errors if any.</returns>
    public virtual Task<BigQueryInsertResults> InsertRowsAsync(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
