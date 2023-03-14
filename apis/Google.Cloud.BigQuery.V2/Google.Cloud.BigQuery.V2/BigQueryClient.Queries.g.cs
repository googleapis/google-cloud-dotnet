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
    #region GetQueryResults
    /// <summary>
    /// Retrieves the results of the specified job within this client's project, which must be a query job.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation will only complete when the specified query has completed.
    /// </para>
    /// </remarks>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The results of the query.</returns>
    public virtual BigQueryResults GetQueryResults(string jobId, GetQueryResultsOptions options = null) =>
        GetQueryResults(GetJobReference(jobId), options);
    
    /// <summary>
    /// Retrieves the results of the specified job, which must be a query job.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation will only complete when the specified query has completed.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The results of the query.</returns>
    public virtual BigQueryResults GetQueryResults(string projectId, string jobId, GetQueryResultsOptions options = null) =>
        GetQueryResults(GetJobReference(projectId, jobId), options);
    
    /// <summary>
    /// Retrieves the results of the specified job, which must be a query job.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation will only complete when the specified query has completed.
    /// </para>
    /// </remarks>
    /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The results of the query.</returns>
    public virtual BigQueryResults GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously retrieves the results of the specified job within this client's project, which must be a query job.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResultsAsync(JobReference, GetQueryResultsOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation will only complete when the specified query has completed.
    /// </para>
    /// </remarks>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the results of the query.</returns>
    public virtual Task<BigQueryResults> GetQueryResultsAsync(string jobId, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default) =>
        GetQueryResultsAsync(GetJobReference(jobId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the results of the specified job, which must be a query job.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetQueryResultsAsync(JobReference, GetQueryResultsOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation will only complete when the specified query has completed.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the results of the query.</returns>
    public virtual Task<BigQueryResults> GetQueryResultsAsync(string projectId, string jobId, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default) =>
        GetQueryResultsAsync(GetJobReference(projectId, jobId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the results of the specified job, which must be a query job.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation will only complete when the specified query has completed.
    /// </para>
    /// </remarks>
    /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the results of the query.</returns>
    public virtual Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
