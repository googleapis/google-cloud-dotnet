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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region InsertRow
        /// <summary>
        /// Inserts a single row of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRow(TableReference, BigQueryInsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public virtual BigQueryInsertResults InsertRow(string projectId, string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null) =>
            InsertRow(GetTableReference(projectId, datasetId, tableId), row, options);

        /// <summary>
        /// Inserts a single row of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRow(TableReference, BigQueryInsertRow, InsertOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public virtual BigQueryInsertResults InsertRow(string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null) =>
            InsertRow(GetTableReference(datasetId, tableId), row, options);

        /// <summary>
        /// Inserts a single row of data into a table.
        /// This method just creates an array with the single element and delegates to <see cref="InsertRows(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public virtual BigQueryInsertResults InsertRow(TableReference tableReference, BigQueryInsertRow row, InsertOptions options = null) =>
            InsertRows(tableReference, new[] { GaxPreconditions.CheckNotNull(row, nameof(row)) }, options);

        /// <summary>
        /// Asynchronously inserts a single row of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRowAsync(TableReference, BigQueryInsertRow, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public virtual Task<BigQueryInsertResults> InsertRowAsync(string projectId, string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default) =>
            InsertRowAsync(GetTableReference(projectId, datasetId, tableId), row, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts a single row of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRowAsync(TableReference, BigQueryInsertRow, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public virtual Task<BigQueryInsertResults> InsertRowAsync(string datasetId, string tableId, BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default) =>
            InsertRowAsync(GetTableReference(datasetId, tableId), row, options, cancellationToken);

        /// <summary>
        /// Asynchronously inserts a single row of data into a table.
        /// This method just creates an array with the single element and delegates to <see cref="InsertRowsAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="row">The data to insert. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public virtual Task<BigQueryInsertResults> InsertRowAsync(TableReference tableReference, BigQueryInsertRow row, InsertOptions options = null, CancellationToken cancellationToken = default) =>
            InsertRowsAsync(tableReference, new[] { GaxPreconditions.CheckNotNull(row, nameof(row)) }, options, cancellationToken);
        #endregion

        #region InsertRows(array)
        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRows(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertRows(string, string, string, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public virtual BigQueryInsertResults InsertRows(string projectId, string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            InsertRows(GetTableReference(projectId, datasetId, tableId), rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table in this client's project.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRows(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertRows(string, string, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public virtual BigQueryInsertResults InsertRows(string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            InsertRows(GetTableReference(datasetId, tableId), rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just delegates to <see cref="InsertRows(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </summary>
        /// <remarks>
        /// Options are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertRows(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions)"/>.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>An insert result object which contains information on insert errors if any.</returns>
        public virtual BigQueryInsertResults InsertRows(TableReference tableReference, params BigQueryInsertRow[] rows) =>
            InsertRows(tableReference, rows, null);

        /// <summary>
        /// Inserts all the specified rows into a table.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRowsAsync(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options and cancellation tokens are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertRowsAsync(string, string, string, IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public virtual Task<BigQueryInsertResults> InsertRowsAsync(string projectId, string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            InsertRowsAsync(GetTableReference(projectId, datasetId, tableId), rows, null);

        /// <summary>
        /// Asynchronously inserts all the specified rows into a table in this client's project.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRowsAsync(TableReference, BigQueryInsertRow[])"/>.
        /// </summary>
        /// <remarks>
        /// Options and cancellation tokens are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertRowsAsync(string, string,IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public virtual Task<BigQueryInsertResults> InsertRowsAsync(string datasetId, string tableId, params BigQueryInsertRow[] rows) =>
            InsertRowsAsync(GetTableReference(datasetId, tableId), rows, null, CancellationToken.None);

        /// <summary>
        /// Asynchronously inserts all the specified rows into a table.
        /// This method just delegates to <see cref="InsertRowsAsync(TableReference, IEnumerable{BigQueryInsertRow}, InsertOptions,CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// Options and cancellation tokens are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertRowsAsync(TableReference, IEnumerable{BigQueryInsertRow},InsertOptions,CancellationToken)"/>.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rows">The rows to insert. Must not be null, or contain null elements.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an insert result object which contains information on insert errors if any.</returns>
        public virtual Task<BigQueryInsertResults> InsertRowsAsync(TableReference tableReference, params BigQueryInsertRow[] rows) =>
            InsertRowsAsync(tableReference, rows, null, CancellationToken.None);
        #endregion
    }
}
