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
using System;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// Executes a query synchronously.
        /// </summary>
        /// <param name="sql">The query in BigQuery's SQL dialect. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public virtual BigqueryResult ExecuteQuery(string sql, ExecuteQueryOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a query job, with more facilities than <see cref="ExecuteQuery"/>, including the option
        /// to store the results in a persistent table.
        /// </summary>
        /// <param name="sql">The query in BigQuery's SQL dialect. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The query job created. Use <see cref="GetQueryResults(JobReference,GetQueryResultsOptions)"/> to retrieve
        /// the results of the query.</returns>
        public virtual BigqueryJob CreateQueryJob(string sql, CreateQueryJobOptions options = null)
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
        public virtual BigqueryResult GetQueryResults(string jobId, GetQueryResultsOptions options = null) =>
            GetQueryResults(GetJobReference(jobId), options);

        /// <summary>
        /// Retrieves the results of the query job with the specified ID in this clients project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigqueryResult GetQueryResults(string projectId, string jobId, GetQueryResultsOptions options = null) =>
            GetQueryResults(GetJobReference(projectId, jobId), options);

        /// <summary>
        /// Retrieves the results of a query job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The results of the query.</returns>
        public virtual BigqueryResult GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
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
        public virtual BigqueryResult ListRows(string projectId, string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRows(GetTableReference(projectId, datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table within this client's project specified by dataset ID and table ID, similar to a <c>SELECT * FROM ...</c> query.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="ListRows(TableReference, TableSchema, ListRowsOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual BigqueryResult ListRows(string datasetId, string tableId, TableSchema schema = null, ListRowsOptions options = null) =>
            ListRows(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Lists the rows within a table, similar to a <c>SELECT * FROM ...</c> query.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use when interpreting results. This may be null, in which case it will be fetched from
        /// the table first.</param>
        /// <returns>The results of listing the rows within the table.</returns>
        public virtual BigqueryResult ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
