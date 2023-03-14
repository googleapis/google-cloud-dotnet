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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region ExecuteQuery
        /// <summary>
        /// Executes a query.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method will only return when the query has completed. It simply delegates to <see cref="CreateQueryJob(string, IEnumerable{BigQueryParameter}, QueryOptions)"/>
        /// and then <see cref="BigQueryJob.GetQueryResults(GetQueryResultsOptions)"/>.
        /// </para>
        /// </remarks>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="parameters">The parameters for the query. May be null, which is equivalent to specifying an empty list of parameters. Must not contain null elements.</param>
        /// <param name="queryOptions">The options for the query. May be null, in which case defaults will be supplied.</param>
        /// <param name="resultsOptions">The options for retrieving query results. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public virtual BigQueryResults ExecuteQuery(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions queryOptions = null, GetQueryResultsOptions resultsOptions = null) =>
            CreateQueryJob(sql, parameters, queryOptions).GetQueryResults(resultsOptions);        

        /// <summary>
        /// Asynchronously executes a query.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// This method simply delegates to <see cref="CreateQueryJobAsync(string, IEnumerable{BigQueryParameter}, QueryOptions, CancellationToken)"/>
        /// and then <see cref="BigQueryJob.GetQueryResultsAsync(GetQueryResultsOptions, CancellationToken)"/>.
        /// </para>
        /// </remarks>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="parameters">The parameters for the query. May be null, which is equivalent to specifying an empty list of parameters. Must not contain null elements.</param>
        /// <param name="queryOptions">The options for the query. May be null, in which case defaults will be supplied.</param>
        /// <param name="resultsOptions">The options for retrieving query results. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryResults"/> representing the query.</returns>
        public virtual async Task<BigQueryResults> ExecuteQueryAsync(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions queryOptions = null, GetQueryResultsOptions resultsOptions = null, CancellationToken cancellationToken = default)
        {
            var job = await CreateQueryJobAsync(sql, parameters, queryOptions, cancellationToken).ConfigureAwait(false);
            return await job.GetQueryResultsAsync(resultsOptions, cancellationToken).ConfigureAwait(false);
        }        
        #endregion

        #region CreateQueryJob
        /// <summary>
        /// Creates a job for a SQL query.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="parameters">The parameters for the query. May be null, which is equivalent to specifying an empty list of parameters. Must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The query job created. Use <see cref="GetQueryResults(JobReference,GetQueryResultsOptions)"/> to retrieve
        /// the results of the query.</returns>
        public virtual BigQueryJob CreateQueryJob(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job for a SQL query.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="parameters">The parameters for the query. May be null, which is equivalent to specifying an empty list of parameters. Must not contain null elements.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the query job created. Use <see cref="GetQueryResultsAsync(JobReference,GetQueryResultsOptions,CancellationToken)"/> to retrieve
        /// the results of the query.</returns>
        public virtual Task<BigQueryJob> CreateQueryJobAsync(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ListRows
        /// <summary>
        /// Lists the rows within a table specified by project ID, dataset ID and table ID, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="ListRows(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual PagedEnumerable<TableDataList, BigQueryRow> ListRows(string projectId, string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRows(GetTableReference(projectId, datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table within this client's project specified by dataset ID and table ID, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="ListRows(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. If this is a partial schema, then partial rows
        /// will be fetched. See <see cref="GetTableOptions.SelectedFields"/> for how to obtain a table's partial schema.
        /// This may be null or empty (i.e. <see cref="TableSchema.Fields"/> null or empty), in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual PagedEnumerable<TableDataList, BigQueryRow> ListRows(string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRows(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. If this is a partial schema, then partial rows
        /// will be fetched. See <see cref="GetTableOptions.SelectedFields"/> for how to obtain a table's partial schema.
        /// This may be null or empty (i.e. <see cref="TableSchema.Fields"/> null or empty), in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual PagedEnumerable<TableDataList, BigQueryRow> ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the rows within a table specified by project ID, dataset ID and table ID, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="ListRowsAsync(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the rows within the table.</returns>
        public virtual PagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(string projectId, string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRowsAsync(GetTableReference(projectId, datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table within this client's project specified by dataset ID and table ID, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="ListRowsAsync(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the rows within the table.</returns>
        public virtual PagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRowsAsync(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the rows within the table.</returns>
        public virtual PagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// "Raw" version of GetQueryResults, with no translation to BigQueryResults.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="timeoutBase">A base value to use when applying a timeout, or null to use the current date/time.</param>
        /// <returns>The results of the query.</returns>
        internal virtual GetQueryResultsResponse GetRawQueryResults(JobReference jobReference, GetQueryResultsOptions options, DateTime? timeoutBase) =>
            throw new NotImplementedException();

        /// <summary>
        /// "Raw" version of GetQueryResultsAsync, with no translation to BigQueryResults.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="timeoutBase">A base value to use when applying a timeout, or null to use the current date/time.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The results of the query.</returns>
        internal virtual Task<GetQueryResultsResponse> GetRawQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options, DateTime? timeoutBase, CancellationToken cancellationToken) =>
            throw new NotImplementedException();

        // Note - these methods are not part of the regular "pattern", so are not in the GetQueryResults region above.
        // We want to remove them, if the underlying GetQueryResultsResponse starts including the table reference.
        // These methods allow us to call GetQueryResultsAsync from BigQueryJob without fetching the job again.
        internal virtual BigQueryResults GetQueryResults(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options) =>
            throw new NotImplementedException();
        internal virtual Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options, CancellationToken cancellationToken) =>
            throw new NotImplementedException();
    }
}
