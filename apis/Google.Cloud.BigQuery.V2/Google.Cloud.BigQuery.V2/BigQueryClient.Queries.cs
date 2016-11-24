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
        /// <summary>
        /// Executes a query.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public virtual BigQueryQueryJob ExecuteQuery(string sql, ExecuteQueryOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes a command. This overload allows query parameterization, and is preferred over
        /// <see cref="ExecuteQuery(string, ExecuteQueryOptions)"/> when values need to be passed in.
        /// </summary>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public virtual BigQueryQueryJob ExecuteQuery(BigQueryCommand command, ExecuteQueryOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a job for a SQL query, with more facilities than <see cref="ExecuteQuery(string, ExecuteQueryOptions)"/>, including the option
        /// to store the results in a persistent table.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The query job created. Use <see cref="GetQueryResults(JobReference,GetQueryResultsOptions)"/> to retrieve
        /// the results of the query.</returns>
        public virtual BigQueryJob CreateQueryJob(string sql, CreateQueryJobOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a job for a query/command, with more facilities than <see cref="ExecuteQuery(BigQueryCommand, ExecuteQueryOptions)"/>,
        /// including the option to store the results in a persistent table. This overload allows query parameterization, and is preferred over
        /// <see cref="CreateQueryJob(string, CreateQueryJobOptions)"/> when values need to be passed in.
        /// </summary>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The query job created. Use <see cref="GetQueryResults(JobReference,GetQueryResultsOptions)"/> to retrieve
        /// the results of the query.</returns>
        public virtual BigQueryJob CreateQueryJob(BigQueryCommand command, CreateQueryJobOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the results of the query job with specified by project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryQueryJob GetQueryResults(string jobId, GetQueryResultsOptions options = null) =>
            GetQueryResults(GetJobReference(jobId), options);

        /// <summary>
        /// Retrieves the results of the query job with the specified ID in this clients project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryQueryJob GetQueryResults(string projectId, string jobId, GetQueryResultsOptions options = null) =>
            GetQueryResults(GetJobReference(projectId, jobId), options);

        /// <summary>
        /// Retrieves the results of a query job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryQueryJob GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Polls the query job with the specified project ID and job ID until it has completed. The job must represent a query.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollQueryUntilCompleted(JobReference, GetQueryResultsOptions, PollSettings)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryQueryJob PollQueryUntilCompleted(string projectId, string jobId, GetQueryResultsOptions options = null, PollSettings pollSettings = null)
            => PollQueryUntilCompleted(GetJobReference(projectId, jobId), options, pollSettings);

        /// <summary>
        /// Polls the query job with the specified job ID in this project until it has completed. The job must represent a query.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollQueryUntilCompleted(JobReference, GetQueryResultsOptions, PollSettings)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryQueryJob PollQueryUntilCompleted(string jobId, GetQueryResultsOptions options = null, PollSettings pollSettings = null)
            => PollQueryUntilCompleted(GetJobReference(jobId), options, pollSettings);

        /// <summary>
        /// Polls the given job until it has completed. The job must represent a query.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigQueryQueryJob PollQueryUntilCompleted(JobReference jobReference, GetQueryResultsOptions options = null, PollSettings pollSettings = null)
        {
            throw new NotImplementedException();
        }

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
        public virtual IPagedEnumerable<TableDataList, BigQueryRow> ListRows(string projectId, string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
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
        public virtual IPagedEnumerable<TableDataList, BigQueryRow> ListRows(string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRows(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual IPagedEnumerable<TableDataList, BigQueryRow> ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously executes a query.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> ExecuteQueryAsync(string sql, ExecuteQueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously executes a command. This overload allows query parameterization, and is preferred over
        /// <see cref="ExecuteQueryAsync(string, ExecuteQueryOptions,CancellationToken)"/> when values need to be passed in.
        /// </summary>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> ExecuteQueryAsync(BigQueryCommand command, ExecuteQueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job for a SQL query, with more facilities than <see cref="ExecuteQueryAsync(string, ExecuteQueryOptions,CancellationToken)"/>, including the option
        /// to store the results in a persistent table.
        /// </summary>
        /// <param name="sql">The SQL query. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the query job created. Use <see cref="GetQueryResultsAsync(JobReference,GetQueryResultsOptions,CancellationToken)"/> to retrieve
        /// the results of the query.</returns>
        public virtual Task<BigQueryJob> CreateQueryJobAsync(string sql, CreateQueryJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job for a query/command, with more facilities than <see cref="ExecuteQueryAsync(BigQueryCommand, ExecuteQueryOptions,CancellationToken)"/>,
        /// including the option to store the results in a persistent table. This overload allows query parameterization, and is preferred over
        /// <see cref="CreateQueryJobAsync(string, CreateQueryJobOptions,CancellationToken)"/> when values need to be passed in.
        /// </summary>
        /// <param name="command">The command to execute. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the query job created. Use <see cref="GetQueryResultsAsync(JobReference,GetQueryResultsOptions,CancellationToken)"/> to retrieve
        /// the results of the query.</returns>
        public virtual Task<BigQueryJob> CreateQueryJobAsync(BigQueryCommand command, CreateQueryJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously retrieves the results of the query job with specified by project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResultsAsync(JobReference, GetQueryResultsOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> GetQueryResultsAsync(string jobId, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetQueryResultsAsync(GetJobReference(jobId), options, cancellationToken);

        /// <summary>
        /// Asynchronously retrieves the results of the query job with the specified ID in this clients project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResultsAsync(JobReference, GetQueryResultsOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> GetQueryResultsAsync(string projectId, string jobId, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetQueryResultsAsync(GetJobReference(projectId, jobId), options, cancellationToken);

        /// <summary>
        /// Asynchronously retrieves the results of a query job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> GetQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously polls the query job with the specified project ID and job ID until it has completed. The job must represent a query.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollQueryUntilCompletedAsync(JobReference, GetQueryResultsOptions, PollSettings, CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> PollQueryUntilCompletedAsync(string projectId, string jobId, GetQueryResultsOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
            => PollQueryUntilCompletedAsync(GetJobReference(projectId, jobId), options, pollSettings, cancellationToken);

        /// <summary>
        /// Asynchronously polls the query job with the specified job ID in this project until it has completed. The job must represent a query.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollQueryUntilCompletedAsync(JobReference, GetQueryResultsOptions, PollSettings, CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> PollQueryUntilCompletedAsync(string jobId, GetQueryResultsOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
            => PollQueryUntilCompletedAsync(GetJobReference(jobId), options, pollSettings, cancellationToken);

        /// <summary>
        /// Asynchronously polls the given job until it has completed. The job must represent a query.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the <see cref="BigQueryQueryJob"/> representing the query.</returns>
        public virtual Task<BigQueryQueryJob> PollQueryUntilCompletedAsync(JobReference jobReference, GetQueryResultsOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual IPagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(string projectId, string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
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
        public virtual IPagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRowsAsync(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the rows within the table.</returns>
        public virtual IPagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
