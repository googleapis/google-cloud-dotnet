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
        /// This method will only return when the query has completed. It simply delegates to <see cref="CreateQueryJob(string, QueryOptions)"/>
        /// and then <see cref="BigQueryJob.GetQueryResults(GetQueryResultsOptions)"/>.
        /// </para>
        /// </remarks>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="queryOptions">The options for the query. May be null, in which case defaults will be supplied.</param>
        /// <param name="resultsOptions">The options for retrieving query results. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public virtual BigQueryResults ExecuteQuery(string sql, QueryOptions queryOptions = null, GetQueryResultsOptions resultsOptions = null) =>
            CreateQueryJob(sql, queryOptions).GetQueryResults(resultsOptions);

        /// <summary>
        /// Executes a command. This overload allows query parameterization, and is preferred over
        /// <see cref="ExecuteQuery(string, QueryOptions, GetQueryResultsOptions)"/> when values need to be passed in.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method will only return when the query has completed. It simply delegates to <see cref="CreateQueryJob(BigQueryCommand, QueryOptions)"/>
        /// and then <see cref="BigQueryJob.GetQueryResults(GetQueryResultsOptions)"/>.
        /// </para>
        /// </remarks>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="queryOptions">The options for the query. May be null, in which case defaults will be supplied.</param>
        /// <param name="resultsOptions">The options for retrieving query results. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public virtual BigQueryResults ExecuteQuery(BigQueryCommand command, QueryOptions queryOptions = null, GetQueryResultsOptions resultsOptions = null) =>
            CreateQueryJob(command, queryOptions).GetQueryResults(resultsOptions);

        /// <summary>
        /// Asynchronously executes a query.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// This method simply delegates to <see cref="CreateQueryJobAsync(string, QueryOptions, CancellationToken)"/>
        /// and then <see cref="BigQueryJob.GetQueryResultsAsync(GetQueryResultsOptions, CancellationToken)"/>.
        /// </para>
        /// </remarks>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="queryOptions">The options for the query. May be null, in which case defaults will be supplied.</param>
        /// <param name="resultsOptions">The options for retrieving query results. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryResults"/> representing the query.</returns>
        public virtual async Task<BigQueryResults> ExecuteQueryAsync(string sql, QueryOptions queryOptions = null, GetQueryResultsOptions resultsOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var job = await CreateQueryJobAsync(sql, queryOptions, cancellationToken).ConfigureAwait(false);
            return await job.GetQueryResultsAsync(resultsOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously executes a command. This overload allows query parameterization, and is preferred over
        /// <see cref="ExecuteQueryAsync(string, QueryOptions, GetQueryResultsOptions, CancellationToken)"/> when values need to be passed in.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// This method simply delegates to <see cref="CreateQueryJobAsync(BigQueryCommand, QueryOptions, CancellationToken)"/>
        /// and then <see cref="BigQueryJob.GetQueryResultsAsync(GetQueryResultsOptions, CancellationToken)"/>.
        /// </para>
        /// </remarks>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="queryOptions">The options for the query. May be null, in which case defaults will be supplied.</param>
        /// <param name="resultsOptions">The options for retrieving query results. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryResults"/> representing the query.</returns>
        public virtual async Task<BigQueryResults> ExecuteQueryAsync(BigQueryCommand command, QueryOptions queryOptions = null, GetQueryResultsOptions resultsOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var job = await CreateQueryJobAsync(command, queryOptions, cancellationToken).ConfigureAwait(false);
            return await job.GetQueryResultsAsync(resultsOptions, cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region CreateQueryJob
        /// <summary>
        /// Creates a job for a SQL query.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The query job created. Use <see cref="GetQueryResults(JobReference,GetQueryResultsOptions)"/> to retrieve
        /// the results of the query.</returns>
        public virtual BigQueryJob CreateQueryJob(string sql, QueryOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a job for a query/command. This overload allows query parameterization, and is preferred over
        /// <see cref="CreateQueryJob(string, QueryOptions)"/> when values need to be passed in.
        /// </summary>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The query job created. Use <see cref="GetQueryResults(JobReference,GetQueryResultsOptions)"/> to retrieve
        /// the results of the query.</returns>
        public virtual BigQueryJob CreateQueryJob(BigQueryCommand command, QueryOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job for a SQL query.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the query job created. Use <see cref="GetQueryResultsAsync(JobReference,GetQueryResultsOptions,CancellationToken)"/> to retrieve
        /// the results of the query.</returns>
        public virtual Task<BigQueryJob> CreateQueryJobAsync(string sql, QueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job for a query/command. This overload allows query parameterization, and is preferred over
        /// <see cref="CreateQueryJobAsync(string, QueryOptions,CancellationToken)"/> when values need to be passed in.
        /// </summary>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the query job created. Use <see cref="GetQueryResultsAsync(JobReference,GetQueryResultsOptions,CancellationToken)"/> to retrieve
        /// the results of the query.</returns>
        public virtual Task<BigQueryJob> CreateQueryJobAsync(BigQueryCommand command, QueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetQueryResults
        /// <summary>
        /// Retrieves the results of the query job with specified by project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method will only return when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryResults GetQueryResults(string jobId, GetQueryResultsOptions options = null) =>
            GetQueryResults(GetJobReference(jobId), options);

        /// <summary>
        /// Retrieves the results of the query job with the specified ID in this clients project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method will only return when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryResults GetQueryResults(string projectId, string jobId, GetQueryResultsOptions options = null) =>
            GetQueryResults(GetJobReference(projectId, jobId), options);

        /// <summary>
        /// Retrieves the results of a query job.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method will only return when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryResults GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously retrieves the results of the query job with specified by project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResultsAsync(JobReference, GetQueryResultsOptions,CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryResults"/> representing the query.</returns>
        public virtual Task<BigQueryResults> GetQueryResultsAsync(string jobId, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetQueryResultsAsync(GetJobReference(jobId), options, cancellationToken);

        /// <summary>
        /// Asynchronously retrieves the results of the query job with the specified ID in this clients project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResultsAsync(JobReference, GetQueryResultsOptions,CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryResults"/> representing the query.</returns>
        public virtual Task<BigQueryResults> GetQueryResultsAsync(string projectId, string jobId, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetQueryResultsAsync(GetJobReference(projectId, jobId), options, cancellationToken);

        /// <summary>
        /// Asynchronously retrieves the results of a query job.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryResults"/> representing the query.</returns>
        public virtual Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ListRows
        /// <summary>
        /// Lists the rows within a table specified by project ID, dataset ID and table ID, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="ListRows(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
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
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual PagedEnumerable<TableDataList, BigQueryRow> ListRows(string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRows(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
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

        // Note - these methods are not part of the regular "pattern", so are not in the GetQueryResults region above.
        // We want to remove them, if the underlying GetQueryResultsResponse starts including the table reference.
        // These methods allow us to call GetQueryResultsAsync from BigQueryJob without fetching the job again.
        internal virtual BigQueryResults GetQueryResults(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options) =>
            throw new NotImplementedException();
        internal virtual Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options, CancellationToken cancellationToken) =>
            throw new NotImplementedException();
    }
}
