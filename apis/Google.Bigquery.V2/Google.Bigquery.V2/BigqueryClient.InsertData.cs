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
using System;
using System.Collections.Generic;
using System.IO;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
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
        public virtual BigqueryJob UploadCsv(string projectId, string datasetId, string tableId,
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
        public virtual BigqueryJob UploadCsv(string datasetId, string tableId,
            TableSchema schema, Stream input, UploadCsvOptions options = null) =>
            UploadCsv(GetTableReference(datasetId, tableId), schema, input, options);

        /// <summary>
        /// Uploads a stream of CSV data to a table.
        /// </summary>
        /// /// <param name="datasetReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A data upload job.</returns>
        public virtual BigqueryJob UploadCsv(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null)
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
        public virtual BigqueryJob UploadJson(string projectId, string datasetId, string tableId,
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
        public virtual BigqueryJob UploadJson(string datasetId, string tableId,
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
        public virtual BigqueryJob UploadJson(TableReference tableReference,
            TableSchema schema, Stream input, UploadJsonOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inserts a single row of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, InsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string projectId, string datasetId, string tableId, InsertRow row, InsertOptions options = null) =>
            Insert(GetTableReference(projectId, datasetId, tableId), row, options);

        /// <summary>
        /// Inserts a single row of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, InsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string datasetId, string tableId, InsertRow row, InsertOptions options = null) =>
            Insert(GetTableReference(datasetId, tableId), row, options);

        /// <summary>
        /// Inserts a single row of data into a table.
        /// This method just creates an array with the single element and delegates to <see cref="Insert(TableReference, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(TableReference tableReference, InsertRow row, InsertOptions options = null) =>
            Insert(tableReference, new[] { GaxRestPreconditions.CheckNotNull(row, nameof(row)) }, options);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, InsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(string, string, string, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        public virtual void Insert(string projectId, string datasetId, string tableId, params InsertRow[] rows) =>
            Insert(GetTableReference(projectId, datasetId, tableId), rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table in this client's project.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, InsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(string, string, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        public virtual void Insert(string datasetId, string tableId, params InsertRow[] rows) =>
            Insert(GetTableReference(datasetId, tableId), rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just delegates to <see cref="Insert(TableReference, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(TableReference, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        public virtual void Insert(TableReference tableReference, params InsertRow[] rows) =>
            Insert(tableReference, rows, null);

        /// <summary>
        /// Inserts all the given rows of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string projectId, string datasetId, string tableId, IEnumerable<InsertRow> rows, InsertOptions options = null) =>
            Insert(GetTableReference(projectId, datasetId, tableId), rows, options);

        /// <summary>
        /// Inserts all the given rows of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="Insert(TableReference, IEnumerable{InsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(string datasetId, string tableId, IEnumerable<InsertRow> rows, InsertOptions options = null) =>
            Insert(GetTableReference(datasetId, tableId), rows, options);

        /// <summary>
        /// Inserts all the given rows of data into a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The data to insert. Must not be null, or contain null entries.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void Insert(TableReference tableReference, IEnumerable<InsertRow> rows, InsertOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
